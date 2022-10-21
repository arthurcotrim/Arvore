namespace Arvore
{
    public class ArvoreBinaria
    {
        public Node? Raiz { get; set; }
        private string? Side { get; set; }

        // ÁRVORES

        public bool ArvoreBinariaCheia(Node? node) => Cheia(node); // CHEIA
        public bool ArvoreBinariaPerfeita(Node? node) => Perfeita(node, VerificaProfundidade(node), 0); // PERFEITA
        public bool ArvoreBinariaDegenerada(Node? node) => Degenerada(node); // DEGENERADA
        public bool ArvoreBinariaEnviesada(Node? node)
        {
            Side = Inclinacao(node);
            return Enviesada(node);
        } // ENVIESADA
        public bool ArvoreBinariaCompleta(Node? node) => Completa(node, 0, ContarNos(node)); // COMPLETA

        // MÉTODOS

        private bool Cheia(Node? node)
        {
            if (node == null) return true;

            if (node.Esquerdo == null && node.Direito == null) return true;

            if (node.Esquerdo != null && node.Direito != null)
                return ArvoreBinariaCheia(node.Esquerdo) && ArvoreBinariaCheia(node.Direito);

            return false;
        }

        private bool Perfeita(Node? node, int? profundidade, int? nivel)
        {
            if (node == null) return true;

            if (node.Esquerdo == null && node.Direito == null)
                return profundidade == nivel + 1;

            if (node.Esquerdo == null || node.Direito == null) return false; // pq todos os filhos tem que estar no mesmo nivel

            return Perfeita(node.Esquerdo, profundidade, nivel + 1) && Perfeita(node.Direito, profundidade, nivel + 1);
        }

        private bool Degenerada(Node? node)
        {
            if (node == null) return true;

            if (node?.Esquerdo != null)
            {
                if (node.Direito != null) return false;
                else return Degenerada(node.Esquerdo);
            }
            else
            {
                if (node?.Direito != null) return Degenerada(node.Direito);
                else return true;
            }
        }

        private bool Enviesada(Node? node)
        {
            if (node == null) return true;

            if (node.Esquerdo != null && node.Direito != null) return false;

            if (Side == "esquerdo" && node.Direito != null) return false;
            if (Side == "direito" && node.Esquerdo != null) return false;

            if (node.Esquerdo != null && node.Direito == null) return Enviesada(node.Esquerdo);
            else if (node.Esquerdo == null && node.Direito != null) return Enviesada(node.Direito);

            return true;
        }

        private bool Completa(Node? node, int? index, int? nodes_qtd)
        {
            if (node == null) return true;

            if (index >= nodes_qtd) return false;

            return Completa(node.Esquerdo, 2 * index + 1, nodes_qtd)
                && Completa(node.Direito, 2 * index + 2, nodes_qtd);
        }

        // AUXILIAR
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

        private int ContarNos(Node? node)
        {
            if (node == null)
                return (0);
            return (1 + ContarNos(node.Esquerdo) +
                        ContarNos(node.Direito));
        }

        private string Inclinacao(Node? node) => Side = node?.Esquerdo != null ? "esquerdo" : "direito";
    }
}
