namespace WebApplication1.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class AnimalListService
    {
        private static readonly List<Animal> AnimalList = new List<Animal>
        {
            new Animal(
                name: "Dog",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/dog.jpg"),
            new Animal(
                name: "Cat",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/cat.jpg"),
            new Animal(
                name: "Rabbit",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/rabbit.jpg"),
            new Animal(
                name: "Bird",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/bird.jpg"),
            new Animal(
                name: "Horse",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/horse.jpg"),
            new Animal(
                name: "Chicken",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/chicken.jpg"),
            new Animal(
                name: "Snake",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/snake.jpg"),
            new Animal(
                name: "Fish",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/fish.jpg"),
            new Animal(
                name: "Eagle",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/eagle.jpg"),
            new Animal(
                name: "Shark",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/shark.jpg"),
            new Animal(
                name: "Ant",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/ant.jpg"),
            new Animal(
                name: "Pig",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/pig.jpg"),
            new Animal(
                name: "Duck",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/duck.jpg"),
            new Animal(
                name: "Bear",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/bear.jpg"),
            new Animal(
                name: "Lion",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/lion.jpg"),
            new Animal(
                name: "Wolf",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/wolf.jpg"),
            new Animal(
                name: "Bee",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/bee.jpg"),
            new Animal(
                name: "Deer",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/deer.jpg"),
            new Animal(
                name: "Cow",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/cow.jpg"),
            new Animal(
                name: "Monkey",
                imageUrl: "https://inspirich.com/wp-content/uploads/2016/04/monkey.jpg")
        };

        public static Task<Animal> GetRandomAnimal()
        {
            var random = new Random();
            var randomIndex = random.Next(
                maxValue: AnimalList.Count);

            return Task.FromResult(
                result: AnimalList[index: randomIndex]);
        }

        public static void RemoveAnimal(
            Animal animal)
        {
            AnimalList.Remove(
                item: animal);
        }

        public static void AddAnimal(
            Animal animal)
        {
            AnimalList.Add(item: animal);
        }

        public static List<Animal> GetAnimalList()
        {
            return AnimalList /*.ToList()*/;
        }
    }
}