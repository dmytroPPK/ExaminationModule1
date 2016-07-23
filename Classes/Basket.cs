using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Module1
{
    class Basket
    {
        private int discount;
        public int Discount { get { return discount; } set { discount = (value > 100) ? 0 : value; } }
        public  double  TotalDiscount { protected set; get; }
        public double ForPayment { protected set; get; }
        protected IList<dynamic> ListOfGoods;
        public Basket()
        {
            ListOfGoods = new List<dynamic>();
        }

        public void AddProduct(int _intId, int _intQuatity)
        {
            this.ListOfGoods.Add(new
            {
                Name = Product.Store[(ProductList)_intId].Name,
                Quatity = _intQuatity,
                TotalPrice = _intQuatity * Product.Store[(ProductList)_intId].Price
            });
        }
        public string GetCheck()
        {
            StringBuilder strVal = new StringBuilder();
            foreach (var item in this.ListOfGoods)
            {
                strVal.Append(String.Format("{0,-10} x {1,12} = $ {2}\n",item.Name,item.Quatity,item.TotalPrice));
                this.ForPayment += item.TotalPrice*((100-this.discount)/100D);
                this.TotalDiscount += item.TotalPrice*this.discount/100;
            }
            
            return strVal.ToString();
        }
    }
}