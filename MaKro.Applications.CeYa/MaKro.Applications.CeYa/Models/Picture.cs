namespace MaKro.Applications.CeYa.Client.Models
{
    public class Picture
    {
        private byte[] _content;
        private string _format;

        public Picture()
        {

        }

        public Picture(string aiFormat, byte [] aiContent)
        {
            _content = aiContent;
            _format = aiFormat; 
        }

        public byte [] Content
        {
            get { return _content; }
        }

        public string Format
        {
            get { return _format; }
        }
    }
}