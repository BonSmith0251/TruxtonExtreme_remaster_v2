namespace TMPro;

[ExecuteAlways]
[RequireComponent(typeof(CanvasRenderer))]
[Token(Token = "0x2000093")]
public class TMP_SubMeshUI : MaskableGraphic
{
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x40004BA")]
	private TMP_FontAsset m_fontAsset; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x40004BB")]
	private TMP_SpriteAsset m_spriteAsset; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x40004BC")]
	private Material m_material; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x40004BD")]
	private Material m_sharedMaterial; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40004BE")]
	private Material m_fallbackMaterial; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40004BF")]
	private Material m_fallbackSourceMaterial; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40004C0")]
	private bool m_isDefaultMaterial; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	[Token(Token = "0x40004C1")]
	private float m_padding; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40004C2")]
	private Mesh m_mesh; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x40004C3")]
	private TextMeshProUGUI m_TextComponent; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40004C4")]
	private bool m_isRegisteredForEvents; //Field offset: 0x128
	[FieldOffset(Offset = "0x129")]
	[Token(Token = "0x40004C5")]
	private bool m_materialDirty; //Field offset: 0x129
	[FieldOffset(Offset = "0x12C")]
	[SerializeField]
	[Token(Token = "0x40004C6")]
	private int m_materialReferenceIndex; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40004C7")]
	private Transform m_RootCanvasTransform; //Field offset: 0x130

	[Token(Token = "0x17000123")]
	public Material fallbackMaterial
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[Token(Token = "0x6000507")]
		 get { } //Length: 8
		[Address(RVA = "0x2F14BD0", Offset = "0x2F13FD0", Length = "0x192")]
		[Token(Token = "0x6000508")]
		 set { } //Length: 402
	}

	[Token(Token = "0x17000124")]
	public Material fallbackSourceMaterial
	{
		[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
		[Token(Token = "0x6000509")]
		 get { } //Length: 8
		[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
		[Token(Token = "0x600050A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700011E")]
	public TMP_FontAsset fontAsset
	{
		[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
		[Token(Token = "0x60004FE")]
		 get { } //Length: 8
		[Address(RVA = "0x20D5120", Offset = "0x20D4520", Length = "0x13")]
		[Token(Token = "0x60004FF")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000126")]
	public bool isDefaultMaterial
	{
		[Address(RVA = "0x213FF00", Offset = "0x213F300", Length = "0x8")]
		[Token(Token = "0x600050C")]
		 get { } //Length: 8
		[Address(RVA = "0x2140020", Offset = "0x213F420", Length = "0x7")]
		[Token(Token = "0x600050D")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000120")]
	public virtual Texture mainTexture
	{
		[Address(RVA = "0x2F14930", Offset = "0x2F13D30", Length = "0xBD")]
		[Token(Token = "0x6000502")]
		 get { } //Length: 189
	}

	[Token(Token = "0x17000121")]
	public virtual Material material
	{
		[Address(RVA = "0x2F14A50", Offset = "0x2F13E50", Length = "0xF")]
		[Token(Token = "0x6000503")]
		 get { } //Length: 15
		[Address(RVA = "0x2F14D70", Offset = "0x2F14170", Length = "0x10D")]
		[Token(Token = "0x6000504")]
		 set { } //Length: 269
	}

	[Token(Token = "0x17000125")]
	public virtual Material materialForRendering
	{
		[Address(RVA = "0x2F149F0", Offset = "0x2F13DF0", Length = "0x5D")]
		[Token(Token = "0x600050B")]
		 get { } //Length: 93
	}

	[Token(Token = "0x17000128")]
	public Mesh mesh
	{
		[Address(RVA = "0x2F14A60", Offset = "0x2F13E60", Length = "0xC1")]
		[Token(Token = "0x6000510")]
		 get { } //Length: 193
		[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
		[Token(Token = "0x6000511")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000127")]
	public float padding
	{
		[Address(RVA = "0x2D25F00", Offset = "0x2D25300", Length = "0x9")]
		[Token(Token = "0x600050E")]
		 get { } //Length: 9
		[Address(RVA = "0x2D26170", Offset = "0x2D25570", Length = "0x9")]
		[Token(Token = "0x600050F")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000122")]
	public Material sharedMaterial
	{
		[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
		[Token(Token = "0x6000505")]
		 get { } //Length: 8
		[Address(RVA = "0x2F14620", Offset = "0x2F13A20", Length = "0x5E")]
		[Token(Token = "0x6000506")]
		 set { } //Length: 94
	}

	[Token(Token = "0x1700011F")]
	public TMP_SpriteAsset spriteAsset
	{
		[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
		[Token(Token = "0x6000500")]
		 get { } //Length: 8
		[Address(RVA = "0x20D5300", Offset = "0x20D4700", Length = "0x13")]
		[Token(Token = "0x6000501")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000129")]
	public TMP_Text textComponent
	{
		[Address(RVA = "0x2F14B30", Offset = "0x2F13F30", Length = "0x99")]
		[Token(Token = "0x6000512")]
		 get { } //Length: 153
	}

	[Address(RVA = "0x5C4070", Offset = "0x5C3470", Length = "0x7")]
	[Token(Token = "0x600052D")]
	public TMP_SubMeshUI() { }

	[Address(RVA = "0x2F137D0", Offset = "0x2F12BD0", Length = "0x3D8")]
	[Token(Token = "0x6000513")]
	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	[Address(RVA = "0x2F13BB0", Offset = "0x2F12FB0", Length = "0xB1")]
	[Token(Token = "0x600052A")]
	private Material CreateMaterialInstance(Material source) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000522")]
	public virtual void Cull(Rect clipRect, bool validRect) { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[Token(Token = "0x6000507")]
	public Material get_fallbackMaterial() { }

	[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
	[Token(Token = "0x6000509")]
	public Material get_fallbackSourceMaterial() { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[Token(Token = "0x60004FE")]
	public TMP_FontAsset get_fontAsset() { }

	[Address(RVA = "0x213FF00", Offset = "0x213F300", Length = "0x8")]
	[Token(Token = "0x600050C")]
	public bool get_isDefaultMaterial() { }

	[Address(RVA = "0x2F14930", Offset = "0x2F13D30", Length = "0xBD")]
	[Token(Token = "0x6000502")]
	public virtual Texture get_mainTexture() { }

	[Address(RVA = "0x2F14A50", Offset = "0x2F13E50", Length = "0xF")]
	[Token(Token = "0x6000503")]
	public virtual Material get_material() { }

	[Address(RVA = "0x2F149F0", Offset = "0x2F13DF0", Length = "0x5D")]
	[Token(Token = "0x600050B")]
	public virtual Material get_materialForRendering() { }

	[Address(RVA = "0x2F14A60", Offset = "0x2F13E60", Length = "0xC1")]
	[Token(Token = "0x6000510")]
	public Mesh get_mesh() { }

	[Address(RVA = "0x2D25F00", Offset = "0x2D25300", Length = "0x9")]
	[Token(Token = "0x600050E")]
	public float get_padding() { }

	[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
	[Token(Token = "0x6000505")]
	public Material get_sharedMaterial() { }

	[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
	[Token(Token = "0x6000500")]
	public TMP_SpriteAsset get_spriteAsset() { }

	[Address(RVA = "0x2F14B30", Offset = "0x2F13F30", Length = "0x99")]
	[Token(Token = "0x6000512")]
	public TMP_Text get_textComponent() { }

	[Address(RVA = "0x2F13C70", Offset = "0x2F13070", Length = "0x1B5")]
	[Token(Token = "0x6000529")]
	private Material GetMaterial(Material mat) { }

	[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
	[Token(Token = "0x6000528")]
	private Material GetMaterial() { }

	[Address(RVA = "0x2F13E30", Offset = "0x2F13230", Length = "0x153")]
	[Token(Token = "0x6000518")]
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	[Address(RVA = "0x2F13F90", Offset = "0x2F13390", Length = "0x87")]
	[Token(Token = "0x600051A")]
	public float GetPaddingForMaterial(Material mat) { }

	[Address(RVA = "0x2F14020", Offset = "0x2F13420", Length = "0x8B")]
	[Token(Token = "0x6000519")]
	public float GetPaddingForMaterial() { }

	[Address(RVA = "0x2F140B0", Offset = "0x2F134B0", Length = "0xB4")]
	[Token(Token = "0x6000521")]
	private Transform GetRootCanvasTransform() { }

	[Address(RVA = "0x2F14170", Offset = "0x2F13570", Length = "0x23")]
	[Token(Token = "0x600052B")]
	private Material GetSharedMaterial() { }

	[Address(RVA = "0x2F141A0", Offset = "0x2F135A0", Length = "0x1D6")]
	[Token(Token = "0x6000516")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x2F14380", Offset = "0x2F13780", Length = "0xB6")]
	[Token(Token = "0x6000515")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x2F14440", Offset = "0x2F13840", Length = "0x6E")]
	[Token(Token = "0x6000514")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2F144B0", Offset = "0x2F138B0", Length = "0x5F")]
	[Token(Token = "0x6000517")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x2F14510", Offset = "0x2F13910", Length = "0x36")]
	[Token(Token = "0x6000524")]
	public virtual void Rebuild(CanvasUpdate update) { }

	[Address(RVA = "0x2E9E6B0", Offset = "0x2E9DAB0", Length = "0x7")]
	[Token(Token = "0x6000527")]
	public virtual void RecalculateClipping() { }

	[Address(RVA = "0x1FCE300", Offset = "0x1FCD700", Length = "0x14")]
	[Token(Token = "0x6000525")]
	public void RefreshMaterial() { }

	[Address(RVA = "0x2F14BD0", Offset = "0x2F13FD0", Length = "0x192")]
	[Token(Token = "0x6000508")]
	public void set_fallbackMaterial(Material value) { }

	[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
	[Token(Token = "0x600050A")]
	public void set_fallbackSourceMaterial(Material value) { }

	[Address(RVA = "0x20D5120", Offset = "0x20D4520", Length = "0x13")]
	[Token(Token = "0x60004FF")]
	public void set_fontAsset(TMP_FontAsset value) { }

	[Address(RVA = "0x2140020", Offset = "0x213F420", Length = "0x7")]
	[Token(Token = "0x600050D")]
	public void set_isDefaultMaterial(bool value) { }

	[Address(RVA = "0x2F14D70", Offset = "0x2F14170", Length = "0x10D")]
	[Token(Token = "0x6000504")]
	public virtual void set_material(Material value) { }

	[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
	[Token(Token = "0x6000511")]
	public void set_mesh(Mesh value) { }

	[Address(RVA = "0x2D26170", Offset = "0x2D25570", Length = "0x9")]
	[Token(Token = "0x600050F")]
	public void set_padding(float value) { }

	[Address(RVA = "0x2F14620", Offset = "0x2F13A20", Length = "0x5E")]
	[Token(Token = "0x6000506")]
	public void set_sharedMaterial(Material value) { }

	[Address(RVA = "0x20D5300", Offset = "0x20D4700", Length = "0x13")]
	[Token(Token = "0x6000501")]
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600051C")]
	public virtual void SetAllDirty() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600051E")]
	public virtual void SetLayoutDirty() { }

	[Address(RVA = "0x2F14550", Offset = "0x2F13950", Length = "0x4E")]
	[Token(Token = "0x600051F")]
	public virtual void SetMaterialDirty() { }

	[Address(RVA = "0x2F145A0", Offset = "0x2F139A0", Length = "0x77")]
	[Token(Token = "0x6000520")]
	public void SetPivotDirty() { }

	[Address(RVA = "0x2F14620", Offset = "0x2F13A20", Length = "0x5E")]
	[Token(Token = "0x600052C")]
	private void SetSharedMaterial(Material mat) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600051D")]
	public virtual void SetVerticesDirty() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000523")]
	protected virtual void UpdateGeometry() { }

	[Address(RVA = "0x2F14680", Offset = "0x2F13A80", Length = "0x211")]
	[Token(Token = "0x6000526")]
	protected virtual void UpdateMaterial() { }

	[Address(RVA = "0x2F148A0", Offset = "0x2F13CA0", Length = "0x86")]
	[Token(Token = "0x600051B")]
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

}

