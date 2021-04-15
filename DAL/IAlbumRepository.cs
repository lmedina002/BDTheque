using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux albums
    /// </summary>
    public interface IAlbumRepository
    {
        /// <summary>
        /// Récupère la liste des Bd
        /// </summary>
        /// <returns></returns>
        List<Album> GetAll();


        /// <summary>
        /// Recherche dans les albums de la liste donnée selon tout les critères
        /// </summary>
        /// <param name="motCle">le mot clé de la recherche</param>
        /// <param name="libNom">le nom de la ListBox active</param>
        /// <returns>List<(Album,string)></returns>
        List<(Album,string)> SearchAllCriteria(string motCle,string libNom, int userId);

        /// <summary>
        /// Recherche dans les albums de la liste donnée selon le critere donné
        /// </summary>
        /// <param name="motCle">le mot clé de la recherche</param>
        /// <param name="libNom">le nom de la ListBox active</param>
        /// <returns>List<(Album,string)></returns>
        List<(Album, string)> SearchByOneCriteria(string motCle, string libNom, int userId, string critere);


        /// <summary>
        /// Sauvegarde un album
        /// </summary>
        /// <param name="album">l'album</param>
        void Save(Album album);

        /// <summary>
        /// Supprime un album de la base de données
        /// </summary>
        /// <param name="album">l'album</param>
        void Delete(Album album);
    }
}
