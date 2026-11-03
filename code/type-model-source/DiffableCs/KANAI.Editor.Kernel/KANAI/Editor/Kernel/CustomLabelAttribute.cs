namespace KANAI.Editor.Kernel;

[Token(Token = "0x2000004")]
public class CustomLabelAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000006")]
	public readonly string Value; //Field offset: 0x18

	[Address(RVA = "0x1DD97C0", Offset = "0x1DD8BC0", Length = "0x31")]
	[Token(Token = "0x6000003")]
	public CustomLabelAttribute(string value) { }

}

