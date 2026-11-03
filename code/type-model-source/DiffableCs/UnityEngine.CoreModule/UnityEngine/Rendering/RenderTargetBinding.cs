namespace UnityEngine.Rendering;

[Token(Token = "0x200035D")]
public struct RenderTargetBinding
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009B8")]
	private RenderTargetIdentifier[] m_ColorRenderTargets; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009B9")]
	private RenderTargetIdentifier m_DepthRenderTarget; //Field offset: 0x8
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009BA")]
	private RenderBufferLoadAction[] m_ColorLoadActions; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009BB")]
	private RenderBufferStoreAction[] m_ColorStoreActions; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40009BC")]
	private RenderBufferLoadAction m_DepthLoadAction; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40009BD")]
	private RenderBufferStoreAction m_DepthStoreAction; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40009BE")]
	private RenderTargetFlags m_Flags; //Field offset: 0x48

	[Token(Token = "0x170003CB")]
	public RenderBufferLoadAction[] colorLoadActions
	{
		[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
		[Token(Token = "0x6001A31")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170003C9")]
	public RenderTargetIdentifier[] colorRenderTargets
	{
		[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
		[Token(Token = "0x6001A2F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170003CC")]
	public RenderBufferStoreAction[] colorStoreActions
	{
		[Address(RVA = "0x2F944A0", Offset = "0x2F938A0", Length = "0x7")]
		[Token(Token = "0x6001A32")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170003CD")]
	public RenderBufferLoadAction depthLoadAction
	{
		[Address(RVA = "0x30856E0", Offset = "0x3084AE0", Length = "0x6")]
		[Token(Token = "0x6001A33")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170003CA")]
	public RenderTargetIdentifier depthRenderTarget
	{
		[Address(RVA = "0x30856F0", Offset = "0x3084AF0", Length = "0x1D")]
		[Token(Token = "0x6001A30")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170003CE")]
	public RenderBufferStoreAction depthStoreAction
	{
		[Address(RVA = "0x3085710", Offset = "0x3084B10", Length = "0x6")]
		[Token(Token = "0x6001A34")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170003CF")]
	public RenderTargetFlags flags
	{
		[Address(RVA = "0x2F98AE0", Offset = "0x2F97EE0", Length = "0x6")]
		[Token(Token = "0x6001A35")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
	[Token(Token = "0x6001A31")]
	public RenderBufferLoadAction[] get_colorLoadActions() { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x6001A2F")]
	public RenderTargetIdentifier[] get_colorRenderTargets() { }

	[Address(RVA = "0x2F944A0", Offset = "0x2F938A0", Length = "0x7")]
	[Token(Token = "0x6001A32")]
	public RenderBufferStoreAction[] get_colorStoreActions() { }

	[Address(RVA = "0x30856E0", Offset = "0x3084AE0", Length = "0x6")]
	[Token(Token = "0x6001A33")]
	public RenderBufferLoadAction get_depthLoadAction() { }

	[Address(RVA = "0x30856F0", Offset = "0x3084AF0", Length = "0x1D")]
	[Token(Token = "0x6001A30")]
	public RenderTargetIdentifier get_depthRenderTarget() { }

	[Address(RVA = "0x3085710", Offset = "0x3084B10", Length = "0x6")]
	[Token(Token = "0x6001A34")]
	public RenderBufferStoreAction get_depthStoreAction() { }

	[Address(RVA = "0x2F98AE0", Offset = "0x2F97EE0", Length = "0x6")]
	[Token(Token = "0x6001A35")]
	public RenderTargetFlags get_flags() { }

}

