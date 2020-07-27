using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace _6Ex_Guns
{
    class Tank
    {
        protected IGun mainGun;
        protected IGun secGun;
        protected IGun thirdGun;

        //Definició per 3 armes
        public Tank(IGun mainGun, IGun secGun, IGun thirdGun)
        {
            this.mainGun = mainGun;
            this.secGun = secGun;
            this.thirdGun = thirdGun;
        }

        public void mainShoot()
        {
            Console.WriteLine(this.mainGun.Shoot());
        }
        public void secShoot()
        {
            Console.WriteLine(this.secGun.Shoot());
        }
        public void thirdShoot()
        {
            Console.WriteLine(this.thirdGun.Shoot());
        }
    }
}
