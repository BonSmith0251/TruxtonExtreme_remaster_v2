namespace Unity.XGamingRuntime;

[Token(Token = "0x2000224")]
public class D3D12XBOX_FRAME_PIPELINE_TOKEN
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F3")]
	internal D3D12XBOX_FRAME_PIPELINE_TOKEN data; //Field offset: 0x10

	[Token(Token = "0x17000207")]
	public ulong Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000B17")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x6000B18")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x2B7F420", Offset = "0x2B7E820", Length = "0x26")]
	[Token(Token = "0x6000B15")]
	public D3D12XBOX_FRAME_PIPELINE_TOKEN(ulong value) { }

	[Address(RVA = "0xD69A70", Offset = "0xD68E70", Length = "0x26")]
	[Token(Token = "0x6000B16")]
	internal D3D12XBOX_FRAME_PIPELINE_TOKEN(D3D12XBOX_FRAME_PIPELINE_TOKEN interop) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000B17")]
	public ulong get_Value() { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x6000B18")]
	public void set_Value(ulong value) { }

}

