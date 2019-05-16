//
// Algorytm Johnsona
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnsonAlgorithm
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfTasks;
            Console.Write("Podaj liczbe zadan: ");

            while (int.TryParse(Console.ReadLine(), out NumberOfTasks) == false)
            {
                Console.WriteLine("Bledna liczba zadan. Podaj poprawna liczbe zadan: ");
            }
            List<Task> tasksList = new List<Task>();

            //inicjalizacja list czasami zadań na poszczególnych maszynach
            for (int i = 0; i < NumberOfTasks; i++)
            {
                Console.Write($"Podaj czas zadania {i + 1} dla maszyny 1: ");
                int firstTime;
                while (int.TryParse(Console.ReadLine(), out firstTime) == false)
                {
                    Console.WriteLine("Bledna czas maszyny 1. Podaj poprawny czas: ");
                }

                Console.Write($"Podaj czas zadania {i + 1} dla maszyny 2: ");
                int secondTime;
                while (int.TryParse(Console.ReadLine(), out secondTime) == false)
                {
                    Console.WriteLine("Bledna czas maszyny 2. Podaj poprawny czas: ");
                }

                Task temp = new Task()
                {
                    Index = i + 1,
                    MachineOneTime = firstTime,
                    MachineTwoTime = secondTime
                };
                tasksList.Add(temp);
            }

            List<Task> MachineOneList = new List<Task>();
            List<Task> MachineTwoList = new List<Task>();
            //Wybór zleceń gdzie czas wykonania na maszynie 1 jest mniejszy lub równy czasowi wykonania tego samego zadania na maszynie 2
            foreach (Task currentTask in tasksList)
            {
                if (currentTask.IsOneFaster()) MachineOneList.Add(currentTask);
                else MachineTwoList.Add(currentTask);
            }
            // Sortowanie 1 czesci
            MachineOneList.Sort((first, second) => first.MachineOneTime.CompareTo(second.MachineOneTime));
            // Sortowanie 2 czesci
            MachineTwoList.Sort((first, second) => second.MachineTwoTime.CompareTo(first.MachineTwoTime));

            foreach (Task item in MachineOneList)
            {
                Console.WriteLine($"Zlecenie {item.Index}: czas wykonania przez wybraną maszynę: {item.MachineOneTime} ");
            }

            foreach (Task item in MachineTwoList)
            {
                Console.WriteLine($"Zlecenie {item.Index}: czas wykonania przez wybraną maszynę: {item.MachineOneTime} ");
            }
            Console.ReadKey();
        }
    }
}