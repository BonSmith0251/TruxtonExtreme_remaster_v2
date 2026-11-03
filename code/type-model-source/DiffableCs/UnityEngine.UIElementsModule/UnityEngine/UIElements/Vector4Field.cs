namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000B5")]
public class Vector4Field : BaseCompositeField<Vector4, FloatField, Single>
{
	[CompilerGenerated]
	[Token(Token = "0x20000B8")]
	private sealed class <>c
	{
		[Token(Token = "0x40003C4")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003C5")]
		public static Func<Vector4, Single> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x40003C6")]
		public static WriteDelegate<Vector4, FloatField, Single> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x40003C7")]
		public static Func<Vector4, Single> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x40003C8")]
		public static WriteDelegate<Vector4, FloatField, Single> <>9__0_3; //Field offset: 0x20
		[Token(Token = "0x40003C9")]
		public static Func<Vector4, Single> <>9__0_4; //Field offset: 0x28
		[Token(Token = "0x40003CA")]
		public static WriteDelegate<Vector4, FloatField, Single> <>9__0_5; //Field offset: 0x30
		[Token(Token = "0x40003CB")]
		public static Func<Vector4, Single> <>9__0_6; //Field offset: 0x38
		[Token(Token = "0x40003CC")]
		public static WriteDelegate<Vector4, FloatField, Single> <>9__0_7; //Field offset: 0x40

		[Address(RVA = "0x3346530", Offset = "0x3345930", Length = "0x67")]
		[Token(Token = "0x6000612")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000613")]
		public <>c() { }

		[Address(RVA = "0xA502C0", Offset = "0xA4F6C0", Length = "0x5")]
		[Token(Token = "0x6000614")]
		internal float <DescribeFields>b__0_0(Vector4 r) { }

		[Address(RVA = "0x315FB30", Offset = "0x315EF30", Length = "0x5")]
		[Token(Token = "0x6000615")]
		internal void <DescribeFields>b__0_1(ref Vector4 r, float v) { }

		[Address(RVA = "0x3142140", Offset = "0x3141540", Length = "0x6")]
		[Token(Token = "0x6000616")]
		internal float <DescribeFields>b__0_2(Vector4 r) { }

		[Address(RVA = "0x3142150", Offset = "0x3141550", Length = "0x6")]
		[Token(Token = "0x6000617")]
		internal void <DescribeFields>b__0_3(ref Vector4 r, float v) { }

		[Address(RVA = "0x3141490", Offset = "0x3140890", Length = "0x6")]
		[Token(Token = "0x6000618")]
		internal float <DescribeFields>b__0_4(Vector4 r) { }

		[Address(RVA = "0x31414A0", Offset = "0x31408A0", Length = "0x6")]
		[Token(Token = "0x6000619")]
		internal void <DescribeFields>b__0_5(ref Vector4 r, float v) { }

		[Address(RVA = "0x3141210", Offset = "0x3140610", Length = "0x6")]
		[Token(Token = "0x600061A")]
		internal float <DescribeFields>b__0_6(Vector4 r) { }

		[Address(RVA = "0x3141220", Offset = "0x3140620", Length = "0x6")]
		[Token(Token = "0x600061B")]
		internal void <DescribeFields>b__0_7(ref Vector4 r, float v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000B6")]
	internal class UxmlFactory : UxmlFactory<Vector4Field, UxmlTraits>
	{

		[Address(RVA = "0x3346A20", Offset = "0x3345E20", Length = "0x39")]
		[Token(Token = "0x600060F")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000B7")]
	internal class UxmlTraits : UxmlTraits<Vector4>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40003C0")]
		private UxmlFloatAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40003C1")]
		private UxmlFloatAttributeDescription m_YValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40003C2")]
		private UxmlFloatAttributeDescription m_ZValue; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40003C3")]
		private UxmlFloatAttributeDescription m_WValue; //Field offset: 0xB0

		[Address(RVA = "0x3349A70", Offset = "0x3348E70", Length = "0x1AF")]
		[Token(Token = "0x6000611")]
		public UxmlTraits() { }

		[Address(RVA = "0x3346E20", Offset = "0x3346220", Length = "0x29A")]
		[Token(Token = "0x6000610")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40003BD")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40003BE")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40003BF")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x334DEE0", Offset = "0x334D2E0", Length = "0x112")]
	[Token(Token = "0x600060E")]
	private static Vector4Field() { }

	[Address(RVA = "0x334E000", Offset = "0x334D400", Length = "0x116")]
	[Token(Token = "0x600060C")]
	public Vector4Field() { }

	[Address(RVA = "0x334E120", Offset = "0x334D520", Length = "0x19C")]
	[Token(Token = "0x600060D")]
	public Vector4Field(string label) { }

	[Address(RVA = "0x334D6E0", Offset = "0x334CAE0", Length = "0x7FF")]
	[Token(Token = "0x600060B")]
	internal virtual FieldDescription<Vector4, FloatField, Single>[] DescribeFields() { }

}

