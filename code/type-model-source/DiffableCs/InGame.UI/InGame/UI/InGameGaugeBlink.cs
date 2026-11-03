namespace InGame.UI;

[Token(Token = "0x2000004")]
public class InGameGaugeBlink : InGameValueGauge
{
	[Token(Token = "0x4000006")]
	private static readonly Color blink0; //Field offset: 0x0
	[Token(Token = "0x4000007")]
	private static readonly Color blink1; //Field offset: 0x10

	[Address(RVA = "0x1DD1FA0", Offset = "0x1DD13A0", Length = "0x9D")]
	[Token(Token = "0x6000005")]
	private static InGameGaugeBlink() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000004")]
	public InGameGaugeBlink() { }

	[Address(RVA = "0x1DD1D80", Offset = "0x1DD1180", Length = "0x218")]
	[Token(Token = "0x6000003")]
	public virtual void Progress(float dt) { }

}

