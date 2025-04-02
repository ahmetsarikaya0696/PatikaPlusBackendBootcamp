using Pratik44;

ITeacher teacher = new Teacher("Sertan", "Bozkuş");

Classroom classroom = new Classroom(teacher);

Console.WriteLine("Sınıfın öğretmeni: " + classroom.GetTeacherInfo());