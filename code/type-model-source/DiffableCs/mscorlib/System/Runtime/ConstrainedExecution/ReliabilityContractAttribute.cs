namespace System.Runtime.ConstrainedExecution;

[AttributeUsage(1133, Inherited = False)]
[Token(Token = "0x200046A")]
public sealed class ReliabilityContractAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001245")]
	private readonly Consistency <ConsistencyGuarantee>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001246")]
	private readonly Cer <Cer>k__BackingField; //Field offset: 0x14

	[Address(RVA = "0x1F3A2B0", Offset = "0x1F396B0", Length = "0x34")]
	[Token(Token = "0x60020B4")]
	public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer) { }

}

