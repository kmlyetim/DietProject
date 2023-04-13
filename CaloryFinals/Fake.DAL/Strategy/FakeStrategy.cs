using Fake.DAL.Context;
using Fake.DAL.Entities;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Fake.DAL.Strategy
{
    public class FakeStrategy : CreateDatabaseIfNotExists<FakeContext>
    {
        protected override void Seed(FakeContext context)
        {
            Category category1 = new Category() { Name = "Fruit", Description = "In botany, the fruit is the seed-bearing structure in flowering plants that is formed from the ovary after flowering." };
            Category category2 = new Category() { Name = "Fish", Description = "Fish is a low-fat high quality protein. Fish is filled with omega-3 fatty acids and vitamins such as D and B2 (riboflavin). Fish is rich in calcium and phosphorus and a great source of minerals, such as iron, zinc, iodine, magnesium, and potassium." };
            Category category3 = new Category() { Name = "Grain", Description = "Grain is the harvested seed of grasses such as wheat, oats, rice, and corn. Other important grains include sorghum, millet, rye, and barley. Around the globe, grains, also called cereals, are the most important staple food. Humans get an average of 48 percent of their calories, or food energy, from grains." };
            Category category4 = new Category() { Name = "Pastries", Description = "Pastry is baked food made with a dough of flour, water and shortening (solid fats, including butter or lard) that may be savoury or sweetened." };
            Category category5 = new Category() { Name = "Milk And Milk Products", Description = "Dairy products or milk products, also known as lacticinia, are food products made from (or containing) milk. The most common dairy animals are cow, water buffalo, nanny goat, and ewe." };
            Category category6 = new Category() { Name = "Vegetables", Description = "Vegetables are parts of plants that are consumed by humans or other animals as food. The original meaning is still commonly used and is applied to plants collectively to refer to all edible plant matter, including the flowers, fruits, stems, leaves, roots, and seeds." };
            Category category7 = new Category() { Name = "Meat products", Description = "Meat is animal flesh that is eaten as food.[1] Humans have hunted, farmed, and scavenged animals for meat since prehistoric times." };
            context.Categories.Add(category1);
            context.Categories.Add(category2);
            context.Categories.Add(category3);
            context.Categories.Add(category4);
            context.Categories.Add(category5);
            context.Categories.Add(category6);
            context.Categories.Add(category7);
            context.SaveChanges();


            byte[] ConvertFileToByte(string sPath)
            {
                byte[] data = null;
                FileInfo fInfo = new FileInfo(sPath);
                long numBytes = fInfo.Length;
                FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fStream);
                data = br.ReadBytes((int)numBytes);
                return data;
            }

            Food food = new Food()
            {
                Name = "Tomato",
                Calory = 22,
                Description = "A herbaceous plant from the tomato nightshade family, whose homeland is South and Central America, and whose fruit can be eaten.",
                Protein = 1.08,
                Carbohydrate = 4.78,
                Fat = 0.25,
                PortionType = Enums.Portion.Piece,
                CategoryId = 6,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "tomato.jpg"))

            };

            Food food1 = new Food()
            {
                Name = "Rice",
                Calory = 25,
                Description = "It is a dish made by cooking grained herbs or pasta such as vermicelli and couscous in water.",
                Protein = 0.41,
                Carbohydrate = 4.31,
                Fat = 0.65,
                PortionType = Enums.Portion.Spoon,
                CategoryId = 3,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "rice.jpg"))
            };

            Food food2 = new Food()
            {
                Name = "Anchovy",
                Calory = 0.8,
                Description = "Anchovy is an oseanodromous saltwater fish that lives in subtropical seas at a depth of up to 400 meters.",
                Protein = 1.25,
                Carbohydrate = 0,
                Fat = 0.5,
                PortionType = Enums.Portion.Piece,
                CategoryId = 2,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "ancovy.jpg"))
            };

            Food food3 = new Food()
            {
                Name = "Bagel",
                Calory = 434,
                Description = "A dense bread roll in the shape of a ring, made by boiling dough and then baking it.",
                Protein = 1,
                Carbohydrate = 69,
                Fat = 17,
                PortionType = Enums.Portion.Piece,
                CategoryId = 4,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Simit.jpg"))
            };

            Food food4 = new Food()
            {
                Name = "Brown bread",
                Calory = 63,
                Description = "Brown bread is bread made with significant amounts of whole grain flour, usually wheat, and sometimes dark-coloured ingredients such as molasses or coffee.",
                Protein = 3.11,
                Carbohydrate = 10.68,
                Fat = 0.88,
                PortionType = Enums.Portion.Slice,
                CategoryId = 4,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Brownbread.jpg"))
            };

            Food food5 = new Food()
            {
                Name = "Rolled oats",
                Calory = 73,
                Description = "Rolled oats are a type of lightly processed whole-grain food. Traditionally, they are made from oat groats that have been dehusked and steamed, before being rolled into flat flakes under heavy rollers and then stabilized by being lightly toasted.",
                Protein = 3.20,
                Carbohydrate = 13.40,
                Fat = 1.26,
                PortionType = Enums.Portion.Spoon,
                CategoryId = 4,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "ORG-yulaf-ezmesi-kg467.jpg"))
            };

            Food food6 = new Food()
            {
                Name = "Feta cheese",
                Calory = 60,
                Description = "Feta is a Greek brined white cheese made from sheep's milk or from a mixture of sheep and goat's milk. ",
                Protein = 2.35,
                Carbohydrate = 2.44,
                Fat = 4.58,
                PortionType = Enums.Portion.Slice,
                CategoryId = 5,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "fetacheese.jpg"))
            };

            Food food7 = new Food()
            {
                Name = "Buttermilk",
                Calory = 76,
                Description = "Buttermilk is a fermented dairy drink. Traditionally, it was the liquid left behind after churning butter out of cultured cream.",
                Protein = 4,
                Carbohydrate = 5.6,
                Fat = 4,
                PortionType = Enums.Portion.Cup,
                CategoryId = 5,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Fresh_ayran.jpg"))
            };

            Food food8 = new Food()
            {
                Name = "Apple",
                Calory = 95,
                Description = "An apple is an edible fruit produced by an apple tree (Malus domestica). Apple trees are cultivated worldwide and are the most widely grown species in the genus Malus.",
                Protein = 0.47,
                Carbohydrate = 25.13,
                Fat = 0.31,
                PortionType = Enums.Portion.Slice,
                CategoryId = 1,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "elma.jpg"))
            };

            Food food9 = new Food()
            {
                Name = "Orange",
                Calory = 62,
                Description = "An orange is a fruit of various citrus species in the family Rutaceae ; it primarily refers to Citrus × sinensis, which is also called sweet orange, to distinguish it from the related Citrus × aurantium, referred to as bitter orange.",
                Protein = 1.23,
                Carbohydrate = 15.39,
                Fat = 0.16,
                PortionType = Enums.Portion.Slice,
                CategoryId = 1,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Oranges_-_whole-halved-segment.jpg"))
            };

            Food food10 = new Food()
            {
                Name = "Banana",
                Calory = 105,
                Description = "A banana is an elongated, edible fruit – botanically a berry – produced by several kinds of large herbaceous flowering plants in the genus Musa.",
                Protein = 1.29,
                Carbohydrate = 126.95,
                Fat = 0.39,
                PortionType = Enums.Portion.Slice,
                CategoryId = 1,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "banana.jpg"))
            };

            Food food11 = new Food()
            {
                Name = "Peach",
                Calory = 58,
                Description = "The peach is a deciduous tree first domesticated and cultivated in Zhejiang province of Eastern China. It bears edible juicy fruits with various characteristics, most called peaches and others , nectarines.",
                Protein = 1.36,
                Carbohydrate = 14.31,
                Fat = 0.38,
                PortionType = Enums.Portion.Slice,
                CategoryId = 1,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "organik-seftali-organik-ufuklar-4134-450x450-product_thumb.jpg"))
            };

            Food food12 = new Food()
            {
                Name = "Cucumber",
                Calory = 15,
                Description = "The cucumber is a widely-cultivated creeping vine plant in the family Cucurbitaceae that bears cylindrical to spherical fruits, which are used as culinary vegetables.",
                Protein = 0.65,
                Carbohydrate = 3.63,
                Fat = 0.11,
                PortionType = Enums.Portion.Slice,
                CategoryId = 6,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Cucumber.jpg"))
            };

            Food food13 = new Food()
            {
                Name = "Broccoli",
                Calory = 31,
                Description = "Broccoli is an edible green plant in the cabbage family  whose large flowering head, stalk and small associated leaves are eaten as a vegetable.",
                Protein = 2.57,
                Carbohydrate = 6.04,
                Fat = 0.34,
                PortionType = Enums.Portion.Slice,
                CategoryId = 6,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "broccoli.jpg"))
            };

            Food food14 = new Food()
            {
                Name = "Carrot",
                Calory = 25,
                Description = "The carrot is a root vegetable, typically orange in color, though purple, black, red, white, and yellow cultivars exist,all of which are domesticated forms of the wild carrot, Daucus carota, native to Europe and Southwestern Asia.",
                Protein = 0.57,
                Carbohydrate = 5.84,
                Fat = 0.15,
                PortionType = Enums.Portion.Slice,
                CategoryId = 6,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "carrot.jpg"))
            };

            Food food15 = new Food()
            {
                Name = "Meatball",
                Calory = 59,
                Description = "A meatball is ground meat rolled into a ball, sometimes along with other ingredients, such as bread crumbs, minced onion, eggs, butter, and seasoning.",
                Protein = 6.30,
                Carbohydrate = 2.40,
                Fat = 2.70,
                PortionType = Enums.Portion.Piece,
                CategoryId = 7,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Meatball.jpg"))
            };

            Food food16 = new Food()
            {
                Name = "Steak",
                Calory = 75.6,
                Description = "A steak is a thick cut of meat generally sliced across the muscle fibers, sometimes including a bone. It is normally grilled or fried. ",
                Protein = 8.2,
                Carbohydrate = 0,
                Fat = 4.5,
                PortionType = Enums.Portion.Piece,
                CategoryId = 7,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Steak.jpg"))
            };

            Food food17 = new Food()
            {
                Name = "Chicken",
                Calory = 76,
                Description = "Chicken is the most common type of poultry in the world. Owing to the relative ease and low cost of raising chickens—in comparison to mammals such as cattle or hogs—chicken meat  and chicken eggs have become prevalent in numerous cuisines.",
                Protein = 15.27,
                Carbohydrate = 0,
                Fat = 1.58,
                PortionType = Enums.Portion.Piece,
                CategoryId = 7,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "chick.jpg"))
            };

            Food food18 = new Food()
            {
                Name = "Salmon",
                Calory = 76,
                Description = "Salmon is the common name for several commercially important species of euryhaline ray-finned fish from the family Salmonidae, which are native to tributaries of the North Atlantic and North Pacific basin. Other closely related fish in the same family include trout, char, grayling, whitefish, lenok and taimen.",
                Protein = 12.29,
                Carbohydrate = 0,
                Fat = 2.64,
                PortionType = Enums.Portion.Piece,
                CategoryId = 2,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Salmon.jpg"))
            };

            Food food19 = new Food()
            {
                Name = "Haricot Bean",
                Calory = 35.3,
                Description = "The navy bean, haricot, pearl haricot bean, Boston bean, white pea bean, or pea bean is a variety of the common bean  native to the Americas, where it was first domesticated.",
                Protein = 0.68,
                Carbohydrate = 3.47,
                Fat = 2.21,
                PortionType = Enums.Portion.Spoon,
                CategoryId = 3,
                Picture = ConvertFileToByte(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Kuru Fasulye.jpg"))
            };

            context.Foods.Add(food1);
            context.Foods.Add(food2);
            context.Foods.Add(food);
            context.Foods.Add(food3);
            context.Foods.Add(food4);
            context.Foods.Add(food5);
            context.Foods.Add(food6);
            context.Foods.Add(food7);
            context.Foods.Add(food8);
            context.Foods.Add(food9);
            context.Foods.Add(food10);
            context.Foods.Add(food11);
            context.Foods.Add(food12);
            context.Foods.Add(food13);
            context.Foods.Add(food14);
            context.Foods.Add(food15);
            context.Foods.Add(food16);
            context.Foods.Add(food17);
            context.Foods.Add(food18);
            context.Foods.Add(food19);
            context.SaveChanges();
            User user1 = new User()
            {
                FirstName = "Bilge",
                LastName = "Adam",
                Height = 180,
                Weight = 80,
                ActivityState = Enums.Activites.Little,
                Email = "bilge.adam@fake.com",
                Password = "AAaa11!!",
                BirthDate = DateTime.Parse("01 / 01 / 1970"),
                Gender = Enums.Gender.Female,
                PhoneNumber = "(111)111-1111",
                UserStatus = Enums.UserStatus.Owner
            };
            User user2 = new User()
            {
                FirstName = "Younan",
                LastName = "Nowzaradan",
                Height = 180,
                Weight = 80,
                ActivityState = Enums.Activites.Little,
                Email = "younan.nowzaradan@fake.com",
                Password = "AAaa11!!",
                BirthDate = DateTime.Parse("01 / 01 / 1944"),
                Gender = Enums.Gender.Male,
                PhoneNumber = "(222)222-2222",
                UserStatus = Enums.UserStatus.Expert
            };
            User user3 = new User()
            {
                FirstName = "Canan",
                LastName = "Karatay",
                Height = 160,
                Weight = 50,
                ActivityState = Enums.Activites.Athlete,
                Email = "canan.karatay@fake.com",
                Password = "AAaa11!!",
                BirthDate = DateTime.Parse("01 / 01 / 1943"),
                Gender = Enums.Gender.Female,
                PhoneNumber = "(333)333-3333",
                UserStatus = Enums.UserStatus.Expert
            };
            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Users.Add(user3);
            context.SaveChanges();
        }
    }
}
