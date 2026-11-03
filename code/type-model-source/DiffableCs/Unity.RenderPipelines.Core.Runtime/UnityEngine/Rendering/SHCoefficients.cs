namespace UnityEngine.Rendering;

[Token(Token = "0x20001AC")]
public struct SHCoefficients : IEquatable<SHCoefficients>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400084A")]
	public Vector4 SHAr; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400084B")]
	public Vector4 SHAg; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400084C")]
	public Vector4 SHAb; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400084D")]
	public Vector4 SHBr; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400084E")]
	public Vector4 SHBg; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400084F")]
	public Vector4 SHBb; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000850")]
	public Vector4 SHC; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000851")]
	public Vector4 ProbesOcclusion; //Field offset: 0x70

	[Address(RVA = "0x2C4EF30", Offset = "0x2C4E330", Length = "0x66E")]
	[Token(Token = "0x6000CB8")]
	public SHCoefficients(SphericalHarmonicsL2 sh) { }

	[Address(RVA = "0x2C4EEB0", Offset = "0x2C4E2B0", Length = "0x7D")]
	[Token(Token = "0x6000CB9")]
	public SHCoefficients(SphericalHarmonicsL2 sh, Vector4 probesOcclusion) { }

	[Address(RVA = "0x2C4E6F0", Offset = "0x2C4DAF0", Length = "0x318")]
	[Token(Token = "0x6000CBD")]
	public override bool Equals(SHCoefficients other) { }

	[Address(RVA = "0x2C4EA10", Offset = "0x2C4DE10", Length = "0xF0")]
	[Token(Token = "0x6000CBE")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2C4EB10", Offset = "0x2C4DF10", Length = "0x16F")]
	[Token(Token = "0x6000CBF")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C4EC80", Offset = "0x2C4E080", Length = "0xDA")]
	[Token(Token = "0x6000CBA")]
	private static Vector4 GetSHA(SphericalHarmonicsL2 sh, int i) { }

	[Address(RVA = "0x2C4ED60", Offset = "0x2C4E160", Length = "0xBD")]
	[Token(Token = "0x6000CBB")]
	private static Vector4 GetSHB(SphericalHarmonicsL2 sh, int i) { }

	[Address(RVA = "0x2C4EE20", Offset = "0x2C4E220", Length = "0x8C")]
	[Token(Token = "0x6000CBC")]
	private static Vector4 GetSHC(SphericalHarmonicsL2 sh) { }

	[Address(RVA = "0x2C4F5A0", Offset = "0x2C4E9A0", Length = "0x5F")]
	[Token(Token = "0x6000CC0")]
	public static bool op_Equality(SHCoefficients left, SHCoefficients right) { }

	[Address(RVA = "0x2C4F600", Offset = "0x2C4EA00", Length = "0x61")]
	[Token(Token = "0x6000CC1")]
	public static bool op_Inequality(SHCoefficients left, SHCoefficients right) { }

}

