namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000025")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct LinkInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E3")]
	public int hashCode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000E4")]
	public int linkIdFirstCharacterIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000E5")]
	public int linkIdLength; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000E6")]
	public int linkTextfirstCharacterIndex; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000E7")]
	public int linkTextLength; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Char[] linkId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E9")]
	private string m_LinkIdString; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000EA")]
	private string m_LinkTextString; //Field offset: 0x28

	[Address(RVA = "0x3181980", Offset = "0x3180D80", Length = "0x4D")]
	[Token(Token = "0x600006C")]
	public string GetLinkId() { }

	[Address(RVA = "0x31819D0", Offset = "0x3180DD0", Length = "0xF8")]
	[Token(Token = "0x600006B")]
	public string GetLinkText(TextInfo textInfo) { }

	[Address(RVA = "0x3181AD0", Offset = "0x3180ED0", Length = "0xFB")]
	[Token(Token = "0x600006A")]
	internal void SetLinkId(Char[] text, int startIndex, int length) { }

}

