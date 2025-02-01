using System;
using System.Diagnostics;

class TaskAutomator
{
    static void Main()
    {
        Console.WriteLine("⚙️ Автоматизатор задач для Windows");
        Console.WriteLine("Введіть програму для запуску (наприклад, notepad.exe):");
        string program = Console.ReadLine();
        
        Process.Start(program);
        Console.WriteLine($"✅ {program} запущено!");
    }
}