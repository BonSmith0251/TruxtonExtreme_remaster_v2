namespace System;

[Token(Token = "0x200019B")]
internal class UnitySerializationHolder : ISerializable, IObjectReference
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000661")]
	private Type[] m_instantiation; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000662")]
	private Int32[] m_elementTypes; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000663")]
	private int m_genericParameterPosition; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000664")]
	private Type m_declaringType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000665")]
	private MethodBase m_declaringMethod; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000666")]
	private string m_data; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000667")]
	private string m_assemblyName; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000668")]
	private int m_unityType; //Field offset: 0x48

	[Address(RVA = "0x2092390", Offset = "0x2091790", Length = "0x46E")]
	[Token(Token = "0x6000F0A")]
	internal UnitySerializationHolder(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2091170", Offset = "0x2090570", Length = "0x255")]
	[Token(Token = "0x6000F05")]
	internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) { }

	[Address(RVA = "0x20913D0", Offset = "0x20907D0", Length = "0x5F")]
	[Token(Token = "0x6000F0C")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2091430", Offset = "0x2090830", Length = "0x658")]
	[Token(Token = "0x6000F0D")]
	public override object GetRealObject(StreamingContext context) { }

	[Address(RVA = "0x20920A0", Offset = "0x20914A0", Length = "0x10D")]
	[Token(Token = "0x6000F07")]
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType) { }

	[Address(RVA = "0x2091AB0", Offset = "0x2090EB0", Length = "0x48E")]
	[Token(Token = "0x6000F08")]
	internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) { }

	[Address(RVA = "0x2091F40", Offset = "0x2091340", Length = "0x15B")]
	[Token(Token = "0x6000F09")]
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) { }

	[Address(RVA = "0x20921B0", Offset = "0x20915B0", Length = "0x126")]
	[Token(Token = "0x6000F06")]
	internal Type MakeElementTypes(Type type) { }

	[Address(RVA = "0x20922E0", Offset = "0x20916E0", Length = "0xA2")]
	[Token(Token = "0x6000F0B")]
	private void ThrowInsufficientInformation(string field) { }

}

