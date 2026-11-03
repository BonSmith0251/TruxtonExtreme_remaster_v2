namespace UnityEngine.TextCore.LowLevel;

[DebuggerDisplay("{familyName} - {styleName}")]
[Token(Token = "0x200000C")]
[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
internal struct FontReference
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006B")]
	public string familyName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400006C")]
	public string styleName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400006D")]
	public int faceIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400006E")]
	public string filePath; //Field offset: 0x18

}

