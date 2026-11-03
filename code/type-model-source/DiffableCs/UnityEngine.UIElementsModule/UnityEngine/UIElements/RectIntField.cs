namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000A9")]
public class RectIntField : BaseCompositeField<RectInt, IntegerField, Int32>
{
	[CompilerGenerated]
	[Token(Token = "0x20000AC")]
	private sealed class <>c
	{
		[Token(Token = "0x400039D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400039E")]
		public static Func<RectInt, Int32> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x400039F")]
		public static WriteDelegate<RectInt, IntegerField, Int32> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x40003A0")]
		public static Func<RectInt, Int32> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x40003A1")]
		public static WriteDelegate<RectInt, IntegerField, Int32> <>9__0_3; //Field offset: 0x20
		[Token(Token = "0x40003A2")]
		public static Func<RectInt, Int32> <>9__0_4; //Field offset: 0x28
		[Token(Token = "0x40003A3")]
		public static WriteDelegate<RectInt, IntegerField, Int32> <>9__0_5; //Field offset: 0x30
		[Token(Token = "0x40003A4")]
		public static Func<RectInt, Int32> <>9__0_6; //Field offset: 0x38
		[Token(Token = "0x40003A5")]
		public static WriteDelegate<RectInt, IntegerField, Int32> <>9__0_7; //Field offset: 0x40

		[Address(RVA = "0x3346450", Offset = "0x3345850", Length = "0x67")]
		[Token(Token = "0x60005E5")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005E6")]
		public <>c() { }

		[Address(RVA = "0x3345BA0", Offset = "0x3344FA0", Length = "0x42")]
		[Token(Token = "0x60005E7")]
		internal int <DescribeFields>b__0_0(RectInt r) { }

		[Address(RVA = "0x3345C50", Offset = "0x3345050", Length = "0x4E")]
		[Token(Token = "0x60005E8")]
		internal void <DescribeFields>b__0_1(ref RectInt r, int v) { }

		[Address(RVA = "0x3345D00", Offset = "0x3345100", Length = "0x43")]
		[Token(Token = "0x60005E9")]
		internal int <DescribeFields>b__0_2(RectInt r) { }

		[Address(RVA = "0x3345E20", Offset = "0x3345220", Length = "0x4F")]
		[Token(Token = "0x60005EA")]
		internal void <DescribeFields>b__0_3(ref RectInt r, int v) { }

		[Address(RVA = "0x3345E70", Offset = "0x3345270", Length = "0x43")]
		[Token(Token = "0x60005EB")]
		internal int <DescribeFields>b__0_4(RectInt r) { }

		[Address(RVA = "0x3345F10", Offset = "0x3345310", Length = "0x4F")]
		[Token(Token = "0x60005EC")]
		internal void <DescribeFields>b__0_5(ref RectInt r, int v) { }

		[Address(RVA = "0x3345FC0", Offset = "0x33453C0", Length = "0x43")]
		[Token(Token = "0x60005ED")]
		internal int <DescribeFields>b__0_6(RectInt r) { }

		[Address(RVA = "0x33460C0", Offset = "0x33454C0", Length = "0x4F")]
		[Token(Token = "0x60005EE")]
		internal void <DescribeFields>b__0_7(ref RectInt r, int v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000AA")]
	internal class UxmlFactory : UxmlFactory<RectIntField, UxmlTraits>
	{

		[Address(RVA = "0x3346BA0", Offset = "0x3345FA0", Length = "0x39")]
		[Token(Token = "0x60005E2")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000AB")]
	internal class UxmlTraits : UxmlTraits<RectInt>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000399")]
		private UxmlIntAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400039A")]
		private UxmlIntAttributeDescription m_YValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400039B")]
		private UxmlIntAttributeDescription m_WValue; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400039C")]
		private UxmlIntAttributeDescription m_HValue; //Field offset: 0xB0

		[Address(RVA = "0x334AB50", Offset = "0x3349F50", Length = "0x1AF")]
		[Token(Token = "0x60005E4")]
		public UxmlTraits() { }

		[Address(RVA = "0x33478F0", Offset = "0x3346CF0", Length = "0x26A")]
		[Token(Token = "0x60005E3")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000396")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4000397")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x4000398")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x3344D90", Offset = "0x3344190", Length = "0x112")]
	[Token(Token = "0x60005E1")]
	private static RectIntField() { }

	[Address(RVA = "0x3344EB0", Offset = "0x33442B0", Length = "0x136")]
	[Token(Token = "0x60005DF")]
	public RectIntField() { }

	[Address(RVA = "0x3344FF0", Offset = "0x33443F0", Length = "0x143")]
	[Token(Token = "0x60005E0")]
	public RectIntField(string label) { }

	[Address(RVA = "0x3344590", Offset = "0x3343990", Length = "0x7FF")]
	[Token(Token = "0x60005DE")]
	internal virtual FieldDescription<RectInt, IntegerField, Int32>[] DescribeFields() { }

}

