namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x200006D")]
internal class MenuCategoryAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000170")]
	public readonly string category; //Field offset: 0x10

	[Address(RVA = "0x2F411E0", Offset = "0x2F405E0", Length = "0x51")]
	[Token(Token = "0x600032B")]
	public MenuCategoryAttribute(string category) { }

}

