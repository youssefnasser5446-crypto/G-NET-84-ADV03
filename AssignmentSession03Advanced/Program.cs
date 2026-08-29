
using System.Collections.Concurrent;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;
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

            #region Question02

            ////1. Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona" 
            //SortedDictionary<int, string> player = new SortedDictionary<int, string>()
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [800] = "Ali",
            //    [350] = "Mona"
            //};

            ////2.Print all entries(they should be sorted by score automatically)
            //Console.WriteLine("all entries======================");

            //foreach (var (key,value) in player)
            //{
            //    Console.WriteLine($"{key} : {value}"); 
            //}

            ////3. Access the first key and first value 
            //Console.WriteLine("first key and first value==========================");
            //Console.WriteLine($"first key : {player.First().Key}");
            //Console.WriteLine($"first Value : {player.First().Value}");

            ////4. Check if score 500 exists
            //Console.WriteLine("Check if score 500 exists ? ========================================");
            //Console.WriteLine($"contains 500 ? {player.ContainsKey(500)}");

            ////5. Safely get the player with score 999 
            //Console.WriteLine("player with score 999 ===========================================");
            //if (player.TryGetValue(999, out string? result))
            //{
            //    Console.WriteLine(result);
            //}
            //else 
            //{
            //    Console.WriteLine("not found");
            //}
            ////6. Remove the player with score 200 and print the updated list 
            //Console.WriteLine("Remove the player with score 200===================");
            //player.Remove(200);
            //foreach (var (key,value) in player)
            //{
            //    Console.WriteLine($"{key} : {value}");  
            //}


            #endregion
        }
    }
}
