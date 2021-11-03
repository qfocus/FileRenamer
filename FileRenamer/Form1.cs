using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using FileRenamer.Business;
using Unity;
using Microsoft.WindowsAPICodePack.Dialogs;

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

        private void BtnChooseFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtSourceFolder.Text = dialog.FileName;

                clbFiles.Items.Clear();

            }
            btnExecute.Enabled = false;
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbFiles.Items.Count; i++)
            {
                if (!clbFiles.GetItemChecked(i))
                {
                    continue;
                }

                Target instance = (Target)clbFiles.Items[i];

                string original = Path.Combine(txtSourceFolder.Text.Trim(), instance.OriginalName);
                string target = Path.Combine(txtSourceFolder.Text.Trim(), instance.TargetName);

                if (File.Exists(target))
                {
                    continue;
                }

                File.Move(original, target);
            }

            MessageBox.Show("重命名完成！", "重命名完成！", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            checkAll.Checked = false;
            PreView();
        }

        private void PreView()
        {
            if (!IsValid())
            {
                btnExecute.Enabled = false;
                return;
            }

            clbFiles.Items.Clear();

            ChooseRenamer();

            var files = Directory.GetFiles(txtSourceFolder.Text);

            foreach (var item in files)
            {
                string originName = Path.GetFileName(item);

                string newName = Rename(originName);

                Target target = new Target(originName, newName);

                clbFiles.Items.Add(target, false);
            }

            btnExecute.Enabled = true;

        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(txtSourceFolder.Text) || !Directory.Exists(txtSourceFolder.Text.Trim()))
            {
                MessageBox.Show("目标文件夹不存在！", "输入错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtOldCharacter.Text))
            {
                MessageBox.Show("删除字符为空，请重新输入！", "输入错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (rbReplace.Checked && string.IsNullOrEmpty(txtNewCharacter.Text))
            {
                MessageBox.Show("替换字符为空，请重新输入！", "输入错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Directory.GetFiles(txtSourceFolder.Text).Length == 0)
            {
                MessageBox.Show("目标文件夹为空！", "输入错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            for (int i = 0; i < clbFiles.Items.Count; i++)
            {
                clbFiles.SetItemChecked(i, checkAll.Checked); ;
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

            return renamer.Rename(name, txtOldCharacter.Text.Trim(), txtNewCharacter.Text.Trim());

        }
    }
}