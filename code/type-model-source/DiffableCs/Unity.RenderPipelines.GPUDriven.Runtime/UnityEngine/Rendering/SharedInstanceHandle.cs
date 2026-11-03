namespace UnityEngine.Rendering;

[Token(Token = "0x2000074")]
internal struct SharedInstanceHandle : IEquatable<SharedInstanceHandle>, IComparable<SharedInstanceHandle>
{
	[Token(Token = "0x400020D")]
	public static readonly SharedInstanceHandle Invalid; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400020C")]
	private int <index>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000034")]
	public int index
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60001F5")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x60001F6")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000035")]
	public bool valid
	{
		[Address(RVA = "0x2CF07B0", Offset = "0x2CEFBB0", Length = "0x46")]
		[Token(Token = "0x60001F7")]
		 get { } //Length: 70
	}

	[Address(RVA = "0x2CF0770", Offset = "0x2CEFB70", Length = "0x39")]
	[Token(Token = "0x60001FB")]
	private static SharedInstanceHandle() { }

	[Address(RVA = "0x2CF0660", Offset = "0x2CEFA60", Length = "0x68")]
	[Token(Token = "0x60001F9")]
	public override int CompareTo(SharedInstanceHandle other) { }

	[Address(RVA = "0x2CF06D0", Offset = "0x2CEFAD0", Length = "0x50")]
	[Token(Token = "0x60001F8")]
	public override bool Equals(SharedInstanceHandle other) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60001F5")]
	public int get_index() { }

	[Address(RVA = "0x2CF07B0", Offset = "0x2CEFBB0", Length = "0x46")]
	[Token(Token = "0x60001F7")]
	public bool get_valid() { }

	[Address(RVA = "0x2CF0720", Offset = "0x2CEFB20", Length = "0x42")]
	[Token(Token = "0x60001FA")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x60001F6")]
	public void set_index(int value) { }

}

