namespace UnityEngine.UIElements;

[Token(Token = "0x200006F")]
internal class ReusableTreeViewItem : ReusableCollectionItem
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000205")]
	private Toggle m_Toggle; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000206")]
	private VisualElement m_Container; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000207")]
	internal VisualElement m_IndentElement; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000208")]
	private VisualElement m_BindableContainer; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000209")]
	private VisualElement m_Checkmark; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400020A")]
	private Action<PointerUpEvent> onPointerUp; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400020B")]
	private Action<ChangeEvent`1<Boolean>> onToggleValueChanged; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400020C")]
	internal int m_Depth; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x400020D")]
	private float m_IndentWidth; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400020E")]
	internal Nullable<Single> customIndentWidth; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400020F")]
	private EventCallback<PointerUpEvent> m_PointerUpCallback; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000210")]
	private EventCallback<ChangeEvent`1<Boolean>> m_ToggleValueChangedCallback; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000211")]
	private EventCallback<GeometryChangedEvent> m_ToggleGeometryChangedCallback; //Field offset: 0xA0

	[Token(Token = "0x1400000E")]
	public event Action<PointerUpEvent> onPointerUp
	{
		[Address(RVA = "0x3228590", Offset = "0x3227990", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60003D1")]
		 add { } //Length: 172
		[Address(RVA = "0x3228760", Offset = "0x3227B60", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60003D2")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x1400000F")]
	public event Action<ChangeEvent`1<Boolean>> onToggleValueChanged
	{
		[Address(RVA = "0x3228640", Offset = "0x3227A40", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60003D3")]
		 add { } //Length: 172
		[Address(RVA = "0x3228810", Offset = "0x3227C10", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60003D4")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x17000087")]
	internal float indentWidth
	{
		[Address(RVA = "0x32286F0", Offset = "0x3227AF0", Length = "0x5B")]
		[Token(Token = "0x60003D5")]
		internal get { } //Length: 91
	}

	[Token(Token = "0x17000086")]
	public virtual VisualElement rootElement
	{
		[Address(RVA = "0x3228750", Offset = "0x3227B50", Length = "0xE")]
		[Token(Token = "0x60003D0")]
		 get { } //Length: 14
	}

	[Address(RVA = "0x32277A0", Offset = "0x3226BA0", Length = "0x127")]
	[Token(Token = "0x60003D6")]
	public ReusableTreeViewItem() { }

	[Address(RVA = "0x3228590", Offset = "0x3227990", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60003D1")]
	public void add_onPointerUp(Action<PointerUpEvent> value) { }

	[Address(RVA = "0x3228640", Offset = "0x3227A40", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60003D3")]
	public void add_onToggleValueChanged(Action<ChangeEvent`1<Boolean>> value) { }

	[Address(RVA = "0x32278D0", Offset = "0x3226CD0", Length = "0x1B0")]
	[Token(Token = "0x60003DA")]
	public virtual void DetachElement() { }

	[Address(RVA = "0x32286F0", Offset = "0x3227AF0", Length = "0x5B")]
	[Token(Token = "0x60003D5")]
	internal float get_indentWidth() { }

	[Address(RVA = "0x3228750", Offset = "0x3227B50", Length = "0xE")]
	[Token(Token = "0x60003D0")]
	public virtual VisualElement get_rootElement() { }

	[Address(RVA = "0x3227A90", Offset = "0x3226E90", Length = "0x15")]
	[Token(Token = "0x60003DB")]
	public void Indent(int depth) { }

	[Address(RVA = "0x3227F50", Offset = "0x3227350", Length = "0xE8")]
	[Token(Token = "0x60003D7")]
	public virtual void Init(VisualElement item) { }

	[Address(RVA = "0x3227AB0", Offset = "0x3226EB0", Length = "0x494")]
	[Token(Token = "0x60003D8")]
	protected void InitExpandHierarchy(VisualElement root, VisualElement item) { }

	[Address(RVA = "0x3228040", Offset = "0x3227440", Length = "0x19")]
	[Token(Token = "0x60003E0")]
	private void OnPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x3228060", Offset = "0x3227460", Length = "0x14C")]
	[Token(Token = "0x60003DE")]
	private void OnToggleGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x32281B0", Offset = "0x32275B0", Length = "0x19")]
	[Token(Token = "0x60003E1")]
	private void OnToggleValueChanged(ChangeEvent<Boolean> evt) { }

	[Address(RVA = "0x32281D0", Offset = "0x32275D0", Length = "0x1B0")]
	[Token(Token = "0x60003D9")]
	public virtual void PreAttachElement() { }

	[Address(RVA = "0x3228760", Offset = "0x3227B60", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60003D2")]
	public void remove_onPointerUp(Action<PointerUpEvent> value) { }

	[Address(RVA = "0x3228810", Offset = "0x3227C10", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60003D4")]
	public void remove_onToggleValueChanged(Action<ChangeEvent`1<Boolean>> value) { }

	[Address(RVA = "0x3228390", Offset = "0x3227790", Length = "0x1E")]
	[Token(Token = "0x60003DC")]
	public void SetExpandedWithoutNotify(bool expanded) { }

	[Address(RVA = "0x32283B0", Offset = "0x32277B0", Length = "0x14")]
	[Token(Token = "0x60003DD")]
	public void SetToggleVisibility(bool visible) { }

	[Address(RVA = "0x32283D0", Offset = "0x32277D0", Length = "0x1BC")]
	[Token(Token = "0x60003DF")]
	private void UpdateIndentLayout() { }

}

