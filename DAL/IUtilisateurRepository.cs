using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IUtilisateurRepository
    {
        /// <summary>
        /// Sauvegarde un utilisateur
        /// </summary>
        /// <param name="utilisateur">l'utilisateur</param>
        void Save(Utilisateur utilisateur);

        /// <summary>
        /// Recupère un utilisateur à partir de son id
        /// </summary>
        /// <param name="utilisateur">l'utilisateur</param>
        Utilisateur GetUserById(int id);

        /// <summary>
        /// Récupère la liste des utilisateurs
        /// </summary>
        /// <returns></returns>
        List<Utilisateur> GetAll();

    }
}
