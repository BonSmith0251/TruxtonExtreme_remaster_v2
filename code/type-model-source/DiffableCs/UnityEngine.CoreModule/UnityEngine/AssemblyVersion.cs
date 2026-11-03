namespace UnityEngine;

[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200019F")]
internal struct AssemblyVersion
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000656")]
	public ushort major; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000657")]
	public ushort minor; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000658")]
	public ushort build; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000659")]
	public ushort revision; //Field offset: 0x6

	[Address(RVA = "0x3054400", Offset = "0x3053800", Length = "0xA7")]
	[Token(Token = "0x60012D5")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x30544B0", Offset = "0x30538B0", Length = "0x97")]
	[Token(Token = "0x60012D6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3054750", Offset = "0x3053B50", Length = "0x3E")]
	[Token(Token = "0x60012D3")]
	public static bool op_Equality(AssemblyVersion lhs, AssemblyVersion rhs) { }

	[Address(RVA = "0x3054550", Offset = "0x3053950", Length = "0x1FC")]
	[Token(Token = "0x60012D4")]
	public virtual string ToString() { }

}

