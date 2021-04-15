using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainTests
{
    [TestClass]
    public class UtilisateurTests
    {
        private Utilisateur user;
        private string login = "DarkVador";
        private string mdp = "Skywalker";
        private bool admin = false;

        [TestInitialize()]
        public void Initialize()
        {
            user = new Utilisateur(login, mdp, admin);
        }

        [TestMethod]
        public void TestUtilisateur_ToString()
        {
            Assert.AreEqual(login, user.ToString());
        }

        [TestMethod]
        public void TestUtilisateur_Decrire()
        {
            string[] expected = { login, admin.ToString() };
            CollectionAssert.AreEquivalent(expected, user.Decrire());
        }
    }
}
