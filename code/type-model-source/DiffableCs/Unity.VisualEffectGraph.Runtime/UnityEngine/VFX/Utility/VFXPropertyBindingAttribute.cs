namespace UnityEngine.VFX.Utility;

[AttributeUsage(AttributeTargets::Field (256))]
[Token(Token = "0x2000069")]
public class VFXPropertyBindingAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000204")]
	public String[] EditorTypes; //Field offset: 0x18

	[Address(RVA = "0x1DD97C0", Offset = "0x1DD8BC0", Length = "0x31")]
	[Token(Token = "0x6000203")]
	public VFXPropertyBindingAttribute(String[] editorTypes) { }

}

