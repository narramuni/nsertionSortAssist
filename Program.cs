

using System;

public class Program
{
     static void Main()
 {
     runApp();
 }
 static void runApp()
 {
     
        string[] students = new string[5];
        students[0] = "praveen";
        students[1] = "kumar";
        students[2] = "pranith";
        students[3] = "kiran";
        students[4] = "srinu";


        int n = students.Length;
        for (int i = 1; i < n; i++)
        {
            string currentStudent = students[i];
            int j = i - 1;

            while (j >= 0 && string.Compare(students[j], currentStudent) > 0)
            {
                students[j + 1] = students[j];
                j--;
            }

            students[j + 1] = currentStudent;
        }

        Console.WriteLine("Sorted List of Students:");
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student}");
            Console.ReadLine();
        }
    }
}

