namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000B9")]
public class Vector2IntField : BaseCompositeField<Vector2Int, IntegerField, Int32>
{
	[CompilerGenerated]
	[Token(Token = "0x20000BC")]
	private sealed class <>c
	{
		[Token(Token = "0x40003D2")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003D3")]
		public static Func<Vector2Int, Int32> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x40003D4")]
		public static WriteDelegate<Vector2Int, IntegerField, Int32> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x40003D5")]
		public static Func<Vector2Int, Int32> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x40003D6")]
		public static WriteDelegate<Vector2Int, IntegerField, Int32> <>9__0_3; //Field offset: 0x20

		[Address(RVA = "0x3346220", Offset = "0x3345620", Length = "0x67")]
		[Token(Token = "0x6000623")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000624")]
		public <>c() { }

		[Address(RVA = "0xF59E80", Offset = "0xF59280", Length = "0x3")]
		[Token(Token = "0x6000625")]
		internal int <DescribeFields>b__0_0(Vector2Int r) { }

		[Address(RVA = "0x3165310", Offset = "0x3164710", Length = "0x4")]
		[Token(Token = "0x6000626")]
		internal void <DescribeFields>b__0_1(ref Vector2Int r, int v) { }

		[Address(RVA = "0x3345DB0", Offset = "0x33451B0", Length = "0x7")]
		[Token(Token = "0x6000627")]
		internal int <DescribeFields>b__0_2(Vector2Int r) { }

		[Address(RVA = "0x3165840", Offset = "0x3164C40", Length = "0x5")]
		[Token(Token = "0x6000628")]
		internal void <DescribeFields>b__0_3(ref Vector2Int r, int v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000BA")]
	internal class UxmlFactory : UxmlFactory<Vector2IntField, UxmlTraits>
	{

		[Address(RVA = "0x3346D20", Offset = "0x3346120", Length = "0x39")]
		[Token(Token = "0x6000620")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000BB")]
	internal class UxmlTraits : UxmlTraits<Vector2Int>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40003D0")]
		private UxmlIntAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40003D1")]
		private UxmlIntAttributeDescription m_YValue; //Field offset: 0xA0

		[Address(RVA = "0x334A580", Offset = "0x3349980", Length = "0xFF")]
		[Token(Token = "0x6000622")]
		public UxmlTraits() { }

		[Address(RVA = "0x3348A00", Offset = "0x3347E00", Length = "0x1B3")]
		[Token(Token = "0x6000621")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40003CD")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40003CE")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40003CF")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x334C250", Offset = "0x334B650", Length = "0x112")]
	[Token(Token = "0x600061F")]
	private static Vector2IntField() { }

	[Address(RVA = "0x334C4A0", Offset = "0x334B8A0", Length = "0x116")]
	[Token(Token = "0x600061D")]
	public Vector2IntField() { }

	[Address(RVA = "0x334C370", Offset = "0x334B770", Length = "0x123")]
	[Token(Token = "0x600061E")]
	public Vector2IntField(string label) { }

	[Address(RVA = "0x334BDF0", Offset = "0x334B1F0", Length = "0x456")]
	[Token(Token = "0x600061C")]
	internal virtual FieldDescription<Vector2Int, IntegerField, Int32>[] DescribeFields() { }

}

