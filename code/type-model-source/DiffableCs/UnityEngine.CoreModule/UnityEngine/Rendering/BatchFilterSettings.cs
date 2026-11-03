namespace UnityEngine.Rendering;

[Token(Token = "0x20003A5")]
public struct BatchFilterSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B2F")]
	public uint renderingLayerMask; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000B30")]
	public int rendererPriority; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B31")]
	private ulong m_sceneCullingMask; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B32")]
	public byte layer; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000B33")]
	private byte m_batchLayer; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4000B34")]
	private byte m_motionMode; //Field offset: 0x12
	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x4000B35")]
	private byte m_shadowMode; //Field offset: 0x13
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000B36")]
	private byte m_receiveShadows; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x4000B37")]
	private byte m_staticShadowCaster; //Field offset: 0x15
	[FieldOffset(Offset = "0x16")]
	[Token(Token = "0x4000B38")]
	private byte m_allDepthSorted; //Field offset: 0x16
	[FieldOffset(Offset = "0x17")]
	[Token(Token = "0x4000B39")]
	private byte m_isSceneCullingMaskSet; //Field offset: 0x17

	[Token(Token = "0x170003F3")]
	public bool allDepthSorted
	{
		[Address(RVA = "0x3098460", Offset = "0x3097860", Length = "0x6")]
		[Token(Token = "0x6001CEF")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170003EE")]
	public byte batchLayer
	{
		[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
		[Token(Token = "0x6001CEA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003EF")]
	public MotionVectorGenerationMode motionMode
	{
		[Address(RVA = "0x216CFD0", Offset = "0x216C3D0", Length = "0x4")]
		[Token(Token = "0x6001CEB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003F1")]
	public bool receiveShadows
	{
		[Address(RVA = "0x3098470", Offset = "0x3097870", Length = "0x6")]
		[Token(Token = "0x6001CED")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170003F0")]
	public ShadowCastingMode shadowCastingMode
	{
		[Address(RVA = "0x21C1120", Offset = "0x21C0520", Length = "0x4")]
		[Token(Token = "0x6001CEC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003F2")]
	public bool staticShadowCaster
	{
		[Address(RVA = "0x3098480", Offset = "0x3097880", Length = "0x6")]
		[Token(Token = "0x6001CEE")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x3098460", Offset = "0x3097860", Length = "0x6")]
	[Token(Token = "0x6001CEF")]
	public void set_allDepthSorted(bool value) { }

	[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
	[Token(Token = "0x6001CEA")]
	public void set_batchLayer(byte value) { }

	[Address(RVA = "0x216CFD0", Offset = "0x216C3D0", Length = "0x4")]
	[Token(Token = "0x6001CEB")]
	public void set_motionMode(MotionVectorGenerationMode value) { }

	[Address(RVA = "0x3098470", Offset = "0x3097870", Length = "0x6")]
	[Token(Token = "0x6001CED")]
	public void set_receiveShadows(bool value) { }

	[Address(RVA = "0x21C1120", Offset = "0x21C0520", Length = "0x4")]
	[Token(Token = "0x6001CEC")]
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	[Address(RVA = "0x3098480", Offset = "0x3097880", Length = "0x6")]
	[Token(Token = "0x6001CEE")]
	public void set_staticShadowCaster(bool value) { }

}

