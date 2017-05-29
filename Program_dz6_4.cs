using System;

namespace DZ_6_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			var aPoint = new Point3D((long)15, (float)18.6, -8);
			Console.WriteLine(aPoint);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
