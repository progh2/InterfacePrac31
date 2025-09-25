using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrac31
{
    internal class Program
    {

        class Product : IComparable<Product>
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(Product other)
            {
                //return this.Price - other.Price;
                //return this.Price.CompareTo(other.Price);
                return this.Name.CompareTo(other.Name);
            }

            public override string ToString()
            {
                //return Name + " : " + Price + "원";
                   return $"{Name} : {Price}원";
            }
        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Name="감자", Price =500},
                new Product(){Price=700, Name="사과" },
                new Product(){Name="고구마", Price =400},
                new Product(){Name="배추", Price =600},
                new Product(){Name="상추", Price =300},
            };
            //정렬
            products.Sort();
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

        }
    }
}
