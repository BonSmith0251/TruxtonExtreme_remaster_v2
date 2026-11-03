namespace UnityEngine;

[DefaultMember("Item")]
[Token(Token = "0x200014D")]
[UsedByNativeCode]
public struct Color32 : IEquatable<Color32>, IFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Ignore(DoesNotContributeToSize = True)]
	[Token(Token = "0x4000579")]
	private int rgba; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400057A")]
	public byte r; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x400057B")]
	public byte g; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x400057C")]
	public byte b; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x400057D")]
	public byte a; //Field offset: 0x3

	[Address(RVA = "0x131FF40", Offset = "0x131F340", Length = "0x13")]
	[Token(Token = "0x6001000")]
	public Color32(byte r, byte g, byte b, byte a) { }

	[Address(RVA = "0x3046610", Offset = "0x3045A10", Length = "0x7F")]
	[IsReadOnly]
	[Token(Token = "0x6001004")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[IsReadOnly]
	[Token(Token = "0x6001005")]
	public override bool Equals(Color32 other) { }

	[Address(RVA = "0x3046600", Offset = "0x3045A00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6001006")]
	public bool Equals(in Color32 other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[IsReadOnly]
	[Token(Token = "0x6001003")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x5C1550", Offset = "0x5C0950", Length = "0x19F")]
	[Token(Token = "0x6001001")]
	public static Color32 op_Implicit(Color c) { }

	[Address(RVA = "0x3046900", Offset = "0x3045D00", Length = "0x61")]
	[Token(Token = "0x6001002")]
	public static Color op_Implicit(Color32 c) { }

	[Address(RVA = "0x30468F0", Offset = "0x3045CF0", Length = "0xD")]
	[IsReadOnly]
	[Token(Token = "0x6001007")]
	public virtual string ToString() { }

	[Address(RVA = "0x3046690", Offset = "0x3045A90", Length = "0x259")]
	[IsReadOnly]
	[Token(Token = "0x6001008")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

