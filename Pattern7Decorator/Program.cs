using Pattern7Decorator.ClassDiagramDescription;
using Pattern7Decorator.ConcreteDecorators;
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
             
            Console.WriteLine(" Базовое оружие ");
            IWeapon sword = new BaseSword("Стальной меч", 20, 100m);
            PrintWeapon(sword);
            
            Console.WriteLine("После заточки ");
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

        static void PrintWeapon(IWeapon weapon)
        {
            Console.WriteLine($"Предмет: {weapon.GetDescription()}");
            Console.WriteLine($"Урон: {weapon.GetDamage()}");
            Console.WriteLine($"Цена: {weapon.GetPrice():F2}");
        }
    }
}

