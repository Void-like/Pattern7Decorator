using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7Decorator.ClassDiagramDescription
{
    public interface IWeapon
    {
        string GetDescription();
        int GetDamage();
        decimal GetPrice();
    }

}
