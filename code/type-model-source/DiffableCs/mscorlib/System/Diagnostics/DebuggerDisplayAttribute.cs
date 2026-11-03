namespace System.Diagnostics;

[AttributeUsage(4509, AllowMultiple = True)]
[ComVisible(True)]
[Token(Token = "0x200058B")]
public sealed class DebuggerDisplayAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001760")]
	private string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001761")]
	private string value; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001762")]
	private string type; //Field offset: 0x20

	[Token(Token = "0x17000601")]
	public string Name
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60028EB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000602")]
	public string Type
	{
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60028EC")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1FC1740", Offset = "0x1FC0B40", Length = "0x9F")]
	[Token(Token = "0x60028EA")]
	public DebuggerDisplayAttribute(string value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60028EB")]
	public void set_Name(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60028EC")]
	public void set_Type(string value) { }

}

