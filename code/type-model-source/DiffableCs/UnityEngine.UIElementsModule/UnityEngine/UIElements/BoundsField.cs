namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x2000097")]
public class BoundsField : BaseField<Bounds>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000098")]
	internal class UxmlFactory : UxmlFactory<BoundsField, UxmlTraits>
	{

		[Address(RVA = "0x3346A60", Offset = "0x3345E60", Length = "0x39")]
		[Token(Token = "0x60005A7")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000099")]
	internal class UxmlTraits : UxmlTraits<Bounds>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000365")]
		private UxmlFloatAttributeDescription m_CenterXValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000366")]
		private UxmlFloatAttributeDescription m_CenterYValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000367")]
		private UxmlFloatAttributeDescription m_CenterZValue; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000368")]
		private UxmlFloatAttributeDescription m_ExtentsXValue; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000369")]
		private UxmlFloatAttributeDescription m_ExtentsYValue; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400036A")]
		private UxmlFloatAttributeDescription m_ExtentsZValue; //Field offset: 0xC0

		[Address(RVA = "0x334ADF0", Offset = "0x334A1F0", Length = "0x25F")]
		[Token(Token = "0x60005A9")]
		public UxmlTraits() { }

		[Address(RVA = "0x3347B60", Offset = "0x3346F60", Length = "0x370")]
		[Token(Token = "0x60005A8")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400035E")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400035F")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x4000360")]
	public static readonly string inputUssClassName; //Field offset: 0x10
	[Token(Token = "0x4000361")]
	public static readonly string centerFieldUssClassName; //Field offset: 0x18
	[Token(Token = "0x4000362")]
	public static readonly string extentsFieldUssClassName; //Field offset: 0x20
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x4000363")]
	private Vector3Field m_CenterField; //Field offset: 0x368
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x4000364")]
	private Vector3Field m_ExtentsField; //Field offset: 0x370

	[Address(RVA = "0x3338680", Offset = "0x3337A80", Length = "0x1C2")]
	[Token(Token = "0x60005A4")]
	private static BoundsField() { }

	[Address(RVA = "0x3338C60", Offset = "0x3338060", Length = "0xA")]
	[Token(Token = "0x60005A0")]
	public BoundsField() { }

	[Address(RVA = "0x3338850", Offset = "0x3337C50", Length = "0x404")]
	[Token(Token = "0x60005A1")]
	public BoundsField(string label) { }

	[Address(RVA = "0x3338490", Offset = "0x3337890", Length = "0xA9")]
	[CompilerGenerated]
	[Token(Token = "0x60005A5")]
	private void <.ctor>b__11_0(ChangeEvent<Vector3> e) { }

	[Address(RVA = "0x3338540", Offset = "0x3337940", Length = "0xB2")]
	[CompilerGenerated]
	[Token(Token = "0x60005A6")]
	private void <.ctor>b__11_1(ChangeEvent<Vector3> e) { }

	[Address(RVA = "0x3338370", Offset = "0x3337770", Length = "0x111")]
	[Token(Token = "0x60005A2")]
	public virtual void SetValueWithoutNotify(Bounds newValue) { }

	[Address(RVA = "0x3338600", Offset = "0x3337A00", Length = "0x79")]
	[Token(Token = "0x60005A3")]
	protected virtual void UpdateMixedValueContent() { }

}

