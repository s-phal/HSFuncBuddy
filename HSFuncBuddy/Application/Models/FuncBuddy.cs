namespace HSFuncBuddy.Application.Models
{
    public class FuncBuddy
    {
        public int func_buddy_id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int language_id { get; set; }
        public DateTime created_date { get; set; }
    }
}
