using ExplorandoLinguagem.Models;

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



