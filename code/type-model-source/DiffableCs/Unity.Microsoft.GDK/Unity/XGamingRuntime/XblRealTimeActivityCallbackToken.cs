namespace Unity.XGamingRuntime;

[Token(Token = "0x20001CD")]
public struct XblRealTimeActivityCallbackToken
{
	[Token(Token = "0x40004CD")]
	public const int InvalidHandlerId = 0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004CE")]
	public int InteropHandlerId; //Field offset: 0x0

	[Address(RVA = "0x2B8B030", Offset = "0x2B8A430", Length = "0x7")]
	[Token(Token = "0x60009AE")]
	public bool IsValid() { }

	[Address(RVA = "0x2B8B020", Offset = "0x2B8A420", Length = "0x6")]
	[Token(Token = "0x60009AF")]
	public static bool IsValid(int interopHandlerId) { }

	[Address(RVA = "0x1CA23C0", Offset = "0x1CA17C0", Length = "0x7")]
	[Token(Token = "0x60009AD")]
	public void Reset() { }

}

