using Pratik11;

// Create a new Person object representing a teacher
Person teacher = new Person()
{
    Name = "Sertan",     // Assign the teacher's first name
    Surname = "Bozkuş",  // Assign the teacher's last name
    IsStudent = false,    // Specify that this person is not a student
    BirthDate = new DateTime(1996, 6, 20) // Assign the teacher's birth date
};

// Call the method to display the teacher's properties
teacher.DisplayProperties();

// Create a new Person object representing a student
Person student = new Person()
{
    Name = "Ahmet",      // Assign the student's first name
    Surname = "Sarıkaya", // Assign the student's last name
    IsStudent = true,     // Specify that this person is a student
    BirthDate = new DateTime(1996, 1, 1) // Assign the student's birth date
};

// Call the method to display the student's properties
student.DisplayProperties();