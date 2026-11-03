namespace UnityEngine.Rendering;

[Token(Token = "0x20001A5")]
internal class AtlasAllocator
{
	[CompilerGenerated]
	[Token(Token = "0x20001A7")]
	private sealed class <>c
	{
		[Token(Token = "0x400081D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400081E")]
		public static UnityAction<AtlasNode> <>9__6_0; //Field offset: 0x8
		[Token(Token = "0x400081F")]
		public static UnityAction<AtlasNode> <>9__6_1; //Field offset: 0x10

		[Address(RVA = "0x2C53CA0", Offset = "0x2C530A0", Length = "0x67")]
		[Token(Token = "0x6000C7E")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C7F")]
		public <>c() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000C80")]
		internal void <.ctor>b__6_0(AtlasNode _) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000C81")]
		internal void <.ctor>b__6_1(AtlasNode _) { }

	}

	[Token(Token = "0x20001A6")]
	private class AtlasNode
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400081A")]
		public AtlasNode m_RightChild; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400081B")]
		public AtlasNode m_BottomChild; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400081C")]
		public Vector4 m_Rect; //Field offset: 0x20

		[Address(RVA = "0x2C39D30", Offset = "0x2C39130", Length = "0xE")]
		[Token(Token = "0x6000C7D")]
		public AtlasNode() { }

		[Address(RVA = "0x2C398F0", Offset = "0x2C38CF0", Length = "0x344")]
		[Token(Token = "0x6000C7B")]
		public AtlasNode Allocate(ref ObjectPool<AtlasNode>& pool, int width, int height, bool powerOfTwoPadding) { }

		[Address(RVA = "0x2C39C40", Offset = "0x2C39040", Length = "0xEF")]
		[Token(Token = "0x6000C7C")]
		public void Release(ref ObjectPool<AtlasNode>& pool) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000815")]
	private AtlasNode m_Root; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000816")]
	private int m_Width; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000817")]
	private int m_Height; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000818")]
	private bool powerOfTwoPadding; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000819")]
	private ObjectPool<AtlasNode> m_NodePool; //Field offset: 0x28

	[Address(RVA = "0x2C39660", Offset = "0x2C38A60", Length = "0x288")]
	[Token(Token = "0x6000C78")]
	public AtlasAllocator(int width, int height, bool potPadding) { }

	[Address(RVA = "0x2C39580", Offset = "0x2C38980", Length = "0x7F")]
	[Token(Token = "0x6000C79")]
	public bool Allocate(ref Vector4 result, int width, int height) { }

	[Address(RVA = "0x2C39600", Offset = "0x2C38A00", Length = "0x54")]
	[Token(Token = "0x6000C7A")]
	public void Reset() { }

}

