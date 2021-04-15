using System;
using System.Collections.Generic;
using DAL;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace DALTests
{
    class TestRepository : Repository
    {
        internal static void ResetSchema()
        {
            ClearSession();
            new SchemaExport(Configuration).Execute(false, true, false);
        }

        internal static void ClearSession()
        {
            Session.Clear();
        }

        internal static void Execute(string sql)
        {
            ISQLQuery query = Session.CreateSQLQuery(sql);
            query.ExecuteUpdate();
        }

        /// <summary>
        /// Load database with test data
        /// </summary>
        public static void InitDB()
        {
            ResetSchema();

            Execute(
                "insert into utilisateur (utilisateurId, utilisateurLogin, utilisateurMdp, utilisateurAdmin) values (1, 'cfricaud', 'mdpSecured', 1) ON DUPLICATE KEY UPDATE utilisateurId = 1; " +
                "insert into utilisateur (utilisateurId, utilisateurLogin, utilisateurMdp, utilisateurAdmin) values (2, 'Etienne', 'xblTG4649mlP', 0) ON DUPLICATE KEY UPDATE utilisateurId = 2;" +
                "insert into utilisateur (utilisateurId, utilisateurLogin, utilisateurMdp, utilisateurAdmin) values (3, 'xXDarkSasukeXx', 'bgdu26', 0) ON DUPLICATE KEY UPDATE utilisateurId = 3;"
                );
            Execute(
                "insert into album (albumId, albumCover, albumNom, albumSerie, albumAuteur, albumCategorie, albumGenre, albumEditeur) values (1, 'Cover1', 'Le Nom de Edward', 'Serie1', 'Auteur1', 'BD', 'fantasy', 'Editeur1') ON DUPLICATE KEY UPDATE albumId = 1;" +
                "insert into album (albumId, albumCover, albumNom, albumSerie, albumAuteur, albumCategorie, albumGenre, albumEditeur) values (2, 'Cover2', 'Nom2', 'Serie2', 'Edward Edward', 'manga', 'polar', 'Editeur2') ON DUPLICATE KEY UPDATE albumId = 2;" +
                "insert into album (albumId, albumCover, albumNom, albumSerie, albumAuteur, albumCategorie, albumGenre, albumEditeur) values (3, 'Cover3', 'Nom3', 'Serie3', 'Auteur3', 'comic', 'jeunesse', 'Edward Edward') ON DUPLICATE KEY UPDATE albumId = 3;"
                );
            Execute(
                "insert into listealbumpossede values (1, 1);" +
                "insert into listealbumpossede values (1, 2);" +
                "insert into listealbumpossede values (2, 3);"
                );
            Execute(
                "insert into listesouhait values (1, 3);" +
                "insert into listesouhait values (2, 1);" +
                "insert into listesouhait values (2, 2);"
                );

        }
    }
}