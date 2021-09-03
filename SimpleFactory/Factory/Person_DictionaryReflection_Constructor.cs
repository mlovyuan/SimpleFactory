using SimpleFactory.Sport;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SimpleFactory.Factory
{
    static class Person_DictionaryReflection_Constructor
    {
        private static Dictionary<SportCategory, Func<object>> SportDictionary;

        static Person_DictionaryReflection_Constructor()
        {
            SportDictionary = new Dictionary<SportCategory, Func<object>>
            {
                { SportCategory.Jog,  GetConstructor(typeof(Jog))},
                { SportCategory.Baseball,  GetConstructor(typeof(Baseball))},
            };
        }

        static public ISport GetSport(SportCategory sportCategory)
        {
            SportDictionary.TryGetValue(sportCategory, out Func<object> value);
            return (ISport)value.Invoke();
        }

        /// <summary>
        /// 放著某類別建構式的方法清單
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        static private Func<object> GetConstructor(Type type)
        {
            var ctor = type.GetConstructor(new Type[] { });
            var method = new DynamicMethod($"CreateInstance<>{type.Name}", typeof(object), new Type[] { }, type);
            ILGenerator gen = method.GetILGenerator();
            gen.Emit(OpCodes.Newobj, ctor);
            gen.Emit(OpCodes.Ret);
            var ctrMethod = (Func<object>)method.CreateDelegate(typeof(Func<object>));
            return ctrMethod;
        }
    }
}
