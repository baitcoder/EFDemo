using System;
using System.Collections.Generic;
using System.Text;
using EFDemo.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace EFDemo
{
    class CatList
    {
        static void Main()
        {
            northwindContext context = new northwindContext();
            var data = from cat in context.Categories.Include("Products") select cat;
            foreach(var item in data)
            {
                int i = 1;
                Console.WriteLine($"{item.CategoryId}---{item.CategoryName}---{item.Description}");
                foreach(var prod in item.Products)
                {
                    Console.WriteLine($"\t{i}=={prod.ProductName}----{prod.UnitPrice}");
                    
                    i++;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
