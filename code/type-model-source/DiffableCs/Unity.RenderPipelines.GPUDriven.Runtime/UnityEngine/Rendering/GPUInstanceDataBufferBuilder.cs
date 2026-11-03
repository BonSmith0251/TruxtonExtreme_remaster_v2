namespace UnityEngine.Rendering;

[Token(Token = "0x200006B")]
internal struct GPUInstanceDataBufferBuilder : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D3")]
	private NativeList<GPUInstanceComponentDesc> m_Components; //Field offset: 0x0

	[Address(RVA = "0x811DA0", Offset = "0x8111A0", Length = "0x7B")]
	[Token(Token = "0x60001CF")]
	public void AddComponent(int propertyID, bool isOverriden, bool isPerInstance, InstanceType instanceType, InstanceComponentGroup componentGroup = 1) { }

	[Address(RVA = "0x2CDFC70", Offset = "0x2CDF070", Length = "0x128")]
	[Token(Token = "0x60001D0")]
	public void AddComponent(int propertyID, bool isOverriden, int byteSize, bool isPerInstance, InstanceType instanceType, InstanceComponentGroup componentGroup) { }

	[Address(RVA = "0x2CDFDA0", Offset = "0x2CDF1A0", Length = "0x9BE")]
	[Token(Token = "0x60001D1")]
	public GPUInstanceDataBuffer Build(in InstanceNumInfo instanceNumInfo) { }

	[Address(RVA = "0x2CE0760", Offset = "0x2CDFB60", Length = "0x23")]
	[Token(Token = "0x60001CE")]
	private MetadataValue CreateMetadataValue(int nameID, int gpuAddress, bool isOverridden) { }

	[Address(RVA = "0x2CE0790", Offset = "0x2CDFB90", Length = "0x51")]
	[Token(Token = "0x60001D2")]
	public override void Dispose() { }

}

