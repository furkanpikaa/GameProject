using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        List<Game> GetAll();
        Game GetById(int id);

        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
