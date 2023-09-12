namespace CarList.Models
{


    public class Car : ICar
    {
        public virtual DateTime date { get; set; }
        public virtual int id { get; set; }
        public virtual string title { get; set; }
        public virtual string modelName { get; set; }
        public virtual int price { get; set; }
        public virtual string priceFormatted { get; set; }
        public virtual string dateFormatted { get; set; }

        public virtual string photo { get; set; }
        public virtual LocationBase location { get; set; }
        public virtual CategoryBase category { get; set; }
        public virtual List<PropertyBase> properties { get; set; }
    }


}