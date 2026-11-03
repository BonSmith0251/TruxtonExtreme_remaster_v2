namespace Unity.XGamingRuntime;

[Token(Token = "0x2000282")]
public class XSystemHandleCallbackHandle
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006D0")]
	internal XSystemHandleCallbackHandle interop; //Field offset: 0x10

	[Token(Token = "0x170002DE")]
	public bool IsValid
	{
		[Address(RVA = "0x2B83A10", Offset = "0x2B82E10", Length = "0x44")]
		[Token(Token = "0x6000D46")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170002DF")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000D47")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000D48")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B83980", Offset = "0x2B82D80", Length = "0x87")]
	[Token(Token = "0x6000D45")]
	internal XSystemHandleCallbackHandle(XSystemHandleCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B83910", Offset = "0x2B82D10", Length = "0x44")]
	[Token(Token = "0x6000D4A")]
	public void Dispose() { }

	[Address(RVA = "0x2B83A10", Offset = "0x2B82E10", Length = "0x44")]
	[Token(Token = "0x6000D46")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000D47")]
	public ulong get_Token() { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000D48")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B83960", Offset = "0x2B82D60", Length = "0x1D")]
	[Token(Token = "0x6000D49")]
	public void Unregister() { }

}

