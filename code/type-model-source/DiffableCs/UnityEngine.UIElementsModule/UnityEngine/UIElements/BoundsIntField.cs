namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x200009A")]
public class BoundsIntField : BaseField<BoundsInt>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200009B")]
	internal class UxmlFactory : UxmlFactory<BoundsIntField, UxmlTraits>
	{

		[Address(RVA = "0x3346B60", Offset = "0x3345F60", Length = "0x39")]
		[Token(Token = "0x60005B1")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200009C")]
	internal class UxmlTraits : UxmlTraits<BoundsInt>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000372")]
		private UxmlIntAttributeDescription m_PositionXValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000373")]
		private UxmlIntAttributeDescription m_PositionYValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000374")]
		private UxmlIntAttributeDescription m_PositionZValue; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000375")]
		private UxmlIntAttributeDescription m_SizeXValue; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000376")]
		private UxmlIntAttributeDescription m_SizeYValue; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000377")]
		private UxmlIntAttributeDescription m_SizeZValue; //Field offset: 0xC0

		[Address(RVA = "0x334A790", Offset = "0x3349B90", Length = "0x25F")]
		[Token(Token = "0x60005B3")]
		public UxmlTraits() { }

		[Address(RVA = "0x3348290", Offset = "0x3347690", Length = "0x319")]
		[Token(Token = "0x60005B2")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400036D")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400036E")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x400036F")]
	public static readonly string inputUssClassName; //Field offset: 0x10
	[Token(Token = "0x4000370")]
	public static readonly string positionUssClassName; //Field offset: 0x18
	[Token(Token = "0x4000371")]
	public static readonly string sizeUssClassName; //Field offset: 0x20
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x400036B")]
	private Vector3IntField m_PositionField; //Field offset: 0x368
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x400036C")]
	private Vector3IntField m_SizeField; //Field offset: 0x370

	[Address(RVA = "0x3338F80", Offset = "0x3338380", Length = "0x1C2")]
	[Token(Token = "0x60005AE")]
	private static BoundsIntField() { }

	[Address(RVA = "0x3339150", Offset = "0x3338550", Length = "0xA")]
	[Token(Token = "0x60005AA")]
	public BoundsIntField() { }

	[Address(RVA = "0x3339160", Offset = "0x3338560", Length = "0x404")]
	[Token(Token = "0x60005AB")]
	public BoundsIntField(string label) { }

	[Address(RVA = "0x3338D90", Offset = "0x3338190", Length = "0xA9")]
	[CompilerGenerated]
	[Token(Token = "0x60005AF")]
	private void <.ctor>b__11_0(ChangeEvent<Vector3Int> e) { }

	[Address(RVA = "0x3338E40", Offset = "0x3338240", Length = "0xB2")]
	[CompilerGenerated]
	[Token(Token = "0x60005B0")]
	private void <.ctor>b__11_1(ChangeEvent<Vector3Int> e) { }

	[Address(RVA = "0x3338C70", Offset = "0x3338070", Length = "0x111")]
	[Token(Token = "0x60005AC")]
	public virtual void SetValueWithoutNotify(BoundsInt newValue) { }

	[Address(RVA = "0x3338F00", Offset = "0x3338300", Length = "0x79")]
	[Token(Token = "0x60005AD")]
	protected virtual void UpdateMixedValueContent() { }

}

