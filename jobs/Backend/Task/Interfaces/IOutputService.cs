﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRateUpdater.Interfaces
{
    public interface IOutputService
    {
        void WriteMessage(string text);
    }
}
