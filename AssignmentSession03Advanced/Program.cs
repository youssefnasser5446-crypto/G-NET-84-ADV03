
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentSession03Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            ////1. Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            ////2. Print the collection, Count, first and last grade 

            //Console.WriteLine(" collection is ");
            //Console.WriteLine(string.Join(",", grades));

            //Console.WriteLine($"count of grades {grades.Count}");                    
            //Console.WriteLine(" first garde ! ");
            //Console.WriteLine(grades[0]);

            //Console.WriteLine(" last garde ! ");
            //Console.WriteLine(grades[grades.Count-1]);

            ////3. Sort the grades ascending, then print 
            //Console.WriteLine(" sorted garde ! ");
            //List<int> sortedlist =new(grades);
            //sortedlist.Sort();
            //Console.WriteLine(string.Join(',', sortedlist));

            ////4. Get the first grade above 90 
            //Console.WriteLine("first grade above 90");
            //Console.WriteLine(grades.Find(g=> g>90));

            ////5.Get all grades below 75(failing grades)
            //Console.WriteLine("All grades below 75");
            //List<int> below = grades.FindAll(g => g < 75);
            //Console.WriteLine(string.Join(',', below));

            ////6. Remove all failing grades (below 75) 
            //Console.WriteLine("All grades After remove");
            // grades.RemoveAll(g=> g < 75);
            //Console.WriteLine(string.Join(',', grades));

            ////7.Check if any grade equals 100
            //Console.WriteLine($"any grade equals 100? {grades.Contains(100)}");

            ////8. Create a List<string> where each grade becomes "Grade: X" 

            //List<string> strGrade = new List<string>();
            //foreach (int item in grades)
            //{
            //    strGrade.Add($"Grade: {item}");
            //}
            //Console.WriteLine(string.Join(',', strGrade));
            #endregion
        }
    }
}
