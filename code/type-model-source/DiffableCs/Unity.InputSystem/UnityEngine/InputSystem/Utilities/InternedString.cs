namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000247")]
public struct InternedString : IEquatable<InternedString>, IComparable<InternedString>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C80")]
	private readonly string m_StringOriginalCase; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C81")]
	private readonly string m_StringLowerCase; //Field offset: 0x8

	[Token(Token = "0x170005F9")]
	public int length
	{
		[Address(RVA = "0x2919B10", Offset = "0x2918F10", Length = "0xE")]
		[Token(Token = "0x6001548")]
		 get { } //Length: 14
	}

	[Address(RVA = "0x2919A50", Offset = "0x2918E50", Length = "0xBF")]
	[Token(Token = "0x6001549")]
	public InternedString(string text) { }

	[Address(RVA = "0x2919890", Offset = "0x2918C90", Length = "0x16")]
	[Token(Token = "0x600154E")]
	public override int CompareTo(InternedString other) { }

	[Address(RVA = "0x29198B0", Offset = "0x2918CB0", Length = "0x12A")]
	[Token(Token = "0x600154C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x29199E0", Offset = "0x2918DE0", Length = "0xC")]
	[Token(Token = "0x600154D")]
	public override bool Equals(InternedString other) { }

	[Address(RVA = "0x2919B10", Offset = "0x2918F10", Length = "0xE")]
	[Token(Token = "0x6001548")]
	public int get_length() { }

	[Address(RVA = "0x29199F0", Offset = "0x2918DF0", Length = "0x22")]
	[Token(Token = "0x600154F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2919A20", Offset = "0x2918E20", Length = "0x9")]
	[Token(Token = "0x600154A")]
	public bool IsEmpty() { }

	[Address(RVA = "0x2919B20", Offset = "0x2918F20", Length = "0x20")]
	[Token(Token = "0x6001555")]
	public static bool op_Equality(string a, InternedString b) { }

	[Address(RVA = "0x29199E0", Offset = "0x2918DE0", Length = "0xC")]
	[Token(Token = "0x6001551")]
	public static bool op_Equality(InternedString a, InternedString b) { }

	[Address(RVA = "0x2919B40", Offset = "0x2918F40", Length = "0x20")]
	[Token(Token = "0x6001553")]
	public static bool op_Equality(InternedString a, string b) { }

	[Address(RVA = "0x2919B60", Offset = "0x2918F60", Length = "0x24")]
	[Token(Token = "0x6001558")]
	public static bool op_GreaterThan(InternedString left, InternedString right) { }

	[Address(RVA = "0x2919A30", Offset = "0x2918E30", Length = "0x1A")]
	[Token(Token = "0x6001559")]
	public static string op_Implicit(InternedString str) { }

	[Address(RVA = "0x2919BC0", Offset = "0x2918FC0", Length = "0x20")]
	[Token(Token = "0x6001554")]
	public static bool op_Inequality(InternedString a, string b) { }

	[Address(RVA = "0x2919BA0", Offset = "0x2918FA0", Length = "0x20")]
	[Token(Token = "0x6001556")]
	public static bool op_Inequality(string a, InternedString b) { }

	[Address(RVA = "0x2919B90", Offset = "0x2918F90", Length = "0xC")]
	[Token(Token = "0x6001552")]
	public static bool op_Inequality(InternedString a, InternedString b) { }

	[Address(RVA = "0x2919BE0", Offset = "0x2918FE0", Length = "0x22")]
	[Token(Token = "0x6001557")]
	public static bool op_LessThan(InternedString left, InternedString right) { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x600154B")]
	public string ToLower() { }

	[Address(RVA = "0x2919A30", Offset = "0x2918E30", Length = "0x1A")]
	[Token(Token = "0x6001550")]
	public virtual string ToString() { }

}

