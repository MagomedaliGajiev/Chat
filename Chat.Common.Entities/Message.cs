namespace Chat.Common.Entities
{
    public class Message
    {
        public Guid Id { get; set; } 
        public User User { get; set; }
        public string Content { get; set; } 
    }
}
