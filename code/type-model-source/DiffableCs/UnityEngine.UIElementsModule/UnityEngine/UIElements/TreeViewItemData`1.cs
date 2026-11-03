namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000170")]
public struct TreeViewItemData
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000738")]
	private readonly int <id>k__BackingField; //Field offset: 0x0
	[CreateProperty]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000739")]
	private readonly T m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400073A")]
	private readonly IList<TreeViewItemData`1<T>> m_Children; //Field offset: 0x0

	[Token(Token = "0x170001EC")]
	public IEnumerable<TreeViewItemData`1<T>> children
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000B22")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001EB")]
	public T data
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6000B21")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001EA")]
	public int id
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6000B20")]
		 get { } //Length: 3
	}

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000B22")]
	public IEnumerable<TreeViewItemData`1<T>> get_children() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x6000B21")]
	public T get_data() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x6000B20")]
	public int get_id() { }

}

