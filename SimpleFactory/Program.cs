using SimpleFactory.Factory;
using SimpleFactory.Sport;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SimpleFactory
{
    class Program
    {
        static private Dictionary<SportCategory, Func<object>> Source;

        static void Main(string[] args)
        {
            // 工廠要怎麼用到 abstract?
            var 小明 = Person_SimpleFactory.GetSport(SportCategory.Jog);
            var 小豬 = Person_SimpleDictionary.GetSport(SportCategory.Jog);
            var 小呆 = Person_DictionaryReflection_Type.GetSport(SportCategory.Jog);
            var 小皮 = Person_DictionaryReflection_Constructor.GetSport(SportCategory.Jog);

            
            Console.WriteLine(小皮.GetType().Name);

            Console.ReadLine();
        }

        
    }
}
