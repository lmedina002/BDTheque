using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TempUtilisateurRepository : Repository, IUtilisateurRepository
    {
        List<Utilisateur> ListUtilisateurs { get; set; }

        public TempUtilisateurRepository(List<Utilisateur> utilisateurs)
        {
            ListUtilisateurs = utilisateurs;
        }

        public List<Utilisateur> GetAll()
        {
            return ListUtilisateurs;
        }

        public void Save(Utilisateur utilisateur)
        {
            ListUtilisateurs.Add(utilisateur);
        }

        public Utilisateur GetUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
