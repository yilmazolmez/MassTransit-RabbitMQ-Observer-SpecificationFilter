﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogManager.ConsumerService.Commands
{
    public class LogCommand
    {
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
    }

}
