using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Decorators
{
    public class CaramelDecorator : BeverageDecorator
    {
        #region Constants
        private const string _description = "Caramel";
        private const decimal _cost = 1.0M;
        #endregion

        #region Constructor(s)
        public CaramelDecorator(Beverage b) : base(b) {}
        #endregion

        #region Properties (Overridden)
        public override string Description
        {
            get
            {
                return $"{this.GetWrappedEntity().Description}, {_description}";
            }
        }

        public override decimal Cost
        {
            get
            {
                return this.GetWrappedEntity().Cost + _cost;
            }
        }

        public string GetDecoratorDescriptionOnly()
        {
            return _description;
        }
        #endregion
    }
}
