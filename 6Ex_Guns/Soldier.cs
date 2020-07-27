using System;
using System.Collections.Generic;
using System.Text;

namespace _6Ex_Guns
{
    class Soldier
    {
        private IGun mainGun;
        private IGun secGun;

        public Soldier(IGun mainGun, IGun secGun)
        {
            this.mainGun = mainGun;
            this.secGun = secGun;
        }

        public void mainShoot()
        {
            Console.WriteLine(this.mainGun.Shoot());
        }
        public void secShoot()
        {
            Console.WriteLine(this.secGun.Shoot());
        }
    }

}
