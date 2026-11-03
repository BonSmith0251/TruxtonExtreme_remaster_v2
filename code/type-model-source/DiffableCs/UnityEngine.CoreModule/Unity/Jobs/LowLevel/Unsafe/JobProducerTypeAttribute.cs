namespace Unity.Jobs.LowLevel.Unsafe;

[AttributeUsage(AttributeTargets::Interface (1024))]
[Token(Token = "0x2000019")]
public sealed class JobProducerTypeAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000F")]
	private readonly Type <ProducerType>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000037")]
	public JobProducerTypeAttribute(Type producerType) { }

}

