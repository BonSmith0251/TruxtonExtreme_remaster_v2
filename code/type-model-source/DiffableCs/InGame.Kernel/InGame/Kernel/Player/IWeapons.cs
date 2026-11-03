namespace InGame.Kernel.Player;

[Token(Token = "0x200010B")]
public interface IWeapons
{

	[Token(Token = "0x600084D")]
	public int Fire(float dt, bool isExBoost) { }

	[Token(Token = "0x6000855")]
	public Material GetMaterial(Mats mats) { }

	[Token(Token = "0x6000846")]
	public IEnumerator Initialize(Transform proot, Transform groot, GameObject player, Transform[] emitTable, int playerNo) { }

	[Token(Token = "0x6000847")]
	public void InitializeMaterails() { }

	[Token(Token = "0x6000848")]
	public void InitializeShotDatas() { }

	[Token(Token = "0x600084E")]
	public bool IsFire(bool isExBoost) { }

	[Token(Token = "0x6000851")]
	public ArmsKind Kind() { }

	[Token(Token = "0x6000857")]
	public PrefabBank<WeaponLaserCollision> LBBank() { }

	[Token(Token = "0x6000856")]
	public PrefabBank<WeaponNormalCollision> NBBank() { }

	[Token(Token = "0x600084F")]
	public void NoFire(float dt) { }

	[Token(Token = "0x600084C")]
	public void OnUpdate(float dt) { }

	[Token(Token = "0x6000850")]
	public int OptionLevel() { }

	[Token(Token = "0x6000853")]
	public ID PipiruShotSE() { }

	[Token(Token = "0x6000852")]
	public PowerLevels PowerLevel() { }

	[Token(Token = "0x600084A")]
	public void Reset() { }

	[Token(Token = "0x600084B")]
	public void SetGameRoot(Transform gmr) { }

	[Token(Token = "0x6000854")]
	public bool SetPower(int npower) { }

	[Token(Token = "0x6000849")]
	public void Terminate() { }

}

