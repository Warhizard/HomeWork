using System;

namespace Bizness
{
    public class Boss : Person, IneedWork
    {
        public void OrderForWork()
        {
            Console.WriteLine("Мы получили заявку! ");
        }

        public void CantDoWork()
        {
            Console.WriteLine("Думаю, какую работу дать подчиненным ");
        }
    }
}
