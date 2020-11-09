using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_09_11_2020.Model
{
    public class Collaborateur
    {
        // creation de la classe Raoul
        #region Attributs
        public static List<Collaborateur> CollClasseCOllaborateur = new List<Collaborateur>(); // collection de classe collaborateur
        private int _idCollaborateur; // numero du collaborateur
        private string _nomCollaborateur; // nom du collaborateur
        private Service _leService; // objet de service
        #endregion

        #region Constructeur
        public Collaborateur(int idCollaborateur, string nomCollaborateur, Service leService)
        {
            _idCollaborateur = idCollaborateur;
            _nomCollaborateur = nomCollaborateur;
            _leService = leService;
            CollClasseCOllaborateur.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int IdCollaborateur { get => _idCollaborateur; set => _idCollaborateur = value; }
        public string NomCollaborateur { get => _nomCollaborateur; set => _nomCollaborateur = value; }
        internal Service LeService { get => _leService; set => _leService = value; }
        #endregion

        #region Méthodes
        #endregion
    }
}
