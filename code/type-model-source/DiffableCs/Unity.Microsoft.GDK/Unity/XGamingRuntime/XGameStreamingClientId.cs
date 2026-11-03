namespace Unity.XGamingRuntime;

[Token(Token = "0x2000223")]
public class XGameStreamingClientId
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F2")]
	internal XGameStreamingClientId data; //Field offset: 0x10

	[Token(Token = "0x17000206")]
	public ulong Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000B13")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x6000B14")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x2B7F420", Offset = "0x2B7E820", Length = "0x26")]
	[Token(Token = "0x6000B11")]
	public XGameStreamingClientId(ulong value) { }

	[Address(RVA = "0xD69A70", Offset = "0xD68E70", Length = "0x26")]
	[Token(Token = "0x6000B12")]
	internal XGameStreamingClientId(XGameStreamingClientId interop) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000B13")]
	public ulong get_Value() { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x6000B14")]
	public void set_Value(ulong value) { }

}

