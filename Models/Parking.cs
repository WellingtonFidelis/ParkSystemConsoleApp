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
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string licensePlate = "";

            // Verifica se o veículo existe
            if (cars.Any(x => x.ToUpper() == licensePlate.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int hours = 0;
                decimal totalValue = 0;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo {licensePlate} foi removido e o preço total foi de: R$ {totalValue}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
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
