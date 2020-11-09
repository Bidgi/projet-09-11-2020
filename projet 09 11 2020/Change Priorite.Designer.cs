namespace projet_09_11_2020
{
    partial class Change_Priorite
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPremiere = new System.Windows.Forms.Button();
            this.btnDerniere = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.BtnAccueil = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectionner la tache a modifier :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selection la tache l\'emplacement :";
            // 
            // btnPremiere
            // 
            this.btnPremiere.Location = new System.Drawing.Point(222, 31);
            this.btnPremiere.Name = "btnPremiere";
            this.btnPremiere.Size = new System.Drawing.Size(180, 34);
            this.btnPremiere.TabIndex = 4;
            this.btnPremiere.Text = "Placer en premiere position";
            this.btnPremiere.UseVisualStyleBackColor = true;
            this.btnPremiere.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnDerniere
            // 
            this.btnDerniere.Location = new System.Drawing.Point(222, 71);
            this.btnDerniere.Name = "btnDerniere";
            this.btnDerniere.Size = new System.Drawing.Size(180, 34);
            this.btnDerniere.TabIndex = 5;
            this.btnDerniere.Text = "Placer en derniere position";
            this.btnDerniere.UseVisualStyleBackColor = true;
            this.btnDerniere.Click += new System.EventHandler(this.BtnDerniere_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(463, 281);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(149, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // BtnAccueil
            // 
            this.BtnAccueil.Location = new System.Drawing.Point(364, 310);
            this.BtnAccueil.Name = "BtnAccueil";
            this.BtnAccueil.Size = new System.Drawing.Size(248, 23);
            this.BtnAccueil.TabIndex = 12;
            this.BtnAccueil.Text = "Retournée a l\'accuiel";
            this.BtnAccueil.UseVisualStyleBackColor = true;
            this.BtnAccueil.Click += new System.EventHandler(this.BtnAccueil_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 238);
            this.listBox1.TabIndex = 13;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(408, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(204, 238);
            this.listBox2.TabIndex = 14;
            // 
            // Change_Priorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 351);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnAccueil);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnDerniere);
            this.Controls.Add(this.btnPremiere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Change_Priorite";
            this.Text = "Change_Priorite";
            this.Load += new System.EventHandler(this.Change_Priorite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPremiere;
        private System.Windows.Forms.Button btnDerniere;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button BtnAccueil;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}