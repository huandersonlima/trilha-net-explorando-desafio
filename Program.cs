using System.Text;
using hotel.models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "João");
Pessoa p2 = new Pessoa(nome: "Ellen");


hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria:50);


Reserva reserva = new Reserva(diasReservados: 15);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine("Hóspedes:");
foreach (Pessoa p in hospedes)
{
    Console.WriteLine($"Nome: {p.Nome}");
}

Console.WriteLine($"Quantidade: {reserva.ObterquantidadeHospedes()}");
Console.WriteLine($"Suite: {suite.TipoSuite}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");