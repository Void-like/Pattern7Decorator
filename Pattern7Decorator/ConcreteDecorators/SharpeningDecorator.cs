using Pattern7Decorator.ClassDiagramDescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7Decorator.ConcreteDecorators
{
    public class SharpeningDecorator : WeaponDecorator
    {
        public SharpeningDecorator(IWeapon weapon) : base(weapon) { }

        public override string GetDescription()
        {
            return _decoratedWeapon.GetDescription() + " [Заточено]";
        }

        public override int GetDamage()
        {
            return _decoratedWeapon.GetDamage() + 5;
        }

        public override decimal GetPrice()
        {
            return _decoratedWeapon.GetPrice() * 1.2m;
        }
    }
}
