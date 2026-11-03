namespace UnityEngine.UIElements;

[Token(Token = "0x20000D1")]
public class Foldout : BindableElement, INotifyValueChanged<Boolean>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000D2")]
	internal class UxmlFactory : UxmlFactory<Foldout, UxmlTraits>
	{

		[Address(RVA = "0x3346DA0", Offset = "0x33461A0", Length = "0x39")]
		[Token(Token = "0x600068C")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000D3")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000410")]
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000411")]
		private UxmlBoolAttributeDescription m_Value; //Field offset: 0x98

		[Address(RVA = "0x334A680", Offset = "0x3349A80", Length = "0x10A")]
		[Token(Token = "0x600068E")]
		public UxmlTraits() { }

		[Address(RVA = "0x3347460", Offset = "0x3346860", Length = "0x319")]
		[Token(Token = "0x600068D")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000400")]
	internal static readonly BindingId textProperty; //Field offset: 0x0
	[Token(Token = "0x4000401")]
	internal static readonly BindingId toggleOnLabelClickProperty; //Field offset: 0x98
	[Token(Token = "0x4000402")]
	internal static readonly BindingId valueProperty; //Field offset: 0x130
	[Token(Token = "0x4000406")]
	public static readonly string ussClassName; //Field offset: 0x1C8
	[Token(Token = "0x4000407")]
	public static readonly string toggleUssClassName; //Field offset: 0x1D0
	[Token(Token = "0x4000408")]
	public static readonly string contentUssClassName; //Field offset: 0x1D8
	[Token(Token = "0x4000409")]
	public static readonly string inputUssClassName; //Field offset: 0x1E0
	[Token(Token = "0x400040A")]
	public static readonly string checkmarkUssClassName; //Field offset: 0x1E8
	[Token(Token = "0x400040B")]
	public static readonly string textUssClassName; //Field offset: 0x1F0
	[Token(Token = "0x400040C")]
	internal static readonly string toggleInspectorUssClassName; //Field offset: 0x1F8
	[Token(Token = "0x400040D")]
	internal static readonly string ussFoldoutDepthClassName; //Field offset: 0x200
	[Token(Token = "0x400040E")]
	internal static readonly int ussFoldoutMaxDepth; //Field offset: 0x208
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000403")]
	private readonly Toggle m_Toggle; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000404")]
	private VisualElement m_Container; //Field offset: 0x2E0
	[DontCreateProperty]
	[FieldOffset(Offset = "0x2E8")]
	[SerializeField]
	[Token(Token = "0x4000405")]
	private bool m_Value; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x400040F")]
	private KeyboardNavigationManipulator m_NavigationManipulator; //Field offset: 0x2F0

	[Token(Token = "0x170000F4")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
		[Token(Token = "0x600067B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000F5")]
	public virtual bool focusable
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x600067C")]
		 get { } //Length: 5
		[Address(RVA = "0x333F000", Offset = "0x333E400", Length = "0x4B")]
		[Token(Token = "0x600067D")]
		 set { } //Length: 75
	}

	[CreateProperty]
	[Token(Token = "0x170000F7")]
	public string text
	{
		[Address(RVA = "0x333EF90", Offset = "0x333E390", Length = "0x20")]
		[Token(Token = "0x6000680")]
		 get { } //Length: 32
		[Address(RVA = "0x333F050", Offset = "0x333E450", Length = "0x1AA")]
		[Token(Token = "0x6000681")]
		 set { } //Length: 426
	}

	[Token(Token = "0x170000F3")]
	internal Toggle toggle
	{
		[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
		[Token(Token = "0x600067A")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170000F6")]
	public bool toggleOnLabelClick
	{
		[Address(RVA = "0x333EFC0", Offset = "0x333E3C0", Length = "0x21")]
		[Token(Token = "0x600067E")]
		 get { } //Length: 33
		[Address(RVA = "0x333F200", Offset = "0x333E600", Length = "0x90")]
		[Token(Token = "0x600067F")]
		 set { } //Length: 144
	}

	[CreateProperty]
	[Token(Token = "0x170000F8")]
	public override bool value
	{
		[Address(RVA = "0x333EFF0", Offset = "0x333E3F0", Length = "0x8")]
		[Token(Token = "0x6000682")]
		 get { } //Length: 8
		[Address(RVA = "0x333F2A0", Offset = "0x333E6A0", Length = "0x195")]
		[Token(Token = "0x6000683")]
		 set { } //Length: 405
	}

	[Address(RVA = "0x333E560", Offset = "0x333D960", Length = "0x5B9")]
	[Token(Token = "0x600068A")]
	private static Foldout() { }

	[Address(RVA = "0x333EB20", Offset = "0x333DF20", Length = "0x461")]
	[Token(Token = "0x6000688")]
	public Foldout() { }

	[Address(RVA = "0x333E500", Offset = "0x333D900", Length = "0x5B")]
	[CompilerGenerated]
	[Token(Token = "0x600068B")]
	private void <.ctor>b__39_0(ChangeEvent<Boolean> evt) { }

	[Address(RVA = "0x333DF00", Offset = "0x333D300", Length = "0xD8")]
	[Token(Token = "0x6000687")]
	private bool Apply(KeyboardNavigationOperation op) { }

	[Address(RVA = "0x333E010", Offset = "0x333D410", Length = "0x10C")]
	[Token(Token = "0x6000686")]
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
	[Token(Token = "0x600067B")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x600067C")]
	public virtual bool get_focusable() { }

	[Address(RVA = "0x333EF90", Offset = "0x333E390", Length = "0x20")]
	[Token(Token = "0x6000680")]
	public string get_text() { }

	[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
	[Token(Token = "0x600067A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Toggle get_toggle() { }

	[Address(RVA = "0x333EFC0", Offset = "0x333E3C0", Length = "0x21")]
	[Token(Token = "0x600067E")]
	public bool get_toggleOnLabelClick() { }

	[Address(RVA = "0x333EFF0", Offset = "0x333E3F0", Length = "0x8")]
	[Token(Token = "0x6000682")]
	public override bool get_value() { }

	[Address(RVA = "0x333E150", Offset = "0x333D550", Length = "0x20A")]
	[Token(Token = "0x6000689")]
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	[Address(RVA = "0x333E360", Offset = "0x333D760", Length = "0x42")]
	[Token(Token = "0x6000685")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x333F000", Offset = "0x333E400", Length = "0x4B")]
	[Token(Token = "0x600067D")]
	public virtual void set_focusable(bool value) { }

	[Address(RVA = "0x333F050", Offset = "0x333E450", Length = "0x1AA")]
	[Token(Token = "0x6000681")]
	public void set_text(string value) { }

	[Address(RVA = "0x333F200", Offset = "0x333E600", Length = "0x90")]
	[Token(Token = "0x600067F")]
	public void set_toggleOnLabelClick(bool value) { }

	[Address(RVA = "0x333F2A0", Offset = "0x333E6A0", Length = "0x195")]
	[Token(Token = "0x6000683")]
	public override void set_value(bool value) { }

	[Address(RVA = "0x333E3B0", Offset = "0x333D7B0", Length = "0x14C")]
	[Token(Token = "0x6000684")]
	public override void SetValueWithoutNotify(bool newValue) { }

}

