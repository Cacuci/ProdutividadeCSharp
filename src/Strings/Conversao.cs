using System.Text;

namespace Strings
{
    internal class Conversao
    {
        public void ConversaoParaBytes()
        {
            var mensagem = "Produtividade em C#";

            Console.WriteLine(mensagem);

            Console.WriteLine("Mensagem convertida para bytes");

            byte[] conteudo = Encoding.Unicode.GetBytes(mensagem);

            Console.WriteLine(conteudo);
        }
    }
}
