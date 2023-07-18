using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sell(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " oyunu " +
                gamer.FirstName + " adli oyuncuya " + 
                (game.Price - campaign.Discount) + 
                " fiyatinda satilmiştir." + " Adet " + game.Custom
                );
        }
    }
}
