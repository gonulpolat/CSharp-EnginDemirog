﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_01
{
    internal class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms!");
        }
    }
}