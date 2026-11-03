namespace UnityEngine.UIElements;

[Token(Token = "0x2000482")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleProperty
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000EB7")]
	private StylePropertyId m_Id; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000EB8")]
	private string m_CustomName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000EB9")]
	private int m_Line; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000EBA")]
	private StyleValueHandle[] m_Values; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000EBB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool requireVariableResolve; //Field offset: 0x30

	[Token(Token = "0x17000915")]
	internal int handleCount
	{
		[Address(RVA = "0x328AE80", Offset = "0x328A280", Length = "0xE")]
		[Token(Token = "0x60021BE")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 14
	}

	[Token(Token = "0x17000912")]
	internal StylePropertyId id
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60021B9")]
		internal get { } //Length: 85
	}

	[Token(Token = "0x17000916")]
	internal bool isCustomProperty
	{
		[Address(RVA = "0x328AE90", Offset = "0x328A290", Length = "0x8")]
		[Token(Token = "0x60021BF")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000913")]
	public internal string name
	{
		[Address(RVA = "0x328AEA0", Offset = "0x328A2A0", Length = "0xBC")]
		[Token(Token = "0x60021BA")]
		 get { } //Length: 188
		[Address(RVA = "0x328A200", Offset = "0x3289600", Length = "0x155")]
		[Token(Token = "0x60021BB")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 341
	}

	[Token(Token = "0x17000914")]
	public internal StyleValueHandle[] values
	{
		[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
		[Token(Token = "0x60021BC")]
		 get { } //Length: 7
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60021BD")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x328ADD0", Offset = "0x328A1D0", Length = "0xAD")]
	[Token(Token = "0x60021C0")]
	internal StyleProperty() { }

	[Address(RVA = "0x328A200", Offset = "0x3289600", Length = "0x155")]
	[Token(Token = "0x60021C1")]
	internal void CacheId(string value) { }

	[Address(RVA = "0x328A360", Offset = "0x3289760", Length = "0x84")]
	[Token(Token = "0x60021C4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static float ConvertDimensionToFilterFloat(Dimension dim) { }

	[Address(RVA = "0x328AE80", Offset = "0x328A280", Length = "0xE")]
	[Token(Token = "0x60021BE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int get_handleCount() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60021B9")]
	internal StylePropertyId get_id() { }

	[Address(RVA = "0x328AE90", Offset = "0x328A290", Length = "0x8")]
	[Token(Token = "0x60021BF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool get_isCustomProperty() { }

	[Address(RVA = "0x328AEA0", Offset = "0x328A2A0", Length = "0xBC")]
	[Token(Token = "0x60021BA")]
	public string get_name() { }

	[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
	[Token(Token = "0x60021BC")]
	public StyleValueHandle[] get_values() { }

	[Address(RVA = "0x328A200", Offset = "0x3289600", Length = "0x155")]
	[Token(Token = "0x60021BB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_name(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60021BD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_values(StyleValueHandle[] value) { }

	[Address(RVA = "0x328A400", Offset = "0x3289800", Length = "0x18")]
	[Token(Token = "0x60021C3")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static FilterFunctionType ToFilterFunctionType(StyleValueFunction function) { }

	[Address(RVA = "0x328A480", Offset = "0x3289880", Length = "0x94A")]
	[Token(Token = "0x60021C2")]
	public bool TryGetMaterialDefinition(StyleSheet styleSheet, out MaterialDefinition value) { }

}

