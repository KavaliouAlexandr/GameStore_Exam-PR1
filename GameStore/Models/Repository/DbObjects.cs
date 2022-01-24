using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models.Repository
{
    public class DbObjects
    {
        public List<Game> DefGames
        {
            get
            {
                return new List<Game>
                {
                    new Game
                    {
                        GameId = 1,
                        Name = "SimCity",
                        Description = "Symulator budowania miasta powraca! Spersonalizuj miasto swoich marzeń.",
                        Category = "Symulator",
                        Price = 299
                    },
                    new Game
                    {
                        GameId = 2,
                        Name = "Battlefield 4",
                        Description = "Battlefield 4 to definiująca gatunek, pełna akcji gra akcji znana z niezrównanej możliwości zniszczenia.",
                        Category = "Shooter",
                        Price = 199
                    },
                    new Game
                    {
                        GameId = 3,
                        Name = "The Elder Scrolls V",
                        Description = "Po zabójstwie króla Skyrim imperium znalazło się na krawędzi katastrofy. Nowe sojusze zgromadziły się wokół pretendentów do tronu, i wybuchł konflikt. Ponadto, jak przepowiadały starożytne zwoje, na świat powróciły okrutne i bezlitosne smoki. Teraz przyszłość Skyrim i wszystkich imperium zależy od smoczego dziecka – człowieka, w którego żyłach płynie krew legendarnych stworzeń.",
                        Category = "RPG",
                        Price = 399
                    },
                    new Game
                    {
                        GameId = 4,
                        Name = "Dark Souls II",
                        Description = "Kontynuacja słynnej akcji RPG ponownie zmusi graczy do przejścia przez najtrudniejsze testy. Dark Souls II zaoferuje nowy bohater, nowa historia i nowy świat. Tylko jedno jest niezmienne – przetrwanie w ponurym uniwersum Dark Souls jest bardzo trudne.",
                        Category = "RPG",
                        Price = 150
                    },
                    new Game
                    {
                        GameId = 5,
                        Name = "Dead Space 3",
                        Description = "W Dead Space 3 Isaac Clarke i twardy żołnierz John Carver wyruszają w kosmiczną podróż, aby poznać pochodzenie Nekromorfów.",
                        Category = "Shooter",
                        Price = 499
                    },
                    new Game
                    {
                        GameId = 6,
                        Name = "TITANFALL",
                        Description = "Ta gra przeniesie Cię do wszechświata, w którym małe przeciwstawia się dużemu, natura przeciwstawia się przemysłowi, a człowiek przeciwstawia się maszynie.",
                        Category = "Shooter",
                        Price = 399
                    },
                    new Game
                    {
                        GameId = 7,
                        Name = "FIFA 22",
                        Description = "Niezawodna, piękna, emocjonująca piłka nożna! Uświęcona tradycją rozgrywka w FIFA stała się jeszcze lepsza dzięki innowacjom, które zachęcają do kreatywnej gry w środek pola i pozwalający na ustalenie jego tempa.",
                        Category = "Symulator",
                        Price = 539
                    },
                    new Game
                    {
                        GameId = 8,
                        Name = "Need for Speed",
                        Description = "Zapomnij o standardowych trybach gry. Zacieraj granicę między trybem dla jednego gracza a trybem wieloosobowym w ciągłej rywalizacji między jeźdźcami a policją. Swobodnie wkrocz do świata, w którym Twoi znajomi już się ścigają i ścigają.",
                        Category = "Symulator",
                        Price = 199
                    }
                };
            }
        }

    }
}