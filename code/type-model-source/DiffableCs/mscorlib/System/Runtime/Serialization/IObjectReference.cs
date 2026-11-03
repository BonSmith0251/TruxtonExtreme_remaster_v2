namespace System.Runtime.Serialization;

[Token(Token = "0x20003D4")]
public interface IObjectReference
{

	[Token(Token = "0x6001D84")]
	public object GetRealObject(StreamingContext context) { }

}

