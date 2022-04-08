using System;
using System.Collections.Generic;
using System.Text;

namespace Task21
{
    internal class Student
    {
        public Student(string name)
        {
            FullName = name;
            _no++;
            No = _no;
        }
        public Student()
        {
            _no++;
            No = _no;
        }
        public int No { get; set; }
        public string FullName;
        private static int _no;
        public Dictionary<string,int> Exams = new Dictionary<string,int>();
        public void AddExam(string examName , int point)
        {
            Exams.Add(examName, point);
        }
        public int GetExamResult(string examName)
        {
            foreach (var item in Exams)
            {
                if (item.Key == examName) return item.Value;
            }
            return 0;
        }
        public double GetExamAvg()
        {
            double totalCount = 0;
            double count = 0;
            foreach (var item in Exams)
            {
                totalCount += item.Value;
                count++;
            }
            return totalCount / count;
        }


    }
}
