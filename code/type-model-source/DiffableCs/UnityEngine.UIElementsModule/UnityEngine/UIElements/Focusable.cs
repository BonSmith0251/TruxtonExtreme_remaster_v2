namespace UnityEngine.UIElements;

[Token(Token = "0x2000259")]
public abstract class Focusable : CallbackEventHandler
{
	[Token(Token = "0x400091E")]
	internal static readonly BindingId focusableProperty; //Field offset: 0x0
	[Token(Token = "0x400091F")]
	internal static readonly BindingId tabIndexProperty; //Field offset: 0x98
	[Token(Token = "0x4000920")]
	internal static readonly BindingId delegatesFocusProperty; //Field offset: 0x130
	[Token(Token = "0x4000921")]
	internal static readonly BindingId canGrabFocusProperty; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000922")]
	private bool m_Focusable; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000923")]
	private int m_TabIndex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000924")]
	private bool m_DelegatesFocus; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000925")]
	private bool m_ExcludeFromFocusRing; //Field offset: 0x29
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000926")]
	private bool <isEligibleToReceiveFocusFromDisabledChild>k__BackingField; //Field offset: 0x2A

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000300")]
	public override bool canGrabFocus
	{
		[Address(RVA = "0x1F60FF0", Offset = "0x1F603F0", Length = "0x14")]
		[Token(Token = "0x6001027")]
		 get { } //Length: 20
	}

	[CreateProperty]
	[Token(Token = "0x170002FD")]
	public bool delegatesFocus
	{
		[Address(RVA = "0x33E8050", Offset = "0x33E7450", Length = "0x7")]
		[Token(Token = "0x6001021")]
		 get { } //Length: 7
		[Address(RVA = "0x33E8070", Offset = "0x33E7470", Length = "0x79")]
		[Token(Token = "0x6001022")]
		 set { } //Length: 121
	}

	[Token(Token = "0x170002FE")]
	internal bool excludeFromFocusRing
	{
		[Address(RVA = "0x33E8060", Offset = "0x33E7460", Length = "0x7")]
		[Token(Token = "0x6001023")]
		internal get { } //Length: 7
		[Address(RVA = "0x33E80F0", Offset = "0x33E74F0", Length = "0xD0")]
		[Token(Token = "0x6001024")]
		internal set { } //Length: 208
	}

	[CreateProperty]
	[Token(Token = "0x170002FB")]
	public override bool focusable
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x600101D")]
		 get { } //Length: 5
		[Address(RVA = "0x33E81D0", Offset = "0x33E75D0", Length = "0x72")]
		[Token(Token = "0x600101E")]
		 set { } //Length: 114
	}

	[Token(Token = "0x170002FA")]
	public abstract FocusController focusController
	{
		[Token(Token = "0x600101C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002FF")]
	internal bool isEligibleToReceiveFocusFromDisabledChild
	{
		[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001025")]
		internal get { } //Length: 5
		[Address(RVA = "0x2BCDF60", Offset = "0x2BCD360", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001026")]
		internal set { } //Length: 4
	}

	[CreateProperty]
	[Token(Token = "0x170002FC")]
	public int tabIndex
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x600101F")]
		 get { } //Length: 4
		[Address(RVA = "0x33E8250", Offset = "0x33E7650", Length = "0x76")]
		[Token(Token = "0x6001020")]
		 set { } //Length: 118
	}

	[Address(RVA = "0x33E7C40", Offset = "0x33E7040", Length = "0x368")]
	[Token(Token = "0x600102D")]
	private static Focusable() { }

	[Address(RVA = "0x33E7FB0", Offset = "0x33E73B0", Length = "0x9F")]
	[Token(Token = "0x600101B")]
	protected Focusable() { }

	[Address(RVA = "0x33E7860", Offset = "0x33E6C60", Length = "0x44")]
	[Token(Token = "0x6001029")]
	public override void Blur() { }

	[Address(RVA = "0x33E7810", Offset = "0x33E6C10", Length = "0x44")]
	[Token(Token = "0x600102A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void BlurImmediately() { }

	[Address(RVA = "0x33E78B0", Offset = "0x33E6CB0", Length = "0x14C")]
	[Token(Token = "0x6001028")]
	public override void Focus() { }

	[Address(RVA = "0x1F60FF0", Offset = "0x1F603F0", Length = "0x14")]
	[Token(Token = "0x6001027")]
	public override bool get_canGrabFocus() { }

	[Address(RVA = "0x33E8050", Offset = "0x33E7450", Length = "0x7")]
	[Token(Token = "0x6001021")]
	public bool get_delegatesFocus() { }

	[Address(RVA = "0x33E8060", Offset = "0x33E7460", Length = "0x7")]
	[Token(Token = "0x6001023")]
	internal bool get_excludeFromFocusRing() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x600101D")]
	public override bool get_focusable() { }

	[Token(Token = "0x600101C")]
	public abstract FocusController get_focusController() { }

	[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001025")]
	internal bool get_isEligibleToReceiveFocusFromDisabledChild() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x600101F")]
	public int get_tabIndex() { }

	[Address(RVA = "0x33E7A00", Offset = "0x33E6E00", Length = "0x18E")]
	[Token(Token = "0x600102C")]
	private static Focusable GetFirstFocusableChild(VisualElement ve) { }

	[Address(RVA = "0x33E7B90", Offset = "0x33E6F90", Length = "0xA2")]
	[Token(Token = "0x600102B")]
	internal Focusable GetFocusDelegate() { }

	[Address(RVA = "0x33E8070", Offset = "0x33E7470", Length = "0x79")]
	[Token(Token = "0x6001022")]
	public void set_delegatesFocus(bool value) { }

	[Address(RVA = "0x33E80F0", Offset = "0x33E74F0", Length = "0xD0")]
	[Token(Token = "0x6001024")]
	internal void set_excludeFromFocusRing(bool value) { }

	[Address(RVA = "0x33E81D0", Offset = "0x33E75D0", Length = "0x72")]
	[Token(Token = "0x600101E")]
	public override void set_focusable(bool value) { }

	[Address(RVA = "0x2BCDF60", Offset = "0x2BCD360", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001026")]
	internal void set_isEligibleToReceiveFocusFromDisabledChild(bool value) { }

	[Address(RVA = "0x33E8250", Offset = "0x33E7650", Length = "0x76")]
	[Token(Token = "0x6001020")]
	public void set_tabIndex(int value) { }

}

