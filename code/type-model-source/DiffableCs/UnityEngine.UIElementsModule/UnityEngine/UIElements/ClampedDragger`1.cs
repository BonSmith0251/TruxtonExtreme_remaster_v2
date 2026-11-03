namespace UnityEngine.UIElements;

[Token(Token = "0x2000050")]
internal class ClampedDragger : Clickable
{
	[Flags]
	[Token(Token = "0x2000051")]
	internal enum DragDirection : int
	{
		None = 0,
		LowToHigh = 1,
		HighToLow = 2,
		Free = 4,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400017E")]
	private Action dragging; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400017F")]
	private Action draggingEnded; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000180")]
	private DragDirection<T> <dragDirection>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000181")]
	private BaseSlider<T> <slider>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000182")]
	private Vector2 <startMousePosition>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x14000002")]
	public event Action dragging
	{
		[Address(RVA = "0x16D1D80", Offset = "0x16D1180", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000246")]
		 add { } //Length: 158
		[Address(RVA = "0x16D22A0", Offset = "0x16D16A0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000247")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000003")]
	public event Action draggingEnded
	{
		[Address(RVA = "0x16D1C40", Offset = "0x16D1040", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000248")]
		 add { } //Length: 158
		[Address(RVA = "0x16D2020", Offset = "0x16D1420", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000249")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000051")]
	public Vector2 delta
	{
		[Address(RVA = "0x16D1EC0", Offset = "0x16D12C0", Length = "0x35")]
		[Token(Token = "0x600024F")]
		 get { } //Length: 53
	}

	[Token(Token = "0x1700004E")]
	public DragDirection<T> dragDirection
	{
		[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600024A")]
		 get { } //Length: 7
		[Address(RVA = "0xE26DE0", Offset = "0xE261E0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600024B")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700004F")]
	private BaseSlider<T> slider
	{
		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600024C")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000050")]
	public private Vector2 startMousePosition
	{
		[Address(RVA = "0x16D1F60", Offset = "0x16D1360", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x600024D")]
		 get { } //Length: 25
		[Address(RVA = "0x16D2340", Offset = "0x16D1740", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600024E")]
		private set { } //Length: 8
	}

	[Address(RVA = "0x16D1890", Offset = "0x16D0C90", Length = "0xDF")]
	[Token(Token = "0x6000250")]
	public ClampedDragger`1(BaseSlider<T> slider, Action clickHandler, Action dragHandler) { }

	[Address(RVA = "0x16D1D80", Offset = "0x16D1180", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000246")]
	public void add_dragging(Action value) { }

	[Address(RVA = "0x16D1C40", Offset = "0x16D1040", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000248")]
	public void add_draggingEnded(Action value) { }

	[Address(RVA = "0x16D1EC0", Offset = "0x16D12C0", Length = "0x35")]
	[Token(Token = "0x600024F")]
	public Vector2 get_delta() { }

	[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600024A")]
	public DragDirection<T> get_dragDirection() { }

	[Address(RVA = "0x16D1F60", Offset = "0x16D1360", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x600024D")]
	public Vector2 get_startMousePosition() { }

	[Address(RVA = "0x16D1330", Offset = "0x16D0730", Length = "0x45")]
	[Token(Token = "0x6000251")]
	protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[Address(RVA = "0x16D16C0", Offset = "0x16D0AC0", Length = "0x176")]
	[Token(Token = "0x6000253")]
	protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

	[Address(RVA = "0x16D1840", Offset = "0x16D0C40", Length = "0x44")]
	[Token(Token = "0x6000252")]
	protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[Address(RVA = "0x16D22A0", Offset = "0x16D16A0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000247")]
	public void remove_dragging(Action value) { }

	[Address(RVA = "0x16D2020", Offset = "0x16D1420", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000249")]
	public void remove_draggingEnded(Action value) { }

	[Address(RVA = "0xE26DE0", Offset = "0xE261E0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600024B")]
	public void set_dragDirection(DragDirection<T> value) { }

	[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600024C")]
	private void set_slider(BaseSlider<T> value) { }

	[Address(RVA = "0x16D2340", Offset = "0x16D1740", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600024E")]
	private void set_startMousePosition(Vector2 value) { }

}

