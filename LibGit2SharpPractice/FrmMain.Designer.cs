namespace LibGit2SharpPractice
{
    partial class FrmMain
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
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.fbdGitFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.ofdGitFile = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnRm = new System.Windows.Forms.Button();
            this.btnFileUndo = new System.Windows.Forms.Button();
            this.btnRemote = new System.Windows.Forms.Button();
            this.btnRemoteAdd = new System.Windows.Forms.Button();
            this.txtRemoteName = new System.Windows.Forms.TextBox();
            this.txtRemoteUrl = new System.Windows.Forms.TextBox();
            this.btnFetch = new System.Windows.Forms.Button();
            this.cbRemoteName = new System.Windows.Forms.ComboBox();
            this.btnBranch = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.cbBranches = new System.Windows.Forms.ComboBox();
            this.btnBranchAdd = new System.Windows.Forms.Button();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(13, 13);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(13, 43);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 1;
            this.btnInit.Text = "git init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(13, 73);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "Choose file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(95, 73);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(206, 22);
            this.txtFilePath.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "git add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(13, 133);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 5;
            this.btnCommit.Text = "git commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(95, 133);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(206, 22);
            this.txtComment.TabIndex = 6;
            this.txtComment.Text = "Here\'s a Comment";
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(13, 163);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(75, 23);
            this.btnClone.TabIndex = 7;
            this.btnClone.Text = "git clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(95, 163);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(206, 22);
            this.txtUrl.TabIndex = 8;
            this.txtUrl.Text = "https://github.com/fo40225/HelloGit.git";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(13, 193);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 9;
            this.btnStatus.Text = "git status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnRm
            // 
            this.btnRm.Location = new System.Drawing.Point(13, 223);
            this.btnRm.Name = "btnRm";
            this.btnRm.Size = new System.Drawing.Size(75, 23);
            this.btnRm.TabIndex = 10;
            this.btnRm.Text = "git rm";
            this.btnRm.UseVisualStyleBackColor = true;
            this.btnRm.Click += new System.EventHandler(this.btnRm_Click);
            // 
            // btnFileUndo
            // 
            this.btnFileUndo.Location = new System.Drawing.Point(13, 253);
            this.btnFileUndo.Name = "btnFileUndo";
            this.btnFileUndo.Size = new System.Drawing.Size(75, 23);
            this.btnFileUndo.TabIndex = 11;
            this.btnFileUndo.Text = "FileUndo";
            this.btnFileUndo.UseVisualStyleBackColor = true;
            this.btnFileUndo.Click += new System.EventHandler(this.btnFileUndo_Click);
            // 
            // btnRemote
            // 
            this.btnRemote.Location = new System.Drawing.Point(13, 283);
            this.btnRemote.Name = "btnRemote";
            this.btnRemote.Size = new System.Drawing.Size(75, 23);
            this.btnRemote.TabIndex = 12;
            this.btnRemote.Text = "git remote";
            this.btnRemote.UseVisualStyleBackColor = true;
            this.btnRemote.Click += new System.EventHandler(this.btnRemote_Click);
            // 
            // btnRemoteAdd
            // 
            this.btnRemoteAdd.Location = new System.Drawing.Point(13, 313);
            this.btnRemoteAdd.Name = "btnRemoteAdd";
            this.btnRemoteAdd.Size = new System.Drawing.Size(80, 23);
            this.btnRemoteAdd.TabIndex = 13;
            this.btnRemoteAdd.Text = "git remote add";
            this.btnRemoteAdd.UseVisualStyleBackColor = true;
            this.btnRemoteAdd.Click += new System.EventHandler(this.btnRemoteAdd_Click);
            // 
            // txtRemoteName
            // 
            this.txtRemoteName.Location = new System.Drawing.Point(95, 314);
            this.txtRemoteName.Name = "txtRemoteName";
            this.txtRemoteName.Size = new System.Drawing.Size(100, 22);
            this.txtRemoteName.TabIndex = 14;
            this.txtRemoteName.Text = "RemoteName";
            // 
            // txtRemoteUrl
            // 
            this.txtRemoteUrl.Location = new System.Drawing.Point(201, 313);
            this.txtRemoteUrl.Name = "txtRemoteUrl";
            this.txtRemoteUrl.Size = new System.Drawing.Size(100, 22);
            this.txtRemoteUrl.TabIndex = 15;
            this.txtRemoteUrl.Text = "https://github.com/fo40225/HelloGit.git";
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(13, 343);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 16;
            this.btnFetch.Text = "git fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // cbRemoteName
            // 
            this.cbRemoteName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemoteName.FormattingEnabled = true;
            this.cbRemoteName.Location = new System.Drawing.Point(94, 345);
            this.cbRemoteName.Name = "cbRemoteName";
            this.cbRemoteName.Size = new System.Drawing.Size(121, 20);
            this.cbRemoteName.TabIndex = 17;
            // 
            // btnBranch
            // 
            this.btnBranch.Location = new System.Drawing.Point(13, 373);
            this.btnBranch.Name = "btnBranch";
            this.btnBranch.Size = new System.Drawing.Size(75, 23);
            this.btnBranch.TabIndex = 18;
            this.btnBranch.Text = "git branch";
            this.btnBranch.UseVisualStyleBackColor = true;
            this.btnBranch.Click += new System.EventHandler(this.btnBranch_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(12, 436);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 19;
            this.btnCheckout.Text = "git checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // cbBranches
            // 
            this.cbBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBranches.FormattingEnabled = true;
            this.cbBranches.Location = new System.Drawing.Point(99, 452);
            this.cbBranches.Name = "cbBranches";
            this.cbBranches.Size = new System.Drawing.Size(121, 20);
            this.cbBranches.TabIndex = 20;
            // 
            // btnBranchAdd
            // 
            this.btnBranchAdd.Location = new System.Drawing.Point(13, 403);
            this.btnBranchAdd.Name = "btnBranchAdd";
            this.btnBranchAdd.Size = new System.Drawing.Size(80, 23);
            this.btnBranchAdd.TabIndex = 21;
            this.btnBranchAdd.Text = "git branch add";
            this.btnBranchAdd.UseVisualStyleBackColor = true;
            this.btnBranchAdd.Click += new System.EventHandler(this.btnBranchAdd_Click);
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(99, 405);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(100, 22);
            this.txtBranchName.TabIndex = 22;
            this.txtBranchName.Text = "BranchName";
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(13, 466);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 23);
            this.btnMerge.TabIndex = 23;
            this.btnMerge.Text = "git merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.btnBranchAdd);
            this.Controls.Add(this.cbBranches);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnBranch);
            this.Controls.Add(this.cbRemoteName);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.txtRemoteUrl);
            this.Controls.Add(this.txtRemoteName);
            this.Controls.Add(this.btnRemoteAdd);
            this.Controls.Add(this.btnRemote);
            this.Controls.Add(this.btnFileUndo);
            this.Controls.Add(this.btnRm);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnSelectFolder);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select repo folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdGitFolder;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.OpenFileDialog ofdGitFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnRm;
        private System.Windows.Forms.Button btnFileUndo;
        private System.Windows.Forms.Button btnRemote;
        private System.Windows.Forms.Button btnRemoteAdd;
        private System.Windows.Forms.TextBox txtRemoteName;
        private System.Windows.Forms.TextBox txtRemoteUrl;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.ComboBox cbRemoteName;
        private System.Windows.Forms.Button btnBranch;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.ComboBox cbBranches;
        private System.Windows.Forms.Button btnBranchAdd;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Button btnMerge;
    }
}

