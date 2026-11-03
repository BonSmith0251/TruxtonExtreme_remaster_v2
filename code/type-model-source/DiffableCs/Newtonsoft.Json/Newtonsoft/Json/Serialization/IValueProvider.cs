namespace Newtonsoft.Json.Serialization;

[NullableContext(1)]
[Token(Token = "0x2000111")]
public interface IValueProvider
{

	[Token(Token = "0x60007CB")]
	public object GetValue(object target) { }

	[Token(Token = "0x60007CA")]
	public void SetValue(object target, object value) { }

}

