using projet_09_11_2020.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_09_11_2020
{
    public partial class SupprimerTache : Form
    {
        public SupprimerTache()
        {
            InitializeComponent();
        }
        /// <summary> Raoul
        /// Permet d'instancié la liste (listBox1) avec les taches de la collection des taches
        /// </summary>
        private void SupprimerTache_Load(object sender, EventArgs e)
        {
            foreach (Tache uneTache in Tache.CollClasseTache) listBox1.Items.Add(uneTache.IntituleTache);
        }
        /// <summary> Raoul
        /// Permet de supprimer la page selectionné dans la listeBox
        /// </summary>
        private void BtnValide_Click(object sender, EventArgs e)
        {
            foreach (Tache uneTache in Tache.CollClasseTache) if (listBox1.SelectedItem.ToString() == uneTache.IntituleTache) Tache.CollClasseTache.Remove(uneTache);
        }
        /// <summary> Raoul
        /// Permet d'ouvrir un nouveaux form accueil
        /// </summary>
        private void BtnAccueil_Click(object sender, EventArgs e)
        {
            Accuiel accuiel = new Accuiel();
            accuiel.Show();
            this.Close();
        }
    }
}
