namespace System.Runtime.CompilerServices;

[Token(Token = "0x200024A")]
public class CallSite
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000418")]
	internal readonly CallSiteBinder _binder; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000419")]
	internal bool _match; //Field offset: 0x18

	[Token(Token = "0x17000249")]
	public CallSiteBinder Binder
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000B26")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000B25")]
	internal CallSite(CallSiteBinder binder) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000B26")]
	public CallSiteBinder get_Binder() { }

}

