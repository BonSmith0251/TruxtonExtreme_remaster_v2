namespace Unity.XGamingRuntime;

[Token(Token = "0x2000245")]
public class XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000642")]
	internal XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken interop; //Field offset: 0x10

	[Token(Token = "0x17000245")]
	public bool IsValid
	{
		[Address(RVA = "0x2B818A0", Offset = "0x2B80CA0", Length = "0x44")]
		[Token(Token = "0x6000BBC")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000246")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000BBD")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000BBE")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B81810", Offset = "0x2B80C10", Length = "0x87")]
	[Token(Token = "0x6000BBB")]
	internal XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken(XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B817A0", Offset = "0x2B80BA0", Length = "0x44")]
	[Token(Token = "0x6000BC0")]
	public void Dispose() { }

	[Address(RVA = "0x2B818A0", Offset = "0x2B80CA0", Length = "0x44")]
	[Token(Token = "0x6000BBC")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000BBD")]
	public ulong get_Token() { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000BBE")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B817F0", Offset = "0x2B80BF0", Length = "0x1E")]
	[Token(Token = "0x6000BBF")]
	public bool Unregister(bool wait) { }

}

