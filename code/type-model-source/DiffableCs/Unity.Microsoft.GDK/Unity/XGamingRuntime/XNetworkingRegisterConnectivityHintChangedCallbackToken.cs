namespace Unity.XGamingRuntime;

[Token(Token = "0x2000244")]
public class XNetworkingRegisterConnectivityHintChangedCallbackToken
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000641")]
	internal XNetworkingRegisterConnectivityHintChangedCallbackToken interop; //Field offset: 0x10

	[Token(Token = "0x17000243")]
	public bool IsValid
	{
		[Address(RVA = "0x2B81B20", Offset = "0x2B80F20", Length = "0x44")]
		[Token(Token = "0x6000BB6")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000244")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000BB7")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000BB8")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B81A90", Offset = "0x2B80E90", Length = "0x87")]
	[Token(Token = "0x6000BB5")]
	internal XNetworkingRegisterConnectivityHintChangedCallbackToken(XNetworkingConnectivityHintChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B81A20", Offset = "0x2B80E20", Length = "0x44")]
	[Token(Token = "0x6000BBA")]
	public void Dispose() { }

	[Address(RVA = "0x2B81B20", Offset = "0x2B80F20", Length = "0x44")]
	[Token(Token = "0x6000BB6")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000BB7")]
	public ulong get_Token() { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000BB8")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B81A70", Offset = "0x2B80E70", Length = "0x1E")]
	[Token(Token = "0x6000BB9")]
	public bool Unregister(bool wait) { }

}

