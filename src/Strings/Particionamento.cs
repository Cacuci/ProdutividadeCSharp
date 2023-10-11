namespace Strings
{
    internal class Particionamento
    {
        public void ParticianamentoSimples()
        {
            Console.WriteLine("Livros	recentes:");
            Console.WriteLine();

            //Livros	separados	apenas	por	vírgulas
            string livrosRecentes = "Produtividade	em	C#,	Guia de Validação de Dados em C#, Guia de Validação	de Dados em	Visual Basic, Guia de Validação de Dados em Python";

            string[] lista = livrosRecentes.Split(", ");

            foreach (string livro in lista)
            {
                Console.WriteLine(livro);
            }
        }

    }
}
