

using System;

namespace Bizness
{

    public class Director : Person, IneedWork
    {
        public void OrderForWork()
        {
            Console.WriteLine("Получил распоряжение от босса, выполняю ");
        }
        public void CantDoWork()
        {
            Console.WriteLine("Нет распоряжений от босса. Жду ");
        }
    }
}
