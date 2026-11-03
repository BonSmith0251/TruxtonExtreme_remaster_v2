namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000AD")]
public class Vector2Field : BaseCompositeField<Vector2, FloatField, Single>
{
	[CompilerGenerated]
	[Token(Token = "0x20000B0")]
	private sealed class <>c
	{
		[Token(Token = "0x40003AB")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003AC")]
		public static Func<Vector2, Single> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x40003AD")]
		public static WriteDelegate<Vector2, FloatField, Single> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x40003AE")]
		public static Func<Vector2, Single> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x40003AF")]
		public static WriteDelegate<Vector2, FloatField, Single> <>9__0_3; //Field offset: 0x20

		[Address(RVA = "0x33464C0", Offset = "0x33458C0", Length = "0x67")]
		[Token(Token = "0x60005F6")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005F7")]
		public <>c() { }

		[Address(RVA = "0x3345BF0", Offset = "0x3344FF0", Length = "0xC")]
		[Token(Token = "0x60005F8")]
		internal float <DescribeFields>b__0_0(Vector2 r) { }

		[Address(RVA = "0x315FB30", Offset = "0x315EF30", Length = "0x5")]
		[Token(Token = "0x60005F9")]
		internal void <DescribeFields>b__0_1(ref Vector2 r, float v) { }

		[Address(RVA = "0x3345DA0", Offset = "0x33451A0", Length = "0xC")]
		[Token(Token = "0x60005FA")]
		internal float <DescribeFields>b__0_2(Vector2 r) { }

		[Address(RVA = "0x3142150", Offset = "0x3141550", Length = "0x6")]
		[Token(Token = "0x60005FB")]
		internal void <DescribeFields>b__0_3(ref Vector2 r, float v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000AE")]
	internal class UxmlFactory : UxmlFactory<Vector2Field, UxmlTraits>
	{

		[Address(RVA = "0x3346BE0", Offset = "0x3345FE0", Length = "0x39")]
		[Token(Token = "0x60005F3")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000AF")]
	internal class UxmlTraits : UxmlTraits<Vector2>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40003A9")]
		private UxmlFloatAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40003AA")]
		private UxmlFloatAttributeDescription m_YValue; //Field offset: 0xA0

		[Address(RVA = "0x334B230", Offset = "0x334A630", Length = "0xFF")]
		[Token(Token = "0x60005F5")]
		public UxmlTraits() { }

		[Address(RVA = "0x3349280", Offset = "0x3348680", Length = "0x1B8")]
		[Token(Token = "0x60005F4")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40003A6")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40003A7")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40003A8")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x334BA80", Offset = "0x334AE80", Length = "0x112")]
	[Token(Token = "0x60005F2")]
	private static Vector2Field() { }

	[Address(RVA = "0x334BBA0", Offset = "0x334AFA0", Length = "0x116")]
	[Token(Token = "0x60005F0")]
	public Vector2Field() { }

	[Address(RVA = "0x334BCC0", Offset = "0x334B0C0", Length = "0x123")]
	[Token(Token = "0x60005F1")]
	public Vector2Field(string label) { }

	[Address(RVA = "0x334B620", Offset = "0x334AA20", Length = "0x456")]
	[Token(Token = "0x60005EF")]
	internal virtual FieldDescription<Vector2, FloatField, Single>[] DescribeFields() { }

}

