using AutoMapper;

namespace be_artwork_sharing_platform.Core.Dtos.Category
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } 
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

    }
}
