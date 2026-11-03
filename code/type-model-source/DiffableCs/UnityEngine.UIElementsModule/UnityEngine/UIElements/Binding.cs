namespace UnityEngine.UIElements;

[Token(Token = "0x2000020")]
[UxmlObject]
public abstract class Binding
{
	[Token(Token = "0x4000049")]
	internal const string k_UpdateTriggerTooltip = "This informs the binding system of whether the binding object should be updated on every frame, when a change occurs in the source or on every frame if change detection is impossible, and when explicitly marked as dirty."; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000046")]
	private bool m_Dirty; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000047")]
	private BindingUpdateTrigger m_UpdateTrigger; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000048")]
	private string <property>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000022")]
	public bool isDirty
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000096")]
		 get { } //Length: 5
	}

	[CreateProperty]
	[Token(Token = "0x17000023")]
	public BindingUpdateTrigger updateTrigger
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000097")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x6000098")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x21890D0", Offset = "0x21884D0", Length = "0x1A")]
	[Token(Token = "0x6000099")]
	internal Binding() { }

	[Address(RVA = "0x2170560", Offset = "0x216F960", Length = "0x5")]
	[Token(Token = "0x600009B")]
	internal void ClearDirty() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000096")]
	public bool get_isDirty() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6000097")]
	public BindingUpdateTrigger get_updateTrigger() { }

	[Address(RVA = "0x31F1EC0", Offset = "0x31F12C0", Length = "0x51")]
	[Token(Token = "0x6000092")]
	public static BindingLogLevel GetGlobalLogLevel() { }

	[Address(RVA = "0x31F1F20", Offset = "0x31F1320", Length = "0x105")]
	[Token(Token = "0x6000094")]
	public static BindingLogLevel GetPanelLogLevel(IPanel panel) { }

	[Address(RVA = "0xE0B640", Offset = "0xE0AA40", Length = "0x5")]
	[Token(Token = "0x600009A")]
	public void MarkDirty() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600009C")]
	protected private override void OnActivated(in BindingActivationContext context) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600009E")]
	protected private override void OnDataSourceChanged(in DataSourceContextChanged context) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600009D")]
	protected private override void OnDeactivated(in BindingActivationContext context) { }

	[Address(RVA = "0x31F2030", Offset = "0x31F1430", Length = "0x7E")]
	[Token(Token = "0x6000095")]
	public static void ResetPanelLogLevel(IPanel panel) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x6000098")]
	public void set_updateTrigger(BindingUpdateTrigger value) { }

	[Address(RVA = "0x31F20B0", Offset = "0x31F14B0", Length = "0x56")]
	[Token(Token = "0x6000091")]
	public static void SetGlobalLogLevel(BindingLogLevel logLevel) { }

	[Address(RVA = "0x31F2110", Offset = "0x31F1510", Length = "0xCB")]
	[Token(Token = "0x6000093")]
	public static void SetPanelLogLevel(IPanel panel, BindingLogLevel logLevel) { }

}

