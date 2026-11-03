namespace UnityEngine.UIElements;

[Token(Token = "0x200013F")]
public class Scroller : VisualElement
{
	[Token(Token = "0x2000140")]
	private class ScrollerSlider : Slider
	{

		[Address(RVA = "0x33A1050", Offset = "0x33A0450", Length = "0x92")]
		[Token(Token = "0x60009BE")]
		public ScrollerSlider(float start, float end, SliderDirection direction, float pageSize) { }

		[Address(RVA = "0x33A0F80", Offset = "0x33A0380", Length = "0xCC")]
		[Token(Token = "0x60009BF")]
		internal virtual float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000141")]
	internal class UxmlFactory : UxmlFactory<Scroller, UxmlTraits>
	{

		[Address(RVA = "0x33A8240", Offset = "0x33A7640", Length = "0x39")]
		[Token(Token = "0x60009C0")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000142")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000622")]
		private UxmlFloatAttributeDescription m_LowValue; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000623")]
		private UxmlFloatAttributeDescription m_HighValue; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000624")]
		private UxmlEnumAttributeDescription<SliderDirection> m_Direction; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000625")]
		private UxmlFloatAttributeDescription m_Value; //Field offset: 0xA0

		[Address(RVA = "0x33AB330", Offset = "0x33AA730", Length = "0x298")]
		[Token(Token = "0x60009C2")]
		public UxmlTraits() { }

		[Address(RVA = "0x33A8EF0", Offset = "0x33A82F0", Length = "0x27C")]
		[Token(Token = "0x60009C1")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000614")]
	internal static readonly BindingId valueProperty; //Field offset: 0x0
	[Token(Token = "0x4000615")]
	internal static readonly BindingId lowValueProperty; //Field offset: 0x98
	[Token(Token = "0x4000616")]
	internal static readonly BindingId highValueProperty; //Field offset: 0x130
	[Token(Token = "0x4000617")]
	internal static readonly BindingId directionProperty; //Field offset: 0x1C8
	[Token(Token = "0x400061C")]
	public static readonly string ussClassName; //Field offset: 0x260
	[Token(Token = "0x400061D")]
	public static readonly string horizontalVariantUssClassName; //Field offset: 0x268
	[Token(Token = "0x400061E")]
	public static readonly string verticalVariantUssClassName; //Field offset: 0x270
	[Token(Token = "0x400061F")]
	public static readonly string sliderUssClassName; //Field offset: 0x278
	[Token(Token = "0x4000620")]
	public static readonly string lowButtonUssClassName; //Field offset: 0x280
	[Token(Token = "0x4000621")]
	public static readonly string highButtonUssClassName; //Field offset: 0x288
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000618")]
	private Action<Single> valueChanged; //Field offset: 0x2C8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000619")]
	private readonly Slider <slider>k__BackingField; //Field offset: 0x2D0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x400061A")]
	private readonly RepeatButton <lowButton>k__BackingField; //Field offset: 0x2D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x400061B")]
	private readonly RepeatButton <highButton>k__BackingField; //Field offset: 0x2E0

	[Token(Token = "0x14000024")]
	public event Action<Single> valueChanged
	{
		[Address(RVA = "0x33A2090", Offset = "0x33A1490", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x60009A8")]
		 add { } //Length: 186
		[Address(RVA = "0x33A2280", Offset = "0x33A1680", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x60009A9")]
		 remove { } //Length: 186
	}

	[CreateProperty]
	[Token(Token = "0x170001A7")]
	public SliderDirection direction
	{
		[Address(RVA = "0x33A2150", Offset = "0x33A1550", Length = "0x5D")]
		[Token(Token = "0x60009B3")]
		 get { } //Length: 93
		[Address(RVA = "0x33A2340", Offset = "0x33A1740", Length = "0x243")]
		[Token(Token = "0x60009B4")]
		 set { } //Length: 579
	}

	[Token(Token = "0x170001A3")]
	public RepeatButton highButton
	{
		[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60009AC")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170001A6")]
	public float highValue
	{
		[Address(RVA = "0x33A21B0", Offset = "0x33A15B0", Length = "0x47")]
		[Token(Token = "0x60009B1")]
		 get { } //Length: 71
		[Address(RVA = "0x33A2590", Offset = "0x33A1990", Length = "0xFF")]
		[Token(Token = "0x60009B2")]
		 set { } //Length: 255
	}

	[Token(Token = "0x170001A2")]
	public RepeatButton lowButton
	{
		[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60009AB")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170001A5")]
	public float lowValue
	{
		[Address(RVA = "0x33A2200", Offset = "0x33A1600", Length = "0x47")]
		[Token(Token = "0x60009AF")]
		 get { } //Length: 71
		[Address(RVA = "0x33A2690", Offset = "0x33A1A90", Length = "0xFF")]
		[Token(Token = "0x60009B0")]
		 set { } //Length: 255
	}

	[Token(Token = "0x170001A1")]
	public Slider slider
	{
		[Address(RVA = "0x1CE5A20", Offset = "0x1CE4E20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60009AA")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170001A4")]
	public float value
	{
		[Address(RVA = "0x33A2250", Offset = "0x33A1650", Length = "0x2D")]
		[Token(Token = "0x60009AD")]
		 get { } //Length: 45
		[Address(RVA = "0x33A2790", Offset = "0x33A1B90", Length = "0xF5")]
		[Token(Token = "0x60009AE")]
		 set { } //Length: 245
	}

	[Address(RVA = "0x33A1670", Offset = "0x33A0A70", Length = "0x59F")]
	[Token(Token = "0x60009BD")]
	private static Scroller() { }

	[Address(RVA = "0x33A1C40", Offset = "0x33A1040", Length = "0x443")]
	[Token(Token = "0x60009B6")]
	public Scroller(float lowValue, float highValue, Action<Single> valueChanged, SliderDirection direction = 1) { }

	[Address(RVA = "0x33A1C10", Offset = "0x33A1010", Length = "0x28")]
	[Token(Token = "0x60009B5")]
	public Scroller() { }

	[Address(RVA = "0x33A2090", Offset = "0x33A1490", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x60009A8")]
	public void add_valueChanged(Action<Single> value) { }

	[Address(RVA = "0x33A10F0", Offset = "0x33A04F0", Length = "0x70")]
	[Token(Token = "0x60009B7")]
	public void Adjust(float factor) { }

	[Address(RVA = "0x33A2150", Offset = "0x33A1550", Length = "0x5D")]
	[Token(Token = "0x60009B3")]
	public SliderDirection get_direction() { }

	[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60009AC")]
	public RepeatButton get_highButton() { }

	[Address(RVA = "0x33A21B0", Offset = "0x33A15B0", Length = "0x47")]
	[Token(Token = "0x60009B1")]
	public float get_highValue() { }

	[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60009AB")]
	public RepeatButton get_lowButton() { }

	[Address(RVA = "0x33A2200", Offset = "0x33A1600", Length = "0x47")]
	[Token(Token = "0x60009AF")]
	public float get_lowValue() { }

	[Address(RVA = "0x1CE5A20", Offset = "0x1CE4E20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60009AA")]
	public Slider get_slider() { }

	[Address(RVA = "0x33A2250", Offset = "0x33A1650", Length = "0x2D")]
	[Token(Token = "0x60009AD")]
	public float get_value() { }

	[Address(RVA = "0x33A1170", Offset = "0x33A0570", Length = "0x9C")]
	[Token(Token = "0x60009B8")]
	private void OnSliderValueChange(ChangeEvent<Single> evt) { }

	[Address(RVA = "0x33A2280", Offset = "0x33A1680", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x60009A9")]
	public void remove_valueChanged(Action<Single> value) { }

	[Address(RVA = "0x33A1330", Offset = "0x33A0730", Length = "0x109")]
	[Token(Token = "0x60009BA")]
	public void ScrollPageDown() { }

	[Address(RVA = "0x33A1210", Offset = "0x33A0610", Length = "0x11E")]
	[Token(Token = "0x60009BC")]
	public void ScrollPageDown(float factor) { }

	[Address(RVA = "0x33A1440", Offset = "0x33A0840", Length = "0x11E")]
	[Token(Token = "0x60009BB")]
	public void ScrollPageUp(float factor) { }

	[Address(RVA = "0x33A1560", Offset = "0x33A0960", Length = "0x109")]
	[Token(Token = "0x60009B9")]
	public void ScrollPageUp() { }

	[Address(RVA = "0x33A2340", Offset = "0x33A1740", Length = "0x243")]
	[Token(Token = "0x60009B4")]
	public void set_direction(SliderDirection value) { }

	[Address(RVA = "0x33A2590", Offset = "0x33A1990", Length = "0xFF")]
	[Token(Token = "0x60009B2")]
	public void set_highValue(float value) { }

	[Address(RVA = "0x33A2690", Offset = "0x33A1A90", Length = "0xFF")]
	[Token(Token = "0x60009B0")]
	public void set_lowValue(float value) { }

	[Address(RVA = "0x33A2790", Offset = "0x33A1B90", Length = "0xF5")]
	[Token(Token = "0x60009AE")]
	public void set_value(float value) { }

}

