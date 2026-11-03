namespace UnityEngine.UIElements;

[Token(Token = "0x20004E7")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule"})]
internal class TemplateAsset : VisualElementAsset
{
	[Token(Token = "0x20004E8")]
	internal struct AttributeOverride
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001077")]
		public string m_ElementName; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001078")]
		public String[] m_NamesPath; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001079")]
		public string m_AttributeName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400107A")]
		public string m_Value; //Field offset: 0x18

		[Address(RVA = "0x32B8150", Offset = "0x32B7550", Length = "0x17C")]
		[Token(Token = "0x6002520")]
		public bool NamesPathMatchesElementNamesPath(IList<String> elementNamesPath) { }

	}

	[Token(Token = "0x20004E9")]
	internal struct UxmlSerializedDataOverride
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400107B")]
		public int m_ElementId; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400107C")]
		public List<Int32> m_ElementIdsPath; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[SerializeReference]
		[Token(Token = "0x400107D")]
		public UxmlSerializedData m_SerializedData; //Field offset: 0x10

	}

	[Token(Token = "0x4001073")]
	public static readonly string UxmlInstanceTypeName; //Field offset: 0x0
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4001074")]
	private string m_TemplateAlias; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4001075")]
	private List<AttributeOverride> m_AttributeOverrides; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x4001076")]
	private List<SlotUsageEntry> m_SlotUsages; //Field offset: 0x98

	[Token(Token = "0x170009C4")]
	public List<AttributeOverride> attributeOverrides
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x600251D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170009C5")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<SlotUsageEntry> slotUsages
	{
		[Address(RVA = "0x2F92D00", Offset = "0x2F92100", Length = "0xA")]
		[Token(Token = "0x600251E")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 10
	}

	[Token(Token = "0x170009C3")]
	public string templateAlias
	{
		[Address(RVA = "0x2F94480", Offset = "0x2F93880", Length = "0xA")]
		[Token(Token = "0x600251C")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x32BA2A0", Offset = "0x32B96A0", Length = "0x62")]
	[Token(Token = "0x600251F")]
	private static TemplateAsset() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x600251D")]
	public List<AttributeOverride> get_attributeOverrides() { }

	[Address(RVA = "0x2F92D00", Offset = "0x2F92100", Length = "0xA")]
	[Token(Token = "0x600251E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<SlotUsageEntry> get_slotUsages() { }

	[Address(RVA = "0x2F94480", Offset = "0x2F93880", Length = "0xA")]
	[Token(Token = "0x600251C")]
	public string get_templateAlias() { }

}

