using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkSystemConsoleApp.Models.Parking
{
    internal class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> cars = new List<string>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddCar()
        {
            Console.WriteLine("Informe o código da placa do veículo para estacionar:");
            string? licensePlate = Console.ReadLine();

            if (licensePlate != null)
            {
                cars.Add(licensePlate.ToUpper());
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }

        public void DeleteCar()
        {
            if (cars.Count > 0)
            {
                Console.WriteLine("Digite o código da placa do carro que deseja remover.\n");

                // Pedir para o usuário digitar a placa e armazenar na variável placa
                // *IMPLEMENTE AQUI*
                int i = 0;
                foreach (string car in cars)
                {
                    i++;
                    Console.WriteLine($"{i} - {car}"); 
                }

                int carOptionCode = Convert.ToInt16(Console.ReadLine());

                // Verifica se o veículo existe
                //if (cars.Any(x => x.ToUpper() == licensePlate.ToUpper()))
                if (carOptionCode <= cars.Count)
                {

                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                    int hoursParked = Convert.ToInt16(Console.ReadLine());

                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                    // *IMPLEMENTE AQUI*
                    decimal totalValue = 0;
                    totalValue = initialPrice + pricePerHour * hoursParked;

                    // TODO: Remover a placa digitada da lista de veículos
                    // *IMPLEMENTE AQUI*
                    //
                    string licensePlate = cars[(carOptionCode - 1)];
                    cars.RemoveAt((carOptionCode - 1));

                    Console.WriteLine($"O veículo {licensePlate} foi removido e o preço total foi de: R$ {totalValue}");
                }
                else
                {
                    Console.WriteLine("Desculpe, esse código é inválido.");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void ListCar()
        {
            if (cars.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");

                foreach (string car in cars)
                {
                   Console.WriteLine(car); 
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

    }
}
