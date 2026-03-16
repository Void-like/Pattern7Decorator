using Pattern7Decorator.ClassDiagramDescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7Decorator.ConcreteDecorators
{
    public class FireRuneDecorator : WeaponDecorator
    {
        public FireRuneDecorator(IWeapon weapon) : base(weapon) { }

        public override string GetDescription()
        {
            return _decoratedWeapon.GetDescription() + " [Огненная руна]";
        }

        public override int GetDamage()
        {
            return _decoratedWeapon.GetDamage() + 10;
        }

        public override decimal GetPrice()
        {
            return _decoratedWeapon.GetPrice() + 100;
        }
    }
}
