//複数のキャラクターをたくさん当序させて、それぞれのステータスや特技を順番に表示するプログラム

using object_study;

Player hiroshi = new Player("ひろし");　//クラスのインスタンス化・実体化
//hiroshi.Name("ひろし");
hiroshi.Action();
hiroshi.StatusDisplay();

Player yoshida = new Player();　//クラスのインスタンス化・実体化
yoshida.Name("よしだ");
yoshida.Action(1);
yoshida.StatusDisplay();

Player nanjolno = new Player();　//クラスのインスタンス化・実体化
nanjolno.Name("なんじょる");
nanjolno.Action(2);
nanjolno.StatusDisplay();
