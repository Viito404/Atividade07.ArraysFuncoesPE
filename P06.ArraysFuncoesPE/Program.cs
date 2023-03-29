using System.Drawing;
using System;

namespace P06.ArraysFuncoesPE
{
     internal class Program
     {
          #region Variáveis Globais;

          static int[] valores = new int[] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1 };

          static int[] tresValores = new int[3];

          static int numeroRemovido = 0;

          #endregion

          static void Main(string[] args)
          {
               do
               {
                    string opcao = MostrarMenu();

                    if (opcao == "S")
                    {
                         Console.ForegroundColor = ConsoleColor.Red;
                         Console.WriteLine("\nSaindo...");
                         Console.ResetColor();
                         break;
                    }

                    VisualizarMaiorValor("O Maior Valor da Sequência é: ");

                    VisualizarMenorValor("\nO Menor Valor Da Sequência é: ");

                    VisualizarMediaValor("\nA Média Dos Valores Da Sequência é: ");

                    int[] tresValores = EncontrarMaiores("\nOs Três Maiores Da Sequência são: ", valores, 3);
                    MostrarValores("", tresValores);

                    int[] valoresNegativos = EncontrarNegativos("\n\nOs Negativos Da Sequência são: ", valores);
                    MostrarValores("", valoresNegativos);

                    MostrarValores("\n\nOs Valores Da Sequência são:\n", valores);

                    int[] novaSequencia = RemoverItemSequencia("\n\nSequência Com Um Número Removido: ", valores);

                    MostrarValores("", novaSequencia);

                    Console.WriteLine($"\n\nNúmero Removido: {numeroRemovido}");

                    Console.ReadLine();

               } while (true);
          }

          #region Funções;

          static string MostrarMenu()
          {
               Console.Clear();
               Console.WriteLine("=============================================");
               Console.WriteLine("\nArrays, Funções e Programação Estruturada\n");
               Console.WriteLine("=============================================");

               Console.Write("\nDigite S para sair, ou qualquer outro botão para continuar:\n> ");

               string opcao;
               opcao = Console.ReadLine();
               opcao = opcao.ToUpper();
               return opcao;
          }

          static void VisualizarMaiorValor(string mensagem)
          {
               Console.Write(mensagem);
               int maiorValor = valores.Max();
               Console.WriteLine(maiorValor);
          }

          static void VisualizarMenorValor(string mensagem)
          {
               Console.Write(mensagem);
               int menorValor = valores.Min();
               Console.WriteLine(menorValor);
          }

          static void VisualizarMediaValor(string mensagem)
          {
               Console.Write(mensagem);
               int mediaValor = valores.Sum() / valores.Length;
               Console.WriteLine(mediaValor);
          }

          static void MostrarValores(string mensagem, int[] valores)
          {
               Console.Write(mensagem);
               foreach (int valor in valores)
               {
                    Console.Write(valor + " ");
               }
          }

          static int[] EncontrarMaiores(string mensagem, int[] valores, int valoresMaiores)
          {
               Console.WriteLine(mensagem);
               return valores.OrderByDescending(x => x).Take(valoresMaiores).ToArray();
          }

          static int[] EncontrarNegativos(string mensagem, int[] valores)
          {
               Console.WriteLine(mensagem);
               return Array.FindAll(valores, x => x < 0);
          }

          static int[] RemoverItemSequencia(string mensagem, int[] valores)
          {
               Console.WriteLine(mensagem);

               List<int> lista = valores.ToList();

               numeroRemovido = 5;
               lista.Remove(numeroRemovido);
               return lista.ToArray();
          }

          #endregion

     }
}