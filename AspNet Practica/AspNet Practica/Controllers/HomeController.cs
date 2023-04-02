using Microsoft.AspNetCore.Mvc;

namespace AspNet_Practica.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            int[] nums1 = { 1, 4, 7, 8, 9, 0, 5 };
            int[] nums2 = { 15, 4, 7, 8, 9, 30, 15 };

            

            return View(nums1);
        }




        //public string Index(int id)
        //{
        //    if (id == 2)
        //    {
        //        return "Anar";
        //    }
            
        //    return "Aqshin - " + id ;
            
        //}



        //public string Detail (string slug, string name)
        //{
        //    return slug + name;
        //}



         
        //private string GetName()
        //{
        //    return "Aqshin";
        //}




    }


    
}
