namespace UnityEngine.UIElements;

[EventCategory(EventCategory::ChangeValue (9))]
[Token(Token = "0x20001BC")]
public class ChangeEvent : EventBase<ChangeEvent`1<T>>
{
	[CompilerGenerated]
	[Token(Token = "0x20001BD")]
	private sealed class <>c
	{
		[Token(Token = "0x4000803")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000C99")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C9A")]
		public <>c() { }

		[Address(RVA = "0xA35930", Offset = "0xA34D30", Length = "0x5D")]
		[Token(Token = "0x6000C9B")]
		internal ChangeEvent<T> <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000801")]
	private T <previousValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000802")]
	private T <newValue>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700023E")]
	public T newValue
	{
		[Address(RVA = "0x16D07D0", Offset = "0x16CFBD0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C93")]
		 get { } //Length: 5
		[Address(RVA = "0x16D0A60", Offset = "0x16CFE60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C94")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700023D")]
	public T previousValue
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C91")]
		 get { } //Length: 5
		[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C92")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x16CFF50", Offset = "0x16CF350", Length = "0x19C")]
	[Token(Token = "0x6000C90")]
	private static ChangeEvent`1() { }

	[Address(RVA = "0x16D06B0", Offset = "0x16CFAB0", Length = "0x7A")]
	[Token(Token = "0x6000C98")]
	public ChangeEvent`1() { }

	[Address(RVA = "0x16D07D0", Offset = "0x16CFBD0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C93")]
	public T get_newValue() { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C91")]
	public T get_previousValue() { }

	[Address(RVA = "0x16CEC50", Offset = "0x16CE050", Length = "0xD5")]
	[Token(Token = "0x6000C97")]
	public static ChangeEvent<T> GetPooled(T previousValue, T newValue) { }

	[Address(RVA = "0x16CF990", Offset = "0x16CED90", Length = "0x3A")]
	[Token(Token = "0x6000C95")]
	protected virtual void Init() { }

	[Address(RVA = "0x16CFCE0", Offset = "0x16CF0E0", Length = "0x20")]
	[Token(Token = "0x6000C96")]
	private void LocalInit() { }

	[Address(RVA = "0x16D0A60", Offset = "0x16CFE60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C94")]
	protected void set_newValue(T value) { }

	[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C92")]
	protected void set_previousValue(T value) { }

}

