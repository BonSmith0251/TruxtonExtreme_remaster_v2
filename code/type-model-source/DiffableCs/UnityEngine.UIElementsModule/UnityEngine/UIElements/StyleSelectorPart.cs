namespace UnityEngine.UIElements;

[Token(Token = "0x2000486")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct StyleSelectorPart
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000EC8")]
	private string m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000EC9")]
	private StyleSelectorType m_Type; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000ECA")]
	internal object tempData; //Field offset: 0x10

	[Token(Token = "0x1700091D")]
	public internal StyleSelectorType type
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x60021D8")]
		 get { } //Length: 6
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x60021D9")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700091C")]
	public internal string value
	{
		[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
		[Token(Token = "0x60021D6")]
		 get { } //Length: 6
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60021D7")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 8
	}

	[Address(RVA = "0x328B560", Offset = "0x328A960", Length = "0x51")]
	[Token(Token = "0x60021DB")]
	public static StyleSelectorPart CreateClass(string className) { }

	[Address(RVA = "0x328B5C0", Offset = "0x328A9C0", Length = "0x51")]
	[Token(Token = "0x60021DC")]
	public static StyleSelectorPart CreateId(string Id) { }

	[Address(RVA = "0x328B620", Offset = "0x328AA20", Length = "0x4E")]
	[Token(Token = "0x60021DD")]
	public static StyleSelectorPart CreatePredicate(object predicate) { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x60021D8")]
	public StyleSelectorType get_type() { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x60021D6")]
	public string get_value() { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x60021D9")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_type(StyleSelectorType value) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x60021D7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_value(string value) { }

	[Address(RVA = "0x328B670", Offset = "0x328AA70", Length = "0x70")]
	[Token(Token = "0x60021DA")]
	public virtual string ToString() { }

}

