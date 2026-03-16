using Pattern7Decorator.ClassDiagramDescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7Decorator.ConcreteDecorators
{
    public class VampirismEnchantDecorator : WeaponDecorator
    {
        public VampirismEnchantDecorator(IWeapon weapon) : base(weapon) { }

        public override string GetDescription()
        {
            return _decoratedWeapon.GetDescription() + " [Вампиризм]";
        }

        public override int GetDamage()
        {     
            return _decoratedWeapon.GetDamage() - 2;
        }

        public override decimal GetPrice()
        {       
            return _decoratedWeapon.GetPrice() * 2;
        }
    }
}
