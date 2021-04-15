using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Mdp { get; set; }
        public virtual bool Admin { get; set; }
        public virtual IList<Album> ListeAlbumPossede { get; set; }
        public virtual IList<Album> ListeSouhait { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Utilisateur() { }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        public Utilisateur(string login, string mdp, bool admin)
        {
            Login = login;
            Mdp = mdp;
            Admin = admin;
        }



        /// <summary>
        /// Décrit un utilisateur sous forme d'un tableau
        /// </summary>
        /// <returns>Un tableau contenant les propriétés de l'utilisateur</returns>
        public virtual string[] Decrire()
        {
            return new string[] { Login, Admin.ToString()};
        }

        /// <summary>
        /// Décrit un Album sous forme textuelle
        /// </summary>
        /// <returns>Nom</returns>
        public override string ToString()
        {
            return Login;
        }
    }
}
