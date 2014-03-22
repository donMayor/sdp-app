using System.Collections.Generic;

namespace SDP.ViewModels
{
    public class Listmodel : List<listcourse>
    {
        public List<listcourse> relatedcourse { get; set; }
        public Listmodel()
        {
            BuildCollection();

           if (MainPage.header == 0)
            {
                LoadRelatedCourses(MainPage.selectedindex);
            }
        }

        public List<listcourse> datacollection { get; set; }

        public List<listcourse> LoadRelatedCourses(int selectedindex)
        {
            relatedcourse = new List<listcourse>();
            switch (selectedindex)
            {
                case 0:
                    relatedcourse.Add(new listcourse("Data Analysis", "Assets/images/1.jpg"));
                    relatedcourse.Add(new listcourse("Python", "Assets/images/2.jpg"));
                    break;
                case 1:
                     relatedcourse.Add(new listcourse("php", "Assets/images/15.jpg"));
                    relatedcourse.Add(new listcourse("Perl", "Assets/images/14.jpg"));
                   // relatedcourse.Add(new listcourse("C#", "Assets/images/14.jpg"));
                    break;
                case 2:
                    relatedcourse.Add(new listcourse("Linux Network Programming", "Assets/images/16.jpg"));
                  
                    break;
                case 3:
                    relatedcourse.Add(new listcourse("Data Analysis", "Assets/images/1.jpg"));
                    relatedcourse.Add(new listcourse("Python", "Assets/images/2.jpg"));
                    break;
                case 4:
                    relatedcourse.Add(new listcourse("Data Analysis", "Assets/images/1.jpg"));
                    relatedcourse.Add(new listcourse("Python", "Assets/images/2.jpg"));
                    break;
                case 5:
                    relatedcourse.Add(new listcourse("Data Analysis", "Assets/images/1.jpg"));
                    relatedcourse.Add(new listcourse("Python", "Assets/images/2.jpg"));
                    break;
                case 6:
                    relatedcourse.Add(new listcourse("C#", "Assets/images/8.jpg"));
                    relatedcourse.Add(new listcourse("C++", "Assets/images/9.jpg"));
                    break;
                case 7:
                    relatedcourse.Add(new listcourse("Data Analysis", "Assets/images/1.jpg"));
                    relatedcourse.Add(new listcourse("Python", "Assets/images/2.jpg"));
                    break;
                case 8:
                    relatedcourse.Add(new listcourse("Data Analysis", "Assets/images/1.jpg"));
                    relatedcourse.Add(new listcourse("Python", "Assets/images/2.jpg"));
                    break;
                case 9:
                    relatedcourse.Add(new listcourse("Data Analysis", "Assets/images/1.jpg"));
                    relatedcourse.Add(new listcourse("Python", "Assets/images/2.jpg"));
                    break;
                case 10:
                    relatedcourse.Add(new listcourse("Linux Network Programming", "Assets/images/16.jpg"));
                    relatedcourse.Add(new listcourse("Linux System Admistration", "Assets/images/3.jpg"));
                    break;
                case 11:
                    relatedcourse.Add(new listcourse("Database Admistration", "Assets/images/19.jpg"));
                    break;
                case 12:
                    relatedcourse.Add(new listcourse("Data Analysis", "Assets/images/5.jpg"));
                    relatedcourse.Add(new listcourse("Machine Learning", "Assets/images/4.jpg"));
                    break;
                case 13:
                   // relatedcourse.Add(new listcourse("Data Analysis", "Assets/images/1.jpg"));
                   // relatedcourse.Add(new listcourse("Python", "Assets/images/2.jpg"));
                    break;
                case 14:
                    relatedcourse.Add(new listcourse("php", "Assets/images/15.jpg"));
                    relatedcourse.Add(new listcourse("Python", "Assets/images/2.jpg"));
                    break;
                case 15:
                    relatedcourse.Add(new listcourse("Data Analysis", "Assets/images/1.jpg"));
                    relatedcourse.Add(new listcourse("Python", "Assets/images/2.jpg"));
                    break;
                case 16:
                    relatedcourse.Add(new listcourse("Data Analysis", "Assets/images/1.jpg"));
                    relatedcourse.Add(new listcourse("Python", "Assets/images/2.jpg"));
                    break;
                case 17:
                    relatedcourse.Add(new listcourse("Data Analysis", "Assets/images/1.jpg"));
                    relatedcourse.Add(new listcourse("Python", "Assets/images/2.jpg"));
                    break;
                case 18:
                    relatedcourse.Add(new listcourse("MySQL", "Assets/images/11.jpg"));
                 //   relatedcourse.Add(new listcourse("Python", "Assets/images/2.jpg"));
                    break;

            };

            return relatedcourse;
        }

        List<listcourse> BuildCollection()
        {
            datacollection = new List<listcourse>();
            datacollection.Add(new listcourse("Data Analysis", "/Assets/images/1.jpg"));
            datacollection.Add(new listcourse("Python", "/Assets/images/2.jpg"));
            datacollection.Add(new listcourse("Linux Admistration", "/Assets/images/3.jpg"));
            datacollection.Add(new listcourse("Machine Learning", "/Assets/images/4.jpg"));
            datacollection.Add(new listcourse("Image Processing", "/Assets/images/5.jpg"));
            datacollection.Add(new listcourse("GSM Architecture", "/Assets/images/6.jpg"));
            datacollection.Add(new listcourse("Java", "/Assets/images/7.jpg"));
            datacollection.Add(new listcourse("C#", "/Assets/images/8.jpg"));
            datacollection.Add(new listcourse("C++", "/Assets/images/9.jpg"));
            datacollection.Add(new listcourse("Bash", "/Assets/images/10.jpg"));
            datacollection.Add(new listcourse("MySQL", "/Assets/images/11.jpg"));
            datacollection.Add(new listcourse("Artificial Intelligence", "/Assets/images/12.jpg"));
            datacollection.Add(new listcourse("Java Script", "/Assets/images/13.jpg"));
            datacollection.Add(new listcourse("Perl", "/Assets/images/14.jpg"));
            datacollection.Add(new listcourse("php", "/Assets/images/15.jpg"));
            datacollection.Add(new listcourse("Linux", "/Assets/images/16.jpg"));
            datacollection.Add(new listcourse("Web", "/Assets/images/17.jpg"));
            datacollection.Add(new listcourse("Cloud Computing", "/Assets/images/18.jpg"));
            datacollection.Add(new listcourse("Database Admistration", "/Assets/images/19.jpg"));
            return datacollection;
        }
    }
}
