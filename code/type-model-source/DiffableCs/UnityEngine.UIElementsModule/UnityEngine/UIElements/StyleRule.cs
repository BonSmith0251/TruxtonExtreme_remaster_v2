namespace UnityEngine.UIElements;

[Token(Token = "0x2000483")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleRule
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000EBC")]
	private StyleComplexSelector[] m_ComplexSelectors; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000EBD")]
	private StyleProperty[] m_Properties; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000EBE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int line; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EBF")]
	private StyleSheet <styleSheet>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000EC0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int customPropertiesCount; //Field offset: 0x30

	[Token(Token = "0x17000918")]
	public StyleComplexSelector[] complexSelectors
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60021C8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000919")]
	public StyleProperty[] properties
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60021C9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000917")]
	internal StyleSheet styleSheet
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60021C5")]
		internal get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60021C6")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x328B4C0", Offset = "0x328A8C0", Length = "0x94")]
	[Token(Token = "0x60021C7")]
	internal StyleRule(StyleSheet styleSheet) { }

	[Address(RVA = "0x328AF60", Offset = "0x328A360", Length = "0x24D")]
	[Token(Token = "0x60021CC")]
	public StyleProperty AddProperty(string propertyName) { }

	[Address(RVA = "0x328B1B0", Offset = "0x328A5B0", Length = "0x1A6")]
	[Token(Token = "0x60021CB")]
	public StyleComplexSelector AddSelector(string selectorStr) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60021C8")]
	public StyleComplexSelector[] get_complexSelectors() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60021C9")]
	public StyleProperty[] get_properties() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60021C5")]
	internal StyleSheet get_styleSheet() { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60021C6")]
	internal void set_styleSheet(StyleSheet value) { }

	[Address(RVA = "0x328B360", Offset = "0x328A760", Length = "0x157")]
	[Token(Token = "0x60021CA")]
	public bool TryAddSelector(string selectorStr, out StyleComplexSelector selector, out string error) { }

}

