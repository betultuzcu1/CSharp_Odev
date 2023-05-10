namespace MVC_Injection.Models
{
    public class Supplier
    {
        private static int _idCounter = 0;
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }

        public Supplier()
        {
            _idCounter++;
            ID = _idCounter;
        }
    }
}
