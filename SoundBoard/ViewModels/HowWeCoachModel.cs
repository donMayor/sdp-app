using System.Collections.Generic;

namespace SDP.ViewModels
{
    class HowWeCoachModel: List<HowWeCoach>
    {
        string about = "SDP is a community of knowledge-driven individuals in the IT industry who are willing and able to learn skills relevant to our society and their personal career goals and aspirations, thereby helping to solve challenges and problems using these skills and tools learnt";
        string requirement = "A PC with internet connection\nA teachable individual";
        string offer = "Convenient Virtual classes! Anytime! Anywhere! \nSkill learned provide you with ample opportunity to stand-out among your equals\nSDP may provide you with the chance of working on real company projects after the 3-months duration of learning for each skill\nCheap and Affordable Social Learning Build you Skill portfolio and get references";
        string duration = " SDP runs for a period of 3 months per skill chosen at a rate of #5000 per skill and you are allowed to enrol for as many courses as you wish per time.";
        public HowWeCoachModel()
        {
            
            LoadData();
        }

     
        public List<HowWeCoach> howWeCoach { get; set; }
        
        public void LoadData()
        {
           howWeCoach = new List<HowWeCoach>();
 
           
               howWeCoach.Add(new HowWeCoach(about, requirement,duration, offer));       
            
        }

    
    }
}
