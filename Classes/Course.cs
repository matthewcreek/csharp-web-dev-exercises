using System;
using System.Reflection.Metadata.Ecma335;
using Classes;

namespace Courses;

public class Course
{
    public string Name {get; set;}
    public int Capacity {get; set;}
    public List<Student> Enrolled {get; set;}

    public Course(string name, int capacity, List<Student> enrolled)
    {
        Name = name;
        Capacity = capacity;
        Enrolled = enrolled;
    }

    public Course(string name, List<Student> enrolled): this(name, 30, enrolled) {}
}