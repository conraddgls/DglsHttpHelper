using System.Text;
using WinHttp;

namespace DHH.HttpRequest
{
    public class HttpRequest
    {
        WinHttpRequest request = new WinHttpRequest();
        string body;

        public HttpRequest(string Method, string URL, bool Async)
        {
            request.Open(Method, URL, Async); 
        }

        public string GetHtmlSource()
        {
            request.Send();
            request.WaitForResponse();
            body = Encoding.Default.GetString(request.ResponseBody);
            return body;
        }
    }
}
