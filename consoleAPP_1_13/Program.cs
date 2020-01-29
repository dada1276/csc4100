using System;

namespace consoleAPP_1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[] { 99, 96, 92, 97, 95 };
            string[] students = new string[] { "Momo", "Larry", "Curly", "Shemp", "Jojo" };
            double[] exams = new double[] { 99.4, 100, 99.9, 96.9, 88.8 };
            double[] grade = calcGrade(marks, exams);
            //Console.WriteLine("Grades=" + grade.ToString());
            outputValues(students, marks, exams, grade);
        }

        private static void outputValues(string[] students, int[] marks, double[] exams, double[] grade)
        {
            int ctr = 0;
            foreach(string s in students)
            {
                Console.WriteLine("\ns:{0} x:{2} Aver:{3}", s, marks[ctr], exams[ctr], grade[ctr]);
                ctr += 1;
            }
        }
        private static double[] calcGrade(int[] marks, double[] exams)
        {
            double[] retGrades = new double[exams.Length];
            var ctr = 0;
            foreach( double e in exams)
            {
                retGrades[ctr] = (e + marks[ctr++]) / 2;
            };
            return retGrades;
        }
    }
}
