using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TempAlbumRepository : Repository, IAlbumRepository
    {
        List<Album> ListAlbums { get; set; }

        public TempAlbumRepository(List<Album> albums)
        {
            ListAlbums = albums;
        }

        public List<Album> GetAll()
        {
            return ListAlbums;
        }

        public void Save(Album album)
        {
            ListAlbums.Add(album);
        }

        public List<(Album,string)> SearchAllCriteria(string listeCriteres, string libNom, int userId)
        {
            throw new NotImplementedException();
        }        
        
        public void Delete(Album album)
        {
            throw new NotImplementedException();
        }
        
        public List<(Album, string)> SearchByOneCriteria(string motCle, string libNom, int userId, string critere)
        {
            throw new NotImplementedException();
        }
    }
}
