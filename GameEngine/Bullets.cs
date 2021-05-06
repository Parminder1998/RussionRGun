using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSSIONRGun.GameEngine
{
    class Bullets
    {
        private int[] bullets;

        public Bullets()
        {
            bullets = new int[6];
        }

        //load 1 bullet
        public void LoadBullet(int pos)
        {
            if (pos >= 0 && pos < 6)
            {
                bullets[pos] = 1;
            }
        }

        //Spin the Chamber
        public void Spin()
        {
            int rotations = new Random().Next(1, 13);
            for (int i = 1; i <= rotations; i++)
            {
                int temp = bullets[5];
                for (int j = 5; j > 0; j--)
                {
                    bullets[j] = bullets[j - 1];
                }
                bullets[0] = temp;
            }
        }

        //Fire bullet
        public bool FireBullet(int pos)
        {
            return bullets[pos] == 1;
        }
    }
}
