using Shared;

namespace Strings
{
    internal class Interpolacao
    {
        Livro Livro { get; set; } = new();

        /// <summary>
        /// Interpolação de strings através do método String.Format
        /// </summary>
        internal void InterpolarStringsComStringFormat()
        {
            var mensagem = string.Format("{0} é o novo livro de {1}", Livro.Titulo, Livro.Autor);

            Console.WriteLine(mensagem);
        }

        /// <summary>
        /// Interpolação de strings através do método $. Recurso introduzido no C# 6.0
        /// </summary>
        internal void InterpolarStringsComCifrao()
        {
            var mensagem = string.Format($"{Livro.Titulo} é o novo livro de {Livro.Titulo}");

            Console.WriteLine(mensagem);
        }

        /// Interpolação de strings através de caracteres de controle para inserir quebra de linha (\n) e tabulação (\t)
        internal void InterpolarStringsPreservandoEspacos()
        {
            var mensagem = "Amigo leitor,\n\n\t obrigado por ter adquirido este livro. Esperamos que ele o ajude em sua jornada diária de trabalho.\n\nBom	estudo!\nCláudio Ralha";

            Console.WriteLine(mensagem);
        }

        /// <summary>
        /// Interpolação de strings através do recurso verbatim	string "@"
        /// </summary>
        internal void InterpolarStringsPreservandoEspacosComSimbolo()
        {
            var mensagem = @"Amigo	leitor,
				obrigado	por	ter	adquirido	este	livro.	Esperamos	que	ele	o	aj
            ude	em	sua	jornada	diária	de	trabalho.
            
            Bom	estudo!
            Cláudio	Ralha";

            Console.WriteLine(mensagem);
        }
    }
}
