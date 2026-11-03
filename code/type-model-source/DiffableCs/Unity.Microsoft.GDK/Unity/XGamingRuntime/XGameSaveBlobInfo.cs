namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000215")]
public class XGameSaveBlobInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005A7")]
	internal XGameSaveBlobInfo interop; //Field offset: 0x10

	[Token(Token = "0x170001F9")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000AE9")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000AEA")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170001FA")]
	public uint Size
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000AEB")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6000AEC")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B7C2C0", Offset = "0x2B7B6C0", Length = "0x33")]
	[Token(Token = "0x6000AE7")]
	internal XGameSaveBlobInfo(XGameSaveBlobInfo interop) { }

	[Address(RVA = "0x2B6E870", Offset = "0x2B6DC70", Length = "0x1D")]
	[Token(Token = "0x6000AE8")]
	public XGameSaveBlobInfo() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000AE9")]
	public string get_Name() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000AEB")]
	public uint get_Size() { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000AEA")]
	public void set_Name(string value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6000AEC")]
	public void set_Size(uint value) { }

}

