namespace UnityEngine.Bindings;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x2000258")]
[VisibleToOtherModules]
internal struct OutStringMarshaller
{

	[Address(RVA = "0x307A220", Offset = "0x3079620", Length = "0x86")]
	[Token(Token = "0x6001842")]
	public static string GetStringAndDispose(ManagedSpanWrapper managedSpan) { }

}

