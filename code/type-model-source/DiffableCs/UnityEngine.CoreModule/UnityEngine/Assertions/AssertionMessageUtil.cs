namespace UnityEngine.Assertions;

[Token(Token = "0x2000330")]
internal class AssertionMessageUtil
{

	[Address(RVA = "0x3077400", Offset = "0x3076800", Length = "0x87")]
	[Token(Token = "0x60019DD")]
	public static string BooleanFailureMessage(bool expected) { }

	[Address(RVA = "0x3077490", Offset = "0x3076890", Length = "0xE2")]
	[Token(Token = "0x60019DB")]
	public static string GetEqualityMessage(object actual, object expected, bool expectEqual) { }

	[Address(RVA = "0x3077790", Offset = "0x3076B90", Length = "0x4F")]
	[Token(Token = "0x60019D9")]
	public static string GetMessage(string failureMessage) { }

	[Address(RVA = "0x3077580", Offset = "0x3076980", Length = "0x20A")]
	[Token(Token = "0x60019DA")]
	public static string GetMessage(string failureMessage, string expected) { }

	[Address(RVA = "0x30777E0", Offset = "0x3076BE0", Length = "0x98")]
	[Token(Token = "0x60019DC")]
	public static string NullFailureMessage(object value, bool expectNull) { }

}

