namespace Unity.XGamingRuntime;

[Token(Token = "0x200028A")]
public class XTaskQueueCallbackHandle
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006DB")]
	internal XTaskQueueCallbackHandle interop; //Field offset: 0x10

	[Token(Token = "0x170002E4")]
	public bool IsValid
	{
		[Address(RVA = "0x2B83E20", Offset = "0x2B83220", Length = "0x44")]
		[Token(Token = "0x6000D66")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170002E5")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000D67")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000D68")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B83D90", Offset = "0x2B83190", Length = "0x87")]
	[Token(Token = "0x6000D65")]
	internal XTaskQueueCallbackHandle(XTaskQueueCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B83D40", Offset = "0x2B83140", Length = "0x44")]
	[Token(Token = "0x6000D69")]
	public void Dispose() { }

	[Address(RVA = "0x2B83E20", Offset = "0x2B83220", Length = "0x44")]
	[Token(Token = "0x6000D66")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000D67")]
	public ulong get_Token() { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000D68")]
	public void set_Token(ulong value) { }

}

