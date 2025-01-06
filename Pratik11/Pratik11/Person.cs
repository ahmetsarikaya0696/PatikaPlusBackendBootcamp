namespace Pratik11
{
    public class Person
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public bool IsStudent { get; set; }
        public bool IsTeacher => !IsStudent;

        public void DisplayProperties()
        {
            Console.WriteLine($"Merhaba benim adım {Name} {Surname}. Ben bir {(IsStudent ? "öğrenciyim" : "öğretmenim")}");
        }
    }
}
