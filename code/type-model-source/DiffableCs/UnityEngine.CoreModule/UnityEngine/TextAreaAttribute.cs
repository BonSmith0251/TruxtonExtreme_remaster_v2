namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
[Token(Token = "0x2000170")]
public sealed class TextAreaAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000606")]
	public readonly int minLines; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000607")]
	public readonly int maxLines; //Field offset: 0x1C

	[Address(RVA = "0x30728F0", Offset = "0x3071CF0", Length = "0x38")]
	[Token(Token = "0x6001207")]
	public TextAreaAttribute(int minLines, int maxLines) { }

}

