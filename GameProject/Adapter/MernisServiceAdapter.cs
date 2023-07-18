using GameProject.Abstract;
using GameProject.Entities;
using GameProject.MernisService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapter
{
    public class MernisServiceAdapter : IGamerCheckService
    {

        public bool CheckIfRealPlayer(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.TcNo),
                gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(),
                gamer.DateOfBirth.Year
                );
        }
    }
}
