namespace KANAI.Network;

[Token(Token = "0x2000012")]
public class JsonRequest
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000059")]
	public string jsonrpc; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005A")]
	public string method; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005B")]
	public T[] params; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005C")]
	public string id; //Field offset: 0x0

	[Address(RVA = "0xAC92A0", Offset = "0xAC86A0", Length = "0x19B")]
	[Token(Token = "0x6000073")]
	public JsonRequest`1() { }

	[Address(RVA = "0xAC9290", Offset = "0xAC8690", Length = "0x7")]
	[Token(Token = "0x6000074")]
	public string ToJson() { }

}

