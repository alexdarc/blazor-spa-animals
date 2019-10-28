namespace WebApplication1.Data
{
    using System.ComponentModel.DataAnnotations;

    public class AddAnimalRequestModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Url]
        public string Image { get; set; }
    }
}