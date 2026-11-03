namespace UnityEngine.Bindings;

[Token(Token = "0x200024F")]
[VisibleToOtherModules]
internal static class ThrowHelper
{

	[Address(RVA = "0x308AFF0", Offset = "0x308A3F0", Length = "0x76")]
	[DoesNotReturn]
	[Token(Token = "0x6001835")]
	public static void ThrowArgumentNullException(object obj, string parameterName) { }

	[Address(RVA = "0x308B070", Offset = "0x308A470", Length = "0x6A")]
	[DoesNotReturn]
	[Token(Token = "0x6001836")]
	public static void ThrowNullReferenceException(object obj) { }

}

