namespace projet_09_11_2020
{
    partial class SupprimerTache
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
            this.BtnValide = new System.Windows.Forms.Button();
            this.BtnAccueil = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectionner la tache a supprimer :";
            // 
            // BtnValide
            // 
            this.BtnValide.Location = new System.Drawing.Point(130, 272);
            this.BtnValide.Name = "BtnValide";
            this.BtnValide.Size = new System.Drawing.Size(117, 23);
            this.BtnValide.TabIndex = 3;
            this.BtnValide.Text = "Valider la suppretion";
            this.BtnValide.UseVisualStyleBackColor = true;
            this.BtnValide.Click += new System.EventHandler(this.BtnValide_Click);
            // 
            // BtnAccueil
            // 
            this.BtnAccueil.Location = new System.Drawing.Point(12, 301);
            this.BtnAccueil.Name = "BtnAccueil";
            this.BtnAccueil.Size = new System.Drawing.Size(235, 23);
            this.BtnAccueil.TabIndex = 11;
            this.BtnAccueil.Text = "Retournée a l\'accuiel";
            this.BtnAccueil.UseVisualStyleBackColor = true;
            this.BtnAccueil.Click += new System.EventHandler(this.BtnAccueil_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 238);
            this.listBox1.TabIndex = 12;
            // 
            // SupprimerTache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 348);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnAccueil);
            this.Controls.Add(this.BtnValide);
            this.Controls.Add(this.label1);
            this.Name = "SupprimerTache";
            this.Text = "SupprimerTache";
            this.Load += new System.EventHandler(this.SupprimerTache_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnValide;
        private System.Windows.Forms.Button BtnAccueil;
        private System.Windows.Forms.ListBox listBox1;
    }
}