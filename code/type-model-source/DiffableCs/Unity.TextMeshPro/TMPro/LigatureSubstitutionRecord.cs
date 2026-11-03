namespace TMPro;

[Token(Token = "0x2000010")]
public struct LigatureSubstitutionRecord
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000021")]
	private UInt32[] m_ComponentGlyphIDs; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000022")]
	private uint m_LigatureGlyphID; //Field offset: 0x8

	[Token(Token = "0x1700000F")]
	public UInt32[] componentGlyphIDs
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000030")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000031")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000010")]
	public uint ligatureGlyphID
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000032")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x6000033")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000030")]
	public UInt32[] get_componentGlyphIDs() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6000032")]
	public uint get_ligatureGlyphID() { }

	[Address(RVA = "0x2E985B0", Offset = "0x2E979B0", Length = "0x7D")]
	[Token(Token = "0x6000034")]
	public static bool op_Equality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }

	[Address(RVA = "0x2E98630", Offset = "0x2E97A30", Length = "0x98")]
	[Token(Token = "0x6000035")]
	public static bool op_Inequality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6000031")]
	public void set_componentGlyphIDs(UInt32[] value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x6000033")]
	public void set_ligatureGlyphID(uint value) { }

}

