namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000E4")]
public sealed class TaaHistory : CameraHistoryItem
{
	[Token(Token = "0x4000543")]
	private static readonly String[] m_TaaAccumulationNames; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000541")]
	private Int32[] m_TaaAccumulationTextureIds; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000542")]
	private Int32[] m_TaaAccumulationVersions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000544")]
	private RenderTextureDescriptor m_Descriptor; //Field offset: 0x30
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000545")]
	private Hash128 m_DescKey; //Field offset: 0x68

	[Address(RVA = "0x2DC7930", Offset = "0x2DC6D30", Length = "0xCA")]
	[Token(Token = "0x6000641")]
	private static TaaHistory() { }

	[Address(RVA = "0x2DC7A00", Offset = "0x2DC6E00", Length = "0x76")]
	[Token(Token = "0x6000640")]
	public TaaHistory() { }

	[Address(RVA = "0x2DC7280", Offset = "0x2DC6680", Length = "0x193")]
	[Token(Token = "0x600063E")]
	private void Alloc(ref RenderTextureDescriptor desc, bool xrMultipassEnabled) { }

	[Address(RVA = "0x2DC7420", Offset = "0x2DC6820", Length = "0x30")]
	[Token(Token = "0x6000639")]
	public RTHandle GetAccumulationTexture(int eyeIndex = 0) { }

	[Address(RVA = "0x2DC7460", Offset = "0x2DC6860", Length = "0x2B")]
	[Token(Token = "0x600063A")]
	public int GetAccumulationVersion(int eyeIndex = 0) { }

	[Address(RVA = "0x2DC7490", Offset = "0x2DC6890", Length = "0x7C")]
	[Token(Token = "0x600063D")]
	private bool IsDirty(ref RenderTextureDescriptor desc) { }

	[Address(RVA = "0x2DC7510", Offset = "0x2DC6910", Length = "0x34")]
	[Token(Token = "0x600063C")]
	private bool IsValid() { }

	[Address(RVA = "0x2DC5000", Offset = "0x2DC4400", Length = "0x6C")]
	[Token(Token = "0x6000637")]
	public virtual void OnCreate(BufferedRTHandleSystem owner, uint typeId) { }

	[Address(RVA = "0x2DC7550", Offset = "0x2DC6950", Length = "0xB8")]
	[Token(Token = "0x6000638")]
	public virtual void Reset() { }

	[Address(RVA = "0x2DC7610", Offset = "0x2DC6A10", Length = "0x2B")]
	[Token(Token = "0x600063B")]
	internal void SetAccumulationVersion(int eyeIndex, int version) { }

	[Address(RVA = "0x2DC7640", Offset = "0x2DC6A40", Length = "0x2E8")]
	[Token(Token = "0x600063F")]
	internal bool Update(ref RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled = false) { }

}

