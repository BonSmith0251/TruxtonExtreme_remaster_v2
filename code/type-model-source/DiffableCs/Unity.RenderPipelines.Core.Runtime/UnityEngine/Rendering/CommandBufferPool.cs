namespace UnityEngine.Rendering;

[Token(Token = "0x2000028")]
public static class CommandBufferPool
{
	[CompilerGenerated]
	[Token(Token = "0x2000029")]
	private sealed class <>c
	{
		[Token(Token = "0x40000AE")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x2BC5AD0", Offset = "0x2BC4ED0", Length = "0x67")]
		[Token(Token = "0x6000449")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600044A")]
		public <>c() { }

		[Address(RVA = "0x2BC5AB0", Offset = "0x2BC4EB0", Length = "0x1F")]
		[Token(Token = "0x600044B")]
		internal void <.cctor>b__4_0(CommandBuffer x) { }

	}

	[Token(Token = "0x40000AD")]
	private static ObjectPool<CommandBuffer> s_BufferPool; //Field offset: 0x0

	[Address(RVA = "0x2BBB540", Offset = "0x2BBA940", Length = "0x10B")]
	[Token(Token = "0x6000448")]
	private static CommandBufferPool() { }

	[Address(RVA = "0x2BBB370", Offset = "0x2BBA770", Length = "0xA3")]
	[Token(Token = "0x6000445")]
	public static CommandBuffer Get() { }

	[Address(RVA = "0x2BBB420", Offset = "0x2BBA820", Length = "0x99")]
	[Token(Token = "0x6000446")]
	public static CommandBuffer Get(string name) { }

	[Address(RVA = "0x2BBB4C0", Offset = "0x2BBA8C0", Length = "0x78")]
	[Token(Token = "0x6000447")]
	public static void Release(CommandBuffer buffer) { }

}

