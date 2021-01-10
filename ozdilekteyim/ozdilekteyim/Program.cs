using ozdilekteyim.Context;
using ozdilekteyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ozdilekteyim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brands brands = new Brands();
            ////brands.brand_added();
            //PullCategory pullCategory = new PullCategory();
            ////pullCategory.category_added();
            //PullCategoryChild pullCategoryChild = new PullCategoryChild();
            ////pullCategoryChild.category_added();

            //PullingProductAddressInCategory kategoridenproductadrescekme = new PullingProductAddressInCategory();
            //try
            //{
            //    using (var contex = new ProductContext())
            //    {
            //        List<Category> GetAllKategoriAddresses2 = contex.Categories.Where(s => s.State == false).ToList();
            //        foreach (var item in GetAllKategoriAddresses2)
            //        {

            //            kategoridenproductadrescekme.katpro(item.Address);
            //            item.State = true;
            //            contex.SaveChanges();

            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
            urun urun = new urun();

            using (var contex = new ProductContext())
            {
                List<ProductAddress> GetAllKategoriAddresses2 = contex.ProductAddresses.Where(s => s.State == true).ToList();
                foreach (var item in GetAllKategoriAddresses2)
                {
                    try
                    {

                        urun.urun_added(item.Path);
                        item.State = false;
                        contex.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        continue;
                    }
                }

            }
        }

    }
}
