namespace Unity.Collections;

[Token(Token = "0x20000AB")]
internal sealed class NativeParallelHashSetDebuggerTypeProxy
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003D0")]
	private NativeParallelHashSet<T> Data; //Field offset: 0x0

	[Token(Token = "0x170000EF")]
	public List<T> Items
	{
		[Address(RVA = "0xD8D6D0", Offset = "0xD8CAD0", Length = "0x218")]
		[Token(Token = "0x6000836")]
		 get { } //Length: 536
	}

	[Address(RVA = "0xB49C20", Offset = "0xB49020", Length = "0x29")]
	[Token(Token = "0x6000835")]
	public NativeParallelHashSetDebuggerTypeProxy`1(NativeParallelHashSet<T> data) { }

	[Address(RVA = "0xD8D6D0", Offset = "0xD8CAD0", Length = "0x218")]
	[Token(Token = "0x6000836")]
	public List<T> get_Items() { }

}

