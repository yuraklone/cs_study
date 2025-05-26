//複数のキャラクターをたくさん当序させて、それぞれのステータスや特技を順番に表示するプログラム

using object_study;

Player hiroshi = new Warrior("ひろし");　//クラスのインスタンス化・実体化
//hiroshi.Name("ひろし");
hiroshi.Action();
hiroshi.StatusDisplay();
hiroshi.SpecialAttack();

Warrior yoshida = new Warrior("よしだ");　//クラスのインスタンス化・実体化
//yoshida.Name("よしだ");
yoshida.Action(1);
yoshida.HardAttack();
yoshida.StatusDisplay();
yoshida.SpecialAttack();

Player nanjolno = new Player();　//クラスのインスタンス化・実体化
nanjolno.NameSet("なんじょる");
nanjolno.Action(2);
nanjolno.StatusDisplay();
nanjolno.SpecialAttack();
