using SimpleFactory.Sport;
using System;
using System.Collections.Generic;

namespace SimpleFactory.Factory
{
    static class MeReflection
    {
        private static Dictionary<SportCategory, Func<object>> SportDictionary;

        static MeReflection()
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
