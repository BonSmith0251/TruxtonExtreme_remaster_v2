namespace KANAI.DebugTools;

[Token(Token = "0x2000007")]
public class DebugStopWatch : IDisposable
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600000E")]
	public DebugStopWatch(string label) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600000F")]
	public override void Dispose() { }

}

