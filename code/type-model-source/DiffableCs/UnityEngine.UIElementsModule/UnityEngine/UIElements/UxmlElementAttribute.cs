namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False)]
[Token(Token = "0x2000506")]
public class UxmlElementAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010A6")]
	public readonly string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010A7")]
	public LibraryVisibility visibility; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010A8")]
	internal readonly Type[] supportedChildTypes; //Field offset: 0x20

	[Address(RVA = "0x32C3D20", Offset = "0x32C3120", Length = "0x4B")]
	[Token(Token = "0x6002582")]
	public UxmlElementAttribute(string uxmlName) { }

	[Address(RVA = "0x32C3CC0", Offset = "0x32C30C0", Length = "0x55")]
	[Token(Token = "0x6002583")]
	public UxmlElementAttribute(string uxmlName, Type[] supportedTypes) { }

}

