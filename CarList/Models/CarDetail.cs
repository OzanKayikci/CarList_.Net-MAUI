namespace CarList.Models
{
    public class CarDetail : ICar
    {


        public List<string> Photos { get; set; }

        public string Text { get; set; }
        public UserInfo UserInfo { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string modelName { get; set; }
        public int price { get; set; }
        public string priceFormatted { get; set; }
        public LocationBase location { get; set; }
        public CategoryBase category { get; set; }
        public DateTime date { get; set; }
        public string dateFormatted { get; set; }
        public List<PropertyBase> properties { get; set; }
    }


}
