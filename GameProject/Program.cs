using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            IGameService gameService = new GameManager();
            Game game1 = new Game()
            {
                Id = 1,
                GameName = "Valorant",
                Custom = 50,
                Price = 100
            };

            Game game2 = new Game()
            {
                Id = 2,
                GameName = "Cs.Go",
                Custom = 470,
                Price = 60
            };

            gameService.Add(game1);
            gameService.Add(game2);

            

            var gameList = gameService.GetAll();

            gameService.Delete(game2);

            Console.WriteLine("******************");

            gameService.GetAll();

            ISaleService saleService = new SaleManager();
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "Furkan",
                LastName = "Sırdaş",
                DateOfBirth = new DateTime( 2001, 06, 09),
                TcNo = "12345678910"
            };

            var buyGame = gameService.GetById(1);
            Game game3 = new Game()
            {
                Id = buyGame.Id,
                GameName = buyGame.GameName,
                Price = buyGame.Price,
                Custom = 2
            };

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                Name = "yaz kampanyasi",
                Discount = 20
            };
                     
            saleService.Sell(gamer1,game3,campaign1);
            Console.WriteLine("**********Mernis************");
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            Gamer gamer4 = new Gamer()
            {
                Id = 4,
                FirstName = "Furkan",
                LastName = "Sırdaş",
                DateOfBirth = new DateTime(2001, 06, 09),
                TcNo = "12345678910"

            };

            gamerManager.Add(gamer4);
            
            Console.ReadLine();
        }
    }
}
