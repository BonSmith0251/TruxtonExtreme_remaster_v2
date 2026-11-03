namespace UnityEngine;

[Token(Token = "0x200008C")]
public struct SecondarySpriteTexture : IEquatable<SecondarySpriteTexture>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013A")]
	public string name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400013B")]
	public Texture2D texture; //Field offset: 0x8

	[Address(RVA = "0x2FE9E50", Offset = "0x2FE9250", Length = "0x48")]
	[Token(Token = "0x60001D4")]
	public override bool Equals(SecondarySpriteTexture other) { }

	[Address(RVA = "0x2FE9EA0", Offset = "0x2FE92A0", Length = "0xAD")]
	[Token(Token = "0x60001D5")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FE9F50", Offset = "0x2FE9350", Length = "0x6D")]
	[Token(Token = "0x60001D6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2FE9E50", Offset = "0x2FE9250", Length = "0x48")]
	[Token(Token = "0x60001D7")]
	public static bool op_Equality(SecondarySpriteTexture lhs, SecondarySpriteTexture rhs) { }

	[Address(RVA = "0x2FE9FC0", Offset = "0x2FE93C0", Length = "0x4C")]
	[Token(Token = "0x60001D8")]
	public static bool op_Inequality(SecondarySpriteTexture lhs, SecondarySpriteTexture rhs) { }

}

