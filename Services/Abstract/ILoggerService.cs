﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface ILoggerService
    {
        void LogInfo(string message);
        void LogWarnnig(string message);
        void LogError(string message);
        void LogDebug(string message);
    }
}
