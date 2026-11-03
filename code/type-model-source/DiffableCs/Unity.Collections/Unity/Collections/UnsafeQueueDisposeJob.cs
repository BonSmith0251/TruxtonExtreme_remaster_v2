namespace Unity.Collections;

[BurstCompile]
[Token(Token = "0x20000F1")]
internal struct UnsafeQueueDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400046B")]
	public UnsafeQueueDispose Data; //Field offset: 0x0

	[Address(RVA = "0x28D3180", Offset = "0x28D2580", Length = "0x7")]
	[Token(Token = "0x6000A65")]
	public override void Execute() { }

}

