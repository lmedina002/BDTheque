using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Modélise un album
    /// </summary>
    public class Album
    {
        public virtual int Id { get; set; }

        public virtual string Cover { get; set; }

        public virtual string Nom { get; set; }

        public virtual string Serie { get; set; }

        public virtual string Auteur { get; set; }

        public virtual string Categorie { get; set; }

        public virtual string Genre { get; set; }

        public virtual string Editeur { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Album() { }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="titre"></param>
        /// <param name="auteur"></param>
        public Album(string cover, string nom, string serie, string auteur, string categorie, string genre, string editeur)
        {
            Cover = cover;
            Nom = nom;
            Serie = serie;
            Auteur = auteur;
            Categorie = categorie;
            Genre = genre;
            Editeur = editeur;
        }

        /// <summary>
        /// Décrit un album sous forme d'un tableau
        /// </summary>
        /// <returns>Un tableau contenant les propriétés de l'album</returns>
        public virtual string[] Decrire()
        {
                return new string[] { Cover, Nom, Serie, Auteur, Categorie, Genre, Editeur };
        }

        /// <summary>
        /// Décrit un Album sous forme textuelle
        /// </summary>
        /// <returns>Nom</returns>
        public override string ToString()
        {
                return Nom;
        }
    }
}