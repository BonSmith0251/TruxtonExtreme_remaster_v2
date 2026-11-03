namespace UnityEngine;

[AttributeUsage(AttributeTargets::All (32767), Inherited = True, AllowMultiple = False)]
[Token(Token = "0x200016A")]
public class TooltipAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005FF")]
	public readonly string tooltip; //Field offset: 0x18

	[Address(RVA = "0x3073140", Offset = "0x3072540", Length = "0x35")]
	[Token(Token = "0x6001200")]
	public TooltipAttribute(string tooltip) { }

}

