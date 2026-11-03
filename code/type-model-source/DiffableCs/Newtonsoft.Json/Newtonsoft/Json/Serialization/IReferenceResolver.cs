namespace Newtonsoft.Json.Serialization;

[NullableContext(1)]
[Token(Token = "0x200010E")]
public interface IReferenceResolver
{

	[Token(Token = "0x60007C5")]
	public void AddReference(object context, string reference, object value) { }

	[Token(Token = "0x60007C3")]
	public string GetReference(object context, object value) { }

	[Token(Token = "0x60007C4")]
	public bool IsReferenced(object context, object value) { }

	[Token(Token = "0x60007C2")]
	public object ResolveReference(object context, string reference) { }

}

