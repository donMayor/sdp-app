using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.ViewModels
{
    public class listcourse
    {

        public listcourse() { }

        public listcourse(string name, string imageUri)
        {
            this.coursename = name;
            this.imageUri = imageUri;
        }

        public string coursename { get; set; }
        public string imageUri { get; set; }
    }
}
