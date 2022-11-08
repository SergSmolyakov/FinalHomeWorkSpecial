using static System.Console;

int limit = 3;
string[] array = AskArray();
string[] result = FindLessThan(array);

WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThan(string[] input) {
    string[] output = new string[CountLessThan(input)];

    for(int i = 0, j = 0; i < limit ; i++) {
        if(input[i].Length <= input.Length) {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}

int CountLessThan(string[] input) {
    int count = 0;

    for(int i = 0; i < limit; i++) {
        if(input[i].Length <= input.Length) {
            count++;
        }
    }
    return count;
}

string[] AskArray() {
    Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}