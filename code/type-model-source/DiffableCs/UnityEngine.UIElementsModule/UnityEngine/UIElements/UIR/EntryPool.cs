namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000595")]
internal class EntryPool
{
	[CompilerGenerated]
	[Token(Token = "0x2000596")]
	private sealed class <>c
	{
		[Token(Token = "0x400131F")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x3302830", Offset = "0x3301C30", Length = "0x67")]
		[Token(Token = "0x6002868")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002869")]
		public <>c() { }

		[Address(RVA = "0x3302670", Offset = "0x3301A70", Length = "0x44")]
		[Token(Token = "0x600286A")]
		internal Entry <.cctor>b__8_0() { }

		[Address(RVA = "0x33026C0", Offset = "0x3301AC0", Length = "0xAA")]
		[Token(Token = "0x600286B")]
		internal void <.cctor>b__8_1(Entry e) { }

	}

	[Token(Token = "0x400131A")]
	private const int k_StackSize = 128; //Field offset: 0x0
	[Token(Token = "0x400131D")]
	private static readonly Func<Entry> k_CreateAction; //Field offset: 0x0
	[Token(Token = "0x400131E")]
	private static readonly Action<Entry> k_ResetAction; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400131B")]
	private Stack<Entry>[] m_ThreadEntries; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400131C")]
	private ImplicitPool<Entry> m_SharedPool; //Field offset: 0x18

	[Address(RVA = "0x32F2140", Offset = "0x32F1540", Length = "0x141")]
	[Token(Token = "0x6002867")]
	private static EntryPool() { }

	[Address(RVA = "0x32F2290", Offset = "0x32F1690", Length = "0x1F6")]
	[Token(Token = "0x6002864")]
	public EntryPool(int maxCapacity = 1024) { }

	[Address(RVA = "0x32F1DE0", Offset = "0x32F11E0", Length = "0x285")]
	[Token(Token = "0x6002865")]
	public Entry Get() { }

	[Address(RVA = "0x32F2070", Offset = "0x32F1470", Length = "0xCA")]
	[Token(Token = "0x6002866")]
	public void ReturnAll() { }

}

