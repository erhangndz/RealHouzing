namespace RealHouzing.Consume.Models.MessageModels
{
    public class UpdateMessageViewModel
    {
        public int MessageID { get; set; }
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Content { get; set; }
    }
}
