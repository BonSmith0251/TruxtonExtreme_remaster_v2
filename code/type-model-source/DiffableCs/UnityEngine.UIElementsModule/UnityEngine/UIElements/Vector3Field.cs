namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000B1")]
public class Vector3Field : BaseCompositeField<Vector3, FloatField, Single>
{
	[CompilerGenerated]
	[Token(Token = "0x20000B4")]
	private sealed class <>c
	{
		[Token(Token = "0x40003B6")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003B7")]
		public static Func<Vector3, Single> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x40003B8")]
		public static WriteDelegate<Vector3, FloatField, Single> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x40003B9")]
		public static Func<Vector3, Single> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x40003BA")]
		public static WriteDelegate<Vector3, FloatField, Single> <>9__0_3; //Field offset: 0x20
		[Token(Token = "0x40003BB")]
		public static Func<Vector3, Single> <>9__0_4; //Field offset: 0x28
		[Token(Token = "0x40003BC")]
		public static WriteDelegate<Vector3, FloatField, Single> <>9__0_5; //Field offset: 0x30

		[Address(RVA = "0x3346300", Offset = "0x3345700", Length = "0x67")]
		[Token(Token = "0x6000603")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000604")]
		public <>c() { }

		[Address(RVA = "0xA502C0", Offset = "0xA4F6C0", Length = "0x5")]
		[Token(Token = "0x6000605")]
		internal float <DescribeFields>b__0_0(Vector3 r) { }

		[Address(RVA = "0x315FB30", Offset = "0x315EF30", Length = "0x5")]
		[Token(Token = "0x6000606")]
		internal void <DescribeFields>b__0_1(ref Vector3 r, float v) { }

		[Address(RVA = "0x3142140", Offset = "0x3141540", Length = "0x6")]
		[Token(Token = "0x6000607")]
		internal float <DescribeFields>b__0_2(Vector3 r) { }

		[Address(RVA = "0x3142150", Offset = "0x3141550", Length = "0x6")]
		[Token(Token = "0x6000608")]
		internal void <DescribeFields>b__0_3(ref Vector3 r, float v) { }

		[Address(RVA = "0x3141490", Offset = "0x3140890", Length = "0x6")]
		[Token(Token = "0x6000609")]
		internal float <DescribeFields>b__0_4(Vector3 r) { }

		[Address(RVA = "0x31414A0", Offset = "0x31408A0", Length = "0x6")]
		[Token(Token = "0x600060A")]
		internal void <DescribeFields>b__0_5(ref Vector3 r, float v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000B2")]
	internal class UxmlFactory : UxmlFactory<Vector3Field, UxmlTraits>
	{

		[Address(RVA = "0x33469E0", Offset = "0x3345DE0", Length = "0x39")]
		[Token(Token = "0x6000600")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000B3")]
	internal class UxmlTraits : UxmlTraits<Vector3>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40003B3")]
		private UxmlFloatAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40003B4")]
		private UxmlFloatAttributeDescription m_YValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40003B5")]
		private UxmlFloatAttributeDescription m_ZValue; //Field offset: 0xA8

		[Address(RVA = "0x334A000", Offset = "0x3349400", Length = "0x157")]
		[Token(Token = "0x6000602")]
		public UxmlTraits() { }

		[Address(RVA = "0x3349840", Offset = "0x3348C40", Length = "0x22B")]
		[Token(Token = "0x6000601")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40003B0")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40003B1")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40003B2")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x334CBF0", Offset = "0x334BFF0", Length = "0x112")]
	[Token(Token = "0x60005FF")]
	private static Vector3Field() { }

	[Address(RVA = "0x334CE40", Offset = "0x334C240", Length = "0xA")]
	[Token(Token = "0x60005FD")]
	public Vector3Field() { }

	[Address(RVA = "0x334CD10", Offset = "0x334C110", Length = "0x123")]
	[Token(Token = "0x60005FE")]
	public Vector3Field(string label) { }

	[Address(RVA = "0x334C5C0", Offset = "0x334B9C0", Length = "0x626")]
	[Token(Token = "0x60005FC")]
	internal virtual FieldDescription<Vector3, FloatField, Single>[] DescribeFields() { }

}

