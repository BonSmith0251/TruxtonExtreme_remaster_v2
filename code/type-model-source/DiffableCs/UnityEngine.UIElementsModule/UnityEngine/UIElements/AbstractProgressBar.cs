namespace UnityEngine.UIElements;

[Token(Token = "0x2000131")]
public abstract class AbstractProgressBar : BindableElement, INotifyValueChanged<Single>
{
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000132")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40005ED")]
		private UxmlFloatAttributeDescription m_LowValue; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40005EE")]
		private UxmlFloatAttributeDescription m_HighValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40005EF")]
		private UxmlFloatAttributeDescription m_Value; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40005F0")]
		private UxmlStringAttributeDescription m_Title; //Field offset: 0xA8

		[Address(RVA = "0x33AB990", Offset = "0x33AAD90", Length = "0x1F5")]
		[Token(Token = "0x600096C")]
		public UxmlTraits() { }

		[Address(RVA = "0x33AA1A0", Offset = "0x33A95A0", Length = "0x433")]
		[Token(Token = "0x600096B")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40005DD")]
	internal static readonly BindingId titleProperty; //Field offset: 0x0
	[Token(Token = "0x40005DE")]
	internal static readonly BindingId lowValueProperty; //Field offset: 0x98
	[Token(Token = "0x40005DF")]
	internal static readonly BindingId highValueProperty; //Field offset: 0x130
	[Token(Token = "0x40005E0")]
	internal static readonly BindingId valueProperty; //Field offset: 0x1C8
	[Token(Token = "0x40005E1")]
	public static readonly string ussClassName; //Field offset: 0x260
	[Token(Token = "0x40005E2")]
	public static readonly string containerUssClassName; //Field offset: 0x268
	[Token(Token = "0x40005E3")]
	public static readonly string titleUssClassName; //Field offset: 0x270
	[Token(Token = "0x40005E4")]
	public static readonly string titleContainerUssClassName; //Field offset: 0x278
	[Token(Token = "0x40005E5")]
	public static readonly string progressUssClassName; //Field offset: 0x280
	[Token(Token = "0x40005E6")]
	public static readonly string backgroundUssClassName; //Field offset: 0x288
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x40005E7")]
	private readonly VisualElement m_Background; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x40005E8")]
	private readonly VisualElement m_Progress; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x40005E9")]
	private readonly Label m_Title; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x40005EA")]
	private float m_LowValue; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F4")]
	[Token(Token = "0x40005EB")]
	private float m_HighValue; //Field offset: 0x2F4
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x40005EC")]
	private float m_Value; //Field offset: 0x2F8

	[CreateProperty]
	[Token(Token = "0x17000198")]
	public float highValue
	{
		[Address(RVA = "0x3393510", Offset = "0x3392910", Length = "0x9")]
		[Token(Token = "0x6000961")]
		 get { } //Length: 9
		[Address(RVA = "0x3393560", Offset = "0x3392960", Length = "0xB4")]
		[Token(Token = "0x6000962")]
		 set { } //Length: 180
	}

	[CreateProperty]
	[Token(Token = "0x17000197")]
	public float lowValue
	{
		[Address(RVA = "0x2EF4730", Offset = "0x2EF3B30", Length = "0x9")]
		[Token(Token = "0x600095F")]
		 get { } //Length: 9
		[Address(RVA = "0x3393620", Offset = "0x3392A20", Length = "0xB4")]
		[Token(Token = "0x6000960")]
		 set { } //Length: 180
	}

	[CreateProperty]
	[Token(Token = "0x17000196")]
	public string title
	{
		[Address(RVA = "0x3393520", Offset = "0x3392920", Length = "0x2D")]
		[Token(Token = "0x600095D")]
		 get { } //Length: 45
		[Address(RVA = "0x33936E0", Offset = "0x3392AE0", Length = "0xF5")]
		[Token(Token = "0x600095E")]
		 set { } //Length: 245
	}

	[CreateProperty]
	[Token(Token = "0x17000199")]
	public override float value
	{
		[Address(RVA = "0x3393550", Offset = "0x3392950", Length = "0xB")]
		[Token(Token = "0x6000965")]
		 get { } //Length: 11
		[Address(RVA = "0x33937E0", Offset = "0x3392BE0", Length = "0x32C")]
		[Token(Token = "0x6000966")]
		 set { } //Length: 812
	}

	[Address(RVA = "0x3392C20", Offset = "0x3392020", Length = "0x59F")]
	[Token(Token = "0x600096A")]
	private static AbstractProgressBar() { }

	[Address(RVA = "0x33931C0", Offset = "0x33925C0", Length = "0x349")]
	[Token(Token = "0x6000963")]
	public AbstractProgressBar() { }

	[Address(RVA = "0x3392820", Offset = "0x3391C20", Length = "0x22C")]
	[Token(Token = "0x6000969")]
	private float CalculateOppositeProgressWidth(float width) { }

	[Address(RVA = "0x3393510", Offset = "0x3392910", Length = "0x9")]
	[Token(Token = "0x6000961")]
	public float get_highValue() { }

	[Address(RVA = "0x2EF4730", Offset = "0x2EF3B30", Length = "0x9")]
	[Token(Token = "0x600095F")]
	public float get_lowValue() { }

	[Address(RVA = "0x3393520", Offset = "0x3392920", Length = "0x2D")]
	[Token(Token = "0x600095D")]
	public string get_title() { }

	[Address(RVA = "0x3393550", Offset = "0x3392950", Length = "0xB")]
	[Token(Token = "0x6000965")]
	public override float get_value() { }

	[Address(RVA = "0x3392A50", Offset = "0x3391E50", Length = "0x2F")]
	[Token(Token = "0x6000964")]
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	[Address(RVA = "0x3393560", Offset = "0x3392960", Length = "0xB4")]
	[Token(Token = "0x6000962")]
	public void set_highValue(float value) { }

	[Address(RVA = "0x3393620", Offset = "0x3392A20", Length = "0xB4")]
	[Token(Token = "0x6000960")]
	public void set_lowValue(float value) { }

	[Address(RVA = "0x33936E0", Offset = "0x3392AE0", Length = "0xF5")]
	[Token(Token = "0x600095E")]
	public void set_title(string value) { }

	[Address(RVA = "0x33937E0", Offset = "0x3392BE0", Length = "0x32C")]
	[Token(Token = "0x6000966")]
	public override void set_value(float value) { }

	[Address(RVA = "0x3392A80", Offset = "0x3391E80", Length = "0x15E")]
	[Token(Token = "0x6000968")]
	private void SetProgress(float p) { }

	[Address(RVA = "0x3392BE0", Offset = "0x3391FE0", Length = "0x37")]
	[Token(Token = "0x6000967")]
	public override void SetValueWithoutNotify(float newValue) { }

}

