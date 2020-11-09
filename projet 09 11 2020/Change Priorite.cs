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
    public partial class Change_Priorite : Form
    {
        public Change_Priorite()
        {
            InitializeComponent();
        }
        /// <summary>Raoul
        /// Permet d'instgancier les listes listeBox1 et listeBox2 avec la collection des taches
        /// </summary>
        private void Change_Priorite_Load(object sender, EventArgs e)
        {
            foreach (Tache uneTache in Tache.CollClasseTache) listBox1.Items.Add(uneTache.IntituleTache);
            foreach (Tache uneTache in Tache.CollClasseTache)
            {
                listBox2.Items.Add(uneTache.IntituleTache);
                listBox2.Items.Add("Ici");
            }
        }
        private static readonly ListeTriee listeTriee = new ListeTriee();
        /// <summary>Raoul
        /// Permet de changer l'index de la tache sélectionner dans la listeBox1 en premiere possition
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (Tache uneTache in Tache.CollClasseTache) 
            { 
                if (listBox1.SelectedItem.ToString() == uneTache.IntituleTache)
                {
                    Tache.CollClasseTache.Remove(uneTache);
                    listeTriee.AjoutePremier(uneTache, Tache.CollClasseTache);
                }
            }
        }
        /// <summary>Raoul
        /// Permet de changer l'index de la tache sélectionner dans la listeBox1 en dernier possition
        /// </summary>
        private void BtnDerniere_Click(object sender, EventArgs e)
        {
            foreach (Tache uneTache in Tache.CollClasseTache)
            {
                if (listBox1.SelectedItem.ToString() == uneTache.IntituleTache)
                {
                    Tache.CollClasseTache.Remove(uneTache);
                    listeTriee.AjouteDerniere(uneTache, Tache.CollClasseTache);
                }
            }
        }
        /// <summary>Raoul
        /// Permet de changer l'index d'une tache selectionne de la liste "listeBox1" par un index sélectionne de la liste "listeBox2"
        /// </summary>
        private void BtnValider_Click(object sender, EventArgs e)
        {
            int place;
            try { place = listBox2.SelectedIndex / 2; }
            catch { place = listBox2.SelectedIndex; }
            Tache tache = null;
            foreach (Tache uneTache in Tache.CollClasseTache) if (listBox1.SelectedItem.ToString() == uneTache.IntituleTache) tache = uneTache;
            listeTriee.DeplacerPriorite(Tache.CollClasseTache, place, tache);
        }
        /// <summary> Raoul
        ///  Permet d'ouvrir un nouveaux form accueil
        /// </summary>
        private void BtnAccueil_Click(object sender, EventArgs e)
        {
            Accuiel accuiel = new Accuiel();
            accuiel.Show();
            this.Close();
        }
    }
}
