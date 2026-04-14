using LINQ_01.DataSources;
using LINQ_01.Models;

namespace LINQ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //var seafood = Source.ProductList.Where(p => p.Category == "Seafood");
            //foreach(var item in seafood)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2
            //var list = from c in Source.ProductList
            //           select c.ProductName;
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3
            //var list = Source.ProductList.OrderBy(c => c.UnitPrice);
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"Product name : {item.ProductName} - Price: {item.UnitPrice}");
            //}
            #endregion
            #region 4
            //var list = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 5
            //var list = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 6
            //var Anonymous = Source.ProductList.Select(p => new
            //{
            //    Name=p.ProductName,
            //    Price=p.UnitPrice,
            //    StockStatus= (p.UnitsInStock>0)?"Available" :"Out of Stock"

            //});
            //foreach (var item in Anonymous)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 7
            //var list = Source.ProductList.Select((p, index) => new
            //{
            //    Position=index+1,
            //    Name=p.ProductName,

            //});
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 8
            //var list = Source.ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 9
            //var list = Source.ProductList.Where(p => p.Category == "Beverages").OrderByDescending(o => o.UnitsInStock)
            //    ;
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"Name: {item.ProductName} - stock: {item.UnitsInStock}");
            //}
            #endregion
            #region 10
            //var list = from p in Source.CustomerList
            //           from o in p.Orders
            //           where o.OrderDate.Year == 1997
            //           select new
            //           {
            //               CustomerID=p.CustomerID,
            //               OrderDate=o.OrderDate
            //           };
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 11
            //var list = Source.ProductList.Select((p, index) => new
            //{
            //    position =index, // or index+1 (i prefere the index without +1)
            //    ProductName= p.ProductName
            //});
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 12
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var list = Arr.OrderBy(p => p.Length).ThenBy(p => p, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in list)
            //{             
            //   Console.WriteLine(item);
            //}
            #endregion 12
            #region 13
            //List<string> list = new List<string>()
            //{
            //    "zero",
            //    "one",
            //    "two",
            //    "three",
            //    "four",
            //    "five",
            //    "six",
            //    "seven",
            //    "eight",
            //    "nine"
            //};
            //var result = list.Where(x => x[1] == 'i').Reverse();
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
                
            #endregion

        }
    }
}
