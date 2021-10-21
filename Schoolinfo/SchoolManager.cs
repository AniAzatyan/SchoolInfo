using System;

namespace SchoolInfo
{
    public class SchoolManager
    {
        private string[] students;
        private string _name { get; set; }
        private int _foundationYear { get; set; }
        private string _directorName { get; set; }
        public int _classNumber { get; set; }
        public int _eachClassStudentNumber { get; set; }

        public SchoolManager(string name, int year, string directorName)
        {
            _name = name;
            _foundationYear = year;
            _directorName = directorName;
        }
        public void Display()
        {
            Console.WriteLine($"This is {_name} school,founded in {_foundationYear} year and the current director is {_directorName}");
        }
        private int NumberOfStudents(int eachClassNumber, int classNumber)
        {
            return eachClassNumber * classNumber;
        }
        public void Display(string[] students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }

    }
}
