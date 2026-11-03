namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000F9")]
public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
{
	[Token(Token = "0x40004DB")]
	private static readonly object TypeContractCacheLock; //Field offset: 0x0
	[Token(Token = "0x40004DC")]
	private static readonly DefaultJsonNameTable NameTable; //Field offset: 0x8
	[Nullable(new IL2CPP_TYPE_U1[] {2, 0, 1, 1, 1})]
	[Token(Token = "0x40004DD")]
	private static Dictionary<StructMultiKey`2<Type, Type>, JsonContract> _contractCache; //Field offset: 0x10

	[Address(RVA = "0x21347F0", Offset = "0x2133BF0", Length = "0xC4")]
	[Token(Token = "0x600073C")]
	private static CamelCasePropertyNamesContractResolver() { }

	[Address(RVA = "0x21348C0", Offset = "0x2133CC0", Length = "0x99")]
	[Token(Token = "0x6000739")]
	public CamelCasePropertyNamesContractResolver() { }

	[Address(RVA = "0x2134450", Offset = "0x2133850", Length = "0x4F")]
	[Token(Token = "0x600073B")]
	internal virtual DefaultJsonNameTable GetNameTable() { }

	[Address(RVA = "0x21344A0", Offset = "0x21338A0", Length = "0x346")]
	[Token(Token = "0x600073A")]
	public virtual JsonContract ResolveContract(Type type) { }

}

