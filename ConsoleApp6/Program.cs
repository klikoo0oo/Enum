using System;

namespace seasons
{
    internal class Program
    {
        public static class seasons
        {
            public static int Temperatyr(Seasons season)
            {
                switch (season)
                {
                    case Seasons.spring:
                        return 9;
                    case Seasons.summer:
                        return 20;
                    case Seasons.autumn:
                        return 9;
                    case Seasons.winter:
                        return -20;
                }
                return 0;
            }

            public static string returnString(Seasons season, Seasons temperature)
            {
                switch (season)
                {
                    case Seasons.spring:
                        return "Я люблю весну";
                    case Seasons.summer:
                        return "Я люблю лето";
                    case Seasons.autumn:
                        return "Я люблю осень";
                    case Seasons.winter:
                        return "Я люблю зиму";
                }
                return "";
            }
            public static string returnString(Seasons season)
            {
                switch (season)
                {
                    case Seasons.spring:
                        return "Веснa удивляет своей красотой";
                    case Seasons.summer:
                        return "Лето - это время отдыха";
                    case Seasons.autumn:
                        return "Осень - это отличное время года";
                    case Seasons.winter:
                        return "Зима - самое холодное время года";
                }
                return "";
            }
            public static string getDescription(Seasons season)
            {
                if (season == Seasons.summer)
                {
                    return "Тёплое время года";
                }
                return "Холодное время года";
            }
            static void Main(string[] args)
            {
                Console.WriteLine(returnString(Seasons.spring));
                Console.WriteLine(returnString(Seasons.summer));
                Console.WriteLine(returnString(Seasons.autumn));
                Console.WriteLine(returnString(Seasons.winter));
                Console.WriteLine(getDescription(Seasons.spring));
                Console.WriteLine(getDescription(Seasons.summer));
                Console.WriteLine(getDescription(Seasons.autumn));
                Console.WriteLine(getDescription(Seasons.winter));
                Console.WriteLine(Temperatyr(Seasons.spring));
                Console.WriteLine(Temperatyr(Seasons.summer));
                Console.WriteLine(Temperatyr(Seasons.autumn));
                Console.WriteLine(Temperatyr(Seasons.winter));
            }
            public enum Seasons
            {
                spring = 0,
                summer = 1,
                autumn = 2,
                winter = 3,
                springTemperature = 9,
                summerTemperature = 20,
                autumnTemperature = -9,
                winterTemperature = -20,
            }
        }

    }
}