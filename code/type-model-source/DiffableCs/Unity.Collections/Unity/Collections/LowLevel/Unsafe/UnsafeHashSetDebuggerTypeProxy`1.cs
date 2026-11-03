namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000112")]
internal sealed class UnsafeHashSetDebuggerTypeProxy
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004BF")]
	private HashMapHelper<T> Data; //Field offset: 0x0

	[Token(Token = "0x1700015A")]
	public List<T> Items
	{
		[Address(RVA = "0x11A74B0", Offset = "0x11A68B0", Length = "0x218")]
		[Token(Token = "0x6000BA4")]
		 get { } //Length: 536
	}

	[Address(RVA = "0x11A5B80", Offset = "0x11A4F80", Length = "0x41")]
	[Token(Token = "0x6000BA3")]
	public UnsafeHashSetDebuggerTypeProxy`1(UnsafeHashSet<T> data) { }

	[Address(RVA = "0x11A74B0", Offset = "0x11A68B0", Length = "0x218")]
	[Token(Token = "0x6000BA4")]
	public List<T> get_Items() { }

}

