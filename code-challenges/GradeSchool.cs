using System;
using System.Collections.Generic;

namespace code_challenges
{
    public class GradeSchool
    {
        SortedDictionary<string, int> entireSchool = new SortedDictionary<string, int>();
        public void Add(string student, int grade)
        {
            entireSchool.Add(student, grade);
        }

        public IEnumerable<string> Roster()
        {
            SortedList<int, string> studentsFromEntireSchool = new SortedList<int, string>();
            foreach (KeyValuePair<string, int> entry in entireSchool)
            {
                studentsFromEntireSchool.Add(entry.Value, entry.Key);
            }
            return studentsFromEntireSchool.Values;
        }

        public IEnumerable<string> Grade(int grade)
        {
            SortedSet<string> studentsFromSelectedGrade = new SortedSet<string>();
            foreach (KeyValuePair<string, int> entry in entireSchool)
            {
                if (entry.Value == grade) studentsFromSelectedGrade.Add(entry.Key);
            }
            return studentsFromSelectedGrade;
        }
    }
}
