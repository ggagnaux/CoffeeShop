using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Decorators
{
    public class HazelnutSyrupDecorator : BeverageDecorator
    {
        #region Constants
        private const string _description = "Hazelnut Syrup";
        private const decimal _cost = 0.25M;
        #endregion

        #region Consructor(s)
        public HazelnutSyrupDecorator(Beverage b) : base(b)
        {
        }
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
        #endregion
    }

}
