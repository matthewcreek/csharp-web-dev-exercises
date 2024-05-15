//Classes part 2 exercises

// TODO: Test your exercise solutions with print statements here.

using Classes_Part_2;

Student student = new("Matt");
Console.WriteLine(student.ToString());

student.AddGrade(3,4.0);
Console.WriteLine(student.ToString());

student.AddGrade(4,3.0);
Console.WriteLine(student.ToString());

Student student2 = new("Marina", 1);
Student student3 = new("Richard");

Console.WriteLine(student.Equals(student2));
Console.WriteLine(student.Equals(student3));

Student student4 = new("Binny",4,90,4.0);

Console.WriteLine(student.GetGradeLevel(student.NumberOfCredits));
Console.WriteLine(student4.GetGradeLevel(student4.NumberOfCredits));
