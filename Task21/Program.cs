using System;
using System.Collections;
using System.Collections.Generic;

namespace Task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Student> studentList = new List<Student>();
            bool check = true;
            while (check)
            {
                Console.WriteLine("1_Telebe Elave Et : \n2_Telebeye imtahan elave et" +
                "\n3_Telebenin bir imtahan deyerine bax : \n4_Telebenin butun imtahanlarini goster" +
                "\n5_Telebenin imtahan ortalamasini goster : \n6_Telebeden imtahan sil\n0_Programi Bitir : ");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Fullname yazin : ");
                        string fullname = Console.ReadLine();
                        studentList.Add(new Student(fullname));
                        break;
                    case 2:
                        Console.WriteLine("Televe nomrasin yazin : ");
                        int no = int.Parse(Console.ReadLine());
                        Console.WriteLine("Imtahan adi ve neticesini daxil edin ; ");
                        string examName = Console.ReadLine();
                        int point = int.Parse(Console.ReadLine());
                        foreach (var item in studentList)
                        {
                            if (item.No == no)
                            {
                                item.AddExam(examName, point);
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Telebe nomresini yazin : ");
                        no = int.Parse(Console.ReadLine());
                        Console.WriteLine("Exam adini yazin : ");
                        examName = Console.ReadLine();
                        foreach (var item in studentList)
                        {
                            if (item.No == no)
                            {
                                Console.WriteLine(item.GetExamResult(examName));
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Telebe nomresini yaz");
                        no = int.Parse(Console.ReadLine());
                        foreach (var item in studentList)
                        {
                            if (item.No == no)
                            {
                                foreach (var exam in item.Exams)
                                {
                                    Console.WriteLine(exam);
                                }
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Telebenin nomresini yaz : ");
                        no= int.Parse(Console.ReadLine());
                        foreach (var item in studentList)                      
                        {
                            if (item.No == no) Console.WriteLine(item.GetExamAvg()); 
                        }
                        break;
                    case 6:
                        Console.WriteLine("Telebe nomresin yazin : ");
                        no=int.Parse(Console.ReadLine());
                        Console.WriteLine("Silinecey imtahanin adini yazin");
                        examName= Console.ReadLine();
                        foreach (var item in studentList)
                        {
                            if (item.No == no) item.Exams.Remove(examName);
                        }
                        break;
                    case 0:
                        check = false;
                        break;
                    default:
                        break;
                }
            }
            

        }
    }
}
