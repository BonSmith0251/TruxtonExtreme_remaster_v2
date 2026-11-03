namespace Unity.XGamingRuntime;

[Token(Token = "0x2000229")]
public class XGameStreamingConnectionStateChangedToken
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005FB")]
	private XGameStreamingConnectionStateChangedToken <interop>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700021D")]
	internal XGameStreamingConnectionStateChangedToken interop
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B49")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000B4A")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700021E")]
	public bool IsValid
	{
		[Address(RVA = "0x2B812B0", Offset = "0x2B806B0", Length = "0x44")]
		[Token(Token = "0x6000B4C")]
		 get { } //Length: 68
	}

	[Token(Token = "0x1700021F")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000B4D")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000B4E")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B81220", Offset = "0x2B80620", Length = "0x87")]
	[Token(Token = "0x6000B4B")]
	internal XGameStreamingConnectionStateChangedToken(XGameStreamingConnectionStateChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B49")]
	internal XGameStreamingConnectionStateChangedToken get_interop() { }

	[Address(RVA = "0x2B812B0", Offset = "0x2B806B0", Length = "0x44")]
	[Token(Token = "0x6000B4C")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000B4D")]
	public ulong get_Token() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000B4A")]
	private void set_interop(XGameStreamingConnectionStateChangedToken value) { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000B4E")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B81200", Offset = "0x2B80600", Length = "0x1E")]
	[Token(Token = "0x6000B4F")]
	public bool Unregister(bool wait) { }

}

