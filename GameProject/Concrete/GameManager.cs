using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {

        List<Game> games = new List<Game>();


        public void Add(Game game)
        {
            games.Add(game);
        }

        public void Delete(Game game)
        {
            games.Remove(game);
        }

        public List<Game> GetAll()
        {
            var result = games.ToList();

            if (result != null)
            {
                foreach (var x in result)
                {
                    Console.WriteLine(x.Id + " numaralı oyun bilgileri " + x.GameName + " fiyati : " + x.Price + " Adet: " + x.Custom);
                }
                return result;
            }

            return null;
        }

        public Game GetById(int id)
        {
            var result = games.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                return result;
            }

            return null;
        }

        public void Update(Game game)
        {
            var result = GetById(game.Id);

            if (result!= null)
            {
                Delete(game);
                Add(game);
            }
        }
    }
}
