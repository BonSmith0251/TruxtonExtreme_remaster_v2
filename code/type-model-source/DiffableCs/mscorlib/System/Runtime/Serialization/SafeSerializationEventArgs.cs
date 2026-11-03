namespace System.Runtime.Serialization;

[Token(Token = "0x20003F1")]
public sealed class SafeSerializationEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F6D")]
	private StreamingContext m_streamingContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F6E")]
	private List<Object> m_serializedStates; //Field offset: 0x20

	[Token(Token = "0x170003C9")]
	internal IList<Object> SerializedStates
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001E41")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1F28590", Offset = "0x1F27990", Length = "0xB7")]
	[Token(Token = "0x6001E40")]
	internal SafeSerializationEventArgs(StreamingContext streamingContext) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001E41")]
	internal IList<Object> get_SerializedStates() { }

}

