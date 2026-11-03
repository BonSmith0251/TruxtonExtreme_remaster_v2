namespace Unity.XGamingRuntime;

[Token(Token = "0x2000211")]
public class XGameProtocolActivationToken
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000589")]
	private XGameProtocolActivationToken <interop>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170001F6")]
	internal XGameProtocolActivationToken interop
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AE0")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000AE1")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001F8")]
	public bool IsValid
	{
		[Address(RVA = "0x2B80E20", Offset = "0x2B80220", Length = "0x44")]
		[Token(Token = "0x6000AE5")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170001F7")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000AE3")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000AE4")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B80D90", Offset = "0x2B80190", Length = "0x87")]
	[Token(Token = "0x6000AE2")]
	internal XGameProtocolActivationToken(XGameProtocolActivationCallback callback, IntPtr context) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AE0")]
	internal XGameProtocolActivationToken get_interop() { }

	[Address(RVA = "0x2B80E20", Offset = "0x2B80220", Length = "0x44")]
	[Token(Token = "0x6000AE5")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000AE3")]
	public ulong get_Token() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000AE1")]
	private void set_interop(XGameProtocolActivationToken value) { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000AE4")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B80D70", Offset = "0x2B80170", Length = "0x1E")]
	[Token(Token = "0x6000AE6")]
	public bool Unregister(bool wait) { }

}

