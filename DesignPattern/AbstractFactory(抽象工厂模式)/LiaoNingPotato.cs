using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory_抽象工厂模式_
{
    public class LiaoNingPotato : Phato
    {
        public override void GetPotato()
        {
            Console.WriteLine("LiaoNing cook potato");
        }
    }
}
