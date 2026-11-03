namespace TXEKernel;

[Token(Token = "0x2000086")]
public class UnlockedDateTime : RecordDateTime
{
	[Token(Token = "0x2000087")]
	internal class UnlockedDateTimeParams : DateTimeParams
	{

		[Address(RVA = "0x2707A20", Offset = "0x2706E20", Length = "0x8")]
		[Token(Token = "0x60004A9")]
		public UnlockedDateTimeParams(string label) { }

	}


	[Address(RVA = "0x26F66A0", Offset = "0x26F5AA0", Length = "0x48")]
	[Token(Token = "0x60004A3")]
	public UnlockedDateTime(UnlockedDateTimeParams p) { }

	[Address(RVA = "0x2707A50", Offset = "0x2706E50", Length = "0x8B")]
	[Token(Token = "0x60004A4")]
	public UnlockedDateTime(string label) { }

	[Address(RVA = "0x2707A30", Offset = "0x2706E30", Length = "0x7")]
	[Token(Token = "0x60004A5")]
	public bool IsUnlocked() { }

	[Address(RVA = "0x26F64D0", Offset = "0x26F58D0", Length = "0xB0")]
	[Token(Token = "0x60004A8")]
	public void Lock() { }

	[Address(RVA = "0x2707A40", Offset = "0x2706E40", Length = "0x7")]
	[Token(Token = "0x60004A6")]
	public void Unlock() { }

	[Address(RVA = "0x26F6630", Offset = "0x26F5A30", Length = "0x6B")]
	[Token(Token = "0x60004A7")]
	public void Unlock(DateTime dateTime) { }

}

