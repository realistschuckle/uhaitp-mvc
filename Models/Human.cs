namespace UhAitpMvc.Models
{
    public class Human
    {
        private static int DatabaseId = 0;

        public Human()
        {
            Id = DatabaseId;
            DatabaseId += 1;
        }

        public int Id { get; }

        public string Email { get; set; }

        public string Hobby { get; set; }
    }
}