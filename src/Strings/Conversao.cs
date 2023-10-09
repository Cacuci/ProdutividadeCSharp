using System.Text;

namespace Strings
{
    internal class Conversao
    {
        public void ConversaoParaBytes()
        {
            var mensagem = "Produtividade em C#";

            Console.WriteLine(mensagem);

            Console.WriteLine("String convertida para bytes:");

            byte[] conteudo = Encoding.Unicode.GetBytes(mensagem);

            for (int i = 0; i < conteudo.Length; i++)
            {
                Console.Write(conteudo[i]);
            }
        }

        public void ConversaoArrayDeBytesParaString()
        {
            string mensagem = "Produtividade em C#";

            Console.WriteLine(mensagem);

            byte[] conteudo = UnicodeEncoding.Unicode.GetBytes(mensagem);

            Console.WriteLine("String convertida para bytes:");

            for (int i = 0; i < conteudo.Length; i++)
            {
                Console.Write(conteudo[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Concatenando todos os bytes em uma string de bytes:");

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < conteudo.Length; i++)
            {
                builder.Append(conteudo[i].ToString("x2"));
            }

            Console.WriteLine(builder.ToString());

            Console.WriteLine("Usando a classe BitConverter para colocar todos os bytes em uma string:");

            string bitString = BitConverter.ToString(conteudo);

            Console.WriteLine(bitString);

            Console.WriteLine("Obtendo a string em Unicode a partir dos Bytes:");

            string unicodeString = Encoding.Unicode.GetString(conteudo, 0, conteudo.Length);

            Console.WriteLine(unicodeString);
        }
    }
}

