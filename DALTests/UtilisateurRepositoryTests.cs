using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace DALTests
{
    [TestClass]
    public class UtilisateurRepositoryTests
    {
        private UtilisateurRepository utilRepository;

        [TestInitialize()]
        public void Initialize()
        {

            TestRepository.InitDB();
            utilRepository = new UtilisateurRepository();

        }

        [TestMethod]
        public void TestUtilRepo_GetAll()
        {
            var utilisateurs = utilRepository.GetAll();
            // 3 utilisateurs dans le jeu de données de test
            Assert.AreEqual(3, utilisateurs.Count);
            var actual = utilisateurs.Select(util => util.Login).ToList();
            var expected = new List<string> { "cfricaud", "Etienne", "xXDarkSasukeXx" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void TestUtilRepo_GetUserById()
        {
            int id = 1;
            var current = utilRepository.GetUserById(id);
            // 1 utilisateur dans le jeu de données de test
            var expected = "cfricaud";
            Assert.AreEqual(current.Login, expected);
        }
    }
}
