using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomstr
{
    class Crow : Bird
    {
        public Crow() : base("カラス")
        {
        }
        //  カラスがなく
        public override void Sing()
        {
            Console.WriteLine("カーカー");
        }

    }
}
