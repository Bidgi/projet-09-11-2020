using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_09_11_2020.Model
{
    public class Tache
    {
        // Raoul
        #region Attributs
        public static List<Tache> CollClasseTache = new List<Tache>();
        private int _idTache; // numero de tache 
        private string _intituleTache; // nom de tache
        private DateTime _dateDebutPrevue; // date de debut prevue de la tache
        private DateTime _dateDebutReelle; // date de debut reelle  de la tache
        private int _dureePrevue; // duree prevue de la tache
        private int _dureeReelle; // duree reelle de la tache
        private string _etat; // etat de la tache
        private List<Collaborateur> _lesCollaborateur; // liste d'objet collaborateur
        #endregion

        #region Constructeur
        public Tache(int idTache, string intituleTache, DateTime dateDebutPrevue, DateTime dateDebutReelle, int dureePrevue, int dureeReelle, string etat, List<Collaborateur> lesCollaborateur)
        {
            IdTache = idTache;
            IntituleTache = intituleTache;
            DateDebutPrevue = dateDebutPrevue;
            DateDebutReelle = dateDebutReelle;
            DureePrevue = dureePrevue;
            DureeReelle = dureeReelle;
            Etat = etat;
            LesCollaborateur = lesCollaborateur;
            CollClasseTache.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int IdTache { get => _idTache; set => _idTache = value; }
        public string IntituleTache { get => _intituleTache; set => _intituleTache = value; }
        public DateTime DateDebutPrevue { get => _dateDebutPrevue; set => _dateDebutPrevue = value; }
        public DateTime DateDebutReelle { get => _dateDebutReelle; set => _dateDebutReelle = value; }
        public int DureePrevue { get => _dureePrevue; set => _dureePrevue = value; }
        public int DureeReelle { get => _dureeReelle; set => _dureeReelle = value; }
        public string Etat { get => _etat; set => _etat = value; }
        public List<Collaborateur> LesCollaborateur { get => _lesCollaborateur; set => _lesCollaborateur = value; }
        #endregion

        #region Méthodes
        #endregion
    }
}
