using Microsoft.VisualBasic;
using System;
using System.Runtime.CompilerServices;

namespace _6Ex_Guns
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            string resposta="";
            while (resposta!="soldat" && resposta != "tanc")
            {
                Console.WriteLine("Menú principal:\nQui ha de disparar? (soldat o tanc)");
                resposta = Console.ReadLine();
            }
            switch (resposta)
            {
                case "soldat":
                    SoldierMenu();
                    break;
                case "tanc":
                    TankMenu();
                    break;
            }

        }
        static void SoldierMenu()
        {
            string gun1;
            string gun2;
            do
            {
                Console.WriteLine("Quina és l'arma principal?");
                Console.WriteLine("(Rifle, Shotgun, Gatling, Revolver)");
                gun1 = Console.ReadLine();
            } while (CheckGun(gun1) == null);

            do
            {
                Console.WriteLine("Quina és l'arma secundària?");
                Console.WriteLine("(Rifle, Shotgun, Gatling, Revolver)");
                gun2 = Console.ReadLine();
            } while (CheckGun(gun2) == null);

            Soldier mySoldier = new Soldier(CheckGun(gun1), CheckGun(gun2));
            SoldierShot(mySoldier);

        }
        static void SoldierShot(Soldier soldier)
        {
            string resposta = "";
            while(resposta != "sortir")
            {
                Console.WriteLine($"Amb quina arma vols disparar? (principal, secundària o sortir)");
                resposta = Console.ReadLine();
                if (resposta == "principal") soldier.mainShoot();
                else if (resposta == "secundària") soldier.secShoot();
            }

        }
        static void TankMenu()
        {
            string gun1;
            string gun2;
            string gun3;
            do
            {
                Console.WriteLine("Quina és l'arma principal?");
                Console.WriteLine("(Rifle, Shotgun, Gatling, Revolver)");
                gun1 = Console.ReadLine();
            } while (CheckGun(gun1) == null);

            do
            {
                Console.WriteLine("Quina és l'arma secundària?");
                Console.WriteLine("(Rifle, Shotgun, Gatling, Revolver)");
                gun2 = Console.ReadLine();
            } while (CheckGun(gun2) == null);
            do
            {
                Console.WriteLine("Quina és l'arma terciària?");
                Console.WriteLine("(Rifle, Shotgun, Gatling, Revolver)");
                gun3 = Console.ReadLine();
            } while (CheckGun(gun3) == null);

            Tank myTank = new Tank(CheckGun(gun1), CheckGun(gun2), CheckGun(gun3));
            TankShot(myTank);
        }
        static void TankShot(Tank tank)
        {
            string resposta = "";
            while (resposta != "sortir")
            {
                Console.WriteLine($"Amb quina arma vols disparar? (principal, secundària, terciària o sortir)");
                resposta = Console.ReadLine();
                if (resposta == "principal") tank.mainShoot();
                else if (resposta == "secundària") tank.secShoot();
                else if (resposta == "terciària") tank.thirdShoot();
            }
        }
        static IGun CheckGun(string name)
        {
            switch (name)
            {
                case "Rifle":
                    Rifle rifle1 = new Rifle();
                    return rifle1;
                case "Shotgun":
                    Shotgun shotgun1 = new Shotgun();
                    return shotgun1;
                case "Gatling":
                    Gatling gatling1 = new Gatling();
                    return gatling1;
                case "Revolver":
                    Revolver revolver1 = new Revolver();
                    return revolver1;
                default:
                    return null;
            }
        }
    }
}
