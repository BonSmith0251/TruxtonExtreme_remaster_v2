namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000A5")]
public class RectField : BaseCompositeField<Rect, FloatField, Single>
{
	[CompilerGenerated]
	[Token(Token = "0x20000A8")]
	private sealed class <>c
	{
		[Token(Token = "0x400038D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400038E")]
		public static Func<Rect, Single> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x400038F")]
		public static WriteDelegate<Rect, FloatField, Single> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x4000390")]
		public static Func<Rect, Single> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x4000391")]
		public static WriteDelegate<Rect, FloatField, Single> <>9__0_3; //Field offset: 0x20
		[Token(Token = "0x4000392")]
		public static Func<Rect, Single> <>9__0_4; //Field offset: 0x28
		[Token(Token = "0x4000393")]
		public static WriteDelegate<Rect, FloatField, Single> <>9__0_5; //Field offset: 0x30
		[Token(Token = "0x4000394")]
		public static Func<Rect, Single> <>9__0_6; //Field offset: 0x38
		[Token(Token = "0x4000395")]
		public static WriteDelegate<Rect, FloatField, Single> <>9__0_7; //Field offset: 0x40

		[Address(RVA = "0x33461B0", Offset = "0x33455B0", Length = "0x67")]
		[Token(Token = "0x60005D4")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005D5")]
		public <>c() { }

		[Address(RVA = "0x3345C00", Offset = "0x3345000", Length = "0x44")]
		[Token(Token = "0x60005D6")]
		internal float <DescribeFields>b__0_0(Rect r) { }

		[Address(RVA = "0x3345CA0", Offset = "0x33450A0", Length = "0x51")]
		[Token(Token = "0x60005D7")]
		internal void <DescribeFields>b__0_1(ref Rect r, float v) { }

		[Address(RVA = "0x3345D50", Offset = "0x3345150", Length = "0x45")]
		[Token(Token = "0x60005D8")]
		internal float <DescribeFields>b__0_2(Rect r) { }

		[Address(RVA = "0x3345DC0", Offset = "0x33451C0", Length = "0x52")]
		[Token(Token = "0x60005D9")]
		internal void <DescribeFields>b__0_3(ref Rect r, float v) { }

		[Address(RVA = "0x3345EC0", Offset = "0x33452C0", Length = "0x45")]
		[Token(Token = "0x60005DA")]
		internal float <DescribeFields>b__0_4(Rect r) { }

		[Address(RVA = "0x3345F60", Offset = "0x3345360", Length = "0x52")]
		[Token(Token = "0x60005DB")]
		internal void <DescribeFields>b__0_5(ref Rect r, float v) { }

		[Address(RVA = "0x3346010", Offset = "0x3345410", Length = "0x45")]
		[Token(Token = "0x60005DC")]
		internal float <DescribeFields>b__0_6(Rect r) { }

		[Address(RVA = "0x3346060", Offset = "0x3345460", Length = "0x52")]
		[Token(Token = "0x60005DD")]
		internal void <DescribeFields>b__0_7(ref Rect r, float v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000A6")]
	internal class UxmlFactory : UxmlFactory<RectField, UxmlTraits>
	{

		[Address(RVA = "0x3346C20", Offset = "0x3346020", Length = "0x39")]
		[Token(Token = "0x60005D1")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000A7")]
	internal class UxmlTraits : UxmlTraits<Rect>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000389")]
		private UxmlFloatAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400038A")]
		private UxmlFloatAttributeDescription m_YValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400038B")]
		private UxmlFloatAttributeDescription m_WValue; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400038C")]
		private UxmlFloatAttributeDescription m_HValue; //Field offset: 0xB0

		[Address(RVA = "0x334B330", Offset = "0x334A730", Length = "0x1AF")]
		[Token(Token = "0x60005D3")]
		public UxmlTraits() { }

		[Address(RVA = "0x33485B0", Offset = "0x33479B0", Length = "0x29A")]
		[Token(Token = "0x60005D2")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000386")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4000387")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x4000388")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x33441E0", Offset = "0x33435E0", Length = "0x112")]
	[Token(Token = "0x60005D0")]
	private static RectField() { }

	[Address(RVA = "0x3344300", Offset = "0x3343700", Length = "0x136")]
	[Token(Token = "0x60005CE")]
	public RectField() { }

	[Address(RVA = "0x3344440", Offset = "0x3343840", Length = "0x143")]
	[Token(Token = "0x60005CF")]
	public RectField(string label) { }

	[Address(RVA = "0x33439E0", Offset = "0x3342DE0", Length = "0x7FF")]
	[Token(Token = "0x60005CD")]
	internal virtual FieldDescription<Rect, FloatField, Single>[] DescribeFields() { }

}

