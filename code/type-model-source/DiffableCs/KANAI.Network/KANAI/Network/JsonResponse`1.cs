namespace KANAI.Network;

[Token(Token = "0x2000017")]
public class JsonResponse
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000068")]
	public string jsonrpc; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000069")]
	public T result; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006A")]
	public JsonErrorResponse error; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006B")]
	public string id; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600007F")]
	public JsonResponse`1() { }

	[Address(RVA = "0xAC9440", Offset = "0xAC8840", Length = "0x37")]
	[Token(Token = "0x600007B")]
	public int GetErrorCode() { }

	[Address(RVA = "0xAC9480", Offset = "0xAC8880", Length = "0xAC")]
	[Token(Token = "0x600007C")]
	public T GetReply() { }

	[Address(RVA = "0xAC9530", Offset = "0xAC8930", Length = "0x80")]
	[Token(Token = "0x600007E")]
	public Dialog GetServerErrorDialog() { }

	[Address(RVA = "0xAC95C0", Offset = "0xAC89C0", Length = "0x3B")]
	[Token(Token = "0x600007A")]
	public bool IsSuccess() { }

	[Address(RVA = "0xAC9600", Offset = "0xAC8A00", Length = "0x141")]
	[Token(Token = "0x600007D")]
	public void SetError(int code) { }

}

