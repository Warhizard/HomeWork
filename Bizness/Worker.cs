
namespace Bizness
{
    public class Worker : Person, IneedWork
    {
        public void OrderForWork()
        {
            Console.WriteLine("Получил задачу от руководства, выполняю ");
        }

        public void CantDoWork()
        {
            Console.WriteLine("Немогу начать работать, т.к не получил задачи ");
        }
    }
}
