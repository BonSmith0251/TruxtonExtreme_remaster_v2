namespace UnityEngine.UIElements;

[Token(Token = "0x200010B")]
[UxmlObject]
public class Column : INotifyBindablePropertyChanged
{
	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200010D")]
	public class UxmlObjectFactory : UxmlObjectFactory<Column>
	{

		[Address(RVA = "0x33914E0", Offset = "0x33908E0", Length = "0x39")]
		[Token(Token = "0x6000866")]
		public UxmlObjectFactory() { }

	}

	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200010C")]
	public class UxmlObjectFactory : UxmlObjectFactory<T, UxmlObjectTraits`1<T>>
	{

		[Address(RVA = "0x11E5050", Offset = "0x11E4450", Length = "0x22")]
		[Token(Token = "0x6000865")]
		public UxmlObjectFactory`1() { }

	}

	[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200010E")]
	public class UxmlObjectTraits : UxmlObjectTraits<T>
	{
		[CompilerGenerated]
		[Token(Token = "0x200010F")]
		private sealed class <>c__DisplayClass14_0
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000552")]
			public VisualTreeAsset asset; //Field offset: 0x0

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600086A")]
			public <>c__DisplayClass14_0() { }

			[Address(RVA = "0xA540F0", Offset = "0xA534F0", Length = "0xE3")]
			[Token(Token = "0x600086B")]
			internal VisualElement <Init>b__0() { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000110")]
		private sealed class <>c__DisplayClass14_1
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000553")]
			public VisualTreeAsset asset; //Field offset: 0x0

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600086C")]
			public <>c__DisplayClass14_1() { }

			[Address(RVA = "0xA541E0", Offset = "0xA535E0", Length = "0xE3")]
			[Token(Token = "0x600086D")]
			internal VisualElement <Init>b__1() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000545")]
		private UxmlStringAttributeDescription m_Name; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000546")]
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000547")]
		private UxmlBoolAttributeDescription m_Visible; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000548")]
		private UxmlStringAttributeDescription m_Width; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000549")]
		private UxmlStringAttributeDescription m_MinWidth; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400054A")]
		private UxmlStringAttributeDescription m_MaxWidth; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400054B")]
		private UxmlBoolAttributeDescription m_Stretch; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400054C")]
		private UxmlBoolAttributeDescription m_Sortable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400054D")]
		private UxmlBoolAttributeDescription m_Optional; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400054E")]
		private UxmlBoolAttributeDescription m_Resizable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400054F")]
		private UxmlStringAttributeDescription m_HeaderTemplateId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000550")]
		private UxmlStringAttributeDescription m_CellTemplateId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000551")]
		private UxmlStringAttributeDescription m_BindingPath; //Field offset: 0x0

		[Address(RVA = "0x11E6AF0", Offset = "0x11E5EF0", Length = "0x490")]
		[Token(Token = "0x6000869")]
		public UxmlObjectTraits`1() { }

		[Address(RVA = "0x11E5F90", Offset = "0x11E5390", Length = "0x819")]
		[Token(Token = "0x6000868")]
		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

		[Address(RVA = "0x11E6950", Offset = "0x11E5D50", Length = "0x19B")]
		[Token(Token = "0x6000867")]
		private static Length ParseLength(string str, Length defaultValue) { }

	}

	[Token(Token = "0x400051C")]
	private static readonly BindingId nameProperty; //Field offset: 0x0
	[Token(Token = "0x400051D")]
	private static readonly BindingId titleProperty; //Field offset: 0x98
	[Token(Token = "0x400051E")]
	private static readonly BindingId iconProperty; //Field offset: 0x130
	[Token(Token = "0x400051F")]
	private static readonly BindingId visibleProperty; //Field offset: 0x1C8
	[Token(Token = "0x4000520")]
	private static readonly BindingId widthProperty; //Field offset: 0x260
	[Token(Token = "0x4000521")]
	private static readonly BindingId minWidthProperty; //Field offset: 0x2F8
	[Token(Token = "0x4000522")]
	private static readonly BindingId maxWidthProperty; //Field offset: 0x390
	[Token(Token = "0x4000523")]
	private static readonly BindingId sortableProperty; //Field offset: 0x428
	[Token(Token = "0x4000524")]
	private static readonly BindingId stretchableProperty; //Field offset: 0x4C0
	[Token(Token = "0x4000525")]
	private static readonly BindingId optionalProperty; //Field offset: 0x558
	[Token(Token = "0x4000526")]
	private static readonly BindingId resizableProperty; //Field offset: 0x5F0
	[Token(Token = "0x4000527")]
	private static readonly BindingId headerTemplateProperty; //Field offset: 0x688
	[Token(Token = "0x4000528")]
	private static readonly BindingId cellTemplateProperty; //Field offset: 0x720
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000529")]
	private string m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400052A")]
	private string m_Title; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400052B")]
	private Background m_Icon; //Field offset: 0x20
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400052C")]
	private bool m_Visible; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400052D")]
	private Length m_Width; //Field offset: 0x44
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400052E")]
	private Length m_MinWidth; //Field offset: 0x4C
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400052F")]
	private Length m_MaxWidth; //Field offset: 0x54
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000530")]
	private float m_DesiredWidth; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000531")]
	private bool m_Stretchable; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4000532")]
	private bool m_Sortable; //Field offset: 0x61
	[FieldOffset(Offset = "0x62")]
	[Token(Token = "0x4000533")]
	private bool m_Optional; //Field offset: 0x62
	[FieldOffset(Offset = "0x63")]
	[Token(Token = "0x4000534")]
	private bool m_Resizable; //Field offset: 0x63
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000535")]
	private VisualTreeAsset m_HeaderTemplate; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000536")]
	private VisualTreeAsset m_CellTemplate; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000537")]
	private Func<VisualElement> m_MakeHeader; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000538")]
	private Action<VisualElement> m_BindHeader; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000539")]
	private Action<VisualElement> m_UnbindHeader; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400053A")]
	private Action<VisualElement> m_DestroyHeader; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400053B")]
	private Func<VisualElement> m_MakeCell; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400053C")]
	private Action<VisualElement, Int32> m_BindCell; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400053D")]
	private Action<VisualElement, Int32> m_UnbindCellItem; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400053E")]
	private EventHandler<BindablePropertyChangedEventArgs> propertyChanged; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400053F")]
	private Comparison<Int32> <comparison>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000540")]
	private string <bindingPath>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000541")]
	private Action<VisualElement> <destroyCell>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000542")]
	private Columns <collection>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000543")]
	private Action<Column, ColumnDataType> changed; //Field offset: 0xD8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000544")]
	private Action<Column> resized; //Field offset: 0xE0

	[Token(Token = "0x14000015")]
	internal event Action<Column, ColumnDataType> changed
	{
		[Address(RVA = "0x337B510", Offset = "0x337A910", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x600085A")]
		internal add { } //Length: 186
		[Address(RVA = "0x337B970", Offset = "0x337AD70", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x600085B")]
		internal remove { } //Length: 186
	}

	[Token(Token = "0x14000014")]
	public override event EventHandler<BindablePropertyChangedEventArgs> propertyChanged
	{
		[Address(RVA = "0x337B5D0", Offset = "0x337A9D0", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x600082B")]
		 add { } //Length: 186
		[Address(RVA = "0x337BA30", Offset = "0x337AE30", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x600082C")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000016")]
	internal event Action<Column> resized
	{
		[Address(RVA = "0x337B690", Offset = "0x337AA90", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x600085C")]
		internal add { } //Length: 186
		[Address(RVA = "0x337BAF0", Offset = "0x337AEF0", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x600085D")]
		internal remove { } //Length: 186
	}

	[Token(Token = "0x1700016D")]
	public Action<VisualElement, Int32> bindCell
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x6000855")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000169")]
	public Action<VisualElement> bindHeader
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6000850")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000165")]
	public string bindingPath
	{
		[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000849")]
		 set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x17000167")]
	public VisualTreeAsset cellTemplate
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x600084C")]
		 get { } //Length: 5
		[Address(RVA = "0x337BBB0", Offset = "0x337AFB0", Length = "0xE3")]
		[Token(Token = "0x600084D")]
		 set { } //Length: 227
	}

	[Token(Token = "0x17000170")]
	public internal Columns collection
	{
		[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000858")]
		 get { } //Length: 8
		[Address(RVA = "0x20E7790", Offset = "0x20E6B90", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000859")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000158")]
	public Comparison<Int32> comparison
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000833")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000160")]
	internal float desiredWidth
	{
		[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
		[Token(Token = "0x600083F")]
		internal get { } //Length: 6
		[Address(RVA = "0x337BCA0", Offset = "0x337B0A0", Length = "0x30")]
		[Token(Token = "0x6000840")]
		internal set { } //Length: 48
	}

	[Token(Token = "0x1700016F")]
	public Action<VisualElement> destroyCell
	{
		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000857")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700016B")]
	public Action<VisualElement> destroyHeader
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6000852")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700015A")]
	internal int displayIndex
	{
		[Address(RVA = "0x337B750", Offset = "0x337AB50", Length = "0xA9")]
		[Token(Token = "0x6000835")]
		internal get { } //Length: 169
	}

	[CreateProperty]
	[Token(Token = "0x17000166")]
	public VisualTreeAsset headerTemplate
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x600084A")]
		 get { } //Length: 5
		[Address(RVA = "0x337BCD0", Offset = "0x337B0D0", Length = "0xE3")]
		[Token(Token = "0x600084B")]
		 set { } //Length: 227
	}

	[CreateProperty]
	[Token(Token = "0x17000157")]
	public Background icon
	{
		[Address(RVA = "0x337B800", Offset = "0x337AC00", Length = "0x13")]
		[Token(Token = "0x6000831")]
		 get { } //Length: 19
		[Address(RVA = "0x337BDC0", Offset = "0x337B1C0", Length = "0xE5")]
		[Token(Token = "0x6000832")]
		 set { } //Length: 229
	}

	[Token(Token = "0x17000159")]
	internal int index
	{
		[Address(RVA = "0x337B820", Offset = "0x337AC20", Length = "0x71")]
		[Token(Token = "0x6000834")]
		internal get { } //Length: 113
	}

	[Token(Token = "0x1700016C")]
	public Func<VisualElement> makeCell
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x6000853")]
		 get { } //Length: 8
		[Address(RVA = "0x337BEB0", Offset = "0x337B2B0", Length = "0x67")]
		[Token(Token = "0x6000854")]
		 set { } //Length: 103
	}

	[Token(Token = "0x17000168")]
	public Func<VisualElement> makeHeader
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x600084E")]
		 get { } //Length: 5
		[Address(RVA = "0x337BF20", Offset = "0x337B320", Length = "0x5E")]
		[Token(Token = "0x600084F")]
		 set { } //Length: 94
	}

	[CreateProperty]
	[Token(Token = "0x1700015F")]
	public Length maxWidth
	{
		[Address(RVA = "0x337B8A0", Offset = "0x337ACA0", Length = "0x5")]
		[Token(Token = "0x600083D")]
		 get { } //Length: 5
		[Address(RVA = "0x337BF80", Offset = "0x337B380", Length = "0xA9")]
		[Token(Token = "0x600083E")]
		 set { } //Length: 169
	}

	[CreateProperty]
	[Token(Token = "0x1700015E")]
	public Length minWidth
	{
		[Address(RVA = "0x20D3C90", Offset = "0x20D3090", Length = "0x5")]
		[Token(Token = "0x600083B")]
		 get { } //Length: 5
		[Address(RVA = "0x337C030", Offset = "0x337B430", Length = "0xA9")]
		[Token(Token = "0x600083C")]
		 set { } //Length: 169
	}

	[CreateProperty]
	[Token(Token = "0x17000155")]
	public string name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600082D")]
		 get { } //Length: 5
		[Address(RVA = "0x337C0E0", Offset = "0x337B4E0", Length = "0xAB")]
		[Token(Token = "0x600082E")]
		 set { } //Length: 171
	}

	[CreateProperty]
	[Token(Token = "0x17000163")]
	public bool optional
	{
		[Address(RVA = "0x121E390", Offset = "0x121D790", Length = "0x5")]
		[Token(Token = "0x6000845")]
		 get { } //Length: 5
		[Address(RVA = "0x337C190", Offset = "0x337B590", Length = "0x9C")]
		[Token(Token = "0x6000846")]
		 set { } //Length: 156
	}

	[CreateProperty]
	[Token(Token = "0x17000164")]
	public bool resizable
	{
		[Address(RVA = "0x2B88D50", Offset = "0x2B88150", Length = "0x5")]
		[Token(Token = "0x6000847")]
		 get { } //Length: 5
		[Address(RVA = "0x337C230", Offset = "0x337B630", Length = "0x9C")]
		[Token(Token = "0x6000848")]
		 set { } //Length: 156
	}

	[CreateProperty]
	[Token(Token = "0x17000161")]
	public bool sortable
	{
		[Address(RVA = "0x1D3B270", Offset = "0x1D3A670", Length = "0x5")]
		[Token(Token = "0x6000841")]
		 get { } //Length: 5
		[Address(RVA = "0x337C2D0", Offset = "0x337B6D0", Length = "0x9C")]
		[Token(Token = "0x6000842")]
		 set { } //Length: 156
	}

	[CreateProperty]
	[Token(Token = "0x17000162")]
	public bool stretchable
	{
		[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
		[Token(Token = "0x6000843")]
		 get { } //Length: 5
		[Address(RVA = "0x337C370", Offset = "0x337B770", Length = "0x9C")]
		[Token(Token = "0x6000844")]
		 set { } //Length: 156
	}

	[CreateProperty]
	[Token(Token = "0x17000156")]
	public string title
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600082F")]
		 get { } //Length: 5
		[Address(RVA = "0x337C410", Offset = "0x337B810", Length = "0xB5")]
		[Token(Token = "0x6000830")]
		 set { } //Length: 181
	}

	[Token(Token = "0x1700016E")]
	public Action<VisualElement, Int32> unbindCell
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x6000856")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700016A")]
	public Action<VisualElement> unbindHeader
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x6000851")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x1700015C")]
	public bool visible
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x6000837")]
		 get { } //Length: 5
		[Address(RVA = "0x337C4D0", Offset = "0x337B8D0", Length = "0x9C")]
		[Token(Token = "0x6000838")]
		 set { } //Length: 156
	}

	[Token(Token = "0x1700015B")]
	internal int visibleIndex
	{
		[Address(RVA = "0x337B8B0", Offset = "0x337ACB0", Length = "0xA9")]
		[Token(Token = "0x6000836")]
		internal get { } //Length: 169
	}

	[CreateProperty]
	[Token(Token = "0x1700015D")]
	public Length width
	{
		[Address(RVA = "0x337B960", Offset = "0x337AD60", Length = "0x5")]
		[Token(Token = "0x6000839")]
		 get { } //Length: 5
		[Address(RVA = "0x337C570", Offset = "0x337B970", Length = "0xE1")]
		[Token(Token = "0x600083A")]
		 set { } //Length: 225
	}

	[Address(RVA = "0x337AA50", Offset = "0x3379E50", Length = "0xA47")]
	[Token(Token = "0x6000864")]
	private static Column() { }

	[Address(RVA = "0x337B4A0", Offset = "0x337A8A0", Length = "0x61")]
	[Token(Token = "0x6000863")]
	public Column() { }

	[Address(RVA = "0x337B510", Offset = "0x337A910", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x600085A")]
	internal void add_changed(Action<Column, ColumnDataType> value) { }

	[Address(RVA = "0x337B5D0", Offset = "0x337A9D0", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x600082B")]
	public override void add_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[Address(RVA = "0x337B690", Offset = "0x337AA90", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x600085C")]
	internal void add_resized(Action<Column> value) { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x6000855")]
	public Action<VisualElement, Int32> get_bindCell() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6000850")]
	public Action<VisualElement> get_bindHeader() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x600084C")]
	public VisualTreeAsset get_cellTemplate() { }

	[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000858")]
	public Columns get_collection() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000833")]
	public Comparison<Int32> get_comparison() { }

	[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
	[Token(Token = "0x600083F")]
	internal float get_desiredWidth() { }

	[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000857")]
	public Action<VisualElement> get_destroyCell() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6000852")]
	public Action<VisualElement> get_destroyHeader() { }

	[Address(RVA = "0x337B750", Offset = "0x337AB50", Length = "0xA9")]
	[Token(Token = "0x6000835")]
	internal int get_displayIndex() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x600084A")]
	public VisualTreeAsset get_headerTemplate() { }

	[Address(RVA = "0x337B800", Offset = "0x337AC00", Length = "0x13")]
	[Token(Token = "0x6000831")]
	public Background get_icon() { }

	[Address(RVA = "0x337B820", Offset = "0x337AC20", Length = "0x71")]
	[Token(Token = "0x6000834")]
	internal int get_index() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x6000853")]
	public Func<VisualElement> get_makeCell() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x600084E")]
	public Func<VisualElement> get_makeHeader() { }

	[Address(RVA = "0x337B8A0", Offset = "0x337ACA0", Length = "0x5")]
	[Token(Token = "0x600083D")]
	public Length get_maxWidth() { }

	[Address(RVA = "0x20D3C90", Offset = "0x20D3090", Length = "0x5")]
	[Token(Token = "0x600083B")]
	public Length get_minWidth() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600082D")]
	public string get_name() { }

	[Address(RVA = "0x121E390", Offset = "0x121D790", Length = "0x5")]
	[Token(Token = "0x6000845")]
	public bool get_optional() { }

	[Address(RVA = "0x2B88D50", Offset = "0x2B88150", Length = "0x5")]
	[Token(Token = "0x6000847")]
	public bool get_resizable() { }

	[Address(RVA = "0x1D3B270", Offset = "0x1D3A670", Length = "0x5")]
	[Token(Token = "0x6000841")]
	public bool get_sortable() { }

	[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
	[Token(Token = "0x6000843")]
	public bool get_stretchable() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600082F")]
	public string get_title() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x6000856")]
	public Action<VisualElement, Int32> get_unbindCell() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x6000851")]
	public Action<VisualElement> get_unbindHeader() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x6000837")]
	public bool get_visible() { }

	[Address(RVA = "0x337B8B0", Offset = "0x337ACB0", Length = "0xA9")]
	[Token(Token = "0x6000836")]
	internal int get_visibleIndex() { }

	[Address(RVA = "0x337B960", Offset = "0x337AD60", Length = "0x5")]
	[Token(Token = "0x6000839")]
	public Length get_width() { }

	[Address(RVA = "0x337A8A0", Offset = "0x3379CA0", Length = "0x27")]
	[Token(Token = "0x6000861")]
	internal float GetMaxWidth(float layoutWidth) { }

	[Address(RVA = "0x337A8D0", Offset = "0x3379CD0", Length = "0x27")]
	[Token(Token = "0x6000862")]
	internal float GetMinWidth(float layoutWidth) { }

	[Address(RVA = "0x337A900", Offset = "0x3379D00", Length = "0x27")]
	[Token(Token = "0x6000860")]
	internal float GetWidth(float layoutWidth) { }

	[Address(RVA = "0x337A930", Offset = "0x3379D30", Length = "0x22")]
	[Token(Token = "0x600085E")]
	private void NotifyChange(ColumnDataType type) { }

	[Address(RVA = "0x337A960", Offset = "0x3379D60", Length = "0xEC")]
	[Token(Token = "0x600085F")]
	private void NotifyPropertyChanged(in BindingId property) { }

	[Address(RVA = "0x337B970", Offset = "0x337AD70", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x600085B")]
	internal void remove_changed(Action<Column, ColumnDataType> value) { }

	[Address(RVA = "0x337BA30", Offset = "0x337AE30", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x600082C")]
	public override void remove_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[Address(RVA = "0x337BAF0", Offset = "0x337AEF0", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x600085D")]
	internal void remove_resized(Action<Column> value) { }

	[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000849")]
	public void set_bindingPath(string value) { }

	[Address(RVA = "0x337BBB0", Offset = "0x337AFB0", Length = "0xE3")]
	[Token(Token = "0x600084D")]
	public void set_cellTemplate(VisualTreeAsset value) { }

	[Address(RVA = "0x20E7790", Offset = "0x20E6B90", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000859")]
	internal void set_collection(Columns value) { }

	[Address(RVA = "0x337BCA0", Offset = "0x337B0A0", Length = "0x30")]
	[Token(Token = "0x6000840")]
	internal void set_desiredWidth(float value) { }

	[Address(RVA = "0x337BCD0", Offset = "0x337B0D0", Length = "0xE3")]
	[Token(Token = "0x600084B")]
	public void set_headerTemplate(VisualTreeAsset value) { }

	[Address(RVA = "0x337BDC0", Offset = "0x337B1C0", Length = "0xE5")]
	[Token(Token = "0x6000832")]
	public void set_icon(Background value) { }

	[Address(RVA = "0x337BEB0", Offset = "0x337B2B0", Length = "0x67")]
	[Token(Token = "0x6000854")]
	public void set_makeCell(Func<VisualElement> value) { }

	[Address(RVA = "0x337BF20", Offset = "0x337B320", Length = "0x5E")]
	[Token(Token = "0x600084F")]
	public void set_makeHeader(Func<VisualElement> value) { }

	[Address(RVA = "0x337BF80", Offset = "0x337B380", Length = "0xA9")]
	[Token(Token = "0x600083E")]
	public void set_maxWidth(Length value) { }

	[Address(RVA = "0x337C030", Offset = "0x337B430", Length = "0xA9")]
	[Token(Token = "0x600083C")]
	public void set_minWidth(Length value) { }

	[Address(RVA = "0x337C0E0", Offset = "0x337B4E0", Length = "0xAB")]
	[Token(Token = "0x600082E")]
	public void set_name(string value) { }

	[Address(RVA = "0x337C190", Offset = "0x337B590", Length = "0x9C")]
	[Token(Token = "0x6000846")]
	public void set_optional(bool value) { }

	[Address(RVA = "0x337C230", Offset = "0x337B630", Length = "0x9C")]
	[Token(Token = "0x6000848")]
	public void set_resizable(bool value) { }

	[Address(RVA = "0x337C2D0", Offset = "0x337B6D0", Length = "0x9C")]
	[Token(Token = "0x6000842")]
	public void set_sortable(bool value) { }

	[Address(RVA = "0x337C370", Offset = "0x337B770", Length = "0x9C")]
	[Token(Token = "0x6000844")]
	public void set_stretchable(bool value) { }

	[Address(RVA = "0x337C410", Offset = "0x337B810", Length = "0xB5")]
	[Token(Token = "0x6000830")]
	public void set_title(string value) { }

	[Address(RVA = "0x337C4D0", Offset = "0x337B8D0", Length = "0x9C")]
	[Token(Token = "0x6000838")]
	public void set_visible(bool value) { }

	[Address(RVA = "0x337C570", Offset = "0x337B970", Length = "0xE1")]
	[Token(Token = "0x600083A")]
	public void set_width(Length value) { }

}

