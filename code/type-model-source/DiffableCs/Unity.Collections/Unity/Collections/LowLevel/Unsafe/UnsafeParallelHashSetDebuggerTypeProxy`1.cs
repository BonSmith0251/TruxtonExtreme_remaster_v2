namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000134")]
internal sealed class UnsafeParallelHashSetDebuggerTypeProxy
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400050A")]
	private UnsafeParallelHashSet<T> Data; //Field offset: 0x0

	[Token(Token = "0x17000188")]
	public List<T> Items
	{
		[Address(RVA = "0xD8D6D0", Offset = "0xD8CAD0", Length = "0x218")]
		[Token(Token = "0x6000CAF")]
		 get { } //Length: 536
	}

	[Address(RVA = "0xB49C20", Offset = "0xB49020", Length = "0x29")]
	[Token(Token = "0x6000CAE")]
	public UnsafeParallelHashSetDebuggerTypeProxy`1(UnsafeParallelHashSet<T> data) { }

	[Address(RVA = "0xD8D6D0", Offset = "0xD8CAD0", Length = "0x218")]
	[Token(Token = "0x6000CAF")]
	public List<T> get_Items() { }

}

