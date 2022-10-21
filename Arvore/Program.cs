using Arvore;

ArvoreBinaria arvore = new()
{
    Raiz = new(5),
};

arvore.Raiz.Esquerdo = new(9);
arvore.Raiz.Esquerdo.Esquerdo = new(10);
arvore.Raiz.Esquerdo.Esquerdo.Esquerdo = new(8);
//arvore.Raiz.Direito = new(8);

if (arvore.ArvoreBinariaCheia(arvore.Raiz))
    Console.WriteLine("É árvore binária cheia");

if (arvore.ArvoreBinariaPerfeita(arvore.Raiz))
    Console.WriteLine("É árvore binária perfeita");

if (arvore.ArvoreBinariaDegenerada(arvore.Raiz))
    Console.WriteLine("É árvore binária degenerada");

if (arvore.ArvoreBinariaEnviesada(arvore.Raiz))
    Console.WriteLine("É árvore binária enviesada"); 