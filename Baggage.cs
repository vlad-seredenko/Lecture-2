using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    class Baggage
    {
        private int height;
        private int length;
        private int width;
        private int weight;
        private static int counter;
        private int NumberOfBaggage;
        private const string BAG = "БАГАЖ";


        public Baggage(int height, int length, int width, int weight)
        {
            this.height = height;
            this.length = length;
            this.width = width;
            this.weight = weight;
            NumberOfBaggage = ++counter;

        }

        public int GetVolume()
        {
            return height * length * width;
        }

        

        public int Height
        {
            get { return height; }
            set { height = value > 0 ? value : 0; }
        }
        

    }
}
