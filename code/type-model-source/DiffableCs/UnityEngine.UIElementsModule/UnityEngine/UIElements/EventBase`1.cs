namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Default (0))]
[Token(Token = "0x20001C7")]
public abstract class EventBase : EventBase
{
	[CompilerGenerated]
	[Token(Token = "0x20001C8")]
	private sealed class <>c
	{
		[Token(Token = "0x400082F")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000D03")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000D04")]
		public <>c() { }

		[Address(RVA = "0xA347A0", Offset = "0xA33BA0", Length = "0x14")]
		[Token(Token = "0x6000D05")]
		internal T <.cctor>b__15_0() { }

	}

	[Token(Token = "0x400082B")]
	private static readonly long s_TypeId; //Field offset: 0x0
	[Token(Token = "0x400082C")]
	private static readonly ObjectPool<T> s_Pool; //Field offset: 0x0
	[Token(Token = "0x400082E")]
	internal static readonly EventCategory EventCategory; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400082D")]
	private int m_RefCount; //Field offset: 0x0

	[Token(Token = "0x1700025A")]
	public virtual long eventTypeId
	{
		[Address(RVA = "0x1BABB70", Offset = "0x1BAAF70", Length = "0x77")]
		[Token(Token = "0x6000D01")]
		 get { } //Length: 119
	}

	[Address(RVA = "0x1BAB7B0", Offset = "0x1BAABB0", Length = "0x325")]
	[Token(Token = "0x6000D02")]
	private static EventBase`1() { }

	[Address(RVA = "0x1BABAE0", Offset = "0x1BAAEE0", Length = "0x88")]
	[Token(Token = "0x6000CF9")]
	protected EventBase`1() { }

	[Address(RVA = "0x1BAB0F0", Offset = "0x1BAA4F0", Length = "0x4")]
	[Token(Token = "0x6000CFF")]
	internal virtual void Acquire() { }

	[Address(RVA = "0x1BAB100", Offset = "0x1BAA500", Length = "0x19D")]
	[Token(Token = "0x6000D00")]
	public virtual void Dispose() { }

	[Address(RVA = "0x1BABB70", Offset = "0x1BAAF70", Length = "0x77")]
	[Token(Token = "0x6000D01")]
	public virtual long get_eventTypeId() { }

	[Address(RVA = "0x1BAB2A0", Offset = "0x1BAA6A0", Length = "0x10D")]
	[Token(Token = "0x6000CFC")]
	public static T GetPooled() { }

	[Address(RVA = "0x1BAB3B0", Offset = "0x1BAA7B0", Length = "0x194")]
	[Token(Token = "0x6000CFD")]
	internal static T GetPooled(EventBase e) { }

	[Address(RVA = "0x1BAB550", Offset = "0x1BAA950", Length = "0x7B")]
	[Token(Token = "0x6000CFB")]
	protected virtual void Init() { }

	[Address(RVA = "0x1BAB5D0", Offset = "0x1BAA9D0", Length = "0x113")]
	[Token(Token = "0x6000CFE")]
	private static void ReleasePooled(T evt) { }

	[Address(RVA = "0x1BAB6F0", Offset = "0x1BAAAF0", Length = "0xB2")]
	[Token(Token = "0x6000CF8")]
	protected private static void SetCreateFunction(Func<T> createMethod) { }

	[Address(RVA = "0xCF0DA0", Offset = "0xCF01A0", Length = "0x99")]
	[Token(Token = "0x6000CFA")]
	public static long TypeId() { }

}

