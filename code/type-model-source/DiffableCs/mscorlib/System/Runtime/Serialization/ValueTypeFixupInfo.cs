namespace System.Runtime.Serialization;

[Token(Token = "0x20003E4")]
internal sealed class ValueTypeFixupInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F38")]
	private readonly long _containerID; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F39")]
	private readonly FieldInfo _parentField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F3A")]
	private readonly Int32[] _parentIndex; //Field offset: 0x20

	[Token(Token = "0x170003A9")]
	public long ContainerID
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001DBF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003AA")]
	public FieldInfo ParentField
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001DC0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003AB")]
	public Int32[] ParentIndex
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001DC1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1F15AE0", Offset = "0x1F14EE0", Length = "0x1EC")]
	[Token(Token = "0x6001DBE")]
	public ValueTypeFixupInfo(long containerID, FieldInfo member, Int32[] parentIndex) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001DBF")]
	public long get_ContainerID() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001DC0")]
	public FieldInfo get_ParentField() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001DC1")]
	public Int32[] get_ParentIndex() { }

}

