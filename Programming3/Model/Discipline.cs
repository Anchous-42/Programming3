namespace Programming3
{
    public class Discipline
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public int Semester { get; set; }
        public int Grade { get; set; }

        public Discipline(string name, string teacher, int semester, int grade)
        {
            Name = name;
            Teacher = teacher;
            Semester = semester;
            Grade = grade;
        }

        public Discipline()
        {
            Name = "Безымянный";
            Teacher = "Неизвестно";
            Semester = 1;
            Grade = 3;
        }
    }
}