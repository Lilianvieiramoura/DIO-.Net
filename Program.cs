using ExplorandoLinguagem.Models;
using System.Globalization;

// Pessoa p1 = new("Lílian", "Vieira");
// Pessoa p2 = new("vfbf", "queiroz");

// Curso ingles = new()
// {
//   Nome = "Inglês",
//   Alunos = new List<Pessoa>(),
// };

// ingles.AdicionarAluno(p1);
// ingles.AdicionarAluno(p2);
// ingles.ListarAlunos();

// // -----------------------------------------------------------

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

// string data2 = "2024/02/29 14:00";

// bool sucesso = DateTime.TryParseExact(data2,
//                         "yyyy/MM/dd HH:mm",
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None, out DateTime dateT);

// if (sucesso)
// {
//   Console.WriteLine($"Conversão com sucesso! Data: {data2}");
// }
// else
// {
//   Console.WriteLine($"{data2} não é uma data válida");
// }

// --------------------------------------------------------------------


// try
// {
//   string[] linhas = File.ReadAllLines("Arquivos/pasta/arquivosLeitura.txt");

//   foreach (string linha in linhas)
//   {
//     Console.WriteLine(linha);
//   }
// }
// catch (FileNotFoundException ex)
// {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//   Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrada. " + ex.Message);
// }
// catch (Exception ex)
// {
//   Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//   Console.WriteLine("Chegou até aqui");
// }


// new ExemploExcecao().Metodo1();

// Queue<int> fila = new();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//   Console.WriteLine(item);
// }


Stack<int> pilha = new();
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (int item in pilha)
{
  Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

pilha.Push(20);

foreach (int item in pilha)
{
  Console.WriteLine(item);
}