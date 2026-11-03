namespace UnityEngine.Rendering;

[DefaultMember("Item")]
[Token(Token = "0x20003C5")]
public struct AttachmentIndexArray
{
	[Token(Token = "0x4000C00")]
	public static AttachmentIndexArray Emtpy; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C01")]
	private int a0; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000C02")]
	private int a1; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C03")]
	private int a2; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000C04")]
	private int a3; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C05")]
	private int a4; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C06")]
	private int a5; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C07")]
	private int a6; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000C08")]
	private int a7; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C09")]
	private int activeAttachments; //Field offset: 0x20

	[Token(Token = "0x1700040C")]
	public int Item
	{
		[Address(RVA = "0x30B9460", Offset = "0x30B8860", Length = "0x119")]
		[Token(Token = "0x6001D55")]
		 get { } //Length: 281
		[Address(RVA = "0x30B9580", Offset = "0x30B8980", Length = "0x11A")]
		[Token(Token = "0x6001D56")]
		 set { } //Length: 282
	}

	[Token(Token = "0x1700040D")]
	public int Length
	{
		[Address(RVA = "0x1073710", Offset = "0x1072B10", Length = "0x6")]
		[Token(Token = "0x6001D57")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x30B9330", Offset = "0x30B8730", Length = "0x6F")]
	[Token(Token = "0x6001D58")]
	private static AttachmentIndexArray() { }

	[Address(RVA = "0x30B93A0", Offset = "0x30B87A0", Length = "0xBD")]
	[Token(Token = "0x6001D54")]
	public AttachmentIndexArray(int numAttachments) { }

	[Address(RVA = "0x30B9460", Offset = "0x30B8860", Length = "0x119")]
	[Token(Token = "0x6001D55")]
	public int get_Item(int index) { }

	[Address(RVA = "0x1073710", Offset = "0x1072B10", Length = "0x6")]
	[Token(Token = "0x6001D57")]
	public int get_Length() { }

	[Address(RVA = "0x30B9580", Offset = "0x30B8980", Length = "0x11A")]
	[Token(Token = "0x6001D56")]
	public void set_Item(int index, int value) { }

}

