namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x200003B")]
public class LinkedListNodeCache
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000096")]
	private int m_maxNodesAllowed; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000097")]
	private int m_NodesCreated; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000098")]
	private Stack<LinkedListNode`1<T>> m_NodeCache; //Field offset: 0x0

	[Token(Token = "0x17000028")]
	internal int CachedNodeCount
	{
		[Address(RVA = "0xAFF420", Offset = "0xAFE820", Length = "0x12")]
		[Token(Token = "0x6000158")]
		internal get { } //Length: 18
		[Address(RVA = "0xAFF480", Offset = "0xAFE880", Length = "0x115")]
		[Token(Token = "0x6000159")]
		internal set { } //Length: 277
	}

	[Token(Token = "0x17000027")]
	internal int CreatedNodeCount
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000157")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0xAFF360", Offset = "0xAFE760", Length = "0x53")]
	[Token(Token = "0x6000152")]
	public LinkedListNodeCache`1() { }

	[Address(RVA = "0xAFF2F0", Offset = "0xAFE6F0", Length = "0x6A")]
	[Token(Token = "0x6000153")]
	public LinkedListNodeCache`1(int maxNodesAllowed, int initialCapacity, int initialPreallocateCount) { }

	[Address(RVA = "0xAFEAC0", Offset = "0xAFDEC0", Length = "0xDA")]
	[Token(Token = "0x6000155")]
	public LinkedListNode<T> Acquire(T val) { }

	[Address(RVA = "0xAFF420", Offset = "0xAFE820", Length = "0x12")]
	[Token(Token = "0x6000158")]
	internal int get_CachedNodeCount() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6000157")]
	internal int get_CreatedNodeCount() { }

	[Address(RVA = "0xAFED70", Offset = "0xAFE170", Length = "0x125")]
	[Token(Token = "0x6000154")]
	private void InitCache(int maxNodesAllowed = 2147483647, int initialCapacity = 10, int initialPreallocateCount = 0) { }

	[Address(RVA = "0xAFF200", Offset = "0xAFE600", Length = "0x76")]
	[Token(Token = "0x6000156")]
	public void Release(LinkedListNode<T> node) { }

	[Address(RVA = "0xAFF480", Offset = "0xAFE880", Length = "0x115")]
	[Token(Token = "0x6000159")]
	internal void set_CachedNodeCount(int value) { }

}

