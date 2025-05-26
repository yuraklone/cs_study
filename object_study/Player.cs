using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace object_study
{
    internal class Player
    {
        public string name;
        public int hp =100;
        public float attack =120;
        public float defence =80;
        public string job ="冒険者";


        public void Name(string name)
        {
            this.name = name;
        }

        public void Attack() 
        {
            Console.WriteLine(attack + "のダメージを与えた");
        }

        public void StatusDisplay()
        {
            Console.WriteLine("NAME:" + name);
            Console.WriteLine("HP:" + hp);
            Console.WriteLine("ATK:" + attack);
            Console.WriteLine("DEF" + defence);
            Console.WriteLine("JOB"+job);
        }

    }
}
