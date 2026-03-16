using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7Decorator.ClassDiagramDescription
{
    public abstract class WeaponDecorator : IWeapon
    {
        protected IWeapon _decoratedWeapon;

        public WeaponDecorator(IWeapon weapon)
        {
            _decoratedWeapon = weapon;
        }

        public virtual string GetDescription()
        {
            return _decoratedWeapon.GetDescription();
        }

        public virtual int GetDamage()
        {
            return _decoratedWeapon.GetDamage();
        }

        public virtual decimal GetPrice()
        {
            return _decoratedWeapon.GetPrice();
        }
    }
}
