//task 13

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 10;

if ((num / 100) % 10 == 0){
    Console.WriteLine($"Третьей цифры в числе {num} нет");
}
else{
    while ((num / count) % 10 != 0)
    {
        count = count * 10;
        }
    Console.WriteLine((num / (count/1000)) % 10);
    // Console.WriteLine(count);
}
