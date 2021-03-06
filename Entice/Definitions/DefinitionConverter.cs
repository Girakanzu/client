﻿using GuildWarsInterface.Declarations;
using System;

namespace Entice.Definitions
{
    internal static class DefinitionConverter
    {
        public static Area ToArea(Map map)
        {
            switch (map)
            {
                case Map.HeroesAscent:
                    return Area.heroes_ascent;

                case Map.RandomArenas:
                    return Area.random_arenas;

                case Map.TeamArenas:
                    return Area.team_arenas;

                case Map.GreatTempleOfBalthazar:
                    return Area.great_temple_of_balthazar;

                default:
                    throw new ArgumentOutOfRangeException("map");
            }
        }

        public static Map ToMap(Area area)
        {
            switch (area)
            {
                case Area.heroes_ascent:
                    return Map.HeroesAscent;

                case Area.random_arenas:
                    return Map.RandomArenas;

                case Area.team_arenas:
                    return Map.TeamArenas;

                case Area.great_temple_of_balthazar:
                    return Map.GreatTempleOfBalthazar;

                default:
                    throw new ArgumentOutOfRangeException("area");
            }
        }
    }
}