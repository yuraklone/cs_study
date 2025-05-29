//複数のキャラクターをたくさん当序させて、それぞれのステータスや特技を順番に表示するプログラム

using object_study;

Player hiroshi = new Warrior("ひろし");　//クラスのインスタンス化・実体化
//hiroshi.Name("ひろし");
//hiroshi.Action();
//hiroshi.StatusDisplay();
//hiroshi.SpecialAttack();

Warrior yoshida = new Warrior("よしだ");　
//yoshida.Name("よしだ");
//yoshida.Action(1);
//yoshida.HardAttack();
//yoshida.StatusDisplay();
//yoshida.SpecialAttack();

Player nanjolno = new Player("なんじょる");
//nanjolno.NameSet("なんじょる");
//nanjolno.Action(2);
//nanjolno.StatusDisplay();
//nanjolno.SpecialAttack();

List<Player> players = new List<Player>();
players.Add(hiroshi);
players.Add(yoshida);
players.Add(nanjolno);

players.RemoveAt(1);

//配列を順番に処理する繰り返し構文
//抽出する情報の型名　一次的に情報を取り扱う変数名 in 対象配列
foreach(Player p in players)
{
    p.StatusDisplay();
    p.SpecialAttack();
}

