using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate;

namespace DAL
{
    public class AlbumRepository : Repository, IAlbumRepository
    {
        public List<Album> GetAll()
        {
            return Session.Query<Album>().ToList();
        }

        public List<(Album,string)> SearchAllCriteria(string motCle, string libNom, int userId)
        {
            string requete = "";
            IList<Album> listResultat = new List<Album>();
            List<(Album, string)> listComplete = new List<(Album, string)>();

            if (libNom == "libCatalogue")
            {
                //Albums trouvés par le nom
                requete = "From Album a Where a.Nom like :motCle";
                listResultat = Session.CreateQuery(requete).SetParameter("motCle", "%" + motCle + "%").List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Nom"));

                //Albums trouvés par l'auteur
                requete = "From Album a Where a.Auteur like :motCle";
                listResultat = Session.CreateQuery(requete).SetParameter("motCle", "%" + motCle + "%").List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Auteur"));

                //Albums trouvés par la série
                requete = "From Album a Where a.Serie like :motCle";
                listResultat = Session.CreateQuery(requete).SetParameter("motCle", "%" + motCle + "%").List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Serie"));

                //Albums trouvés par l'éditeur
                requete = "From Album a Where a.Editeur like :motCle";
                listResultat = Session.CreateQuery(requete).SetParameter("motCle", "%" + motCle + "%").List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Editeur"));

                //Albums trouvés par genre
                requete = "From Album a Where a.Genre like :motCle";
                listResultat = Session.CreateQuery(requete).SetParameter("motCle", "%" + motCle + "%").List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Genre"));

                //Albums trouvés par catégorie
                requete = "From Album a Where a.Categorie like :motCle";
                listResultat = Session.CreateQuery(requete).SetParameter("motCle", "%" + motCle + "%").List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Categorie"));

            }
            else if(libNom == "libPossede")
            {
                //Albums trouvés par le nom
                IQuery sqlQueryNom = Session.CreateSQLQuery("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listealbumpossede WHERE utilisateurId = " + userId.ToString() + ") AND albumNom LIKE '%" + motCle + "%'").AddEntity(typeof(Album));
                listResultat = sqlQueryNom.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Nom"));

                //Albums trouvés par l'auteur
                IQuery sqlQueryAuteur = Session.CreateSQLQuery("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listealbumpossede WHERE utilisateurId = " + userId.ToString() + ") AND albumAuteur LIKE '%" + motCle + "%'").AddEntity(typeof(Album));
                listResultat = sqlQueryAuteur.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Auteur"));

                //Albums trouvés par la série
                IQuery sqlQuerySerie = Session.CreateSQLQuery("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listealbumpossede WHERE utilisateurId = " + userId.ToString() + ") AND albumSerie LIKE '%" + motCle + "%'").AddEntity(typeof(Album));
                listResultat = sqlQuerySerie.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Serie"));

                //Albums trouvés par l'éditeur
                IQuery sqlQueryEditeur = Session.CreateSQLQuery("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listealbumpossede WHERE utilisateurId = " + userId.ToString() + ") AND albumEditeur LIKE '%" + motCle + "%'").AddEntity(typeof(Album));
                listResultat = sqlQueryEditeur.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Editeur"));

                //Albums trouvés par genre
                IQuery sqlQueryGenre = Session.CreateSQLQuery("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listealbumpossede WHERE utilisateurId = " + userId.ToString() + ") AND albumGenre LIKE '%" + motCle + "%'").AddEntity(typeof(Album));
                listResultat = sqlQueryGenre.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Genre"));

                //Albums trouvés par catégorie
                IQuery sqlQueryCategorie = Session.CreateSQLQuery("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listealbumpossede WHERE utilisateurId = " + userId.ToString() + ") AND albumCategorie LIKE '%" + motCle + "%'").AddEntity(typeof(Album));
                listResultat = sqlQueryGenre.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Categorie"));
            }
            else
            {
                //Albums trouvés par le nom
                IQuery sqlQueryNom = Session.CreateSQLQuery("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listesouhait WHERE utilisateurId = " + userId.ToString() + ") AND albumNom LIKE '%" + motCle + "%'").AddEntity(typeof(Album));
                listResultat = sqlQueryNom.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Nom"));

                //Albums trouvés par l'auteur
                IQuery sqlQueryAuteur = Session.CreateSQLQuery("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listesouhait WHERE utilisateurId = " + userId.ToString() + ") AND albumAuteur LIKE '%" + motCle + "%'").AddEntity(typeof(Album));
                listResultat = sqlQueryAuteur.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Auteur"));

                //Albums trouvés par la série
                IQuery sqlQuerySerie = Session.CreateSQLQuery("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listesouhait WHERE utilisateurId = " + userId.ToString() + ") AND albumSerie LIKE '%" + motCle + "%'").AddEntity(typeof(Album));
                listResultat = sqlQuerySerie.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Serie"));

                //Albums trouvés par l'éditeur
                IQuery sqlQueryEditeur = Session.CreateSQLQuery("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listesouhait WHERE utilisateurId = " + userId.ToString() + ") AND albumEditeur LIKE '%" + motCle + "%'").AddEntity(typeof(Album));
                listResultat = sqlQueryEditeur.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Editeur"));

                //Albums trouvés par genre
                IQuery sqlQueryGenre = Session.CreateSQLQuery("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listealbumpossede WHERE utilisateurId = " + userId.ToString() + ") AND albumGenre LIKE '%" + motCle + "%'").AddEntity(typeof(Album));
                listResultat = sqlQueryGenre.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Genre"));

                //Albums trouvés par catégorie
                IQuery sqlQueryCategorie = Session.CreateSQLQuery("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listealbumpossede WHERE utilisateurId = " + userId.ToString() + ") AND albumCategorie LIKE '%" + motCle + "%'").AddEntity(typeof(Album));
                listResultat = sqlQueryGenre.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, "Categorie"));
            }

            return listComplete;
        }        

        public List<(Album, string)> SearchByOneCriteria(string motCle, string libNom, int userId, string critere)
        {
            string requete = "";
            IList<Album> listResultat = new List<Album>();
            List<(Album, string)> listComplete = new List<(Album, string)>();

            if (libNom == "libCatalogue")
            {
                //Albums trouvés par l'éditeur
                requete = String.Format("From Album a Where a.{0} like :motCle",critere);
                listResultat = Session.CreateQuery(requete).SetParameter("motCle", "%" + motCle + "%").List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, critere));
            }
            else if (libNom == "libPossede")
            {
                //Albums trouvés par l'éditeur
                IQuery sqlQueryEditeur = Session.CreateSQLQuery(String.Format("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listealbumpossede WHERE utilisateurId = {0}) AND album{1} LIKE '%{2}%'", userId.ToString(),critere,motCle)).AddEntity(typeof(Album));
                listResultat = sqlQueryEditeur.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, critere));
            }
            else
            {
                //Albums trouvés par l'éditeur
                IQuery sqlQueryEditeur = Session.CreateSQLQuery(String.Format("SELECT * FROM album WHERE albumId IN (SELECT albumId FROM listesouhait WHERE utilisateurId = {0}) AND album{1} LIKE '%{2}%'", userId.ToString(), critere, motCle)).AddEntity(typeof(Album));
                listResultat = sqlQueryEditeur.List<Album>();
                foreach (Album album in listResultat)
                    listComplete.Add((album, critere));
            }

            return listComplete;
        }        

        public void Save(Album album)
        {
            Session.SaveOrUpdate(album);
            Session.Flush();
        }

        public void Delete(Album album)
        {
            IQuery sqlQueryDeleteSouhait = Session.CreateSQLQuery("DELETE FROM listesouhait WHERE albumId = " + album.Id);
            sqlQueryDeleteSouhait.ExecuteUpdate();

            IQuery sqlQueryDeletePossede = Session.CreateSQLQuery("DELETE FROM listealbumpossede WHERE albumId = " + album.Id);
            sqlQueryDeletePossede.ExecuteUpdate();

            IQuery sqlQueryDeleteCatalogue = Session.CreateSQLQuery("DELETE FROM album WHERE albumId = " + album.Id);
            sqlQueryDeleteCatalogue.ExecuteUpdate();
        }
    }
}
