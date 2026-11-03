namespace System;

[Token(Token = "0x2000195")]
internal class ReflectionOnlyType : RuntimeType
{

	[Token(Token = "0x17000143")]
	public virtual RuntimeTypeHandle TypeHandle
	{
		[Address(RVA = "0x2087E20", Offset = "0x2087220", Length = "0x5F")]
		[Token(Token = "0x6000EF2")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x2087DD0", Offset = "0x20871D0", Length = "0x49")]
	[Token(Token = "0x6000EF1")]
	private ReflectionOnlyType() { }

	[Address(RVA = "0x2087E20", Offset = "0x2087220", Length = "0x5F")]
	[Token(Token = "0x6000EF2")]
	public virtual RuntimeTypeHandle get_TypeHandle() { }

}

