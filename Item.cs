namespace csharp
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return $"{this.Name}, {this.SellIn}, {this.Quality}";
        }

        public virtual void UpdateQuality()
        {
            this.Quality -= 1;
        }

        public virtual void UpdateSelling()
        {
            this.SellIn -= 1;
        }
    }
}
