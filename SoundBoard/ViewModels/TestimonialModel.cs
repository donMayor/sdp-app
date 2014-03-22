using System.Collections.Generic;

namespace SDP.ViewModels
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
   
                first.Add(new Testimonial("Detan Oyedele", "Obafemi Awolowo University", "Software Developer", "IQube SDP is great and perfect for every bright minds"));
               
                second.Add(new Testimonial("Egbewunmi Mayowa", "Obafemi Awolowo University", "Business Lead", "SDP helps you develop your career within the shortest possible time. It's just on point!"));
               
                third.Add(new Testimonial("Emeka Okoroafor", "Obafemi Awolowo University", "Software Engineer","SDP is flexible and accomodating for student in schools. Simply at your convinience"));
                   
               fourth.Add(new Testimonial("Francis Adereti", "University of Lagos", "Telecom Engineer","It's just the BEST training i have ever taken.. Don't miss out!!"));
                 
               fifth.Add(new Testimonial("Tomiwa Ijaware", "Obafemi Awolowo University","Software Coach", "Fantastics!!! I could have said more, preferably i will love you to testify yourself"));
          
                sixth.Add(new Testimonial("Wale Oyediran", "FUTA", "Product Manager","It is one of the most insightful training in the globe, The virtual training, projects and lessons are just the best for hungry minds"));
            
        }

    
    }
}
