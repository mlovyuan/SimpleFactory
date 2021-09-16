using SimpleFactory.Factory;

namespace SimpleFactory.Sport
{
    public enum SportCategory
    {
        [Person_AttributeVersion(typeof(Jog))]
        Jog,

        [Person_AttributeVersion(typeof(Baseball))]
        Baseball
    }
}
