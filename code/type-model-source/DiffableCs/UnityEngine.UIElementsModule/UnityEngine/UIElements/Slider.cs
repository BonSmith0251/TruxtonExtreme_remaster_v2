namespace UnityEngine.UIElements;

[Token(Token = "0x200014C")]
public class Slider : BaseSlider<Single>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200014D")]
	internal class UxmlFactory : UxmlFactory<Slider, UxmlTraits>
	{

		[Address(RVA = "0x33A8100", Offset = "0x33A7500", Length = "0x39")]
		[Token(Token = "0x6000A30")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200014E")]
	internal class UxmlTraits : UxmlTraits<Single, UxmlFloatAttributeDescription>
	{
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000696")]
		private UxmlFloatAttributeDescription m_LowValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000697")]
		private UxmlFloatAttributeDescription m_HighValue; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000698")]
		private UxmlFloatAttributeDescription m_PageSize; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000699")]
		private UxmlBoolAttributeDescription m_ShowInputField; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400069A")]
		private UxmlEnumAttributeDescription<SliderDirection> m_Direction; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x400069B")]
		private UxmlBoolAttributeDescription m_Inverted; //Field offset: 0xC8

		[Address(RVA = "0x33AAFB0", Offset = "0x33AA3B0", Length = "0x2CD")]
		[Token(Token = "0x6000A32")]
		public UxmlTraits() { }

		[Address(RVA = "0x33A8820", Offset = "0x33A7C20", Length = "0x363")]
		[Token(Token = "0x6000A31")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000693")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4000694")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x4000695")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x33A3D90", Offset = "0x33A3190", Length = "0x112")]
	[Token(Token = "0x6000A2F")]
	private static Slider() { }

	[Address(RVA = "0x33A4010", Offset = "0x33A3410", Length = "0x2C")]
	[Token(Token = "0x6000A26")]
	public Slider() { }

	[Address(RVA = "0x33A4040", Offset = "0x33A3440", Length = "0x30")]
	[Token(Token = "0x6000A27")]
	public Slider(float start, float end, SliderDirection direction = 0, float pageSize = 0) { }

	[Address(RVA = "0x33A3EB0", Offset = "0x33A32B0", Length = "0x15C")]
	[Token(Token = "0x6000A28")]
	public Slider(string label, float start = 0, float end = 10, SliderDirection direction = 0, float pageSize = 0) { }

	[Address(RVA = "0x33A35C0", Offset = "0x33A29C0", Length = "0x133")]
	[Token(Token = "0x6000A29")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	[Address(RVA = "0x33A3700", Offset = "0x33A2B00", Length = "0x23E")]
	[Token(Token = "0x6000A2E")]
	internal virtual void ComputeValueFromKey(SliderKey<Single> sliderKey, bool isShift) { }

	[Address(RVA = "0x33A3940", Offset = "0x33A2D40", Length = "0xC8")]
	[Token(Token = "0x6000A2D")]
	internal virtual float ParseStringToValue(string previousValue, string newValue) { }

	[Address(RVA = "0x33A3A10", Offset = "0x33A2E10", Length = "0x212")]
	[Token(Token = "0x6000A2A")]
	internal virtual float SliderLerpUnclamped(float a, float b, float interpolant) { }

	[Address(RVA = "0x33A3C30", Offset = "0x33A3030", Length = "0xB7")]
	[Token(Token = "0x6000A2B")]
	internal virtual float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	[Address(RVA = "0x33A3CF0", Offset = "0x33A30F0", Length = "0x9E")]
	[Token(Token = "0x6000A2C")]
	internal virtual float SliderRange() { }

}

