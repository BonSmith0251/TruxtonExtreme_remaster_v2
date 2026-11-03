namespace UnityEngine.UIElements;

[Token(Token = "0x20003FF")]
internal class StyleValueCollection
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D7E")]
	internal List<StyleValue> m_Values; //Field offset: 0x10

	[Address(RVA = "0x327D820", Offset = "0x327CC20", Length = "0x77")]
	[Token(Token = "0x6001E66")]
	public StyleValueCollection() { }

	[Address(RVA = "0x327CC20", Offset = "0x327C020", Length = "0x260")]
	[Token(Token = "0x6001E5D")]
	public StyleBackground GetStyleBackground(StylePropertyId id) { }

	[Address(RVA = "0x327CB10", Offset = "0x327BF10", Length = "0x7C")]
	[Token(Token = "0x6001E5E")]
	public StyleBackgroundPosition GetStyleBackgroundPosition(StylePropertyId id) { }

	[Address(RVA = "0x327CB90", Offset = "0x327BF90", Length = "0x81")]
	[Token(Token = "0x6001E5F")]
	public StyleBackgroundRepeat GetStyleBackgroundRepeat(StylePropertyId id) { }

	[Address(RVA = "0x327CE80", Offset = "0x327C280", Length = "0x6D")]
	[Token(Token = "0x6001E5C")]
	public StyleColor GetStyleColor(StylePropertyId id) { }

	[Address(RVA = "0x327CEF0", Offset = "0x327C2F0", Length = "0x69")]
	[Token(Token = "0x6001E5A")]
	public StyleFloat GetStyleFloat(StylePropertyId id) { }

	[Address(RVA = "0x327D030", Offset = "0x327C430", Length = "0xE6")]
	[Token(Token = "0x6001E60")]
	public StyleFont GetStyleFont(StylePropertyId id) { }

	[Address(RVA = "0x327CF60", Offset = "0x327C360", Length = "0xC4")]
	[Token(Token = "0x6001E61")]
	public StyleFontDefinition GetStyleFontDefinition(StylePropertyId id) { }

	[Address(RVA = "0x327D120", Offset = "0x327C520", Length = "0x73")]
	[Token(Token = "0x6001E5B")]
	public StyleInt GetStyleInt(StylePropertyId id) { }

	[Address(RVA = "0x327D1A0", Offset = "0x327C5A0", Length = "0xA4")]
	[Token(Token = "0x6001E59")]
	public StyleLength GetStyleLength(StylePropertyId id) { }

	[Address(RVA = "0x327D250", Offset = "0x327C650", Length = "0x217")]
	[Token(Token = "0x6001E62")]
	public StyleMaterialDefinition GetStyleMaterialDefinition(StylePropertyId id) { }

	[Address(RVA = "0x327D470", Offset = "0x327C870", Length = "0x7A")]
	[Token(Token = "0x6001E63")]
	public StyleRatio GetStyleRatio(StylePropertyId id) { }

	[Address(RVA = "0x327D4F0", Offset = "0x327C8F0", Length = "0x1CA")]
	[Token(Token = "0x6001E65")]
	public void SetStyleValue(StyleValue value) { }

	[Address(RVA = "0x327D6C0", Offset = "0x327CAC0", Length = "0x159")]
	[Token(Token = "0x6001E64")]
	public bool TryGetStyleValue(StylePropertyId id, ref StyleValue value) { }

}

