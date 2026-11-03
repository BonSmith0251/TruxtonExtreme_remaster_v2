namespace TXEKernel;

[Token(Token = "0x2000008")]
public class ActivityManager : SimpleSingleton<ActivityManager>
{

	[Address(RVA = "0x26D1AD0", Offset = "0x26D0ED0", Length = "0x39")]
	[Token(Token = "0x600000B")]
	public ActivityManager() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000008")]
	public void Initialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600000A")]
	public void Terminate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000009")]
	public void Update() { }

}

