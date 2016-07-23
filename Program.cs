using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Module1
{
    class Program
    {
        static StringBuilder strHelper = new StringBuilder();  
        static void Main(string[] args)
        {
            #region List Of Products
            Console.Write("Enter please your name: ");
            String strName = Console.ReadLine();
            Console.WriteLine($"{strName}, choose that you want to buy:\n");
            strHelper.Append('-', 10).Append("Products").Append('-',10).Append("\n");
            Console.Write(strHelper);
            strHelper.Clear();
            foreach (var KV in Product.Store)
            {
                String value = String.Format("{0,3}. {1,-10} : $ {2:F}", (int)KV.Key, KV.Value.Name, KV.Value.Price);
                strHelper.Append("\n");
                strHelper.Append(value);
            }
            strHelper.Append("\n\n<exit> : EXIT\n").Append('-',28);
            Console.WriteLine(strHelper);
            strHelper.Clear();
            #endregion
            #region prompt area

            String strId = default(String);
            Int32 intId = default(Int32);
            String strQuatity = default(String);
            Int32 intQuatity = default(Int32);
            Boolean validEntered = false;
            Basket basket = new Basket();
            while (!validEntered)
            {
                Console.Write("Enter id of product: ");
                strId = Console.ReadLine();
                Console.Write("Enter quatity: ");
                strQuatity = Console.ReadLine();
                validEntered = (Int32.TryParse(strId,out intId) && Int32.TryParse(strQuatity,out intQuatity));
                if (!validEntered) continue;
                basket.AddProduct(intId,intQuatity);
                Console.Write(" - Added. Press any key to continue or enter 'exit' to EXIT: ");
                if (Console.ReadLine().ToLower() == "exit") break;
                else validEntered = false;
            }
            Console.Write("Do you have a discount? <yes,no>: ");
            if (Console.ReadLine().ToLower() == "yes") {
                Console.Write("Enter a value of discount <in %>: ");
                String strDiscount = Console.ReadLine();
                int intDiscount = 0;
                Int32.TryParse(strDiscount, out intDiscount);
                basket.Discount = intDiscount;
            }
            #endregion
            #region order area

            strHelper.Append("\n").Append('-', 10).Append("Check").Append('-', 10).Append("\n");
            strHelper.Append(basket.GetCheck()).Append("\n");
            strHelper.Append("For payment: ").Append(basket.ForPayment).Append("\n");
            strHelper.Append("Total Discount: ").Append(basket.TotalDiscount).Append("\n").Append('-',25);
            
            Console.WriteLine(strHelper.ToString());
            strHelper = null;
            
            #endregion
            Console.ReadKey();
        }

    }
}
