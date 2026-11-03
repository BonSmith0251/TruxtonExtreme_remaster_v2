namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000D8")]
internal class Universal2DResourceData : UniversalResourceDataBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004E2")]
	private TextureHandle[][] _lightTextures; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004E3")]
	private TextureHandle[] _cameraNormalsTexture; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004E4")]
	private TextureHandle _normalsDepth; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004E5")]
	private TextureHandle[][] _shadowTextures; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004E6")]
	private TextureHandle _shadowDepth; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004E7")]
	private TextureHandle _upscaleTexture; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004E8")]
	private TextureHandle _cameraSortingLayerTexture; //Field offset: 0x60

	[Token(Token = "0x17000190")]
	internal TextureHandle cameraSortingLayerTexture
	{
		[Address(RVA = "0x2D931A0", Offset = "0x2D925A0", Length = "0x29")]
		[Token(Token = "0x60005B7")]
		internal get { } //Length: 41
		[Address(RVA = "0x2D93290", Offset = "0x2D92690", Length = "0x79")]
		[Token(Token = "0x60005B8")]
		internal set { } //Length: 121
	}

	[Token(Token = "0x1700018A")]
	internal TextureHandle[][] lightTextures
	{
		[Address(RVA = "0x2D931D0", Offset = "0x2D925D0", Length = "0xC")]
		[Token(Token = "0x60005AB")]
		internal get { } //Length: 12
		[Address(RVA = "0x2D93310", Offset = "0x2D92710", Length = "0xF")]
		[Token(Token = "0x60005AC")]
		internal set { } //Length: 15
	}

	[Token(Token = "0x1700018C")]
	internal TextureHandle normalsDepth
	{
		[Address(RVA = "0x2D931E0", Offset = "0x2D925E0", Length = "0x29")]
		[Token(Token = "0x60005AF")]
		internal get { } //Length: 41
		[Address(RVA = "0x2D93320", Offset = "0x2D92720", Length = "0x79")]
		[Token(Token = "0x60005B0")]
		internal set { } //Length: 121
	}

	[Token(Token = "0x1700018B")]
	internal TextureHandle[] normalsTexture
	{
		[Address(RVA = "0x2D93210", Offset = "0x2D92610", Length = "0xC")]
		[Token(Token = "0x60005AD")]
		internal get { } //Length: 12
		[Address(RVA = "0x2D933A0", Offset = "0x2D927A0", Length = "0xF")]
		[Token(Token = "0x60005AE")]
		internal set { } //Length: 15
	}

	[Token(Token = "0x1700018E")]
	internal TextureHandle shadowDepth
	{
		[Address(RVA = "0x2D93220", Offset = "0x2D92620", Length = "0x29")]
		[Token(Token = "0x60005B3")]
		internal get { } //Length: 41
		[Address(RVA = "0x2D933B0", Offset = "0x2D927B0", Length = "0x79")]
		[Token(Token = "0x60005B4")]
		internal set { } //Length: 121
	}

	[Token(Token = "0x1700018D")]
	internal TextureHandle[][] shadowTextures
	{
		[Address(RVA = "0x2D93250", Offset = "0x2D92650", Length = "0xC")]
		[Token(Token = "0x60005B1")]
		internal get { } //Length: 12
		[Address(RVA = "0x2D93430", Offset = "0x2D92830", Length = "0xF")]
		[Token(Token = "0x60005B2")]
		internal set { } //Length: 15
	}

	[Token(Token = "0x1700018F")]
	internal TextureHandle upscaleTexture
	{
		[Address(RVA = "0x2D93260", Offset = "0x2D92660", Length = "0x29")]
		[Token(Token = "0x60005B5")]
		internal get { } //Length: 41
		[Address(RVA = "0x2D93440", Offset = "0x2D92840", Length = "0x79")]
		[Token(Token = "0x60005B6")]
		internal set { } //Length: 121
	}

	[Address(RVA = "0x2D93100", Offset = "0x2D92500", Length = "0x9A")]
	[Token(Token = "0x60005BA")]
	public Universal2DResourceData() { }

	[Address(RVA = "0x2D92A40", Offset = "0x2D91E40", Length = "0x16B")]
	[Token(Token = "0x60005A9")]
	private TextureHandle[][] CheckAndGetTextureHandle(ref TextureHandle[][] handle) { }

	[Address(RVA = "0x2D92BB0", Offset = "0x2D91FB0", Length = "0x138")]
	[Token(Token = "0x60005AA")]
	private void CheckAndSetTextureHandle(ref TextureHandle[][] handle, TextureHandle[][] newHandle) { }

	[Address(RVA = "0x2D931A0", Offset = "0x2D925A0", Length = "0x29")]
	[Token(Token = "0x60005B7")]
	internal TextureHandle get_cameraSortingLayerTexture() { }

	[Address(RVA = "0x2D931D0", Offset = "0x2D925D0", Length = "0xC")]
	[Token(Token = "0x60005AB")]
	internal TextureHandle[][] get_lightTextures() { }

	[Address(RVA = "0x2D931E0", Offset = "0x2D925E0", Length = "0x29")]
	[Token(Token = "0x60005AF")]
	internal TextureHandle get_normalsDepth() { }

	[Address(RVA = "0x2D93210", Offset = "0x2D92610", Length = "0xC")]
	[Token(Token = "0x60005AD")]
	internal TextureHandle[] get_normalsTexture() { }

	[Address(RVA = "0x2D93220", Offset = "0x2D92620", Length = "0x29")]
	[Token(Token = "0x60005B3")]
	internal TextureHandle get_shadowDepth() { }

	[Address(RVA = "0x2D93250", Offset = "0x2D92650", Length = "0xC")]
	[Token(Token = "0x60005B1")]
	internal TextureHandle[][] get_shadowTextures() { }

	[Address(RVA = "0x2D93260", Offset = "0x2D92660", Length = "0x29")]
	[Token(Token = "0x60005B5")]
	internal TextureHandle get_upscaleTexture() { }

	[Address(RVA = "0x2D92CF0", Offset = "0x2D920F0", Length = "0x40A")]
	[Token(Token = "0x60005B9")]
	public virtual void Reset() { }

	[Address(RVA = "0x2D93290", Offset = "0x2D92690", Length = "0x79")]
	[Token(Token = "0x60005B8")]
	internal void set_cameraSortingLayerTexture(TextureHandle value) { }

	[Address(RVA = "0x2D93310", Offset = "0x2D92710", Length = "0xF")]
	[Token(Token = "0x60005AC")]
	internal void set_lightTextures(TextureHandle[][] value) { }

	[Address(RVA = "0x2D93320", Offset = "0x2D92720", Length = "0x79")]
	[Token(Token = "0x60005B0")]
	internal void set_normalsDepth(TextureHandle value) { }

	[Address(RVA = "0x2D933A0", Offset = "0x2D927A0", Length = "0xF")]
	[Token(Token = "0x60005AE")]
	internal void set_normalsTexture(TextureHandle[] value) { }

	[Address(RVA = "0x2D933B0", Offset = "0x2D927B0", Length = "0x79")]
	[Token(Token = "0x60005B4")]
	internal void set_shadowDepth(TextureHandle value) { }

	[Address(RVA = "0x2D93430", Offset = "0x2D92830", Length = "0xF")]
	[Token(Token = "0x60005B2")]
	internal void set_shadowTextures(TextureHandle[][] value) { }

	[Address(RVA = "0x2D93440", Offset = "0x2D92840", Length = "0x79")]
	[Token(Token = "0x60005B6")]
	internal void set_upscaleTexture(TextureHandle value) { }

}

