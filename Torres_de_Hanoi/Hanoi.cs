﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public void mover_disco(Pila a, Pila b)
        {
            if (a.Top < b.Top) b.push(a.pop());
            else if (a.Top > b.Top) a.push(b.pop());
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
