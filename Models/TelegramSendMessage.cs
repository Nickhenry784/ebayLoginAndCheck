namespace ebayLoginAndCheck.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Chat
    {
        public int id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public bool all_members_are_administrators { get; set; }
    }

    public class From
    {
        public long id { get; set; }
        public bool is_bot { get; set; }
        public string first_name { get; set; }
        public string username { get; set; }
    }

    public class ResultTelegram
    {
        public int message_id { get; set; }
        public From from { get; set; }
        public Chat chat { get; set; }
        public int date { get; set; }
        public string text { get; set; }
    }

    public class TelegramSendMessage
    {
        public bool ok { get; set; }
        public ResultTelegram result { get; set; }
    }


}
