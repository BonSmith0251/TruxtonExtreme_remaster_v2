namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Legacy/Dropdown", 102)]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000015")]
public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
{
	[CompilerGenerated]
	[Token(Token = "0x200001A")]
	private sealed class <>c__DisplayClass63_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400005A")]
		public DropdownItem item; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400005B")]
		public Dropdown <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000BB")]
		public <>c__DisplayClass63_0() { }

		[Address(RVA = "0x31ECB90", Offset = "0x31EBF90", Length = "0x12D")]
		[Token(Token = "0x60000BC")]
		internal void <Show>b__0(bool x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001B")]
	private sealed class <DelayedDestroyDropdownList>d__75 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400005C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400005D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400005E")]
		public float delay; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400005F")]
		public Dropdown <>4__this; //Field offset: 0x28

		[Token(Token = "0x17000026")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000C0")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000027")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000C2")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60000BD")]
		public <DelayedDestroyDropdownList>d__75(int <>1__state) { }

		[Address(RVA = "0x31EC8B0", Offset = "0x31EBCB0", Length = "0xB1")]
		[Token(Token = "0x60000BF")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000C0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000C2")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x31EC970", Offset = "0x31EBD70", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000C1")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60000BE")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000019")]
	internal class DropdownEvent : UnityEvent<Int32>
	{

		[Address(RVA = "0x31D9500", Offset = "0x31D8900", Length = "0x39")]
		[Token(Token = "0x60000BA")]
		public DropdownEvent() { }

	}

	[Token(Token = "0x2000016")]
	private class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
	{
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Token(Token = "0x4000053")]
		private Text m_Text; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Token(Token = "0x4000054")]
		private Image m_Image; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Token(Token = "0x4000055")]
		private RectTransform m_RectTransform; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Token(Token = "0x4000056")]
		private Toggle m_Toggle; //Field offset: 0x38

		[Token(Token = "0x17000020")]
		public Image image
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[Token(Token = "0x60000A6")]
			 get { } //Length: 5
			[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
			[Token(Token = "0x60000A7")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000021")]
		public RectTransform rectTransform
		{
			[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
			[Token(Token = "0x60000A8")]
			 get { } //Length: 5
			[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
			[Token(Token = "0x60000A9")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700001F")]
		public Text text
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x60000A4")]
			 get { } //Length: 5
			[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
			[Token(Token = "0x60000A5")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000022")]
		public Toggle toggle
		{
			[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
			[Token(Token = "0x60000AA")]
			 get { } //Length: 5
			[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
			[Token(Token = "0x60000AB")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
		[Token(Token = "0x60000AE")]
		public DropdownItem() { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60000A6")]
		public Image get_image() { }

		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60000A8")]
		public RectTransform get_rectTransform() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60000A4")]
		public Text get_text() { }

		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60000AA")]
		public Toggle get_toggle() { }

		[Address(RVA = "0x31D9540", Offset = "0x31D8940", Length = "0x85")]
		[Token(Token = "0x60000AD")]
		public override void OnCancel(BaseEventData eventData) { }

		[Address(RVA = "0x31D95D0", Offset = "0x31D89D0", Length = "0x74")]
		[Token(Token = "0x60000AC")]
		public override void OnPointerEnter(PointerEventData eventData) { }

		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60000A7")]
		public void set_image(Image value) { }

		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60000A9")]
		public void set_rectTransform(RectTransform value) { }

		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60000A5")]
		public void set_text(Text value) { }

		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x60000AB")]
		public void set_toggle(Toggle value) { }

	}

	[Token(Token = "0x2000017")]
	internal class OptionData
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x4000057")]
		private string m_Text; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x4000058")]
		private Sprite m_Image; //Field offset: 0x18

		[Token(Token = "0x17000024")]
		public Sprite image
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60000B1")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[Token(Token = "0x60000B2")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000023")]
		public string text
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x60000AF")]
			 get { } //Length: 5
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[Token(Token = "0x60000B0")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000B3")]
		public OptionData() { }

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60000B4")]
		public OptionData(string text) { }

		[Address(RVA = "0x1F079E0", Offset = "0x1F06DE0", Length = "0x31")]
		[Token(Token = "0x60000B5")]
		public OptionData(Sprite image) { }

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x60000B6")]
		public OptionData(string text, Sprite image) { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60000B1")]
		public Sprite get_image() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000AF")]
		public string get_text() { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60000B2")]
		public void set_image(Sprite value) { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60000B0")]
		public void set_text(string value) { }

	}

	[Token(Token = "0x2000018")]
	internal class OptionDataList
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x4000059")]
		private List<OptionData> m_Options; //Field offset: 0x10

		[Token(Token = "0x17000025")]
		public List<OptionData> options
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x60000B7")]
			 get { } //Length: 5
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[Token(Token = "0x60000B8")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x31EC5E0", Offset = "0x31EB9E0", Length = "0x77")]
		[Token(Token = "0x60000B9")]
		public OptionDataList() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000B7")]
		public List<OptionData> get_options() { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60000B8")]
		public void set_options(List<OptionData> value) { }

	}

	[Token(Token = "0x4000051")]
	private const int kHighSortingLayer = 30000; //Field offset: 0x0
	[Token(Token = "0x4000052")]
	private static OptionData s_NoOptionData; //Field offset: 0x0
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x4000043")]
	private RectTransform m_Template; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x4000044")]
	private Text m_CaptionText; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x4000045")]
	private Image m_CaptionImage; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Space]
	[Token(Token = "0x4000046")]
	private Text m_ItemText; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000047")]
	private Image m_ItemImage; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Space]
	[Token(Token = "0x4000048")]
	private int m_Value; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Space]
	[Token(Token = "0x4000049")]
	private OptionDataList m_Options; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Space]
	[Token(Token = "0x400004A")]
	private DropdownEvent m_OnValueChanged; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x400004B")]
	private float m_AlphaFadeSpeed; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400004C")]
	private GameObject m_Dropdown; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400004D")]
	private GameObject m_Blocker; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x400004E")]
	private List<DropdownItem> m_Items; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400004F")]
	private TweenRunner<FloatTween> m_AlphaTweenRunner; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000050")]
	private bool validTemplate; //Field offset: 0x168

	[Token(Token = "0x1700001D")]
	public float alphaFadeSpeed
	{
		[Address(RVA = "0x31DCCF0", Offset = "0x31DC0F0", Length = "0x9")]
		[Token(Token = "0x6000080")]
		 get { } //Length: 9
		[Address(RVA = "0x31DCD30", Offset = "0x31DC130", Length = "0x9")]
		[Token(Token = "0x6000081")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000018")]
	public Image captionImage
	{
		[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
		[Token(Token = "0x6000076")]
		 get { } //Length: 8
		[Address(RVA = "0x31DCD40", Offset = "0x31DC140", Length = "0x2B")]
		[Token(Token = "0x6000077")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000017")]
	public Text captionText
	{
		[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
		[Token(Token = "0x6000074")]
		 get { } //Length: 8
		[Address(RVA = "0x31DCD70", Offset = "0x31DC170", Length = "0x2B")]
		[Token(Token = "0x6000075")]
		 set { } //Length: 43
	}

	[Token(Token = "0x1700001A")]
	public Image itemImage
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[Token(Token = "0x600007A")]
		 get { } //Length: 8
		[Address(RVA = "0x31DCDA0", Offset = "0x31DC1A0", Length = "0x2B")]
		[Token(Token = "0x600007B")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000019")]
	public Text itemText
	{
		[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
		[Token(Token = "0x6000078")]
		 get { } //Length: 8
		[Address(RVA = "0x31DCDD0", Offset = "0x31DC1D0", Length = "0x2B")]
		[Token(Token = "0x6000079")]
		 set { } //Length: 43
	}

	[Token(Token = "0x1700001C")]
	public DropdownEvent onValueChanged
	{
		[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
		[Token(Token = "0x600007E")]
		 get { } //Length: 8
		[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
		[Token(Token = "0x600007F")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700001B")]
	public List<OptionData> options
	{
		[Address(RVA = "0x31DCD00", Offset = "0x31DC100", Length = "0x1E")]
		[Token(Token = "0x600007C")]
		 get { } //Length: 30
		[Address(RVA = "0x31DCE00", Offset = "0x31DC200", Length = "0x36")]
		[Token(Token = "0x600007D")]
		 set { } //Length: 54
	}

	[Token(Token = "0x17000016")]
	public RectTransform template
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[Token(Token = "0x6000072")]
		 get { } //Length: 8
		[Address(RVA = "0x31DCE40", Offset = "0x31DC240", Length = "0x2B")]
		[Token(Token = "0x6000073")]
		 set { } //Length: 43
	}

	[Token(Token = "0x1700001E")]
	public int value
	{
		[Address(RVA = "0x31DCD20", Offset = "0x31DC120", Length = "0x7")]
		[Token(Token = "0x6000082")]
		 get { } //Length: 7
		[Address(RVA = "0x31DCE70", Offset = "0x31DC270", Length = "0xB")]
		[Token(Token = "0x6000083")]
		 set { } //Length: 11
	}

	[Address(RVA = "0x31DCAD0", Offset = "0x31DBED0", Length = "0x73")]
	[Token(Token = "0x60000A3")]
	private static Dropdown() { }

	[Address(RVA = "0x31DCB50", Offset = "0x31DBF50", Length = "0x19F")]
	[Token(Token = "0x6000086")]
	protected Dropdown() { }

	[Address(RVA = "0x31D9650", Offset = "0x31D8A50", Length = "0x317")]
	[Token(Token = "0x600009B")]
	private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items) { }

	[Address(RVA = "0x31D9AF0", Offset = "0x31D8EF0", Length = "0x173")]
	[Token(Token = "0x600008D")]
	public void AddOptions(List<Sprite> options) { }

	[Address(RVA = "0x31D9970", Offset = "0x31D8D70", Length = "0x173")]
	[Token(Token = "0x600008C")]
	public void AddOptions(List<String> options) { }

	[Address(RVA = "0x31D9C70", Offset = "0x31D9070", Length = "0x69")]
	[Token(Token = "0x600008B")]
	public void AddOptions(List<OptionData> options) { }

	[Address(RVA = "0x31D9CE0", Offset = "0x31D90E0", Length = "0x173")]
	[Token(Token = "0x600009D")]
	private void AlphaFadeList(float duration, float start, float end) { }

	[Address(RVA = "0x31D9E60", Offset = "0x31D9260", Length = "0x8B")]
	[Token(Token = "0x600009C")]
	private void AlphaFadeList(float duration, float alpha) { }

	[Address(RVA = "0x31D9EF0", Offset = "0x31D92F0", Length = "0x104")]
	[Token(Token = "0x6000087")]
	protected virtual void Awake() { }

	[Address(RVA = "0x31DA000", Offset = "0x31D9400", Length = "0x79")]
	[Token(Token = "0x600008E")]
	public void ClearOptions() { }

	[Address(RVA = "0x31DA080", Offset = "0x31D9480", Length = "0x541")]
	[Token(Token = "0x6000095")]
	protected override GameObject CreateBlocker(Canvas rootCanvas) { }

	[Address(RVA = "0x31DA5D0", Offset = "0x31D99D0", Length = "0x5A")]
	[Token(Token = "0x6000097")]
	protected override GameObject CreateDropdownList(GameObject template) { }

	[Address(RVA = "0x31DA630", Offset = "0x31D9A30", Length = "0x5A")]
	[Token(Token = "0x6000099")]
	protected override DropdownItem CreateItem(DropdownItem itemTemplate) { }

	[Address(RVA = "0x31DA690", Offset = "0x31D9A90", Length = "0x79")]
	[IteratorStateMachine(typeof(<DelayedDestroyDropdownList>d__75))]
	[Token(Token = "0x60000A0")]
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	[Address(RVA = "0x31DA710", Offset = "0x31D9B10", Length = "0x49")]
	[Token(Token = "0x6000096")]
	protected override void DestroyBlocker(GameObject blocker) { }

	[Address(RVA = "0x31DA760", Offset = "0x31D9B60", Length = "0x49")]
	[Token(Token = "0x6000098")]
	protected override void DestroyDropdownList(GameObject dropdownList) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600009A")]
	protected override void DestroyItem(DropdownItem item) { }

	[Address(RVA = "0x31DCCF0", Offset = "0x31DC0F0", Length = "0x9")]
	[Token(Token = "0x6000080")]
	public float get_alphaFadeSpeed() { }

	[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
	[Token(Token = "0x6000076")]
	public Image get_captionImage() { }

	[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
	[Token(Token = "0x6000074")]
	public Text get_captionText() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[Token(Token = "0x600007A")]
	public Image get_itemImage() { }

	[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
	[Token(Token = "0x6000078")]
	public Text get_itemText() { }

	[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
	[Token(Token = "0x600007E")]
	public DropdownEvent get_onValueChanged() { }

	[Address(RVA = "0x31DCD00", Offset = "0x31DC100", Length = "0x1E")]
	[Token(Token = "0x600007C")]
	public List<OptionData> get_options() { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[Token(Token = "0x6000072")]
	public RectTransform get_template() { }

	[Address(RVA = "0x31DCD20", Offset = "0x31DC120", Length = "0x7")]
	[Token(Token = "0x6000082")]
	public int get_value() { }

	[Address(RVA = "0x7D15F0", Offset = "0x7D09F0", Length = "0x9C")]
	[Token(Token = "0x6000090")]
	private static T GetOrAddComponent(GameObject go) { }

	[Address(RVA = "0x31DA7B0", Offset = "0x31D9BB0", Length = "0x1DB")]
	[Token(Token = "0x600009F")]
	public void Hide() { }

	[Address(RVA = "0x31DA990", Offset = "0x31D9D90", Length = "0x1B6")]
	[Token(Token = "0x60000A1")]
	private void ImmediateDestroyDropdownList() { }

	[Address(RVA = "0x31DAB50", Offset = "0x31D9F50", Length = "0x7")]
	[Token(Token = "0x6000093")]
	public override void OnCancel(BaseEventData eventData) { }

	[Address(RVA = "0x31DAB60", Offset = "0x31D9F60", Length = "0xAA")]
	[Token(Token = "0x6000089")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x31DAC10", Offset = "0x31DA010", Length = "0x7")]
	[Token(Token = "0x6000091")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x31DAC20", Offset = "0x31DA020", Length = "0x11A")]
	[Token(Token = "0x60000A2")]
	private void OnSelectItem(Toggle toggle) { }

	[Address(RVA = "0x31DAC10", Offset = "0x31DA010", Length = "0x7")]
	[Token(Token = "0x6000092")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x31DAD40", Offset = "0x31DA140", Length = "0x204")]
	[Token(Token = "0x600008A")]
	public void RefreshShownValue() { }

	[Address(RVA = "0x31DB010", Offset = "0x31DA410", Length = "0x129")]
	[Token(Token = "0x6000085")]
	private void Set(int value, bool sendCallback = true) { }

	[Address(RVA = "0x31DCD30", Offset = "0x31DC130", Length = "0x9")]
	[Token(Token = "0x6000081")]
	public void set_alphaFadeSpeed(float value) { }

	[Address(RVA = "0x31DCD40", Offset = "0x31DC140", Length = "0x2B")]
	[Token(Token = "0x6000077")]
	public void set_captionImage(Image value) { }

	[Address(RVA = "0x31DCD70", Offset = "0x31DC170", Length = "0x2B")]
	[Token(Token = "0x6000075")]
	public void set_captionText(Text value) { }

	[Address(RVA = "0x31DCDA0", Offset = "0x31DC1A0", Length = "0x2B")]
	[Token(Token = "0x600007B")]
	public void set_itemImage(Image value) { }

	[Address(RVA = "0x31DCDD0", Offset = "0x31DC1D0", Length = "0x2B")]
	[Token(Token = "0x6000079")]
	public void set_itemText(Text value) { }

	[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
	[Token(Token = "0x600007F")]
	public void set_onValueChanged(DropdownEvent value) { }

	[Address(RVA = "0x31DCE00", Offset = "0x31DC200", Length = "0x36")]
	[Token(Token = "0x600007D")]
	public void set_options(List<OptionData> value) { }

	[Address(RVA = "0x31DCE40", Offset = "0x31DC240", Length = "0x2B")]
	[Token(Token = "0x6000073")]
	public void set_template(RectTransform value) { }

	[Address(RVA = "0x31DCE70", Offset = "0x31DC270", Length = "0xB")]
	[Token(Token = "0x6000083")]
	public void set_value(int value) { }

	[Address(RVA = "0x31DAF50", Offset = "0x31DA350", Length = "0xA7")]
	[Token(Token = "0x600009E")]
	private void SetAlpha(float alpha) { }

	[Address(RVA = "0x31DB140", Offset = "0x31DA540", Length = "0x71C")]
	[Token(Token = "0x600008F")]
	private void SetupTemplate(Canvas rootCanvas) { }

	[Address(RVA = "0x31DB000", Offset = "0x31DA400", Length = "0xB")]
	[Token(Token = "0x6000084")]
	public void SetValueWithoutNotify(int input) { }

	[Address(RVA = "0x31DB860", Offset = "0x31DAC60", Length = "0x11A0")]
	[Token(Token = "0x6000094")]
	public void Show() { }

	[Address(RVA = "0x31DCA10", Offset = "0x31DBE10", Length = "0xB4")]
	[Token(Token = "0x6000088")]
	protected virtual void Start() { }

}

