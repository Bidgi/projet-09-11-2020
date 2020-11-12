using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_09_11_2020.Model
{
    public class Service
    {
        // creation de la classe Raoul
        #region Attributs
        private int _idService; // numero du service
        private string _nomService; // nom du service
        private Collaborateur _leResponsable; // objet do collaborateur
        #endregion

        #region Constructeur
        public Service(int idService, string intituleProjet, Collaborateur leResponsable)
        {
            _idService = idService;
            _nomService = intituleProjet;
            _leResponsable = leResponsable;
        }
        public Service(int idService, string intituleProjet)
        {
            _idService = idService;
            _nomService = intituleProjet;
        }

        #endregion

        #region Getters-Setters
        public int IdService { get => _idService; set => _idService = value; }
        public string NomService { get => _nomService; set => _nomService = value; }
        internal Collaborateur LeResponsable { get => _leResponsable; set => _leResponsable = value; }
        #endregion

        #region Méthodes
        public void SetCollab(Collaborateur collaborateur)
        {
            this.LeResponsable = collaborateur;
        }
        #endregion
    }
}
