using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7Decorator.ClassDiagramDescription
{
    public class BaseSword : IWeapon
    {
        private int _baseDamage;
        private decimal _basePrice;
        private string _name;

        public BaseSword(string name, int damage, decimal price)
        {
            _name = name;
            _baseDamage = damage;
            _basePrice = price;
        }
        public string GetDescription()
        {
            return _name;
        }

        public int GetDamage()
        {
            return _baseDamage;
        }

        public decimal GetPrice()
        {
            return _basePrice;
        }
    }

}
