using System;

namespace SimpleFactory.Sport
{
    public class Baseball : BaseSport, ISport
    {
        protected override string Name => "棒球";


        public void Play()
        {
            Console.WriteLine("跑起乃");
        }
    }
}
