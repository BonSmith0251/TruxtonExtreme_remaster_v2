namespace UnityEngine.UIElements;

[Token(Token = "0x200020E")]
public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000210")]
	private sealed class <>c
	{
		[Token(Token = "0x4000895")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33DFEA0", Offset = "0x33DF2A0", Length = "0x67")]
		[Token(Token = "0x6000E89")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E8A")]
		public <>c() { }

		[Address(RVA = "0x33DE340", Offset = "0x33DD740", Length = "0xA9")]
		[Token(Token = "0x6000E8B")]
		internal NavigationMoveEvent <.cctor>b__0_0() { }

	}

	[Token(Token = "0x200020F")]
	internal enum Direction : int
	{
		None = 0,
		Left = 1,
		Up = 2,
		Right = 3,
		Down = 4,
		Next = 5,
		Previous = 6,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400088B")]
	private Direction <direction>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400088C")]
	private Vector2 <move>k__BackingField; //Field offset: 0x74

	[Token(Token = "0x17000293")]
	public private Direction direction
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000E7F")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000E80")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000294")]
	private Vector2 move
	{
		[Address(RVA = "0xD11C30", Offset = "0xD11030", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000E81")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x33D6A40", Offset = "0x33D5E40", Length = "0xD1")]
	[Token(Token = "0x6000E7D")]
	private static NavigationMoveEvent() { }

	[Address(RVA = "0x33D6B20", Offset = "0x33D5F20", Length = "0x7E")]
	[Token(Token = "0x6000E86")]
	public NavigationMoveEvent() { }

	[Address(RVA = "0x33D65D0", Offset = "0x33D59D0", Length = "0x7F")]
	[Token(Token = "0x6000E7E")]
	internal static Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6) { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000E7F")]
	public Direction get_direction() { }

	[Address(RVA = "0x33D67A0", Offset = "0x33D5BA0", Length = "0xF6")]
	[Token(Token = "0x6000E82")]
	internal static NavigationMoveEvent GetPooled(Vector2 moveVector, NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	[Address(RVA = "0x33D6650", Offset = "0x33D5A50", Length = "0x95")]
	[Token(Token = "0x6000E83")]
	public static NavigationMoveEvent GetPooled(Direction direction, EventModifiers modifiers = 0) { }

	[Address(RVA = "0x33D66F0", Offset = "0x33D5AF0", Length = "0xA2")]
	[Token(Token = "0x6000E84")]
	internal static NavigationMoveEvent GetPooled(Direction direction, NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	[Address(RVA = "0x33D68A0", Offset = "0x33D5CA0", Length = "0x7E")]
	[Token(Token = "0x6000E85")]
	protected virtual void Init() { }

	[Address(RVA = "0x33D6920", Offset = "0x33D5D20", Length = "0x53")]
	[Token(Token = "0x6000E87")]
	private void LocalInit() { }

	[Address(RVA = "0x33D6980", Offset = "0x33D5D80", Length = "0xB8")]
	[Token(Token = "0x6000E88")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000E80")]
	private void set_direction(Direction value) { }

	[Address(RVA = "0xD11C30", Offset = "0xD11030", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000E81")]
	private void set_move(Vector2 value) { }

}

