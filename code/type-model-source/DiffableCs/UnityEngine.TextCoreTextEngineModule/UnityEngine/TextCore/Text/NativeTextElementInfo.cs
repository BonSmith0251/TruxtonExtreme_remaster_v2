namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextElementInfo.h")]
[Token(Token = "0x200002B")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEngine.IMGUIModule"})]
internal struct NativeTextElementInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000102")]
	public int glyphID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000103")]
	public TextCoreVertex bottomLeft; //Field offset: 0x4
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000104")]
	public TextCoreVertex topLeft; //Field offset: 0x24
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000105")]
	public TextCoreVertex topRight; //Field offset: 0x44
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000106")]
	public TextCoreVertex bottomRight; //Field offset: 0x64

}

