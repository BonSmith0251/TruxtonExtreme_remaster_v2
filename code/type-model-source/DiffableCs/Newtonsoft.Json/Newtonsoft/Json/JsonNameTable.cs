namespace Newtonsoft.Json;

[Token(Token = "0x2000023")]
public abstract class JsonNameTable
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000A1")]
	protected JsonNameTable() { }

	[NullableContext(1)]
	[Token(Token = "0x60000A0")]
	public abstract string Get(Char[] key, int start, int length) { }

}

