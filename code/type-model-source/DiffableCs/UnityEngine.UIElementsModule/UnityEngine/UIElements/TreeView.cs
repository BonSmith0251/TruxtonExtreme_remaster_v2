namespace UnityEngine.UIElements;

[Token(Token = "0x200016D")]
public class TreeView : BaseTreeView
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200016E")]
	internal class UxmlFactory : UxmlFactory<TreeView, UxmlTraits>
	{

		[Address(RVA = "0x33C3CA0", Offset = "0x33C30A0", Length = "0x39")]
		[Token(Token = "0x6000B1D")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200016F")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4000737")]
		private UxmlAssetAttributeDescription<VisualTreeAsset> m_ItemTemplate; //Field offset: 0xD0

		[Address(RVA = "0x33C4E10", Offset = "0x33C4210", Length = "0xA7")]
		[Token(Token = "0x6000B1F")]
		public UxmlTraits() { }

		[Address(RVA = "0x33C46A0", Offset = "0x33C3AA0", Length = "0x221")]
		[Token(Token = "0x6000B1E")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400072C")]
	internal static readonly BindingId itemTemplateProperty; //Field offset: 0x0
	[Token(Token = "0x400072D")]
	internal static readonly BindingId makeItemProperty; //Field offset: 0x98
	[Token(Token = "0x400072E")]
	internal static readonly BindingId bindItemProperty; //Field offset: 0x130
	[Token(Token = "0x400072F")]
	internal static readonly BindingId unbindItemProperty; //Field offset: 0x1C8
	[Token(Token = "0x4000730")]
	internal static readonly BindingId destroyItemProperty; //Field offset: 0x260
	[FieldOffset(Offset = "0x3E8")]
	[Token(Token = "0x4000731")]
	private Func<VisualElement> m_MakeItem; //Field offset: 0x3E8
	[FieldOffset(Offset = "0x3F0")]
	[Token(Token = "0x4000732")]
	private Func<VisualElement> m_TemplateMakeItem; //Field offset: 0x3F0
	[FieldOffset(Offset = "0x3F8")]
	[Token(Token = "0x4000733")]
	private VisualTreeAsset m_ItemTemplate; //Field offset: 0x3F8
	[FieldOffset(Offset = "0x400")]
	[Token(Token = "0x4000734")]
	private Action<VisualElement, Int32> m_BindItem; //Field offset: 0x400
	[FieldOffset(Offset = "0x408")]
	[Token(Token = "0x4000735")]
	private Action<VisualElement, Int32> m_UnbindItem; //Field offset: 0x408
	[FieldOffset(Offset = "0x410")]
	[Token(Token = "0x4000736")]
	private Action<VisualElement> m_DestroyItem; //Field offset: 0x410

	[CreateProperty]
	[Token(Token = "0x170001E7")]
	public Action<VisualElement, Int32> bindItem
	{
		[Address(RVA = "0x33BCC00", Offset = "0x33BC000", Length = "0x8")]
		[Token(Token = "0x6000B12")]
		 get { } //Length: 8
		[Address(RVA = "0x33BCC30", Offset = "0x33BC030", Length = "0xA5")]
		[Token(Token = "0x6000B13")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x170001E9")]
	public Action<VisualElement> destroyItem
	{
		[Address(RVA = "0x33BCC10", Offset = "0x33BC010", Length = "0x8")]
		[Token(Token = "0x6000B16")]
		 get { } //Length: 8
		[Address(RVA = "0x33BCCE0", Offset = "0x33BC0E0", Length = "0x9B")]
		[Token(Token = "0x6000B17")]
		 set { } //Length: 155
	}

	[CreateProperty]
	[Token(Token = "0x170001E6")]
	public VisualTreeAsset itemTemplate
	{
		[Address(RVA = "0x3395100", Offset = "0x3394500", Length = "0x8")]
		[Token(Token = "0x6000B0F")]
		 get { } //Length: 8
		[Address(RVA = "0x33BCD80", Offset = "0x33BC180", Length = "0xF7")]
		[Token(Token = "0x6000B10")]
		 set { } //Length: 247
	}

	[CreateProperty]
	[Token(Token = "0x170001E5")]
	public Func<VisualElement> makeItem
	{
		[Address(RVA = "0x2EA4E40", Offset = "0x2EA4240", Length = "0x8")]
		[Token(Token = "0x6000B0D")]
		 get { } //Length: 8
		[Address(RVA = "0x33BCE80", Offset = "0x33BC280", Length = "0xA5")]
		[Token(Token = "0x6000B0E")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x170001E8")]
	public Action<VisualElement, Int32> unbindItem
	{
		[Address(RVA = "0x33BCC20", Offset = "0x33BC020", Length = "0x8")]
		[Token(Token = "0x6000B14")]
		 get { } //Length: 8
		[Address(RVA = "0x33BCF30", Offset = "0x33BC330", Length = "0x9B")]
		[Token(Token = "0x6000B15")]
		 set { } //Length: 155
	}

	[Address(RVA = "0x33BC520", Offset = "0x33BB920", Length = "0x42B")]
	[Token(Token = "0x6000B1C")]
	private static TreeView() { }

	[Address(RVA = "0x33BC950", Offset = "0x33BBD50", Length = "0x143")]
	[Token(Token = "0x6000B1A")]
	public TreeView() { }

	[Address(RVA = "0x33BCAA0", Offset = "0x33BBEA0", Length = "0x152")]
	[Token(Token = "0x6000B1B")]
	public TreeView(Func<VisualElement> makeItem, Action<VisualElement, Int32> bindItem) { }

	[Address(RVA = "0x33BC390", Offset = "0x33BB790", Length = "0x55")]
	[Token(Token = "0x6000B19")]
	protected virtual CollectionViewController CreateViewController() { }

	[Address(RVA = "0x33BCC00", Offset = "0x33BC000", Length = "0x8")]
	[Token(Token = "0x6000B12")]
	public Action<VisualElement, Int32> get_bindItem() { }

	[Address(RVA = "0x33BCC10", Offset = "0x33BC010", Length = "0x8")]
	[Token(Token = "0x6000B16")]
	public Action<VisualElement> get_destroyItem() { }

	[Address(RVA = "0x3395100", Offset = "0x3394500", Length = "0x8")]
	[Token(Token = "0x6000B0F")]
	public VisualTreeAsset get_itemTemplate() { }

	[Address(RVA = "0x2EA4E40", Offset = "0x2EA4240", Length = "0x8")]
	[Token(Token = "0x6000B0D")]
	public Func<VisualElement> get_makeItem() { }

	[Address(RVA = "0x33BCC20", Offset = "0x33BC020", Length = "0x8")]
	[Token(Token = "0x6000B14")]
	public Action<VisualElement, Int32> get_unbindItem() { }

	[Address(RVA = "0x33BC3F0", Offset = "0x33BB7F0", Length = "0x3D")]
	[Token(Token = "0x6000B18")]
	internal virtual bool HasValidDataAndBindings() { }

	[Address(RVA = "0x33BCC30", Offset = "0x33BC030", Length = "0xA5")]
	[Token(Token = "0x6000B13")]
	public void set_bindItem(Action<VisualElement, Int32> value) { }

	[Address(RVA = "0x33BCCE0", Offset = "0x33BC0E0", Length = "0x9B")]
	[Token(Token = "0x6000B17")]
	public void set_destroyItem(Action<VisualElement> value) { }

	[Address(RVA = "0x33BCD80", Offset = "0x33BC180", Length = "0xF7")]
	[Token(Token = "0x6000B10")]
	public void set_itemTemplate(VisualTreeAsset value) { }

	[Address(RVA = "0x33BCE80", Offset = "0x33BC280", Length = "0xA5")]
	[Token(Token = "0x6000B0E")]
	public void set_makeItem(Func<VisualElement> value) { }

	[Address(RVA = "0x33BCF30", Offset = "0x33BC330", Length = "0x9B")]
	[Token(Token = "0x6000B15")]
	public void set_unbindItem(Action<VisualElement, Int32> value) { }

	[Address(RVA = "0x33BC430", Offset = "0x33BB830", Length = "0xE9")]
	[Token(Token = "0x6000B11")]
	private VisualElement TemplateMakeItem() { }

}

