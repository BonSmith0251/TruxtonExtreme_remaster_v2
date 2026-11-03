namespace System.Runtime.CompilerServices;

[Token(Token = "0x200048A")]
public static class RuntimeFeature
{

	[Token(Token = "0x17000403")]
	public static bool IsDynamicCodeSupported
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60020EE")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60020EE")]
	public static bool get_IsDynamicCodeSupported() { }

}

