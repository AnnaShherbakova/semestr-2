using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Path
    {
        public List<int> Paths { get; set; }   // Последовательность номеров узлов
        public int NumberOfMan { get; set; }   // Количество людей, которых можно провести данным маршрутом

        public Path()
        {
            Paths = new List<int>();
            NumberOfMan = 0;
        }
    }
}