﻿using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioInterface.ClassesBichos
{
    public class Jacare : Reptil, IAquatico
    {
        private readonly IAquatico aquatico;
        public bool ViveEmTerra { get ; set ; }
        public bool Mergulho { get ; set; }
        public bool AguaDoce { get; set; }
        public Jacare(string nome) : base(nome)
        {
                
        }
    }
}
