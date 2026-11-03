namespace System.Reflection;

[ComVisible(True)]
[Token(Token = "0x2000526")]
public class StrongNameKeyPair : ISerializable, IDeserializationCallback
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400149B")]
	private Byte[] _publicKey; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400149C")]
	private string _keyPairContainer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400149D")]
	private bool _keyPairExported; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400149E")]
	private Byte[] _keyPairArray; //Field offset: 0x28

	[Address(RVA = "0x1F6D8B0", Offset = "0x1F6CCB0", Length = "0x20E")]
	[Token(Token = "0x6002524")]
	protected StrongNameKeyPair(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6002526")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0x1F6D780", Offset = "0x1F6CB80", Length = "0x12E")]
	[Token(Token = "0x6002525")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

