namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003AB")]
internal class CADMessageBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EBC")]
	protected Object[] _args; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EBD")]
	protected Byte[] _serializedArgs; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EBE")]
	protected int _propertyCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EBF")]
	protected CADArgHolder _callContext; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000EC0")]
	internal Byte[] serializedMethod; //Field offset: 0x30

	[Address(RVA = "0x1EFA640", Offset = "0x1EF9A40", Length = "0xA2")]
	[Token(Token = "0x6001C80")]
	public CADMessageBase(IMethodMessage msg) { }

	[Address(RVA = "0x1EF87F0", Offset = "0x1EF7BF0", Length = "0x8C")]
	[Token(Token = "0x6001C8B")]
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }

	[Address(RVA = "0x1EF8880", Offset = "0x1EF7C80", Length = "0x16F")]
	[Token(Token = "0x6001C81")]
	internal MethodBase GetMethod() { }

	[Address(RVA = "0x1EF89F0", Offset = "0x1EF7DF0", Length = "0x214")]
	[Token(Token = "0x6001C82")]
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	[Address(RVA = "0x1EF8C10", Offset = "0x1EF8010", Length = "0x18A")]
	[Token(Token = "0x6001C85")]
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	[Address(RVA = "0x1EF8DA0", Offset = "0x1EF81A0", Length = "0x366")]
	[Token(Token = "0x6001C86")]
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	[Address(RVA = "0x1EF9110", Offset = "0x1EF8510", Length = "0x143")]
	[Token(Token = "0x6001C88")]
	internal Object[] MarshalArguments(Object[] arguments, ref ArrayList args) { }

	[Address(RVA = "0x1EF9260", Offset = "0x1EF8660", Length = "0x4DA")]
	[Token(Token = "0x6001C83")]
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	[Address(RVA = "0x1EF9740", Offset = "0x1EF8B40", Length = "0x1C2")]
	[Token(Token = "0x6001C8A")]
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	[Address(RVA = "0x1EF9910", Offset = "0x1EF8D10", Length = "0x9E0")]
	[Token(Token = "0x6001C87")]
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	[Address(RVA = "0x1EFA370", Offset = "0x1EF9770", Length = "0x143")]
	[Token(Token = "0x6001C89")]
	internal Object[] UnmarshalArguments(Object[] arguments, ArrayList args) { }

	[Address(RVA = "0x1EFA4C0", Offset = "0x1EF98C0", Length = "0x177")]
	[Token(Token = "0x6001C84")]
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

}

