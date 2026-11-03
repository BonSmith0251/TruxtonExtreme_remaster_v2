namespace System.Runtime.Serialization;

[Token(Token = "0x20003E0")]
internal sealed class SerializationEvents
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F2E")]
	private readonly List<MethodInfo> _onSerializingMethods; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F2F")]
	private readonly List<MethodInfo> _onSerializedMethods; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F30")]
	private readonly List<MethodInfo> _onDeserializingMethods; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F31")]
	private readonly List<MethodInfo> _onDeserializedMethods; //Field offset: 0x28

	[Token(Token = "0x170003A8")]
	internal bool HasOnSerializingEvents
	{
		[Address(RVA = "0x1F139D0", Offset = "0x1F12DD0", Length = "0x13")]
		[Token(Token = "0x6001DAD")]
		internal get { } //Length: 19
	}

	[Address(RVA = "0x1F13880", Offset = "0x1F12C80", Length = "0x142")]
	[Token(Token = "0x6001DAB")]
	internal SerializationEvents(Type t) { }

	[Address(RVA = "0x1F13320", Offset = "0x1F12720", Length = "0x1F5")]
	[Token(Token = "0x6001DB4")]
	private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, List<MethodInfo> methods) { }

	[Address(RVA = "0x1F13520", Offset = "0x1F12920", Length = "0x18")]
	[Token(Token = "0x6001DB2")]
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

	[Address(RVA = "0x1F13540", Offset = "0x1F12940", Length = "0x18")]
	[Token(Token = "0x6001DB1")]
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	[Address(RVA = "0x1F139D0", Offset = "0x1F12DD0", Length = "0x13")]
	[Token(Token = "0x6001DAD")]
	internal bool get_HasOnSerializingEvents() { }

	[Address(RVA = "0x1F13560", Offset = "0x1F12960", Length = "0x1E8")]
	[Token(Token = "0x6001DAC")]
	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	[Address(RVA = "0x1F13750", Offset = "0x1F12B50", Length = "0x3A")]
	[Token(Token = "0x6001DB3")]
	private static void InvokeOnDelegate(object obj, StreamingContext context, List<MethodInfo> methods) { }

	[Address(RVA = "0x1F13790", Offset = "0x1F12B90", Length = "0x44")]
	[Token(Token = "0x6001DB0")]
	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	[Address(RVA = "0x1F137E0", Offset = "0x1F12BE0", Length = "0x44")]
	[Token(Token = "0x6001DAF")]
	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	[Address(RVA = "0x1F13830", Offset = "0x1F12C30", Length = "0x44")]
	[Token(Token = "0x6001DAE")]
	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

}

