namespace Unity.Cinemachine;

[Token(Token = "0x200009F")]
public sealed class HideIfNoComponentAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000288")]
	public Type ComponentType; //Field offset: 0x18

	[Address(RVA = "0x1DD97C0", Offset = "0x1DD8BC0", Length = "0x31")]
	[Token(Token = "0x6000329")]
	public HideIfNoComponentAttribute(Type type) { }

}

