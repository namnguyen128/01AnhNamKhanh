using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien :");
            //lay so luong sinhvien do nguoi dung nhap
            int numOfStudent;
            try
            {
                numOfStudent = int.Parse(Console.ReadLine());
                InputStudentList(numOfStudent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("chi nhap so!");
            }
            Console.ReadKey();
        }

        private static void InputStudentList(int numOfStudent)
        {
            Student[] studentList = new Student[numOfStudent];
            Student student;
            for(int i = 0; i < numOfStudent; i++)
            {
                student = new Student();
                Console.Write("ID =");
                student.StudentID = int.Parse(Console.ReadLine());
                //tuong tu nhap cac thuoc tinh khac
                studentList[i] = student;
            }
        }
    }
}
