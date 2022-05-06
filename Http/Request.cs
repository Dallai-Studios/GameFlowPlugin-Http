using System.Net.Http;
using System.Text;

namespace GameFlow.Plugins.Http
{
    public class Request : StringContent
    {
        public Request(string content) : base(content) { }
        public Request(string content, Encoding encoding) : base(content, encoding) { }
        public Request(string content, Encoding encoding, string mediaType) : base(content, encoding, mediaType) { }
    }
}

