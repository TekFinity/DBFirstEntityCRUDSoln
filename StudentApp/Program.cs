using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
   public class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("EDM CRUD Operations");
            
            do
            {
                EdmOperation obj = new EdmOperation();
                Console.WriteLine("Select Below Options: ");
                Console.WriteLine("1.Create 2.Read 3.Update 4.Delete 5.Exit");
                 choice = Convert.ToString( Console.ReadLine());
                switch (choice)
                {
                    case "1":
                        CreateStudent(obj);
                        break;
                    case "2": ReadStudent(obj);
                        break;
                    case "3":
                        UpdateStudent(obj);
                        break;
                    case "4":
                        DeleteStudent(obj);
                        break;
                    


                    default:
                        break;
                }

            } while (choice != "5");
         
        }

       private static void CreateStudent(EdmOperation obj)
        {
            student s = new student();

            Console.WriteLine("Enter Student Details-");
            Console.Write("Enter Name-");
             s.NAME = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Branch-");
            s.BRANCH = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Score-");
            s.SCORE = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Div-");
            s.DIVISION = Console.ReadLine();
            Console.ReadLine();
            obj.insertOperation(s);
        }
        private static void ReadStudent(EdmOperation obj)
        {
           List<student> allStudent = new List<student>();
            var studentList = obj.ReadOperation();
            Console.WriteLine("All Student Details are-");
            foreach (var student in studentList)
            {
                student s = new student();
                s.NAME = student.NAME;
                s.BRANCH = student.BRANCH;
                s.ID = student.ID;
                s.SCORE = student.SCORE;
                s.DIVISION = student.DIVISION;
                allStudent.Add(s);
                Console.WriteLine(s.ID + "  " + s.NAME + "  " + s.BRANCH + "  " + s.DIVISION + "  " + s.SCORE);
            }


        }
        private static void UpdateStudent(EdmOperation obj)
        {
            Console.WriteLine("Enter student name :");
            var name =Convert.ToString(Console.ReadLine());
            var sData = obj.updateOperation(name);
            student sd = new student();
            sd.ID = sData.ID;
            sd.NAME = sData.NAME;
            sd.BRANCH = sData.BRANCH;
            sd.DIVISION = sData.DIVISION;
            sd.SCORE = sData.SCORE;
            Console.WriteLine(sd.ID + "  " + sd.NAME + "  " + sd.BRANCH + "  " + sd.DIVISION + "  " + sd.SCORE);
            Console.WriteLine("Enter new Student Details-");
            Console.Write("Enter Name-");
            sd.NAME = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Branch-");
            sd.BRANCH = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Score-");
            sd.SCORE = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Div-");
            sd.DIVISION = Console.ReadLine();
            Console.ReadLine();
            sData.ID = sd.ID;
            sData.NAME = sd.NAME;
            sData.BRANCH = sd.BRANCH;
            sData.DIVISION = sd.DIVISION;
            sData.SCORE = sd.SCORE;

            obj.SaveUpdate(sData);


        }
        private static void DeleteStudent(EdmOperation obj)
        {

        }

    }
}
