namespace System;

[ComVisible(True)]
[Token(Token = "0x20001C6")]
public struct RuntimeMethodHandle : ISerializable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000722")]
	private IntPtr value; //Field offset: 0x0

	[Token(Token = "0x17000167")]
	public IntPtr Value
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6001011")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x600100F")]
	internal RuntimeMethodHandle(IntPtr v) { }

	[Address(RVA = "0x20886A0", Offset = "0x2087AA0", Length = "0x191")]
	[Token(Token = "0x6001010")]
	private RuntimeMethodHandle(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x20882C0", Offset = "0x20876C0", Length = "0x15B")]
	[Token(Token = "0x6001015")]
	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) { }

	[Address(RVA = "0x2088420", Offset = "0x2087820", Length = "0xE1")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001013")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6001011")]
	public IntPtr get_Value() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6001014")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2088510", Offset = "0x2087910", Length = "0x18B")]
	[Token(Token = "0x6001012")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
	[Token(Token = "0x6001016")]
	internal bool IsNullHandle() { }

}

