namespace UnityEngine.Bindings;

[Token(Token = "0x2000255")]
[VisibleToOtherModules]
internal static class ExceptionMarshaller
{
	[ThreadStatic]
	[Token(Token = "0x40007C3")]
	private static Exception s_pendingException; //Field offset: 0x80000000

	[Address(RVA = "0x30789C0", Offset = "0x3077DC0", Length = "0x50")]
	[RequiredByNativeCode]
	[Token(Token = "0x600183E")]
	private static void SetPendingException(Exception ex) { }

}

