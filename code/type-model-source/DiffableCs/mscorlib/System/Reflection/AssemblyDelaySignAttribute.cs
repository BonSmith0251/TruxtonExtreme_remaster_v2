namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
[Token(Token = "0x20004CE")]
public sealed class AssemblyDelaySignAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012F0")]
	private readonly bool <DelaySign>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x1F31920", Offset = "0x1F30D20", Length = "0x26")]
	[Token(Token = "0x6002206")]
	public AssemblyDelaySignAttribute(bool delaySign) { }

}

