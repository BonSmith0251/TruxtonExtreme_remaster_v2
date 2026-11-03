namespace UnityEngine.UIElements;

[HelpURL("UIE-USS")]
[Token(Token = "0x2000489")]
public class StyleSheet : ScriptableObject
{
	[Token(Token = "0x200048B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	public struct ImportStruct
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EED")]
		public StyleSheet styleSheet; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000EEE")]
		public String[] mediaQueries; //Field offset: 0x8

	}

	[Token(Token = "0x200048C")]
	public enum OrderedSelectorType : int
	{
		None = -1,
		Name = 0,
		Type = 1,
		Class = 2,
		Length = 3,
	}

	[Flags]
	[Token(Token = "0x200048A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	public enum RebuildOptions : int
	{
		None = 0,
		Synchronous = 1,
	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000ED8")]
	private bool m_RequiresRebuild; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	[Token(Token = "0x4000ED9")]
	private bool m_ImportedWithErrors; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[SerializeField]
	[Token(Token = "0x4000EDA")]
	private bool m_ImportedWithWarnings; //Field offset: 0x1A
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000EDB")]
	private StyleRule[] m_Rules; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000EDC")]
	internal Single[] floats; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000EDD")]
	internal Dimension[] dimensions; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000EDE")]
	internal Color[] colors; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000EDF")]
	internal String[] strings; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000EE0")]
	internal Object[] assets; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000EE1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal ImportStruct[] imports; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000EE2")]
	private List<StyleSheet> m_FlattenedImportedStyleSheets; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000EE3")]
	private int m_ContentHash; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000EE4")]
	internal ScalableImage[] scalableImages; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000EE5")]
	internal Dictionary<String, StyleComplexSelector>[] m_Tables; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000EE6")]
	internal int nonEmptyTablesMask; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000EE7")]
	internal StyleComplexSelector firstRootSelector; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000EE8")]
	internal StyleComplexSelector firstWildCardSelector; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000EE9")]
	private bool m_IsDefaultStyleSheet; //Field offset: 0x90

	[Token(Token = "0x17000922")]
	public int contentHash
	{
		[Address(RVA = "0x3264A40", Offset = "0x3263E40", Length = "0x6")]
		[Token(Token = "0x60021E4")]
		 get { } //Length: 6
		[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
		[Token(Token = "0x60021E5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000921")]
	internal List<StyleSheet> flattenedRecursiveImports
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60021E3")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700091E")]
	public internal bool importedWithErrors
	{
		[Address(RVA = "0x2F8BC90", Offset = "0x2F8B090", Length = "0x7")]
		[Token(Token = "0x60021DE")]
		 get { } //Length: 7
		[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
		[Token(Token = "0x60021DF")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700091F")]
	public internal bool importedWithWarnings
	{
		[Address(RVA = "0x2F8BCA0", Offset = "0x2F8B0A0", Length = "0x7")]
		[Token(Token = "0x60021E0")]
		 get { } //Length: 7
		[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
		[Token(Token = "0x60021E1")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000924")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool isDefaultStyleSheet
	{
		[Address(RVA = "0x32906D0", Offset = "0x328FAD0", Length = "0xA")]
		[Token(Token = "0x60021E7")]
		internal get { } //Length: 10
		[Address(RVA = "0x32909B0", Offset = "0x328FDB0", Length = "0x11F")]
		[Token(Token = "0x60021E8")]
		internal set { } //Length: 287
	}

	[Token(Token = "0x17000920")]
	internal StyleRule[] rules
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60021E2")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000923")]
	internal Dictionary<String, StyleComplexSelector>[] tables
	{
		[Address(RVA = "0x32906E0", Offset = "0x328FAE0", Length = "0x2C8")]
		[Token(Token = "0x60021E6")]
		internal get { } //Length: 712
	}

	[Address(RVA = "0x3290370", Offset = "0x328F770", Length = "0x35F")]
	[Token(Token = "0x6002239")]
	public StyleSheet() { }

	[Address(RVA = "0x328D280", Offset = "0x328C680", Length = "0x10")]
	[Token(Token = "0x60021EE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleRule AddRule() { }

	[Address(RVA = "0x328D290", Offset = "0x328C690", Length = "0x10")]
	[Token(Token = "0x60021F0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleRule AddRule(string selector) { }

	[Address(RVA = "0x328D270", Offset = "0x328C670", Length = "0xB")]
	[Token(Token = "0x60021EF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleRule AddRuleAtIndex(int index) { }

	[Address(RVA = "0x328CFA0", Offset = "0x328C3A0", Length = "0x2C1")]
	[Token(Token = "0x60021F1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleRule AddRuleAtIndex(int index, string selector) { }

	[Address(RVA = "0x328D510", Offset = "0x328C910", Length = "0x57")]
	[Token(Token = "0x60021FE")]
	internal int AddValue(Color value) { }

	[Address(RVA = "0x328D620", Offset = "0x328CA20", Length = "0x4C")]
	[Token(Token = "0x60021FD")]
	internal int AddValue(Dimension value) { }

	[Address(RVA = "0x328D570", Offset = "0x328C970", Length = "0x4C")]
	[Token(Token = "0x6002200")]
	internal int AddValue(string value) { }

	[Address(RVA = "0x328D4A0", Offset = "0x328C8A0", Length = "0x17")]
	[Token(Token = "0x60021FB")]
	internal int AddValue(StyleValueFunction function) { }

	[Address(RVA = "0x328D4A0", Offset = "0x328C8A0", Length = "0x17")]
	[Token(Token = "0x60021FA")]
	internal int AddValue(StyleValueKeyword keyword) { }

	[Address(RVA = "0x328D2A0", Offset = "0x328C6A0", Length = "0x4C")]
	[Token(Token = "0x6002201")]
	internal int AddValue(object value) { }

	[Address(RVA = "0x328D2F0", Offset = "0x328C6F0", Length = "0x1AE")]
	[Token(Token = "0x6002202")]
	internal int AddValue(Enum value) { }

	[Address(RVA = "0x328D5C0", Offset = "0x328C9C0", Length = "0x57")]
	[Token(Token = "0x60021FF")]
	internal int AddValue(ScalableImage value) { }

	[Address(RVA = "0x328D4C0", Offset = "0x328C8C0", Length = "0x4D")]
	[Token(Token = "0x60021FC")]
	internal int AddValue(float value) { }

	[Address(RVA = "0x91AAB0", Offset = "0x919EB0", Length = "0x7D")]
	[Token(Token = "0x60021F8")]
	private int AddValueToArray(ref T[] array, T value) { }

	[Address(RVA = "0x91AE30", Offset = "0x91A230", Length = "0x1FF")]
	[Token(Token = "0x60021EA")]
	private T CheckAccess(T[] list, StyleValueType type, StyleValueHandle handle) { }

	[Address(RVA = "0x328D7A0", Offset = "0x328CBA0", Length = "0x7B")]
	[Token(Token = "0x60021EC")]
	internal void FlattenImportedStyleSheetsRecursive() { }

	[Address(RVA = "0x328D670", Offset = "0x328CA70", Length = "0x124")]
	[Token(Token = "0x60021ED")]
	private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet) { }

	[Address(RVA = "0x3264A40", Offset = "0x3263E40", Length = "0x6")]
	[Token(Token = "0x60021E4")]
	public int get_contentHash() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60021E3")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<StyleSheet> get_flattenedRecursiveImports() { }

	[Address(RVA = "0x2F8BC90", Offset = "0x2F8B090", Length = "0x7")]
	[Token(Token = "0x60021DE")]
	public bool get_importedWithErrors() { }

	[Address(RVA = "0x2F8BCA0", Offset = "0x2F8B0A0", Length = "0x7")]
	[Token(Token = "0x60021E0")]
	public bool get_importedWithWarnings() { }

	[Address(RVA = "0x32906D0", Offset = "0x328FAD0", Length = "0xA")]
	[Token(Token = "0x60021E7")]
	internal bool get_isDefaultStyleSheet() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60021E2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleRule[] get_rules() { }

	[Address(RVA = "0x32906E0", Offset = "0x328FAE0", Length = "0x2C8")]
	[Token(Token = "0x60021E6")]
	internal Dictionary<String, StyleComplexSelector>[] get_tables() { }

	[Address(RVA = "0x91BC80", Offset = "0x91B080", Length = "0x76")]
	[Token(Token = "0x60021F9")]
	private int InsertValueInArray(ref T[] array, int index, T value) { }

	[Address(RVA = "0x328D820", Offset = "0x328CC20", Length = "0x73")]
	[Token(Token = "0x6002238")]
	private void MarkAsChanged() { }

	[Address(RVA = "0x328D8A0", Offset = "0x328CCA0", Length = "0x7")]
	[Token(Token = "0x60021EB")]
	internal override void OnEnable() { }

	[Address(RVA = "0x328D8B0", Offset = "0x328CCB0", Length = "0xAB")]
	[Token(Token = "0x6002222")]
	internal Angle ReadAngle(StyleValueHandle handle) { }

	[Address(RVA = "0x328D960", Offset = "0x328CD60", Length = "0x58")]
	[Token(Token = "0x6002215")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal object ReadAssetReference(StyleValueHandle handle) { }

	[Address(RVA = "0x328D9C0", Offset = "0x328CDC0", Length = "0x116")]
	[Token(Token = "0x6002209")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Color ReadColor(StyleValueHandle handle) { }

	[Address(RVA = "0x328DAE0", Offset = "0x328CEE0", Length = "0xB0")]
	[Token(Token = "0x6002207")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Dimension ReadDimension(StyleValueHandle handle) { }

	[Address(RVA = "0x91BD00", Offset = "0x91B100", Length = "0x213")]
	[Token(Token = "0x600220F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TEnum ReadEnum(StyleValueHandle handle) { }

	[Address(RVA = "0x328DB90", Offset = "0x328CF90", Length = "0x58")]
	[Token(Token = "0x600220D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadEnum(StyleValueHandle handle) { }

	[Address(RVA = "0x328DBF0", Offset = "0x328CFF0", Length = "0x9A")]
	[Token(Token = "0x6002205")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal float ReadFloat(StyleValueHandle handle) { }

	[Address(RVA = "0x328E080", Offset = "0x328D480", Length = "0x9")]
	[Token(Token = "0x6002219")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleValueFunction ReadFunction(StyleValueHandle handle) { }

	[Address(RVA = "0x328DC90", Offset = "0x328D090", Length = "0x140")]
	[Token(Token = "0x600221B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadFunctionName(StyleValueHandle handle) { }

	[Address(RVA = "0x328E080", Offset = "0x328D480", Length = "0x9")]
	[Token(Token = "0x6002203")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleValueKeyword ReadKeyword(StyleValueHandle handle) { }

	[Address(RVA = "0x328E090", Offset = "0x328D490", Length = "0x73")]
	[Token(Token = "0x6002220")]
	internal Length ReadLength(StyleValueHandle handle) { }

	[Address(RVA = "0x328E110", Offset = "0x328D510", Length = "0x58")]
	[Token(Token = "0x6002216")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle) { }

	[Address(RVA = "0x328E170", Offset = "0x328D570", Length = "0x58")]
	[Token(Token = "0x6002213")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadResourcePath(StyleValueHandle handle) { }

	[Address(RVA = "0x328E1D0", Offset = "0x328D5D0", Length = "0x7D")]
	[Token(Token = "0x600221C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal ScalableImage ReadScalableImage(StyleValueHandle handle) { }

	[Address(RVA = "0x328E250", Offset = "0x328D650", Length = "0x58")]
	[Token(Token = "0x600220B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadString(StyleValueHandle handle) { }

	[Address(RVA = "0x328E2B0", Offset = "0x328D6B0", Length = "0x8E")]
	[Token(Token = "0x600221E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StylePropertyName ReadStylePropertyName(StyleValueHandle handle) { }

	[Address(RVA = "0x328E340", Offset = "0x328D740", Length = "0x42")]
	[Token(Token = "0x6002224")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TimeValue ReadTimeValue(StyleValueHandle handle) { }

	[Address(RVA = "0x328E390", Offset = "0x328D790", Length = "0x58")]
	[Token(Token = "0x6002211")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadVariable(StyleValueHandle handle) { }

	[Address(RVA = "0x328E3F0", Offset = "0x328D7F0", Length = "0xE")]
	[Token(Token = "0x60021F6")]
	internal void RebuildIfNecessary() { }

	[Address(RVA = "0x328E500", Offset = "0x328D900", Length = "0x15E")]
	[Token(Token = "0x60021F2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool RemoveRule(StyleRule rule) { }

	[Address(RVA = "0x328E400", Offset = "0x328D800", Length = "0xF2")]
	[Token(Token = "0x60021F3")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void RemoveRule(int ruleIndex) { }

	[Address(RVA = "0x328E660", Offset = "0x328DA60", Length = "0x3A")]
	[Token(Token = "0x60021F5")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void RequestRebuild(RebuildOptions options = 0) { }

	[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
	[Token(Token = "0x60021E5")]
	public void set_contentHash(int value) { }

	[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
	[Token(Token = "0x60021DF")]
	internal void set_importedWithErrors(bool value) { }

	[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
	[Token(Token = "0x60021E1")]
	internal void set_importedWithWarnings(bool value) { }

	[Address(RVA = "0x32909B0", Offset = "0x328FDB0", Length = "0x11F")]
	[Token(Token = "0x60021E8")]
	internal void set_isDefaultStyleSheet(bool value) { }

	[Address(RVA = "0x328E6A0", Offset = "0x328DAA0", Length = "0x25")]
	[Token(Token = "0x60021F4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SetRules(StyleRule[] newRules) { }

	[Address(RVA = "0x328E6D0", Offset = "0x328DAD0", Length = "0x5CC")]
	[Token(Token = "0x60021F7")]
	internal void SetupReferences() { }

	[Address(RVA = "0x91BF20", Offset = "0x91B320", Length = "0x7D")]
	[Token(Token = "0x60021E9")]
	private bool TryCheckAccess(T[] list, StyleValueType type, StyleValueHandle handle, out T value) { }

	[Address(RVA = "0x328ECC0", Offset = "0x328E0C0", Length = "0xDC")]
	[Token(Token = "0x6002223")]
	internal bool TryReadAngle(StyleValueHandle handle, out Angle value) { }

	[Address(RVA = "0x328EDA0", Offset = "0x328E1A0", Length = "0x6A")]
	[Token(Token = "0x6002218")]
	internal bool TryReadAssetReference(StyleValueHandle handle, out object value) { }

	[Address(RVA = "0x328EE10", Offset = "0x328E210", Length = "0x126")]
	[Token(Token = "0x600220A")]
	internal bool TryReadColor(StyleValueHandle handle, out Color value) { }

	[Address(RVA = "0x328EF40", Offset = "0x328E340", Length = "0xEC")]
	[Token(Token = "0x6002208")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool TryReadDimension(StyleValueHandle handle, out Dimension value) { }

	[Address(RVA = "0x91C2E0", Offset = "0x91B6E0", Length = "0xEC")]
	[Token(Token = "0x6002210")]
	internal bool TryReadEnum(StyleValueHandle handle, out TEnum value) { }

	[Address(RVA = "0x328F030", Offset = "0x328E430", Length = "0x6A")]
	[Token(Token = "0x600220E")]
	internal bool TryReadEnum(StyleValueHandle handle, out string value) { }

	[Address(RVA = "0x328F0A0", Offset = "0x328E4A0", Length = "0xCA")]
	[Token(Token = "0x6002206")]
	internal bool TryReadFloat(StyleValueHandle handle, out float value) { }

	[Address(RVA = "0x328F170", Offset = "0x328E570", Length = "0x11")]
	[Token(Token = "0x600221A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool TryReadFunction(StyleValueHandle handle, out StyleValueFunction value) { }

	[Address(RVA = "0x328F190", Offset = "0x328E590", Length = "0x11")]
	[Token(Token = "0x6002204")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool TryReadKeyword(StyleValueHandle handle, out StyleValueKeyword value) { }

	[Address(RVA = "0x328F1B0", Offset = "0x328E5B0", Length = "0x9A")]
	[Token(Token = "0x6002221")]
	internal bool TryReadLength(StyleValueHandle handle, out Length value) { }

	[Address(RVA = "0x328F250", Offset = "0x328E650", Length = "0x6A")]
	[Token(Token = "0x6002217")]
	internal bool TryReadMissingAssetReferenceUrl(StyleValueHandle handle, out string value) { }

	[Address(RVA = "0x328F2C0", Offset = "0x328E6C0", Length = "0x6A")]
	[Token(Token = "0x6002214")]
	internal bool TryReadResourcePath(StyleValueHandle handle, out string value) { }

	[Address(RVA = "0x328F330", Offset = "0x328E730", Length = "0x6A")]
	[Token(Token = "0x600221D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool TryReadScalableImage(StyleValueHandle handle, out ScalableImage value) { }

	[Address(RVA = "0x328F3A0", Offset = "0x328E7A0", Length = "0x6A")]
	[Token(Token = "0x600220C")]
	internal bool TryReadString(StyleValueHandle handle, out string value) { }

	[Address(RVA = "0x328F410", Offset = "0x328E810", Length = "0xBE")]
	[Token(Token = "0x600221F")]
	internal bool TryReadStylePropertyName(StyleValueHandle handle, out StylePropertyName value) { }

	[Address(RVA = "0x328F4D0", Offset = "0x328E8D0", Length = "0x55")]
	[Token(Token = "0x6002225")]
	internal bool TryReadTimeValue(StyleValueHandle handle, out TimeValue value) { }

	[Address(RVA = "0x328F530", Offset = "0x328E930", Length = "0x6A")]
	[Token(Token = "0x6002212")]
	internal bool TryReadVariable(StyleValueHandle handle, out string value) { }

	[Address(RVA = "0x328F5A0", Offset = "0x328E9A0", Length = "0x132")]
	[Token(Token = "0x6002236")]
	internal void WriteAngle(ref StyleValueHandle handle, Angle value) { }

	[Address(RVA = "0x328F6E0", Offset = "0x328EAE0", Length = "0xE6")]
	[Token(Token = "0x600222F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteAssetReference(ref StyleValueHandle handle, object value) { }

	[Address(RVA = "0x328F7D0", Offset = "0x328EBD0", Length = "0xA9")]
	[Token(Token = "0x6002229")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteColor(ref StyleValueHandle handle, Color color) { }

	[Address(RVA = "0x328F880", Offset = "0x328EC80", Length = "0xE")]
	[Token(Token = "0x6002234")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteCommaSeparator(ref StyleValueHandle handle) { }

	[Address(RVA = "0x328F890", Offset = "0x328EC90", Length = "0x95")]
	[Token(Token = "0x6002228")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteDimension(ref StyleValueHandle handle, Dimension dimension) { }

	[Address(RVA = "0x91C3D0", Offset = "0x91B7D0", Length = "0xDD")]
	[Token(Token = "0x600222B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteEnum(ref StyleValueHandle handle, TEnum value) { }

	[Address(RVA = "0x328F930", Offset = "0x328ED30", Length = "0xA5")]
	[Token(Token = "0x600222C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteEnumAsString(ref StyleValueHandle handle, string valueStr) { }

	[Address(RVA = "0x328F9E0", Offset = "0x328EDE0", Length = "0x96")]
	[Token(Token = "0x6002227")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteFloat(ref StyleValueHandle handle, float value) { }

	[Address(RVA = "0x328FA80", Offset = "0x328EE80", Length = "0x11")]
	[Token(Token = "0x6002231")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteFunction(ref StyleValueHandle handle, StyleValueFunction function) { }

	[Address(RVA = "0x328FAA0", Offset = "0x328EEA0", Length = "0x11")]
	[Token(Token = "0x6002226")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteKeyword(ref StyleValueHandle handle, StyleValueKeyword value) { }

	[Address(RVA = "0x328FAC0", Offset = "0x328EEC0", Length = "0x2E3")]
	[Token(Token = "0x6002235")]
	internal void WriteLength(ref StyleValueHandle handle, Length value) { }

	[Address(RVA = "0x328FDB0", Offset = "0x328F1B0", Length = "0xA5")]
	[Token(Token = "0x6002230")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteMissingAssetReferenceUrl(ref StyleValueHandle handle, string assetReference) { }

	[Address(RVA = "0x328FE60", Offset = "0x328F260", Length = "0xA5")]
	[Token(Token = "0x600222E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteResourcePath(ref StyleValueHandle handle, string resourcePath) { }

	[Address(RVA = "0x328FF10", Offset = "0x328F310", Length = "0xBB")]
	[Token(Token = "0x6002232")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteScalableImage(ref StyleValueHandle handle, ScalableImage scalableImage) { }

	[Address(RVA = "0x328FFD0", Offset = "0x328F3D0", Length = "0xA5")]
	[Token(Token = "0x600222A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteString(ref StyleValueHandle handle, string value) { }

	[Address(RVA = "0x3290080", Offset = "0x328F480", Length = "0xD3")]
	[Token(Token = "0x6002233")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteStylePropertyName(ref StyleValueHandle handle, StylePropertyName propertyName) { }

	[Address(RVA = "0x3290160", Offset = "0x328F560", Length = "0x156")]
	[Token(Token = "0x6002237")]
	internal void WriteTimeValue(ref StyleValueHandle handle, TimeValue value) { }

	[Address(RVA = "0x32902C0", Offset = "0x328F6C0", Length = "0xA5")]
	[Token(Token = "0x600222D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void WriteVariable(ref StyleValueHandle handle, string variableName) { }

}

