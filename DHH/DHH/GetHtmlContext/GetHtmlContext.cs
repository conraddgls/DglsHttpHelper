using System;

namespace DHH.GetHtmlContext
{
    public static class GetHtmlContext
    {
        public static string[] GetCotext(string body, string indexOf, char word)
        {
            int index = body.IndexOf(indexOf);
            string tempBody = body.Substring(index);

            string[] split = tempBody.Split(word);

            return split;
        }
    }
}