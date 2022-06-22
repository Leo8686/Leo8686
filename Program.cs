class Conclusao
{
    static void Main()
    {
        bool opcao = true;

        Console.WriteLine("Olá, irei realizar a soma de números até você parar!");

        Console.WriteLine("Digite o valor inicial!");
        float.TryParse(Console.ReadLine(), out float inicial);

        while (opcao == true)
        {

            Console.WriteLine("Digite o número que deseja somar ao número inicial: ");
            float.TryParse(Console.ReadLine(), out float n1);
            inicial = inicial + n1;
            Console.WriteLine("A soma até o momento é {0}", inicial);
            Console.WriteLine("Deseja sair do programa? 1 - Sim / 2 - Não");
            int.TryParse(Console.ReadLine(), out int saida);

            switch (saida)
            {
                case 1:
                    Console.WriteLine("Saindo do Programa!");
                    opcao = false;
                    break;
                case 2:
                    Console.WriteLine("Continua a Soma...");
                    break;
                default:
                    Console.WriteLine("Opção Inválida.Retornando...");
                    break;
            }

        }
    }
}
