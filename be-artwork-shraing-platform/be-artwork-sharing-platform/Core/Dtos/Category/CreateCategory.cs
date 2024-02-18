namespace be_artwork_sharing_platform.Core.Dtos.Category
{
    public class CreateCategory
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
