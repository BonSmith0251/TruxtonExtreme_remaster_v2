namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x2000019")]
[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule", "UnityEditor.TextCoreTextEngineModule"})]
internal struct LigatureSubstitutionRecord : IEquatable<LigatureSubstitutionRecord>
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("componentGlyphs")]
	[SerializeField]
	[Token(Token = "0x400009B")]
	private UInt32[] m_ComponentGlyphIDs; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("ligatureGlyph")]
	[SerializeField]
	[Token(Token = "0x400009C")]
	private uint m_LigatureGlyphID; //Field offset: 0x8

	[Token(Token = "0x17000039")]
	public UInt32[] componentGlyphIDs
	{
		[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
		[Token(Token = "0x60000B8")]
		 get { } //Length: 6
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60000B9")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700003A")]
	public uint ligatureGlyphID
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x60000BA")]
		 get { } //Length: 6
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x60000BB")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x31719B0", Offset = "0x3170DB0", Length = "0xB0")]
	[Token(Token = "0x60000BC")]
	public override bool Equals(LigatureSubstitutionRecord other) { }

	[Address(RVA = "0x3171A70", Offset = "0x3170E70", Length = "0x90")]
	[Token(Token = "0x60000BD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x60000B8")]
	public UInt32[] get_componentGlyphIDs() { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x60000BA")]
	public uint get_ligatureGlyphID() { }

	[Address(RVA = "0x289C630", Offset = "0x289BA30", Length = "0x29")]
	[Token(Token = "0x60000BE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3171B10", Offset = "0x3170F10", Length = "0xD7")]
	[Token(Token = "0x60000BF")]
	public static bool op_Equality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x60000B9")]
	public void set_componentGlyphIDs(UInt32[] value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x60000BB")]
	public void set_ligatureGlyphID(uint value) { }

}

