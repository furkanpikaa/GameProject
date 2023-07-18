using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;
        List<Gamer> gamers = new List<Gamer>();
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (gamer != null)
            {
                if (_gamerCheckService.CheckIfRealPlayer(gamer))
                {
                    gamers.Add(gamer);
                    Console.WriteLine("Başarıyla eklendi");
                }
                else
                {
                    Console.WriteLine("Vatandaş bulunamadı");
                }
            }
        }

        public void Delete(Gamer gamer)
        {
            if (gamer != null)
            {
                gamers.Remove(gamer);
            }
        }

        public List<Gamer> GetAll()
        {
            var result = gamers.ToList();
            if (result != null)
            {
                return result;
            }
            return null;
        }

        public Gamer GetById(int id)
        {
            var result = gamers.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                return result;
            }

            return null;
        }

        public void Update(Gamer gamer)
        {
            var result = GetById(gamer.Id);
            if (result != null)
            {
                Delete(gamer);
                Add(gamer);
            }
        }
    }
}
