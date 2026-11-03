namespace UnityEngine.UIElements;

[Token(Token = "0x20001F9")]
public class WheelEvent : MouseEventBase<WheelEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001FA")]
	private sealed class <>c
	{
		[Token(Token = "0x400087A")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33E01B0", Offset = "0x33DF5B0", Length = "0x67")]
		[Token(Token = "0x6000E2C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E2D")]
		public <>c() { }

		[Address(RVA = "0x33DF220", Offset = "0x33DE620", Length = "0x6F")]
		[Token(Token = "0x6000E2E")]
		internal WheelEvent <.cctor>b__1_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000879")]
	private Vector3 <delta>k__BackingField; //Field offset: 0xA0

	[Token(Token = "0x1700028A")]
	public private Vector3 delta
	{
		[Address(RVA = "0x33E1070", Offset = "0x33E0470", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000E23")]
		 get { } //Length: 25
		[Address(RVA = "0x33E1090", Offset = "0x33E0490", Length = "0x69")]
		[CompilerGenerated]
		[Token(Token = "0x6000E24")]
		private set { } //Length: 105
	}

	[Address(RVA = "0x33E0F40", Offset = "0x33E0340", Length = "0xD1")]
	[Token(Token = "0x6000E22")]
	private static WheelEvent() { }

	[Address(RVA = "0x33E1020", Offset = "0x33E0420", Length = "0x43")]
	[Token(Token = "0x6000E2A")]
	public WheelEvent() { }

	[Address(RVA = "0x33E0C00", Offset = "0x33E0000", Length = "0x94")]
	[Token(Token = "0x6000E2B")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x33E1070", Offset = "0x33E0470", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000E23")]
	public Vector3 get_delta() { }

	[Address(RVA = "0x33E0CA0", Offset = "0x33E00A0", Length = "0x89")]
	[Token(Token = "0x6000E25")]
	public static WheelEvent GetPooled(Event systemEvent) { }

	[Address(RVA = "0x33E0DA0", Offset = "0x33E01A0", Length = "0xC0")]
	[Token(Token = "0x6000E26")]
	internal static WheelEvent GetPooled(Vector3 delta, Vector3 mousePosition, EventModifiers modifiers = 0) { }

	[Address(RVA = "0x33E0D30", Offset = "0x33E0130", Length = "0x65")]
	[Token(Token = "0x6000E27")]
	internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent) { }

	[Address(RVA = "0x33E0E70", Offset = "0x33E0270", Length = "0x43")]
	[Token(Token = "0x6000E28")]
	protected virtual void Init() { }

	[Address(RVA = "0x33E0EC0", Offset = "0x33E02C0", Length = "0x78")]
	[Token(Token = "0x6000E29")]
	private void LocalInit() { }

	[Address(RVA = "0x33E1090", Offset = "0x33E0490", Length = "0x69")]
	[CompilerGenerated]
	[Token(Token = "0x6000E24")]
	private void set_delta(Vector3 value) { }

}

