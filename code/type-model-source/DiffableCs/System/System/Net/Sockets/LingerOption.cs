namespace System.Net.Sockets;

[Token(Token = "0x2000305")]
public class LingerOption
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D76")]
	private bool enabled; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000D77")]
	private int lingerTime; //Field offset: 0x14

	[Token(Token = "0x1700045D")]
	public bool Enabled
	{
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x6001475")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700045E")]
	public int LingerTime
	{
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x6001476")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x25DEAA0", Offset = "0x25DDEA0", Length = "0x35")]
	[Token(Token = "0x6001474")]
	public LingerOption(bool enable, int seconds) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x6001475")]
	public void set_Enabled(bool value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x6001476")]
	public void set_LingerTime(int value) { }

}

