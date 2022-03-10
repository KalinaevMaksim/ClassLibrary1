using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public double MinAVG(string[] marks)
        {
            double minAvg = Math.Floor(marks.Select(mark => double.Parse(mark)).Average());
            return minAvg;
        }

        public int[] GetCountTruancy(List<Mark> marks)
        {
            int[] countTruancy = new int[12];

            for (int i = 0; i < countTruancy.Length; i++)
            {
                IEnumerable<Mark> v = marks.Where(mark => mark.date.Month == i + 1);
                countTruancy[i] = (int)v.Count(mark => mark.Estimation.ToLower() == "п");
            }

            return countTruancy;
        }

        public int[] GetCountDisease(List<Mark> marks)
        {
            int[] сountDisease = new int[12];

            for (int i = 0; i < сountDisease.Length; i++)
            {
                сountDisease[i] = (int)(marks.Where(mark => mark.date.Month == i + 1)?.Count(mark => mark.Estimation.ToLower() == "б"));
            }

            return сountDisease;
        }

        public string GetStudNumber(int year, int group, string fio)
        {
            string[] fios = fio.Split(' ');
            string studNumber = $"{year}.{group}.{fios[0][0]}{fios[1][0]}{fios[2][0]}";
            return studNumber;
        }

        public List<Mark> GetMarks(DateTime now, List<Student> students)
        {
            List<Mark> marks = new List<Mark>();
            Random random = new Random();

            foreach (var student in students)
            {
                List<Mark> marksStudent = new List<Mark>();

                for (int i = 0; i < 10; i++)
                {
                    marksStudent.Add(new Mark() { date = DateTime.Today, Estimation = Mark.Estimations[random.Next(0, Mark.Estimations.Count)] });
                }

                student.Marks.AddRange(marksStudent);
                marks.AddRange(marksStudent);
            }

            return marks;
        }
    }
}
