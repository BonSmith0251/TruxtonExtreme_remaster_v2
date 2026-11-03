namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200027E")]
public class XVersion
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006CA")]
	internal XVersion interop; //Field offset: 0x10

	[Token(Token = "0x170002D5")]
	public ushort Build
	{
		[Address(RVA = "0x1963870", Offset = "0x1962C70", Length = "0x5")]
		[Token(Token = "0x6000D2B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6E8D0", Offset = "0x2B6DCD0", Length = "0x5")]
		[Token(Token = "0x6000D2C")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170002D3")]
	public ushort Major
	{
		[Address(RVA = "0x111BFC0", Offset = "0x111B3C0", Length = "0x5")]
		[Token(Token = "0x6000D27")]
		 get { } //Length: 5
		[Address(RVA = "0x1E51EE0", Offset = "0x1E512E0", Length = "0x5")]
		[Token(Token = "0x6000D28")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170002D4")]
	public ushort Minor
	{
		[Address(RVA = "0x2B6E8B0", Offset = "0x2B6DCB0", Length = "0x5")]
		[Token(Token = "0x6000D29")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6E910", Offset = "0x2B6DD10", Length = "0x5")]
		[Token(Token = "0x6000D2A")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170002D6")]
	public ushort Revision
	{
		[Address(RVA = "0x29EA640", Offset = "0x29E9A40", Length = "0x5")]
		[Token(Token = "0x6000D2D")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6E8E0", Offset = "0x2B6DCE0", Length = "0x5")]
		[Token(Token = "0x6000D2E")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170002D7")]
	public ulong Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D2F")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x6000D30")]
		 set { } //Length: 5
	}

	[Address(RVA = "0xD69A70", Offset = "0xD68E70", Length = "0x26")]
	[Token(Token = "0x6000D25")]
	internal XVersion(XVersion interop) { }

	[Address(RVA = "0x2B7F400", Offset = "0x2B7E800", Length = "0x1C")]
	[Token(Token = "0x6000D26")]
	public XVersion() { }

	[Address(RVA = "0x1963870", Offset = "0x1962C70", Length = "0x5")]
	[Token(Token = "0x6000D2B")]
	public ushort get_Build() { }

	[Address(RVA = "0x111BFC0", Offset = "0x111B3C0", Length = "0x5")]
	[Token(Token = "0x6000D27")]
	public ushort get_Major() { }

	[Address(RVA = "0x2B6E8B0", Offset = "0x2B6DCB0", Length = "0x5")]
	[Token(Token = "0x6000D29")]
	public ushort get_Minor() { }

	[Address(RVA = "0x29EA640", Offset = "0x29E9A40", Length = "0x5")]
	[Token(Token = "0x6000D2D")]
	public ushort get_Revision() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000D2F")]
	public ulong get_Value() { }

	[Address(RVA = "0x2B6E8D0", Offset = "0x2B6DCD0", Length = "0x5")]
	[Token(Token = "0x6000D2C")]
	public void set_Build(ushort value) { }

	[Address(RVA = "0x1E51EE0", Offset = "0x1E512E0", Length = "0x5")]
	[Token(Token = "0x6000D28")]
	public void set_Major(ushort value) { }

	[Address(RVA = "0x2B6E910", Offset = "0x2B6DD10", Length = "0x5")]
	[Token(Token = "0x6000D2A")]
	public void set_Minor(ushort value) { }

	[Address(RVA = "0x2B6E8E0", Offset = "0x2B6DCE0", Length = "0x5")]
	[Token(Token = "0x6000D2E")]
	public void set_Revision(ushort value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x6000D30")]
	public void set_Value(ulong value) { }

}

