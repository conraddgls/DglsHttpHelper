using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WinHttp;

namespace BoardManager
{
    class HttpRequest
    {
        WinHttpRequest http = new WinHttpRequest();
        static string text;
        public HttpRequest(string URL)
        {
            http.Open("GET", URL, true);
            http.Send();
            http.WaitForResponse();
            text = http.ResponseText;
        }

        public static string GetHttpSource()
        {
            return text;
        }
    }
}