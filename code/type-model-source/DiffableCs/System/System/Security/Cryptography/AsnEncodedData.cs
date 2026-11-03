namespace System.Security.Cryptography;

[Token(Token = "0x200011C")]
public class AsnEncodedData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000504")]
	internal Oid _oid; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000505")]
	internal Byte[] _raw; //Field offset: 0x18

	[Token(Token = "0x17000115")]
	public Oid Oid
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60006CF")]
		 get { } //Length: 5
		[Address(RVA = "0x262C4C0", Offset = "0x262B8C0", Length = "0xA5")]
		[Token(Token = "0x60006D0")]
		 set { } //Length: 165
	}

	[Token(Token = "0x17000116")]
	public Byte[] RawData
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60006D1")]
		 get { } //Length: 5
		[Address(RVA = "0x262C570", Offset = "0x262B970", Length = "0xFC")]
		[Token(Token = "0x60006D2")]
		 set { } //Length: 252
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60006CB")]
	protected AsnEncodedData() { }

	[Address(RVA = "0x262C2C0", Offset = "0x262B6C0", Length = "0xED")]
	[Token(Token = "0x60006CC")]
	public AsnEncodedData(string oid, Byte[] rawData) { }

	[Address(RVA = "0x262C200", Offset = "0x262B600", Length = "0xBF")]
	[Token(Token = "0x60006CD")]
	public AsnEncodedData(Oid oid, Byte[] rawData) { }

	[Address(RVA = "0x262C3B0", Offset = "0x262B7B0", Length = "0x10E")]
	[Token(Token = "0x60006CE")]
	public AsnEncodedData(AsnEncodedData asnEncodedData) { }

	[Address(RVA = "0x262B470", Offset = "0x262A870", Length = "0x9A")]
	[Token(Token = "0x60006D7")]
	internal string BasicConstraintsExtension(bool multiLine) { }

	[Address(RVA = "0x262B510", Offset = "0x262A910", Length = "0x135")]
	[Token(Token = "0x60006D3")]
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	[Address(RVA = "0x262B650", Offset = "0x262AA50", Length = "0x120")]
	[Token(Token = "0x60006D6")]
	internal string Default(bool multiLine) { }

	[Address(RVA = "0x262B780", Offset = "0x262AB80", Length = "0x9A")]
	[Token(Token = "0x60006D8")]
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	[Address(RVA = "0x262B820", Offset = "0x262AC20", Length = "0x3C")]
	[Token(Token = "0x60006D4")]
	public override string Format(bool multiLine) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60006CF")]
	public Oid get_Oid() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60006D1")]
	public Byte[] get_RawData() { }

	[Address(RVA = "0x262B860", Offset = "0x262AC60", Length = "0x9A")]
	[Token(Token = "0x60006D9")]
	internal string KeyUsageExtension(bool multiLine) { }

	[Address(RVA = "0x262B900", Offset = "0x262AD00", Length = "0x3B7")]
	[Token(Token = "0x60006DC")]
	internal string NetscapeCertType(bool multiLine) { }

	[Address(RVA = "0x262C4C0", Offset = "0x262B8C0", Length = "0xA5")]
	[Token(Token = "0x60006D0")]
	public void set_Oid(Oid value) { }

	[Address(RVA = "0x262C570", Offset = "0x262B970", Length = "0xFC")]
	[Token(Token = "0x60006D2")]
	public void set_RawData(Byte[] value) { }

	[Address(RVA = "0x262BCC0", Offset = "0x262B0C0", Length = "0x2C3")]
	[Token(Token = "0x60006DB")]
	internal string SubjectAltName(bool multiLine) { }

	[Address(RVA = "0x262BF90", Offset = "0x262B390", Length = "0x9A")]
	[Token(Token = "0x60006DA")]
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	[Address(RVA = "0x262C030", Offset = "0x262B430", Length = "0x1C0")]
	[Token(Token = "0x60006D5")]
	internal override string ToString(bool multiLine) { }

}

