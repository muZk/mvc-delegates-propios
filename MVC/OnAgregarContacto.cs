﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class OnAgregarContactoArgs : EventArgs
    {
        public string nombre;
        public string email;
    }
}