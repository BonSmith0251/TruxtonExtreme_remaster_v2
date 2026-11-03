namespace Unity.XGamingRuntime;

[Token(Token = "0x20002A3")]
public class XUserChangeRegistrationToken
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000725")]
	internal XUserChangeRegistrationToken interop; //Field offset: 0x10

	[Token(Token = "0x170002FC")]
	public bool IsValid
	{
		[Address(RVA = "0x2B84650", Offset = "0x2B83A50", Length = "0x44")]
		[Token(Token = "0x6000DB4")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170002FD")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000DB5")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000DB6")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B845C0", Offset = "0x2B839C0", Length = "0x87")]
	[Token(Token = "0x6000DB3")]
	internal XUserChangeRegistrationToken(XUserChangeEventCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B84550", Offset = "0x2B83950", Length = "0x44")]
	[Token(Token = "0x6000DB8")]
	public void Dispose() { }

	[Address(RVA = "0x2B84650", Offset = "0x2B83A50", Length = "0x44")]
	[Token(Token = "0x6000DB4")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000DB5")]
	public ulong get_Token() { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000DB6")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B845A0", Offset = "0x2B839A0", Length = "0x1E")]
	[Token(Token = "0x6000DB7")]
	public bool Unregister(bool wait) { }

}

