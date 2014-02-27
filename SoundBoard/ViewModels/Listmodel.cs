using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.ViewModels
{
    public class Listmodel : List<listcourse>
    {

        public Listmodel()
        {
            BuildCollection();
        }

        public List<listcourse> datacollection { get; set; }

        List<listcourse> BuildCollection()
        {
            datacollection = new List<listcourse>();
            datacollection.Add(new listcourse("Data Analysis", "/Assets/images/1.jpg"));
            datacollection.Add(new listcourse("Python", "/Assets/images/2.jpg"));
            datacollection.Add(new listcourse("Linux Admistration", "/Assets/images/3.jpg"));
            datacollection.Add(new listcourse("Machine Learning", "/Assets/images/4.jpg"));
            datacollection.Add(new listcourse("Image Processing", "/Assets/images/5.jpg"));
            datacollection.Add(new listcourse("GSM Architecture", "/Assets/images/6.jpg"));

            return datacollection;
        }
    }
}
