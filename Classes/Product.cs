using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Module1
{
    enum ProductList
    {
        Apple =1,
        Milk,
        Cola,
        Bread,
        Chocolate,
        Soda,
        Beef,
        Sweets
    }
    class Product
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }

        public static IDictionary<ProductList, Product> Store { get; private set; }

        static Product()
        {
            Store = new Dictionary<ProductList, Product>();
            Store.Add(ProductList.Apple, new Product()
                                            { Name = "Apple", Price = 4 });
            Store.Add(ProductList.Milk, new Product()
                                            { Name = "Milk", Price = 7 });
            Store.Add(ProductList.Cola, new Product()
                                            { Name = "Cola", Price = 2.5 });
            Store.Add(ProductList.Bread, new Product()
                                            { Name = "Bread", Price = 2.45 });
            Store.Add(ProductList.Chocolate, new Product()
                                            { Name = "Chocolate", Price = 8 });
            Store.Add(ProductList.Soda, new Product()
                                            { Name = "Soda", Price = 1.5 });
            Store.Add(ProductList.Beef, new Product()
                                            { Name = "Beef", Price = 16 });
            Store.Add(ProductList.Sweets, new Product()
                                            { Name = "Sweets", Price = 10 });
        }
    }
}
