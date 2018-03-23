using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Decorators
{
    public abstract class BeverageDecorator : Beverage
    {
        #region Constructor(s)
        private Beverage _beverage;
        protected BeverageDecorator(Beverage b)
        {
            _beverage = b;
        }
        #endregion

        #region Method(s)
        protected Beverage GetWrappedEntity() { return this._beverage; }
        #endregion
    }
}
