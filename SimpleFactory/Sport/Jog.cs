using System;

namespace SimpleFactory.Sport
{
    public class Jog : BaseSport, ISport
    {
        protected override string Name => "慢跑";


        public void Play()
        {
            Console.WriteLine("跑起乃");
        }
    }
}
