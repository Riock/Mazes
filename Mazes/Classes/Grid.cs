using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazes.Classes
{
    public class Grid
    {
        public Cell[,] Cells { get; set; }

        public Grid(int width, int height, int cellsize)
        {
            Cells = new Cell[height / cellsize, width / cellsize];
        }
    }
}
