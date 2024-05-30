// --------- Divide By Zero! ----------


static double Divide(double x, double y)
{
    // Write your code here!
    if (y.Equals(0))
    {
        throw new ArgumentOutOfRangeException("y", "Cannot divide by zero!");
    }
    else
    {
        return x/y;
    }
}


// Test out your Divide() function here!
try
{
    Console.WriteLine(Divide(6,3));
    Console.WriteLine(Divide(6,0));
}
catch (ArgumentOutOfRangeException e)
{
    
    Console.WriteLine(e.Message);
}


// --------- Test Student Labs ----------


static int CheckFileExtension(string fileName)
{
    if (fileName.Equals(null) || fileName.Equals(""))
    {
        throw new NullReferenceException("Filename cannot be blank.");
    }
    else if (fileName.Contains(".cs"))
    {
        return 1;
    }
    else return 0;
}


// Test out your CheckFileExtension() function here!

Dictionary<string, string> students = new()
{
    { "Carl", "Program.cs" },
    { "Brad", "" },
    { "Elizabeth", "MyCode.cs" }
};

foreach (KeyValuePair<string,string> student in students)
{
    try
    {
        Console.WriteLine($"{student.Key}: {CheckFileExtension(student.Value)}");   
    }
    catch (NullReferenceException e)
    {
        
        Console.WriteLine($"{student.Key}: {e.Message}");
    }
}


