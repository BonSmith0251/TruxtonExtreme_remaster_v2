namespace Unity.Collections;

[BurstCompile]
[Token(Token = "0x20000C2")]
internal struct NativeRingQueueDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003ED")]
	public NativeRingQueueDispose Data; //Field offset: 0x0

	[Address(RVA = "0x28C8AE0", Offset = "0x28C7EE0", Length = "0x39")]
	[Token(Token = "0x6000901")]
	public override void Execute() { }

}

