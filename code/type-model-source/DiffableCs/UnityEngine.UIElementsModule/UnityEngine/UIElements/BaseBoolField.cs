namespace UnityEngine.UIElements;

[Token(Token = "0x2000074")]
public abstract class BaseBoolField : BaseField<Boolean>
{
	[Token(Token = "0x4000226")]
	internal static readonly BindingId textProperty; //Field offset: 0x0
	[Token(Token = "0x4000227")]
	internal static readonly BindingId toggleOnLabelClickProperty; //Field offset: 0x98
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x4000228")]
	protected Label m_Label; //Field offset: 0x358
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x4000229")]
	protected private readonly VisualElement m_CheckMark; //Field offset: 0x360
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x400022A")]
	internal readonly Clickable m_Clickable; //Field offset: 0x368
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x400022B")]
	private bool <toggleOnLabelClick>k__BackingField; //Field offset: 0x370
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x371")]
	[Token(Token = "0x400022C")]
	private bool <toggleOnTextClick>k__BackingField; //Field offset: 0x371
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x400022D")]
	private string m_OriginalText; //Field offset: 0x378

	[Token(Token = "0x17000091")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool acceptClicksIfDisabled
	{
		[Address(RVA = "0x3213800", Offset = "0x3212C00", Length = "0x7C")]
		[Token(Token = "0x600041F")]
		internal set { } //Length: 124
	}

	[CreateProperty]
	[Token(Token = "0x17000094")]
	public string text
	{
		[Address(RVA = "0x32137C0", Offset = "0x3212BC0", Length = "0x2F")]
		[Token(Token = "0x6000426")]
		 get { } //Length: 47
		[Address(RVA = "0x3213880", Offset = "0x3212C80", Length = "0x106")]
		[Token(Token = "0x6000427")]
		 set { } //Length: 262
	}

	[CreateProperty]
	[Token(Token = "0x17000092")]
	public bool toggleOnLabelClick
	{
		[Address(RVA = "0x32137F0", Offset = "0x3212BF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000420")]
		 get { } //Length: 8
		[Address(RVA = "0x3213990", Offset = "0x3212D90", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000421")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000093")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool toggleOnTextClick
	{
		[Address(RVA = "0x107EBA0", Offset = "0x107DFA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000422")]
		internal get { } //Length: 8
		[Address(RVA = "0x32139A0", Offset = "0x3212DA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000423")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x3213260", Offset = "0x3212660", Length = "0x1E2")]
	[Token(Token = "0x6000430")]
	private static BaseBoolField() { }

	[Address(RVA = "0x3213450", Offset = "0x3212850", Length = "0x361")]
	[Token(Token = "0x6000424")]
	public BaseBoolField(string label) { }

	[Address(RVA = "0x32137C0", Offset = "0x3212BC0", Length = "0x2F")]
	[Token(Token = "0x6000426")]
	public string get_text() { }

	[Address(RVA = "0x32137F0", Offset = "0x3212BF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000420")]
	public bool get_toggleOnLabelClick() { }

	[Address(RVA = "0x107EBA0", Offset = "0x107DFA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000422")]
	internal bool get_toggleOnTextClick() { }

	[Address(RVA = "0x3212740", Offset = "0x3211B40", Length = "0x15D")]
	[Token(Token = "0x6000428")]
	protected override void InitLabel() { }

	[Address(RVA = "0x32128A0", Offset = "0x3211CA0", Length = "0x2FE")]
	[Token(Token = "0x600042A")]
	private void OnClickEvent(EventBase evt) { }

	[Address(RVA = "0x3212BA0", Offset = "0x3211FA0", Length = "0x35")]
	[Token(Token = "0x6000425")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x3212BE0", Offset = "0x3211FE0", Length = "0xE1")]
	[Token(Token = "0x600042E")]
	internal virtual void RegisterEditingCallbacks() { }

	[Address(RVA = "0x3213800", Offset = "0x3212C00", Length = "0x7C")]
	[Token(Token = "0x600041F")]
	internal void set_acceptClicksIfDisabled(bool value) { }

	[Address(RVA = "0x3213880", Offset = "0x3212C80", Length = "0x106")]
	[Token(Token = "0x6000427")]
	public void set_text(string value) { }

	[Address(RVA = "0x3213990", Offset = "0x3212D90", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000421")]
	public void set_toggleOnLabelClick(bool value) { }

	[Address(RVA = "0x32139A0", Offset = "0x3212DA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000423")]
	internal void set_toggleOnTextClick(bool value) { }

	[Address(RVA = "0x3212CD0", Offset = "0x32120D0", Length = "0x8C")]
	[Token(Token = "0x6000429")]
	public virtual void SetValueWithoutNotify(bool newValue) { }

	[Address(RVA = "0x3212D60", Offset = "0x3212160", Length = "0x228")]
	[Token(Token = "0x600042B")]
	private bool ShouldIgnoreClick(Vector3 position) { }

	[Address(RVA = "0x3212F90", Offset = "0x3212390", Length = "0x3D")]
	[Token(Token = "0x600042C")]
	protected override void ToggleValue() { }

	[Address(RVA = "0x3212FD0", Offset = "0x32123D0", Length = "0xE1")]
	[Token(Token = "0x600042F")]
	internal virtual void UnregisterEditingCallbacks() { }

	[Address(RVA = "0x32130C0", Offset = "0x32124C0", Length = "0x19E")]
	[Token(Token = "0x600042D")]
	protected virtual void UpdateMixedValueContent() { }

}

