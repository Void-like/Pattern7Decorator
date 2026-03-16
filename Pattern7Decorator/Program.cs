using Pattern7Decorator.ClassDiagramDescription;
using Pattern7Decorator.ConcreteDecorators;
using System;
using System.Text;

namespace Pattern7Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Арсенал Магического Кузнеца ");         
            Console.WriteLine("1.Взять новый меч ");
            Console.WriteLine("2.Заточка ");
            Console.WriteLine("3.Руна Огня ");
            Console.WriteLine("4.Вампиризм  ");
            Console.WriteLine("5.Тест ");
            Console.WriteLine("6.Выход ");
           
            IWeapon sword = new BaseSword("Стальной меч", 20, 100m);
            while (true) {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                         sword = new BaseSword("Стальной меч", 20, 100m);
                        PrintWeapon(sword);
                        break;
                    case "2":
                        sword = new SharpeningDecorator(sword);
                        PrintWeapon(sword);
                        break;
                    case "3":
                        sword = new FireRuneDecorator(sword);
                        PrintWeapon(sword);
                        break;
                    case "4":
                        sword = new VampirismEnchantDecorator(sword);
                        PrintWeapon(sword);
                        break;
                    case "5":
                        Test();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Бред не пиши");
                        break;
                }

            }

        }

        static void PrintWeapon(IWeapon weapon)
        {
            Console.WriteLine($"Предмет: {weapon.GetDescription()}");
            Console.WriteLine($"Урон: {weapon.GetDamage()}");
            Console.WriteLine($"Цена: {weapon.GetPrice()}");
        }
        static void Test()
        {
            Console.WriteLine(" Базовое оружие ");
            IWeapon sword = new BaseSword("Стальной меч", 20, 100m);
            PrintWeapon(sword);

            Console.WriteLine("После заточки");
            IWeapon sharpenedSword = new SharpeningDecorator(sword);
            PrintWeapon(sharpenedSword);


            Console.WriteLine("После заточки и Руны Огня ");
            IWeapon fireSharpenedSword = new FireRuneDecorator(sharpenedSword);
            PrintWeapon(fireSharpenedSword);

            Console.WriteLine("Другой порядок Вампиризм -> Заточка");
            IWeapon newSword = new BaseSword("Стальной меч", 20, 100m);
            IWeapon vampiricSword = new VampirismEnchantDecorator(newSword);
            IWeapon sharpenedVampiricSword = new SharpeningDecorator(vampiricSword);
            PrintWeapon(sharpenedVampiricSword);
        }
    }
}

