namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Keyboard (6))]
[Token(Token = "0x20001E1")]
internal class IMEEvent : EventBase<IMEEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001E2")]
	private sealed class <>c
	{
		[Token(Token = "0x400085F")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33E07D0", Offset = "0x33DFBD0", Length = "0x67")]
		[Token(Token = "0x6000D95")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000D96")]
		public <>c() { }

		[Address(RVA = "0x33DF2F0", Offset = "0x33DE6F0", Length = "0xA0")]
		[Token(Token = "0x6000D97")]
		internal IMEEvent <.cctor>b__4_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400085E")]
	private string <compositionString>k__BackingField; //Field offset: 0x68

	[Token(Token = "0x17000261")]
	protected string compositionString
	{
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000D8F")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x33D13A0", Offset = "0x33D07A0", Length = "0xD1")]
	[Token(Token = "0x6000D90")]
	private static IMEEvent() { }

	[Address(RVA = "0x33D1480", Offset = "0x33D0880", Length = "0x74")]
	[Token(Token = "0x6000D94")]
	public IMEEvent() { }

	[Address(RVA = "0x33D1290", Offset = "0x33D0690", Length = "0x81")]
	[Token(Token = "0x6000D91")]
	public static IMEEvent GetPooled(string compositionString) { }

	[Address(RVA = "0x33D1320", Offset = "0x33D0720", Length = "0x53")]
	[Token(Token = "0x6000D92")]
	protected virtual void Init() { }

	[Address(RVA = "0x33D1380", Offset = "0x33D0780", Length = "0x1A")]
	[Token(Token = "0x6000D93")]
	private void LocalInit() { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000D8F")]
	protected void set_compositionString(string value) { }

}

