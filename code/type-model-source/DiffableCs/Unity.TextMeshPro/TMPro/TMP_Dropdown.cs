namespace TMPro;

[AddComponentMenu("UI (Canvas)/Dropdown - TextMeshPro", 35)]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200003F")]
public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
{
	[CompilerGenerated]
	[Token(Token = "0x2000044")]
	private sealed class <>c__DisplayClass76_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001C4")]
		public Toggle nothingToggle; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001C5")]
		public Toggle everythingToggle; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001C6")]
		public TMP_Dropdown <>4__this; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000208")]
		public <>c__DisplayClass76_0() { }

		[Address(RVA = "0x2EC54E0", Offset = "0x2EC48E0", Length = "0x25")]
		[Token(Token = "0x6000209")]
		internal void <Show>b__0(bool x) { }

		[Address(RVA = "0x2EC5510", Offset = "0x2EC4910", Length = "0x25")]
		[Token(Token = "0x600020A")]
		internal void <Show>b__1(bool x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000045")]
	private sealed class <>c__DisplayClass76_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001C7")]
		public DropdownItem item; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001C8")]
		public TMP_Dropdown <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600020B")]
		public <>c__DisplayClass76_1() { }

		[Address(RVA = "0x2EC5540", Offset = "0x2EC4940", Length = "0x2B")]
		[Token(Token = "0x600020C")]
		internal void <Show>b__2(bool x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000046")]
	private sealed class <DelayedDestroyDropdownList>d__90 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001C9")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001CA")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001CB")]
		public float delay; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001CC")]
		public TMP_Dropdown <>4__this; //Field offset: 0x28

		[Token(Token = "0x17000062")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000210")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000063")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000212")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600020D")]
		public <DelayedDestroyDropdownList>d__90(int <>1__state) { }

		[Address(RVA = "0x2EC5190", Offset = "0x2EC4590", Length = "0xB1")]
		[Token(Token = "0x600020F")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000210")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000212")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2EC5250", Offset = "0x2EC4650", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000211")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600020E")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000043")]
	internal class DropdownEvent : UnityEvent<Int32>
	{

		[Address(RVA = "0x2EAE550", Offset = "0x2EAD950", Length = "0x39")]
		[Token(Token = "0x6000207")]
		public DropdownEvent() { }

	}

	[Token(Token = "0x2000040")]
	private class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
	{
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Token(Token = "0x40001BC")]
		private TMP_Text m_Text; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Token(Token = "0x40001BD")]
		private Image m_Image; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Token(Token = "0x40001BE")]
		private RectTransform m_RectTransform; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Token(Token = "0x40001BF")]
		private Toggle m_Toggle; //Field offset: 0x38

		[Token(Token = "0x1700005B")]
		public Image image
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[Token(Token = "0x60001F1")]
			 get { } //Length: 5
			[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
			[Token(Token = "0x60001F2")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700005C")]
		public RectTransform rectTransform
		{
			[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
			[Token(Token = "0x60001F3")]
			 get { } //Length: 5
			[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
			[Token(Token = "0x60001F4")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700005A")]
		public TMP_Text text
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x60001EF")]
			 get { } //Length: 5
			[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
			[Token(Token = "0x60001F0")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700005D")]
		public Toggle toggle
		{
			[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
			[Token(Token = "0x60001F5")]
			 get { } //Length: 5
			[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
			[Token(Token = "0x60001F6")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
		[Token(Token = "0x60001F9")]
		public DropdownItem() { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60001F1")]
		public Image get_image() { }

		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60001F3")]
		public RectTransform get_rectTransform() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60001EF")]
		public TMP_Text get_text() { }

		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60001F5")]
		public Toggle get_toggle() { }

		[Address(RVA = "0x2EAE590", Offset = "0x2EAD990", Length = "0x85")]
		[Token(Token = "0x60001F8")]
		public override void OnCancel(BaseEventData eventData) { }

		[Address(RVA = "0x2EAE620", Offset = "0x2EADA20", Length = "0x74")]
		[Token(Token = "0x60001F7")]
		public override void OnPointerEnter(PointerEventData eventData) { }

		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60001F2")]
		public void set_image(Image value) { }

		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60001F4")]
		public void set_rectTransform(RectTransform value) { }

		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60001F0")]
		public void set_text(TMP_Text value) { }

		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x60001F6")]
		public void set_toggle(Toggle value) { }

	}

	[Token(Token = "0x2000041")]
	internal class OptionData
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40001C0")]
		private string m_Text; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x40001C1")]
		private Sprite m_Image; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Token(Token = "0x40001C2")]
		private Color m_Color; //Field offset: 0x20

		[Token(Token = "0x17000060")]
		public Color color
		{
			[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
			[Token(Token = "0x60001FE")]
			 get { } //Length: 11
			[Address(RVA = "0x1E523A0", Offset = "0x1E517A0", Length = "0x8")]
			[Token(Token = "0x60001FF")]
			 set { } //Length: 8
		}

		[Token(Token = "0x1700005F")]
		public Sprite image
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60001FC")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[Token(Token = "0x60001FD")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700005E")]
		public string text
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x60001FA")]
			 get { } //Length: 5
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[Token(Token = "0x60001FB")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x2EAF440", Offset = "0x2EAE840", Length = "0x13")]
		[Token(Token = "0x6000200")]
		public OptionData() { }

		[Address(RVA = "0x2EAF4D0", Offset = "0x2EAE8D0", Length = "0x3D")]
		[Token(Token = "0x6000201")]
		public OptionData(string text) { }

		[Address(RVA = "0x2EAF510", Offset = "0x2EAE910", Length = "0x3D")]
		[Token(Token = "0x6000202")]
		public OptionData(Sprite image) { }

		[Address(RVA = "0x2EAF460", Offset = "0x2EAE860", Length = "0x70")]
		[Token(Token = "0x6000203")]
		public OptionData(string text, Sprite image, Color color) { }

		[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
		[Token(Token = "0x60001FE")]
		public Color get_color() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60001FC")]
		public Sprite get_image() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60001FA")]
		public string get_text() { }

		[Address(RVA = "0x1E523A0", Offset = "0x1E517A0", Length = "0x8")]
		[Token(Token = "0x60001FF")]
		public void set_color(Color value) { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60001FD")]
		public void set_image(Sprite value) { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60001FB")]
		public void set_text(string value) { }

	}

	[Token(Token = "0x2000042")]
	internal class OptionDataList
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40001C3")]
		private List<OptionData> m_Options; //Field offset: 0x10

		[Token(Token = "0x17000061")]
		public List<OptionData> options
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000204")]
			 get { } //Length: 5
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[Token(Token = "0x6000205")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x2EAF3C0", Offset = "0x2EAE7C0", Length = "0x77")]
		[Token(Token = "0x6000206")]
		public OptionDataList() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000204")]
		public List<OptionData> get_options() { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000205")]
		public void set_options(List<OptionData> value) { }

	}

	[Token(Token = "0x40001A7")]
	private static readonly OptionData k_NothingOption; //Field offset: 0x0
	[Token(Token = "0x40001A8")]
	private static readonly OptionData k_EverythingOption; //Field offset: 0x8
	[Token(Token = "0x40001A9")]
	private static readonly OptionData k_MixedOption; //Field offset: 0x10
	[Token(Token = "0x40001BB")]
	private static OptionData s_NoOptionData; //Field offset: 0x18
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x40001AA")]
	private RectTransform m_Template; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x40001AB")]
	private TMP_Text m_CaptionText; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40001AC")]
	private Image m_CaptionImage; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x40001AD")]
	private Graphic m_Placeholder; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Space]
	[Token(Token = "0x40001AE")]
	private TMP_Text m_ItemText; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x40001AF")]
	private Image m_ItemImage; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Space]
	[Token(Token = "0x40001B0")]
	private int m_Value; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[SerializeField]
	[Token(Token = "0x40001B1")]
	private bool m_MultiSelect; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Space]
	[Token(Token = "0x40001B2")]
	private OptionDataList m_Options; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Space]
	[Token(Token = "0x40001B3")]
	private DropdownEvent m_OnValueChanged; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x40001B4")]
	private float m_AlphaFadeSpeed; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40001B5")]
	private GameObject m_Dropdown; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40001B6")]
	private GameObject m_Blocker; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40001B7")]
	private List<DropdownItem> m_Items; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40001B8")]
	private TweenRunner<FloatTween> m_AlphaTweenRunner; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40001B9")]
	private bool validTemplate; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x40001BA")]
	private Coroutine m_Coroutine; //Field offset: 0x178

	[Token(Token = "0x17000056")]
	public float alphaFadeSpeed
	{
		[Address(RVA = "0x2EB6770", Offset = "0x2EB5B70", Length = "0x9")]
		[Token(Token = "0x60001C5")]
		 get { } //Length: 9
		[Address(RVA = "0x2EB67B0", Offset = "0x2EB5BB0", Length = "0x9")]
		[Token(Token = "0x60001C6")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000050")]
	public Image captionImage
	{
		[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
		[Token(Token = "0x60001B9")]
		 get { } //Length: 8
		[Address(RVA = "0x2EB67C0", Offset = "0x2EB5BC0", Length = "0x2B")]
		[Token(Token = "0x60001BA")]
		 set { } //Length: 43
	}

	[Token(Token = "0x1700004F")]
	public TMP_Text captionText
	{
		[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
		[Token(Token = "0x60001B7")]
		 get { } //Length: 8
		[Address(RVA = "0x2EB67F0", Offset = "0x2EB5BF0", Length = "0x2B")]
		[Token(Token = "0x60001B8")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000058")]
	public bool IsExpanded
	{
		[Address(RVA = "0x2EB6700", Offset = "0x2EB5B00", Length = "0x53")]
		[Token(Token = "0x60001CB")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000053")]
	public Image itemImage
	{
		[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
		[Token(Token = "0x60001BF")]
		 get { } //Length: 8
		[Address(RVA = "0x2EB6820", Offset = "0x2EB5C20", Length = "0x2B")]
		[Token(Token = "0x60001C0")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000052")]
	public TMP_Text itemText
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[Token(Token = "0x60001BD")]
		 get { } //Length: 8
		[Address(RVA = "0x2EB6850", Offset = "0x2EB5C50", Length = "0x2B")]
		[Token(Token = "0x60001BE")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000059")]
	public bool MultiSelect
	{
		[Address(RVA = "0x2EB6760", Offset = "0x2EB5B60", Length = "0x8")]
		[Token(Token = "0x60001CC")]
		 get { } //Length: 8
		[Address(RVA = "0x2EB67A0", Offset = "0x2EB5BA0", Length = "0x7")]
		[Token(Token = "0x60001CD")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000055")]
	public DropdownEvent onValueChanged
	{
		[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
		[Token(Token = "0x60001C3")]
		 get { } //Length: 8
		[Address(RVA = "0x29B4B40", Offset = "0x29B3F40", Length = "0x13")]
		[Token(Token = "0x60001C4")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000054")]
	public List<OptionData> options
	{
		[Address(RVA = "0x2EB6780", Offset = "0x2EB5B80", Length = "0x1E")]
		[Token(Token = "0x60001C1")]
		 get { } //Length: 30
		[Address(RVA = "0x2EB6880", Offset = "0x2EB5C80", Length = "0x36")]
		[Token(Token = "0x60001C2")]
		 set { } //Length: 54
	}

	[Token(Token = "0x17000051")]
	public Graphic placeholder
	{
		[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
		[Token(Token = "0x60001BB")]
		 get { } //Length: 8
		[Address(RVA = "0x2EB68C0", Offset = "0x2EB5CC0", Length = "0x2B")]
		[Token(Token = "0x60001BC")]
		 set { } //Length: 43
	}

	[Token(Token = "0x1700004E")]
	public RectTransform template
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[Token(Token = "0x60001B5")]
		 get { } //Length: 8
		[Address(RVA = "0x2EB68F0", Offset = "0x2EB5CF0", Length = "0x2B")]
		[Token(Token = "0x60001B6")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000057")]
	public int value
	{
		[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
		[Token(Token = "0x60001C7")]
		 get { } //Length: 7
		[Address(RVA = "0x2EB6920", Offset = "0x2EB5D20", Length = "0xB")]
		[Token(Token = "0x60001C8")]
		 set { } //Length: 11
	}

	[Address(RVA = "0x2EB6380", Offset = "0x2EB5780", Length = "0x1D2")]
	[Token(Token = "0x60001EE")]
	private static TMP_Dropdown() { }

	[Address(RVA = "0x2EB6560", Offset = "0x2EB5960", Length = "0x19F")]
	[Token(Token = "0x60001CE")]
	protected TMP_Dropdown() { }

	[Address(RVA = "0x2EB2350", Offset = "0x2EB1750", Length = "0x365")]
	[Token(Token = "0x60001E5")]
	private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items) { }

	[Address(RVA = "0x2EB26C0", Offset = "0x2EB1AC0", Length = "0x69")]
	[Token(Token = "0x60001D3")]
	public void AddOptions(List<OptionData> options) { }

	[Address(RVA = "0x2EB2730", Offset = "0x2EB1B30", Length = "0x182")]
	[Token(Token = "0x60001D4")]
	public void AddOptions(List<String> options) { }

	[Address(RVA = "0x2EB28C0", Offset = "0x2EB1CC0", Length = "0x182")]
	[Token(Token = "0x60001D5")]
	public void AddOptions(List<Sprite> options) { }

	[Address(RVA = "0x2EB2A50", Offset = "0x2EB1E50", Length = "0x173")]
	[Token(Token = "0x60001E7")]
	private void AlphaFadeList(float duration, float start, float end) { }

	[Address(RVA = "0x2EB2BD0", Offset = "0x2EB1FD0", Length = "0x8B")]
	[Token(Token = "0x60001E6")]
	private void AlphaFadeList(float duration, float alpha) { }

	[Address(RVA = "0x2EB2C60", Offset = "0x2EB2060", Length = "0x142")]
	[Token(Token = "0x60001CF")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2EB2DB0", Offset = "0x2EB21B0", Length = "0xB9")]
	[Token(Token = "0x60001D6")]
	public void ClearOptions() { }

	[Address(RVA = "0x2EB2E70", Offset = "0x2EB2270", Length = "0x541")]
	[Token(Token = "0x60001DF")]
	protected override GameObject CreateBlocker(Canvas rootCanvas) { }

	[Address(RVA = "0x2EB33C0", Offset = "0x2EB27C0", Length = "0x5A")]
	[Token(Token = "0x60001E1")]
	protected override GameObject CreateDropdownList(GameObject template) { }

	[Address(RVA = "0x2EB3420", Offset = "0x2EB2820", Length = "0x5A")]
	[Token(Token = "0x60001E3")]
	protected override DropdownItem CreateItem(DropdownItem itemTemplate) { }

	[Address(RVA = "0x2EB3480", Offset = "0x2EB2880", Length = "0x79")]
	[IteratorStateMachine(typeof(<DelayedDestroyDropdownList>d__90))]
	[Token(Token = "0x60001EA")]
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	[Address(RVA = "0x2EB3500", Offset = "0x2EB2900", Length = "0x49")]
	[Token(Token = "0x60001E0")]
	protected override void DestroyBlocker(GameObject blocker) { }

	[Address(RVA = "0x2EB3550", Offset = "0x2EB2950", Length = "0x49")]
	[Token(Token = "0x60001E2")]
	protected override void DestroyDropdownList(GameObject dropdownList) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001E4")]
	protected override void DestroyItem(DropdownItem item) { }

	[Address(RVA = "0x2EB35A0", Offset = "0x2EB29A0", Length = "0x22")]
	[Token(Token = "0x60001DE")]
	private static int EverythingValue(int count) { }

	[Address(RVA = "0x2EB35D0", Offset = "0x2EB29D0", Length = "0x1A")]
	[Token(Token = "0x60001ED")]
	private static int FirstActiveFlagIndex(int value) { }

	[Address(RVA = "0x2EB6770", Offset = "0x2EB5B70", Length = "0x9")]
	[Token(Token = "0x60001C5")]
	public float get_alphaFadeSpeed() { }

	[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
	[Token(Token = "0x60001B9")]
	public Image get_captionImage() { }

	[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
	[Token(Token = "0x60001B7")]
	public TMP_Text get_captionText() { }

	[Address(RVA = "0x2EB6700", Offset = "0x2EB5B00", Length = "0x53")]
	[Token(Token = "0x60001CB")]
	public bool get_IsExpanded() { }

	[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
	[Token(Token = "0x60001BF")]
	public Image get_itemImage() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[Token(Token = "0x60001BD")]
	public TMP_Text get_itemText() { }

	[Address(RVA = "0x2EB6760", Offset = "0x2EB5B60", Length = "0x8")]
	[Token(Token = "0x60001CC")]
	public bool get_MultiSelect() { }

	[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
	[Token(Token = "0x60001C3")]
	public DropdownEvent get_onValueChanged() { }

	[Address(RVA = "0x2EB6780", Offset = "0x2EB5B80", Length = "0x1E")]
	[Token(Token = "0x60001C1")]
	public List<OptionData> get_options() { }

	[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
	[Token(Token = "0x60001BB")]
	public Graphic get_placeholder() { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[Token(Token = "0x60001B5")]
	public RectTransform get_template() { }

	[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
	[Token(Token = "0x60001C7")]
	public int get_value() { }

	[Address(RVA = "0x7D15F0", Offset = "0x7D09F0", Length = "0x9C")]
	[Token(Token = "0x60001D8")]
	private static T GetOrAddComponent(GameObject go) { }

	[Address(RVA = "0x2EB35F0", Offset = "0x2EB29F0", Length = "0x200")]
	[Token(Token = "0x60001E9")]
	public void Hide() { }

	[Address(RVA = "0x2EB3800", Offset = "0x2EB2C00", Length = "0x1F8")]
	[Token(Token = "0x60001EB")]
	private void ImmediateDestroyDropdownList() { }

	[Address(RVA = "0x2EB3A00", Offset = "0x2EB2E00", Length = "0x2B")]
	[Token(Token = "0x60001DD")]
	private static bool IsEverythingValue(int count, int value) { }

	[Address(RVA = "0x2EB3A30", Offset = "0x2EB2E30", Length = "0x7")]
	[Token(Token = "0x60001DB")]
	public override void OnCancel(BaseEventData eventData) { }

	[Address(RVA = "0x2EB3A40", Offset = "0x2EB2E40", Length = "0xAA")]
	[Token(Token = "0x60001D1")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x2EB3AF0", Offset = "0x2EB2EF0", Length = "0x7")]
	[Token(Token = "0x60001D9")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x2EB3B00", Offset = "0x2EB2F00", Length = "0x331")]
	[Token(Token = "0x60001EC")]
	private void OnSelectItem(Toggle toggle) { }

	[Address(RVA = "0x2EB3AF0", Offset = "0x2EB2EF0", Length = "0x7")]
	[Token(Token = "0x60001DA")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x2EB3E40", Offset = "0x2EB3240", Length = "0x45E")]
	[Token(Token = "0x60001D2")]
	public void RefreshShownValue() { }

	[Address(RVA = "0x2EB67B0", Offset = "0x2EB5BB0", Length = "0x9")]
	[Token(Token = "0x60001C6")]
	public void set_alphaFadeSpeed(float value) { }

	[Address(RVA = "0x2EB67C0", Offset = "0x2EB5BC0", Length = "0x2B")]
	[Token(Token = "0x60001BA")]
	public void set_captionImage(Image value) { }

	[Address(RVA = "0x2EB67F0", Offset = "0x2EB5BF0", Length = "0x2B")]
	[Token(Token = "0x60001B8")]
	public void set_captionText(TMP_Text value) { }

	[Address(RVA = "0x2EB6820", Offset = "0x2EB5C20", Length = "0x2B")]
	[Token(Token = "0x60001C0")]
	public void set_itemImage(Image value) { }

	[Address(RVA = "0x2EB6850", Offset = "0x2EB5C50", Length = "0x2B")]
	[Token(Token = "0x60001BE")]
	public void set_itemText(TMP_Text value) { }

	[Address(RVA = "0x2EB67A0", Offset = "0x2EB5BA0", Length = "0x7")]
	[Token(Token = "0x60001CD")]
	public void set_MultiSelect(bool value) { }

	[Address(RVA = "0x29B4B40", Offset = "0x29B3F40", Length = "0x13")]
	[Token(Token = "0x60001C4")]
	public void set_onValueChanged(DropdownEvent value) { }

	[Address(RVA = "0x2EB6880", Offset = "0x2EB5C80", Length = "0x36")]
	[Token(Token = "0x60001C2")]
	public void set_options(List<OptionData> value) { }

	[Address(RVA = "0x2EB68C0", Offset = "0x2EB5CC0", Length = "0x2B")]
	[Token(Token = "0x60001BC")]
	public void set_placeholder(Graphic value) { }

	[Address(RVA = "0x2EB68F0", Offset = "0x2EB5CF0", Length = "0x2B")]
	[Token(Token = "0x60001B6")]
	public void set_template(RectTransform value) { }

	[Address(RVA = "0x2EB6920", Offset = "0x2EB5D20", Length = "0xB")]
	[Token(Token = "0x60001C8")]
	public void set_value(int value) { }

	[Address(RVA = "0x2EB42A0", Offset = "0x2EB36A0", Length = "0xA7")]
	[Token(Token = "0x60001E8")]
	private void SetAlpha(float alpha) { }

	[Address(RVA = "0x2EB44E0", Offset = "0x2EB38E0", Length = "0x6ED")]
	[Token(Token = "0x60001D7")]
	private void SetupTemplate() { }

	[Address(RVA = "0x2EB4360", Offset = "0x2EB3760", Length = "0x176")]
	[Token(Token = "0x60001CA")]
	private void SetValue(int value, bool sendCallback = true) { }

	[Address(RVA = "0x2EB4350", Offset = "0x2EB3750", Length = "0xB")]
	[Token(Token = "0x60001C9")]
	public void SetValueWithoutNotify(int input) { }

	[Address(RVA = "0x2EB4BD0", Offset = "0x2EB3FD0", Length = "0x16E7")]
	[Token(Token = "0x60001DC")]
	public void Show() { }

	[Address(RVA = "0x2EB62C0", Offset = "0x2EB56C0", Length = "0xB4")]
	[Token(Token = "0x60001D0")]
	protected virtual void Start() { }

}

