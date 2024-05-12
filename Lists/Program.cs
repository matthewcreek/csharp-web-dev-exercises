//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

static double AddNums(List<double> nums){
    double sum = 0;
    foreach (double num in nums){
        sum += num;
    };
    return sum;
};

List<double> numList = new() { 1,2,3,4,5,6,7,8,9,10};

System.Console.WriteLine(AddNums(numList));

static void PrintStrings(List<string> strings) {
    System.Console.WriteLine("How many letters do you seek? ");
    int wordLength = int.Parse(Console.ReadLine());
    foreach (string word in strings) {
        if (word.Length == wordLength) {
            System.Console.WriteLine(word);
        }
    }
}

List<string> wordList = new() {"hamburger", "clone", "evil", "apothecary", "xi", "cat"};

PrintStrings(wordList);