using MauiPlanets.Models;


namespace MauiPlanets.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.svg",
                Description = "Mercury is the first planet from the Sun and " +
                "the smallest in the Solar System. It is a rocky planet" +
                " with a trace atmosphere and a surface gravity slightly higher " +
                "than that of Mars. The surface of Mercury is similar to Earth's " +
                "Moon, being heavily cratered, with an expansive rupes system " +
                "generated from thrust faults, and bright ray systems, formed by " +
                "ejecta. Its largest crater, Caloris Planitia, has a diameter " +
                "of 1,550 km (960 mi), which is about one-third the diameter of " +
                "the planet (4,880 km or 3,030 mi)",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg",
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "Similar size to Earth",
                HeroImage = "venus.svg",
                Description = "covered in thick clouds of carbon dioxide. It has an extreme greenhouse effect, making it the hottest planet in the Solar System.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "Our home planet.",
                HeroImage = "earth.svg",
                Description = "Our home planet, the only known world with liquid water on the surface and life. It has a balanced atmosphere of nitrogen and oxygen.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "Known as the Red Planet.",
                HeroImage = "mars.svg",
                Description = "It has the largest volcano (Olympus Mons) and a thin atmosphere, with evidence of ancient water.",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/78_mars_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/79_mars_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/80_mars_carousel_3.jpg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The largest planet..",
                HeroImage = "jupiter.svg",
                Description = "Gas giant with strong storms (like the Great Red Spot). It has a strong magnetic field and dozens of moons, including Ganymede, the largest in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "Famous for its spectacular rings",
                HeroImage = "saturn.svg",
                Description = "Made of ice and rock. It's a gas giant with many moons, including Titan, which has lakes of liquid methane.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg"
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "Ice giant.",
                HeroImage = "uranus.svg",
                Description = "Rotates on its side, making its seasons extreme. Its atmosphere contains methane, giving it a pale blue color.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/90_uranus_carousel_2.jpg"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "Farthest planet from the Sun.",
                HeroImage = "neptune.svg",
                Description = "Deep blue ice giant with supersonic winds and the moon Triton.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },
            new()
            {
                Name = "Pluto",
                Subtitle = "Dwarf planet in the Kuiper Belt",
                HeroImage = "pluto.jpg",
                Description = "Pluto is a complex and mysterious world with mountains, valleys, plains, craters, and glaciers. " +
                "It is located in the distant Kuiper Belt. " +
                "Discovered in 1930, Pluto was long considered our solar system's ninth planet. But after " +
                "the discovery of similar worlds deeper in the Kuiper Belt, Pluto was reclassified as a dwarf planet in 2006 " +
                "by the International Astronomical Union. " +
                "Pluto is only about 1,400 miles wide. At that small size, Pluto is only about half the width of the United States.",
                AccentColorStart = Color.FromArgb("#3b2e2b"),
                AccentColorEnd = Color.FromArgb("#c7a98a"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2024/03/pluto-new-horizons-pia20291-16x9-1.jpg",
                    "https://www.gannett-cdn.com/presto/2022/03/30/USAT/2b0a574f-1378-4536-9f93-5c7544aa760b-XXX_IMG_SPUTNIK_PLANITIA_COP_1_1_J9GECN43.JPG?width=592&format=pjpg&auto=webp&quality=70",
                    "https://cdn.mos.cms.futurecdn.net/DoZSMXF87kCuzbymsuEFHo-650-80.jpg"
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "Largest object in the asteroid belt",
                HeroImage = "ceres.jpg",
                Description = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter, " +
                "and it's the only dwarf planet located in the inner solar system. " +
                "It was the first member of the asteroid belt to be discovered when Giuseppe Piazzi spotted it in 1801. " +
                "When NASA's Dawn arrived in 2015, Ceres became the first dwarf planet to receive a visit from a spacecraft. " +
                "Called an asteroid for many years, Ceres is so much bigger and so different from its rocky neighbors that " +
                "scientists classified it as a dwarf planet in 2006.",
                AccentColorStart = Color.FromArgb("#545454"),
                AccentColorEnd = Color.FromArgb("#b0b0b0"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2024/03/ceres-dawn-pia19562-16x9-1.jpg?resize=600,338",
                    "https://cdn.mos.cms.futurecdn.net/PUnWUXynCLFjACVkVFYQ7M-970-80.jpg",
                    "https://cdn.mos.cms.futurecdn.net/g2uHbkqw93YdbhCXDwQepX-970-80.jpg"
                }
            },
            new()
            {
                Name = "Gonggong",
                Subtitle = "Dwarf planet candidate with a moon",
                HeroImage = "gonggong.jpg",
                Description = "Gonggong is a trans-Neptunian object and a strong candidate for dwarf planet status. " +
                "It is approximately half the size of Pluto and is located in the scattered disc region of the outer solar system. " +
                "Gonggong was discovered in 2007 and is named after a Chinese water god. " +
                "It has one known moon named Xiangliu, discovered in 2016. " +
                "Gonggong's surface is likely composed of water ice and other volatile materials, giving it a reddish appearance.",
                AccentColorStart = Color.FromArgb("#2d1b2e"),
                AccentColorEnd = Color.FromArgb("#8b5a8c"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/thesolarsystem6361/images/3/3b/E7810368-F1A1-4A04-A9AD-A21F19CE3090.png/revision/latest/scale-to-width-down/1000?cb=20220819213643"
                }
            },
            new()
            {
                Name = "Quaoar",
                Subtitle = "Dwarf planet with rings and a moon",
                HeroImage = "quaoar.webp",
                Description = "Quaoar is a large trans-Neptunian object and a strong candidate for dwarf planet classification. " +
                "It is slightly smaller than Gonggong and is located in the Kuiper Belt. " +
                "Quaoar was discovered in 2002 and is named after the Tongva creator god. " +
                "It has one known moon called Weywot, discovered in 2007. " +
                "In 2023, astronomers discovered that Quaoar has a ring system, which is unusual for objects of its size. " +
                "The rings are located at a distance that challenges current understanding of ring formation.",
                AccentColorStart = Color.FromArgb("#1a1a2e"),
                AccentColorEnd = Color.FromArgb("#4a4a6a"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/thesolarsystem6361/images/0/0e/OrbitOf50000Quaoar.jpeg/revision/latest?cb=20230711221035",
                    "https://static.wikia.nocookie.net/thesolarsystem6361/images/a/a9/QuaoarPaint.NET.png/revision/latest?cb=20180809074140"
                }
            },
            new()
            {
                Name = "Orcus",
                Subtitle = "Plutino dwarf planet candidate",
                HeroImage = "orcus.jpg",
                Description = "Orcus is a large trans-Neptunian object and a strong candidate for dwarf planet status. " +
                "It is comparable in size to Ceres and is located in the Kuiper Belt. " +
                "Orcus was discovered in 2004 and is named after the Etruscan god of the underworld. " +
                "It has a large moon named Vanth, discovered in 2005. " +
                "Orcus shares a similar orbital resonance with Neptune as Pluto does (2:3 resonance), making it a 'Plutino'. " +
                "Its surface is likely composed of water ice and may have cryovolcanic features.",
                AccentColorStart = Color.FromArgb("#0f0f1e"),
                AccentColorEnd = Color.FromArgb("#3d3d5c"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/thesolarsystem6361/images/2/20/Orcus2.webp/revision/latest?cb=20231120220619",
                    "https://static.wikia.nocookie.net/thesolarsystem6361/images/6/6b/Orcus_3.webp/revision/latest?cb=20231120220645",
                    "https://static.wikia.nocookie.net/thesolarsystem6361/images/c/c1/Orcus_Space_Engine.jpg/revision/latest/scale-to-width-down/1000?cb=20230429200924"
                }
            },
        };


        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}

