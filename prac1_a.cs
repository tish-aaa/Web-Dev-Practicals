using System;

class Product
{
	static void Main()
	{
		{
 			int n1, n2,n3,n4,prod;
 			Console.Write("Enter 1st Number: ");
			n1 = Int32.Parse(Console.ReadLine());
 			Console.Write("Enter 2nd Number: ");
			n2 = Convert.ToInt32(Console.ReadLine());
 			Console.Write("Enter 3rd Number: ");
 			n3 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter 4th Number: ");
			n4 = Convert.ToInt32(Console.ReadLine());
 			prod = n1 * n2 * n3 * n4;
 			Console.WriteLine(n1 + "*" + n2 + "*" + n3 + "*" + n4 + "=" + prod);
		}
	}
}
