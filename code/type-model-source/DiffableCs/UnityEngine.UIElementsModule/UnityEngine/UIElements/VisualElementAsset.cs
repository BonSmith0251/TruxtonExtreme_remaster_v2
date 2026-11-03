namespace UnityEngine.UIElements;

[Token(Token = "0x200051F")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule"})]
internal class VisualElementAsset : UxmlAsset
{
	[Token(Token = "0x40010C7")]
	internal const string k_LostInlineStyles = "VisualElementAsset previously had inline styles that were lost."; //Field offset: 0x0
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40010C8")]
	private int m_RuleIndex; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40010C9")]
	private String[] m_Classes; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40010CA")]
	private List<String> m_StylesheetPaths; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40010CB")]
	private List<StyleSheet> m_Stylesheets; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeReference]
	[Token(Token = "0x40010CC")]
	private UxmlSerializedData m_SerializedData; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x40010CD")]
	private bool m_SkipClone; //Field offset: 0x80

	[Token(Token = "0x170009E4")]
	public String[] classes
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60025DB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170009E6")]
	public bool hasStylesheetPaths
	{
		[Address(RVA = "0x1D33240", Offset = "0x1D32640", Length = "0x9")]
		[Token(Token = "0x60025DD")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170009E8")]
	public bool hasStylesheets
	{
		[Address(RVA = "0x32C7B00", Offset = "0x32C6F00", Length = "0x9")]
		[Token(Token = "0x60025DF")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170009E3")]
	public int ruleIndex
	{
		[Address(RVA = "0x30CD7C0", Offset = "0x30CCBC0", Length = "0x6")]
		[Token(Token = "0x60025D9")]
		 get { } //Length: 6
		[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
		[Token(Token = "0x60025DA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170009E9")]
	public UxmlSerializedData serializedData
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x60025E0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170009EA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool skipClone
	{
		[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
		[Token(Token = "0x60025E1")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170009E5")]
	public List<String> stylesheetPaths
	{
		[Address(RVA = "0x32C7B10", Offset = "0x32C6F10", Length = "0x7B")]
		[Token(Token = "0x60025DC")]
		 get { } //Length: 123
	}

	[Token(Token = "0x170009E7")]
	public List<StyleSheet> stylesheets
	{
		[Address(RVA = "0x32C7B90", Offset = "0x32C6F90", Length = "0x7B")]
		[Token(Token = "0x60025DE")]
		 get { } //Length: 123
	}

	[Address(RVA = "0x32C7A60", Offset = "0x32C6E60", Length = "0x92")]
	[Token(Token = "0x60025E2")]
	public VisualElementAsset(string fullTypeName, UxmlNamespaceDefinition xmlNamespace = null) { }

	[Address(RVA = "0x32C6F20", Offset = "0x32C6320", Length = "0x6C")]
	[Token(Token = "0x60025E5")]
	internal virtual bool Accepts(UxmlAsset asset, out string errorMessage) { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60025DB")]
	public String[] get_classes() { }

	[Address(RVA = "0x1D33240", Offset = "0x1D32640", Length = "0x9")]
	[Token(Token = "0x60025DD")]
	public bool get_hasStylesheetPaths() { }

	[Address(RVA = "0x32C7B00", Offset = "0x32C6F00", Length = "0x9")]
	[Token(Token = "0x60025DF")]
	public bool get_hasStylesheets() { }

	[Address(RVA = "0x30CD7C0", Offset = "0x30CCBC0", Length = "0x6")]
	[Token(Token = "0x60025D9")]
	public int get_ruleIndex() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x60025E0")]
	public UxmlSerializedData get_serializedData() { }

	[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
	[Token(Token = "0x60025E1")]
	internal bool get_skipClone() { }

	[Address(RVA = "0x32C7B10", Offset = "0x32C6F10", Length = "0x7B")]
	[Token(Token = "0x60025DC")]
	public List<String> get_stylesheetPaths() { }

	[Address(RVA = "0x32C7B90", Offset = "0x32C6F90", Length = "0x7B")]
	[Token(Token = "0x60025DE")]
	public List<StyleSheet> get_stylesheets() { }

	[Address(RVA = "0x32C6F90", Offset = "0x32C6390", Length = "0x11C")]
	[Token(Token = "0x60025E3")]
	private static bool IdsPathMatchesAttributeOverrideIdsPath(List<Int32> idsPath, List<Int32> attributeOverrideIdsPath, int templateId) { }

	[Address(RVA = "0x32C70B0", Offset = "0x32C64B0", Length = "0x6E4")]
	[Token(Token = "0x60025E4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal override VisualElement Instantiate(CreationContext cc) { }

	[Address(RVA = "0x32C77A0", Offset = "0x32C6BA0", Length = "0x117")]
	[Token(Token = "0x60025E7")]
	virtual void OnVisualTreeAssetChanged(VisualTreeAsset previousVta, VisualTreeAsset newVta) { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[Token(Token = "0x60025DA")]
	public void set_ruleIndex(int value) { }

	[Address(RVA = "0x32C78C0", Offset = "0x32C6CC0", Length = "0x191")]
	[Token(Token = "0x60025E6")]
	public virtual string ToString() { }

}

