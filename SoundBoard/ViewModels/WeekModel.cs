
namespace SDP.ViewModels
{
    public class WeekModel
    {
        public WeekModel()
        {

        }
        public WeekModel(string id, string week, string content )
        {
            this.ID = id;
            this.Week = week;
            this.WeekContent = content;
       //   this.relatedcourse = relatedcourse;

        }
        public string Week { get; set; }
        public string WeekContent { get; set; }
        public string WeekPython { get; set; }
        public string ID { get; set; }
     //   public List<listcourse> relatedcourse { get; set; }

         
    }
}
