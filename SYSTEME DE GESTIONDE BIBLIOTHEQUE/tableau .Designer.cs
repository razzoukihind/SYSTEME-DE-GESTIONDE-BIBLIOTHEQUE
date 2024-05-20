namespace SYSTEME_DE_GESTIONDE_BIBLIOTHEQUE
{
    partial class tableau
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tableau));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lIversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnNouveauLiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLesLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnEtudientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLesInformationSurLesEtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liversDePublicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retournerLesLiversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailCompletDuLiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lIversToolStripMenuItem,
            this.etudiantToolStripMenuItem,
            this.liversDePublicationToolStripMenuItem,
            this.retournerLesLiversToolStripMenuItem,
            this.detailCompletDuLiverToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1492, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lIversToolStripMenuItem
            // 
            this.lIversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnNouveauLiverToolStripMenuItem,
            this.voirLesLivresToolStripMenuItem});
            this.lIversToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lIversToolStripMenuItem.Image")));
            this.lIversToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lIversToolStripMenuItem.Name = "lIversToolStripMenuItem";
            this.lIversToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.lIversToolStripMenuItem.Text = "LIvers";
            this.lIversToolStripMenuItem.Click += new System.EventHandler(this.lIversToolStripMenuItem_Click);
            // 
            // ajouterUnNouveauLiverToolStripMenuItem
            // 
            this.ajouterUnNouveauLiverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterUnNouveauLiverToolStripMenuItem.Image")));
            this.ajouterUnNouveauLiverToolStripMenuItem.Name = "ajouterUnNouveauLiverToolStripMenuItem";
            this.ajouterUnNouveauLiverToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.ajouterUnNouveauLiverToolStripMenuItem.Text = "Ajouter un nouveau livre";
            this.ajouterUnNouveauLiverToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnNouveauLiverToolStripMenuItem_Click);
            // 
            // voirLesLivresToolStripMenuItem
            // 
            this.voirLesLivresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("voirLesLivresToolStripMenuItem.Image")));
            this.voirLesLivresToolStripMenuItem.Name = "voirLesLivresToolStripMenuItem";
            this.voirLesLivresToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.voirLesLivresToolStripMenuItem.Text = "Voir les livres";
            this.voirLesLivresToolStripMenuItem.Click += new System.EventHandler(this.voirLesLivresToolStripMenuItem_Click);
            // 
            // etudiantToolStripMenuItem
            // 
            this.etudiantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnEtudientToolStripMenuItem,
            this.voirLesInformationSurLesEtudiantsToolStripMenuItem});
            this.etudiantToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("etudiantToolStripMenuItem.Image")));
            this.etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.etudiantToolStripMenuItem.Text = "Etudiants";
            // 
            // ajouterUnEtudientToolStripMenuItem
            // 
            this.ajouterUnEtudientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterUnEtudientToolStripMenuItem.Image")));
            this.ajouterUnEtudientToolStripMenuItem.Name = "ajouterUnEtudientToolStripMenuItem";
            this.ajouterUnEtudientToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.ajouterUnEtudientToolStripMenuItem.Text = "Ajouter un etudient";
            this.ajouterUnEtudientToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnEtudientToolStripMenuItem_Click);
            // 
            // voirLesInformationSurLesEtudiantsToolStripMenuItem
            // 
            this.voirLesInformationSurLesEtudiantsToolStripMenuItem.Name = "voirLesInformationSurLesEtudiantsToolStripMenuItem";
            this.voirLesInformationSurLesEtudiantsToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.voirLesInformationSurLesEtudiantsToolStripMenuItem.Text = "Voir les information sur les etudiants";
            this.voirLesInformationSurLesEtudiantsToolStripMenuItem.Click += new System.EventHandler(this.voirLesInformationSurLesEtudiantsToolStripMenuItem_Click);
            // 
            // liversDePublicationToolStripMenuItem
            // 
            this.liversDePublicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("liversDePublicationToolStripMenuItem.Image")));
            this.liversDePublicationToolStripMenuItem.Name = "liversDePublicationToolStripMenuItem";
            this.liversDePublicationToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.liversDePublicationToolStripMenuItem.Text = "Livers de Publication";
            this.liversDePublicationToolStripMenuItem.Click += new System.EventHandler(this.liversDePublicationToolStripMenuItem_Click);
            // 
            // retournerLesLiversToolStripMenuItem
            // 
            this.retournerLesLiversToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retournerLesLiversToolStripMenuItem.Image")));
            this.retournerLesLiversToolStripMenuItem.Name = "retournerLesLiversToolStripMenuItem";
            this.retournerLesLiversToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.retournerLesLiversToolStripMenuItem.Text = "Retourner les Livers";
            this.retournerLesLiversToolStripMenuItem.Click += new System.EventHandler(this.retournerLesLiversToolStripMenuItem_Click);
            // 
            // detailCompletDuLiverToolStripMenuItem
            // 
            this.detailCompletDuLiverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detailCompletDuLiverToolStripMenuItem.Image")));
            this.detailCompletDuLiverToolStripMenuItem.Name = "detailCompletDuLiverToolStripMenuItem";
            this.detailCompletDuLiverToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.detailCompletDuLiverToolStripMenuItem.Text = "Detail Complet du Liver";
            this.detailCompletDuLiverToolStripMenuItem.Click += new System.EventHandler(this.detailCompletDuLiverToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1492, 591);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "tableau";
            this.Text = "tableau";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tableau_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lIversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liversDePublicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retournerLesLiversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailCompletDuLiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnNouveauLiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLesLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLesInformationSurLesEtudiantsToolStripMenuItem;
    }
}