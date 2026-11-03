namespace UnityEngine.UIElements;

[DefaultMember("Item")]
[Token(Token = "0x2000517")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal abstract class UxmlAsset : IUxmlAttributes
{
	[Token(Token = "0x40010B2")]
	public const string NullNodeType = "null"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40010B3")]
	private string m_FullTypeName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40010B4")]
	private UxmlNamespaceDefinition m_XmlNamespace; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40010B5")]
	private int m_Id; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeReference]
	[Token(Token = "0x40010B6")]
	private UxmlAsset m_Parent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeReference]
	[Token(Token = "0x40010B7")]
	private List<UxmlAsset> m_Children; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40010B8")]
	private VisualTreeAsset m_VisualTreeAsset; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40010B9")]
	private List<UxmlNamespaceDefinition> m_NamespaceDefinitions; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40010BA")]
	protected List<UxmlProperty> m_Properties; //Field offset: 0x50

	[Token(Token = "0x170009DC")]
	public int childCount
	{
		[Address(RVA = "0x32C2990", Offset = "0x32C1D90", Length = "0x3D")]
		[Token(Token = "0x60025AC")]
		 get { } //Length: 61
	}

	[Token(Token = "0x170009D7")]
	public string fullTypeName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60025A6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170009D8")]
	public int id
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x60025A7")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x60025A8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170009D9")]
	public bool isRoot
	{
		[Address(RVA = "0x32C29D0", Offset = "0x32C1DD0", Length = "0xB1")]
		[Token(Token = "0x60025A9")]
		 get { } //Length: 177
	}

	[Token(Token = "0x170009DD")]
	public UxmlAsset Item
	{
		[Address(RVA = "0x32C2930", Offset = "0x32C1D30", Length = "0x51")]
		[Token(Token = "0x60025AD")]
		 get { } //Length: 81
	}

	[Token(Token = "0x170009DE")]
	public List<UxmlNamespaceDefinition> namespaceDefinitions
	{
		[Address(RVA = "0x32C2A90", Offset = "0x32C1E90", Length = "0x7B")]
		[Token(Token = "0x60025AE")]
		 get { } //Length: 123
	}

	[Token(Token = "0x170009DA")]
	public UxmlAsset parentAsset
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60025AA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170009DB")]
	internal VisualTreeAsset visualTreeAsset
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60025AB")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x10A5A10", Offset = "0x10A4E10", Length = "0x50")]
	[Token(Token = "0x60025A5")]
	public UxmlAsset(string fullTypeName, UxmlNamespaceDefinition xmlNamespace = null) { }

	[Token(Token = "0x60025C1")]
	internal abstract bool Accepts(UxmlAsset asset, out string errorMessage) { }

	[Address(RVA = "0x32C1720", Offset = "0x32C0B20", Length = "0xA1")]
	[Token(Token = "0x60025B3")]
	public void Add(UxmlAsset asset) { }

	[Address(RVA = "0x32C2990", Offset = "0x32C1D90", Length = "0x3D")]
	[Token(Token = "0x60025AC")]
	public int get_childCount() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60025A6")]
	public string get_fullTypeName() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x60025A7")]
	public int get_id() { }

	[Address(RVA = "0x32C29D0", Offset = "0x32C1DD0", Length = "0xB1")]
	[Token(Token = "0x60025A9")]
	public bool get_isRoot() { }

	[Address(RVA = "0x32C2930", Offset = "0x32C1D30", Length = "0x51")]
	[Token(Token = "0x60025AD")]
	public UxmlAsset get_Item(int index) { }

	[Address(RVA = "0x32C2A90", Offset = "0x32C1E90", Length = "0x7B")]
	[Token(Token = "0x60025AE")]
	public List<UxmlNamespaceDefinition> get_namespaceDefinitions() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60025AA")]
	public UxmlAsset get_parentAsset() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60025AB")]
	internal VisualTreeAsset get_visualTreeAsset() { }

	[Address(RVA = "0x32C17D0", Offset = "0x32C0BD0", Length = "0x133")]
	[Token(Token = "0x60025AF")]
	public void GetChildrenUxmlObjectAssets(List<UxmlObjectAsset> children) { }

	[Address(RVA = "0x32C1910", Offset = "0x32C0D10", Length = "0x115")]
	[Token(Token = "0x60025B0")]
	public UxmlObjectAsset GetField(string fieldName) { }

	[Address(RVA = "0x1550FC0", Offset = "0x15503C0", Length = "0x9")]
	[Token(Token = "0x60025BC")]
	public override bool HasParent() { }

	[Address(RVA = "0x32C1A30", Offset = "0x32C0E30", Length = "0x53")]
	[Token(Token = "0x60025BA")]
	public int IndexOf(UxmlAsset asset) { }

	[Address(RVA = "0x32C1B50", Offset = "0x32C0F50", Length = "0x432")]
	[Token(Token = "0x60025B4")]
	public void Insert(int index, UxmlAsset asset) { }

	[Address(RVA = "0x32C1A90", Offset = "0x32C0E90", Length = "0xB8")]
	[Token(Token = "0x60025B5")]
	private void InsertInChildren(int index, UxmlAsset asset) { }

	[Address(RVA = "0x32C1F90", Offset = "0x32C1390", Length = "0x198")]
	[Token(Token = "0x60025BB")]
	public bool IsAncestorOf(UxmlAsset other) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60025B9")]
	override void OnVisualTreeAssetChanged(VisualTreeAsset previousVta, VisualTreeAsset newVta) { }

	[Address(RVA = "0x32C2130", Offset = "0x32C1530", Length = "0xD0")]
	[Token(Token = "0x60025BF")]
	public void RemoveAttribute(string attributeName) { }

	[Address(RVA = "0x32C2210", Offset = "0x32C1610", Length = "0x88")]
	[Token(Token = "0x60025B6")]
	private void RemoveFromChildren(UxmlAsset child) { }

	[Address(RVA = "0x32C22A0", Offset = "0x32C16A0", Length = "0x51")]
	[Token(Token = "0x60025B7")]
	private void RemoveFromChildren(int index) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x60025A8")]
	public void set_id(int value) { }

	[Address(RVA = "0x32C2300", Offset = "0x32C1700", Length = "0x8")]
	[Token(Token = "0x60025BE")]
	public void SetAttribute(string name, string value) { }

	[Address(RVA = "0x32C2310", Offset = "0x32C1710", Length = "0x23A")]
	[Token(Token = "0x60025C0")]
	private void SetOrAddProperty(string propertyName, string propertyValue) { }

	[Address(RVA = "0x32C2550", Offset = "0x32C1950", Length = "0xD1")]
	[Token(Token = "0x60025B8")]
	private void SetParent(UxmlAsset parent) { }

	[Address(RVA = "0x32C2630", Offset = "0x32C1A30", Length = "0x19C")]
	[Token(Token = "0x60025B2")]
	internal void SetVisualTreeAsset(VisualTreeAsset vta) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x60025B1")]
	internal void SetVisualTreeAssetWithOutNotify(VisualTreeAsset vta) { }

	[Address(RVA = "0x32C27D0", Offset = "0x32C1BD0", Length = "0x65")]
	[Token(Token = "0x60025C2")]
	public virtual string ToString() { }

	[Address(RVA = "0x32C2840", Offset = "0x32C1C40", Length = "0xEA")]
	[Token(Token = "0x60025BD")]
	public override bool TryGetAttributeValue(string propertyName, out string value) { }

}

