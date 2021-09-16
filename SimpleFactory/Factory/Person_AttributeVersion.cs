using SimpleFactory.Sport;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Factory
{
    public class Person_AttributeVersion : Attribute
    {
        public Person_AttributeVersion(Type sport)  
        {
            Sport = sport;
        }
        public Type Sport { get; set; }
    }

    static public class Person_AttributeVersionHelper
    {
        static public Type GetType(SportCategory sportEnum)
        {
            var fieldInfo = typeof(SportCategory).GetField(sportEnum.ToString());
            var fieldAttribute = Attribute.GetCustomAttribute(fieldInfo, typeof(Person_AttributeVersion)) as Person_AttributeVersion;
            return fieldAttribute.Sport;
        }
    }
}
