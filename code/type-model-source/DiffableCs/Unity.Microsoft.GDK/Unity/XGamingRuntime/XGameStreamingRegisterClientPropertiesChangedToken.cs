namespace Unity.XGamingRuntime;

[Token(Token = "0x200022A")]
public class XGameStreamingRegisterClientPropertiesChangedToken
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005FC")]
	private XGameStreamingRegisterClientPropertiesChangedToken <interop>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000220")]
	internal XGameStreamingRegisterClientPropertiesChangedToken interop
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B50")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000B51")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000221")]
	public bool IsValid
	{
		[Address(RVA = "0x2B81540", Offset = "0x2B80940", Length = "0x44")]
		[Token(Token = "0x6000B53")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000222")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000B54")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000B55")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B81490", Offset = "0x2B80890", Length = "0xAD")]
	[Token(Token = "0x6000B52")]
	internal XGameStreamingRegisterClientPropertiesChangedToken(XGameStreamingClientId clientId, XGameStreamingClientPropertiesChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B50")]
	internal XGameStreamingRegisterClientPropertiesChangedToken get_interop() { }

	[Address(RVA = "0x2B81540", Offset = "0x2B80940", Length = "0x44")]
	[Token(Token = "0x6000B53")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000B54")]
	public ulong get_Token() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000B51")]
	private void set_interop(XGameStreamingRegisterClientPropertiesChangedToken value) { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000B55")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B81460", Offset = "0x2B80860", Length = "0x27")]
	[Token(Token = "0x6000B56")]
	public bool Unregister(XGameStreamingClientId clientId, bool wait) { }

}

