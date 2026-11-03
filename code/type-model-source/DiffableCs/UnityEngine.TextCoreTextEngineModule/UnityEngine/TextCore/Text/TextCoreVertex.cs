namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextCoreVertex.h")]
[Token(Token = "0x2000042")]
[UsedByNativeCode("TextCoreVertex")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct TextCoreVertex
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C5")]
	public Vector3 position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001C6")]
	public Color32 color; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C7")]
	public Vector2 uv0; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C8")]
	public Vector2 uv2; //Field offset: 0x18

}

