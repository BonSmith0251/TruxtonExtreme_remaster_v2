namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Terrain Binder")]
[Token(Token = "0x200005F")]
[VFXBinder("Utility/Terrain")]
internal class VFXTerrainBinder : VFXBinderBase
{
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("TerrainParameter")]
	[Token(Token = "0x40001E4")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEditor.VFX.TerrainType"})]
	public ExposedProperty m_Property; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001E5")]
	public Terrain Terrain; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001E6")]
	private ExposedProperty Terrain_Bounds_center; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001E7")]
	private ExposedProperty Terrain_Bounds_size; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001E8")]
	private ExposedProperty Terrain_HeightMap; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001E9")]
	private ExposedProperty Terrain_Height; //Field offset: 0x50

	[Token(Token = "0x17000037")]
	public string Property
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x60001B4")]
		 get { } //Length: 27
		[Address(RVA = "0x2F81320", Offset = "0x2F80720", Length = "0x35")]
		[Token(Token = "0x60001B5")]
		 set { } //Length: 53
	}

	[Address(RVA = "0x2F812C0", Offset = "0x2F806C0", Length = "0x52")]
	[Token(Token = "0x60001BC")]
	public VFXTerrainBinder() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x60001B4")]
	public string get_Property() { }

	[Address(RVA = "0x2F80E30", Offset = "0x2F80230", Length = "0xFA")]
	[Token(Token = "0x60001B9")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F80F30", Offset = "0x2F80330", Length = "0x1F")]
	[Token(Token = "0x60001B6")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2F80F50", Offset = "0x2F80350", Length = "0x7")]
	[Token(Token = "0x60001B7")]
	private void OnValidate() { }

	[Address(RVA = "0x2F81320", Offset = "0x2F80720", Length = "0x35")]
	[Token(Token = "0x60001B5")]
	public void set_Property(string value) { }

	[Address(RVA = "0x2F80F60", Offset = "0x2F80360", Length = "0xB9")]
	[Token(Token = "0x60001BB")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F81020", Offset = "0x2F80420", Length = "0x171")]
	[Token(Token = "0x60001BA")]
	public virtual void UpdateBinding(VisualEffect component) { }

	[Address(RVA = "0x2F811A0", Offset = "0x2F805A0", Length = "0x117")]
	[Token(Token = "0x60001B8")]
	private void UpdateSubProperties() { }

}

