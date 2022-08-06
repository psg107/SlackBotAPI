namespace SlackBotAPI.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryStringAttribute : System.Attribute
    {
        public QueryStringAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
