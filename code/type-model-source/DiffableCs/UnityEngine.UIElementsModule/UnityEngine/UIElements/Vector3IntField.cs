namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000BD")]
public class Vector3IntField : BaseCompositeField<Vector3Int, IntegerField, Int32>
{
	[CompilerGenerated]
	[Token(Token = "0x20000C0")]
	private sealed class <>c
	{
		[Token(Token = "0x40003DD")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003DE")]
		public static Func<Vector3Int, Int32> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x40003DF")]
		public static WriteDelegate<Vector3Int, IntegerField, Int32> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x40003E0")]
		public static Func<Vector3Int, Int32> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x40003E1")]
		public static WriteDelegate<Vector3Int, IntegerField, Int32> <>9__0_3; //Field offset: 0x20
		[Token(Token = "0x40003E2")]
		public static Func<Vector3Int, Int32> <>9__0_4; //Field offset: 0x28
		[Token(Token = "0x40003E3")]
		public static WriteDelegate<Vector3Int, IntegerField, Int32> <>9__0_5; //Field offset: 0x30

		[Address(RVA = "0x3346290", Offset = "0x3345690", Length = "0x67")]
		[Token(Token = "0x6000630")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000631")]
		public <>c() { }

		[Address(RVA = "0x17D3A70", Offset = "0x17D2E70", Length = "0x3")]
		[Token(Token = "0x6000632")]
		internal int <DescribeFields>b__0_0(Vector3Int r) { }

		[Address(RVA = "0x3165310", Offset = "0x3164710", Length = "0x4")]
		[Token(Token = "0x6000633")]
		internal void <DescribeFields>b__0_1(ref Vector3Int r, int v) { }

		[Address(RVA = "0x31656E0", Offset = "0x3164AE0", Length = "0x4")]
		[Token(Token = "0x6000634")]
		internal int <DescribeFields>b__0_2(Vector3Int r) { }

		[Address(RVA = "0x3165840", Offset = "0x3164C40", Length = "0x5")]
		[Token(Token = "0x6000635")]
		internal void <DescribeFields>b__0_3(ref Vector3Int r, int v) { }

		[Address(RVA = "0x3165B60", Offset = "0x3164F60", Length = "0x4")]
		[Token(Token = "0x6000636")]
		internal int <DescribeFields>b__0_4(Vector3Int r) { }

		[Address(RVA = "0x3165B70", Offset = "0x3164F70", Length = "0x5")]
		[Token(Token = "0x6000637")]
		internal void <DescribeFields>b__0_5(ref Vector3Int r, int v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000BE")]
	internal class UxmlFactory : UxmlFactory<Vector3IntField, UxmlTraits>
	{

		[Address(RVA = "0x3346CE0", Offset = "0x33460E0", Length = "0x39")]
		[Token(Token = "0x600062D")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000BF")]
	internal class UxmlTraits : UxmlTraits<Vector3Int>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40003DA")]
		private UxmlIntAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40003DB")]
		private UxmlIntAttributeDescription m_YValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40003DC")]
		private UxmlIntAttributeDescription m_ZValue; //Field offset: 0xA8

		[Address(RVA = "0x334A9F0", Offset = "0x3349DF0", Length = "0x157")]
		[Token(Token = "0x600062F")]
		public UxmlTraits() { }

		[Address(RVA = "0x3349620", Offset = "0x3348A20", Length = "0x21C")]
		[Token(Token = "0x600062E")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40003D7")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40003D8")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40003D9")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x334D480", Offset = "0x334C880", Length = "0x112")]
	[Token(Token = "0x600062C")]
	private static Vector3IntField() { }

	[Address(RVA = "0x334D5A0", Offset = "0x334C9A0", Length = "0xA")]
	[Token(Token = "0x600062A")]
	public Vector3IntField() { }

	[Address(RVA = "0x334D5B0", Offset = "0x334C9B0", Length = "0x123")]
	[Token(Token = "0x600062B")]
	public Vector3IntField(string label) { }

	[Address(RVA = "0x334CE50", Offset = "0x334C250", Length = "0x626")]
	[Token(Token = "0x6000629")]
	internal virtual FieldDescription<Vector3Int, IntegerField, Int32>[] DescribeFields() { }

}

