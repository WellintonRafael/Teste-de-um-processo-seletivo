namespace Program
{
    public class Desafio
    {
        // Foi criado esses tracejados para reaproveitamento de código.
        static string dashed = "-------------------------------------------------";
        static string bigDashed = dashed + dashed;


        static void Main(string[] args)
        {
            // Apresentação.
            Console.WriteLine("\n{0} Desafio Agger {0} \n", dashed);
            Console.WriteLine("Esse desafio consiste em: \n\n" +
                "1 - Receber um input (número inteiro) do usuário. \n" +
                "2 - Somar os números que sejam menores que o input e múltiplos de 3 ou 5. \n" +
                "      2.1 - Caso algum número seja múltiplo de 3 e também de 5 (Ex.: 15), ele será somado uma única vez. \n" +
                "3 - Caso o número escolhido pelo usuário seja negativo, o resultado será 0. \n");
            Console.WriteLine("{0} Vamos começar {0} \n", dashed);

            RequestNumber();
        }
        private static void RequestNumber()
        {
            var multiples = new HashSet<long>(); // Essa collection não permite números duplicados.

            Console.Write("Digite um número inteiro: \n\n--> ");
            var userInput = Console.ReadLine();

            int getNumberUserInput;

            try
            {
                getNumberUserInput = int.Parse(userInput); // Converte o input do tipo string para inteiro.
            }   
            catch
            {
                Console.WriteLine("{0}\nVocê não digitou um número inteiro! \n{0}", bigDashed);
                RequestNumber();
                return;
            }

            Console.WriteLine("\n... Aguarde ... \n");
            Thread.Sleep(800); // Aguarda durante 800 milisegundos antes de ir para a próxima linha.
            Console.WriteLine("O número digitado foi: {0} \n", userInput);
            Thread.Sleep(800); // Aguarda durante 800 milisegundos antes de ir para a próxima linha.
            Console.WriteLine("Verificando resultados... \n");
            Thread.Sleep(1400); // Aguarda durante 1400 milisegundos antes de ir para a próxima linha.


            // Iteração para adicionar os múltiplos de 3 e 5 na lista 'multiples'.
            for (int i = 3; i < getNumberUserInput; i++)
            {

                // Caso o número não for divisível por 3 nem por 5, é testado o próximo número da iteração.
                if (i % 3 != 0 && i % 5 != 0) continue;

                multiples.Add(i); // Os múltiplos de 3 ou 5 são adicionados à lista.
            }


            // Aqui é impresso na tela a soma de todos os números da lista 'multiples'.
            Console.WriteLine("{0} \n\n" +
                "A soma dos números menores que {1} e múltiplos de 3 e 5 é: {2}\n" +
                "   ", bigDashed, userInput, multiples.Sum());

            Console.WriteLine("{0}", bigDashed);

            Console.Write("Quer continuar? \n\n" +
                "Sim -> [1] \n" +
                "Não -> [2] \n\n " +
                "Ou pressione ENTER para sair \n\n" +
                "--> ");

            var getUserResponse = (Console.ReadLine()).ToUpper();

            switch (getUserResponse)
            {
                case "1":
                case "SIM":
                    // Se o usuário digitar 1, é chamada a função 'RequestNumber()' que solicita um novo número para calcular.
                    Console.WriteLine("{0}\n\n ... Vamos iniciar novamente ... \n\n{0}", bigDashed);
                    RequestNumber();
                    break;

                default:
                    Console.WriteLine("\n {0} \n\n Até breve! \n\n {0}", bigDashed);
                    break;
            }
        }
    }
}