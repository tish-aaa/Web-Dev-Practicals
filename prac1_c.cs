using System;
namespace ArrayOfStructs
{
 	class StudentDetails
 	{
 		struct Student
 		{
			 public string studid, name, cname;
			 public int day, month, year;
 		}
 		static void Main()
 		{
 		    int n;
 		    Console.Write("Enter the number of students:");
 		    n= Convert.ToInt32(Console.ReadLine());
			Student[] s = new Student[n];
 			int i,j=1;
            for (i=0;i<2;i++)
            {
 			    Console.Write("Enter Student {0} Details",j);
 			    Console.Write("\n\nEnter Student Id:");
			    s[i].studid = Console.ReadLine();
			    Console.Write("Enter Student name : ");
 			    s[i].name = Console.ReadLine();
 			    Console.Write("Enter Course name : ");
 			    s[i].cname = Console.ReadLine();
			    Console.Write("Enter date of birth\n Enter day(1-31):");
 			    s[i].day = Convert.ToInt32(Console.ReadLine());
 			    Console.Write("Enter month(1-12):");
 			    s[i].month = Convert.ToInt32(Console.ReadLine());
 			    Console.Write("Enter year:");
 			    s[i].year = Convert.ToInt32(Console.ReadLine());
 			    j++;
                Console.Write("\n");
            }
            j=1;
            for (i=0;i<2;i++)
            {
                Console.Write("");
 		        Console.WriteLine("\n\nStudent {0}'s List\n",j);
 		        Console.WriteLine("Student ID : " + s[i].studid);
 		        Console.WriteLine("Student name : " + s[i].name);
 		        Console.WriteLine("Course name : " + s[i].cname);
 		        Console.WriteLine("Date of birth(dd-mm-yy) : " + s[i].day + "-" + s[i].month + "-" + s[i].year);
 		        j++;
            }
 		}    
 	}
 }
