namespace ProjectCreation
{
    partial class FrmCreateTeamProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateTeamProject));
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.folderBrowsing = new System.Windows.Forms.FolderBrowserDialog();
            this.txtCollectionUrl = new System.Windows.Forms.TextBox();
            this.lblCollectionUrl = new System.Windows.Forms.Label();
            this.lblTextFile = new System.Windows.Forms.Label();
            this.lblLogPath = new System.Windows.Forms.Label();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.cmbProcessTemplates = new System.Windows.Forms.ComboBox();
            this.lblProcessTemplate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            resources.ApplyResources(this.btnCriar, "btnCriar");
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_click);
            // 
            // txtCaminho
            // 
            resources.ApplyResources(this.txtCaminho, "txtCaminho");
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.ReadOnly = true;
            this.txtCaminho.Click += new System.EventHandler(this.txtCaminho_Click);
            this.txtCaminho.TextChanged += new System.EventHandler(this.txtCaminho_TextChanged);
            // 
            // txtCollectionUrl
            // 
            resources.ApplyResources(this.txtCollectionUrl, "txtCollectionUrl");
            this.txtCollectionUrl.Name = "txtCollectionUrl";
            // 
            // lblCollectionUrl
            // 
            resources.ApplyResources(this.lblCollectionUrl, "lblCollectionUrl");
            this.lblCollectionUrl.Name = "lblCollectionUrl";
            // 
            // lblTextFile
            // 
            resources.ApplyResources(this.lblTextFile, "lblTextFile");
            this.lblTextFile.Name = "lblTextFile";
            // 
            // lblLogPath
            // 
            resources.ApplyResources(this.lblLogPath, "lblLogPath");
            this.lblLogPath.Name = "lblLogPath";
            // 
            // txtLogPath
            // 
            resources.ApplyResources(this.txtLogPath, "txtLogPath");
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.ReadOnly = true;
            this.txtLogPath.Click += new System.EventHandler(this.txtLogPath_Click);
            // 
            // cmbProcessTemplates
            // 
            this.cmbProcessTemplates.DisplayMember = "1";
            this.cmbProcessTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcessTemplates.FormattingEnabled = true;
            this.cmbProcessTemplates.Items.AddRange(new object[] {
            resources.GetString("cmbProcessTemplates.Items"),
            resources.GetString("cmbProcessTemplates.Items1"),
            resources.GetString("cmbProcessTemplates.Items2")});
            resources.ApplyResources(this.cmbProcessTemplates, "cmbProcessTemplates");
            this.cmbProcessTemplates.Name = "cmbProcessTemplates";
            this.cmbProcessTemplates.ValueMember = "1";
            // 
            // lblProcessTemplate
            // 
            resources.ApplyResources(this.lblProcessTemplate, "lblProcessTemplate");
            this.lblProcessTemplate.Name = "lblProcessTemplate";
            // 
            // FrmCreateTeamProject
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProcessTemplate);
            this.Controls.Add(this.cmbProcessTemplates);
            this.Controls.Add(this.lblLogPath);
            this.Controls.Add(this.txtLogPath);
            this.Controls.Add(this.lblTextFile);
            this.Controls.Add(this.lblCollectionUrl);
            this.Controls.Add(this.txtCollectionUrl);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.btnCriar);
            this.Name = "FrmCreateTeamProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.FolderBrowserDialog folderBrowsing;
        private System.Windows.Forms.TextBox txtCollectionUrl;
        private System.Windows.Forms.Label lblCollectionUrl;
        private System.Windows.Forms.Label lblTextFile;
        private System.Windows.Forms.Label lblLogPath;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.ComboBox cmbProcessTemplates;
        private System.Windows.Forms.Label lblProcessTemplate;
    }
}

