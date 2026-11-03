namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000299")]
public class XUserLocalId
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400071C")]
	internal XUserLocalId interop; //Field offset: 0x10

	[Obsolete("Please use Value instead, (UnityUpgradable) -> Value", True)]
	[Token(Token = "0x170002EB")]
	public ulong value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D79")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x6000D7A")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170002EA")]
	public ulong Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D77")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x6000D78")]
		 set { } //Length: 5
	}

	[Address(RVA = "0xD69A70", Offset = "0xD68E70", Length = "0x26")]
	[Token(Token = "0x6000D75")]
	internal XUserLocalId(XUserLocalId interop) { }

	[Address(RVA = "0x2B7F400", Offset = "0x2B7E800", Length = "0x1C")]
	[Token(Token = "0x6000D76")]
	public XUserLocalId() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000D79")]
	public ulong get_value() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000D77")]
	public ulong get_Value() { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x6000D7A")]
	public void set_value(ulong value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x6000D78")]
	public void set_Value(ulong value) { }

}

