namespace SYSTEME_DE_GESTIONDE_BIBLIOTHEQUE
{
    partial class ajouterlivre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajouterlivre));
            this.butajouter = new System.Windows.Forms.Button();
            this.butexit = new System.Windows.Forms.Button();
            this.datelivre = new System.Windows.Forms.DateTimePicker();
            this.textpub = new System.Windows.Forms.TextBox();
            this.textquan = new System.Windows.Forms.TextBox();
            this.textprix = new System.Windows.Forms.TextBox();
            this.textauteur = new System.Windows.Forms.TextBox();
            this.textnom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // butajouter
            // 
            this.butajouter.BackColor = System.Drawing.Color.PeachPuff;
            this.butajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butajouter.Location = new System.Drawing.Point(707, 539);
            this.butajouter.Name = "butajouter";
            this.butajouter.Size = new System.Drawing.Size(119, 36);
            this.butajouter.TabIndex = 27;
            this.butajouter.Text = "Save";
            this.butajouter.UseVisualStyleBackColor = false;
            this.butajouter.Click += new System.EventHandler(this.butajouter_Click);
            // 
            // butexit
            // 
            this.butexit.BackColor = System.Drawing.Color.PeachPuff;
            this.butexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butexit.Location = new System.Drawing.Point(894, 539);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(116, 36);
            this.butexit.TabIndex = 26;
            this.butexit.Text = "Cancel";
            this.butexit.UseVisualStyleBackColor = false;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // datelivre
            // 
            this.datelivre.Location = new System.Drawing.Point(684, 332);
            this.datelivre.Name = "datelivre";
            this.datelivre.Size = new System.Drawing.Size(200, 22);
            this.datelivre.TabIndex = 25;
            // 
            // textpub
            // 
            this.textpub.Location = new System.Drawing.Point(684, 279);
            this.textpub.Name = "textpub";
            this.textpub.Size = new System.Drawing.Size(200, 22);
            this.textpub.TabIndex = 24;
            // 
            // textquan
            // 
            this.textquan.Location = new System.Drawing.Point(684, 482);
            this.textquan.Name = "textquan";
            this.textquan.Size = new System.Drawing.Size(200, 22);
            this.textquan.TabIndex = 23;
            // 
            // textprix
            // 
            this.textprix.Location = new System.Drawing.Point(684, 404);
            this.textprix.Name = "textprix";
            this.textprix.Size = new System.Drawing.Size(200, 22);
            this.textprix.TabIndex = 22;
            // 
            // textauteur
            // 
            this.textauteur.Location = new System.Drawing.Point(684, 214);
            this.textauteur.Name = "textauteur";
            this.textauteur.Size = new System.Drawing.Size(200, 22);
            this.textauteur.TabIndex = 21;
            // 
            // textnom
            // 
            this.textnom.Location = new System.Drawing.Point(684, 156);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(200, 22);
            this.textnom.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quantite de Livre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Prix du Livre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date d\'achat du Livre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Publication de Livres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nom de l\'auteur du livre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nom de Livre";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(401, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 138);
            this.panel3.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(401, 610);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Snap ITC", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 48);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ajouter un Livre";
            // 
            // ajouterlivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1128, 606);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.butajouter);
            this.Controls.Add(this.butexit);
            this.Controls.Add(this.datelivre);
            this.Controls.Add(this.textpub);
            this.Controls.Add(this.textquan);
            this.Controls.Add(this.textprix);
            this.Controls.Add(this.textauteur);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ajouterlivre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ajouterlivre";
            this.Load += new System.EventHandler(this.ajouterlivre_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butajouter;
        private System.Windows.Forms.Button butexit;
        private System.Windows.Forms.DateTimePicker datelivre;
        private System.Windows.Forms.TextBox textpub;
        private System.Windows.Forms.TextBox textquan;
        private System.Windows.Forms.TextBox textprix;
        private System.Windows.Forms.TextBox textauteur;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
    }
}