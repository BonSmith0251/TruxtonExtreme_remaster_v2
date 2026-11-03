namespace UnityEngine.UIElements;

[Token(Token = "0x20004F2")]
public class UxmlDoubleAttributeDescription : TypedUxmlAttributeDescription<Double>
{
	[CompilerGenerated]
	[Token(Token = "0x20004F3")]
	private sealed class <>c
	{
		[Token(Token = "0x400108F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001090")]
		public static Func<String, Double, Double> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x32BB610", Offset = "0x32BAA10", Length = "0x67")]
		[Token(Token = "0x6002547")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002548")]
		public <>c() { }

		[Address(RVA = "0x32BAB20", Offset = "0x32B9F20", Length = "0x98")]
		[Token(Token = "0x6002549")]
		internal double <GetValueFromBag>b__3_0(string s, double d) { }

	}


	[Address(RVA = "0x32C3C30", Offset = "0x32C3030", Length = "0x8E")]
	[Token(Token = "0x6002544")]
	public UxmlDoubleAttributeDescription() { }

	[Address(RVA = "0x32C3A10", Offset = "0x32C2E10", Length = "0x98")]
	[Token(Token = "0x6002546")]
	private static double ConvertValueToDouble(string v, double defaultValue) { }

	[Address(RVA = "0x32C3AB0", Offset = "0x32C2EB0", Length = "0x178")]
	[Token(Token = "0x6002545")]
	public virtual double GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

