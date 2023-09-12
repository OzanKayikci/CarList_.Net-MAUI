namespace CarList.Models
{
    interface ICar
    {
        int id { get; set; }
        string title { get; set; }
        string modelName { get; set; }
        int price { get; set; }
        string priceFormatted { get; set; }
        public LocationBase location { get; set; }
        CategoryBase category { get; set; }
        DateTime date { get; set; }
        string dateFormatted { get; set; }

        List<PropertyBase> properties { get; set; }

    }



}
