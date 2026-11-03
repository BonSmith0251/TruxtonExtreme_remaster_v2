namespace UnityEngine.VFX.Utility;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x2000065")]
public class VFXBinderAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001FA")]
	public string MenuPath; //Field offset: 0x18

	[Address(RVA = "0x1DD97C0", Offset = "0x1DD8BC0", Length = "0x31")]
	[Token(Token = "0x60001E0")]
	public VFXBinderAttribute(string menuPath) { }

}

