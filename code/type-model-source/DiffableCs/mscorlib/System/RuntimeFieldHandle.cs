namespace System;

[ComVisible(True)]
[Token(Token = "0x20001C5")]
public struct RuntimeFieldHandle : ISerializable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000721")]
	private IntPtr value; //Field offset: 0x0

	[Token(Token = "0x17000166")]
	public IntPtr Value
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6001008")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6001006")]
	internal RuntimeFieldHandle(IntPtr v) { }

	[Address(RVA = "0x2088120", Offset = "0x2087520", Length = "0x191")]
	[Token(Token = "0x6001007")]
	private RuntimeFieldHandle(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2087E80", Offset = "0x2087280", Length = "0xE1")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600100A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6001008")]
	public IntPtr get_Value() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x600100B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2087F70", Offset = "0x2087370", Length = "0x18B")]
	[Token(Token = "0x6001009")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2088110", Offset = "0x2087510", Length = "0x5")]
	[Token(Token = "0x600100D")]
	internal static void SetValue(RuntimeFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) { }

	[Address(RVA = "0x2088100", Offset = "0x2087500", Length = "0x5")]
	[Token(Token = "0x600100E")]
	internal static void SetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, Void* pTypedRef, object value, RuntimeType contextType) { }

	[Address(RVA = "0x2088110", Offset = "0x2087510", Length = "0x5")]
	[Token(Token = "0x600100C")]
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

}

