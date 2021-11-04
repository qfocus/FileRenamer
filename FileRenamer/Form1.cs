using System;
using System.Windows.Forms;
using System.IO;
using Unity;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Drawing;

namespace FileRenamer.UI
{
    public partial class Form1 : Form
    {

        private IUnityContainer container;

        ICharacterRenamer renamer;

        public Form1(IUnityContainer container)
        {
            this.container = container;

            InitializeComponent();
        }

        private void ChooseFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtSourceFolder.Text = dialog.FileName;

                if (SourceReady())
                {
                    targetFiles.Items.Clear();

                    LoadFiles();

                    btnExecute.Enabled = false;
                }
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < targetFiles.Items.Count; i++)
            {
                if (!targetFiles.GetItemChecked(i))
                {
                    continue;
                }

                Target instance = (Target)targetFiles.Items[i];

                string original = Path.Combine(txtSourceFolder.Text.Trim(), instance.OriginalName);
                string target = Path.Combine(txtSourceFolder.Text.Trim(), instance.TargetName);

                if (File.Exists(target))
                {
                    log.Items.Add(Path.GetFileName(original) + "重命名失败！ 文件已存在！");
                    continue;
                }
                try
                {
                    File.Move(original, target);
                    //log.Items.Add(Path.GetFileName(original) + "重命名完成！");
                }
                catch (IOException ex)
                {
                    ListViewItem item = new ListViewItem
                    {
                        Text = Path.GetFileName(original) + "重命名失败！ 文件被占用！",
                        ForeColor = Color.Red
                    };
                    log.Items.Add(item);
                }
            }

            Reset();

            MessageBox.Show("重命名完成！", "重命名完成！", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            if (!ConditionReady())
            {
                btnExecute.Enabled = false;
                return;
            }

            ChooseRenamer();

            btnExecute.Enabled = true;

            RenamePreview();
        }

        private bool SourceReady()
        {
            if (string.IsNullOrEmpty(txtSourceFolder.Text) || !Directory.Exists(txtSourceFolder.Text.Trim()))
            {
                this.lblMessage.Text = "目标文件夹不存在！";
                return false;
            }

            if (Directory.GetFiles(txtSourceFolder.Text).Length == 0)
            {
                this.lblMessage.Text = "目标文件夹为空！";
                return false;
            }

            return true;
        }


        private void LoadFiles()
        {
            var files = Directory.GetFiles(txtSourceFolder.Text);

            targetFiles.Items.Clear();

            foreach (var item in files)
            {
                string originName = Path.GetFileName(item);

                Target target = new Target(originName, originName);

                targetFiles.Items.Add(target, false);
            }
        }


        private void RenamePreview()
        {
            for (int i = 0; i < targetFiles.Items.Count; i++)
            {
                if (!targetFiles.GetItemChecked(i))
                {
                    continue;
                }

                Target target = (Target)targetFiles.Items[i];

                target.TargetName = Rename(target.OriginalName);

                targetFiles.Items[i] = target;
            }
        }



        private bool ConditionReady()
        {
            if (rbDelete.Checked && string.IsNullOrEmpty(txtOldCharacter.Text))
            {
                lblMessage.Text = "删除字符为空，请重新输入！";
                return false;
            }


            if (rbReplace.Checked && string.IsNullOrEmpty(txtOldCharacter.Text))
            {
                lblMessage.Text = "目标字符为空，请重新输入！";
                return false;
            }

            if (rbReplace.Checked && string.IsNullOrEmpty(txtNewCharacter.Text))
            {
                lblMessage.Text = "替换字符为空，请重新输入！";
                return false;
            }


            lblMessage.Text = String.Empty;

            return true;
        }



        private bool IsValid()
        {
            if (string.IsNullOrEmpty(txtSourceFolder.Text) || !Directory.Exists(txtSourceFolder.Text.Trim()))
            {
                MessageBox.Show("目标文件夹不存在！", "输入错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Directory.GetFiles(txtSourceFolder.Text).Length == 0)
            {
                MessageBox.Show("目标文件夹为空！", "输入错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtOldCharacter.Text))
            {
                MessageBox.Show("删除字符为空，请重新输入！", "输入错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void RenameType_Changed(object sender, EventArgs e)
        {
            this.txtNewCharacter.Enabled = rbReplace.Checked;
            this.btnExecute.Enabled = false;
        }

        private void CheckAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < targetFiles.Items.Count; i++)
            {
                targetFiles.SetItemChecked(i, checkAll.Checked); ;
            }

        }

        private void ChooseRenamer()
        {
            if (cbIsRegex.Checked)
            {
                this.renamer = container.Resolve<ICharacterRenamer>("RegexRenamer");
            }
            else
            {
                this.renamer = container.Resolve<ICharacterRenamer>("GeneralRenamer");
            }

        }

        private string Rename(string name)
        {
            if (rbDelete.Checked)
            {
                return renamer.Delete(name, txtOldCharacter.Text.Trim());
            }
            else if (rbReplace.Checked)
            {
                return renamer.Rename(name, txtOldCharacter.Text.Trim(), txtNewCharacter.Text.Trim());
            }
            else if (rbToUpper.Checked)
            {
                return renamer.ToUpper(name);
            }

            return renamer.ToLower(name);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            LoadFiles();

            checkAll.Checked = false;
            btnExecute.Enabled = false;
        }
    }
}