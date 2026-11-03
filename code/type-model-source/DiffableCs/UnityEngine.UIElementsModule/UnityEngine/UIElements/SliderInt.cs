namespace UnityEngine.UIElements;

[Token(Token = "0x200014F")]
public class SliderInt : BaseSlider<Int32>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000150")]
	internal class UxmlFactory : UxmlFactory<SliderInt, UxmlTraits>
	{

		[Address(RVA = "0x33A80C0", Offset = "0x33A74C0", Length = "0x39")]
		[Token(Token = "0x6000A3F")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000151")]
	internal class UxmlTraits : UxmlTraits<Int32, UxmlIntAttributeDescription>
	{
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400069F")]
		private UxmlIntAttributeDescription m_LowValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40006A0")]
		private UxmlIntAttributeDescription m_HighValue; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40006A1")]
		private UxmlIntAttributeDescription m_PageSize; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x40006A2")]
		private UxmlBoolAttributeDescription m_ShowInputField; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x40006A3")]
		private UxmlEnumAttributeDescription<SliderDirection> m_Direction; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x40006A4")]
		private UxmlBoolAttributeDescription m_Inverted; //Field offset: 0xC8

		[Address(RVA = "0x33AB5D0", Offset = "0x33AA9D0", Length = "0x2CD")]
		[Token(Token = "0x6000A41")]
		public UxmlTraits() { }

		[Address(RVA = "0x33A8300", Offset = "0x33A7700", Length = "0x365")]
		[Token(Token = "0x6000A40")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400069C")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400069D")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x400069E")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x170001C1")]
	public virtual float pageSize
	{
		[Address(RVA = "0x33A34F0", Offset = "0x33A28F0", Length = "0x39")]
		[Token(Token = "0x6000A35")]
		 get { } //Length: 57
		[Address(RVA = "0x33A3530", Offset = "0x33A2930", Length = "0x8E")]
		[Token(Token = "0x6000A36")]
		 set { } //Length: 142
	}

	[Address(RVA = "0x33A3140", Offset = "0x33A2540", Length = "0x112")]
	[Token(Token = "0x6000A3E")]
	private static SliderInt() { }

	[Address(RVA = "0x33A3260", Offset = "0x33A2660", Length = "0x12F")]
	[Token(Token = "0x6000A33")]
	public SliderInt() { }

	[Address(RVA = "0x33A3390", Offset = "0x33A2790", Length = "0x156")]
	[Token(Token = "0x6000A34")]
	public SliderInt(string label, int start = 0, int end = 10, SliderDirection direction = 0, float pageSize = 0) { }

	[Address(RVA = "0x33A2890", Offset = "0x33A1C90", Length = "0x15A")]
	[Token(Token = "0x6000A37")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	[Address(RVA = "0x33A29F0", Offset = "0x33A1DF0", Length = "0x310")]
	[Token(Token = "0x6000A3C")]
	internal virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	[Address(RVA = "0x33A2D10", Offset = "0x33A2110", Length = "0x236")]
	[Token(Token = "0x6000A3D")]
	internal virtual void ComputeValueFromKey(SliderKey<Int32> sliderKey, bool isShift) { }

	[Address(RVA = "0x33A34F0", Offset = "0x33A28F0", Length = "0x39")]
	[Token(Token = "0x6000A35")]
	public virtual float get_pageSize() { }

	[Address(RVA = "0x33A2F50", Offset = "0x33A2350", Length = "0xA4")]
	[Token(Token = "0x6000A3B")]
	internal virtual int ParseStringToValue(string previousValue, string newValue) { }

	[Address(RVA = "0x33A3530", Offset = "0x33A2930", Length = "0x8E")]
	[Token(Token = "0x6000A36")]
	public virtual void set_pageSize(float value) { }

	[Address(RVA = "0x33A3000", Offset = "0x33A2400", Length = "0x6B")]
	[Token(Token = "0x6000A38")]
	internal virtual int SliderLerpUnclamped(int a, int b, float interpolant) { }

	[Address(RVA = "0x33A3070", Offset = "0x33A2470", Length = "0x3A")]
	[Token(Token = "0x6000A39")]
	internal virtual float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue) { }

	[Address(RVA = "0x33A30B0", Offset = "0x33A24B0", Length = "0x8C")]
	[Token(Token = "0x6000A3A")]
	internal virtual int SliderRange() { }

}

