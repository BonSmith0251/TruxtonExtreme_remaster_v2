namespace UnityEngine.InputSystem.Utilities;

[DefaultMember("Item")]
[Token(Token = "0x200026E")]
internal struct Substring : IComparable<Substring>, IEquatable<Substring>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CF4")]
	private readonly string m_String; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000CF5")]
	private readonly int m_Index; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000CF6")]
	private readonly int m_Length; //Field offset: 0xC

	[Token(Token = "0x17000614")]
	public int index
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60016AF")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000612")]
	public bool isEmpty
	{
		[Address(RVA = "0x2929380", Offset = "0x2928780", Length = "0x8")]
		[Token(Token = "0x6001699")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000615")]
	public char Item
	{
		[Address(RVA = "0x2929300", Offset = "0x2928700", Length = "0x7E")]
		[Token(Token = "0x60016B0")]
		 get { } //Length: 126
	}

	[Token(Token = "0x17000613")]
	public int length
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x60016AE")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2929270", Offset = "0x2928670", Length = "0x38")]
	[Token(Token = "0x600169A")]
	public Substring(string str) { }

	[Address(RVA = "0xD0EDF0", Offset = "0xD0E1F0", Length = "0x36")]
	[Token(Token = "0x600169B")]
	public Substring(string str, int index, int length) { }

	[Address(RVA = "0x29292B0", Offset = "0x29286B0", Length = "0x45")]
	[Token(Token = "0x600169C")]
	public Substring(string str, int index) { }

	[Address(RVA = "0x2928D80", Offset = "0x2928180", Length = "0x4A")]
	[Token(Token = "0x60016A2")]
	public static int Compare(Substring left, Substring right, StringComparison comparison) { }

	[Address(RVA = "0x2928D00", Offset = "0x2928100", Length = "0x7B")]
	[Token(Token = "0x60016A1")]
	public override int CompareTo(Substring other) { }

	[Address(RVA = "0x2928E70", Offset = "0x2928270", Length = "0x149")]
	[Token(Token = "0x600169D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2929050", Offset = "0x2928450", Length = "0xA3")]
	[Token(Token = "0x600169E")]
	public bool Equals(string other) { }

	[Address(RVA = "0x2928FC0", Offset = "0x29283C0", Length = "0x8E")]
	[Token(Token = "0x600169F")]
	public override bool Equals(Substring other) { }

	[Address(RVA = "0x2928DD0", Offset = "0x29281D0", Length = "0x91")]
	[Token(Token = "0x60016A0")]
	public bool Equals(InternedString other) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60016AF")]
	public int get_index() { }

	[Address(RVA = "0x2929380", Offset = "0x2928780", Length = "0x8")]
	[Token(Token = "0x6001699")]
	public bool get_isEmpty() { }

	[Address(RVA = "0x2929300", Offset = "0x2928700", Length = "0x7E")]
	[Token(Token = "0x60016B0")]
	public char get_Item(int index) { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[Token(Token = "0x60016AE")]
	public int get_length() { }

	[Address(RVA = "0x2929100", Offset = "0x2928500", Length = "0x79")]
	[Token(Token = "0x60016A6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2928FC0", Offset = "0x29283C0", Length = "0x8E")]
	[Token(Token = "0x60016A7")]
	public static bool op_Equality(Substring a, Substring b) { }

	[Address(RVA = "0x2929400", Offset = "0x2928800", Length = "0x6A")]
	[Token(Token = "0x60016A9")]
	public static bool op_Equality(Substring a, InternedString b) { }

	[Address(RVA = "0x2929390", Offset = "0x2928790", Length = "0x6A")]
	[Token(Token = "0x60016AB")]
	public static bool op_Equality(InternedString a, Substring b) { }

	[Address(RVA = "0x2929470", Offset = "0x2928870", Length = "0x51")]
	[Token(Token = "0x60016AD")]
	public static Substring op_Implicit(string s) { }

	[Address(RVA = "0x29294D0", Offset = "0x29288D0", Length = "0x8E")]
	[Token(Token = "0x60016A8")]
	public static bool op_Inequality(Substring a, Substring b) { }

	[Address(RVA = "0x2929560", Offset = "0x2928960", Length = "0x76")]
	[Token(Token = "0x60016AA")]
	public static bool op_Inequality(Substring a, InternedString b) { }

	[Address(RVA = "0x29295E0", Offset = "0x29289E0", Length = "0x76")]
	[Token(Token = "0x60016AC")]
	public static bool op_Inequality(InternedString a, Substring b) { }

	[Address(RVA = "0x2929180", Offset = "0x2928580", Length = "0x85")]
	[Token(Token = "0x60016A3")]
	public bool StartsWith(string str) { }

	[Address(RVA = "0x2929210", Offset = "0x2928610", Length = "0x2F")]
	[Token(Token = "0x60016A4")]
	public string Substr(int index = 0, int length = -1) { }

	[Address(RVA = "0x2929240", Offset = "0x2928640", Length = "0x2A")]
	[Token(Token = "0x60016A5")]
	public virtual string ToString() { }

}

