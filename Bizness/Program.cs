using Bizness;
var exit = false;
do
{
    Console.WriteLine("Информация о компании:");
    Console.WriteLine("1. Руководитель компании");
    Console.WriteLine("2. Директор");
    Console.WriteLine("3. Сотрудник");
    Console.WriteLine("0. Выход");
    var input = Console.ReadLine();

   Person person = null;

    switch (input)
    {
        case "1":
            person = new Boss();
            break;
        case "2":
            person = new Director();
            break;
        case "3":
            person = new Worker();
            break;
        case "0":
            exit = true;
            break;
        default:
            Console.WriteLine("Ошибка ввода! Повторите ввод");
            break;
    }

    PrintInfo(person);

} while (!exit);

void PrintInfo(Person person)
{
    if (person is Worker)
    {
        ((Worker)person).OrderForWork();
        ((Worker)person).CantDoWork();

    }
    else if (person is Director)
    {
        ((Director)person).OrderForWork();
        ((Director)person).CantDoWork();

    }
    else
    {
        ((Boss)person).OrderForWork();
        ((Boss)person).CantDoWork();
    }
}

