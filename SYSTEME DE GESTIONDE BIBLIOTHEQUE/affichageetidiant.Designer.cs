namespace SYSTEME_DE_GESTIONDE_BIBLIOTHEQUE
{
    partial class affichageetidiant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttrafrich = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butdelt = new System.Windows.Forms.Button();
            this.butupdate = new System.Windows.Forms.Button();
            this.butexit = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textsem = new System.Windows.Forms.TextBox();
            this.textcant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texNO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textDEP = new System.Windows.Forms.TextBox();
            this.textnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1423, 117);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1410, 335);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(405, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttrafrich
            // 
            this.buttrafrich.Location = new System.Drawing.Point(777, 140);
            this.buttrafrich.Name = "buttrafrich";
            this.buttrafrich.Size = new System.Drawing.Size(111, 40);
            this.buttrafrich.TabIndex = 4;
            this.buttrafrich.Text = "Refrech";
            this.buttrafrich.UseVisualStyleBackColor = true;
            this.buttrafrich.Click += new System.EventHandler(this.buttrafrich_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.butdelt);
            this.panel2.Controls.Add(this.butupdate);
            this.panel2.Controls.Add(this.butexit);
            this.panel2.Controls.Add(this.textEmail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textsem);
            this.panel2.Controls.Add(this.textcant);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.texNO);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textDEP);
            this.panel2.Controls.Add(this.textnom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 567);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1410, 323);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // butdelt
            // 
            this.butdelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdelt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butdelt.Location = new System.Drawing.Point(704, 264);
            this.butdelt.Name = "butdelt";
            this.butdelt.Size = new System.Drawing.Size(75, 36);
            this.butdelt.TabIndex = 59;
            this.butdelt.Text = "Delete";
            this.butdelt.UseVisualStyleBackColor = true;
            this.butdelt.Click += new System.EventHandler(this.butdelt_Click);
            // 
            // butupdate
            // 
            this.butupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butupdate.Location = new System.Drawing.Point(560, 264);
            this.butupdate.Name = "butupdate";
            this.butupdate.Size = new System.Drawing.Size(75, 36);
            this.butupdate.TabIndex = 58;
            this.butupdate.Text = "update";
            this.butupdate.UseVisualStyleBackColor = true;
            this.butupdate.Click += new System.EventHandler(this.butupdate_Click);
            // 
            // butexit
            // 
            this.butexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butexit.Location = new System.Drawing.Point(852, 264);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(75, 36);
            this.butexit.TabIndex = 57;
            this.butexit.Text = "Cancel";
            this.butexit.UseVisualStyleBackColor = true;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(961, 183);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(279, 22);
            this.textEmail.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(768, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Email";
            // 
            // textsem
            // 
            this.textsem.Location = new System.Drawing.Point(961, 69);
            this.textsem.Name = "textsem";
            this.textsem.Size = new System.Drawing.Size(279, 22);
            this.textsem.TabIndex = 54;
            // 
            // textcant
            // 
            this.textcant.Location = new System.Drawing.Point(961, 123);
            this.textcant.Name = "textcant";
            this.textcant.Size = new System.Drawing.Size(279, 22);
            this.textcant.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(767, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 52;
            this.label6.Text = "Contact etudiant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(768, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Semestre d\'etudes";
            // 
            // texNO
            // 
            this.texNO.Location = new System.Drawing.Point(281, 134);
            this.texNO.Name = "texNO";
            this.texNO.Size = new System.Drawing.Size(279, 22);
            this.texNO.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(87, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 18);
            this.label9.TabIndex = 49;
            this.label9.Text = "Numero d\'inscription";
            // 
            // textDEP
            // 
            this.textDEP.Location = new System.Drawing.Point(281, 203);
            this.textDEP.Name = "textDEP";
            this.textDEP.Size = new System.Drawing.Size(279, 22);
            this.textDEP.TabIndex = 48;
            // 
            // textnom
            // 
            this.textnom.Location = new System.Drawing.Point(281, 63);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(279, 22);
            this.textnom.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(88, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "Departement ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(88, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Nom de etudient";
            // 
            // affichageetidiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 891);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttrafrich);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "affichageetidiant";
            this.Text = "affichageetidiant";
            this.Load += new System.EventHandler(this.affichageetidiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttrafrich;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox texNO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDEP;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textsem;
        private System.Windows.Forms.TextBox textcant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butdelt;
        private System.Windows.Forms.Button butupdate;
        private System.Windows.Forms.Button butexit;
    }
}