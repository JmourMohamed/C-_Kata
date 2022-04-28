namespace csharp
{
    public class Backstage : Item
    {
        public override void UpdateQuality()
        {
            if (this.SellIn <= 5)
            {
                this.Quality += 3;
            }
            else if (this.SellIn <= 10)
            {
                this.Quality += 2;
            }
            else
            {
                this.Quality += 1;
            }
        }
    }
}
