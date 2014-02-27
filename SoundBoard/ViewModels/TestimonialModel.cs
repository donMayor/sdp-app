using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.ViewModels
{
    class TestimonialModel : List<Testimonial>
    {
      
        public TestimonialModel()
        {
            
            LoadData();
        }

     
        public List<Testimonial> first { get; set; }
        public List<Testimonial> second { get; set; }

        public List<Testimonial> third { get; set; }
        public List<Testimonial> fourth { get; set; }

        public List<Testimonial> fifth { get; set; }
        public List<Testimonial> sixth { get; set; }
       
        public void LoadData()
        {
            first = new List<Testimonial>();
            second = new List<Testimonial>();
            third = new List<Testimonial>();
            fourth = new List<Testimonial>();
            fifth = new List<Testimonial>();
            sixth = new List<Testimonial>();
   
                first.Add(new Testimonial("Mayowa Egbewunmi", "Obafemi Awolowo University", "Software Developer", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
               
                second.Add(new Testimonial("Detan Oyedele", "Obafemi Awolowo University", "Business Lead", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
               
                third.Add(new Testimonial("Wale Oyediran", "Obafemi Awolowo University", "Software Engineer","Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                   
               fourth.Add(new Testimonial("Emeka A.", "University of Lagos", "Telecom Engineer","Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 
               fifth.Add(new Testimonial("Francis E.", "Obafemi Awolowo University","Software Coach", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
          
                sixth.Add(new Testimonial("Tomiwa D.", "FUTA", "Product Manager","Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
            
        }

    
    }
}
