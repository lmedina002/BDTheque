using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainTests
{
    [TestClass]
    public class AlbumTests
    {
        private Album album;
        private string cover = "CoverTest";
        private string nom = "NomTest";
        private string serie = "SerieTest";
        private string auteur = "AuteurTest";
        private string categorie = "CategorieTest";
        private string genre = "GenreTest";
        private string editeur = "EditeurTest";


        [TestInitialize()]
        public void Initialize()
        {
            album = new Album(cover, nom, serie, auteur, categorie, genre, editeur);
        }

        [TestMethod]
        public void TestAlbum_ToString()
        {
            Assert.AreEqual(nom, album.ToString());
        }

        [TestMethod]
        public void TestAlbum_Decrire()
        {
            string[] expected = { cover, nom, serie, auteur, categorie, genre, editeur };
            CollectionAssert.AreEquivalent(expected, album.Decrire());
        }
    }
}