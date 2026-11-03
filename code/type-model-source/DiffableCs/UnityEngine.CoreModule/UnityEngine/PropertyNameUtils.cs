namespace UnityEngine;

[NativeHeader("Runtime/Utilities/PropertyName.h")]
[Token(Token = "0x2000174")]
internal class PropertyNameUtils
{

	[Address(RVA = "0x306F640", Offset = "0x306EA40", Length = "0x1CA")]
	[FreeFunction("PropertyNameFromStringICall", IsThreadSafe = True)]
	[Token(Token = "0x600120B")]
	public static PropertyName PropertyNameFromString(string name) { }

	[Address(RVA = "0x306F5F0", Offset = "0x306E9F0", Length = "0x42")]
	[Token(Token = "0x600120C")]
	private static void PropertyNameFromString_Injected(ref ManagedSpanWrapper name, out PropertyName ret) { }

}

