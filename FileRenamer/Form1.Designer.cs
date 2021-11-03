namespace FileRenamer.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldCharacter = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewCharacter = new System.Windows.Forms.TextBox();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.rbReplace = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbIsRegex = new System.Windows.Forms.CheckBox();
            this.clbFiles = new System.Windows.Forms.CheckedListBox();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(13, 11);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(99, 19);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "文件夹";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.BtnChooseFolder_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(559, 550);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 19);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "执行";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 11);
            this.label1.TabIndex = 3;
            this.label1.Text = "删除字符：";
            // 
            // txtOldCharacter
            // 
            this.txtOldCharacter.Location = new System.Drawing.Point(192, 66);
            this.txtOldCharacter.Name = "txtOldCharacter";
            this.txtOldCharacter.Size = new System.Drawing.Size(376, 20);
            this.txtOldCharacter.TabIndex = 5;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(452, 550);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 19);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "预览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.Preview_Click);
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(119, 11);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.ReadOnly = true;
            this.txtSourceFolder.Size = new System.Drawing.Size(513, 20);
            this.txtSourceFolder.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 11);
            this.label5.TabIndex = 3;
            this.label5.Text = "替换字符：";
            // 
            // txtNewCharacter
            // 
            this.txtNewCharacter.Enabled = false;
            this.txtNewCharacter.Location = new System.Drawing.Point(192, 105);
            this.txtNewCharacter.Name = "txtNewCharacter";
            this.txtNewCharacter.Size = new System.Drawing.Size(376, 20);
            this.txtNewCharacter.TabIndex = 5;
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Checked = true;
            this.rbDelete.Location = new System.Drawing.Point(10, 19);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(67, 15);
            this.rbDelete.TabIndex = 11;
            this.rbDelete.TabStop = true;
            this.rbDelete.Tag = "RemoveCharacter";
            this.rbDelete.Text = "删除字符";
            this.rbDelete.UseVisualStyleBackColor = true;
            this.rbDelete.CheckedChanged += new System.EventHandler(this.RenameType_Changed);
            // 
            // rbReplace
            // 
            this.rbReplace.AutoSize = true;
            this.rbReplace.Location = new System.Drawing.Point(10, 57);
            this.rbReplace.Name = "rbReplace";
            this.rbReplace.Size = new System.Drawing.Size(67, 15);
            this.rbReplace.TabIndex = 12;
            this.rbReplace.TabStop = true;
            this.rbReplace.Tag = "ReplaceCharacter";
            this.rbReplace.Text = "替换字符";
            this.rbReplace.UseVisualStyleBackColor = true;
            this.rbReplace.CheckedChanged += new System.EventHandler(this.RenameType_Changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDelete);
            this.groupBox1.Controls.Add(this.rbReplace);
            this.groupBox1.Location = new System.Drawing.Point(13, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 91);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "重命名类型";
            // 
            // cbIsRegex
            // 
            this.cbIsRegex.AutoSize = true;
            this.cbIsRegex.Location = new System.Drawing.Point(576, 69);
            this.cbIsRegex.Name = "cbIsRegex";
            this.cbIsRegex.Size = new System.Drawing.Size(46, 15);
            this.cbIsRegex.TabIndex = 14;
            this.cbIsRegex.Text = "正则";
            this.cbIsRegex.UseVisualStyleBackColor = true;
            // 
            // clbFiles
            // 
            this.clbFiles.CheckOnClick = true;
            this.clbFiles.FormattingEnabled = true;
            this.clbFiles.Location = new System.Drawing.Point(13, 160);
            this.clbFiles.Name = "clbFiles";
            this.clbFiles.Size = new System.Drawing.Size(619, 349);
            this.clbFiles.TabIndex = 15;
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Location = new System.Drawing.Point(586, 520);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(46, 15);
            this.checkAll.TabIndex = 16;
            this.checkAll.Text = "全选";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.CheckedChanged += new System.EventHandler(this.CheckAll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 581);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.clbFiles);
            this.Controls.Add(this.cbIsRegex);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.txtNewCharacter);
            this.Controls.Add(this.txtOldCharacter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnChooseFolder);
            this.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量文件名修改器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChooseFolder;        
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldCharacter;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewCharacter;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.RadioButton rbReplace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbIsRegex;
        private System.Windows.Forms.CheckedListBox clbFiles;
        private System.Windows.Forms.CheckBox checkAll;
    }
}

