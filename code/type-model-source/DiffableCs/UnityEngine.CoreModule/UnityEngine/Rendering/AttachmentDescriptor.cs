namespace UnityEngine.Rendering;

[Token(Token = "0x20003C3")]
public struct AttachmentDescriptor : IEquatable<AttachmentDescriptor>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BF0")]
	private RenderBufferLoadAction m_LoadAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000BF1")]
	private RenderBufferStoreAction m_StoreAction; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BF2")]
	private GraphicsFormat m_Format; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BF3")]
	private RenderTargetIdentifier m_LoadStoreTarget; //Field offset: 0x10
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BF4")]
	private RenderTargetIdentifier m_ResolveTarget; //Field offset: 0x38
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BF5")]
	private Color m_ClearColor; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000BF6")]
	private float m_ClearDepth; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000BF7")]
	private uint m_ClearStencil; //Field offset: 0x74

	[Token(Token = "0x17000409")]
	public Color clearColor
	{
		[Address(RVA = "0x2162020", Offset = "0x2161420", Length = "0x8")]
		[Token(Token = "0x6001D4D")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700040A")]
	public float clearDepth
	{
		[Address(RVA = "0x3098350", Offset = "0x3097750", Length = "0x6")]
		[Token(Token = "0x6001D4E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700040B")]
	public uint clearStencil
	{
		[Address(RVA = "0x1E24880", Offset = "0x1E23C80", Length = "0x4")]
		[Token(Token = "0x6001D4F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000405")]
	public RenderBufferLoadAction loadAction
	{
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6001D47")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000407")]
	public RenderTargetIdentifier loadStoreTarget
	{
		[Address(RVA = "0x3098330", Offset = "0x3097730", Length = "0x1D")]
		[Token(Token = "0x6001D4A")]
		 get { } //Length: 29
		[Address(RVA = "0x3098360", Offset = "0x3097760", Length = "0x1A")]
		[Token(Token = "0x6001D4B")]
		 set { } //Length: 26
	}

	[Token(Token = "0x17000408")]
	public RenderTargetIdentifier resolveTarget
	{
		[Address(RVA = "0x3098380", Offset = "0x3097780", Length = "0x1A")]
		[Token(Token = "0x6001D4C")]
		 set { } //Length: 26
	}

	[Token(Token = "0x17000406")]
	public RenderBufferStoreAction storeAction
	{
		[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
		[Token(Token = "0x6001D48")]
		 get { } //Length: 6
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x6001D49")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3098260", Offset = "0x3097660", Length = "0xCC")]
	[Token(Token = "0x6001D50")]
	public AttachmentDescriptor(GraphicsFormat format) { }

	[Address(RVA = "0x3097EE0", Offset = "0x30972E0", Length = "0x25F")]
	[Token(Token = "0x6001D51")]
	public override bool Equals(AttachmentDescriptor other) { }

	[Address(RVA = "0x3097DE0", Offset = "0x30971E0", Length = "0xF2")]
	[Token(Token = "0x6001D52")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3098330", Offset = "0x3097730", Length = "0x1D")]
	[Token(Token = "0x6001D4A")]
	public RenderTargetIdentifier get_loadStoreTarget() { }

	[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
	[Token(Token = "0x6001D48")]
	public RenderBufferStoreAction get_storeAction() { }

	[Address(RVA = "0x3098140", Offset = "0x3097540", Length = "0x111")]
	[Token(Token = "0x6001D53")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2162020", Offset = "0x2161420", Length = "0x8")]
	[Token(Token = "0x6001D4D")]
	public void set_clearColor(Color value) { }

	[Address(RVA = "0x3098350", Offset = "0x3097750", Length = "0x6")]
	[Token(Token = "0x6001D4E")]
	public void set_clearDepth(float value) { }

	[Address(RVA = "0x1E24880", Offset = "0x1E23C80", Length = "0x4")]
	[Token(Token = "0x6001D4F")]
	public void set_clearStencil(uint value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6001D47")]
	public void set_loadAction(RenderBufferLoadAction value) { }

	[Address(RVA = "0x3098360", Offset = "0x3097760", Length = "0x1A")]
	[Token(Token = "0x6001D4B")]
	public void set_loadStoreTarget(RenderTargetIdentifier value) { }

	[Address(RVA = "0x3098380", Offset = "0x3097780", Length = "0x1A")]
	[Token(Token = "0x6001D4C")]
	public void set_resolveTarget(RenderTargetIdentifier value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x6001D49")]
	public void set_storeAction(RenderBufferStoreAction value) { }

}

