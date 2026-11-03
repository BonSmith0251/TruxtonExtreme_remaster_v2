namespace UnityEngine.Rendering;

[Token(Token = "0x2000149")]
public struct SphericalHarmonicsL1
{
	[Token(Token = "0x4000636")]
	public static readonly SphericalHarmonicsL1 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000633")]
	public Vector4 shAr; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000634")]
	public Vector4 shAg; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000635")]
	public Vector4 shAb; //Field offset: 0x20

	[Address(RVA = "0x2C372A0", Offset = "0x2C366A0", Length = "0xD3")]
	[Token(Token = "0x6000AE6")]
	private static SphericalHarmonicsL1() { }

	[Address(RVA = "0x2C37050", Offset = "0x2C36450", Length = "0x117")]
	[Token(Token = "0x6000AE4")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x2C37170", Offset = "0x2C36570", Length = "0x125")]
	[Token(Token = "0x6000AE5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C37380", Offset = "0x2C36780", Length = "0x12F")]
	[Token(Token = "0x6000ADE")]
	public static SphericalHarmonicsL1 op_Addition(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) { }

	[Address(RVA = "0x2C374B0", Offset = "0x2C368B0", Length = "0xE8")]
	[Token(Token = "0x6000AE1")]
	public static SphericalHarmonicsL1 op_Division(SphericalHarmonicsL1 lhs, float rhs) { }

	[Address(RVA = "0x2C375A0", Offset = "0x2C369A0", Length = "0x14A")]
	[Token(Token = "0x6000AE2")]
	public static bool op_Equality(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) { }

	[Address(RVA = "0x2C376F0", Offset = "0x2C36AF0", Length = "0x9D")]
	[Token(Token = "0x6000AE3")]
	public static bool op_Inequality(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) { }

	[Address(RVA = "0x2C37790", Offset = "0x2C36B90", Length = "0xE8")]
	[Token(Token = "0x6000AE0")]
	public static SphericalHarmonicsL1 op_Multiply(SphericalHarmonicsL1 lhs, float rhs) { }

	[Address(RVA = "0x2C37880", Offset = "0x2C36C80", Length = "0x12F")]
	[Token(Token = "0x6000ADF")]
	public static SphericalHarmonicsL1 op_Subtraction(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) { }

}

