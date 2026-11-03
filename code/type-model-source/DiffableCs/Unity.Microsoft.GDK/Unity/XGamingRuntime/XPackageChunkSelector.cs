namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200024C")]
public class XPackageChunkSelector
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000654")]
	internal XPackageChunkSelectorInterop interop; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000655")]
	internal string _languageOrTagOrFeature; //Field offset: 0x20

	[Token(Token = "0x1700024B")]
	public uint ChunkId
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000BCD")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6000BCE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700024A")]
	public string LanguageTagOrFeature
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000BCB")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000BCC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000249")]
	public XPackageChunkSelectorType Type
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000BC9")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000BCA")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B81E30", Offset = "0x2B81230", Length = "0x78")]
	[Token(Token = "0x6000BC7")]
	internal XPackageChunkSelector(XPackageChunkSelectorInterop interop) { }

	[Address(RVA = "0x2B6E870", Offset = "0x2B6DC70", Length = "0x1D")]
	[Token(Token = "0x6000BC8")]
	public XPackageChunkSelector() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000BCD")]
	public uint get_ChunkId() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000BCB")]
	public string get_LanguageTagOrFeature() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000BC9")]
	public XPackageChunkSelectorType get_Type() { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6000BCE")]
	public void set_ChunkId(uint value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000BCC")]
	public void set_LanguageTagOrFeature(string value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000BCA")]
	public void set_Type(XPackageChunkSelectorType value) { }

}

