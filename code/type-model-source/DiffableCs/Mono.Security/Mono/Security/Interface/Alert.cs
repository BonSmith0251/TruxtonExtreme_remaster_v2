namespace Mono.Security.Interface;

[Token(Token = "0x200003A")]
public class Alert
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000CF")]
	private AlertLevel level; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40000D0")]
	private AlertDescription description; //Field offset: 0x11

	[Token(Token = "0x1700005F")]
	public AlertDescription Description
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[Token(Token = "0x6000140")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005E")]
	public AlertLevel Level
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x600013F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1E45E30", Offset = "0x1E45230", Length = "0x84")]
	[Token(Token = "0x6000141")]
	public Alert(AlertDescription description) { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[Token(Token = "0x6000140")]
	public AlertDescription get_Description() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x600013F")]
	public AlertLevel get_Level() { }

	[Address(RVA = "0x1E45ED0", Offset = "0x1E452D0", Length = "0x5C")]
	[Token(Token = "0x6000142")]
	private void inferAlertLevel() { }

	[Address(RVA = "0x1E45D90", Offset = "0x1E45190", Length = "0x96")]
	[Token(Token = "0x6000143")]
	public virtual string ToString() { }

}

