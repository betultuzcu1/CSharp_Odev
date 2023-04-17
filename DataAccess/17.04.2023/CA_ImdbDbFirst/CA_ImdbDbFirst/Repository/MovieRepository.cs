using CA_ImdbDbFirst.Model;
using CA_ImdbDbFirst.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CA_ImdbDbFirst.Repository
{
    internal class MovieRepository : IMovieRepository
    {
        ImdbDataEntities1 db=new ImdbDataEntities1();
        public string CreateMovy(Movy movie)
        {
            throw new NotImplementedException();
        }

        public string DeleteMovy(int id)
        {
            throw new NotImplementedException();
        }


        public List<Movy> FindMovyByGenres(string genres)
        {
            //return db.Movies.Where(x => x.Genres == genres);



            throw new NotImplementedException();
        }


        public List<Movy> BestMovies()
        {
            return db.Movies.Where(x=> x.Rating>=70 && x.Rating<=100).ToList();
        }

        public string UpdateMovy(Movy movie)
        {
            throw new NotImplementedException();
        }

        public List<Movy> GetAllMovy()
        {
            return db.Movies.ToList();
        }
    }
}