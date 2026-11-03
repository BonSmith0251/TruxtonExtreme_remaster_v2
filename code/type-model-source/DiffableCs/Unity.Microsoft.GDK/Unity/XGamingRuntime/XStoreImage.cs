namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000264")]
public class XStoreImage
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000679")]
	internal XStoreImage interop; //Field offset: 0x10

	[Token(Token = "0x1700027B")]
	public string Caption
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000C5E")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000C5F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000279")]
	public uint Height
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000C5A")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6000C5B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700027C")]
	public string ImagePurposeTag
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000C60")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000C61")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000278")]
	public string Uri
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C58")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000C59")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700027A")]
	public uint Width
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000C5C")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x6000C5D")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B82650", Offset = "0x2B81A50", Length = "0x3B")]
	[Token(Token = "0x6000C56")]
	internal XStoreImage(XStoreImage interop) { }

	[Address(RVA = "0x2B82130", Offset = "0x2B81530", Length = "0x21")]
	[Token(Token = "0x6000C57")]
	public XStoreImage() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000C5E")]
	public string get_Caption() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000C5A")]
	public uint get_Height() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000C60")]
	public string get_ImagePurposeTag() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C58")]
	public string get_Uri() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000C5C")]
	public uint get_Width() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000C5F")]
	public void set_Caption(string value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6000C5B")]
	public void set_Height(uint value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000C61")]
	public void set_ImagePurposeTag(string value) { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000C59")]
	public void set_Uri(string value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x6000C5D")]
	public void set_Width(uint value) { }

}

