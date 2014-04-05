using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.ViewModels
{
    class Testimonial
     {

        public Testimonial() { }

        public Testimonial(string name, string institution, string profession, string Testimony)
        {
            this.name = name;
            this.institution = institution;
            this.profession = profession;
            this.testimony = Testimony;
        }

        public string name { get; set; }
        public string institution { get; set; }
        public string profession { get; set; }
        public string testimony { get; set; }

    }
}
