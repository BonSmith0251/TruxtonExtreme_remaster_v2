namespace Unity.XGamingRuntime;

[Token(Token = "0x200020F")]
public class XGameInviteRegistrationToken
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000588")]
	private XGameInviteRegistrationToken <interop>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170001F3")]
	internal XGameInviteRegistrationToken interop
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AD5")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000AD6")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001F5")]
	public bool IsValid
	{
		[Address(RVA = "0x2B80D20", Offset = "0x2B80120", Length = "0x44")]
		[Token(Token = "0x6000ADA")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170001F4")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000AD8")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000AD9")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B80C90", Offset = "0x2B80090", Length = "0x87")]
	[Token(Token = "0x6000AD7")]
	internal XGameInviteRegistrationToken(XGameInviteEventCallback callback, IntPtr context) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AD5")]
	internal XGameInviteRegistrationToken get_interop() { }

	[Address(RVA = "0x2B80D20", Offset = "0x2B80120", Length = "0x44")]
	[Token(Token = "0x6000ADA")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000AD8")]
	public ulong get_Token() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000AD6")]
	private void set_interop(XGameInviteRegistrationToken value) { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000AD9")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B80C70", Offset = "0x2B80070", Length = "0x1E")]
	[Token(Token = "0x6000ADB")]
	public bool Unregister(bool wait) { }

}

