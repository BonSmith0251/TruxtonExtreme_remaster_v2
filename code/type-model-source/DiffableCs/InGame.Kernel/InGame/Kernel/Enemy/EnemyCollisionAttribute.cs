namespace InGame.Kernel.Enemy;

[Flags]
[Token(Token = "0x200015B")]
public enum EnemyCollisionAttribute : int
{
	None = 0,
	NoLockOn = 1,
	LaserBlock = 4,
	NoDamage = 16,
	NoHitBullet = 32,
	NoHitSubject = 64,
	NoClip = 128,
	OnlyHitBlue = 1024,
	OnlyHitGreen = 2048,
	OnlyHitRed = 4096,
	OnlyHitGold = 8192,
	OnlyHitSilver = 16384,
	OnlyHitBlack = 32768,
	OnlyHitBomb = 65536,
	OnlyHitBoost = 131072,
	OnlyHitPurple = 262144,
	OnlyHitMask = 523264,
	OnlyHitPlayer = 1048576,
}

