namespace UnityEngine.VFX.Utility;

[Token(Token = "0x2000047")]
public class ExposedProperty
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400016C")]
	private string m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400016D")]
	private int m_Id; //Field offset: 0x18

	[Address(RVA = "0x2F65A60", Offset = "0x2F64E60", Length = "0x1D")]
	[Token(Token = "0x6000122")]
	public ExposedProperty() { }

	[Address(RVA = "0x1F900F0", Offset = "0x1F8F4F0", Length = "0x39")]
	[Token(Token = "0x6000123")]
	private ExposedProperty(string name) { }

	[Address(RVA = "0x2F65A80", Offset = "0x2F64E80", Length = "0x8C")]
	[Token(Token = "0x6000121")]
	public static ExposedProperty op_Addition(ExposedProperty self, ExposedProperty other) { }

	[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
	[Token(Token = "0x600011F")]
	public static string op_Explicit(ExposedProperty parameter) { }

	[Address(RVA = "0x2F65B10", Offset = "0x2F64F10", Length = "0x67")]
	[Token(Token = "0x600011E")]
	public static ExposedProperty op_Implicit(string name) { }

	[Address(RVA = "0x2F65B80", Offset = "0x2F64F80", Length = "0x8E")]
	[Token(Token = "0x6000120")]
	public static int op_Implicit(ExposedProperty parameter) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000124")]
	public virtual string ToString() { }

}

