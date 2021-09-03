using SimpleFactory.Sport;
using System.Collections.Generic;

namespace SimpleFactory.Factory
{
    static class Person_SimpleDictionary
    {
        private static Dictionary<SportCategory, ISport> SportDictionary;
        
        static Person_SimpleDictionary()
        {
            SportDictionary = new Dictionary<SportCategory, ISport>
            {
                { SportCategory.Jog,  new Jog()},
                { SportCategory.Baseball,  new Baseball()},
            };
        }

        public static ISport GetSport(SportCategory sportName)
        {
            SportDictionary.TryGetValue(sportName, out ISport sportClass);
            return sportClass;
        }
    }
}
