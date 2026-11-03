namespace UnityEngine.UIElements;

[Token(Token = "0x20002AE")]
internal class ObjectPool
{
	[CompilerGenerated]
	[Token(Token = "0x20002AF")]
	private sealed class <>c
	{
		[Token(Token = "0x4000AB9")]
		public static readonly <>c<T> <>9; //Field offset: 0x0
		[Token(Token = "0x4000ABA")]
		public static Func<T> <>9__6_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x600127B")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600127C")]
		public <>c() { }

		[Address(RVA = "0xA347A0", Offset = "0xA33BA0", Length = "0x14")]
		[Token(Token = "0x600127D")]
		internal T <.ctor>b__6_0() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB6")]
	private readonly Stack<T> m_Stack; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB7")]
	private int m_MaxSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB8")]
	internal Func<T> CreateFunc; //Field offset: 0x0

	[Token(Token = "0x17000384")]
	public int maxSize
	{
		[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
		[Token(Token = "0x6001275")]
		 get { } //Length: 6
		[Address(RVA = "0xE0D7F0", Offset = "0xE0CBF0", Length = "0xDB")]
		[Token(Token = "0x6001276")]
		 set { } //Length: 219
	}

	[Address(RVA = "0xE0D2E0", Offset = "0xE0C6E0", Length = "0x302")]
	[Token(Token = "0x6001277")]
	public ObjectPool`1(Func<T> CreateFunc, int maxSize = 100) { }

	[Address(RVA = "0xE0C0B0", Offset = "0xE0B4B0", Length = "0x55")]
	[Token(Token = "0x6001279")]
	public T Get() { }

	[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
	[Token(Token = "0x6001275")]
	public int get_maxSize() { }

	[Address(RVA = "0xE0C910", Offset = "0xE0BD10", Length = "0xD3")]
	[Token(Token = "0x600127A")]
	public void Release(T element) { }

	[Address(RVA = "0xE0D7F0", Offset = "0xE0CBF0", Length = "0xDB")]
	[Token(Token = "0x6001276")]
	public void set_maxSize(int value) { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x6001278")]
	public int Size() { }

}

