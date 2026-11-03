namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000269")]
public class XStoreVideo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400067F")]
	internal XStoreVideo _interop; //Field offset: 0x10
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000680")]
	internal XStoreImage _previewImage; //Field offset: 0x50

	[Token(Token = "0x1700029B")]
	public string Caption
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000CA8")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000CA9")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000299")]
	public uint Height
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000CA4")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6000CA5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000297")]
	internal XStoreVideo interop
	{
		[Address(RVA = "0x2B836A0", Offset = "0x2B82AA0", Length = "0x66")]
		[Token(Token = "0x6000CA0")]
		internal get { } //Length: 102
		[Address(RVA = "0x2B83760", Offset = "0x2B82B60", Length = "0x2A")]
		[Token(Token = "0x6000CA1")]
		internal set { } //Length: 42
	}

	[Token(Token = "0x1700029D")]
	public XStoreImage PreviewImage
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000CAC")]
		 get { } //Length: 5
		[Address(RVA = "0x2B83710", Offset = "0x2B82B10", Length = "0x4F")]
		[Token(Token = "0x6000CAD")]
		 set { } //Length: 79
	}

	[Token(Token = "0x17000298")]
	public string Uri
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000CA2")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000CA3")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700029C")]
	public string VideoPurposeTag
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000CAA")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000CAB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700029A")]
	public uint Width
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000CA6")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x6000CA7")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B83540", Offset = "0x2B82940", Length = "0xC2")]
	[Token(Token = "0x6000C9E")]
	internal XStoreVideo(XStoreVideo interop) { }

	[Address(RVA = "0x2B83610", Offset = "0x2B82A10", Length = "0x84")]
	[Token(Token = "0x6000C9F")]
	public XStoreVideo() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000CA8")]
	public string get_Caption() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000CA4")]
	public uint get_Height() { }

	[Address(RVA = "0x2B836A0", Offset = "0x2B82AA0", Length = "0x66")]
	[Token(Token = "0x6000CA0")]
	internal XStoreVideo get_interop() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000CAC")]
	public XStoreImage get_PreviewImage() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000CA2")]
	public string get_Uri() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000CAA")]
	public string get_VideoPurposeTag() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000CA6")]
	public uint get_Width() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000CA9")]
	public void set_Caption(string value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6000CA5")]
	public void set_Height(uint value) { }

	[Address(RVA = "0x2B83760", Offset = "0x2B82B60", Length = "0x2A")]
	[Token(Token = "0x6000CA1")]
	internal void set_interop(XStoreVideo value) { }

	[Address(RVA = "0x2B83710", Offset = "0x2B82B10", Length = "0x4F")]
	[Token(Token = "0x6000CAD")]
	public void set_PreviewImage(XStoreImage value) { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000CA3")]
	public void set_Uri(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000CAB")]
	public void set_VideoPurposeTag(string value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x6000CA7")]
	public void set_Width(uint value) { }

}

