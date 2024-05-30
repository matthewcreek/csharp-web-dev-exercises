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
Console.WriteLine(Divide(6,3));
Console.WriteLine(Divide(6,0));


// --------- Test Student Labs ----------

/*
static int CheckFileExtension(string fileName)
{
    // Write your code here!
}
*/

// Test out your CheckFileExtension() function here!

Dictionary<string, string> students = new Dictionary<string, string>();
students.Add("Carl", "Program.cs");
students.Add("Brad", "");
students.Add("Elizabeth", "MyCode.cs");



