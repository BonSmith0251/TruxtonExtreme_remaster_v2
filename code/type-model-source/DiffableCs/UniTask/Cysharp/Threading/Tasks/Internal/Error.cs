namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x200020F")]
internal static class Error
{

	[Address(RVA = "0x2788BE0", Offset = "0x2787FE0", Length = "0x54")]
	[Token(Token = "0x6000BFC")]
	public static Exception ArgumentOutOfRange(string paramName) { }

	[Address(RVA = "0x2788C40", Offset = "0x2788040", Length = "0x58")]
	[Token(Token = "0x6000BFE")]
	public static Exception MoreThanOneElement() { }

	[Address(RVA = "0x2788CA0", Offset = "0x27880A0", Length = "0x58")]
	[Token(Token = "0x6000BFD")]
	public static Exception NoElements() { }

	[Address(RVA = "0x7E8E80", Offset = "0x7E8280", Length = "0x45")]
	[Token(Token = "0x6000BFF")]
	public static void ThrowArgumentException(string message) { }

	[Address(RVA = "0x7E8ED0", Offset = "0x7E82D0", Length = "0x13")]
	[Token(Token = "0x6000BFA")]
	public static void ThrowArgumentNullException(T value, string paramName) { }

	[Address(RVA = "0x2788D00", Offset = "0x2788100", Length = "0x49")]
	[Token(Token = "0x6000BFB")]
	private static void ThrowArgumentNullExceptionCore(string paramName) { }

	[Address(RVA = "0x2788D50", Offset = "0x2788150", Length = "0x49")]
	[Token(Token = "0x6000C03")]
	private static void ThrowInvalidOperationExceptionCore(string message) { }

	[Address(RVA = "0x2788DA0", Offset = "0x27881A0", Length = "0x4E")]
	[Token(Token = "0x6000C00")]
	public static void ThrowNotYetCompleted() { }

	[Address(RVA = "0x7E8EF0", Offset = "0x7E82F0", Length = "0x49")]
	[Token(Token = "0x6000C01")]
	public static T ThrowNotYetCompleted() { }

	[Address(RVA = "0x2788DF0", Offset = "0x27881F0", Length = "0x3E")]
	[Token(Token = "0x6000C04")]
	public static void ThrowOperationCanceledException() { }

	[Address(RVA = "0x7E8F40", Offset = "0x7E8340", Length = "0x43")]
	[Token(Token = "0x6000C02")]
	public static void ThrowWhenContinuationIsAlreadyRegistered(T continuationField) { }

}

