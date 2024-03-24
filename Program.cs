using ExplorandoLinguagem.Models;
using System.Data;
using System.Globalization;
using Newtonsoft.Json;

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


// Stack<int> pilha = new();
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//   Console.WriteLine(item);
// }


// Dictionary<string, string> estados = new()
// {
//     { "PE", "Pernambuco" },
//     { "AL", "Alagoas" },
//     { "SP", "São Paulo" },
// };

// foreach (KeyValuePair<string, string> item in estados)  // ou var item in estados
// {
//   Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("SP");
// estados["PE"] = "Pernambuco - valor alterado";

// Console.WriteLine("-----");

// foreach (var item in estados)
// {
//   Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "SP";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//   Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//   Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }


// (int Id, string Nome, string Sobrenome) tupla = (1, "Lílian", "Veira");
// Console.WriteLine(tupla.Id);

// ValueTuple<int, string, string, decimal> outraTupla = (1, "Lílian", "Veira", 1.64M);
// var outraTupla2 = Tuple.Create(1, "Lílian", "Veira", 1.64M);


// LeituraArquivo arquivo = new();
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//   // Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
//   foreach (string linha in linhasArquivo)
//   {
//     Console.WriteLine(linha);
//   }
// }
// else
// {
//   Console.WriteLine("Não foi possível ler o arquivo");
// }


// Pessoa p1 = new("Lílian", "vieira");

// (string nome, string sobrenome) = p1;
// Console.WriteLine($"{nome} {sobrenome}");


// int numero = 20;
// bool ehPar = false;

// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));


// if (numero % 2 == 0)
// {
//   Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//   Console.WriteLine($"O número {numero} é ímpar");
// }

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new();

// Venda v1 = new(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new(2, "Material de construção", 35.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string sereializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", sereializado);

// Console.WriteLine(sereializado);

// ISO 8601


string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
  Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto} " +
                    $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyy HH:mm")}");
}