namespace System.Runtime.Serialization;

[Token(Token = "0x20003F3")]
internal sealed class SafeSerializationManager : IObjectReference, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F6F")]
	private IList<Object> m_serializedStates; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F70")]
	private SerializationInfo m_savedSerializationInfo; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F71")]
	private object m_realObject; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F72")]
	private RuntimeType m_realType; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F73")]
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; //Field offset: 0x30

	[Token(Token = "0x170003CA")]
	internal bool IsActive
	{
		[Address(RVA = "0x1550FC0", Offset = "0x15503C0", Length = "0x9")]
		[Token(Token = "0x6001E45")]
		internal get { } //Length: 9
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001E43")]
	internal SafeSerializationManager() { }

	[Address(RVA = "0x1F290F0", Offset = "0x1F284F0", Length = "0x240")]
	[Token(Token = "0x6001E44")]
	private SafeSerializationManager(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F28650", Offset = "0x1F27A50", Length = "0x2D5")]
	[Token(Token = "0x6001E47")]
	internal void CompleteDeserialization(object deserializedObject) { }

	[Address(RVA = "0x1F28930", Offset = "0x1F27D30", Length = "0x292")]
	[Token(Token = "0x6001E46")]
	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1550FC0", Offset = "0x15503C0", Length = "0x9")]
	[Token(Token = "0x6001E45")]
	internal bool get_IsActive() { }

	[Address(RVA = "0x1F28BD0", Offset = "0x1F27FD0", Length = "0xAE")]
	[OnDeserialized]
	[Token(Token = "0x6001E4A")]
	private void OnDeserialized(StreamingContext context) { }

	[Address(RVA = "0x1F28C80", Offset = "0x1F28080", Length = "0x32D")]
	[Token(Token = "0x6001E49")]
	private override object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[Address(RVA = "0x1F28FB0", Offset = "0x1F283B0", Length = "0x13B")]
	[Token(Token = "0x6001E48")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

