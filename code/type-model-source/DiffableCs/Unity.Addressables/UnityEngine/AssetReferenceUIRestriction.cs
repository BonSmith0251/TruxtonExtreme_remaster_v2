namespace UnityEngine;

[AttributeUsage(384, AllowMultiple = True)]
[Token(Token = "0x2000006")]
public class AssetReferenceUIRestriction : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000009")]
	public AssetReferenceUIRestriction() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000008")]
	public override bool ValidateAsset(string path) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000007")]
	public override bool ValidateAsset(object obj) { }

}

