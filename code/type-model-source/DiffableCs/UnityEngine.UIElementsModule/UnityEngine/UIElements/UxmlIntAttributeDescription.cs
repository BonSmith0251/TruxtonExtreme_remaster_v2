namespace UnityEngine.UIElements;

[Token(Token = "0x20004F4")]
public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<Int32>
{
	[CompilerGenerated]
	[Token(Token = "0x20004F5")]
	private sealed class <>c
	{
		[Token(Token = "0x4001091")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001092")]
		public static Func<String, Int32, Int32> <>9__3_0; //Field offset: 0x8
		[Token(Token = "0x4001093")]
		public static Func<String, Int32, Int32> <>9__4_0; //Field offset: 0x10

		[Address(RVA = "0x32BB680", Offset = "0x32BAA80", Length = "0x67")]
		[Token(Token = "0x600254E")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600254F")]
		public <>c() { }

		[Address(RVA = "0x32BAA10", Offset = "0x32B9E10", Length = "0x39")]
		[Token(Token = "0x6002550")]
		internal int <GetValueFromBag>b__3_0(string s, int i) { }

		[Address(RVA = "0x32BAA10", Offset = "0x32B9E10", Length = "0x39")]
		[Token(Token = "0x6002551")]
		internal int <TryGetValueFromBag>b__4_0(string s, int i) { }

	}


	[Address(RVA = "0x32C4A50", Offset = "0x32C3E50", Length = "0x8D")]
	[Token(Token = "0x600254A")]
	public UxmlIntAttributeDescription() { }

	[Address(RVA = "0x32C4710", Offset = "0x32C3B10", Length = "0x32")]
	[Token(Token = "0x600254D")]
	private static int ConvertValueToInt(string v, int defaultValue) { }

	[Address(RVA = "0x32C4750", Offset = "0x32C3B50", Length = "0x174")]
	[Token(Token = "0x600254B")]
	public virtual int GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x32C48D0", Offset = "0x32C3CD0", Length = "0x17F")]
	[Token(Token = "0x600254C")]
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref int value) { }

}

