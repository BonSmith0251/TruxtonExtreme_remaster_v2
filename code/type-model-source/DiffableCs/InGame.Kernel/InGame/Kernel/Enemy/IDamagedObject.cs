namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000217")]
public interface IDamagedObject
{

	[Token(Token = "0x6000FC2")]
	public int GetDamageScore() { }

	[Token(Token = "0x6000FC3")]
	public int GetDeathScore() { }

	[Token(Token = "0x6000FBF")]
	public toleType GetTolerance(attackType at) { }

	[Token(Token = "0x6000FC0")]
	public void HitBlink(attackType at) { }

	[Token(Token = "0x6000FBA")]
	public bool IsAlive() { }

	[Token(Token = "0x6000FBC")]
	public bool IsAliveDamaged(float tdamage) { }

	[Token(Token = "0x6000FBD")]
	public bool IsBombered() { }

	[Token(Token = "0x6000FBB")]
	public bool IsNoDamaged() { }

	[Token(Token = "0x6000FBE")]
	public void SetBombered() { }

	[Token(Token = "0x6000FC1")]
	public void SetCauseOfDeath(int pno, attackType at, bool isExboost) { }

}

