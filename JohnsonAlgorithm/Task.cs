using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnsonAlgorithm
{
    // Przechowuje: indeks zlecenia, czas na 1 i 2 maszynie
    class Task
    {
        public int Index { get; set; }
        public int MachineOneTime { get; set; }
        public int MachineTwoTime { get; set; }
        // Określenie na której maszynie zadanie wykonało się szybciej
        public bool IsOneFaster()
        {
            if (MachineOneTime <= MachineTwoTime) return true;
            else return false;
        }
    }
}
