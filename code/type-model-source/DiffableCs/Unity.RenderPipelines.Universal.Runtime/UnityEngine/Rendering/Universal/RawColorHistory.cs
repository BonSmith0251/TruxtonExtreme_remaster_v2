namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000E0")]
public sealed class RawColorHistory : CameraHistoryItem
{
	[Token(Token = "0x4000536")]
	private static readonly String[] m_Names; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000535")]
	private Int32[] m_Ids; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000537")]
	private RenderTextureDescriptor m_Descriptor; //Field offset: 0x28
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000538")]
	private Hash128 m_DescKey; //Field offset: 0x60

	[Address(RVA = "0x2DC53C0", Offset = "0x2DC47C0", Length = "0xCA")]
	[Token(Token = "0x6000619")]
	private static RawColorHistory() { }

	[Address(RVA = "0x2DC5490", Offset = "0x2DC4890", Length = "0x55")]
	[Token(Token = "0x6000618")]
	public RawColorHistory() { }

	[Address(RVA = "0x2DC4CB0", Offset = "0x2DC40B0", Length = "0x193")]
	[Token(Token = "0x6000614")]
	private void Alloc(ref RenderTextureDescriptor desc, bool xrMultipassEnabled) { }

	[Address(RVA = "0x2DC4E50", Offset = "0x2DC4250", Length = "0x46")]
	[Token(Token = "0x6000610")]
	public RTHandle GetCurrentTexture(int eyeIndex = 0) { }

	[Address(RVA = "0x2DC4EA0", Offset = "0x2DC42A0", Length = "0x33")]
	[Token(Token = "0x6000616")]
	internal RenderTextureDescriptor GetHistoryDescriptor(ref RenderTextureDescriptor cameraDesc) { }

	[Address(RVA = "0x2DC4EE0", Offset = "0x2DC42E0", Length = "0x46")]
	[Token(Token = "0x6000611")]
	public RTHandle GetPreviousTexture(int eyeIndex = 0) { }

	[Address(RVA = "0x2DC4F30", Offset = "0x2DC4330", Length = "0x43")]
	[Token(Token = "0x6000612")]
	private bool IsAllocated() { }

	[Address(RVA = "0x2DC4F80", Offset = "0x2DC4380", Length = "0x7C")]
	[Token(Token = "0x6000613")]
	private bool IsDirty(ref RenderTextureDescriptor desc) { }

	[Address(RVA = "0x2DC5000", Offset = "0x2DC4400", Length = "0x6C")]
	[Token(Token = "0x600060F")]
	public virtual void OnCreate(BufferedRTHandleSystem owner, uint typeId) { }

	[Address(RVA = "0x2DC5070", Offset = "0x2DC4470", Length = "0x73")]
	[Token(Token = "0x6000615")]
	public virtual void Reset() { }

	[Address(RVA = "0x2DC50F0", Offset = "0x2DC44F0", Length = "0x2CE")]
	[Token(Token = "0x6000617")]
	internal bool Update(ref RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled = false) { }

}

