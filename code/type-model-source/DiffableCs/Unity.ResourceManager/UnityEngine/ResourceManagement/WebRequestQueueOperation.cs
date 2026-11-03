namespace UnityEngine.ResourceManagement;

[Token(Token = "0x2000012")]
public class WebRequestQueueOperation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004A")]
	private bool m_Completed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004B")]
	public UnityWebRequestAsyncOperation Result; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004C")]
	public Action<UnityWebRequestAsyncOperation> OnComplete; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400004D")]
	internal UnityWebRequest m_WebRequest; //Field offset: 0x28

	[Token(Token = "0x17000017")]
	public bool IsDone
	{
		[Address(RVA = "0x2E51970", Offset = "0x2E50D70", Length = "0x12")]
		[Token(Token = "0x600009B")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000018")]
	public internal UnityWebRequest WebRequest
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600009C")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x600009D")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0xAFFCD0", Offset = "0xAFF0D0", Length = "0x31")]
	[Token(Token = "0x600009E")]
	public WebRequestQueueOperation(UnityWebRequest request) { }

	[Address(RVA = "0x2E51920", Offset = "0x2E50D20", Length = "0x41")]
	[Token(Token = "0x600009F")]
	internal void Complete(UnityWebRequestAsyncOperation asyncOp) { }

	[Address(RVA = "0x2E51970", Offset = "0x2E50D70", Length = "0x12")]
	[Token(Token = "0x600009B")]
	public bool get_IsDone() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600009C")]
	public UnityWebRequest get_WebRequest() { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x600009D")]
	internal void set_WebRequest(UnityWebRequest value) { }

}

