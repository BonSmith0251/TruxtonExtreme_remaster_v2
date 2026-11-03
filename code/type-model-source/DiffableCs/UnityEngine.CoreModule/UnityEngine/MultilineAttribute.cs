namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
[Token(Token = "0x200016F")]
public sealed class MultilineAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000605")]
	public readonly int lines; //Field offset: 0x18

	[Address(RVA = "0x3068110", Offset = "0x3067510", Length = "0x21")]
	[Token(Token = "0x6001206")]
	public MultilineAttribute() { }

}

