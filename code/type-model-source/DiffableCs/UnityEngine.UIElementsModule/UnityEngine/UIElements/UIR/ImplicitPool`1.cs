namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A1")]
internal class ImplicitPool
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400138A")]
	private readonly int m_StartCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400138B")]
	private readonly int m_MaxCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400138C")]
	private Func<T> m_CreateAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400138D")]
	private Action<T> m_ResetAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400138E")]
	private List<T> m_List; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400138F")]
	private int m_UsedCount; //Field offset: 0x0

	[Address(RVA = "0x1C74ED0", Offset = "0x1C742D0", Length = "0x13B")]
	[Token(Token = "0x60028B6")]
	public ImplicitPool`1(Func<T> createAction, Action<T> resetAction, int startCapacity, int maxCapacity) { }

	[Address(RVA = "0x1C74C00", Offset = "0x1C74000", Length = "0x1D9")]
	[Token(Token = "0x60028B7")]
	public T Get() { }

	[Address(RVA = "0x1C74DE0", Offset = "0x1C741E0", Length = "0xE2")]
	[Token(Token = "0x60028B8")]
	public void ReturnAll() { }

}

