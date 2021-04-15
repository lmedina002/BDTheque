using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;

namespace DAL
{
    /// <summary>
    /// Superclasse de tous les repository
    /// </summary>
    public abstract class Repository
    {
        private static ISession session;
        private static Configuration configuration;

        protected static Configuration Configuration
        {
            get
            {
                // Crée l'objet Configuration au premier accès (lazy loading)
                if (configuration == null)
                {
                    configuration = new Configuration().Configure();
                }
                return configuration;
            }
        }

        protected static ISession Session
        {
            get
            {
                // Crée l'objet Session au premier accès (lazy loading)
                if (session == null)
                {
                    session = Configuration.BuildSessionFactory().OpenSession();
                }
                return session;
            }
        }
    }
}
