using System;

class Program
{
    static void Main()
    {
        Type myClassType = typeof(MyClass);

        // Создание экземпляра MyClass без прямого вызова конструктора
        object myClassInstance = Activator.CreateInstance(myClassType);

        Console.WriteLine("Экземпляр MyClass создан.");
    }
}
