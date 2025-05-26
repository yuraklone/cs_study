//複数のキャラクターをたくさん当序させて、それぞれのステータスや特技を順番に表示するプログラム

using object_study;

Player hiroshi = new Player();　//クラスのインスタンス化・実体化
hiroshi.Name("ひろし");
hiroshi.Attack();
hiroshi.StatusDisplay();

Player yoshida = new Player();　//クラスのインスタンス化・実体化
yoshida.Name("よしだ");
yoshida.Attack();
yoshida.StatusDisplay();

Player nanjyolno = new Player();　//クラスのインスタンス化・実体化
nanjyolno.Name("なんじょる");
nanjyolno.Attack();
nanjyolno.StatusDisplay();
