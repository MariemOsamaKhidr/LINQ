using LINQ_01.DataSources;
using LINQ_01.Models;

namespace LINQ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                     #region Assignment 02 Linq
                    
                    #region 1
                    //var list = Source.ProductList.OrderByDescending(x => x.UnitPrice).Take(3);
                    //foreach (var item in list)
                    //{
                    //    Console.WriteLine(item);
                    //}
                    
                    #endregion
                    #region 2
                    //int page = 2;
                    //int pagesize = 5;
                    //var list = Source.ProductList.Skip((page - 1) * pagesize).Take(pagesize);
                    //foreach (var item in list)
                    //{
                    //    Console.WriteLine(item);
                    //}
                    #endregion
                    #region 3
                    //var list = Source.ProductList.TakeWhile(x => x.UnitPrice <25);
                    //foreach (var item in list)
                    //{
                    //    Console.WriteLine(item);
                    //}
                    #endregion
                    #region 4
                    //bool check = Source.ProductList.Where(x => x.Category == "seaFood").All(x => x.UnitsInStock >= 0);
                    //var result = (check) ? "No units in stock for Seafood Category" : "There are units in stock for Seafood Category";
                    //Console.WriteLine(result);
                    #endregion
                    #region 5
                    //int[] ids = { 3, 9, 13, 18 };
                    //bool check = ids.Contains(9);
                    //var result = (check) ? "contains 9" : "does not contains 9";
                    //Console.WriteLine(result);
                    #endregion
                    #region 6
                    //var list = from p in Source.ProductList
                    //           group p by p.Category
                    //          into p1
                    //           select new
                    //           {
                    //               ProductName=p1.Key,
                    //               ProductCount=p1.Count()
                    //           };
                    #endregion
                    #region 7
                    //var list = from p in Source.ProductList
                    //           group p by p.Category;
                    
                    //foreach (var item in list)
                    //{
                    //    Console.WriteLine($"Category: {item.Key}");
                    //    Console.WriteLine("--------------");
                    //    foreach (var item2 in item)
                    //    {
                    //        Console.WriteLine(item2.ProductName);
                    //    }
                    //    Console.WriteLine("-------------------------");
                    //}
                    
                    #endregion
                    #region 8
                    //var list = from p in Source.ProductList
                    //           group p by p.Category
                    //          into p1
                    //           where p1.Count() > 3
                    //           select new
                    //           {
                    //               Category =p1.Key
                    
                    //           };
                    //foreach (var item in list)
                    //{
                    //    Console.WriteLine(item);
                    //}
                    
                    #endregion
                    #region 9
                    //var list = from c in Source.CustomerList
                    //           group c by c.Country
                    //           into c1
                    //           select new
                    //           {
                    //               country = c1.Key,
                    //               count = c1.Count(),
                    //               TotalOrderValue=c1.SelectMany(x=>x.Orders).Sum(x=>x.Total)
                    
                    //           };
                    //foreach (var item in list)
                    //{
                    //   Console.WriteLine(item);
                    //}
                    ////////////////OR////////////////////////////
                    //var list = from c in Source.CustomerList
                    //           group c by c.Country;
                    
                    //foreach (var item in list)
                    //{
                    //    Console.WriteLine(item.Key);
                    //    Console.WriteLine(item.Count());
                    
                    //    var totalOrderValue = item
                    //            .SelectMany(c => c.Orders)
                    //            .Sum(o => o.Total);
                    
                    //    Console.WriteLine(totalOrderValue);
                    //}
                    
                    #endregion
                    #region 10
                    //var UnitsInStock = Source.ProductList.Sum(x => x.UnitsInStock);
                    //Console.WriteLine($"total units in stock :{UnitsInStock}");
                    #endregion
                    #region 11
                    //var cheapest = Source.ProductList.OrderBy(x=>x.UnitPrice).First();
                    //Console.WriteLine(cheapest.UnitPrice);          
                    //var expensive = Source.ProductList.OrderByDescending(x => x.UnitPrice).First();
                    //Console.WriteLine(expensive.UnitPrice);
                    #endregion
                    #region 12
                    
                    //var distinct =Source.ProductList.DistinctBy(x=>x.Category);
                    //foreach (var item in distinct)
                    //{
                    //    Console.WriteLine(item.Category);
                    //}
                    
                    #endregion
                    #region 13
                    //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
                    //int[] setB = { 3, 6, 9, 12, 15, 13 };
                    //var result=setA.Except(setB);
                    //foreach (int i in result)
                    //{
                    //    Console.WriteLine(i);
                    //}
                    
                    #endregion
                    #region 14
                    //string[] list1 = { "Germany", "France", "UK", "Spain" };
                    //string[] list2 = { "france", "SPAIN", "Italy" };
                    //var result =list1.Except(list2,StringComparer.OrdinalIgnoreCase);
                    //foreach (var item in result)
                    //{
                    //    Console.WriteLine(item);
                    //}
                    #endregion
                    #region 15
                    
                    // Dictionary<int, Product> p = Source.ProductList.ToDictionary(p => p.ProductID);
                    // var result = p.Where(x => x.Key == 18);
                    
                    //foreach (var item in result)
                    // {
                    //     Console.WriteLine(item.Value);
                    // }
                    #endregion
                    #region 16
                    //var result = Source.ProductList.First(x=>x.UnitPrice>50);
                    //Console.WriteLine(result);
                    #endregion
                    #region 17
                    //var result = Source.ProductList.FirstOrDefault(x => x.UnitPrice > 500);
                    //Console.WriteLine(result);
                    #endregion
                    #region 18
                    //int[] seven = { 1, 2, 3, 4, 5, 6, 7 };
                    //var result = seven.Aggregate((x, y) => x * y);
                    //Console.WriteLine(result);
                    #endregion
                    #region 19
                    //var result = Enumerable.Range(1, 30).Where(x => x % 2 != 0);
                    //foreach (var item in result)
                    //{
                    //    Console.WriteLine(item);
                    //}
                    #endregion
                    #region 20
                    // var result = Source.ProductList.Take(3).Select(x => x.ProductName).Concat(Source.CustomerList.Take(3).Select(c => c.CompanyName));
                    //foreach (var item in result)
                    // {
                    //     Console.WriteLine(item);
                    // }
                    #endregion
                    #region 21
                    
                    //var result = Source.ProductList.Zip(Source.CustomerList,
                    //    (p, c) => $"{p.ProductName} sold to {c.CompanyName}");
                    //foreach ( var item in result )
                    //{
                    //    Console.WriteLine(item);
                    //}
                    
                    #endregion
                    #endregion
                    //////////////////////////////////////////////////////////////////////////            
                    #region Assignment 01 Linq
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
                    #endregion

        }
    }
}
