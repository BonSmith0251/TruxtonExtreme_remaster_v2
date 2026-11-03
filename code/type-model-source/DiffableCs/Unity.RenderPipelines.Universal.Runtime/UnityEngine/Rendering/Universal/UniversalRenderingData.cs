namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000DB")]
public class UniversalRenderingData : ContextItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004FA")]
	public CullingResults cullResults; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004FB")]
	public bool supportsDynamicBatching; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004FC")]
	public PerObjectData perObjectData; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004FD")]
	private RenderingMode <renderingMode>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40004FE")]
	private LayerMask <prepassLayerMask>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004FF")]
	private LayerMask <opaqueLayerMask>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000500")]
	private LayerMask <transparentLayerMask>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000501")]
	private bool <stencilLodCrossFadeEnabled>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x17000193")]
	public internal LayerMask opaqueLayerMask
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005C3")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005C4")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000192")]
	public internal LayerMask prepassLayerMask
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005C1")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005C2")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000191")]
	public internal RenderingMode renderingMode
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005BF")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005C0")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000195")]
	public internal bool stencilLodCrossFadeEnabled
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60005C7")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005C8")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000194")]
	public internal LayerMask transparentLayerMask
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005C5")]
		 get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005C6")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60005CA")]
	public UniversalRenderingData() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005C3")]
	public LayerMask get_opaqueLayerMask() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005C1")]
	public LayerMask get_prepassLayerMask() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005BF")]
	public RenderingMode get_renderingMode() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60005C7")]
	public bool get_stencilLodCrossFadeEnabled() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005C5")]
	public LayerMask get_transparentLayerMask() { }

	[Address(RVA = "0x2DA3D30", Offset = "0x2DA3130", Length = "0x50")]
	[Token(Token = "0x60005C9")]
	public virtual void Reset() { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005C4")]
	internal void set_opaqueLayerMask(LayerMask value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005C2")]
	internal void set_prepassLayerMask(LayerMask value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005C0")]
	internal void set_renderingMode(RenderingMode value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005C8")]
	internal void set_stencilLodCrossFadeEnabled(bool value) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005C6")]
	internal void set_transparentLayerMask(LayerMask value) { }

}

