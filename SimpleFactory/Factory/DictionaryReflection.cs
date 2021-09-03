using SimpleFactory.Sport;
using System;
using System.Collections.Generic;

namespace SimpleFactory.Factory
{
    static class DictionaryReflection
    {
        private static Dictionary<SportCategory, Func<object>> SportDictionary;

        static DictionaryReflection()
        {
            //SportDictionary = new Dictionary<SportCategory, Func<object>>
            //{
            //    { SportCategory.Jog,  typeof(Jog)},
            //    { SportCategory.Baseball,  typeof(Baseball)},
            //};
        }
        //public static ISport GetSport(SportCategory sportName)
        //{
        //}
    }
}
