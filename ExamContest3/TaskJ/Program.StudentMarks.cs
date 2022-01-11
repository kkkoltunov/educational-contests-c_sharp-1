using System;
using System.Collections.Generic;
using System.Linq;

partial class Program
{
    private static IEnumerable<StudentMark> GetStudentMarks(List<Student> students, List<Work> marks)
    {
        List<StudentMark> studentMarks = new List<StudentMark>();

        double mark;
        double count;

        foreach (Student student in students)
        {
            mark = 0;
            count = 0;

            foreach (Work work in marks)
                if (work.ID == student.ID)
                {
                    mark += work.Mark;
                    count++;
                }

            mark /= count;

            int result = (int)Math.Round((double)mark, MidpointRounding.AwayFromZero);

            studentMarks.Add(new StudentMark(student.FIO, result));
        }

        studentMarks = (from item in studentMarks orderby item.FIO select item).ToList();

        foreach (var item in studentMarks)
            yield return item;
    }
}