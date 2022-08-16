using System;
using EFDemo.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            northwindContext context = new northwindContext();
            var data =from prod in context.Products.Include("Category") select prod;
            foreach(var item in data)
            {
                Console.WriteLine($"{item.ProductId}======={item.ProductName}======={item.UnitPrice}==={item.Category.CategoryName}");
            }
        }
    }
}
