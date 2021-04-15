using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Domain;
using System;

namespace DALTests
{
    [TestClass]
    public class AlbumRepositoryTests
    {
        private AlbumRepository albumRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            albumRepository = new AlbumRepository();
        }

        [TestMethod]
        public void TestAlbumRepo_GetAll()
        {
            var albums = albumRepository.GetAll();
            // 3 albums dans le jeu de données de test
            Assert.AreEqual(3, albums.Count);
            var current = albums.Select(album => album.Nom).ToList();
            var expected = new List<string> { "Le Nom de Edward", "Nom2","Nom3" };
            CollectionAssert.AreEquivalent(current, expected);
        }

        [TestMethod]
        public void TestAlbumRepo_SaveNew()
        {
            var album = new Album("Cover4", "Nom4", "Serie4", "Auteur4", "comic", "polar", "Editeur4");
            albumRepository.Save(album);

            TestRepository.ClearSession();
            // Recherche des livres portant le même titre
            var albums = albumRepository.GetAll().Where(l => l.Nom ==
                "Nom4").ToList();
            // 1 seul album correspondant dans le jeu de données de test
            Assert.AreEqual(1, albums.Count);
            Album nouvelAlbum = albums[0];
            Assert.AreEqual("Nom4", nouvelAlbum.Nom);
            Assert.AreEqual("Auteur4", nouvelAlbum.Auteur);
        }

        [TestMethod]
        public void TestAlbumRepo_Update()
        {
            var album = albumRepository.GetAll()[0];
            album.Auteur = "NomAuteurTest";
            albumRepository.Save(album);
            TestRepository.ClearSession();
            album = albumRepository.GetAll().Where(l => l.Nom == "Le Nom de Edward").ToList()[0];
            Assert.AreEqual("NomAuteurTest", album.Auteur);
        }

        [TestMethod]
        public void TestAlbumRepo_SearchByAllCriterias_catalog()
        {
            // recherche d'un nom dans le catalogue
            string motCle = "Le Nom de Edward";
            string libNom = "libCatalogue";
            int userId = 1;

            List<(Album, string)> current = albumRepository.SearchAllCriteria(motCle, libNom, userId);
            var album = new Album("Cover1", "Le Nom de Edward", "Serie1", "Auteur1", "BD", "fantasy", "Editeur1");
            List<(Album, string)> expected = new List<(Album, string)>();
            expected.Add((album,"Nom"));
            CollectionAssert.AreEquivalent(expected[0].Item1.Decrire(), current[0].Item1.Decrire());
        }

        [TestMethod]
        public void TestAlbumRepo_SearchByAllCriterias_owned()
        {
            // recherche d'un auteur dans les albums possédés
            string motCle = "Edward Edward";
            string libNom = "libPossede";
            int userId = 1;

            List<(Album, string)>  current = albumRepository.SearchAllCriteria(motCle, libNom, userId);
            var album = new Album("Cover2", "Nom2", "Serie2", "Edward Edward", "manga", "polar", "Editeur2");
            List<(Album, string)> expected = new List<(Album, string)>();
            expected.Add((album, "Auteur")) ;
            CollectionAssert.AreEquivalent(expected[0].Item1.Decrire(), current[0].Item1.Decrire());
        }

        [TestMethod]
        public void TestAlbumRepo_SearchByAllCriterias_wishlist()
        {
            // recherche d'un éditeur dans la liste de souhaits
            string motCle = "Edward Edward";
            string libNom = "libSouhaits";
            int userId = 1;

            List<(Album, string)> current = albumRepository.SearchAllCriteria(motCle, libNom, userId);
            var album = new Album("Cover3", "Nom3", "Serie3", "Auteur3", "comic", "jeunesse", "Edward Edward");
            List<(Album, string)> expected = new List<(Album, string)>();
            expected.Add((album,"Editeur"));
            CollectionAssert.AreEquivalent(expected[0].Item1.Decrire(), current[0].Item1.Decrire());
        }

        [TestMethod]
        public void TestAlbumRepo_SearchByAllCriterias_catalog_multipleResults_sameAttribute()
        {
            // recherche d'un mot clé dans le catalogue, résultats multiples trouvés pour un seul critère
            string motCle = "Nom";
            string libNom = "libCatalogue";
            int userId = 1;

            List<(Album, string)> current = albumRepository.SearchAllCriteria(motCle, libNom, userId);

            var album1 = new Album("Cover1", "Le Nom de Edward", "Serie1", "Auteur1", "BD", "fantasy", "Editeur1");

            var album2 = new Album("Cover2", "Nom2", "Serie2", "Edward Edward", "manga", "polar", "Editeur2");
            var album3 = new Album("Cover3", "Nom3", "Serie3", "Auteur3", "comic", "jeunesse", "Edward Edward");

            List<(Album, string)> expected = new List<(Album, string)>();
            expected.Add((album1, "Nom"));
            expected.Add((album2, "Nom"));
            expected.Add((album3, "Nom"));

            int i = 0;
            foreach (var a in current)
            {
                CollectionAssert.AreEquivalent(expected[i].Item1.Decrire(), current[i].Item1.Decrire());
                i++;
            }
        }

        [TestMethod]
        public void TestAlbumRepo_SearchByAllCriterias_catalog_multipleResults_diffAttributes()
        {
            // recherche d'un mot clé dans le catalogue, résultats multiples issus d'attributs différents
            string motCle = "Edward";
            string libNom = "libCatalogue";
            int userId = 1;

            List<(Album, string)> current = albumRepository.SearchAllCriteria(motCle, libNom, userId);

            var album1 = new Album("Cover1", "Le Nom de Edward", "Serie1", "Auteur1", "BD", "fantasy", "Editeur1");
            var album2 = new Album("Cover2", "Nom2", "Serie2", "Edward Edward", "manga", "polar", "Editeur2");
            var album3 = new Album("Cover3", "Nom3", "Serie3", "Auteur3", "comic", "jeunesse", "Edward Edward");

            List<(Album, string)> expected = new List<(Album, string)>();
            expected.Add((album1, "Nom"));
            expected.Add((album2, "Auteur"));
            expected.Add((album3, "Editeur"));

            int i = 0;
            foreach (var a in current)
            {
                CollectionAssert.AreEquivalent(expected[i].Item1.Decrire(), current[i].Item1.Decrire());
                i++;
            }

            Assert.AreEqual(expected.Count(), current.Count());

        }

        [TestMethod]
        public void TestAlbumRepo_SearchByOneCriteria_Name()
        {
            // recherche d'un nom dans le catalogue
            string motCle = "Le Nom de Edward";
            string libNom = "libCatalogue";
            string critere = "Nom";
            int userId = 1;

            List<(Album, string)> current = albumRepository.SearchByOneCriteria(motCle, libNom, userId, critere);
            var album = new Album("Cover1", "Le Nom de Edward", "Serie1", "Auteur1", "BD", "fantasy", "Editeur1");
            List<(Album, string)> expected = new List<(Album, string)>();
            expected.Add((album,"Nom"));
            CollectionAssert.AreEquivalent(expected[0].Item1.Decrire(), current[0].Item1.Decrire());
        }

        [TestMethod]
        public void TestAlbumRepo_SearchByOneCriteria_Author()
        {
            // recherche d'un auteur dans les albums possédés
            string motCle = "Edward Edward";
            string libNom = "libPossede";
            string critere = "Auteur";
            int userId = 1;

            List<(Album, string)> current = albumRepository.SearchByOneCriteria(motCle, libNom, userId, critere);
            var album = new Album("Cover2", "Nom2", "Serie2", "Edward Edward", "manga", "polar", "Editeur2");
            List<(Album, string)> expected = new List<(Album, string)>();
            expected.Add((album, "Auteur"));
            CollectionAssert.AreEquivalent(expected[0].Item1.Decrire(), current[0].Item1.Decrire());
        }

        [TestMethod]
        public void TestAlbumRepo_SearchByOneCriteria_Serie()
        {
            // recherche d'une série dans la liste de souhaits
            string motCle = "Serie3";
            string libNom = "libSouhaits";
            string critere = "Serie";
            int userId = 1;

            List<(Album, string)> current = albumRepository.SearchByOneCriteria(motCle, libNom, userId, critere);
            var album = new Album("Cover3", "Nom3", "Serie3", "Auteur3", "comic", "jeunesse", "Edward Edward");
            List<(Album,string)> expected = new List<(Album,string)>();
            expected.Add((album,"Serie"));
            CollectionAssert.AreEquivalent(expected[0].Item1.Decrire(), current[0].Item1.Decrire());
        }

        [TestMethod]
        public void TestAlbumRepo_SearchByOneCriteria_multipleResults()
        {
            // recherche d'un nom clé dans le catalogue, plusieurs résultats
            string motCle = "Nom";
            string libNom = "libCatalogue";
            string critere = "Nom";
            int userId = 1;

            List<(Album, string)> current = albumRepository.SearchByOneCriteria(motCle, libNom, userId, critere);

            var album1 = new Album("Cover1", "Le Nom de Edward", "Serie1", "Auteur1", "BD", "fantasy", "Editeur1");
            var album2 = new Album("Cover2", "Nom2", "Serie2", "Edward Edward", "manga", "polar", "Editeur2");
            var album3 = new Album("Cover3", "Nom3", "Serie3", "Auteur3", "comic", "jeunesse", "Edward Edward");

            List<(Album, string)> expected = new List<(Album, string)>();
            expected.Add((album1, "Nom"));
            expected.Add((album2, "Nom"));
            expected.Add((album3, "Nom"));

            int i = 0;
            foreach (var a in current)
            {
                CollectionAssert.AreEquivalent(expected[i].Item1.Decrire(), current[i].Item1.Decrire());
                i++;
            }
        }
    }
}
