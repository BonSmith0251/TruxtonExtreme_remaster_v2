namespace UnityEngine.InputForUI;

[Token(Token = "0x2000005")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct Event : IEventProperties
{
	[Token(Token = "0x2000007")]
	private interface IMapFn
	{

		[Token(Token = "0x600001E")]
		public TOutputType Map(ref TEventType ev) { }

	}

	[Token(Token = "0x200000A")]
	private struct MapAsEventModifiers : IMapFn<EventModifiers>
	{

		[Address(RVA = "0x9F1EF0", Offset = "0x9F12F0", Length = "0x2A")]
		[Token(Token = "0x6000021")]
		public override EventModifiers Map(ref TEventType ev) { }

	}

	[Token(Token = "0x2000009")]
	private struct MapAsEventSource : IMapFn<EventSource>
	{

		[Address(RVA = "0x9F2080", Offset = "0x9F1480", Length = "0x2A")]
		[Token(Token = "0x6000020")]
		public override EventSource Map(ref TEventType ev) { }

	}

	[Token(Token = "0x2000008")]
	private struct MapAsObject : IMapFn<IEventProperties>
	{

		[Address(RVA = "0x9F2110", Offset = "0x9F1510", Length = "0x4D")]
		[Token(Token = "0x600001F")]
		public override IEventProperties Map(ref TEventType ev) { }

	}

	[Token(Token = "0x2000006")]
	internal enum Type : int
	{
		Invalid = 0,
		KeyEvent = 1,
		PointerEvent = 2,
		TextInputEvent = 3,
		IMECompositionEvent = 4,
		CommandEvent = 5,
		NavigationEvent = 6,
	}

	[Token(Token = "0x4000023")]
	public static Type[] TypesWithState; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000024")]
	private Type _type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000025")]
	private object _managedEvent; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000026")]
	private KeyEvent _keyEvent; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000027")]
	private PointerEvent _pointerEvent; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000028")]
	private TextInputEvent _textInputEvent; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000029")]
	private CommandEvent _commandEvent; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002A")]
	private NavigationEvent _navigationEvent; //Field offset: 0x10

	[Token(Token = "0x1700000D")]
	public CommandEvent asCommandEvent
	{
		[Address(RVA = "0x3109260", Offset = "0x3108660", Length = "0x78")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 120
	}

	[Token(Token = "0x1700000C")]
	public IMECompositionEvent asIMECompositionEvent
	{
		[Address(RVA = "0x31092E0", Offset = "0x31086E0", Length = "0xB3")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 179
	}

	[Token(Token = "0x17000009")]
	public KeyEvent asKeyEvent
	{
		[Address(RVA = "0x31093A0", Offset = "0x31087A0", Length = "0x9F")]
		[Token(Token = "0x6000010")]
		 get { } //Length: 159
	}

	[Token(Token = "0x1700000E")]
	public NavigationEvent asNavigationEvent
	{
		[Address(RVA = "0x3109440", Offset = "0x3108840", Length = "0x87")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000006")]
	private IEventProperties asObject
	{
		[Address(RVA = "0x31094D0", Offset = "0x31088D0", Length = "0x5A")]
		[Token(Token = "0x600000A")]
		private get { } //Length: 90
	}

	[Token(Token = "0x1700000A")]
	public PointerEvent asPointerEvent
	{
		[Address(RVA = "0x3109530", Offset = "0x3108930", Length = "0xC3")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 195
	}

	[Token(Token = "0x1700000B")]
	public TextInputEvent asTextInputEvent
	{
		[Address(RVA = "0x3109600", Offset = "0x3108A00", Length = "0x78")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 120
	}

	[Token(Token = "0x17000008")]
	public override EventModifiers eventModifiers
	{
		[Address(RVA = "0x3109680", Offset = "0x3108A80", Length = "0x5A")]
		[Token(Token = "0x600000C")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000007")]
	public override EventSource eventSource
	{
		[Address(RVA = "0x31096E0", Offset = "0x3108AE0", Length = "0x5A")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000005")]
	public Type type
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6000009")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x31091D0", Offset = "0x31085D0", Length = "0x8C")]
	[Token(Token = "0x600001D")]
	private static Event() { }

	[Address(RVA = "0x3108960", Offset = "0x3107D60", Length = "0x162")]
	[Token(Token = "0x6000008")]
	internal static int CompareType(Event a, Event b) { }

	[Address(RVA = "0x3108AD0", Offset = "0x3107ED0", Length = "0x79")]
	[Token(Token = "0x600000D")]
	private void Ensure(Type t) { }

	[Address(RVA = "0x3108F00", Offset = "0x3108300", Length = "0x9B")]
	[Token(Token = "0x6000013")]
	public static Event From(TextInputEvent textInputEvent) { }

	[Address(RVA = "0x3108C80", Offset = "0x3108080", Length = "0xA4")]
	[Token(Token = "0x6000019")]
	public static Event From(NavigationEvent navigationEvent) { }

	[Address(RVA = "0x3108DC0", Offset = "0x31081C0", Length = "0x98")]
	[Token(Token = "0x600000F")]
	public static Event From(KeyEvent keyEvent) { }

	[Address(RVA = "0x3108D30", Offset = "0x3108130", Length = "0x8C")]
	[Token(Token = "0x6000011")]
	public static Event From(PointerEvent pointerEvent) { }

	[Address(RVA = "0x3108E60", Offset = "0x3108260", Length = "0x9B")]
	[Token(Token = "0x6000017")]
	public static Event From(CommandEvent commandEvent) { }

	[Address(RVA = "0x3108B50", Offset = "0x3107F50", Length = "0x123")]
	[Token(Token = "0x6000015")]
	public static Event From(IMECompositionEvent imeCompositionEvent) { }

	[Address(RVA = "0x3109260", Offset = "0x3108660", Length = "0x78")]
	[Token(Token = "0x6000018")]
	public CommandEvent get_asCommandEvent() { }

	[Address(RVA = "0x31092E0", Offset = "0x31086E0", Length = "0xB3")]
	[Token(Token = "0x6000016")]
	public IMECompositionEvent get_asIMECompositionEvent() { }

	[Address(RVA = "0x31093A0", Offset = "0x31087A0", Length = "0x9F")]
	[Token(Token = "0x6000010")]
	public KeyEvent get_asKeyEvent() { }

	[Address(RVA = "0x3109440", Offset = "0x3108840", Length = "0x87")]
	[Token(Token = "0x600001A")]
	public NavigationEvent get_asNavigationEvent() { }

	[Address(RVA = "0x31094D0", Offset = "0x31088D0", Length = "0x5A")]
	[Token(Token = "0x600000A")]
	private IEventProperties get_asObject() { }

	[Address(RVA = "0x3109530", Offset = "0x3108930", Length = "0xC3")]
	[Token(Token = "0x6000012")]
	public PointerEvent get_asPointerEvent() { }

	[Address(RVA = "0x3109600", Offset = "0x3108A00", Length = "0x78")]
	[Token(Token = "0x6000014")]
	public TextInputEvent get_asTextInputEvent() { }

	[Address(RVA = "0x3109680", Offset = "0x3108A80", Length = "0x5A")]
	[Token(Token = "0x600000C")]
	public override EventModifiers get_eventModifiers() { }

	[Address(RVA = "0x31096E0", Offset = "0x3108AE0", Length = "0x5A")]
	[Token(Token = "0x600000B")]
	public override EventSource get_eventSource() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000009")]
	public Type get_type() { }

	[Address(RVA = "0x7E9560", Offset = "0x7E8960", Length = "0x7D")]
	[Token(Token = "0x600001C")]
	private TOutputType Map() { }

	[Address(RVA = "0x7E95E0", Offset = "0x7E89E0", Length = "0x1D0")]
	[Token(Token = "0x600001B")]
	private TOutputType Map(TMapType fn) { }

	[Address(RVA = "0x3108FA0", Offset = "0x31083A0", Length = "0x224")]
	[Token(Token = "0x600000E")]
	public virtual string ToString() { }

}

