namespace UnityEngine.UIElements;

[Token(Token = "0x2000425")]
public struct StyleMaterialDefinition : IStyleValue<MaterialDefinition>, IEquatable<StyleMaterialDefinition>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DCA")]
	private MaterialDefinition m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000DCB")]
	private StyleKeyword m_Keyword; //Field offset: 0x10

	[Token(Token = "0x170008CA")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
		[Token(Token = "0x6001FAC")]
		 get { } //Length: 6
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6001FAD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008C9")]
	public override MaterialDefinition value
	{
		[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
		[Token(Token = "0x6001FAA")]
		 get { } //Length: 10
		[Address(RVA = "0x327B260", Offset = "0x327A660", Length = "0x23")]
		[Token(Token = "0x6001FAB")]
		 set { } //Length: 35
	}

	[Address(RVA = "0x327AF90", Offset = "0x327A390", Length = "0x14")]
	[Token(Token = "0x6001FAE")]
	public StyleMaterialDefinition(MaterialDefinition m) { }

	[Address(RVA = "0x327B010", Offset = "0x327A410", Length = "0x145")]
	[Token(Token = "0x6001FAF")]
	internal StyleMaterialDefinition(object obj, StyleKeyword keyword) { }

	[Address(RVA = "0x327AFB0", Offset = "0x327A3B0", Length = "0x5A")]
	[Token(Token = "0x6001FB0")]
	public StyleMaterialDefinition(StyleKeyword keyword) { }

	[Address(RVA = "0x327AF70", Offset = "0x327A370", Length = "0x11")]
	[Token(Token = "0x6001FB1")]
	internal StyleMaterialDefinition(MaterialDefinition m, StyleKeyword keyword) { }

	[Address(RVA = "0x327AD00", Offset = "0x327A100", Length = "0x78")]
	[Token(Token = "0x6001FB4")]
	public override bool Equals(StyleMaterialDefinition other) { }

	[Address(RVA = "0x327AD80", Offset = "0x327A180", Length = "0xEC")]
	[Token(Token = "0x6001FB5")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
	[Token(Token = "0x6001FAC")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x6001FAA")]
	public override MaterialDefinition get_value() { }

	[Address(RVA = "0x327AE70", Offset = "0x327A270", Length = "0x8D")]
	[Token(Token = "0x6001FB6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x327B160", Offset = "0x327A560", Length = "0x78")]
	[Token(Token = "0x6001FB2")]
	public static bool op_Equality(StyleMaterialDefinition lhs, StyleMaterialDefinition rhs) { }

	[Address(RVA = "0x327B1E0", Offset = "0x327A5E0", Length = "0x80")]
	[Token(Token = "0x6001FB3")]
	public static StyleMaterialDefinition op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6001FAD")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x327B260", Offset = "0x327A660", Length = "0x23")]
	[Token(Token = "0x6001FAB")]
	public override void set_value(MaterialDefinition value) { }

	[Address(RVA = "0x327AF00", Offset = "0x327A300", Length = "0x6A")]
	[Token(Token = "0x6001FB7")]
	public virtual string ToString() { }

}

