using System; // ignifica que podemos usar classes do System namespace.

namespace Sintaxe // é usada para organizar seu código e é um contêiner para classes e outros namespaces.

{ // As chaves {} marcam o início e o fim de um bloco de código.
        class Program // é um container para dados e métodos, que traz funcionalidade ao seu programa. Cada linha de código executada em C# deve estar dentro de uma classe. Em nosso exemplo, nomeamos a classe Program.

    {
        static void Main(string[] args) // Outra coisa que sempre aparece em um programa C#, é o Mainmétodo. Qualquer código dentro de suas chaves {}será executado. Você não precisa entender as palavras-chave antes e depois de Main. Você os conhecerá pouco a pouco enquanto lê este tutorial.

        {
            Console.Clear(); // Limpa a tela, seria como o cls do prompt
            Console.WriteLine("Hello word!"); //  é uma classe do System namespace, que possui um WriteLine() método que é utilizado para saída/impressão de texto. Em nosso exemplo, a saída será "Hello World!".
                            //  Cada instrução C# termina com um ponto e vírgula ;
        }
    }
} // As chaves {} marcam o início e o fim de um bloco de código.