namespace SYSTEME_DE_GESTIONDE_BIBLIOTHEQUE
{
    partial class affichagelivre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(affichagelivre));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textrech = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butdelet = new System.Windows.Forms.Button();
            this.butupdate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 205);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(145, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 22);
            this.label12.TabIndex = 7;
            this.label12.Text = "affichage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(937, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de Livre";
            // 
            // textrech
            // 
            this.textrech.Location = new System.Drawing.Point(522, 219);
            this.textrech.Name = "textrech";
            this.textrech.Size = new System.Drawing.Size(220, 22);
            this.textrech.TabIndex = 2;
            this.textrech.TextChanged += new System.EventHandler(this.textrech_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(803, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "recherche";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.TextChanged += new System.EventHandler(this.button1_TextChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1335, 224);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.butdelet);
            this.panel3.Controls.Add(this.butupdate);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.butajouter);
            this.panel3.Controls.Add(this.butexit);
            this.panel3.Controls.Add(this.datelivre);
            this.panel3.Controls.Add(this.textpub);
            this.panel3.Controls.Add(this.textquan);
            this.panel3.Controls.Add(this.textprix);
            this.panel3.Controls.Add(this.textauteur);
            this.panel3.Controls.Add(this.textnom);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 513);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1335, 360);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // butdelet
            // 
            this.butdelet.BackColor = System.Drawing.Color.Bisque;
            this.butdelet.Location = new System.Drawing.Point(876, 283);
            this.butdelet.Name = "butdelet";
            this.butdelet.Size = new System.Drawing.Size(119, 51);
            this.butdelet.TabIndex = 32;
            this.butdelet.Text = "Delete";
            this.butdelet.UseVisualStyleBackColor = false;
            this.butdelet.Click += new System.EventHandler(this.butdelet_Click);
            // 
            // butupdate
            // 
            this.butupdate.BackColor = System.Drawing.Color.Bisque;
            this.butupdate.Location = new System.Drawing.Point(730, 283);
            this.butupdate.Name = "butupdate";
            this.butupdate.Size = new System.Drawing.Size(119, 51);
            this.butupdate.TabIndex = 31;
            this.butupdate.Text = "update";
            this.butupdate.UseVisualStyleBackColor = false;
            this.butupdate.Click += new System.EventHandler(this.butupdate_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Bisque;
            this.button3.Location = new System.Drawing.Point(1023, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 51);
            this.button3.TabIndex = 30;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(275, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 24);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Nom de  livre";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // butajouter
            // 
            this.butajouter.Location = new System.Drawing.Point(481, 373);
            this.butajouter.Name = "butajouter";
            this.butajouter.Size = new System.Drawing.Size(75, 23);
            this.butajouter.TabIndex = 27;
            this.butajouter.Text = "Save";
            this.butajouter.UseVisualStyleBackColor = true;
            // 
            // butexit
            // 
            this.butexit.Location = new System.Drawing.Point(774, 373);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(75, 23);
            this.butexit.TabIndex = 26;
            this.butexit.Text = "Cancel";
            this.butexit.UseVisualStyleBackColor = true;
            // 
            // datelivre
            // 
            this.datelivre.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.datelivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelivre.Location = new System.Drawing.Point(261, 182);
            this.datelivre.Name = "datelivre";
            this.datelivre.Size = new System.Drawing.Size(257, 24);
            this.datelivre.TabIndex = 25;
            this.datelivre.ValueChanged += new System.EventHandler(this.datelivre_ValueChanged);
            // 
            // textpub
            // 
            this.textpub.BackColor = System.Drawing.Color.PeachPuff;
            this.textpub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpub.Location = new System.Drawing.Point(819, 40);
            this.textpub.Name = "textpub";
            this.textpub.Size = new System.Drawing.Size(279, 24);
            this.textpub.TabIndex = 24;
            this.textpub.TextChanged += new System.EventHandler(this.textpub_TextChanged);
            // 
            // textquan
            // 
            this.textquan.BackColor = System.Drawing.Color.PeachPuff;
            this.textquan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textquan.Location = new System.Drawing.Point(819, 182);
            this.textquan.Name = "textquan";
            this.textquan.Size = new System.Drawing.Size(279, 24);
            this.textquan.TabIndex = 23;
            this.textquan.TextChanged += new System.EventHandler(this.textquan_TextChanged);
            // 
            // textprix
            // 
            this.textprix.BackColor = System.Drawing.Color.PeachPuff;
            this.textprix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textprix.Location = new System.Drawing.Point(819, 112);
            this.textprix.Name = "textprix";
            this.textprix.Size = new System.Drawing.Size(279, 24);
            this.textprix.TabIndex = 22;
            this.textprix.TextChanged += new System.EventHandler(this.textprix_TextChanged);
            // 
            // textauteur
            // 
            this.textauteur.BackColor = System.Drawing.Color.PeachPuff;
            this.textauteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textauteur.Location = new System.Drawing.Point(273, 116);
            this.textauteur.Name = "textauteur";
            this.textauteur.Size = new System.Drawing.Size(245, 24);
            this.textauteur.TabIndex = 21;
            this.textauteur.TextChanged += new System.EventHandler(this.textauteur_TextChanged);
            // 
            // textnom
            // 
            this.textnom.Location = new System.Drawing.Point(456, -40);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(100, 24);
            this.textnom.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(555, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quantite de Livre";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Prix du Livre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date d\'achat du Livre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Publication de Livres";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nom de l\'auteur du livre";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, -34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nom de Livre";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(888, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(472, 205);
            this.panel4.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "de Livre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(937, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "label10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(480, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // affichagelivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1359, 848);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textrech);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "affichagelivre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "affichagelivre";
            this.Load += new System.EventHandler(this.affichagelivre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textrech;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button butdelet;
        private System.Windows.Forms.Button butupdate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}