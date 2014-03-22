
namespace SDP.ViewModels
{
    class HowWeCoach
    {
          public HowWeCoach() { }

        public HowWeCoach(string about, string requirement, string duration, string offers)
        {
            _about = "About";
            _requirement = "Requirements";
            _duration = "Duration";
            _offers = "What we offer";
            this.about = about;
            this.requirement = requirement;
            this.duration = duration;
            this.offer = offers;
        }

        public string about { get; set; }
        public string requirement { get; set; }
        public string duration { get; set; }
        public string offer { get; set; }
        public string _about { get; set; }
        public string _requirement { get; set; }
        public string _duration { get; set; }
        public string _offers { get; set; }
    }
}
