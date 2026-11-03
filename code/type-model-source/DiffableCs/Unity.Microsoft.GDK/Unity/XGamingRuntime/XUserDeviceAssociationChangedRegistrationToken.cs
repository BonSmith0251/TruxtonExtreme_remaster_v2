namespace Unity.XGamingRuntime;

[Token(Token = "0x20002A5")]
public class XUserDeviceAssociationChangedRegistrationToken
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000727")]
	internal XUserDeviceAssociationChangedRegistrationToken interop; //Field offset: 0x10

	[Token(Token = "0x17000300")]
	public bool IsValid
	{
		[Address(RVA = "0x2B84CD0", Offset = "0x2B840D0", Length = "0x44")]
		[Token(Token = "0x6000DC0")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000301")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000DC1")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000DC2")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B84C40", Offset = "0x2B84040", Length = "0x87")]
	[Token(Token = "0x6000DBF")]
	internal XUserDeviceAssociationChangedRegistrationToken(XUserDeviceAssociationChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B84BD0", Offset = "0x2B83FD0", Length = "0x44")]
	[Token(Token = "0x6000DC4")]
	public void Dispose() { }

	[Address(RVA = "0x2B84CD0", Offset = "0x2B840D0", Length = "0x44")]
	[Token(Token = "0x6000DC0")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000DC1")]
	public ulong get_Token() { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000DC2")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B84C20", Offset = "0x2B84020", Length = "0x1E")]
	[Token(Token = "0x6000DC3")]
	public bool Unregister(bool wait) { }

}

