// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

string path = "./input.txt";

// List<string> lines = new List<string>();

// using(FileStream fs = File.OpenRead(path)){
//     using (var streamReader = new StreamReader(fs)){
//         string line;
//         while ((line = streamReader.ReadLine()) != null){
//             lines.Add(line);
//         }
//     }
// }

var lines = File.ReadAllLines(path);
// string[] lines = {"two1nine", "eightwothree", "abcone2threexyz", "xtwone3four", "4nineeightseven2", "zoneight234", "7pqrstsixteen"};

// foreach(var line in lines){
//     line = string.Join(null, System.Text.RegularExpressions.Regex.Split(line, "[A-Za-z]"));
// }

int sum = 0;

for (int i = 0; i<lines.Length; i++){
    Console.WriteLine(lines[i]);
    // replace all spelled-out numbers
    // NOTE: have to leave leading & trailing character,
    // or else subsequent replacements may miss adjacent number-words (like "eightwo")
    lines[i] = lines[i]
    .Replace("one", "o1e")
    .Replace("two", "t2o")
    .Replace("three", "t3e")
    .Replace("four", "f4r")
    .Replace("five", "f5e")
    .Replace("six", "s6x")
    .Replace("seven", "s7n")
    .Replace("eight", "e8t")
    .Replace("nine", "n9e");
    Console.WriteLine(lines[i]);

    int firstNumber = lines[i].First(c => char.IsDigit(c)) - '0';
    int lastNumber = lines[i].Last(c => char.IsDigit(c)) - '0';
    int entireNumber = firstNumber*10 + lastNumber;
    Console.WriteLine(entireNumber);
    sum += entireNumber;

    Console.WriteLine(sum);
}