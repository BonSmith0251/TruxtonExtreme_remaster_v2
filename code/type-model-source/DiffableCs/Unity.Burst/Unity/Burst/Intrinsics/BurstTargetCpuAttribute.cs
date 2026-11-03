namespace Unity.Burst.Intrinsics;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False)]
[Preserve]
[Token(Token = "0x2000035")]
internal sealed class BurstTargetCpuAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000180")]
	public readonly BurstTargetCpu TargetCpu; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000A5D")]
	public BurstTargetCpuAttribute(BurstTargetCpu TargetCpu) { }

}

