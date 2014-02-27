using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.ViewModels
{
    public class WeekModel
    {
        public WeekModel()
        {

        }
        public WeekModel(string id, string week, string content)
        {
            this.ID = id;
            this.Week = week;
            this.WeekContent = content;
     

        }
        public string Week { get; set; }
        public string WeekContent { get; set; }
        public string WeekPython { get; set; }
        public string ID { get; set; }

         
    }
}
