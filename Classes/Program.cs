// TODO: Instantiate your objects and test your exercise solutions with print statements here.
using Classes;
using Courses;

Student mCreek = new("Matthew Creek", 1, 1, 4.0);

Console.WriteLine($"{mCreek.Name} (Student ID:{mCreek.StudentId}) has {mCreek.NumberOfCredits} credit hour with a GPA of {mCreek.Gpa}.");
