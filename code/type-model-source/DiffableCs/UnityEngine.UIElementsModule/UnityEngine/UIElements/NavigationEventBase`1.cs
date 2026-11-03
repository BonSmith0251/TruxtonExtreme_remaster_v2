namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Navigation (14))]
[Token(Token = "0x200020D")]
public abstract class NavigationEventBase : EventBase<T>, INavigationEvent
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000889")]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400088A")]
	private NavigationDeviceType <deviceType>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000291")]
	public override bool altKey
	{
		[Address(RVA = "0xAF0790", Offset = "0xAEFB90", Length = "0xA")]
		[Token(Token = "0x6000E75")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000292")]
	internal NavigationDeviceType deviceType
	{
		[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000E76")]
		internal get { } //Length: 4
		[Address(RVA = "0xD97670", Offset = "0xD96A70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000E77")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700028F")]
	public override EventModifiers modifiers
	{
		[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000E72")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000E73")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000290")]
	public override bool shiftKey
	{
		[Address(RVA = "0xAF0800", Offset = "0xAEFC00", Length = "0xA")]
		[Token(Token = "0x6000E74")]
		 get { } //Length: 10
	}

	[Address(RVA = "0xD975E0", Offset = "0xD969E0", Length = "0x7A")]
	[Token(Token = "0x6000E78")]
	protected NavigationEventBase`1() { }

	[Address(RVA = "0xAF03B0", Offset = "0xAEF7B0", Length = "0x8")]
	[Token(Token = "0x6000E7C")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0xAF0790", Offset = "0xAEFB90", Length = "0xA")]
	[Token(Token = "0x6000E75")]
	public override bool get_altKey() { }

	[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000E76")]
	internal NavigationDeviceType get_deviceType() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000E72")]
	public override EventModifiers get_modifiers() { }

	[Address(RVA = "0xAF0800", Offset = "0xAEFC00", Length = "0xA")]
	[Token(Token = "0x6000E74")]
	public override bool get_shiftKey() { }

	[Address(RVA = "0xD97490", Offset = "0xD96890", Length = "0xD1")]
	[Token(Token = "0x6000E7B")]
	internal static T GetPooled(NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	[Address(RVA = "0xD97570", Offset = "0xD96970", Length = "0x3A")]
	[Token(Token = "0x6000E79")]
	protected virtual void Init() { }

	[Address(RVA = "0xD975B0", Offset = "0xD969B0", Length = "0x20")]
	[Token(Token = "0x6000E7A")]
	private void LocalInit() { }

	[Address(RVA = "0xD97670", Offset = "0xD96A70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000E77")]
	private void set_deviceType(NavigationDeviceType value) { }

	[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000E73")]
	protected void set_modifiers(EventModifiers value) { }

}

