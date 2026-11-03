namespace System;

[ComVisible(True)]
[Token(Token = "0x200019A")]
public class TypeLoadException : SystemException, ISerializable
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400065D")]
	private string ClassName; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400065E")]
	private string AssemblyName; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400065F")]
	private string MessageArg; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000660")]
	internal int ResourceId; //Field offset: 0xA8

	[Token(Token = "0x17000145")]
	public virtual string Message
	{
		[Address(RVA = "0x20909D0", Offset = "0x208FDD0", Length = "0x1A")]
		[Token(Token = "0x6000EFF")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x20908E0", Offset = "0x208FCE0", Length = "0x4C")]
	[Token(Token = "0x6000EFD")]
	public TypeLoadException() { }

	[Address(RVA = "0x20908B0", Offset = "0x208FCB0", Length = "0x26")]
	[Token(Token = "0x6000EFE")]
	public TypeLoadException(string message) { }

	[Address(RVA = "0x2090930", Offset = "0x208FD30", Length = "0x94")]
	[Token(Token = "0x6000F01")]
	private TypeLoadException(string className, string assemblyName) { }

	[Address(RVA = "0x2090690", Offset = "0x208FA90", Length = "0xA4")]
	[Token(Token = "0x6000F02")]
	private TypeLoadException(string className, string assemblyName, string messageArg, int resourceId) { }

	[Address(RVA = "0x2090740", Offset = "0x208FB40", Length = "0x164")]
	[Token(Token = "0x6000F03")]
	protected TypeLoadException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x20909D0", Offset = "0x208FDD0", Length = "0x1A")]
	[Token(Token = "0x6000EFF")]
	public virtual string get_Message() { }

	[Address(RVA = "0x2090390", Offset = "0x208F790", Length = "0x1B0")]
	[Token(Token = "0x6000F04")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2090550", Offset = "0x208F950", Length = "0x139")]
	[Token(Token = "0x6000F00")]
	private void SetMessageField() { }

}

