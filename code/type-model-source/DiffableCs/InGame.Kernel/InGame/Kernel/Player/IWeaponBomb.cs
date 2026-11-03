namespace InGame.Kernel.Player;

[Token(Token = "0x200010A")]
internal interface IWeaponBomb
{

	[Token(Token = "0x6000844")]
	public bool Bomb(int nlevel) { }

	[Token(Token = "0x6000842")]
	public IEnumerator Initialize(Transform root, int playerNo) { }

	[Token(Token = "0x6000845")]
	public bool IsBomb() { }

	[Token(Token = "0x6000843")]
	public void Terminate() { }

}

