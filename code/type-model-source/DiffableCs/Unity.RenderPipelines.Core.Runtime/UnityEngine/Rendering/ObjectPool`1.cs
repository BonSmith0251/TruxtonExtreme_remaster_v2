namespace UnityEngine.Rendering;

[Token(Token = "0x2000053")]
public class ObjectPool
{
	[Token(Token = "0x2000054")]
	internal struct PooledObject : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000140")]
		private readonly T m_ToReturn; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000141")]
		private readonly ObjectPool<T> m_Pool; //Field offset: 0x0

		[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
		[Token(Token = "0x6000524")]
		internal PooledObject(T value, ObjectPool<T> pool) { }

		[Address(RVA = "0xE28C20", Offset = "0xE28020", Length = "0x50")]
		[Token(Token = "0x6000525")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013B")]
	private readonly Stack<T> m_Stack; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013C")]
	private readonly UnityAction<T> m_ActionOnGet; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013D")]
	private readonly UnityAction<T> m_ActionOnRelease; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013E")]
	private readonly bool m_CollectionCheck; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013F")]
	private int <countAll>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000041")]
	public int countActive
	{
		[Address(RVA = "0xE0D760", Offset = "0xE0CB60", Length = "0x1D")]
		[Token(Token = "0x600051E")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000040")]
	public private int countAll
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600051C")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600051D")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000042")]
	public int countInactive
	{
		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x600051F")]
		 get { } //Length: 26
	}

	[Address(RVA = "0xE0D210", Offset = "0xE0C610", Length = "0xC7")]
	[Token(Token = "0x6000520")]
	public ObjectPool`1(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease, bool collectionCheck = true) { }

	[Address(RVA = "0xE0C520", Offset = "0xE0B920", Length = "0x7C")]
	[Token(Token = "0x6000521")]
	public T Get() { }

	[Address(RVA = "0xE0C260", Offset = "0xE0B660", Length = "0xE8")]
	[Token(Token = "0x6000522")]
	public PooledObject<T> Get(out T v) { }

	[Address(RVA = "0xE0D760", Offset = "0xE0CB60", Length = "0x1D")]
	[Token(Token = "0x600051E")]
	public int get_countActive() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600051C")]
	public int get_countAll() { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x600051F")]
	public int get_countInactive() { }

	[Address(RVA = "0xE0CD30", Offset = "0xE0C130", Length = "0x68")]
	[Token(Token = "0x6000523")]
	public void Release(T element) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600051D")]
	private void set_countAll(int value) { }

}

