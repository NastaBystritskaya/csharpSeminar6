// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

int[] GetArray(){
    System.Console.WriteLine("Введите числа через запятую: ");
    string Input = System.Console.ReadLine()!;
    string[] StringArray = Input.Split(", ");
    int[] Result = Array.ConvertAll(StringArray, int.Parse);
    return Result; 
}

void CheckTreyg(int[] Array) {
    bool Check = IsTreyg(Array[0], Array[1], Array[2]); 
    if (Check) {
        System.Console.WriteLine("Такой треугольник существует");
    }
    else {
        System.Console.WriteLine("Такой треугольник не существует");
    }
}

bool IsTreyg(int a, int b, int c) {
    bool result = a < b + c;
    bool result1 = b < a + c;
    bool result2 = c < a + b;
    bool total = result && result1 && result2;
    return total;
}

void Main() {
    int[] Array = GetArray();
    CheckTreyg(Array);
}

Main();