using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //DistrictManager districtManager = new DistrictManager(new EfDistrictDal());
            //foreach (var district in districtManager.GetAllByCounty(35))
            //{
            //    Console.WriteLine(district.Name);
            //}
            DistrictManager districtManager = new DistrictManager(new EfDistrictDal());
            foreach (var district in districtManager.GetAll())
            {
                Console.WriteLine(district.Name);
            }
            //CountyManager countyManager = new CountyManager(new EfCountyDal());
            //foreach (var item in countyManager.GetAll())
            //{
            //    Console.WriteLine(item.Name);
            //}
        }
    }
}
