namespace UnityEngine.UIElements;

[Token(Token = "0x20004FA")]
public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription<Int64>
{
	[CompilerGenerated]
	[Token(Token = "0x20004FB")]
	private sealed class <>c
	{
		[Token(Token = "0x4001098")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001099")]
		public static Func<String, Int64, Int64> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x32BB760", Offset = "0x32BAB60", Length = "0x67")]
		[Token(Token = "0x6002561")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002562")]
		public <>c() { }

		[Address(RVA = "0x32BAA80", Offset = "0x32B9E80", Length = "0x3C")]
		[Token(Token = "0x6002563")]
		internal long <GetValueFromBag>b__3_0(string s, long l) { }

	}


	[Address(RVA = "0x32C4CA0", Offset = "0x32C40A0", Length = "0x8E")]
	[Token(Token = "0x600255E")]
	public UxmlLongAttributeDescription() { }

	[Address(RVA = "0x32C4AE0", Offset = "0x32C3EE0", Length = "0x36")]
	[Token(Token = "0x6002560")]
	private static long ConvertValueToLong(string v, long defaultValue) { }

	[Address(RVA = "0x32C4B20", Offset = "0x32C3F20", Length = "0x176")]
	[Token(Token = "0x600255F")]
	public virtual long GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

