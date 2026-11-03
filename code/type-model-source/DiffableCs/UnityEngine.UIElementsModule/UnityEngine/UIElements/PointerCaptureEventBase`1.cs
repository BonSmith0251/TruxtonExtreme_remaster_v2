namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Pointer (1))]
[Token(Token = "0x20001B2")]
public abstract class PointerCaptureEventBase : EventBase<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007FB")]
	private IEventHandler <relatedTarget>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007FC")]
	private int <pointerId>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700023C")]
	public private override int pointerId
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C72")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C73")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700023B")]
	private IEventHandler relatedTarget
	{
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000C71")]
		private set { } //Length: 13
	}

	[Address(RVA = "0xE22D50", Offset = "0xE22150", Length = "0xCF")]
	[Token(Token = "0x6000C77")]
	protected PointerCaptureEventBase`1() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C72")]
	public override int get_pointerId() { }

	[Address(RVA = "0xE22AE0", Offset = "0xE21EE0", Length = "0x158")]
	[Token(Token = "0x6000C76")]
	public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId) { }

	[Address(RVA = "0xE22C40", Offset = "0xE22040", Length = "0x8F")]
	[Token(Token = "0x6000C74")]
	protected virtual void Init() { }

	[Address(RVA = "0xE22CD0", Offset = "0xE220D0", Length = "0x7B")]
	[Token(Token = "0x6000C75")]
	private void LocalInit() { }

	[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C73")]
	private void set_pointerId(int value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000C71")]
	private void set_relatedTarget(IEventHandler value) { }

}

