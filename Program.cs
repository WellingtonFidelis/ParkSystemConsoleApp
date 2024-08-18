// See https://aka.ms/new-console-template for more information

using ParkSystemConsoleApp.Models.Parking; 

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n");
Console.WriteLine("Digite o preço inicial:");
initialPrice = Convert.ToDecimal(Console.ReadLine());


Console.WriteLine("Agora digite o preço por hora:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());


Parking pk = new Parking(initialPrice, pricePerHour);

string option = string.Empty;
bool showMenu = true;

while (showMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            pk.AddCar();
            break;

        case "2":
            pk.DeleteCar();
            break;

        case "3":
            pk.ListCar();
            break;

        case "4":
            showMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}


Console.WriteLine("O programa encerrou.");
