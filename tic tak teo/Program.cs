using System.Collections.Generic;
using System.Security.Principal;
using tic_tak_teo.Model;

namespace tic_tak_teo
{
	internal class Program
	{
		static void Main()
		{
			Console.CursorVisible = false;

			Console.WriteLine("\n			With Friend");
			Console.WriteLine("			With IA");

			Console.WriteLine(@"


						
			▄▄▄█████▓ ██▓ ▄████▄     ▄▄▄█████▓ ▄▄▄       ██ ▄█▀   ▄▄▄█████▓▓█████  ▒█████  
			▓  ██▒ ▓▒▓██▒▒██▀ ▀█     ▓  ██▒ ▓▒▒████▄     ██▄█▒    ▓  ██▒ ▓▒▓█   ▀ ▒██▒  ██▒
			▒ ▓██░ ▒░▒██▒▒▓█    ▄    ▒ ▓██░ ▒░▒██  ▀█▄  ▓███▄░    ▒ ▓██░ ▒░▒███   ▒██░  ██▒
			░ ▓██▓ ░ ░██░▒▓▓▄ ▄██▒   ░ ▓██▓ ░ ░██▄▄▄▄██ ▓██ █▄    ░ ▓██▓ ░ ▒▓█  ▄ ▒██   ██░
			  ▒██▒ ░ ░██░▒ ▓███▀ ░     ▒██▒ ░  ▓█   ▓██▒▒██▒ █▄     ▒██▒ ░ ░▒████▒░ ████▓▒░
			  ▒ ░░   ░▓  ░ ░▒ ▒  ░     ▒ ░░    ▒▒   ▓▒█░▒ ▒▒ ▓▒     ▒ ░░   ░░ ▒░ ░░ ▒░▒░▒░ 
			    ░     ▒ ░  ░  ▒          ░      ▒   ▒▒ ░░ ░▒ ▒░       ░     ░ ░  ░  ░ ▒ ▒░ 
			  ░       ▒ ░░             ░        ░   ▒   ░ ░░ ░      ░         ░   ░ ░ ░ ▒  
			          ░  ░ ░                        ░  ░░  ░                  ░  ░    ░ ░  
			             ░                                                                 
		

", Console.ForegroundColor = ConsoleColor.Cyan);


			Helper.CursorMoveForMenu(0, 0, 2, 1, 0);

			Console.Clear();


			if (CursorPosition.Y == 1)
			{
				bool Gamer_X = true;

				Console.WriteLine(@"

								------------------------------------
								||---------||---------||---------||
								||         ||         ||         ||
								||         ||         ||         ||
								||         ||         ||         ||
								||---------||---------||---------||
								||---------||---------||---------||
								||         ||         ||         ||
								||         ||         ||         ||
								||         ||         ||         ||
								||---------||---------||---------||
								||---------||---------||---------||
								||         ||         ||         ||
								||         ||         ||         ||
								||         ||         ||         ||
								||---------||---------||---------||
								------------------------------------
", Console.ForegroundColor = ConsoleColor.Cyan);



				List<string> Collection_X = new List<string>(9);

				List<string> Collection_O = new List<string>(9);



				while (true)
				{

					Console.CursorVisible = true;

					Helper.CursorMoveForGame(max_x: 90, min_x: 68, max_y: 15, min_y: 5, X_add: 11, Y_add: 5);

					string n = CursorPosition.X.ToString() + CursorPosition.Y.ToString();


					if (!Collection_X.Contains(n) && !Collection_O.Contains(n))
					{
						Console.SetCursorPosition(CursorPosition.X, CursorPosition.Y);

						if (Gamer_X)
						{
							Collection_X.Add(n);
							Gamer_X = false;
							Console.Write("X");
						}
						else
						{
							Collection_O.Add(n);
							Gamer_X = true;
							Console.Write("O");
						}
					}


					Helper.Check_Winner(Collection_X, Collection_O);

				}
			}


			else if (CursorPosition.Y == 2)
				Console.WriteLine("Tessüf: Bu seçim hələ aktiv deyil", Console.ForegroundColor = ConsoleColor.Red);

			Console.ResetColor();




		}
	}
}