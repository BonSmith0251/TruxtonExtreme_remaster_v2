namespace TMPro;

[Token(Token = "0x200004E")]
public struct FontAssetCreationSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000237")]
	public string sourceFontFileName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000238")]
	public string sourceFontFileGUID; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000239")]
	public int faceIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400023A")]
	public int pointSizeSamplingMode; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400023B")]
	public int pointSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400023C")]
	public int padding; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400023D")]
	public int paddingMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400023E")]
	public int packingMode; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400023F")]
	public int atlasWidth; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000240")]
	public int atlasHeight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000241")]
	public int characterSetSelectionMode; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000242")]
	public string characterSequence; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000243")]
	public string referencedFontAssetGUID; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000244")]
	public string referencedTextAssetGUID; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000245")]
	public int fontStyle; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000246")]
	public float fontStyleModifier; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000247")]
	public int renderMode; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000248")]
	public bool includeFontFeatures; //Field offset: 0x5C

	[Address(RVA = "0x2EC5590", Offset = "0x2EC4990", Length = "0xFF")]
	[Token(Token = "0x600029B")]
	internal FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode) { }

}

