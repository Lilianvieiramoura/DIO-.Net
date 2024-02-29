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

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


decimal valorMonetario = 1582.40M;
Console.WriteLine(valorMonetario.ToString("C1"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("yyyy/MM/dd HH:mm"));