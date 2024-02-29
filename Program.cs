using ExplorandoLinguagem.Models;
using System.Globalization;

Pessoa p1 = new("Lílian", "Vieira");
Pessoa p2 = new("vfbf", "queiroz");

Curso ingles = new()
{
  Nome = "Inglês",
  Alunos = new List<Pessoa>(),
};

ingles.AdicionarAluno(p1);
ingles.AdicionarAluno(p2);
ingles.ListarAlunos();

// -----------------------------------------------------------

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;
// Console.WriteLine(valorMonetario.ToString("C1"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// DateTime data = DateTime.Parse("29/02/2024 11:00");

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(data.ToString("yyyy/MM/dd HH:mm"));

// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// Console.WriteLine(data);

string data2 = "2024/02/29 14:00";

bool sucesso = DateTime.TryParseExact(data2,
                        "yyyy/MM/dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out DateTime dateT);

if (sucesso)
{
  Console.WriteLine($"Conversão com sucesso! Data: {data2}");
}
else
{
  Console.WriteLine($"{data2} não é uma data válida");
}
