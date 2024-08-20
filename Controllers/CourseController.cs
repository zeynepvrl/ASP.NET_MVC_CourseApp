using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers
{
    public class CourseController : Controller
    {   //course/
        //course/index
        public IActionResult Index()
        {
            var course = new Course();
            course.Id = 1;
            course.Title = "Test";
            return View(course);
        }

        public IActionResult Details(int? id )      //burdaki id program.cs deki url deki id şeklinde belirlenmesinden dolayı. url deki id yi  buraya parametre olarak belirtirsek, yazarsak gelir
        {
            if ( id == null )
            {
                return Redirect("/course/list");
            }
            var course = Repostory.getBYId(id);

            return View(course);
        }

        // course/list
        public IActionResult List()
        {
            
            return View("CourseList", Repostory.Courses);              //eğer view sayfası burdaki fonksiyonun ismi ile aynı isimde olmasayda, ismini parantez içinde yazardık
        }
    }
}
