namespace UnityEngine.UIElements;

[Token(Token = "0x20000FF")]
public class ListView : BaseListView
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000100")]
	internal class UxmlFactory : UxmlFactory<ListView, UxmlTraits>
	{

		[Address(RVA = "0x3391420", Offset = "0x3390820", Length = "0x39")]
		[Token(Token = "0x60007E9")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000101")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x40004EB")]
		private UxmlAssetAttributeDescription<VisualTreeAsset> m_ItemTemplate; //Field offset: 0x108

		[Address(RVA = "0x3392230", Offset = "0x3391630", Length = "0xA7")]
		[Token(Token = "0x60007EB")]
		public UxmlTraits() { }

		[Address(RVA = "0x3391520", Offset = "0x3390920", Length = "0x2AA")]
		[Token(Token = "0x60007EA")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40004E0")]
	internal static readonly BindingId itemTemplateProperty; //Field offset: 0x0
	[Token(Token = "0x40004E1")]
	internal static readonly BindingId makeItemProperty; //Field offset: 0x98
	[Token(Token = "0x40004E2")]
	internal static readonly BindingId bindItemProperty; //Field offset: 0x130
	[Token(Token = "0x40004E3")]
	internal static readonly BindingId unbindItemProperty; //Field offset: 0x1C8
	[Token(Token = "0x40004E4")]
	internal static readonly BindingId destroyItemProperty; //Field offset: 0x260
	[FieldOffset(Offset = "0x4D8")]
	[Token(Token = "0x40004E5")]
	private Func<VisualElement> m_MakeItem; //Field offset: 0x4D8
	[FieldOffset(Offset = "0x4E0")]
	[Token(Token = "0x40004E6")]
	private Func<VisualElement> m_TemplateMakeItem; //Field offset: 0x4E0
	[FieldOffset(Offset = "0x4E8")]
	[Token(Token = "0x40004E7")]
	private VisualTreeAsset m_ItemTemplate; //Field offset: 0x4E8
	[FieldOffset(Offset = "0x4F0")]
	[Token(Token = "0x40004E8")]
	private Action<VisualElement, Int32> m_BindItem; //Field offset: 0x4F0
	[FieldOffset(Offset = "0x4F8")]
	[Token(Token = "0x40004E9")]
	private Action<VisualElement, Int32> m_UnbindItem; //Field offset: 0x4F8
	[FieldOffset(Offset = "0x500")]
	[Token(Token = "0x40004EA")]
	private Action<VisualElement> m_DestroyItem; //Field offset: 0x500

	[CreateProperty]
	[Token(Token = "0x17000145")]
	public Action<VisualElement, Int32> bindItem
	{
		[Address(RVA = "0x3386770", Offset = "0x3385B70", Length = "0x8")]
		[Token(Token = "0x60007DF")]
		 get { } //Length: 8
		[Address(RVA = "0x33867C0", Offset = "0x3385BC0", Length = "0xA5")]
		[Token(Token = "0x60007E0")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x17000147")]
	public Action<VisualElement> destroyItem
	{
		[Address(RVA = "0x3386780", Offset = "0x3385B80", Length = "0x8")]
		[Token(Token = "0x60007E3")]
		 get { } //Length: 8
		[Address(RVA = "0x3386870", Offset = "0x3385C70", Length = "0x9B")]
		[Token(Token = "0x60007E4")]
		 set { } //Length: 155
	}

	[CreateProperty]
	[Token(Token = "0x17000144")]
	public VisualTreeAsset itemTemplate
	{
		[Address(RVA = "0x3386790", Offset = "0x3385B90", Length = "0x8")]
		[Token(Token = "0x60007DC")]
		 get { } //Length: 8
		[Address(RVA = "0x3386910", Offset = "0x3385D10", Length = "0x180")]
		[Token(Token = "0x60007DD")]
		 set { } //Length: 384
	}

	[CreateProperty]
	[Token(Token = "0x17000143")]
	public Func<VisualElement> makeItem
	{
		[Address(RVA = "0x33867A0", Offset = "0x3385BA0", Length = "0x8")]
		[Token(Token = "0x60007DA")]
		 get { } //Length: 8
		[Address(RVA = "0x3386A90", Offset = "0x3385E90", Length = "0xA5")]
		[Token(Token = "0x60007DB")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x17000146")]
	public Action<VisualElement, Int32> unbindItem
	{
		[Address(RVA = "0x33867B0", Offset = "0x3385BB0", Length = "0x8")]
		[Token(Token = "0x60007E1")]
		 get { } //Length: 8
		[Address(RVA = "0x3386B40", Offset = "0x3385F40", Length = "0x9B")]
		[Token(Token = "0x60007E2")]
		 set { } //Length: 155
	}

	[Address(RVA = "0x3386270", Offset = "0x3385670", Length = "0x42B")]
	[Token(Token = "0x60007E8")]
	private static ListView() { }

	[Address(RVA = "0x33866A0", Offset = "0x3385AA0", Length = "0xC4")]
	[Token(Token = "0x60007E7")]
	public ListView() { }

	[Address(RVA = "0x33860C0", Offset = "0x33854C0", Length = "0x44")]
	[Token(Token = "0x60007E6")]
	protected virtual CollectionViewController CreateViewController() { }

	[Address(RVA = "0x3386770", Offset = "0x3385B70", Length = "0x8")]
	[Token(Token = "0x60007DF")]
	public Action<VisualElement, Int32> get_bindItem() { }

	[Address(RVA = "0x3386780", Offset = "0x3385B80", Length = "0x8")]
	[Token(Token = "0x60007E3")]
	public Action<VisualElement> get_destroyItem() { }

	[Address(RVA = "0x3386790", Offset = "0x3385B90", Length = "0x8")]
	[Token(Token = "0x60007DC")]
	public VisualTreeAsset get_itemTemplate() { }

	[Address(RVA = "0x33867A0", Offset = "0x3385BA0", Length = "0x8")]
	[Token(Token = "0x60007DA")]
	public Func<VisualElement> get_makeItem() { }

	[Address(RVA = "0x33867B0", Offset = "0x3385BB0", Length = "0x8")]
	[Token(Token = "0x60007E1")]
	public Action<VisualElement, Int32> get_unbindItem() { }

	[Address(RVA = "0x3386110", Offset = "0x3385510", Length = "0x65")]
	[Token(Token = "0x60007E5")]
	internal virtual bool HasValidDataAndBindings() { }

	[Address(RVA = "0x33867C0", Offset = "0x3385BC0", Length = "0xA5")]
	[Token(Token = "0x60007E0")]
	public void set_bindItem(Action<VisualElement, Int32> value) { }

	[Address(RVA = "0x3386870", Offset = "0x3385C70", Length = "0x9B")]
	[Token(Token = "0x60007E4")]
	public void set_destroyItem(Action<VisualElement> value) { }

	[Address(RVA = "0x3386910", Offset = "0x3385D10", Length = "0x180")]
	[Token(Token = "0x60007DD")]
	public void set_itemTemplate(VisualTreeAsset value) { }

	[Address(RVA = "0x3386A90", Offset = "0x3385E90", Length = "0xA5")]
	[Token(Token = "0x60007DB")]
	public void set_makeItem(Func<VisualElement> value) { }

	[Address(RVA = "0x3386B40", Offset = "0x3385F40", Length = "0x9B")]
	[Token(Token = "0x60007E2")]
	public void set_unbindItem(Action<VisualElement, Int32> value) { }

	[Address(RVA = "0x3386180", Offset = "0x3385580", Length = "0xE9")]
	[Token(Token = "0x60007DE")]
	private VisualElement TemplateMakeItem() { }

}

