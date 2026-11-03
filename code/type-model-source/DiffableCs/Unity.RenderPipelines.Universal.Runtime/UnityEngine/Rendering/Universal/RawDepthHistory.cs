namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000E1")]
public sealed class RawDepthHistory : CameraHistoryItem
{
	[Token(Token = "0x400053A")]
	private static readonly String[] m_Names; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000539")]
	private Int32[] m_Ids; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400053B")]
	private RenderTextureDescriptor m_Descriptor; //Field offset: 0x28
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400053C")]
	private Hash128 m_DescKey; //Field offset: 0x60

	[Address(RVA = "0x2DC5A20", Offset = "0x2DC4E20", Length = "0xCA")]
	[Token(Token = "0x6000624")]
	private static RawDepthHistory() { }

	[Address(RVA = "0x2DC5AF0", Offset = "0x2DC4EF0", Length = "0x55")]
	[Token(Token = "0x6000623")]
	public RawDepthHistory() { }

	[Address(RVA = "0x2DC54F0", Offset = "0x2DC48F0", Length = "0x193")]
	[Token(Token = "0x600061F")]
	private void Alloc(ref RenderTextureDescriptor desc, bool xrMultipassEnabled) { }

	[Address(RVA = "0x2DC4E50", Offset = "0x2DC4250", Length = "0x46")]
	[Token(Token = "0x600061B")]
	public RTHandle GetCurrentTexture(int eyeIndex = 0) { }

	[Address(RVA = "0x2DC5690", Offset = "0x2DC4A90", Length = "0x32")]
	[Token(Token = "0x6000621")]
	internal RenderTextureDescriptor GetHistoryDescriptor(ref RenderTextureDescriptor cameraDesc) { }

	[Address(RVA = "0x2DC4EE0", Offset = "0x2DC42E0", Length = "0x46")]
	[Token(Token = "0x600061C")]
	public RTHandle GetPreviousTexture(int eyeIndex = 0) { }

	[Address(RVA = "0x2DC4F30", Offset = "0x2DC4330", Length = "0x43")]
	[Token(Token = "0x600061D")]
	private bool IsAllocated() { }

	[Address(RVA = "0x2DC56D0", Offset = "0x2DC4AD0", Length = "0x7C")]
	[Token(Token = "0x600061E")]
	private bool IsDirty(ref RenderTextureDescriptor desc) { }

	[Address(RVA = "0x2DC5000", Offset = "0x2DC4400", Length = "0x6C")]
	[Token(Token = "0x600061A")]
	public virtual void OnCreate(BufferedRTHandleSystem owner, uint typeId) { }

	[Address(RVA = "0x2DC5070", Offset = "0x2DC4470", Length = "0x73")]
	[Token(Token = "0x6000620")]
	public virtual void Reset() { }

	[Address(RVA = "0x2DC5750", Offset = "0x2DC4B50", Length = "0x2CE")]
	[Token(Token = "0x6000622")]
	internal bool Update(ref RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled) { }

}

