namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000270")]
internal struct TypeTable
{
	[CompilerGenerated]
	[Token(Token = "0x2000271")]
	private sealed class <>c
	{
		[Token(Token = "0x4000CF9")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000CFA")]
		public static Func<InternedString, String> <>9__2_0; //Field offset: 0x8

		[Address(RVA = "0x292B220", Offset = "0x292A620", Length = "0x67")]
		[Token(Token = "0x60016BD")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60016BE")]
		public <>c() { }

		[Address(RVA = "0x292B190", Offset = "0x292A590", Length = "0x13")]
		[Token(Token = "0x60016BF")]
		internal string <get_names>b__2_0(InternedString x) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CF7")]
	public Dictionary<InternedString, Type> table; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000CF8")]
	private InputManager m_Manager; //Field offset: 0x8

	[Token(Token = "0x17000617")]
	public IEnumerable<InternedString> internedNames
	{
		[Address(RVA = "0x292A920", Offset = "0x2929D20", Length = "0x43")]
		[Token(Token = "0x60016B7")]
		 get { } //Length: 67
	}

	[Token(Token = "0x17000616")]
	public IEnumerable<String> names
	{
		[Address(RVA = "0x292A970", Offset = "0x2929D70", Length = "0x140")]
		[Token(Token = "0x60016B6")]
		 get { } //Length: 320
	}

	[Address(RVA = "0x292A380", Offset = "0x2929780", Length = "0x168")]
	[Token(Token = "0x60016BA")]
	public void AddTypeRegistration(string name, Type type) { }

	[Address(RVA = "0x292A4F0", Offset = "0x29298F0", Length = "0x21C")]
	[Token(Token = "0x60016B9")]
	public InternedString FindNameForType(Type type) { }

	[Address(RVA = "0x292A920", Offset = "0x2929D20", Length = "0x43")]
	[Token(Token = "0x60016B7")]
	public IEnumerable<InternedString> get_internedNames() { }

	[Address(RVA = "0x292A970", Offset = "0x2929D70", Length = "0x140")]
	[Token(Token = "0x60016B6")]
	public IEnumerable<String> get_names() { }

	[Address(RVA = "0x292A710", Offset = "0x2929B10", Length = "0x88")]
	[Token(Token = "0x60016B8")]
	public void Initialize(InputManager manager) { }

	[Address(RVA = "0x292A7A0", Offset = "0x2929BA0", Length = "0xB7")]
	[Token(Token = "0x60016BB")]
	public Type LookupTypeRegistration(string name) { }

	[Address(RVA = "0x292A860", Offset = "0x2929C60", Length = "0xB0")]
	[Token(Token = "0x60016BC")]
	private Type TryLookupTypeRegistration(InternedString internedName) { }

}

