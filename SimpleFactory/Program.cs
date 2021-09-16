using SimpleFactory.Factory;
using SimpleFactory.Sport;
using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var 小明 = Person_SimpleFactory.GetSport(SportCategory.Jog);
            var 小豬 = Person_SimpleDictionary.GetSport(SportCategory.Jog);
            var 小呆 = Person_DictionaryReflection_Type.GetSport(SportCategory.Jog);
            var 小皮 = Person_DictionaryReflection_Constructor.GetSport(SportCategory.Jog);
            var 小彭 = Person_Factory_AttributeVersion.GetSport(SportCategory.Jog);

            Console.WriteLine(小皮.GetType().Name);

            Console.ReadLine();
        }

        
    }
}
