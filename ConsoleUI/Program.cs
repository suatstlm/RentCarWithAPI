using Business.Abstract;
using Business.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new EfCarDal());
            //ICarDal carDal = new EfCarDal();
            //CarDatabaseContext context = new CarDatabaseContext();

            //var A = new EfEntityFrameworkBase<Car, CarDatabaseContext>();

            var cars = carService.Add(

                new Car
                {
                    BrandId = 3,
                    ColorId = 3,
                    CarName = "WV501",
                    DailyPrice = 450,
                    ModelYear = "2020",
                    Description = "Yeni model Uzun Kasa SUV"
                }
                );


            //var cars1 = carService.GetAll();

            //foreach (var car in cars1.Data)
            //{
            //    Console.WriteLine(car.CarName);
            //}
            //var result = carService.GetById(3);
            //Console.WriteLine(result.Data.CarName);




            //Product product = new Product();
            //GetAll getAll = new GetAll();

            //List<Product> results = getAll.Get();

            //foreach (var result in getAll.Get())
            //{
            //    Console.WriteLine(result.ProductName);
            //}






        }
    }
    public class Product
    {
        public string ProductName { get; set; }
    }

    public class CarDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
    }

    
    public class GetAll
    {
        CarDatabaseContext context = new CarDatabaseContext();
        public List<Product> Get(Expression<Func<Product, bool>> filter = null)
        {
            return filter == null ? context.Set<Product>().ToList()
                                  : context.Set<Product>().Where(filter).ToList();
        }
    }
}