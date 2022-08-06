using SlackBotAPI.Attributes;

namespace SlackBotAPI.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class HttpClientHelper
    {
        /// <summary>
        /// object -> querystring
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToQueryString<T>(this T obj) where T : class
        {
            var items = obj
                .GetType()
                .GetProperties()
                .Where(p => Attribute.IsDefined(p, typeof(QueryStringAttribute)) && p.GetValue(obj, null) != null)
                .Select(p => new
                {
                    Key = Uri.EscapeDataString((p.GetCustomAttributes(typeof(QueryStringAttribute), false).First() as QueryStringAttribute).Name),
                    Value = Uri.EscapeDataString(p.GetValue(obj).ToString())
                })
                .Select(x => $"{x.Key}={x.Value}");
            var queryString = string.Join("&", items);

            return queryString;
        }
    }
}
