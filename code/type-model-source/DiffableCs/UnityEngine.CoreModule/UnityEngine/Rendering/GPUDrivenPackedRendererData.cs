namespace UnityEngine.Rendering;

[Token(Token = "0x20003BF")]
[UsedByNativeCode]
internal struct GPUDrivenPackedRendererData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BC2")]
	private uint data; //Field offset: 0x0

	[Token(Token = "0x170003FF")]
	public bool hasTree
	{
		[Address(RVA = "0x30B3A90", Offset = "0x30B2E90", Length = "0xA")]
		[Token(Token = "0x6001D3E")]
		 get { } //Length: 10
	}

	[Token(Token = "0x170003FE")]
	public bool isPartOfStaticBatch
	{
		[Address(RVA = "0x30B3AA0", Offset = "0x30B2EA0", Length = "0xA")]
		[Token(Token = "0x6001D3D")]
		 get { } //Length: 10
	}

	[Token(Token = "0x170003FC")]
	public LightProbeUsage lightProbeUsage
	{
		[Address(RVA = "0x30B3AB0", Offset = "0x30B2EB0", Length = "0x9")]
		[Token(Token = "0x6001D3B")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170003FA")]
	public byte lodMask
	{
		[Address(RVA = "0x30B3AC0", Offset = "0x30B2EC0", Length = "0x6")]
		[Token(Token = "0x6001D39")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170003FD")]
	public MotionVectorGenerationMode motionVecGenMode
	{
		[Address(RVA = "0x30B3AD0", Offset = "0x30B2ED0", Length = "0x9")]
		[Token(Token = "0x6001D3C")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170003FB")]
	public ShadowCastingMode shadowCastingMode
	{
		[Address(RVA = "0x30B3AE0", Offset = "0x30B2EE0", Length = "0x9")]
		[Token(Token = "0x6001D3A")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000400")]
	public bool smallMeshCulling
	{
		[Address(RVA = "0x30B3AF0", Offset = "0x30B2EF0", Length = "0xA")]
		[Token(Token = "0x6001D3F")]
		 get { } //Length: 10
	}

	[Token(Token = "0x170003F9")]
	public bool staticShadowCaster
	{
		[Address(RVA = "0x2E7FCC0", Offset = "0x2E7F0C0", Length = "0x7")]
		[Token(Token = "0x6001D38")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1CA23C0", Offset = "0x1CA17C0", Length = "0x7")]
	[Token(Token = "0x6001D40")]
	public GPUDrivenPackedRendererData() { }

	[Address(RVA = "0x30B3A90", Offset = "0x30B2E90", Length = "0xA")]
	[Token(Token = "0x6001D3E")]
	public bool get_hasTree() { }

	[Address(RVA = "0x30B3AA0", Offset = "0x30B2EA0", Length = "0xA")]
	[Token(Token = "0x6001D3D")]
	public bool get_isPartOfStaticBatch() { }

	[Address(RVA = "0x30B3AB0", Offset = "0x30B2EB0", Length = "0x9")]
	[Token(Token = "0x6001D3B")]
	public LightProbeUsage get_lightProbeUsage() { }

	[Address(RVA = "0x30B3AC0", Offset = "0x30B2EC0", Length = "0x6")]
	[Token(Token = "0x6001D39")]
	public byte get_lodMask() { }

	[Address(RVA = "0x30B3AD0", Offset = "0x30B2ED0", Length = "0x9")]
	[Token(Token = "0x6001D3C")]
	public MotionVectorGenerationMode get_motionVecGenMode() { }

	[Address(RVA = "0x30B3AE0", Offset = "0x30B2EE0", Length = "0x9")]
	[Token(Token = "0x6001D3A")]
	public ShadowCastingMode get_shadowCastingMode() { }

	[Address(RVA = "0x30B3AF0", Offset = "0x30B2EF0", Length = "0xA")]
	[Token(Token = "0x6001D3F")]
	public bool get_smallMeshCulling() { }

	[Address(RVA = "0x2E7FCC0", Offset = "0x2E7F0C0", Length = "0x7")]
	[Token(Token = "0x6001D38")]
	public bool get_staticShadowCaster() { }

}

