namespace System;

[AttributeUsage(AttributeTargets::All (32767), Inherited = True, AllowMultiple = False)]
[Token(Token = "0x20000C2")]
public sealed class CLSCompliantAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002A7")]
	private bool _compliant; //Field offset: 0x10

	[Address(RVA = "0x1F31920", Offset = "0x1F30D20", Length = "0x26")]
	[Token(Token = "0x6000484")]
	public CLSCompliantAttribute(bool isCompliant) { }

}

