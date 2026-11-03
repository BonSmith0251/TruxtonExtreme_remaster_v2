namespace UnityEngine.UIElements;

[Token(Token = "0x2000518")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class UxmlObjectAsset : UxmlAsset
{
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40010BB")]
	private int m_ParentId; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x40010BC")]
	private bool m_IsField; //Field offset: 0x5C

	[Token(Token = "0x170009E0")]
	public bool isField
	{
		[Address(RVA = "0x1FEC950", Offset = "0x1FEBD50", Length = "0x5")]
		[Token(Token = "0x60025C6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170009DF")]
	public int parentId
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x60025C4")]
		 get { } //Length: 4
		[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
		[Token(Token = "0x60025C5")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x32C5390", Offset = "0x32C4790", Length = "0x63")]
	[Token(Token = "0x60025C7")]
	public UxmlObjectAsset(string fullTypeNameOrFieldName, bool isField, UxmlNamespaceDefinition xmlNamespace = null) { }

	[Address(RVA = "0x32C50C0", Offset = "0x32C44C0", Length = "0x1B3")]
	[Token(Token = "0x60025C8")]
	internal virtual bool Accepts(UxmlAsset asset, out string errorMessage) { }

	[Address(RVA = "0x1FEC950", Offset = "0x1FEBD50", Length = "0x5")]
	[Token(Token = "0x60025C6")]
	public bool get_isField() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x60025C4")]
	public int get_parentId() { }

	[Address(RVA = "0x32C5280", Offset = "0x32C4680", Length = "0xA")]
	[Token(Token = "0x60025C3")]
	public virtual bool HasParent() { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[Token(Token = "0x60025C5")]
	public void set_parentId(int value) { }

	[Address(RVA = "0x32C5290", Offset = "0x32C4690", Length = "0xF2")]
	[Token(Token = "0x60025C9")]
	public virtual string ToString() { }

}

