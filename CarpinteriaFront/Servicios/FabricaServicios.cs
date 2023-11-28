﻿using CarpinteriaFront.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaFront.Servicios
{
    public abstract class FabricaServicios
    {
        public abstract IServicio CrearServicio();
    }
}
