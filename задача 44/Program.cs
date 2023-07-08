// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые числа Фибоначчи: 0 и 1. 
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int GetUserInput() {
    System.Console.WriteLine("Введите число: ");
    int Input = int.Parse(System.Console.ReadLine()!);
    return Input;
}

void PrintFibonache(int input) {
    System.Console.Write("0 1 ");
    for (int i = 1; i < input - 1; i++) {
        if(i == 1 || i==2) {
          System.Console.Write(i + " ");  
        } else {
          System.Console.Write(((i-1) + (i - 2)) + " ");
        }
    }
}

void Main() {
    int UserInput = GetUserInput();
    PrintFibonache(UserInput);
}

Main();