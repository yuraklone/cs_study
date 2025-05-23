﻿//冒険プログラムのステータスの話

float attackPower = 10; //攻撃力10

Console.WriteLine("現在の攻撃力" +  attackPower);

//インクリメント演算子
attackPower++; //1増やす
//++attackPower;でもOK

Console.WriteLine("インクリメント後の攻撃力" + attackPower);

//デクリメント演算子
attackPower--; //1減らす
//++attackPower;でもOK

Console.WriteLine("デクリメント後の攻撃力" + attackPower);

//攻撃の係数

float[] attack_k = { 1.1f, 1.5f, 0.8f, 0.6f, 1.0f };

Random rand = new Random();
int result;

for (int i = 0; i < 10; i++)
{
    result = rand.Next(0, 5);
    Console.WriteLine("プレイヤーの攻撃：" + attackPower * attack_k[result]);
}

//おみくじの結果
string[] omikuji = { "大吉", "吉", "末吉", "凶" };

//result = rand.Next(0, 4);
//Console.WriteLine("おみくじの結果" + omikuji[result]);

//while (result != 0) //条件の間繰り返す
//{
//    result = rand .Next(0, 4);
//    Console.WriteLine("おみくじの結果" + omikuji[result]);
//}

do
{
    result = rand .Next(0, 4);
    Console.WriteLine("おみくじの結果" + omikuji[result]);
}
while (result != 0);


Console.WriteLine("今年はついてるなぁ");


//配列の順次処理に特化した繰り返し構文
foreach (string omi in omikuji) 
{
    Console.WriteLine(omi);
}