﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Sell(Gamer gamer , Game game, Campaign campaign);
    }
}
