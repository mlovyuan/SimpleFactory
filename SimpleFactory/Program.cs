using SimpleFactory.Factory;
using SimpleFactory.Sport;
using System;
using System.Collections.Generic;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // 工廠要怎麼用到 abstract?
            var 小明 = Person_SimpleFactory.GetSport(SportCategory.Jog);
            var 小豬 = Person_SimpleDictionary.GetSport(SportCategory.Jog);
            var 小呆 = Person_DictionaryReflection.GetSport(SportCategory.Jog);
        }
    }

}
