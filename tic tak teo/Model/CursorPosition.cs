using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tak_teo.Model
{
	internal struct CursorPosition
	{
		public static int Y { get; set; }
		public static int X { get; set; }
		public static int Min_X { get; set; }
		public static int Max_X { get; set; }
		public static int Min_Y { get; set; }
		public static int Max_Y { get; set; }
		public static int Y_Addition { get; set; } = 1;
		public static int X_Addition { get; set; } = 1;


		public static void MoveToDown()
		{
			ClearCursorTire();
			Y = Y >= Max_Y ? Min_Y : Y + Y_Addition;
			Console.SetCursorPosition(X, Y);
		}

		public static void MoveToUp()
		{
			ClearCursorTire();
			Y = Y <= Min_Y ? Max_Y : Y - Y_Addition;
			Console.SetCursorPosition(X, Y);
		}

		public static void MoveToRight()
		{
			ClearCursorTire();
			X = X >= Max_X ? Min_X : X + X_Addition;
			Console.SetCursorPosition(X, Y);
		}

		public static void MoveToLeft()
		{
			ClearCursorTire();
			X = X <= Min_X ? Max_X : X - X_Addition;
			Console.SetCursorPosition(X, Y);
		}
		public static void ClearCursorTire()
		{
			Console.SetCursorPosition(X, Y);
			Console.WriteLine("     ");
		}

		public static void CursorReset()
		{
			X = 0;
			Y = 0;
			Min_X = 0;
			Max_X = 0;
			Min_Y = 0;
			Max_Y = 0;
			Console.SetCursorPosition(X, Y);
		}
	}
}
