using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace genshinpingpong
{
    internal class Particles
    {
        public int height;
        public int width;
        public int posX;
        public int posY;
        public int[] sizes = { 30, 40, 50 };
        Random random = new Random();
        public int speed = 0;
        int i = 0;
        public Image particle;
        public Particles(string fileLocation)
        {
            particle = Image.FromFile(fileLocation);
            i = random.Next(0, sizes.Length);
            height = sizes[i];
            width = sizes[i];
            posX = random.Next(-200, 800);
            posY = random.Next(-700, -200);
            speed = random.Next(1, 10);
        }

    }
}
