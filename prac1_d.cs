using System;

class operations
{
	static void Main()
	{
		{
			int n,f=1,p=2,v=3,r=4;
			Console.Write("OPERATIONS\n1. Fibonacci Series\n2. Test for Prime Numbers\n3. Test for Vowels\n4. Reverse a number and find sum of digits of a number");
			Console.Write("Enter the operation number required:");
			n=Convert.ToInt32(Console.ReadLine());

			if (n==f)
			{
				Console.Write("Enter the limit for the Fibonacci Serie:");
				int fn,a=0,b=1,c=0;
				fn=Int32.Parse(Console.ReadLine());
				while(fn!=0)
				{
					Console.Write(a+", "+b+", ");
					c=a;
					a=b;
					b=c+b;
					fn=fn-1;
				}
			}
			else if(n==p)
			{
				int pn,i=pn/2,temp=1;
				Console.Write("Enter the number: ");
				pn=Convert.ToInt32(Console.ReadLine());
				if(pn==0 || pn==1)
				{
					Console.Write(pn+" is not Prime.");
				}
				else
				{
					while(i>1)
					{
						if(pn%i==0)
						{
							temp=0;
							break;
						}
						else
						{
							temp=1;
						}
					}
					if(temp==0)
					{
						Console.Write(pn+" is not Prime.");
					}
					else
					{
						Console.Write(pn+" is Prime.");
					}
				}
			}
			else if(n==v)
			{
				string vn;
				Console.Write("Enter a letter: ");
				vn=Console.ReadLine();
				if (vn=="a"||vn=="e"||vn=="i"||vn=="o"||vn=="u")
				{
				 	Console.Write(vn+" is a Vowel.);
				}
				else
				{
					Console.Write(vn+" is a Consonant");
				}
			}
			else if(n==r)
			{
				int rn,rev=0,rem,sum=0;
				Console.Write("Enter a number: ");
				rn=Convert.ToInt32(ReadLine());
				while(rn!=0)
				{
					rem=rn%10;
					rev=rev*10+rem;
					sum=sum+rem;
					rn=rn/10;
				}
				Console.Write("Reversed Number: "+rev);
				Console.Write("Sum of Digits: "+sum);
			}
		}
	}	
}				



