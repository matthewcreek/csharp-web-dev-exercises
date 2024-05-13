// //Exercises: Control Flow & Collections

// //TODO: Write your code for Dictionary Practice below:

Dictionary<int, string> students = new Dictionary<int, string>();
string newStudent;

System.Console.WriteLine("Enter your students (or ENTER to finish):");
do 
{
    System.Console.WriteLine("Student: ");
    newStudent = Console.ReadLine();

    if (newStudent != "") 
    {
        System.Console.WriteLine("ID Number: ");
        int newID = int.Parse(Console.ReadLine());
        students.Add(newID, newStudent);
    };  
} 
while (newStudent != "");
    
System.Console.WriteLine("\nClass Roster");
foreach (KeyValuePair<int, string> student in students) 
{
    System.Console.WriteLine("Student name: " + student.Value + "\tID: " + student.Key);
}
System.Console.WriteLine("Total students: " + students.Count);