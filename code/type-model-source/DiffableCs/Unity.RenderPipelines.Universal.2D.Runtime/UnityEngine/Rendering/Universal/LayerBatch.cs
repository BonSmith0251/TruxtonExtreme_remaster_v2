namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200003B")]
internal struct LayerBatch
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000123")]
	public int startLayerID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000124")]
	public int endLayerValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000125")]
	public SortingLayerRange layerRange; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000126")]
	public LightStats lightStats; //Field offset: 0xC
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000127")]
	public bool useNormals; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000128")]
	public List<Light2D> lights; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000129")]
	public List<Int32> shadowIndices; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400012A")]
	public List<ShadowCasterGroup2D> shadowCasters; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400012B")]
	internal Int32[] activeBlendStylesIndices; //Field offset: 0x48

	[Address(RVA = "0x2D203E0", Offset = "0x2D1F7E0", Length = "0xF9")]
	[Token(Token = "0x6000174")]
	public void InitRTIds(int index) { }

}

