namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000213")]
internal sealed class PooledDelegate : ITaskPoolNode<PooledDelegate`1<T>>
{
	[CompilerGenerated]
	[Token(Token = "0x2000214")]
	private sealed class <>c
	{
		[Token(Token = "0x40005CD")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000C2B")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C2C")]
		public <>c() { }

		[Address(RVA = "0xA35A50", Offset = "0xA34E50", Length = "0x77")]
		[Token(Token = "0x6000C2D")]
		internal int <.cctor>b__4_0() { }

	}

	[Token(Token = "0x40005C9")]
	private static TaskPool<PooledDelegate`1<T>> pool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005CA")]
	private PooledDelegate<T> nextNode; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005CB")]
	private readonly Action<T> runDelegate; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005CC")]
	private Action continuation; //Field offset: 0x0

	[Token(Token = "0x1700006F")]
	public override PooledDelegate<T>& NextNode
	{
		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x6000C26")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xE28690", Offset = "0xE27A90", Length = "0x172")]
	[Token(Token = "0x6000C27")]
	private static PooledDelegate`1() { }

	[Address(RVA = "0xE28A20", Offset = "0xE27E20", Length = "0x84")]
	[Token(Token = "0x6000C28")]
	private PooledDelegate`1() { }

	[Address(RVA = "0xE27FB0", Offset = "0xE273B0", Length = "0x1D9")]
	[Token(Token = "0x6000C29")]
	public static Action<T> Create(Action continuation) { }

	[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
	[Token(Token = "0x6000C26")]
	public override PooledDelegate<T>& get_NextNode() { }

	[Address(RVA = "0xE28450", Offset = "0xE27850", Length = "0xC0")]
	[Token(Token = "0x6000C2A")]
	private void Run(T _) { }

}

