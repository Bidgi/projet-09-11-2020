using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_09_11_2020.Model
{
    public class Projet
    {
        // creation de la classe Raoul
        #region Attributs
        public static List<Projet> CollClasseProjet = new List<Projet>(); // list 
        private int _idProjet; // numero du projet
        private string _intituleProjet; // nom du projet
        private DateTime _dateDebutPrevue; // date de debut prevue du projet
        private DateTime _dateDebutReelle; // date de debut reelle  du projet
        private DateTime _dateFinPrevue; // date de fin prevue du projet
        private DateTime _dateFinReelle; // date de fin reelle du projet
        private string _etat; // etat du projet
        private List<Lot> _lesLot; // list d'objet de lot 
        private Collaborateur _leResponsable; // objet de collaborateur
        private List<Tache> _lesTacheRestantARealiser; // list d'objet de tache
        #endregion

        #region Constructeur
        public Projet(int idProjet, string intituleProjet, DateTime dateDebutPrevue, DateTime dateDebutReelle, DateTime dateFinPrevue, DateTime dateFinReelle, string etat, List<Lot> lesLot, Collaborateur leResponsable, List<Tache> lesTacheRestantARealiser)
        {
            _idProjet = idProjet;
            _intituleProjet = intituleProjet;
            _dateDebutPrevue = dateDebutPrevue;
            _dateDebutReelle = dateDebutReelle;
            _dateFinPrevue = dateFinPrevue;
            _dateFinReelle = dateFinReelle;
            _etat = etat;
            _lesLot = lesLot;
            _leResponsable = leResponsable;
            _lesTacheRestantARealiser = lesTacheRestantARealiser;
            CollClasseProjet.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int IdProjet { get => _idProjet; set => _idProjet = value; }
        public string IntituleProjet { get => _intituleProjet; set => _intituleProjet = value; }
        public DateTime DateDebutPrevue { get => _dateDebutPrevue; set => _dateDebutPrevue = value; }
        public DateTime DateDebutReelle { get => _dateDebutReelle; set => _dateDebutReelle = value; }
        public DateTime DateFinPrevue { get => _dateFinPrevue; set => _dateFinPrevue = value; }
        public DateTime DateFinReelle { get => _dateFinReelle; set => _dateFinReelle = value; }
        public string Etat { get => _etat; set => _etat = value; }
        public List<Lot> LesLot { get => _lesLot; set => _lesLot = value; }
        public Collaborateur LeResponsable { get => _leResponsable; set => _leResponsable = value; }
        public List<Tache> LesTacheRestantARealiser { get => _lesTacheRestantARealiser; set => _lesTacheRestantARealiser = value; }
        #endregion

        #region Méthodes
        /// <summary> Galaad
        /// Permet d'avoir un pourcentage pour les tâches terminées et le nombre de tâches total du projet
        ///</summary>
        //////<returns>
        ///Retourne un pourcentage des taches déjà fini
        //////</returns>
        //////<param>
        ///Aucun
        //////</param>
        public int PourcentageAvacement()
        {
            int compteurTermine = 0;
            foreach (Projet unProjet in CollClasseProjet) if (unProjet.Etat == "T") compteurTermine++;
            return compteurTermine / CollClasseProjet.Count() * 100;
        }
        #endregion
    }
}
