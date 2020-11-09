namespace projet_09_11_2020
{
    partial class Accuiel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbProjet = new System.Windows.Forms.ComboBox();
            this.cbbLot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjou = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnPrio = new System.Windows.Forms.Button();
            this.labelAvancement = new System.Windows.Forms.Label();
            this.labelAvancementLot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNbtache = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbbProjet
            // 
            this.cbbProjet.FormattingEnabled = true;
            this.cbbProjet.Location = new System.Drawing.Point(12, 25);
            this.cbbProjet.Name = "cbbProjet";
            this.cbbProjet.Size = new System.Drawing.Size(195, 21);
            this.cbbProjet.TabIndex = 0;
            this.cbbProjet.SelectedIndexChanged += new System.EventHandler(this.CbbProjet_SelectedIndexChanged);
            // 
            // cbbLot
            // 
            this.cbbLot.FormattingEnabled = true;
            this.cbbLot.Location = new System.Drawing.Point(12, 86);
            this.cbbLot.Name = "cbbLot";
            this.cbbLot.Size = new System.Drawing.Size(195, 21);
            this.cbbLot.TabIndex = 1;
            this.cbbLot.SelectedIndexChanged += new System.EventHandler(this.CbbLot_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selection le projet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selection le lot  :";
            // 
            // btnAjou
            // 
            this.btnAjou.Location = new System.Drawing.Point(12, 165);
            this.btnAjou.Name = "btnAjou";
            this.btnAjou.Size = new System.Drawing.Size(195, 44);
            this.btnAjou.TabIndex = 4;
            this.btnAjou.Text = "Ajouter une Tache dans le lot selectionner";
            this.btnAjou.UseVisualStyleBackColor = true;
            this.btnAjou.Click += new System.EventHandler(this.BtnAjou_Click);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(12, 215);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(195, 44);
            this.btnSup.TabIndex = 5;
            this.btnSup.Text = "Supprimer une Tache dans le lot selectionner";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.BtnSup_Click);
            // 
            // btnPrio
            // 
            this.btnPrio.Location = new System.Drawing.Point(12, 265);
            this.btnPrio.Name = "btnPrio";
            this.btnPrio.Size = new System.Drawing.Size(195, 44);
            this.btnPrio.TabIndex = 6;
            this.btnPrio.Text = "Change les priorite des Tache du lot selectionner";
            this.btnPrio.UseVisualStyleBackColor = true;
            this.btnPrio.Click += new System.EventHandler(this.BtnPrio_Click);
            // 
            // labelAvancement
            // 
            this.labelAvancement.AutoSize = true;
            this.labelAvancement.Location = new System.Drawing.Point(9, 49);
            this.labelAvancement.Name = "labelAvancement";
            this.labelAvancement.Size = new System.Drawing.Size(73, 13);
            this.labelAvancement.TabIndex = 7;
            this.labelAvancement.Text = "Avancement :";
            // 
            // labelAvancementLot
            // 
            this.labelAvancementLot.AutoSize = true;
            this.labelAvancementLot.Location = new System.Drawing.Point(9, 110);
            this.labelAvancementLot.Name = "labelAvancementLot";
            this.labelAvancementLot.Size = new System.Drawing.Size(73, 13);
            this.labelAvancementLot.TabIndex = 8;
            this.labelAvancementLot.Text = "Avancement :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Combien de tache sont a selectionner";
            // 
            // txtNbtache
            // 
            this.txtNbtache.Location = new System.Drawing.Point(12, 139);
            this.txtNbtache.Name = "txtNbtache";
            this.txtNbtache.Size = new System.Drawing.Size(195, 20);
            this.txtNbtache.TabIndex = 10;
            // 
            // Accuiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 323);
            this.Controls.Add(this.txtNbtache);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAvancementLot);
            this.Controls.Add(this.labelAvancement);
            this.Controls.Add(this.btnPrio);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnAjou);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbLot);
            this.Controls.Add(this.cbbProjet);
            this.Name = "Accuiel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Accuiel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbProjet;
        private System.Windows.Forms.ComboBox cbbLot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjou;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnPrio;
        private System.Windows.Forms.Label labelAvancement;
        private System.Windows.Forms.Label labelAvancementLot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNbtache;
    }
}

