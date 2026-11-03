namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A8")]
internal class LinkedPool
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013BF")]
	private readonly Func<T> m_CreateFunc; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013C0")]
	private readonly Action<T> m_ResetAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013C1")]
	private readonly int m_Limit; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013C2")]
	private T m_PoolFirst; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013C3")]
	private int <Count>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000A4D")]
	public private int Count
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60028CE")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60028CF")]
		private set { } //Length: 4
	}

	[Address(RVA = "0xB09FC0", Offset = "0xB093C0", Length = "0xAC")]
	[Token(Token = "0x60028CD")]
	public LinkedPool`1(Func<T> createFunc, Action<T> resetAction, int limit = 10000) { }

	[Address(RVA = "0xB09ED0", Offset = "0xB092D0", Length = "0xA")]
	[Token(Token = "0x60028D0")]
	public void Clear() { }

	[Address(RVA = "0xB09EE0", Offset = "0xB092E0", Length = "0x7A")]
	[Token(Token = "0x60028D1")]
	public T Get() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60028CE")]
	public int get_Count() { }

	[Address(RVA = "0xB09F60", Offset = "0xB09360", Length = "0x51")]
	[Token(Token = "0x60028D2")]
	public void Return(T item) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60028CF")]
	private void set_Count(int value) { }

}

