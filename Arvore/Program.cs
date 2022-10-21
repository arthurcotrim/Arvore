using Arvore;

ArvoreBinaria arvore = new()
{
    Raiz = new(1),
};

// PARA TESTAR OS MÉTODOS, INSTANCIE O OBJETO ARVORE ACIMA COM OS NÓS
// DE ACORDO COM A ÁRVORE DESEJADA

// EX.:
// arvore.Raiz.Esquerdo = new(2);
// arvore.Raiz.Direito = new(3);


if (arvore.ArvoreBinariaCheia(arvore.Raiz))
    Console.WriteLine("É árvore binária cheia");

if (arvore.ArvoreBinariaPerfeita(arvore.Raiz))
    Console.WriteLine("É árvore binária perfeita");

if (arvore.ArvoreBinariaDegenerada(arvore.Raiz))
    Console.WriteLine("É árvore binária degenerada");

if (arvore.ArvoreBinariaEnviesada(arvore.Raiz))
    Console.WriteLine("É árvore binária enviesada");

if (arvore.ArvoreBinariaCompleta(arvore.Raiz))
    Console.WriteLine("É árvore binária completa");