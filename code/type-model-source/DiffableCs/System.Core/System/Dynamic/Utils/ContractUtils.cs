namespace System.Dynamic.Utils;

[Token(Token = "0x200027E")]
internal static class ContractUtils
{

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x17000288")]
	public static Exception Unreachable
	{
		[Address(RVA = "0x22ADD10", Offset = "0x22AD110", Length = "0x58")]
		[Token(Token = "0x6000C6B")]
		 get { } //Length: 88
	}

	[Address(RVA = "0x22ADD10", Offset = "0x22AD110", Length = "0x58")]
	[Token(Token = "0x6000C6B")]
	public static Exception get_Unreachable() { }

	[Address(RVA = "0x22ADB70", Offset = "0x22ACF70", Length = "0x72")]
	[Token(Token = "0x6000C70")]
	private static string GetParamName(string paramName, int index) { }

	[Address(RVA = "0x22ADCD0", Offset = "0x22AD0D0", Length = "0x3E")]
	[Token(Token = "0x6000C6C")]
	public static void Requires(bool precondition, string paramName) { }

	[Address(RVA = "0x7AAC30", Offset = "0x7AA030", Length = "0xFA")]
	[Token(Token = "0x6000C71")]
	public static void RequiresArrayRange(IList<T> array, int offset, int count, string offsetName, string countName) { }

	[Address(RVA = "0x22ADC70", Offset = "0x22AD070", Length = "0x54")]
	[Token(Token = "0x6000C6D")]
	public static void RequiresNotNull(object value, string paramName) { }

	[Address(RVA = "0x22ADBF0", Offset = "0x22ACFF0", Length = "0x74")]
	[Token(Token = "0x6000C6E")]
	public static void RequiresNotNull(object value, string paramName, int index) { }

	[Address(RVA = "0x7AAF10", Offset = "0x7AA310", Length = "0x173")]
	[Token(Token = "0x6000C6F")]
	public static void RequiresNotNullItems(IList<T> array, string arrayName) { }

}

