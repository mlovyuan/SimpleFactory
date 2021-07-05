using SimpleFactory.Sport;
using System;

namespace SimpleFactory.Factory
{
    static class Person_SimpleFactory
    {
        public static ISport GetSport(SportCategory sportName)
        {
            switch (sportName)
            {
                case SportCategory.Jog:
                    return new Jog();
                case SportCategory.Baseball:
                    return new Baseball();
                default:
                    throw new ArgumentNullException();
            }
        }
    }
}
