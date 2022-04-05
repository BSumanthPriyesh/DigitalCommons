using DigitalCommons.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DigitalCommons.Controllers
{
    public class DigitalCommonsController : Controller
    {
        public ApplicationDbContext dbContext;

        public DigitalCommonsController(ApplicationDbContext context)
        {
            dbContext = context;   
        }
        public IActionResult Index()
        {
           /* var p = dbContext.Students
                    .Include(c => c.Documents)
                    .Select(c => new {c.FirstName,c.LastName}).ToList();
            foreach(var d in p)
            {
                Console.WriteLine(d);
            }
            return View(p);*/

            /*Models.DigitalModel.Student S1 = dbContext.Students
                                    .Where(c => c.StudentID == 2)
                                    .First();
            return View(S1);*/

            var p = dbContext.Documents
                    .Include(c => c.Student)
                    .Where(c => c.ResearchArea == "Machine Learning").ToList();
            return View(p);

            

            /*var list1 = dbContext.Students.ToList();
            return View(list1);*/

            /*var innerJoin = dbContext.Documents.Join(// outer sequence 
                      dbContext.Students,  // inner sequence 
                      s => s.Student,    // outerKeySelector
                      s1 => s1.StudentID,  // innerKeySelector
                      (s, s1) => new  // result selector
                      {
                          FirstName = s1.FirstName,
                          LastName = s1.LastName
                      }); */

            /*var innerJoin1 = from s in dbContext.Documents // outer sequence
                             join st in dbContext.Students //inner sequence 
                             on s.Student equals st.StudentID // key selector 
                            select new
                            { // result selector 
                                FirstName = st.FirstName,
                                LastName = st.LastName
                            };*/
        }

        /*void populateData()
        {
            Models.DigitalModel.Student student1 = new Models.DigitalModel.Student();
            student1.FirstName = "Sumanth";
            student1.LastName = "Priyesh";
            student1.Major = "BAIS";
            student1.BirthDate = "17/06/1996";
            student1.Email = "s@abc.gmail.com";

            Models.DigitalModel.Document Document1 = new Models.DigitalModel.Document();
            Document1.Title = "Supervised";
            Document1.ResearchArea = "Machine learning";
            Document1.PublishDate = "03/11/2000";

            Models.DigitalModel.DownloadInfo Download1 = new Models.DigitalModel.DownloadInfo();
            Download1.DownloadDate = DateTime.Now;
            Download1.NumberOfDownloads = "1";

            Models.DigitalModel.UserInfo User1 = new Models.DigitalModel.UserInfo();
            User1.FirstName = "Rahul";
            User1.LastName = "Puvvula";
            User1.BirthDate = DateTime.Today;
            User1.Email = "ab@gmail.com";
            User1.Address = "India";

            dbContext.Students.Add(student1);
            dbContext.Documents.Add(Document1);
            dbContext.downloadInfos.Add(Download1);
            dbContext.userInfos.Add(User1);

            dbContext.SaveChanges();
        }*/
    }
}
