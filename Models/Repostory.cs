namespace basics.Models
{
    public class Repostory
    {
        private static readonly List<Course> _courses = new();       //= new List<Course>(); un kısayolu direkt new()

        static Repostory()
        {
            _courses = new List<Course>()
            {
                new Course()
                {
                    Id=001,
                    Title="Python",
                    Descrip="des1",
                    Img="1.jpg",
                    Tags= new string[]{"aspnet","web geliştirme"},
                    isActive=false,
                    isHome=true,
                },
                new Course()
                {
                    Id=002,
                    Title="Php",
                    Descrip="des2", 
                    Img="2.jpg",
                    Tags=new string[]{ "php", "web geliştirme" },
                    isActive=true,
                    isHome=false,
                },
                new Course()
                {
                    Id=003,
                    Title="JavaScript",
                    Descrip="des3", 
                    Img="3.jpg",
                    isActive=true,
                    isHome=true
                }
            };
        }

        public static List<Course> Courses { get { return _courses; } }

        public static Course? getBYId(int? id)      //null da olabilir ondan ? koyduk
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}
