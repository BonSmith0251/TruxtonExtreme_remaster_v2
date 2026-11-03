namespace AEAsAnimation;

[Token(Token = "0x2000009")]
public class AEItemsAccessor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000028")]
	public Func<AEComposition> GetMainComposition; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000029")]
	public Func<Int32, CompositionData> GetComposition; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002A")]
	public Func<String, LayerData> GetLayer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400002B")]
	public Func<MetaData> GetMetaData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400002C")]
	public Action<AEComposition, GameObject> RegisterComposition; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400002D")]
	public Action<AELayer, GameObject> RegisterLayer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400002E")]
	public Action<AELayer, AELayerReflection> RegisterLayerReflection; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400002F")]
	public Func<GlobalColorData> GetGlobalColorData; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000030")]
	public Func<IAETextureAccessor> GetTextureAccessor; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000031")]
	public Func<IAEAudioAccessor> GetAudioAccessor; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000032")]
	public Func<IAECompositionFilter> GetCompositionFilter; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000033")]
	public Func<IAELayerFilter> GetLayerFilter; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000034")]
	public Func<AEMaterial> GetMaterialAccessor; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000035")]
	public Func<TextReflector> GetTextReflector; //Field offset: 0x78

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000047")]
	public AEItemsAccessor() { }

}

