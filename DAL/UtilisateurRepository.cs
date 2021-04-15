using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate;

namespace DAL
{
    public class UtilisateurRepository : Repository, IUtilisateurRepository
    {
        public List<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }

        public Utilisateur GetUserById(int id)
        {
            return Session.Query<Utilisateur>().Where(u => u.Id == id).Single<Utilisateur>();            
        }

        public void Save(Utilisateur utilisateur)
        {
            Session.SaveOrUpdate(utilisateur);
            Session.Flush();
        }

    }
}
