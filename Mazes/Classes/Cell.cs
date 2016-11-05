using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mazes.Classes
{
    public enum Directions
    {
        N = 0,
        E = 1,
        S = 2,
        W = 3
    }

    public class Cell
    {
        public Point Location { get; set; }
        public int Size { get; set; }
        public List<Directions> Directions {get; set;}

        public bool IsEmpty
        {
            get
            {
                if (this.Directions.Count == 0 || this.Directions == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Cell(Point location, int size)
        {
            this.Location = location;
            this.Size = size;
        }    
    }
}