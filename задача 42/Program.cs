// Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 44 -> 101100
// 3 -> 11
// 2 -> 10 

int GetUserInput() {
    System.Console.WriteLine("Введите число: ");
    int Input = int.Parse(System.Console.ReadLine()!);
    return Input;
}

void PrintBinary(int input) {
    string Result = Convert.ToString(input, 2);
    System.Console.WriteLine(Result);
}

void Main() {
    int UserInput = GetUserInput();
    PrintBinary(UserInput);
}

Main();