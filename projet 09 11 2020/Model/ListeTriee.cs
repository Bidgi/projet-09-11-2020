using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_09_11_2020.Model
{
    public class ListeTriee
    {
        #region Methode
        /// <summary> Raoul 
        /// ajoute a la liste param en index 0 l'objet o
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"> l'item a ajoute </param>
        /// <param name="param"> liste ou l'item doit etre ajoute </param>
        public void AjoutePremier<T>(T o, List<T> param)
        {
            param.Insert(0, o);
        }
        /// <summary> Raoul
        /// ajout a la liste param au derniere index l'objet o
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"> l'item a ajoute</param>
        /// <param name="param"> liste ou l'item doit etre ajoute </param>
        public void AjouteDerniere<T>(T o, List<T> param)
        {
            param.Add(o);
        }
        /// <summary> Raoul
        /// Permet d'avoir le premiere element de la liste param
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"> liste contenant l'item a retourner </param>
        /// <returns>
        /// Return un objet
        /// </returns>
        public Object RetournePremiere<T>(List<T> param)
        {
            return param.ElementAt(0);
        }
        /// <summary> Raoul
        /// permet d'avoir le derniere element de la liste param 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"> liste contenant l'item a retourner </param>
        /// <returns>
        /// Return un objet
        /// </returns>
        public Object RetourneDerniere<T>(List<T> param)
        {
            return param.ElementAt(param.Count() - 1);
        }
        /// <summary> Raoul
        /// Permet de supprimer le premiere element de la liste param
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"> liste contenant l'item a supprimer </param>
        public void SupprimePremiere<T>(List<T> param)
        {
            param.RemoveAt(0);
        }
        /// <summary> Raoul
        /// Permet de supprimer le derniere element de la liste param
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"> liste contenant l'item a supprimer </param>
        public void SupprimeDerniere<T>(List<T> param)
        {
            param.RemoveAt(param.Count() - 1);
        }
        /// <summary>
        /// Permet d'avoir le nombre d'ellement dans la liste param
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"> liste contenant l'item a supprimer </param>
        /// <returns>
        /// return un entite ( le nombre d'ellement de la liste)
        /// </returns>
        public int DonneNbElements<T>(List<T> param)
        {
            return param.Count();
        }
        /// <summary> Raoul
        /// Permet de change la priorite de l'item (param2) en changeant l'index par le nouvelle index (place) dans la liste param
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"> liste contenant l'item a modifier </param>
        /// <param name="place"> sont nouvelle index </param>
        /// <param name="param2"> l'item a modifier </param>
        public void DeplacerPriorite<T>(List<T> param, int place, T param2)
        {
            param.Remove(param2);
            param.Insert(place, param2);
        }
        #endregion
    }
}
