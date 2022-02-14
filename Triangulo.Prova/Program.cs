using System;

namespace Triangulo.Prova
{
    internal class Program
    {
		static void Main(string[] args)
		{

			string opcao = "";
			while (opcao != "s")

			{                
				Console.WriteLine("Digite E para descobrir o tipo do triangulo\nDigite S para sair do aplicativo");
				opcao = Console.ReadLine();
				if (opcao == "s")
					break;
				
				if (opcao == "e")
				{
					Console.WriteLine("ESCREVA OS LADOS DO TRIÂNGULO X,Y,Z um de cada vez respectivamente:");
				}
				else if (opcao != "e" || opcao != "s")
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Opção invalida, tente novamente");
					Console.ReadLine();
					Console.ResetColor();
					Console.Clear();
					continue;
				}
				
				int x, y, z;

				x = Convert.ToInt32(Console.ReadLine());
				y = Convert.ToInt32(Console.ReadLine());
				z = Convert.ToInt32(Console.ReadLine());
				
				if (x <= 0 || y <= 0 || z <= 0)
				{	
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Seu triangulo é invalido");
					Console.ReadLine();
					Console.ResetColor();
					Console.Clear();
				}

					else if (x + y < z || x + z < y || y + z < x)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Seu triangulo é inválido");
						Console.ReadLine();
						Console.ResetColor();
						Console.Clear();
					}

					else if (x == y && y == z)
									 
					{
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.WriteLine("SEU TRIANGULO É EQUILATERO");
						Console.ReadLine();
						Console.ResetColor();
						Console.Clear();
					}

					else if (x == y && y != z || x != y && y == z || x == z && x != y)											
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("SEU TRIANGULO É ISOSCELES");
						Console.ReadLine();
						Console.ResetColor();
						Console.Clear();
					}

					else if (x != y && y != z && x != z)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("SEU TRIANGULO É ESCALENO");
						Console.ReadLine();
						Console.ResetColor();
						Console.Clear();
					}									
			}
		}	
    }
}
