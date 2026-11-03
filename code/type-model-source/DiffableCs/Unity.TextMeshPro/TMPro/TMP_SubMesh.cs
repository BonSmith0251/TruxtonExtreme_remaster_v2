namespace TMPro;

[ExecuteAlways]
[RequireComponent(typeof(MeshRenderer))]
[Token(Token = "0x2000092")]
public class TMP_SubMesh : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40004AD")]
	private TMP_FontAsset m_fontAsset; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40004AE")]
	private TMP_SpriteAsset m_spriteAsset; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40004AF")]
	private Material m_material; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40004B0")]
	private Material m_sharedMaterial; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004B1")]
	private Material m_fallbackMaterial; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004B2")]
	private Material m_fallbackSourceMaterial; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40004B3")]
	private bool m_isDefaultMaterial; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x40004B4")]
	private float m_padding; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40004B5")]
	private Renderer m_renderer; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004B6")]
	private MeshFilter m_meshFilter; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40004B7")]
	private Mesh m_mesh; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40004B8")]
	private TextMeshPro m_TextComponent; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40004B9")]
	private bool m_isRegisteredForEvents; //Field offset: 0x78

	[Token(Token = "0x17000116")]
	public Material fallbackMaterial
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60004E2")]
		 get { } //Length: 5
		[Address(RVA = "0x2F160B0", Offset = "0x2F154B0", Length = "0x151")]
		[Token(Token = "0x60004E3")]
		 set { } //Length: 337
	}

	[Token(Token = "0x17000117")]
	public Material fallbackSourceMaterial
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60004E4")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x60004E5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000112")]
	public TMP_FontAsset fontAsset
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60004DA")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60004DB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000118")]
	public bool isDefaultMaterial
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[Token(Token = "0x60004E6")]
		 get { } //Length: 5
		[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
		[Token(Token = "0x60004E7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000114")]
	public Material material
	{
		[Address(RVA = "0x2F15DA0", Offset = "0x2F151A0", Length = "0xC")]
		[Token(Token = "0x60004DE")]
		 get { } //Length: 12
		[Address(RVA = "0x2F16210", Offset = "0x2F15610", Length = "0x88")]
		[Token(Token = "0x60004DF")]
		 set { } //Length: 136
	}

	[Token(Token = "0x1700011C")]
	public Mesh mesh
	{
		[Address(RVA = "0x2F15ED0", Offset = "0x2F152D0", Length = "0xB2")]
		[Token(Token = "0x60004EC")]
		 get { } //Length: 178
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x60004ED")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700011B")]
	public MeshFilter meshFilter
	{
		[Address(RVA = "0x2F15DB0", Offset = "0x2F151B0", Length = "0x110")]
		[Token(Token = "0x60004EB")]
		 get { } //Length: 272
	}

	[Token(Token = "0x17000119")]
	public float padding
	{
		[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
		[Token(Token = "0x60004E8")]
		 get { } //Length: 6
		[Address(RVA = "0x1D1D150", Offset = "0x1D1C550", Length = "0x6")]
		[Token(Token = "0x60004E9")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700011A")]
	public Renderer renderer
	{
		[Address(RVA = "0x2F15F90", Offset = "0x2F15390", Length = "0x8D")]
		[Token(Token = "0x60004EA")]
		 get { } //Length: 141
	}

	[Token(Token = "0x17000115")]
	public Material sharedMaterial
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60004E0")]
		 get { } //Length: 5
		[Address(RVA = "0x2F15AE0", Offset = "0x2F14EE0", Length = "0x34")]
		[Token(Token = "0x60004E1")]
		 set { } //Length: 52
	}

	[Token(Token = "0x17000113")]
	public TMP_SpriteAsset spriteAsset
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60004DC")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60004DD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700011D")]
	public TMP_Text textComponent
	{
		[Address(RVA = "0x2F16020", Offset = "0x2F15420", Length = "0x8D")]
		[Token(Token = "0x60004EE")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60004FD")]
	public TMP_SubMesh() { }

	[Address(RVA = "0x2F14E80", Offset = "0x2F14280", Length = "0x373")]
	[Token(Token = "0x60004EF")]
	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	[Address(RVA = "0x2F15200", Offset = "0x2F14600", Length = "0xB1")]
	[Token(Token = "0x60004F5")]
	private Material CreateMaterialInstance(Material source) { }

	[Address(RVA = "0x2F152C0", Offset = "0x2F146C0", Length = "0x5F")]
	[Token(Token = "0x60004F3")]
	public void DestroySelf() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60004E2")]
	public Material get_fallbackMaterial() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60004E4")]
	public Material get_fallbackSourceMaterial() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60004DA")]
	public TMP_FontAsset get_fontAsset() { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[Token(Token = "0x60004E6")]
	public bool get_isDefaultMaterial() { }

	[Address(RVA = "0x2F15DA0", Offset = "0x2F151A0", Length = "0xC")]
	[Token(Token = "0x60004DE")]
	public Material get_material() { }

	[Address(RVA = "0x2F15ED0", Offset = "0x2F152D0", Length = "0xB2")]
	[Token(Token = "0x60004EC")]
	public Mesh get_mesh() { }

	[Address(RVA = "0x2F15DB0", Offset = "0x2F151B0", Length = "0x110")]
	[Token(Token = "0x60004EB")]
	public MeshFilter get_meshFilter() { }

	[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
	[Token(Token = "0x60004E8")]
	public float get_padding() { }

	[Address(RVA = "0x2F15F90", Offset = "0x2F15390", Length = "0x8D")]
	[Token(Token = "0x60004EA")]
	public Renderer get_renderer() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60004E0")]
	public Material get_sharedMaterial() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60004DC")]
	public TMP_SpriteAsset get_spriteAsset() { }

	[Address(RVA = "0x2F16020", Offset = "0x2F15420", Length = "0x8D")]
	[Token(Token = "0x60004EE")]
	public TMP_Text get_textComponent() { }

	[Address(RVA = "0x2F15320", Offset = "0x2F14720", Length = "0x1CD")]
	[Token(Token = "0x60004F4")]
	private Material GetMaterial(Material mat) { }

	[Address(RVA = "0x2F154F0", Offset = "0x2F148F0", Length = "0x85")]
	[Token(Token = "0x60004F8")]
	public float GetPaddingForMaterial() { }

	[Address(RVA = "0x2F15580", Offset = "0x2F14980", Length = "0x9D")]
	[Token(Token = "0x60004F6")]
	private Material GetSharedMaterial() { }

	[Address(RVA = "0x2F15620", Offset = "0x2F14A20", Length = "0x14F")]
	[Token(Token = "0x60004F2")]
	private void OnDestroy() { }

	[Address(RVA = "0x2F15770", Offset = "0x2F14B70", Length = "0xB9")]
	[Token(Token = "0x60004F1")]
	private void OnDisable() { }

	[Address(RVA = "0x2F15830", Offset = "0x2F14C30", Length = "0x29C")]
	[Token(Token = "0x60004F0")]
	private void OnEnable() { }

	[Address(RVA = "0x2F160B0", Offset = "0x2F154B0", Length = "0x151")]
	[Token(Token = "0x60004E3")]
	public void set_fallbackMaterial(Material value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x60004E5")]
	public void set_fallbackSourceMaterial(Material value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60004DB")]
	public void set_fontAsset(TMP_FontAsset value) { }

	[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
	[Token(Token = "0x60004E7")]
	public void set_isDefaultMaterial(bool value) { }

	[Address(RVA = "0x2F16210", Offset = "0x2F15610", Length = "0x88")]
	[Token(Token = "0x60004DF")]
	public void set_material(Material value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x60004ED")]
	public void set_mesh(Mesh value) { }

	[Address(RVA = "0x1D1D150", Offset = "0x1D1C550", Length = "0x6")]
	[Token(Token = "0x60004E9")]
	public void set_padding(float value) { }

	[Address(RVA = "0x2F15AE0", Offset = "0x2F14EE0", Length = "0x34")]
	[Token(Token = "0x60004E1")]
	public void set_sharedMaterial(Material value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60004DD")]
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	[Address(RVA = "0x2F15AD0", Offset = "0x2F14ED0", Length = "0x7")]
	[Token(Token = "0x60004FB")]
	public void SetMaterialDirty() { }

	[Address(RVA = "0x2F15AE0", Offset = "0x2F14EE0", Length = "0x34")]
	[Token(Token = "0x60004F7")]
	private void SetSharedMaterial(Material mat) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004FA")]
	public void SetVerticesDirty() { }

	[Address(RVA = "0x2F15B20", Offset = "0x2F14F20", Length = "0x1F7")]
	[Token(Token = "0x60004FC")]
	protected void UpdateMaterial() { }

	[Address(RVA = "0x2F15D20", Offset = "0x2F15120", Length = "0x80")]
	[Token(Token = "0x60004F9")]
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

}

