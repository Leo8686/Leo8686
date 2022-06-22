//Estrutura Switch

Console.WriteLine("Qual nota você dá para o prato? 0, 5, ou 10");
int.TryParse(Console.ReadLine(), out int nota);

switch(nota)
{
    case 0:
      Console.WriteLine("Comida muito ruim!");
        break;
    case 5:
       Console.WriteLine("Comida razoável!");
        break;
    case 10:
       Console.WriteLine("Comida muito boa!");
        break;
    default:
       Console.WriteLine("Nota inexistente!");
        break;
}