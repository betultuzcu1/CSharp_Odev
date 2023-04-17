using CA_ImdbDbFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CA_ImdbDbFirst.Repository.Abstract
{
    internal interface IMovieRepository
    {
        //Listeleme
        List<Movy> GetAllMovy();

        //Ekleme
        string CreateMovy(Movy movie);

        //Güncelleme
        string UpdateMovy(Movy movie);
        
        //Silme
        string DeleteMovy(int id);

        //En iyi filmler
        List<Movy> BestMovies();

        //Dışarıdan alınan türe göre filmler
        List<Movy> FindMovyByGenres(string  genres);


        

        


    }
}
