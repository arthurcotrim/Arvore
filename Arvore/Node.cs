using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore
{
    public class Node
    {
        public int? Dado { get; set; }
        public Node? Esquerdo { get; set; }
        public Node? Direito { get; set; }

        public Node(int dado)
        {
            Esquerdo = null;
            Direito = null;

            Dado = dado;
        }
    }
}
