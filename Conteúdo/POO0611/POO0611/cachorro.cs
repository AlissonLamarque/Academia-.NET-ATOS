﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO0611
{
    internal class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Au au");
        }
    }
}
