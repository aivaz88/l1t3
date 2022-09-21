Console.Clear();

Console.Write("Введите первое число: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0){
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}