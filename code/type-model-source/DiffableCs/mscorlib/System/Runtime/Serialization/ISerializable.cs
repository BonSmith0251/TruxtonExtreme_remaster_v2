namespace System.Runtime.Serialization;

[Token(Token = "0x20003D5")]
public interface ISerializable
{

	[Token(Token = "0x6001D85")]
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

