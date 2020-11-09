using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_09_11_2020.Model
{
    public class Lot
    {
        // creation de la classe Raoul
        #region Attributs
        public static List<Lot> CollClasseLot = new List<Lot>();
        private int _idLot; // numero du lot 
        private DateTime _dateDebutPrevue; // date de debut prevue du lot
        private DateTime _dateDebutReelle; // date de debut reelle  du lot
        private DateTime _dateFinPrevue; // date de fin prevue du lot
        private DateTime _dateFinReelle; // date de fin reelle du lot
        private string _etat; // etat du projet
        private Projet _leProjet; // objet de projet 
        private List<Tache> _lesTaches; // list d'objet de tache
        #endregion

        #region Constructeur
        public Lot(int idLot, DateTime dateDebutPrevue, DateTime dateDebutReelle, DateTime dateFinPrevue, DateTime dateFinReelle, string etat, Projet leProjet, List<Tache> lesTaches)
        {
            IdLot = idLot;
            DateDebutPrevue = dateDebutPrevue;
            DateDebutReelle = dateDebutReelle;
            DateFinPrevue = dateFinPrevue;
            DateFinReelle = dateFinReelle;
            Etat = etat;
            LeProjet = leProjet;
            LesTaches = lesTaches;
            CollClasseLot.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int IdLot { get => _idLot; set => _idLot = value; }
        public DateTime DateDebutPrevue { get => _dateDebutPrevue; set => _dateDebutPrevue = value; }
        public DateTime DateDebutReelle { get => _dateDebutReelle; set => _dateDebutReelle = value; }
        public DateTime DateFinPrevue { get => _dateFinPrevue; set => _dateFinPrevue = value; }
        public DateTime DateFinReelle { get => _dateFinReelle; set => _dateFinReelle = value; }
        public string Etat { get => _etat; set => _etat = value; }
        public Projet LeProjet { get => _leProjet; set => _leProjet = value; }
        public List<Tache> LesTaches { get => _lesTaches; set => _lesTaches = value; }
        #endregion

        #region Méthodes
        /// <summary> Galaad
        /// Permet d'ajouter des tâches au lot en prélevant à la liste triée des taches à réaliser pour le projet
        ///</summary>
        ///<returns>
        /// Ne retourne rien
        ///</returns>
        ///<para>
        ///Le nombre de Tache Ajouter
        ///</para>
        public void AjouterTaches(int nbTacheAjout)
        {
            int compteur = 0;
            foreach (Tache uneTache in Tache.CollClasseTache)
            {
                compteur++;
                if (compteur <= nbTacheAjout) break;
                if (uneTache.Etat == "AL") LesTaches.Add(uneTache);
            }
        }
        /// <summary> Galaad
        /// Permet de connaitre le nombre de taches terminés
        ///</summary>
        ///<returns>
        /// Retourne le nombre de taches terminées de type "int"
        ///</returns>
        ///<para>
        ///Aucun param en entrée
        ///</para>
        public int DonneNbTachesTerminees()
        {
            int compteurTermine = 0;
            foreach (Tache uneTache in LesTaches) if (uneTache.Etat == "T") compteurTermine++;
            return compteurTermine;
        }
        /// <summary> Ewen
        ///Permet d'obtenir un pourcentage des tâches terminées dans le lot
        ///</summary>
        ///<returns>
        ///Retourne un pourcentage des tâches en "float"
        ///</returns>
        ///<para>
        ///Aucun parametre n'est utilisé
        ///</para>
        public int PourcentageAvancement()
        {
            return DonneNbTachesTerminees() / LesTaches.Count() * 100;
        }
        /// <summary> Ewen
        ///Permet de connaitre les differentes tâches à effectuer restantes
        ///</summary>
        ///<returns>
        ///Retourne une liste des tâches qui ont l'état "AA"
        ///</returns>
        ///<para>
        ///Aucun paramètre n'est utilisé
        ///</para>
        public List<Tache> DonneTacheAAffecter()
        {
            List<Tache> taches = new List<Tache>();
            foreach (Tache uneTache in LesTaches) if (uneTache.Etat == "AA") taches.Add(uneTache);
            return taches;
        }
        #endregion
    }
}
