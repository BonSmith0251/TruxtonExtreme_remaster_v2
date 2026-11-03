namespace System.Runtime.Serialization;

[Token(Token = "0x20003DD")]
public interface ISurrogateSelector
{

	[Token(Token = "0x6001DA4")]
	public ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector) { }

}

