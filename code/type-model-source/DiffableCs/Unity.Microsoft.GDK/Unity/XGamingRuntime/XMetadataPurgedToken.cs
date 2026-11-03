namespace Unity.XGamingRuntime;

[Token(Token = "0x20000F8")]
public class XMetadataPurgedToken
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C7")]
	private XMetadataPurgedToken <interop>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700001E")]
	internal XMetadataPurgedToken interop
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600059F")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60005A0")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700001F")]
	public bool IsValid
	{
		[Address(RVA = "0x2B7CF70", Offset = "0x2B7C370", Length = "0x44")]
		[Token(Token = "0x60005A2")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000020")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x60005A3")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x60005A4")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B7CEE0", Offset = "0x2B7C2E0", Length = "0x87")]
	[Token(Token = "0x60005A1")]
	internal XMetadataPurgedToken(XAppCaptureMetadataPurgedCallback callback, IntPtr context) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600059F")]
	internal XMetadataPurgedToken get_interop() { }

	[Address(RVA = "0x2B7CF70", Offset = "0x2B7C370", Length = "0x44")]
	[Token(Token = "0x60005A2")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x60005A3")]
	public ulong get_Token() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60005A0")]
	private void set_interop(XMetadataPurgedToken value) { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x60005A4")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B7CEC0", Offset = "0x2B7C2C0", Length = "0x1E")]
	[Token(Token = "0x60005A5")]
	public bool Unregister(bool wait) { }

}

