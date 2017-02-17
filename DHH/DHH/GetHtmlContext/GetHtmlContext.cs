namespace DHH.GetHtmlContext
{
    public static class GetHtmlContext
    {
        public static string GetCotext(string body, string indexOf, int lenght, char word, string splitIndex)
        {
            int index = body.IndexOf(indexOf);
            string tempBody = body.Substring(index, index + lenght);

            string[] split = tempBody.Split(word);

            return split[1].Substring(0, split[1].IndexOf(splitIndex));
        }
    }
}