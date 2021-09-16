using SimpleFactory.Sport;
using System;

namespace SimpleFactory.Factory
{
    public static class Person_Factory_AttributeVersion
    {
        public static ISport GetSport(SportCategory sportName)
        {
            var type = Person_AttributeVersionHelper.GetType(sportName);
            return Activator.CreateInstance(type) as ISport;
        }
    }
}
