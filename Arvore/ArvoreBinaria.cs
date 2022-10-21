using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arvore
{
    public class ArvoreBinaria
    {
        public Node? Raiz { get; set; }

        public bool ArvoreBinariaCheia(Node? node)
        {
            if (node == null) return true;

            if (node.Esquerdo == null && node.Direito == null) return true;

            if (node.Esquerdo != null && node.Direito != null)
                return ArvoreBinariaCheia(node.Esquerdo) && ArvoreBinariaCheia(node.Direito);

            return false;
        }

        public bool ArvoreBinariaPerfeita(Node? node)
        {
            int profundidade = VerificaProfundidade(node);
            return Perfeita(node, profundidade, 0);
        }

        private bool Perfeita(Node? node, int? profundidade, int? nivel)
        {
            if (node == null) return true;

            if (node.Esquerdo == null && node.Direito == null)
                return profundidade == nivel + 1;

            if (node.Esquerdo == null || node.Direito == null) return false; // pq todos os filhos tem que estar no mesmo nivel

            return Perfeita(node.Esquerdo, profundidade, nivel + 1) && Perfeita(node.Direito, profundidade, nivel + 1);
        }

        public bool ArvoreBinariaDegenerada(Node? node)
        {
            int profundidade = VerificaProfundidade(node);
            return Degenerada(node, profundidade, 0);
        }

        private bool Degenerada(Node? node, int? profundidade, int? nivel)
        {
            if (node == null) return true;

            if (node.Esquerdo != null && node.Direito != null) return false;

            if (profundidade == nivel) return true;

            if (node.Esquerdo != null && node.Direito == null)
                return Degenerada(node.Esquerdo, profundidade, nivel + 1);
            else if (node.Esquerdo == null && node.Direito != null)
                return Degenerada(node.Direito, profundidade, nivel + 1);

            return false;
        }

        public bool ArvoreBinariaEnviesada(Node? node)
        {
            int profundidade = VerificaProfundidade(node);
            return Enviesada(node, profundidade, 0, "", "");
        }

        private bool Enviesada(Node? node, int? profundidade, int? nivel, string side1, string side2)
        {
            if (node == null) return true;

            if (node.Esquerdo != null && node.Direito != null) return false;

            if (nivel == 0)
            {
                side1 = node.Esquerdo != null ? "esquerdo" : "direito";
                side2 = node.Esquerdo != null ? "esquerdo" : "direito";
            }
            else
                side2 = node.Esquerdo != null ? "esquerdo" : "direito";

            if (profundidade == nivel + 1) return true;

            if (side1 != side2) return false;

            if ((node.Esquerdo != null && node.Direito == null) || (node.Esquerdo == null && node.Direito != null))
                return Enviesada(node.Esquerdo, profundidade, nivel + 1, side1, side2) && Enviesada(node.Direito, profundidade, nivel + 1, side1, side2);

            return false;
        }


        private int VerificaProfundidade(Node? node)
        {
            int profundidade = 0;

            while (node != null)
            {
                node = node.Esquerdo;
                profundidade++;
            }

            return profundidade;
        }
    }
}
