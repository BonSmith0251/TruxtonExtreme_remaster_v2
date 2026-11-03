namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200011D")]
public class JsonDynamicContract : JsonContainerContract
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000550")]
	private readonly JsonPropertyCollection <Properties>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC8")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	[Token(Token = "0x4000551")]
	private Func<String, String> <PropertyNameResolver>k__BackingField; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000552")]
	private readonly ThreadSafeStore<String, CallSite`1<Func`3<CallSite, Object, Object>>> _callSiteGetters; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 1, 1, 1, 1, 2, 1})]
	[Token(Token = "0x4000553")]
	private readonly ThreadSafeStore<String, CallSite`1<Func`4<CallSite, Object, Object, Object>>> _callSiteSetters; //Field offset: 0xD8

	[Token(Token = "0x1700011D")]
	public JsonPropertyCollection Properties
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000826")]
		 get { } //Length: 8
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	[Token(Token = "0x1700011E")]
	public Func<String, String> PropertyNameResolver
	{
		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000827")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000828")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x2142910", Offset = "0x2141D10", Length = "0x1AA")]
	[Token(Token = "0x600082B")]
	public JsonDynamicContract(Type underlyingType) { }

	[Address(RVA = "0x2142460", Offset = "0x2141860", Length = "0xF2")]
	[Token(Token = "0x6000829")]
	private static CallSite<Func`3<CallSite, Object, Object>> CreateCallSiteGetter(string name) { }

	[Address(RVA = "0x2142560", Offset = "0x2141960", Length = "0xF2")]
	[Token(Token = "0x600082A")]
	private static CallSite<Func`4<CallSite, Object, Object, Object>> CreateCallSiteSetter(string name) { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000826")]
	public JsonPropertyCollection get_Properties() { }

	[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000827")]
	public Func<String, String> get_PropertyNameResolver() { }

	[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000828")]
	public void set_PropertyNameResolver(Func<String, String> value) { }

	[Address(RVA = "0x2142660", Offset = "0x2141A60", Length = "0x15E")]
	[Token(Token = "0x600082C")]
	internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, out object value) { }

	[Address(RVA = "0x21427C0", Offset = "0x2141BC0", Length = "0x145")]
	[Token(Token = "0x600082D")]
	internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }

}

