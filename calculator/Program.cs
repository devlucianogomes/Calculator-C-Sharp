namespace calculator
    {
    internal class Program
        {
        static void Main(string[] args)
            {

            Menu();  
            
            }
        // Função que irá definir que tipo de operação o usuário deseja fazer
        static void Menu()
            {
            Console.Clear();
            Console.WriteLine("Qual operação deseja?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------------");

            Console.WriteLine("Selecione uma opção:");

            // Capturando o valor selecionado pelo usuario para o tipo de op
            short operation = short.Parse(Console.ReadLine());

            switch(operation)
                {
                case 1: Sum();
                break;

                case 2: Substract();
                break;

                case 3:Split();
                break;

                case 4: Multiply();
                break;

                case 5: System.Environment.Exit(0);
                break;

                default: Menu();
                break;

                }

            }

        static void Sum()
            {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor:");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            float value2 = float.Parse(Console.ReadLine());

            // Fazendo a soma dos dois itens
            float resultSum = value1 + value2;
            Console.WriteLine();
            Console.WriteLine($"O resultado da soma é: {resultSum} ");

            }

        static void Substract()
            {
            Console.Clear();
            Console.WriteLine("Insira o primeiro valor:");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            float resultSubtract = value1 - value2;
            Console.WriteLine($"Resultado da subtração: {resultSubtract}");

            }


        static void Split()
            {
            Console.Clear();
            Console.WriteLine("Insira o primeiro valor:");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            float resultDivision = value1 / value2;
            Console.WriteLine($"Resultado da divisão: {resultDivision}");

            }

        static void Multiply()
            {
            Console.Clear();
            Console.WriteLine("Insira o primeiro valor:");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            float resultMultiplicate = value1 * value2;
            Console.WriteLine($"Resultado da multiplicação: {resultMultiplicate}");

            }
        }
    }