namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000107")]
internal class DefaultReferenceResolver : IReferenceResolver
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000503")]
	private int _referenceCount; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60007A6")]
	public DefaultReferenceResolver() { }

	[Address(RVA = "0x213CD90", Offset = "0x213C190", Length = "0x7D")]
	[Token(Token = "0x60007A4")]
	public override void AddReference(object context, string reference, object value) { }

	[Address(RVA = "0x213CE10", Offset = "0x213C210", Length = "0xF8")]
	[Token(Token = "0x60007A1")]
	private BidirectionalDictionary<String, Object> GetMappings(object context) { }

	[Address(RVA = "0x213CF10", Offset = "0x213C310", Length = "0xE8")]
	[Token(Token = "0x60007A3")]
	public override string GetReference(object context, object value) { }

	[Address(RVA = "0x213D000", Offset = "0x213C400", Length = "0x7C")]
	[Token(Token = "0x60007A5")]
	public override bool IsReferenced(object context, object value) { }

	[Address(RVA = "0x213D080", Offset = "0x213C480", Length = "0x81")]
	[Token(Token = "0x60007A2")]
	public override object ResolveReference(object context, string reference) { }

}

