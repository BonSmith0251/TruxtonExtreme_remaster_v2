namespace UnityEngine.Rendering;

[Token(Token = "0x2000016")]
internal struct ReceiverPlanes
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003C")]
	public NativeList<Plane> planes; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400003D")]
	public int lightFacingPlaneCount; //Field offset: 0x8

	[Address(RVA = "0x2CD4300", Offset = "0x2CD3700", Length = "0xB9B")]
	[Token(Token = "0x600008C")]
	internal static ReceiverPlanes Create(in BatchCullingContext cc, Allocator allocator) { }

	[Address(RVA = "0x2CD4290", Offset = "0x2CD3690", Length = "0x6D")]
	[Token(Token = "0x600008A")]
	internal static ReceiverPlanes CreateEmptyForTesting(Allocator allocator) { }

	[Address(RVA = "0x2CD4EA0", Offset = "0x2CD42A0", Length = "0x58")]
	[Token(Token = "0x600008B")]
	internal void Dispose(JobHandle job) { }

	[Address(RVA = "0x2CD4F00", Offset = "0x2CD4300", Length = "0x8")]
	[Token(Token = "0x6000087")]
	private static bool IsSignBitSet(float x) { }

	[Address(RVA = "0x2CD4F10", Offset = "0x2CD4310", Length = "0x97")]
	[Token(Token = "0x6000088")]
	internal NativeArray<Plane> LightFacingFrustumPlaneSubArray() { }

	[Address(RVA = "0x2CD4FB0", Offset = "0x2CD43B0", Length = "0xDA")]
	[Token(Token = "0x6000089")]
	internal NativeArray<Plane> SilhouettePlaneSubArray() { }

}

