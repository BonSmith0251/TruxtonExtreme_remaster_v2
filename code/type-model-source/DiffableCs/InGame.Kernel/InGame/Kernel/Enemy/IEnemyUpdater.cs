namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000218")]
public interface IEnemyUpdater
{
	[Token(Token = "0x2000219")]
	internal enum Priority : int
	{
		Fastest = 10,
		Fast = 100,
		Normal = 200,
		Late = 300,
	}


	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000FCC")]
	public void ApplyTransformFromPhysics() { }

	[Token(Token = "0x6000FC7")]
	public void Progress(float dt) { }

	[Token(Token = "0x6000FCA")]
	public void ProgressDisable() { }

	[Token(Token = "0x6000FC9")]
	public void ProgressEnd() { }

	[Token(Token = "0x6000FC4")]
	public void ProgressInitialize() { }

	[Token(Token = "0x6000FCB")]
	public int ProgressPriority() { }

	[Token(Token = "0x6000FC5")]
	public void ProgressReset() { }

	[Token(Token = "0x6000FC6")]
	public void ProgressStart() { }

	[Token(Token = "0x6000FC8")]
	public void ProgressTerminate() { }

}

