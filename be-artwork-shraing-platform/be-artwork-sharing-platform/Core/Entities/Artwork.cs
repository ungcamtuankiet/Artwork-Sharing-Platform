namespace be_artwork_sharing_platform.Core.Entities
{
    public class Artwork : BaseEntity<long>
    { 
        public string Name { get; set; }
        public string Description { get; set; }
        public int quantity { get; set; }
        public double Price { get; set; }

    }
}
