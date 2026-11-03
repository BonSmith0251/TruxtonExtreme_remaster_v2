namespace Unity.Collections;

[Token(Token = "0x2000097")]
internal sealed class NativeHashSetDebuggerTypeProxy
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003BF")]
	private HashMapHelper<T>* Data; //Field offset: 0x0

	[Token(Token = "0x170000CB")]
	public List<T> Items
	{
		[Address(RVA = "0xD6BCB0", Offset = "0xD6B0B0", Length = "0x22B")]
		[Token(Token = "0x600077D")]
		 get { } //Length: 555
	}

	[Address(RVA = "0xD69A70", Offset = "0xD68E70", Length = "0x26")]
	[Token(Token = "0x600077C")]
	public NativeHashSetDebuggerTypeProxy`1(NativeHashSet<T> data) { }

	[Address(RVA = "0xD6BCB0", Offset = "0xD6B0B0", Length = "0x22B")]
	[Token(Token = "0x600077D")]
	public List<T> get_Items() { }

}

