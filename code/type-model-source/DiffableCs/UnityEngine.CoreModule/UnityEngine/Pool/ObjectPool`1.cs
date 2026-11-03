namespace UnityEngine.Pool;

[Token(Token = "0x2000303")]
public class ObjectPool : IDisposable, IPool, IObjectPool<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F0")]
	internal readonly List<T> m_List; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F1")]
	private readonly Func<T> m_CreateFunc; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F2")]
	private readonly Action<T> m_ActionOnGet; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F3")]
	private readonly Action<T> m_ActionOnRelease; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F4")]
	private readonly Action<T> m_ActionOnDestroy; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F5")]
	private readonly int m_MaxSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F6")]
	internal bool m_CollectionCheck; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F7")]
	private T m_FreshlyReleased; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F8")]
	private int <CountAll>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000399")]
	public private int CountAll
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60018A2")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60018A3")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700039A")]
	public override int CountInactive
	{
		[Address(RVA = "0xE0D6D0", Offset = "0xE0CAD0", Length = "0x23")]
		[Token(Token = "0x60018A4")]
		 get { } //Length: 35
	}

	[Address(RVA = "0xE0D020", Offset = "0xE0C420", Length = "0x1E0")]
	[Token(Token = "0x60018A5")]
	public ObjectPool`1(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000) { }

	[Address(RVA = "0xE0BCA0", Offset = "0xE0B0A0", Length = "0x1B1")]
	[Token(Token = "0x60018A9")]
	public override void Clear() { }

	[Address(RVA = "0xE0BE60", Offset = "0xE0B260", Length = "0x17")]
	[Token(Token = "0x60018AA")]
	public override void Dispose() { }

	[Address(RVA = "0x7A9300", Offset = "0x7A8700", Length = "0x20E")]
	[Token(Token = "0x60018A6")]
	public override T Get() { }

	[Address(RVA = "0xE0C110", Offset = "0xE0B510", Length = "0x145")]
	[Token(Token = "0x60018A7")]
	public override PooledObject<T> Get(out T v) { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60018A2")]
	public int get_CountAll() { }

	[Address(RVA = "0xE0D6D0", Offset = "0xE0CAD0", Length = "0x23")]
	[Token(Token = "0x60018A4")]
	public override int get_CountInactive() { }

	[Address(RVA = "0xE0C9F0", Offset = "0xE0BDF0", Length = "0xD1")]
	[Token(Token = "0x60018A8")]
	public override void Release(T element) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60018A3")]
	private void set_CountAll(int value) { }

}

