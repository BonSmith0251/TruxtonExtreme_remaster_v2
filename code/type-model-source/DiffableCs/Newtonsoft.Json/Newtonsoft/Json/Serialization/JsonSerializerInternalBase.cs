namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000125")]
internal abstract class JsonSerializerInternalBase
{
	[NullableContext(0)]
	[Token(Token = "0x2000126")]
	private class ReferenceEqualsEqualityComparer : IEqualityComparer<Object>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60008B1")]
		public ReferenceEqualsEqualityComparer() { }

		[Address(RVA = "0x2152360", Offset = "0x2151760", Length = "0x7")]
		[NullableContext(2)]
		[Token(Token = "0x60008AF")]
		private override bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

		[Address(RVA = "0x2152370", Offset = "0x2151770", Length = "0xA")]
		[NullableContext(1)]
		[Token(Token = "0x60008B0")]
		private override int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Nullable(2)]
	[Token(Token = "0x400058A")]
	private ErrorContext _currentErrorContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	[Token(Token = "0x400058B")]
	private BidirectionalDictionary<String, Object> _mappings; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400058C")]
	internal readonly JsonSerializer Serializer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Nullable(2)]
	[Token(Token = "0x400058D")]
	internal readonly ITraceWriter TraceWriter; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Nullable(2)]
	[Token(Token = "0x400058E")]
	protected JsonSerializerProxy InternalSerializer; //Field offset: 0x30

	[Token(Token = "0x1700014D")]
	internal BidirectionalDictionary<String, Object> DefaultReferenceMappings
	{
		[Address(RVA = "0x21451A0", Offset = "0x21445A0", Length = "0x1F1")]
		[Token(Token = "0x60008AA")]
		internal get { } //Length: 497
	}

	[Address(RVA = "0x21450D0", Offset = "0x21444D0", Length = "0xC8")]
	[Token(Token = "0x60008A9")]
	protected JsonSerializerInternalBase(JsonSerializer serializer) { }

	[Address(RVA = "0x2144A40", Offset = "0x2143E40", Length = "0x74")]
	[Token(Token = "0x60008AD")]
	protected void ClearErrorContext() { }

	[Address(RVA = "0x21451A0", Offset = "0x21445A0", Length = "0x1F1")]
	[Token(Token = "0x60008AA")]
	internal BidirectionalDictionary<String, Object> get_DefaultReferenceMappings() { }

	[Address(RVA = "0x2144AC0", Offset = "0x2143EC0", Length = "0x130")]
	[Token(Token = "0x60008AC")]
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	[Address(RVA = "0x2144C00", Offset = "0x2144000", Length = "0x42A")]
	[NullableContext(2)]
	[Token(Token = "0x60008AE")]
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }

	[Address(RVA = "0x2145030", Offset = "0x2144430", Length = "0x99")]
	[Token(Token = "0x60008AB")]
	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

}

