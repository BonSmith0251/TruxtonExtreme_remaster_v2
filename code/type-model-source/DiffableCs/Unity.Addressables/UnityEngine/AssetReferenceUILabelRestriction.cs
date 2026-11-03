namespace UnityEngine;

[AttributeUsage(384, AllowMultiple = False)]
[Token(Token = "0x2000007")]
public sealed class AssetReferenceUILabelRestriction : AssetReferenceUIRestriction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000009")]
	public String[] m_AllowedLabels; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000A")]
	public string m_CachedToString; //Field offset: 0x18

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x600000A")]
	public AssetReferenceUILabelRestriction(String[] allowedLabels) { }

	[Address(RVA = "0x27A4DE0", Offset = "0x27A41E0", Length = "0x130")]
	[Token(Token = "0x600000D")]
	public virtual string ToString() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600000B")]
	public virtual bool ValidateAsset(object obj) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600000C")]
	public virtual bool ValidateAsset(string path) { }

}

