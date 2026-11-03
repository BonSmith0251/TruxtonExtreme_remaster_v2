namespace System.Runtime.Serialization;

[Token(Token = "0x20003E3")]
public sealed class SerializationObjectManager
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F35")]
	private readonly Dictionary<Object, Object> _objectSeenTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F36")]
	private readonly StreamingContext _context; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F37")]
	private SerializationEventHandler _onSerializedHandler; //Field offset: 0x28

	[Address(RVA = "0x1F14180", Offset = "0x1F13580", Length = "0x8C")]
	[Token(Token = "0x6001DBA")]
	public SerializationObjectManager(StreamingContext context) { }

	[Address(RVA = "0x1F13EF0", Offset = "0x1F132F0", Length = "0x9E")]
	[Token(Token = "0x6001DBD")]
	private void AddOnSerialized(object obj) { }

	[Address(RVA = "0x1F13F90", Offset = "0x1F13390", Length = "0x31")]
	[Token(Token = "0x6001DBC")]
	public void RaiseOnSerializedEvent() { }

	[Address(RVA = "0x1F13FD0", Offset = "0x1F133D0", Length = "0x1A3")]
	[Token(Token = "0x6001DBB")]
	public void RegisterObject(object obj) { }

}

