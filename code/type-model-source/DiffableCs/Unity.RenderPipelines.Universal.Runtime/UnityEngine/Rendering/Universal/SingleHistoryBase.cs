namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000E2")]
internal abstract class SingleHistoryBase : CameraHistoryItem
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400053D")]
	private int m_Id; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400053E")]
	private RenderTextureDescriptor m_Descriptor; //Field offset: 0x24
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400053F")]
	private Hash128 m_DescKey; //Field offset: 0x58

	[Address(RVA = "0x2DC6CD0", Offset = "0x2DC60D0", Length = "0x7")]
	[Token(Token = "0x6000631")]
	protected SingleHistoryBase() { }

	[Address(RVA = "0x2DC67F0", Offset = "0x2DC5BF0", Length = "0xD6")]
	[Token(Token = "0x600062B")]
	private void Alloc(ref RenderTextureDescriptor desc) { }

	[Address(RVA = "0x2DC68D0", Offset = "0x2DC5CD0", Length = "0xB")]
	[Token(Token = "0x6000627")]
	public RTHandle GetCurrentTexture() { }

	[Token(Token = "0x6000630")]
	protected abstract RenderTextureDescriptor GetHistoryDescriptor(ref RenderTextureDescriptor cameraDesc) { }

	[Token(Token = "0x600062E")]
	protected abstract int GetHistoryFrameCount() { }

	[Token(Token = "0x600062F")]
	protected abstract string GetHistoryName() { }

	[Address(RVA = "0x2DC68E0", Offset = "0x2DC5CE0", Length = "0x4D")]
	[Token(Token = "0x6000628")]
	public RTHandle GetPreviousTexture() { }

	[Address(RVA = "0x2DC6930", Offset = "0x2DC5D30", Length = "0x5D")]
	[Token(Token = "0x6000626")]
	public RTHandle GetTexture(int frameIndex = 0) { }

	[Address(RVA = "0x2DC6990", Offset = "0x2DC5D90", Length = "0x56")]
	[Token(Token = "0x6000629")]
	internal bool IsAllocated() { }

	[Address(RVA = "0x2DC69F0", Offset = "0x2DC5DF0", Length = "0x7C")]
	[Token(Token = "0x600062A")]
	internal bool IsDirty(ref RenderTextureDescriptor desc) { }

	[Address(RVA = "0x2DC6A70", Offset = "0x2DC5E70", Length = "0x27")]
	[Token(Token = "0x6000625")]
	public virtual void OnCreate(BufferedRTHandleSystem owner, uint typeId) { }

	[Address(RVA = "0x2DC6AA0", Offset = "0x2DC5EA0", Length = "0xB")]
	[Token(Token = "0x600062C")]
	public virtual void Reset() { }

	[Address(RVA = "0x2DC6AB0", Offset = "0x2DC5EB0", Length = "0x21E")]
	[Token(Token = "0x600062D")]
	internal bool Update(ref RenderTextureDescriptor cameraDesc) { }

}

