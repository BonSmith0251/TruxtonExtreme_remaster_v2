namespace System.Runtime.Serialization;

[Token(Token = "0x20003DC")]
public interface ISerializationSurrogate
{

	[Token(Token = "0x6001DA2")]
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	[Token(Token = "0x6001DA3")]
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) { }

}

