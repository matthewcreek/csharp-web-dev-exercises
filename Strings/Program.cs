﻿//Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

string sentence = @"I would not, could not, in a box. I would not, could not with a fox.
I will not eat them in a house. I will not eat them with a mouse.";

string[] sentenceArray = sentence.Split(".");
System.Console.WriteLine(string.Join(",", sentenceArray));

