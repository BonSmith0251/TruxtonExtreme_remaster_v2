namespace System.Net;

[Token(Token = "0x200024F")]
internal class KnownHttpVerb
{
	[Token(Token = "0x4000939")]
	private static ListDictionary NamedHeaders; //Field offset: 0x0
	[Token(Token = "0x400093A")]
	internal static KnownHttpVerb Get; //Field offset: 0x8
	[Token(Token = "0x400093B")]
	internal static KnownHttpVerb Connect; //Field offset: 0x10
	[Token(Token = "0x400093C")]
	internal static KnownHttpVerb Head; //Field offset: 0x18
	[Token(Token = "0x400093D")]
	internal static KnownHttpVerb Put; //Field offset: 0x20
	[Token(Token = "0x400093E")]
	internal static KnownHttpVerb Post; //Field offset: 0x28
	[Token(Token = "0x400093F")]
	internal static KnownHttpVerb MkCol; //Field offset: 0x30
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000934")]
	internal string Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000935")]
	internal bool RequireContentBody; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000936")]
	internal bool ContentBodyNotAllowed; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x4000937")]
	internal bool ConnectRequest; //Field offset: 0x1A
	[FieldOffset(Offset = "0x1B")]
	[Token(Token = "0x4000938")]
	internal bool ExpectNoContentResponse; //Field offset: 0x1B

	[Address(RVA = "0x26AA970", Offset = "0x26A9D70", Length = "0x480")]
	[Token(Token = "0x6000F84")]
	private static KnownHttpVerb() { }

	[Address(RVA = "0x26AAE00", Offset = "0x26AA200", Length = "0x66")]
	[Token(Token = "0x6000F83")]
	internal KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse) { }

	[Address(RVA = "0x26AA890", Offset = "0x26A9C90", Length = "0xD5")]
	[Token(Token = "0x6000F85")]
	public static KnownHttpVerb Parse(string name) { }

}

