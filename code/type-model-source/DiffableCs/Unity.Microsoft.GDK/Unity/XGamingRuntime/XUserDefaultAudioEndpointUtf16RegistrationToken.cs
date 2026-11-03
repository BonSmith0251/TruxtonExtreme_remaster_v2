namespace Unity.XGamingRuntime;

[Token(Token = "0x20002A4")]
public class XUserDefaultAudioEndpointUtf16RegistrationToken
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000726")]
	internal XUserDefaultAudioEndpointUtf16RegistrationToken interop; //Field offset: 0x10

	[Token(Token = "0x170002FE")]
	public bool IsValid
	{
		[Address(RVA = "0x2B84900", Offset = "0x2B83D00", Length = "0x44")]
		[Token(Token = "0x6000DBA")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170002FF")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000DBB")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000DBC")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B84870", Offset = "0x2B83C70", Length = "0x87")]
	[Token(Token = "0x6000DB9")]
	internal XUserDefaultAudioEndpointUtf16RegistrationToken(XUserDefaultAudioEndpointUtf16ChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B84800", Offset = "0x2B83C00", Length = "0x44")]
	[Token(Token = "0x6000DBE")]
	public void Dispose() { }

	[Address(RVA = "0x2B84900", Offset = "0x2B83D00", Length = "0x44")]
	[Token(Token = "0x6000DBA")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000DBB")]
	public ulong get_Token() { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000DBC")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B84850", Offset = "0x2B83C50", Length = "0x1E")]
	[Token(Token = "0x6000DBD")]
	public bool Unregister(bool wait) { }

}

