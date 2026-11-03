namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000DE")]
public class UniversalResourceData : UniversalResourceDataBase
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000506")]
	private ActiveID <activeColorID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000507")]
	private ActiveID <activeDepthID>k__BackingField; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000508")]
	private TextureHandle _backBufferColor; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000509")]
	private TextureHandle _backBufferDepth; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400050A")]
	private TextureHandle _cameraColor; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400050B")]
	private TextureHandle _cameraDepth; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400050C")]
	private TextureHandle _mainShadowsTexture; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400050D")]
	private TextureHandle _additionalShadowsTexture; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400050E")]
	private TextureHandle[] _gBuffer; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400050F")]
	private TextureHandle _cameraOpaqueTexture; //Field offset: 0x88
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000510")]
	private TextureHandle _cameraDepthTexture; //Field offset: 0x98
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000511")]
	private TextureHandle _cameraNormalsTexture; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000512")]
	private TextureHandle _motionVectorColor; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000513")]
	private TextureHandle _motionVectorDepth; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000514")]
	private TextureHandle _internalColorLut; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000515")]
	internal TextureHandle _debugScreenColor; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000516")]
	internal TextureHandle _debugScreenDepth; //Field offset: 0xF8
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000517")]
	private TextureHandle _afterPostProcessColor; //Field offset: 0x108
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000518")]
	private TextureHandle _overlayUITexture; //Field offset: 0x118
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000519")]
	private TextureHandle _renderingLayersTexture; //Field offset: 0x128
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400051A")]
	private TextureHandle[] _dBuffer; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400051B")]
	private TextureHandle _dBufferDepth; //Field offset: 0x140
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400051C")]
	private TextureHandle _ssaoTexture; //Field offset: 0x150
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400051D")]
	private TextureHandle _irradianceTexture; //Field offset: 0x160
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400051E")]
	private TextureHandle _stpDebugView; //Field offset: 0x170

	[Token(Token = "0x17000197")]
	internal ActiveID activeColorID
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005D5")]
		internal get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005D6")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000198")]
	public TextureHandle activeColorTexture
	{
		[Address(RVA = "0x2DA4A80", Offset = "0x2DA3E80", Length = "0x15D")]
		[Token(Token = "0x60005D7")]
		 get { } //Length: 349
	}

	[Token(Token = "0x17000199")]
	internal ActiveID activeDepthID
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005D9")]
		internal get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005DA")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700019A")]
	public TextureHandle activeDepthTexture
	{
		[Address(RVA = "0x2DA4BE0", Offset = "0x2DA3FE0", Length = "0x15D")]
		[Token(Token = "0x60005DB")]
		 get { } //Length: 349
	}

	[Token(Token = "0x170001A1")]
	public TextureHandle additionalShadowsTexture
	{
		[Address(RVA = "0x2DA4D40", Offset = "0x2DA4140", Length = "0x29")]
		[Token(Token = "0x60005E7")]
		 get { } //Length: 41
		[Address(RVA = "0x2DA5130", Offset = "0x2DA4530", Length = "0x79")]
		[Token(Token = "0x60005E8")]
		 set { } //Length: 121
	}

	[Token(Token = "0x170001AB")]
	public internal TextureHandle afterPostProcessColor
	{
		[Address(RVA = "0x2DA4D70", Offset = "0x2DA4170", Length = "0x2C")]
		[Token(Token = "0x60005FB")]
		 get { } //Length: 44
		[Address(RVA = "0x2DA51B0", Offset = "0x2DA45B0", Length = "0x7C")]
		[Token(Token = "0x60005FC")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x1700019C")]
	public internal TextureHandle backBufferColor
	{
		[Address(RVA = "0x2DA4DA0", Offset = "0x2DA41A0", Length = "0x29")]
		[Token(Token = "0x60005DD")]
		 get { } //Length: 41
		[Address(RVA = "0x2DA5230", Offset = "0x2DA4630", Length = "0x79")]
		[Token(Token = "0x60005DE")]
		internal set { } //Length: 121
	}

	[Token(Token = "0x1700019D")]
	public internal TextureHandle backBufferDepth
	{
		[Address(RVA = "0x2DA4DD0", Offset = "0x2DA41D0", Length = "0x29")]
		[Token(Token = "0x60005DF")]
		 get { } //Length: 41
		[Address(RVA = "0x2DA52B0", Offset = "0x2DA46B0", Length = "0x79")]
		[Token(Token = "0x60005E0")]
		internal set { } //Length: 121
	}

	[Token(Token = "0x1700019E")]
	public TextureHandle cameraColor
	{
		[Address(RVA = "0x2D93220", Offset = "0x2D92620", Length = "0x29")]
		[Token(Token = "0x60005E1")]
		 get { } //Length: 41
		[Address(RVA = "0x2D933B0", Offset = "0x2D927B0", Length = "0x79")]
		[Token(Token = "0x60005E2")]
		 set { } //Length: 121
	}

	[Token(Token = "0x1700019F")]
	public TextureHandle cameraDepth
	{
		[Address(RVA = "0x2D93260", Offset = "0x2D92660", Length = "0x29")]
		[Token(Token = "0x60005E3")]
		 get { } //Length: 41
		[Address(RVA = "0x2D93440", Offset = "0x2D92840", Length = "0x79")]
		[Token(Token = "0x60005E4")]
		 set { } //Length: 121
	}

	[Token(Token = "0x170001A4")]
	public internal TextureHandle cameraDepthTexture
	{
		[Address(RVA = "0x2DA4E00", Offset = "0x2DA4200", Length = "0x2C")]
		[Token(Token = "0x60005ED")]
		 get { } //Length: 44
		[Address(RVA = "0x2DA5330", Offset = "0x2DA4730", Length = "0x7C")]
		[Token(Token = "0x60005EE")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x170001A5")]
	public internal TextureHandle cameraNormalsTexture
	{
		[Address(RVA = "0x2DA4E30", Offset = "0x2DA4230", Length = "0x2C")]
		[Token(Token = "0x60005EF")]
		 get { } //Length: 44
		[Address(RVA = "0x2DA53B0", Offset = "0x2DA47B0", Length = "0x7C")]
		[Token(Token = "0x60005F0")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x170001A3")]
	public internal TextureHandle cameraOpaqueTexture
	{
		[Address(RVA = "0x2DA4E60", Offset = "0x2DA4260", Length = "0x2C")]
		[Token(Token = "0x60005EB")]
		 get { } //Length: 44
		[Address(RVA = "0x2DA5430", Offset = "0x2DA4830", Length = "0x7C")]
		[Token(Token = "0x60005EC")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x170001AE")]
	public TextureHandle[] dBuffer
	{
		[Address(RVA = "0x2DA4EC0", Offset = "0x2DA42C0", Length = "0xF")]
		[Token(Token = "0x6000601")]
		 get { } //Length: 15
		[Address(RVA = "0x2DA5530", Offset = "0x2DA4930", Length = "0x12")]
		[Token(Token = "0x6000602")]
		 set { } //Length: 18
	}

	[Token(Token = "0x170001AF")]
	public TextureHandle dBufferDepth
	{
		[Address(RVA = "0x2DA4E90", Offset = "0x2DA4290", Length = "0x2C")]
		[Token(Token = "0x6000603")]
		 get { } //Length: 44
		[Address(RVA = "0x2DA54B0", Offset = "0x2DA48B0", Length = "0x7C")]
		[Token(Token = "0x6000604")]
		 set { } //Length: 124
	}

	[Token(Token = "0x170001A9")]
	internal TextureHandle debugScreenColor
	{
		[Address(RVA = "0x2DA4ED0", Offset = "0x2DA42D0", Length = "0x2C")]
		[Token(Token = "0x60005F7")]
		internal get { } //Length: 44
		[Address(RVA = "0x2DA5550", Offset = "0x2DA4950", Length = "0x7C")]
		[Token(Token = "0x60005F8")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x170001AA")]
	internal TextureHandle debugScreenDepth
	{
		[Address(RVA = "0x2DA4F00", Offset = "0x2DA4300", Length = "0x2C")]
		[Token(Token = "0x60005F9")]
		internal get { } //Length: 44
		[Address(RVA = "0x2DA55D0", Offset = "0x2DA49D0", Length = "0x7C")]
		[Token(Token = "0x60005FA")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x170001A2")]
	public TextureHandle[] gBuffer
	{
		[Address(RVA = "0x2DA4F30", Offset = "0x2DA4330", Length = "0xF")]
		[Token(Token = "0x60005E9")]
		 get { } //Length: 15
		[Address(RVA = "0x2DA5650", Offset = "0x2DA4A50", Length = "0x12")]
		[Token(Token = "0x60005EA")]
		 set { } //Length: 18
	}

	[Token(Token = "0x170001A8")]
	public TextureHandle internalColorLut
	{
		[Address(RVA = "0x2DA4F40", Offset = "0x2DA4340", Length = "0x2C")]
		[Token(Token = "0x60005F5")]
		 get { } //Length: 44
		[Address(RVA = "0x2DA5670", Offset = "0x2DA4A70", Length = "0x7C")]
		[Token(Token = "0x60005F6")]
		 set { } //Length: 124
	}

	[Token(Token = "0x170001B1")]
	internal TextureHandle irradianceTexture
	{
		[Address(RVA = "0x2DA4F70", Offset = "0x2DA4370", Length = "0x2C")]
		[Token(Token = "0x6000607")]
		internal get { } //Length: 44
		[Address(RVA = "0x2DA56F0", Offset = "0x2DA4AF0", Length = "0x7C")]
		[Token(Token = "0x6000608")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x1700019B")]
	public bool isActiveTargetBackBuffer
	{
		[Address(RVA = "0x2DA4FA0", Offset = "0x2DA43A0", Length = "0x6F")]
		[Token(Token = "0x60005DC")]
		 get { } //Length: 111
	}

	[Token(Token = "0x170001A0")]
	public TextureHandle mainShadowsTexture
	{
		[Address(RVA = "0x2D931A0", Offset = "0x2D925A0", Length = "0x29")]
		[Token(Token = "0x60005E5")]
		 get { } //Length: 41
		[Address(RVA = "0x2D93290", Offset = "0x2D92690", Length = "0x79")]
		[Token(Token = "0x60005E6")]
		 set { } //Length: 121
	}

	[Token(Token = "0x170001A6")]
	public TextureHandle motionVectorColor
	{
		[Address(RVA = "0x2DA5010", Offset = "0x2DA4410", Length = "0x2C")]
		[Token(Token = "0x60005F1")]
		 get { } //Length: 44
		[Address(RVA = "0x2DA5770", Offset = "0x2DA4B70", Length = "0x7C")]
		[Token(Token = "0x60005F2")]
		 set { } //Length: 124
	}

	[Token(Token = "0x170001A7")]
	public TextureHandle motionVectorDepth
	{
		[Address(RVA = "0x2DA5040", Offset = "0x2DA4440", Length = "0x2C")]
		[Token(Token = "0x60005F3")]
		 get { } //Length: 44
		[Address(RVA = "0x2DA57F0", Offset = "0x2DA4BF0", Length = "0x7C")]
		[Token(Token = "0x60005F4")]
		 set { } //Length: 124
	}

	[Token(Token = "0x170001AC")]
	public internal TextureHandle overlayUITexture
	{
		[Address(RVA = "0x2DA5070", Offset = "0x2DA4470", Length = "0x2C")]
		[Token(Token = "0x60005FD")]
		 get { } //Length: 44
		[Address(RVA = "0x2DA5870", Offset = "0x2DA4C70", Length = "0x7C")]
		[Token(Token = "0x60005FE")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x170001AD")]
	public internal TextureHandle renderingLayersTexture
	{
		[Address(RVA = "0x2DA50A0", Offset = "0x2DA44A0", Length = "0x2C")]
		[Token(Token = "0x60005FF")]
		 get { } //Length: 44
		[Address(RVA = "0x2DA58F0", Offset = "0x2DA4CF0", Length = "0x7C")]
		[Token(Token = "0x6000600")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x170001B0")]
	public internal TextureHandle ssaoTexture
	{
		[Address(RVA = "0x2DA50D0", Offset = "0x2DA44D0", Length = "0x2C")]
		[Token(Token = "0x6000605")]
		 get { } //Length: 44
		[Address(RVA = "0x2DA5970", Offset = "0x2DA4D70", Length = "0x7C")]
		[Token(Token = "0x6000606")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x170001B2")]
	internal TextureHandle stpDebugView
	{
		[Address(RVA = "0x2DA5100", Offset = "0x2DA4500", Length = "0x2C")]
		[Token(Token = "0x6000609")]
		internal get { } //Length: 44
		[Address(RVA = "0x2DA59F0", Offset = "0x2DA4DF0", Length = "0x7C")]
		[Token(Token = "0x600060A")]
		internal set { } //Length: 124
	}

	[Address(RVA = "0x2DA49F0", Offset = "0x2DA3DF0", Length = "0x82")]
	[Token(Token = "0x600060C")]
	public UniversalResourceData() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005D5")]
	internal ActiveID get_activeColorID() { }

	[Address(RVA = "0x2DA4A80", Offset = "0x2DA3E80", Length = "0x15D")]
	[Token(Token = "0x60005D7")]
	public TextureHandle get_activeColorTexture() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005D9")]
	internal ActiveID get_activeDepthID() { }

	[Address(RVA = "0x2DA4BE0", Offset = "0x2DA3FE0", Length = "0x15D")]
	[Token(Token = "0x60005DB")]
	public TextureHandle get_activeDepthTexture() { }

	[Address(RVA = "0x2DA4D40", Offset = "0x2DA4140", Length = "0x29")]
	[Token(Token = "0x60005E7")]
	public TextureHandle get_additionalShadowsTexture() { }

	[Address(RVA = "0x2DA4D70", Offset = "0x2DA4170", Length = "0x2C")]
	[Token(Token = "0x60005FB")]
	public TextureHandle get_afterPostProcessColor() { }

	[Address(RVA = "0x2DA4DA0", Offset = "0x2DA41A0", Length = "0x29")]
	[Token(Token = "0x60005DD")]
	public TextureHandle get_backBufferColor() { }

	[Address(RVA = "0x2DA4DD0", Offset = "0x2DA41D0", Length = "0x29")]
	[Token(Token = "0x60005DF")]
	public TextureHandle get_backBufferDepth() { }

	[Address(RVA = "0x2D93220", Offset = "0x2D92620", Length = "0x29")]
	[Token(Token = "0x60005E1")]
	public TextureHandle get_cameraColor() { }

	[Address(RVA = "0x2D93260", Offset = "0x2D92660", Length = "0x29")]
	[Token(Token = "0x60005E3")]
	public TextureHandle get_cameraDepth() { }

	[Address(RVA = "0x2DA4E00", Offset = "0x2DA4200", Length = "0x2C")]
	[Token(Token = "0x60005ED")]
	public TextureHandle get_cameraDepthTexture() { }

	[Address(RVA = "0x2DA4E30", Offset = "0x2DA4230", Length = "0x2C")]
	[Token(Token = "0x60005EF")]
	public TextureHandle get_cameraNormalsTexture() { }

	[Address(RVA = "0x2DA4E60", Offset = "0x2DA4260", Length = "0x2C")]
	[Token(Token = "0x60005EB")]
	public TextureHandle get_cameraOpaqueTexture() { }

	[Address(RVA = "0x2DA4EC0", Offset = "0x2DA42C0", Length = "0xF")]
	[Token(Token = "0x6000601")]
	public TextureHandle[] get_dBuffer() { }

	[Address(RVA = "0x2DA4E90", Offset = "0x2DA4290", Length = "0x2C")]
	[Token(Token = "0x6000603")]
	public TextureHandle get_dBufferDepth() { }

	[Address(RVA = "0x2DA4ED0", Offset = "0x2DA42D0", Length = "0x2C")]
	[Token(Token = "0x60005F7")]
	internal TextureHandle get_debugScreenColor() { }

	[Address(RVA = "0x2DA4F00", Offset = "0x2DA4300", Length = "0x2C")]
	[Token(Token = "0x60005F9")]
	internal TextureHandle get_debugScreenDepth() { }

	[Address(RVA = "0x2DA4F30", Offset = "0x2DA4330", Length = "0xF")]
	[Token(Token = "0x60005E9")]
	public TextureHandle[] get_gBuffer() { }

	[Address(RVA = "0x2DA4F40", Offset = "0x2DA4340", Length = "0x2C")]
	[Token(Token = "0x60005F5")]
	public TextureHandle get_internalColorLut() { }

	[Address(RVA = "0x2DA4F70", Offset = "0x2DA4370", Length = "0x2C")]
	[Token(Token = "0x6000607")]
	internal TextureHandle get_irradianceTexture() { }

	[Address(RVA = "0x2DA4FA0", Offset = "0x2DA43A0", Length = "0x6F")]
	[Token(Token = "0x60005DC")]
	public bool get_isActiveTargetBackBuffer() { }

	[Address(RVA = "0x2D931A0", Offset = "0x2D925A0", Length = "0x29")]
	[Token(Token = "0x60005E5")]
	public TextureHandle get_mainShadowsTexture() { }

	[Address(RVA = "0x2DA5010", Offset = "0x2DA4410", Length = "0x2C")]
	[Token(Token = "0x60005F1")]
	public TextureHandle get_motionVectorColor() { }

	[Address(RVA = "0x2DA5040", Offset = "0x2DA4440", Length = "0x2C")]
	[Token(Token = "0x60005F3")]
	public TextureHandle get_motionVectorDepth() { }

	[Address(RVA = "0x2DA5070", Offset = "0x2DA4470", Length = "0x2C")]
	[Token(Token = "0x60005FD")]
	public TextureHandle get_overlayUITexture() { }

	[Address(RVA = "0x2DA50A0", Offset = "0x2DA44A0", Length = "0x2C")]
	[Token(Token = "0x60005FF")]
	public TextureHandle get_renderingLayersTexture() { }

	[Address(RVA = "0x2DA50D0", Offset = "0x2DA44D0", Length = "0x2C")]
	[Token(Token = "0x6000605")]
	public TextureHandle get_ssaoTexture() { }

	[Address(RVA = "0x2DA5100", Offset = "0x2DA4500", Length = "0x2C")]
	[Token(Token = "0x6000609")]
	internal TextureHandle get_stpDebugView() { }

	[Address(RVA = "0x2DA41E0", Offset = "0x2DA35E0", Length = "0x7F2")]
	[Token(Token = "0x600060B")]
	public virtual void Reset() { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005D6")]
	internal void set_activeColorID(ActiveID value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005DA")]
	internal void set_activeDepthID(ActiveID value) { }

	[Address(RVA = "0x2DA5130", Offset = "0x2DA4530", Length = "0x79")]
	[Token(Token = "0x60005E8")]
	public void set_additionalShadowsTexture(TextureHandle value) { }

	[Address(RVA = "0x2DA51B0", Offset = "0x2DA45B0", Length = "0x7C")]
	[Token(Token = "0x60005FC")]
	internal void set_afterPostProcessColor(TextureHandle value) { }

	[Address(RVA = "0x2DA5230", Offset = "0x2DA4630", Length = "0x79")]
	[Token(Token = "0x60005DE")]
	internal void set_backBufferColor(TextureHandle value) { }

	[Address(RVA = "0x2DA52B0", Offset = "0x2DA46B0", Length = "0x79")]
	[Token(Token = "0x60005E0")]
	internal void set_backBufferDepth(TextureHandle value) { }

	[Address(RVA = "0x2D933B0", Offset = "0x2D927B0", Length = "0x79")]
	[Token(Token = "0x60005E2")]
	public void set_cameraColor(TextureHandle value) { }

	[Address(RVA = "0x2D93440", Offset = "0x2D92840", Length = "0x79")]
	[Token(Token = "0x60005E4")]
	public void set_cameraDepth(TextureHandle value) { }

	[Address(RVA = "0x2DA5330", Offset = "0x2DA4730", Length = "0x7C")]
	[Token(Token = "0x60005EE")]
	internal void set_cameraDepthTexture(TextureHandle value) { }

	[Address(RVA = "0x2DA53B0", Offset = "0x2DA47B0", Length = "0x7C")]
	[Token(Token = "0x60005F0")]
	internal void set_cameraNormalsTexture(TextureHandle value) { }

	[Address(RVA = "0x2DA5430", Offset = "0x2DA4830", Length = "0x7C")]
	[Token(Token = "0x60005EC")]
	internal void set_cameraOpaqueTexture(TextureHandle value) { }

	[Address(RVA = "0x2DA5530", Offset = "0x2DA4930", Length = "0x12")]
	[Token(Token = "0x6000602")]
	public void set_dBuffer(TextureHandle[] value) { }

	[Address(RVA = "0x2DA54B0", Offset = "0x2DA48B0", Length = "0x7C")]
	[Token(Token = "0x6000604")]
	public void set_dBufferDepth(TextureHandle value) { }

	[Address(RVA = "0x2DA5550", Offset = "0x2DA4950", Length = "0x7C")]
	[Token(Token = "0x60005F8")]
	internal void set_debugScreenColor(TextureHandle value) { }

	[Address(RVA = "0x2DA55D0", Offset = "0x2DA49D0", Length = "0x7C")]
	[Token(Token = "0x60005FA")]
	internal void set_debugScreenDepth(TextureHandle value) { }

	[Address(RVA = "0x2DA5650", Offset = "0x2DA4A50", Length = "0x12")]
	[Token(Token = "0x60005EA")]
	public void set_gBuffer(TextureHandle[] value) { }

	[Address(RVA = "0x2DA5670", Offset = "0x2DA4A70", Length = "0x7C")]
	[Token(Token = "0x60005F6")]
	public void set_internalColorLut(TextureHandle value) { }

	[Address(RVA = "0x2DA56F0", Offset = "0x2DA4AF0", Length = "0x7C")]
	[Token(Token = "0x6000608")]
	internal void set_irradianceTexture(TextureHandle value) { }

	[Address(RVA = "0x2D93290", Offset = "0x2D92690", Length = "0x79")]
	[Token(Token = "0x60005E6")]
	public void set_mainShadowsTexture(TextureHandle value) { }

	[Address(RVA = "0x2DA5770", Offset = "0x2DA4B70", Length = "0x7C")]
	[Token(Token = "0x60005F2")]
	public void set_motionVectorColor(TextureHandle value) { }

	[Address(RVA = "0x2DA57F0", Offset = "0x2DA4BF0", Length = "0x7C")]
	[Token(Token = "0x60005F4")]
	public void set_motionVectorDepth(TextureHandle value) { }

	[Address(RVA = "0x2DA5870", Offset = "0x2DA4C70", Length = "0x7C")]
	[Token(Token = "0x60005FE")]
	internal void set_overlayUITexture(TextureHandle value) { }

	[Address(RVA = "0x2DA58F0", Offset = "0x2DA4CF0", Length = "0x7C")]
	[Token(Token = "0x6000600")]
	internal void set_renderingLayersTexture(TextureHandle value) { }

	[Address(RVA = "0x2DA5970", Offset = "0x2DA4D70", Length = "0x7C")]
	[Token(Token = "0x6000606")]
	internal void set_ssaoTexture(TextureHandle value) { }

	[Address(RVA = "0x2DA59F0", Offset = "0x2DA4DF0", Length = "0x7C")]
	[Token(Token = "0x600060A")]
	internal void set_stpDebugView(TextureHandle value) { }

	[Address(RVA = "0x2DA49E0", Offset = "0x2DA3DE0", Length = "0xF")]
	[Token(Token = "0x60005D8")]
	public void SwitchActiveTexturesToBackbuffer() { }

}

