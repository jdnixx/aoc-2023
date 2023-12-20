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

var linez = File.ReadAllLines(path);

// foreach(var line in lines){
//     line = string.Join(null, System.Text.RegularExpressions.Regex.Split(line, "[A-Za-z]"));
// }

int sum = 0;

string[] lines = {"two1nine", "eightwothree", "abcone2threexyz", "xtwone3four", "4nineeightseven2", "zoneight234", "7pqrstsixteen"};

for (int i = 0; i<lines.Length; i++){
    Console.WriteLine(lines[i]);
    // replace all spelled-out numbers
    lines[i] = lines[i]
    .Replace("one", "1")
    .Replace("two", "2")
    .Replace("three", "3")
    .Replace("four", "4")
    .Replace("five", "5")
    .Replace("six", "6")
    .Replace("seven", "7")
    .Replace("eight", "8")
    .Replace("nine", "9");
    Console.WriteLine(lines[i]);


    // strip all letters
    lines[i] = string.Join(null, System.Text.RegularExpressions.Regex.Split(lines[i], "[A-Za-z]"));
    // case where there is only 1 number
    if (lines[i].Length == 1) {
        lines[i] = string.Concat(Enumerable.Repeat(lines[i], 2));
    }

    string firstNumber = lines[i].Substring(0, 1);
    string lastNumber = lines[i].Substring(lines[i].Length - 1, 1);
    lines[i] = firstNumber + lastNumber;
    sum += int.Parse(lines[i]);

    Console.WriteLine(lines[i]);
    Console.WriteLine(sum);
}