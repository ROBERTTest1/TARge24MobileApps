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
                    "mercury.svg",
                    "mercury.svg",
                    "mercury.svg"
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
                    "venus.svg",
                    "venus.svg",
                    "venus.svg"
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
                    "earth.svg",
                    "earth.svg",
                    "earth.svg"
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
                    "mars.svg",
                    "mars.svg",
                    "mars.svg"
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
                    "jupiter.svg",
                    "jupiter.svg",
                    "jupiter.svg"
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
                    "saturn.svg",
                    "saturn.svg",
                    "saturn.svg"
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
                    "uranus.svg",
                    "uranus.svg",
                    "uranus.svg"
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
                    "neptune.svg",
                    "neptune.svg",
                    "neptune.svg"
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

