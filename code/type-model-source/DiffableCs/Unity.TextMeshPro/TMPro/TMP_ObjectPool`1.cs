namespace TMPro;

[Token(Token = "0x200007D")]
internal class TMP_ObjectPool
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400034D")]
	private readonly Stack<T> m_Stack; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400034E")]
	private readonly UnityAction<T> m_ActionOnGet; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400034F")]
	private readonly UnityAction<T> m_ActionOnRelease; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000350")]
	private int <countAll>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170000DA")]
	public int countActive
	{
		[Address(RVA = "0xFDA8E0", Offset = "0xFD9CE0", Length = "0x1D")]
		[Token(Token = "0x600043B")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170000D9")]
	public private int countAll
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000439")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600043A")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170000DB")]
	public int countInactive
	{
		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x600043C")]
		 get { } //Length: 26
	}

	[Address(RVA = "0xFDA7F0", Offset = "0xFD9BF0", Length = "0xE1")]
	[Token(Token = "0x600043D")]
	public TMP_ObjectPool`1(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }

	[Address(RVA = "0xFDA220", Offset = "0xFD9620", Length = "0xF4")]
	[Token(Token = "0x600043E")]
	public T Get() { }

	[Address(RVA = "0xFDA8E0", Offset = "0xFD9CE0", Length = "0x1D")]
	[Token(Token = "0x600043B")]
	public int get_countActive() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000439")]
	public int get_countAll() { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x600043C")]
	public int get_countInactive() { }

	[Address(RVA = "0xFDA320", Offset = "0xFD9720", Length = "0x17E")]
	[Token(Token = "0x600043F")]
	public void Release(T element) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600043A")]
	private void set_countAll(int value) { }

}

