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
        private string name;
        private int hp;
        private float attack;
        private float defence;
        private string job;

        //コンストラクタの設計
        public Player():this("無名のプレイヤー" )//引数付きコンストラクタを利用
        {

        }

        public Player(string name)　//引数付きコンストラクタ
        {
            this.name = "";
            hp = 100;
            attack = 10;
            defence = 10;
            job = "冒険者";
        }
        //hpのプロパティ
        public int HP
        {
            //set
            //{
            //    this.hp = value; //valueは値を代入する際の想定地
            //    if (this.hp < 0)
            //    {
            //        this.hp = 0;
            //    }
            //}
            get
            {
                return this.hp; //returnの後にある値を結果として返す
            }
        }


        public void Name(string name)
        {
            this.name = name;
        }

        public void Action()
        {
            Console.WriteLine("横にかわした！");
        }

        public void Action(int i)
        {
            if (i == 1) Console.WriteLine(attack + "のダメージ！");
            else if (i == 2) Console.WriteLine(defence + "で防御！");
            else Console.WriteLine("横にかわした！");
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
