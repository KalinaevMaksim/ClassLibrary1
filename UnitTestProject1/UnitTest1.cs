using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Class1 class1 = new Class1();

        [TestMethod]
        public void TestMinAVG()
        {
            int wait = 4;

            Console.WriteLine(wait);

            double result = class1.MinAVG(new string[]
            {
                "5",
                "5",
                "5",
                "5",
                "5",
                "5",
                "5",
                "4",
            });

            Console.WriteLine(result);
        }

        [TestMethod]
        public void TestGetCountTruancy()
        {
            List<Mark> marks = new List<Mark>()
            {
                new Mark() { date = DateTime.Today.AddMonths(4), Estimation = "п" },
                new Mark() { date = DateTime.Today.AddMonths(5), Estimation = "п" },
                new Mark() { date = DateTime.Today, Estimation = "н" },
                new Mark() { date = DateTime.Today, Estimation = "4" },
                new Mark() { date = DateTime.Today, Estimation = "4" },
                new Mark() { date = DateTime.Today, Estimation = "5" },
                new Mark() { date = DateTime.Today, Estimation = "2" },
                new Mark() { date = DateTime.Today, Estimation = "п" },
                new Mark() { date = DateTime.Today, Estimation = "п" },
            };

            Console.WriteLine(string.Join(", ", marks.Select(mark => $"{mark.Estimation} - {mark.date.ToShortDateString()}")));

            int[] result = class1.GetCountTruancy(marks);
            Console.WriteLine(string.Join(", ", result));
        }

        [TestMethod]
        public void TestGetCountDisease()
        {
            List<Mark> marks = new List<Mark>()
            {
                new Mark() { date = DateTime.Today.AddMonths(1), Estimation = "б" },
                new Mark() { date = DateTime.Today.AddMonths(2), Estimation = "б" },
                new Mark() { date = DateTime.Today, Estimation = "н" },
                new Mark() { date = DateTime.Today, Estimation = "4" },
                new Mark() { date = DateTime.Today, Estimation = "4" },
                new Mark() { date = DateTime.Today, Estimation = "5" },
                new Mark() { date = DateTime.Today, Estimation = "2" },
                new Mark() { date = DateTime.Today, Estimation = "б" },
                new Mark() { date = DateTime.Today, Estimation = "б" },
            };

            int[] result = class1.GetCountDisease(marks);

            Console.WriteLine(string.Join(", ", marks.Select(mark => $"{mark.Estimation} - {mark.date.ToShortDateString()}")));

            Console.WriteLine(string.Join(", ", result));
        }

        [TestMethod]
        public void TestGetStudNumber()
        {
            string wait = "2010.1281.КМВ";
            Console.WriteLine(wait);
            Console.WriteLine("2010, 1281, Калинаев Максим Витальевич");

            string result = class1.GetStudNumber(2010, 1281, "Калинаев Максим Витальевич");
            Console.WriteLine(result);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void TestGetMarks()
        {
            List<Student> marks = new List<Student>()
            {
                new Student() { },
                new Student() { },
                new Student() { },
                new Student() { },
                new Student() { },
                new Student() { },
                new Student() { },
                new Student() { },
            };
            List<Mark> marks1 = class1.GetMarks(DateTime.Now, marks);
            Console.WriteLine(string.Join(", ", marks1.Select(mark => mark.Estimation)));
        }
    }
}
