namespace Unity.Collections;

[BurstCompile]
[Token(Token = "0x200008C")]
internal struct NativeBitArrayDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003B1")]
	public NativeBitArrayDispose Data; //Field offset: 0x0

	[Address(RVA = "0x28C80B0", Offset = "0x28C74B0", Length = "0x7")]
	[Token(Token = "0x600071D")]
	public override void Execute() { }

}

