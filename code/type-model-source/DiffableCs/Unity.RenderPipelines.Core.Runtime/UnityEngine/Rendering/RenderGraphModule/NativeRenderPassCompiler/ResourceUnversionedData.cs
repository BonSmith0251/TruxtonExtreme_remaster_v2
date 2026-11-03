namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[Token(Token = "0x20002C8")]
internal struct ResourceUnversionedData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CEF")]
	public readonly bool isImported; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000CF0")]
	public bool isShared; //Field offset: 0x1
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CF1")]
	public int tag; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000CF2")]
	public int lastUsePassID; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000CF3")]
	public int lastWritePassID; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CF4")]
	public int firstUsePassID; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000CF5")]
	public bool memoryLess; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CF6")]
	public readonly int width; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000CF7")]
	public readonly int height; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000CF8")]
	public readonly int volumeDepth; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000CF9")]
	public readonly int msaaSamples; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000CFA")]
	public readonly GraphicsFormat graphicsFormat; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000CFB")]
	public int latestVersionNumber; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000CFC")]
	public readonly bool clear; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000CFD")]
	public readonly bool discard; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x4000CFE")]
	public readonly bool bindMS; //Field offset: 0x32
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000CFF")]
	public TextureUVOriginSelection textureUVOrigin; //Field offset: 0x34

	[Address(RVA = "0x2CBE030", Offset = "0x2CBD430", Length = "0x84")]
	[Token(Token = "0x60013B1")]
	public ResourceUnversionedData(TextureResource rll, ref RenderTargetInfo info, ref TextureDesc desc, bool isResourceShared) { }

	[Address(RVA = "0x2CBDFC0", Offset = "0x2CBD3C0", Length = "0x61")]
	[Token(Token = "0x60013B2")]
	public ResourceUnversionedData(IRenderGraphResource rll, ref BufferDesc _, bool isResourceShared) { }

	[Address(RVA = "0x2CBDFC0", Offset = "0x2CBD3C0", Length = "0x61")]
	[Token(Token = "0x60013B3")]
	public ResourceUnversionedData(IRenderGraphResource rll, ref RayTracingAccelerationStructureDesc _, bool isResourceShared) { }

	[Address(RVA = "0x2CBDF70", Offset = "0x2CBD370", Length = "0x26")]
	[Token(Token = "0x60013B0")]
	public string GetName(CompilerContextData ctx, in ResourceHandle h) { }

	[Address(RVA = "0x2CBDFA0", Offset = "0x2CBD3A0", Length = "0x17")]
	[Token(Token = "0x60013B4")]
	public void InitializeNullResource() { }

}

