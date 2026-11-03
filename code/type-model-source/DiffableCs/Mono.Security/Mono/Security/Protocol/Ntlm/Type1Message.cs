namespace Mono.Security.Protocol.Ntlm;

[Token(Token = "0x2000035")]
public class Type1Message : MessageBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A4")]
	private string _host; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A5")]
	private string _domain; //Field offset: 0x20

	[Token(Token = "0x17000056")]
	public string Domain
	{
		[Address(RVA = "0x1E584C0", Offset = "0x1E578C0", Length = "0x79")]
		[Token(Token = "0x600012B")]
		 set { } //Length: 121
	}

	[Token(Token = "0x17000057")]
	public string Host
	{
		[Address(RVA = "0x1E58540", Offset = "0x1E57940", Length = "0x79")]
		[Token(Token = "0x600012C")]
		 set { } //Length: 121
	}

	[Address(RVA = "0x1E58430", Offset = "0x1E57830", Length = "0x86")]
	[Token(Token = "0x600012A")]
	public Type1Message() { }

	[Address(RVA = "0x1E58040", Offset = "0x1E57440", Length = "0x110")]
	[Token(Token = "0x600012D")]
	protected virtual void Decode(Byte[] message) { }

	[Address(RVA = "0x1E58160", Offset = "0x1E57560", Length = "0x2C7")]
	[Token(Token = "0x600012E")]
	public virtual Byte[] GetBytes() { }

	[Address(RVA = "0x1E584C0", Offset = "0x1E578C0", Length = "0x79")]
	[Token(Token = "0x600012B")]
	public void set_Domain(string value) { }

	[Address(RVA = "0x1E58540", Offset = "0x1E57940", Length = "0x79")]
	[Token(Token = "0x600012C")]
	public void set_Host(string value) { }

}

