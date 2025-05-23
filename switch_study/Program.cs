const float maxHP = 10; //プレイヤーの最大HP
float currentHP = maxHP; //実際計算上のHP初期値

int result; //何を踏んだかの結果

int cure = 5; //回復量
int poison = 5; //ダメージ量

Console.WriteLine("最初のHP:" + currentHP);

Random rand = new Random(); //ランダムな機能を持っているRandomクラスの能力を変数randに実体化
result = rand.Next(0, 4);　//0以上4未満のランダム値を返す

switch (result)
{
    case 1:
        Console.WriteLine("回復した");
        break;
    case 2:
        Console.WriteLine("毒を踏んだ");
        break;
    case 3:
        Console.WriteLine("罠にかかった");
        break;
    default:
        Console.WriteLine("何も起きなかった");
        break;

}