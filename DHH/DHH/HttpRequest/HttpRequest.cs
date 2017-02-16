using WinHttp;

namespace DHH.HttpRequest
{
    public class HttpRequest
    {
        WinHttpRequest request = new WinHttpRequest();

        public HttpRequest(string Method, string URL, bool Async)
        {
            request.Open(Method, URL, Async);
        }

        public string GetHtmlSource()
        {
            request.Send();
            request.WaitForResponse();
            return request.ResponseText;
        }
    }
}
