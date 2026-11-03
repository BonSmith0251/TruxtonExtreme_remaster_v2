namespace InGame.Kernel.Timeline;

[Flags]
[Token(Token = "0x20000DD")]
public enum EnemyAttribute : int
{
	None = 0,
	RotateSmooth = 1,
	EventStack = 16,
	BossEvent = 32,
	InAreaStart = 512,
	SkipRestartCheck = 1024,
}

