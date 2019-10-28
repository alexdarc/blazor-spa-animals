namespace WebApplication1.Data
{
    public class Animal
    {
        public Animal(
            string name,
            string imageUrl)
        {
            this.Name = name;
            this.ImageUrl = imageUrl;
        }

        public string Name { get; }

        public string ImageUrl { get; }
    }
}