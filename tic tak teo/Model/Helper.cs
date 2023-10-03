using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tak_teo.Model
{
	internal static class Helper
	{
		public static void CursorMoveForMenu(int max_x = 0, int min_x = 0, int max_y = 0, int min_y = 0, int X_add = 1, int Y_add=1)
		{
			CursorPosition.Min_Y = min_y;
			CursorPosition.Max_Y = max_y;
			CursorPosition.Min_X = min_x;
			CursorPosition.Max_X = max_x;
			CursorPosition.Max_X = max_x;
			CursorPosition.X_Addition = X_add;
			CursorPosition.Y_Addition = Y_add;
			CursorPosition.X = CursorPosition.Min_X;
			CursorPosition.Y = CursorPosition.Min_Y;
			Console.SetCursorPosition(min_x, min_y);
			Console.Write("|-->>", Console.ForegroundColor = ConsoleColor.Cyan);

			while (true)
			{
				ConsoleKey consoleKey = Console.ReadKey(true).Key;
				CursorPosition.ClearCursorTire();

				if (consoleKey == ConsoleKey.UpArrow)
				{
					CursorPosition.MoveToUp();
					Console.Write("|-->>", Console.ForegroundColor = ConsoleColor.Cyan);
				}

				else if (consoleKey == ConsoleKey.DownArrow)
				{
					CursorPosition.MoveToDown();
					Console.Write("|-->>", Console.ForegroundColor = ConsoleColor.Cyan);
				}

				else if (consoleKey == ConsoleKey.LeftArrow)
				{
					CursorPosition.MoveToLeft();
					Console.Write("|-->>", Console.ForegroundColor = ConsoleColor.Cyan);
				}

				else if (consoleKey == ConsoleKey.RightArrow)
				{
					CursorPosition.MoveToRight();
					Console.Write("|-->>", Console.ForegroundColor = ConsoleColor.Cyan);
				}

				else if (consoleKey == ConsoleKey.Escape)
					Environment.Exit(0);

				else if (consoleKey == ConsoleKey.Enter)
					break;

			}
		}


		public static void CursorMoveForGame(int max_x = 0, int min_x = 0, int max_y = 0, int min_y = 0, int X_add = 1, int Y_add = 1)
		{
			CursorPosition.Min_Y = min_y;
			CursorPosition.Max_Y = max_y;
			CursorPosition.Min_X = min_x;
			CursorPosition.Max_X = max_x;
			CursorPosition.Max_X = max_x;
			CursorPosition.X_Addition = X_add;
			CursorPosition.Y_Addition = Y_add;
			CursorPosition.X = CursorPosition.Min_X;
			CursorPosition.Y = CursorPosition.Min_Y;
			Console.SetCursorPosition(min_x, min_y);

			while (true)
			{
				ConsoleKey consoleKey = Console.ReadKey(true).Key;

				if (consoleKey == ConsoleKey.DownArrow)
				{
					CursorPosition.Y = CursorPosition.Y >= CursorPosition.Max_Y ? CursorPosition.Min_Y : CursorPosition.Y + CursorPosition.Y_Addition;
					Console.SetCursorPosition(CursorPosition.X, CursorPosition.Y);
				}

				else if (consoleKey == ConsoleKey.UpArrow)
				{
					CursorPosition.Y = CursorPosition.Y <= CursorPosition.Min_Y ? CursorPosition.Max_Y : CursorPosition.Y - CursorPosition.Y_Addition;
					Console.SetCursorPosition(CursorPosition.X, CursorPosition.Y);
				}

				else if (consoleKey == ConsoleKey.LeftArrow)
				{
					CursorPosition.X = CursorPosition.X <= CursorPosition.Min_X ? CursorPosition.Max_X : CursorPosition.X - CursorPosition.X_Addition;
					Console.SetCursorPosition(CursorPosition.X, CursorPosition.Y);
				}

				else if (consoleKey == ConsoleKey.RightArrow)
				{
					CursorPosition.X = CursorPosition.X >= CursorPosition.Max_X ? CursorPosition.Min_X : CursorPosition.X + CursorPosition.X_Addition;
					Console.SetCursorPosition(CursorPosition.X, CursorPosition.Y);
				}

				else if (consoleKey == ConsoleKey.Escape)
					Environment.Exit(0);

				else if (consoleKey == ConsoleKey.Enter)
					break;

			}
		}

		public static void Wait(int second)
		{
			Thread.Sleep(second);
			while (Console.KeyAvailable) // This is waiting for the sleep time to end.and it does not save the keys or print them on the screen.
			{
				Console.ReadKey(true);
			}
		}

		public static void Check_Winner(List<string> Collection_X, List<string> Collection_O)
		{
			if (Collection_X.Contains("685") && Collection_X.Contains("7910") && Collection_X.Contains("9015"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


██╗  ██╗    ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
╚██╗██╔╝    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
 ╚███╔╝     ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
 ██╔██╗     ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
██╔╝ ██╗    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
╚═╝  ╚═╝    ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                         
			                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_X.Contains("685") && Collection_X.Contains("795") && Collection_X.Contains("905"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


██╗  ██╗    ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
╚██╗██╔╝    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
 ╚███╔╝     ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
 ██╔██╗     ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
██╔╝ ██╗    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
╚═╝  ╚═╝    ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                         
			                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_X.Contains("685") && Collection_X.Contains("6810") && Collection_X.Contains("6815"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


██╗  ██╗    ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
╚██╗██╔╝    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
 ╚███╔╝     ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
 ██╔██╗     ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
██╔╝ ██╗    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
╚═╝  ╚═╝    ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                         
			                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_X.Contains("6810") && Collection_X.Contains("7910") && Collection_X.Contains("9010"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


██╗  ██╗    ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
╚██╗██╔╝    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
 ╚███╔╝     ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
 ██╔██╗     ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
██╔╝ ██╗    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
╚═╝  ╚═╝    ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                         
			                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_X.Contains("6815") && Collection_X.Contains("7915") && Collection_X.Contains("9015"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


██╗  ██╗    ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
╚██╗██╔╝    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
 ╚███╔╝     ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
 ██╔██╗     ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
██╔╝ ██╗    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
╚═╝  ╚═╝    ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                         
			                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_X.Contains("795") && Collection_X.Contains("7910") && Collection_X.Contains("7915"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


██╗  ██╗    ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
╚██╗██╔╝    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
 ╚███╔╝     ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
 ██╔██╗     ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
██╔╝ ██╗    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
╚═╝  ╚═╝    ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                         
			                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_X.Contains("905") && Collection_X.Contains("9010") && Collection_X.Contains("9015"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


██╗  ██╗    ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
╚██╗██╔╝    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
 ╚███╔╝     ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
 ██╔██╗     ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
██╔╝ ██╗    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
╚═╝  ╚═╝    ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                         
			                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_X.Contains("905") && Collection_X.Contains("7910") && Collection_X.Contains("6815"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


██╗  ██╗    ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
╚██╗██╔╝    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
 ╚███╔╝     ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
 ██╔██╗     ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
██╔╝ ██╗    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
╚═╝  ╚═╝    ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                         
			                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}


			if (Collection_O.Contains("685") && Collection_O.Contains("7910") && Collection_O.Contains("9015"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


 ██████╗     ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
██╔═══██╗    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
██║   ██║    ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
██║   ██║    ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
╚██████╔╝    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
 ╚═════╝     ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_O.Contains("685") && Collection_O.Contains("795") && Collection_O.Contains("905"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


 ██████╗     ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
██╔═══██╗    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
██║   ██║    ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
██║   ██║    ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
╚██████╔╝    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
 ╚═════╝     ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_O.Contains("685") && Collection_O.Contains("6810") && Collection_O.Contains("6815"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


 ██████╗     ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
██╔═══██╗    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
██║   ██║    ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
██║   ██║    ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
╚██████╔╝    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
 ╚═════╝     ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_O.Contains("6810") && Collection_O.Contains("7910") && Collection_O.Contains("9010"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


 ██████╗     ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
██╔═══██╗    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
██║   ██║    ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
██║   ██║    ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
╚██████╔╝    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
 ╚═════╝     ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_O.Contains("6815") && Collection_O.Contains("7915") && Collection_O.Contains("9015"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


 ██████╗     ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
██╔═══██╗    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
██║   ██║    ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
██║   ██║    ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
╚██████╔╝    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
 ╚═════╝     ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_O.Contains("795") && Collection_O.Contains("7910") && Collection_O.Contains("7915"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


 ██████╗     ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
██╔═══██╗    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
██║   ██║    ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
██║   ██║    ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
╚██████╔╝    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
 ╚═════╝     ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_O.Contains("905") && Collection_O.Contains("9010") && Collection_O.Contains("9015"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


 ██████╗     ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
██╔═══██╗    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
██║   ██║    ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
██║   ██║    ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
╚██████╔╝    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
 ╚═════╝     ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}
			else if (Collection_O.Contains("905") && Collection_O.Contains("7910") && Collection_O.Contains("6815"))
			{
				Console.CursorVisible = false;
				Wait(2000);
				Console.Clear();
				Console.WriteLine(@"


 ██████╗     ██╗███████╗    ████████╗██╗  ██╗███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ 
██╔═══██╗    ██║██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗
██║   ██║    ██║███████╗       ██║   ███████║█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝
██║   ██║    ██║╚════██║       ██║   ██╔══██║██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗
╚██████╔╝    ██║███████║       ██║   ██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║
 ╚═════╝     ╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝
                                                                                                          

", Console.ForegroundColor = ConsoleColor.Green);
				return;
			}

		}


	}
}
