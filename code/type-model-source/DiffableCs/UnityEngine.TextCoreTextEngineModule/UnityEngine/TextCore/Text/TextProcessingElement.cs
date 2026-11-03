namespace UnityEngine.TextCore.Text;

[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
[Token(Token = "0x2000053")]
internal struct TextProcessingElement
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400032A")]
	public TextProcessingElementType elementType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400032B")]
	public uint unicode; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400032C")]
	public int stringIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400032D")]
	public int length; //Field offset: 0xC

}

