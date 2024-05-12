//Exercises: Control Flow & Collections

//TODO: Write your code for Array Practice below:
int[] numArray = {1, 1, 2, 3, 5, 8};

for (int i = 0; i < numArray.Length; i++) {
    System.Console.WriteLine(numArray[i]);
};

System.Console.WriteLine("\n");

foreach (int num in numArray) {
    if (num % 2 != 0) {
        System.Console.WriteLine(num);
    }
};
