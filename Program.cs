using System.Reflection.Metadata;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();


// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);





bool menu = true;
while (menu)
{
    Console.Clear();
    Console.WriteLine("1 - Adcionar Hospede");
    Console.WriteLine("2 - Reservar");
    Console.WriteLine("0 - Fechar");
    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine(" ");
            Console.WriteLine("Nome:");
            hospedes.Add(new Pessoa(nome: Console.ReadLine()));
            Console.WriteLine("");
            Console.WriteLine("Precione qualquer tecla.");
            Console.ReadLine();
            Console.WriteLine("");
        break;
        case "2":
            Console.WriteLine("Quantidade de dias:");
            // Cria uma nova reserva, passando a suíte e os hóspedes
            try
            {
                int dias = Convert.ToInt32(Console.ReadLine());
                Reserva reserva = new Reserva(diasReservados: dias);
                reserva.CadastrarSuite(suite);
                reserva.CadastrarHospedes(hospedes);

                // Exibe a quantidade de hóspedes e o valor da diária
                Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
                Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
            }
            catch (Exception) 
            {
                Console.WriteLine("Somente numeros são permiditos ");
            }
            Console.WriteLine("");
            Console.WriteLine("Precione qualquer tecla.");
            Console.ReadLine();
            Console.WriteLine("");
        break;

        case "0":
            Console.Beep();
            menu = false;
        break;
        default:
            Console.WriteLine("Opção invalida.");
            Console.ReadLine();
        break;
    }
    
}
Console.Clear();
