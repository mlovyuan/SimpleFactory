using SimpleFactory.Sport;
using System;
using System.Collections.Generic;

namespace SimpleFactory.Factory
{
    static class Person_DictionaryReflection_Type
    {
        private static Dictionary<SportCategory, Type> SportDictionary;

        static Person_DictionaryReflection_Type()
        {
            SportDictionary = new Dictionary<SportCategory, Type>
            {
                { SportCategory.Jog,  typeof(Jog)},
                { SportCategory.Baseball,  typeof(Baseball)},
            };
        }

        public static ISport GetSport(SportCategory sportName)
        {
            SportDictionary.TryGetValue(sportName, out Type sportClassType);
            return Activator.CreateInstance(sportClassType) as ISport;
        }
    }
}
