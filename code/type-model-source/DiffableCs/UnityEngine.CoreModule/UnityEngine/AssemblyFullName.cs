namespace UnityEngine;

[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x20001A0")]
internal struct AssemblyFullName
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("name")]
	[Token(Token = "0x400065A")]
	public string Name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("version")]
	[Token(Token = "0x400065B")]
	public AssemblyVersion Version; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeName("publicKeyToken")]
	[Token(Token = "0x400065C")]
	public string PublicKeyToken; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeName("culture")]
	[Token(Token = "0x400065D")]
	public string Culture; //Field offset: 0x18

	[Address(RVA = "0x3054020", Offset = "0x3053420", Length = "0x123")]
	[Token(Token = "0x60012D7")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x3054150", Offset = "0x3053550", Length = "0x95")]
	[Token(Token = "0x60012D8")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30541F0", Offset = "0x30535F0", Length = "0x201")]
	[Token(Token = "0x60012D9")]
	public virtual string ToString() { }

}

