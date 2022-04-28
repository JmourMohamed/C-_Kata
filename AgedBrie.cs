namespace csharp
{
    public class AgedBrie : Item
    {
        public override void UpdateQuality()
        {
            if (this.SellIn >= 0)
            {
                this.Quality += 1;
            }
            else
            {
                this.Quality += 2;
            }
            this.SellIn += 1;
        }
    }
}
