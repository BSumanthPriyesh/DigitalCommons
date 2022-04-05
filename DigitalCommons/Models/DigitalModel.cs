using System.ComponentModel.DataAnnotations;

namespace DigitalCommons.Models
{
    public class DigitalModel
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Major { get; set; }
            public string BirthDate { get; set; }
            public string Email { get; set; }
            public List<Document> Documents { get; set; }
        }

        public class Document
        {
            public int DocumentID { get; set; }
            public string Title { get; set; }
            public string ResearchArea { get; set; }
            public string PublishDate { get; set; }
            public Student Student { get; set; }
            public List<DownloadInfo> DownloadInfo { get; set; }
        }

        public class DownloadInfo
        {
         [Key]   
            public int ID { get; set; }
            public UserInfo UserInfo { get; set; }
            public Document Document { get; set; }
            public DateTime DownloadDate { get; set; }
            public string NumberOfDownloads { get; set; }
        }
        public class UserInfo
        {
            [Key]
            public int UserID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public List<DownloadInfo> DownloadInfo { get; set; }
        }

    }

}

