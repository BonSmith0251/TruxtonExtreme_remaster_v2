namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Pointer (1))]
[Token(Token = "0x2000227")]
public abstract class PointerEventBase : EventBase<T>, IPointerEvent, IPointerEventInternal, IPointerOrMouseEvent
{
	[Token(Token = "0x40008C2")]
	private const float k_DefaultButtonPressure = 0.5; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008DA")]
	private IMouseEvent <compatibilityMouseEvent>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D9")]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D8")]
	private Vector2 <radiusVariance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D7")]
	private Vector2 <radius>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D6")]
	private PenStatus <penStatus>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D5")]
	private float <twist>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D4")]
	private float <tangentialPressure>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D3")]
	private float <pressure>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D2")]
	private int <clickCount>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D1")]
	private float <deltaTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D0")]
	private Vector3 <deltaPosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008DB")]
	private int <displayIndex>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008CF")]
	private Vector3 <localPosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008CD")]
	private int <pressedButtons>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008CC")]
	private int <button>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008CB")]
	private bool <isPrimary>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008CA")]
	private string <pointerType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C9")]
	private int <pointerId>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C8")]
	private Vector2 m_Tilt; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C7")]
	private bool m_TiltNeeded; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C6")]
	private float m_AzimuthAngle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C5")]
	private float m_AltitudeAngle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C4")]
	private bool m_AzimuthNeedsConversion; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C3")]
	private bool m_AltitudeNeedsConversion; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008CE")]
	private Vector3 <position>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008DC")]
	private bool <recomputeTopElementUnderPointer>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170002CF")]
	public override bool actionKey
	{
		[Address(RVA = "0xE266A0", Offset = "0xE25AA0", Length = "0x8A")]
		[Token(Token = "0x6000F18")]
		 get { } //Length: 138
	}

	[Token(Token = "0x170002C3")]
	public override float altitudeAngle
	{
		[Address(RVA = "0xE26740", Offset = "0xE25B40", Length = "0x80")]
		[Token(Token = "0x6000F04")]
		 get { } //Length: 128
		[Address(RVA = "0xE26BF0", Offset = "0xE25FF0", Length = "0xA")]
		[Token(Token = "0x6000F05")]
		 set { } //Length: 10
	}

	[Token(Token = "0x170002CE")]
	public override bool altKey
	{
		[Address(RVA = "0xE26730", Offset = "0xE25B30", Length = "0xD")]
		[Token(Token = "0x6000F17")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170002C4")]
	public override float azimuthAngle
	{
		[Address(RVA = "0xE267C0", Offset = "0xE25BC0", Length = "0x112")]
		[Token(Token = "0x6000F06")]
		 get { } //Length: 274
		[Address(RVA = "0xE26C00", Offset = "0xE26000", Length = "0xA")]
		[Token(Token = "0x6000F07")]
		 set { } //Length: 10
	}

	[Token(Token = "0x170002BA")]
	public override int button
	{
		[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF2")]
		 get { } //Length: 7
		[Address(RVA = "0xE26C10", Offset = "0xE26010", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF3")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002C0")]
	public override int clickCount
	{
		[Address(RVA = "0xE268F0", Offset = "0xE25CF0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000EFE")]
		 get { } //Length: 7
		[Address(RVA = "0xE26C20", Offset = "0xE26020", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000EFF")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002CD")]
	public override bool commandKey
	{
		[Address(RVA = "0xE26900", Offset = "0xE25D00", Length = "0xD")]
		[Token(Token = "0x6000F16")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170002D0")]
	internal IMouseEvent compatibilityMouseEvent
	{
		[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F19")]
		internal get { } //Length: 8
		[Address(RVA = "0xE26C30", Offset = "0xE26030", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000F1A")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170002CC")]
	public override bool ctrlKey
	{
		[Address(RVA = "0xE26910", Offset = "0xE25D10", Length = "0xD")]
		[Token(Token = "0x6000F15")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170002D5")]
	public internal virtual IEventHandler currentTarget
	{
		[Address(RVA = "0xD11A60", Offset = "0xD10E60", Length = "0x19")]
		[Token(Token = "0x6000F22")]
		 get { } //Length: 25
		[Address(RVA = "0xE26C50", Offset = "0xE26050", Length = "0x117")]
		[Token(Token = "0x6000F23")]
		internal set { } //Length: 279
	}

	[Token(Token = "0x170002BE")]
	public override Vector3 deltaPosition
	{
		[Address(RVA = "0xE26920", Offset = "0xE25D20", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000EFA")]
		 get { } //Length: 25
		[Address(RVA = "0xE265F0", Offset = "0xE259F0", Length = "0x16")]
		[CompilerGenerated]
		[Token(Token = "0x6000EFB")]
		 set { } //Length: 22
	}

	[Token(Token = "0x170002BF")]
	public override float deltaTime
	{
		[Address(RVA = "0xE26940", Offset = "0xE25D40", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000EFC")]
		 get { } //Length: 9
		[Address(RVA = "0xE26D70", Offset = "0xE26170", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000EFD")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170002D1")]
	internal int displayIndex
	{
		[Address(RVA = "0xE26D80", Offset = "0xE26180", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000F1B")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170002B9")]
	public override bool isPrimary
	{
		[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF0")]
		 get { } //Length: 8
		[Address(RVA = "0xE26D90", Offset = "0xE26190", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF1")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002BD")]
	public override Vector3 localPosition
	{
		[Address(RVA = "0xE26960", Offset = "0xE25D60", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF8")]
		 get { } //Length: 25
		[Address(RVA = "0xE26DA0", Offset = "0xE261A0", Length = "0x16")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF9")]
		 set { } //Length: 22
	}

	[Token(Token = "0x170002CA")]
	public override EventModifiers modifiers
	{
		[Address(RVA = "0xE26980", Offset = "0xE25D80", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000F12")]
		 get { } //Length: 7
		[Address(RVA = "0xE26DC0", Offset = "0xE261C0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000F13")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002C7")]
	public override PenStatus penStatus
	{
		[Address(RVA = "0xE26990", Offset = "0xE25D90", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000F0C")]
		 get { } //Length: 7
		[Address(RVA = "0xE26DD0", Offset = "0xE261D0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000F0D")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002B7")]
	public override int pointerId
	{
		[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000EEC")]
		 get { } //Length: 7
		[Address(RVA = "0xE26DE0", Offset = "0xE261E0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000EED")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002B8")]
	public override string pointerType
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000EEE")]
		 get { } //Length: 8
		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000EEF")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170002BC")]
	public override Vector3 position
	{
		[Address(RVA = "0xE269B0", Offset = "0xE25DB0", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF6")]
		 get { } //Length: 25
		[Address(RVA = "0xE26E10", Offset = "0xE26210", Length = "0x16")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF7")]
		 set { } //Length: 22
	}

	[Token(Token = "0x170002BB")]
	public override int pressedButtons
	{
		[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF4")]
		 get { } //Length: 7
		[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF5")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002C1")]
	public override float pressure
	{
		[Address(RVA = "0xE269E0", Offset = "0xE25DE0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000F00")]
		 get { } //Length: 9
		[Address(RVA = "0xE26E40", Offset = "0xE26240", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000F01")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170002C8")]
	public override Vector2 radius
	{
		[Address(RVA = "0xE26A10", Offset = "0xE25E10", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000F0E")]
		 get { } //Length: 25
		[Address(RVA = "0xE26E60", Offset = "0xE26260", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F0F")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170002C9")]
	public override Vector2 radiusVariance
	{
		[Address(RVA = "0xE269F0", Offset = "0xE25DF0", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000F10")]
		 get { } //Length: 25
		[Address(RVA = "0xE26E50", Offset = "0xE26250", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F11")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170002D2")]
	internal bool recomputeTopElementUnderPointer
	{
		[Address(RVA = "0xE26A30", Offset = "0xE25E30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F1C")]
		internal get { } //Length: 8
		[Address(RVA = "0xE26E70", Offset = "0xE26270", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000F1D")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170002CB")]
	public override bool shiftKey
	{
		[Address(RVA = "0xE26A40", Offset = "0xE25E40", Length = "0xD")]
		[Token(Token = "0x6000F14")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170002C2")]
	public override float tangentialPressure
	{
		[Address(RVA = "0xE26A50", Offset = "0xE25E50", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000F02")]
		 get { } //Length: 9
		[Address(RVA = "0xE26E80", Offset = "0xE26280", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000F03")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170002C6")]
	public override Vector2 tilt
	{
		[Address(RVA = "0xE26A60", Offset = "0xE25E60", Length = "0x173")]
		[Token(Token = "0x6000F0A")]
		 get { } //Length: 371
		[Address(RVA = "0xE26E90", Offset = "0xE26290", Length = "0x9")]
		[Token(Token = "0x6000F0B")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170002C5")]
	public override float twist
	{
		[Address(RVA = "0xE26BE0", Offset = "0xE25FE0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000F08")]
		 get { } //Length: 9
		[Address(RVA = "0xE26EA0", Offset = "0xE262A0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000F09")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170002D3")]
	private override IMouseEvent UnityEngine.UIElements.IPointerEventInternal.compatibilityMouseEvent
	{
		[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
		[Token(Token = "0x6000F1E")]
		private get { } //Length: 8
	}

	[Token(Token = "0x170002D4")]
	private override Vector3 UnityEngine.UIElements.IPointerOrMouseEvent.deltaPosition
	{
		[Address(RVA = "0xE265F0", Offset = "0xE259F0", Length = "0x16")]
		[Token(Token = "0x6000F1F")]
		private set { } //Length: 22
	}

	[Address(RVA = "0xE26610", Offset = "0xE25A10", Length = "0x90")]
	[Token(Token = "0x6000F34")]
	protected PointerEventBase`1() { }

	[Address(RVA = "0xE22E20", Offset = "0xE22220", Length = "0xA0")]
	[Token(Token = "0x6000F27")]
	private static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth) { }

	[Address(RVA = "0xE22EC0", Offset = "0xE222C0", Length = "0x35")]
	[Token(Token = "0x6000F33")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0xE266A0", Offset = "0xE25AA0", Length = "0x8A")]
	[Token(Token = "0x6000F18")]
	public override bool get_actionKey() { }

	[Address(RVA = "0xE26740", Offset = "0xE25B40", Length = "0x80")]
	[Token(Token = "0x6000F04")]
	public override float get_altitudeAngle() { }

	[Address(RVA = "0xE26730", Offset = "0xE25B30", Length = "0xD")]
	[Token(Token = "0x6000F17")]
	public override bool get_altKey() { }

	[Address(RVA = "0xE267C0", Offset = "0xE25BC0", Length = "0x112")]
	[Token(Token = "0x6000F06")]
	public override float get_azimuthAngle() { }

	[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF2")]
	public override int get_button() { }

	[Address(RVA = "0xE268F0", Offset = "0xE25CF0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000EFE")]
	public override int get_clickCount() { }

	[Address(RVA = "0xE26900", Offset = "0xE25D00", Length = "0xD")]
	[Token(Token = "0x6000F16")]
	public override bool get_commandKey() { }

	[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F19")]
	internal IMouseEvent get_compatibilityMouseEvent() { }

	[Address(RVA = "0xE26910", Offset = "0xE25D10", Length = "0xD")]
	[Token(Token = "0x6000F15")]
	public override bool get_ctrlKey() { }

	[Address(RVA = "0xD11A60", Offset = "0xD10E60", Length = "0x19")]
	[Token(Token = "0x6000F22")]
	public virtual IEventHandler get_currentTarget() { }

	[Address(RVA = "0xE26920", Offset = "0xE25D20", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000EFA")]
	public override Vector3 get_deltaPosition() { }

	[Address(RVA = "0xE26940", Offset = "0xE25D40", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000EFC")]
	public override float get_deltaTime() { }

	[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF0")]
	public override bool get_isPrimary() { }

	[Address(RVA = "0xE26960", Offset = "0xE25D60", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF8")]
	public override Vector3 get_localPosition() { }

	[Address(RVA = "0xE26980", Offset = "0xE25D80", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000F12")]
	public override EventModifiers get_modifiers() { }

	[Address(RVA = "0xE26990", Offset = "0xE25D90", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000F0C")]
	public override PenStatus get_penStatus() { }

	[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000EEC")]
	public override int get_pointerId() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000EEE")]
	public override string get_pointerType() { }

	[Address(RVA = "0xE269B0", Offset = "0xE25DB0", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF6")]
	public override Vector3 get_position() { }

	[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF4")]
	public override int get_pressedButtons() { }

	[Address(RVA = "0xE269E0", Offset = "0xE25DE0", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000F00")]
	public override float get_pressure() { }

	[Address(RVA = "0xE26A10", Offset = "0xE25E10", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000F0E")]
	public override Vector2 get_radius() { }

	[Address(RVA = "0xE269F0", Offset = "0xE25DF0", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000F10")]
	public override Vector2 get_radiusVariance() { }

	[Address(RVA = "0xE26A30", Offset = "0xE25E30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F1C")]
	internal bool get_recomputeTopElementUnderPointer() { }

	[Address(RVA = "0xE26A40", Offset = "0xE25E40", Length = "0xD")]
	[Token(Token = "0x6000F14")]
	public override bool get_shiftKey() { }

	[Address(RVA = "0xE26A50", Offset = "0xE25E50", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000F02")]
	public override float get_tangentialPressure() { }

	[Address(RVA = "0xE26A60", Offset = "0xE25E60", Length = "0x173")]
	[Token(Token = "0x6000F0A")]
	public override Vector2 get_tilt() { }

	[Address(RVA = "0xE26BE0", Offset = "0xE25FE0", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000F08")]
	public override float get_twist() { }

	[Address(RVA = "0xE24DF0", Offset = "0xE241F0", Length = "0x3D0")]
	[Token(Token = "0x6000F2A")]
	internal static T GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers, int displayIndex) { }

	[Address(RVA = "0xE239E0", Offset = "0xE22DE0", Length = "0x585")]
	[Token(Token = "0x6000F2F")]
	public static T GetPooled(IPointerEvent triggerEvent) { }

	[Address(RVA = "0xE24C00", Offset = "0xE24000", Length = "0x1E0")]
	[Token(Token = "0x6000F2E")]
	internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId) { }

	[Address(RVA = "0xE23F70", Offset = "0xE23370", Length = "0xC88")]
	[Token(Token = "0x6000F2D")]
	internal static T GetPooled(PointerEvent pointerEvent, Vector3 position, int pointerId, float deltaTime) { }

	[Address(RVA = "0xE257B0", Offset = "0xE24BB0", Length = "0x5FB")]
	[Token(Token = "0x6000F2C")]
	internal static T GetPooled(PenData pen, EventModifiers modifiers, int displayIndex) { }

	[Address(RVA = "0xE251D0", Offset = "0xE245D0", Length = "0x5D4")]
	[Token(Token = "0x6000F2B")]
	internal static T GetPooled(Touch touch, int pointerId, EventModifiers modifiers, int displayIndex) { }

	[Address(RVA = "0xE22F00", Offset = "0xE22300", Length = "0xADF")]
	[Token(Token = "0x6000F29")]
	public static T GetPooled(Event systemEvent) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000F30")]
	internal override IMouseEvent GetPooledCompatibilityMouseEvent() { }

	[Address(RVA = "0xE25DB0", Offset = "0xE251B0", Length = "0x4F")]
	[Token(Token = "0x6000F20")]
	protected virtual void Init() { }

	[Address(RVA = "0xE25E00", Offset = "0xE25200", Length = "0x3B")]
	[Token(Token = "0x6000F24")]
	private static bool IsMouse(Event systemEvent) { }

	[Address(RVA = "0xE25E40", Offset = "0xE25240", Length = "0x39")]
	[Token(Token = "0x6000F25")]
	private static bool IsTouch(Event systemEvent) { }

	[Address(RVA = "0xE25E80", Offset = "0xE25280", Length = "0x28F")]
	[Token(Token = "0x6000F21")]
	private void LocalInit() { }

	[Address(RVA = "0xE26110", Offset = "0xE25510", Length = "0x142")]
	[Token(Token = "0x6000F32")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0xE26260", Offset = "0xE25660", Length = "0x213")]
	[Token(Token = "0x6000F31")]
	protected private virtual void PreDispatch(IPanel panel) { }

	[Address(RVA = "0xE26BF0", Offset = "0xE25FF0", Length = "0xA")]
	[Token(Token = "0x6000F05")]
	protected void set_altitudeAngle(float value) { }

	[Address(RVA = "0xE26C00", Offset = "0xE26000", Length = "0xA")]
	[Token(Token = "0x6000F07")]
	protected void set_azimuthAngle(float value) { }

	[Address(RVA = "0xE26C10", Offset = "0xE26010", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF3")]
	protected void set_button(int value) { }

	[Address(RVA = "0xE26C20", Offset = "0xE26020", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000EFF")]
	protected void set_clickCount(int value) { }

	[Address(RVA = "0xE26C30", Offset = "0xE26030", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000F1A")]
	internal void set_compatibilityMouseEvent(IMouseEvent value) { }

	[Address(RVA = "0xE26C50", Offset = "0xE26050", Length = "0x117")]
	[Token(Token = "0x6000F23")]
	internal virtual void set_currentTarget(IEventHandler value) { }

	[Address(RVA = "0xE265F0", Offset = "0xE259F0", Length = "0x16")]
	[CompilerGenerated]
	[Token(Token = "0x6000EFB")]
	protected void set_deltaPosition(Vector3 value) { }

	[Address(RVA = "0xE26D70", Offset = "0xE26170", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000EFD")]
	protected void set_deltaTime(float value) { }

	[Address(RVA = "0xE26D80", Offset = "0xE26180", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000F1B")]
	internal void set_displayIndex(int value) { }

	[Address(RVA = "0xE26D90", Offset = "0xE26190", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF1")]
	protected void set_isPrimary(bool value) { }

	[Address(RVA = "0xE26DA0", Offset = "0xE261A0", Length = "0x16")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF9")]
	protected void set_localPosition(Vector3 value) { }

	[Address(RVA = "0xE26DC0", Offset = "0xE261C0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000F13")]
	protected void set_modifiers(EventModifiers value) { }

	[Address(RVA = "0xE26DD0", Offset = "0xE261D0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000F0D")]
	protected void set_penStatus(PenStatus value) { }

	[Address(RVA = "0xE26DE0", Offset = "0xE261E0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000EED")]
	protected void set_pointerId(int value) { }

	[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000EEF")]
	protected void set_pointerType(string value) { }

	[Address(RVA = "0xE26E10", Offset = "0xE26210", Length = "0x16")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF7")]
	protected void set_position(Vector3 value) { }

	[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF5")]
	protected void set_pressedButtons(int value) { }

	[Address(RVA = "0xE26E40", Offset = "0xE26240", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000F01")]
	protected void set_pressure(float value) { }

	[Address(RVA = "0xE26E60", Offset = "0xE26260", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F0F")]
	protected void set_radius(Vector2 value) { }

	[Address(RVA = "0xE26E50", Offset = "0xE26250", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F11")]
	protected void set_radiusVariance(Vector2 value) { }

	[Address(RVA = "0xE26E70", Offset = "0xE26270", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000F1D")]
	internal void set_recomputeTopElementUnderPointer(bool value) { }

	[Address(RVA = "0xE26E80", Offset = "0xE26280", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000F03")]
	protected void set_tangentialPressure(float value) { }

	[Address(RVA = "0xE26E90", Offset = "0xE26290", Length = "0x9")]
	[Token(Token = "0x6000F0B")]
	protected void set_tilt(Vector2 value) { }

	[Address(RVA = "0xE26EA0", Offset = "0xE262A0", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x6000F09")]
	protected void set_twist(float value) { }

	[Address(RVA = "0xE26480", Offset = "0xE25880", Length = "0x4C")]
	[Token(Token = "0x6000F28")]
	private static float TiltToAltitude(Vector2 tilt) { }

	[Address(RVA = "0xE264D0", Offset = "0xE258D0", Length = "0x102")]
	[Token(Token = "0x6000F26")]
	private static float TiltToAzimuth(Vector2 tilt) { }

	[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
	[Token(Token = "0x6000F1E")]
	private override IMouseEvent UnityEngine.UIElements.IPointerEventInternal.get_compatibilityMouseEvent() { }

	[Address(RVA = "0xE265F0", Offset = "0xE259F0", Length = "0x16")]
	[Token(Token = "0x6000F1F")]
	private override void UnityEngine.UIElements.IPointerOrMouseEvent.set_deltaPosition(Vector3 value) { }

}

