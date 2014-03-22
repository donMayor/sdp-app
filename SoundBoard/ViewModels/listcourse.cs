
namespace SDP.ViewModels
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
