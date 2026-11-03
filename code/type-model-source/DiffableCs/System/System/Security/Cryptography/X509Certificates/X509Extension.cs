namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200013E")]
public class X509Extension : AsnEncodedData
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005BD")]
	private bool _critical; //Field offset: 0x20

	[Token(Token = "0x17000171")]
	public bool Critical
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x60007DD")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x60007DE")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60007DB")]
	protected X509Extension() { }

	[Address(RVA = "0x2658F80", Offset = "0x2658380", Length = "0x28")]
	[Token(Token = "0x60007DC")]
	public X509Extension(string oid, Byte[] rawData, bool critical) { }

	[Address(RVA = "0x2658D60", Offset = "0x2658160", Length = "0x11A")]
	[Token(Token = "0x60007DF")]
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	[Address(RVA = "0x2658E80", Offset = "0x2658280", Length = "0xF7")]
	[Token(Token = "0x60007E0")]
	internal string FormatUnkownData(Byte[] data) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x60007DD")]
	public bool get_Critical() { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x60007DE")]
	public void set_Critical(bool value) { }

}

