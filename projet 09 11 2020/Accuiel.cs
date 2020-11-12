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
    public partial class Accuiel : Form
    {
        public Accuiel()
        {
            InitializeComponent();
        }

        internal static Lot leLot;
        /// <summary>Raoul
        /// Permet d'instancier le combobox cbbProjet avec les intitulé de projet
        /// </summary> 
        private void Accuiel_Load(object sender, EventArgs e)
        {
            Service s1 = new Service(1, "Invention");
            Service s2 = new Service(2, "Ellaborer");

            Collaborateur c1 = new Collaborateur(1, "Michel", s1);
            Collaborateur c2 = new Collaborateur(2, "Patrick", s2);

            s1.SetCollab(c1);
            s2.SetCollab(c2);

            Tache t1 = new Tache(1, "Nettoyer", new DateTime(2020, 02, 06), new DateTime(2020, 02, 08), 10, 15, "En cour", new List<Collaborateur>() { c1, c2 });
            Tache t2 = new Tache(1, "Organiser", new DateTime(2020, 02, 06), new DateTime(2020, 02, 08), 15, 20, "En cour", new List<Collaborateur>() { c1, c2 });

            Projet p1 = new Projet(1, "AA", new DateTime(2020, 02, 05), new DateTime(2020, 02, 08), new DateTime(2020, 04, 05), new DateTime(2020, 05, 05), "Fini", c1);

            Lot l1 = new Lot(1, new DateTime(2020, 05, 02), new DateTime(2020, 02, 08), new DateTime(2020, 04, 05), new DateTime(2020, 05, 05), "Fini", p1, new List<Tache>() {t1, t2});
            p1.LesLot = new List<Lot>() { l1 };
            p1.LesTacheRestantARealiser = new List<Tache>() { t1, t2 };


            foreach (Projet projet in Projet.CollClasseProjet) cbbProjet.Items.Add(projet.IntituleProjet);
        }
        /// <summary>Raoul
        /// Une fois un projet séléctionné , on cherhce l'avancement du projet avec la méthode pourcentageAvancement
        /// Et on instansit le combo box cbbLot avec tous les lots du projet
        /// </summary>
        private void CbbProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Projet projet1 = null;
            foreach (Projet projet in Projet.CollClasseProjet) if (cbbProjet.Text == projet.IntituleProjet) projet1 = projet;
            labelAvancement.Text = "Avancement : " + projet1.PourcentageAvacement() + "%";
            foreach (Lot unLot in projet1.LesLot) cbbLot.Items.Add(unLot);
        }
        /// <summary>Raoul
        /// Une fois un lot séléctionné on cherhce l'avancement du lot avec la méthode pourcentage Avancement
        /// </summary>
        private void CbbLot_SelectedIndexChanged(object sender, EventArgs e)
        {
            Projet projet1 = null;
            foreach (Projet projet in Projet.CollClasseProjet) if (cbbProjet.Text == projet.IntituleProjet) projet1 = projet;
            foreach (Lot unLot in projet1.LesLot) if (unLot == cbbLot.SelectedItem) leLot = unLot;
            labelAvancement.Text = "Avancement : " + leLot.PourcentageAvancement() + "%";
        }
        /// <summary>Raoul
        /// Permet d'ajouter aux lots sélectionné le nombre de taches à ajouter au lot
        /// </summary>
        private void BtnAjou_Click(object sender, EventArgs e)
        {
            leLot.AjouterTaches(int.Parse(txtNbtache.Text));
        }
        /// <summary>Raoul
        /// Permet d'ouvrir un form "Supprimer Taches"
        /// </summary>
        private void BtnSup_Click(object sender, EventArgs e)
        {
            SupprimerTache supprimerTache = new SupprimerTache();
            supprimerTache.Show();
        }
        /// <summary> Raoul
        /// Permet d'ouvrir un from "changerPriorité"
        /// </summary>
        private void BtnPrio_Click(object sender, EventArgs e)
        {
            Change_Priorite change_Priorite = new Change_Priorite();
            change_Priorite.Show();
        }
    }
}
