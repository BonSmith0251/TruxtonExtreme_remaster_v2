namespace UnityEngine.Rendering.Universal;

[AddComponentMenu("Rendering/URP Decal Projector")]
[ExecuteAlways]
[Token(Token = "0x200007F")]
public class DecalProjector : MonoBehaviour, ISerializationCallbackReceiver
{
	[Token(Token = "0x2000080")]
	public sealed class DecalProjectorAction : MulticastDelegate
	{

		[Address(RVA = "0x5BC6F0", Offset = "0x5BBAF0", Length = "0x124")]
		[Token(Token = "0x600030C")]
		public DecalProjectorAction(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x600030E")]
		public override IAsyncResult BeginInvoke(DecalProjector decalProjector, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600030F")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x600030D")]
		public override void Invoke(DecalProjector decalProjector) { }

	}

	[Token(Token = "0x2000081")]
	private enum Version : int
	{
		Initial = 0,
		RenderingLayerMask = 1,
		Count = 2,
	}

	[CompilerGenerated]
	[Token(Token = "0x400024C")]
	private static DecalProjectorAction onDecalAdd; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x400024D")]
	private static DecalProjectorAction onDecalRemove; //Field offset: 0x8
	[CompilerGenerated]
	[Token(Token = "0x400024E")]
	private static DecalProjectorAction onDecalPropertyChange; //Field offset: 0x10
	[CompilerGenerated]
	[Token(Token = "0x400024F")]
	private static Action onAllDecalPropertyChange; //Field offset: 0x18
	[CompilerGenerated]
	[Token(Token = "0x4000250")]
	private static DecalProjectorAction onDecalMaterialChange; //Field offset: 0x20
	[CompilerGenerated]
	[Token(Token = "0x4000251")]
	private static Material <defaultMaterial>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000252")]
	private DecalEntity <decalEntity>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000253")]
	private Material m_Material; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000254")]
	private float m_DrawDistance; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x4000255")]
	private float m_FadeScale; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Range(0, 180)]
	[SerializeField]
	[Token(Token = "0x4000256")]
	private float m_StartAngleFade; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Range(0, 180)]
	[SerializeField]
	[Token(Token = "0x4000257")]
	private float m_EndAngleFade; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000258")]
	private Vector2 m_UVScale; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000259")]
	private Vector2 m_UVBias; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400025A")]
	private RenderingLayerMask m_RenderingLayerMask; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x400025B")]
	private DecalScaleMode m_ScaleMode; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400025C")]
	internal Vector3 m_Offset; //Field offset: 0x58
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x400025D")]
	internal Vector3 m_Size; //Field offset: 0x64
	[FieldOffset(Offset = "0x70")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x400025E")]
	private float m_FadeFactor; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400025F")]
	private Material m_OldMaterial; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000260")]
	private float m_OldDrawDistance; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000261")]
	private float m_OldFadeScale; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000262")]
	private float m_OldStartAngleFade; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000263")]
	private float m_OldEndAngleFade; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000264")]
	private Vector2 m_OldUVScale; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000265")]
	private Vector2 m_OldUVBias; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000266")]
	private DecalScaleMode m_OldScaleMode; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000267")]
	private Vector3 m_OldOffset; //Field offset: 0xA4
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000268")]
	private Vector3 m_OldSize; //Field offset: 0xB0
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000269")]
	private float m_OldFadeFactor; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x400026A")]
	private Version version; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Obsolete("This field is only kept for migration purpose. Use m_RenderingLayersMask instead. #from(6000.2)")]
	[SerializeField]
	[Token(Token = "0x400026B")]
	private uint m_DecalLayerMask; //Field offset: 0xC4

	[Token(Token = "0x14000004")]
	internal static event Action onAllDecalPropertyChange
	{
		[Address(RVA = "0x2D7DBE0", Offset = "0x2D7CFE0", Length = "0xB8")]
		[CompilerGenerated]
		[Token(Token = "0x60002DD")]
		internal add { } //Length: 184
		[Address(RVA = "0x2D7E180", Offset = "0x2D7D580", Length = "0xB8")]
		[CompilerGenerated]
		[Token(Token = "0x60002DE")]
		internal remove { } //Length: 184
	}

	[Token(Token = "0x14000001")]
	internal static event DecalProjectorAction onDecalAdd
	{
		[Address(RVA = "0x2D7DCA0", Offset = "0x2D7D0A0", Length = "0xB4")]
		[CompilerGenerated]
		[Token(Token = "0x60002D7")]
		internal add { } //Length: 180
		[Address(RVA = "0x2D7E240", Offset = "0x2D7D640", Length = "0xB4")]
		[CompilerGenerated]
		[Token(Token = "0x60002D8")]
		internal remove { } //Length: 180
	}

	[Token(Token = "0x14000005")]
	internal static event DecalProjectorAction onDecalMaterialChange
	{
		[Address(RVA = "0x2D7DD60", Offset = "0x2D7D160", Length = "0xB8")]
		[CompilerGenerated]
		[Token(Token = "0x60002DF")]
		internal add { } //Length: 184
		[Address(RVA = "0x2D7E300", Offset = "0x2D7D700", Length = "0xB8")]
		[CompilerGenerated]
		[Token(Token = "0x60002E0")]
		internal remove { } //Length: 184
	}

	[Token(Token = "0x14000003")]
	internal static event DecalProjectorAction onDecalPropertyChange
	{
		[Address(RVA = "0x2D7DE20", Offset = "0x2D7D220", Length = "0xB8")]
		[CompilerGenerated]
		[Token(Token = "0x60002DB")]
		internal add { } //Length: 184
		[Address(RVA = "0x2D7E3C0", Offset = "0x2D7D7C0", Length = "0xB8")]
		[CompilerGenerated]
		[Token(Token = "0x60002DC")]
		internal remove { } //Length: 184
	}

	[Token(Token = "0x14000002")]
	internal static event DecalProjectorAction onDecalRemove
	{
		[Address(RVA = "0x2D7DEE0", Offset = "0x2D7D2E0", Length = "0xB8")]
		[CompilerGenerated]
		[Token(Token = "0x60002D9")]
		internal add { } //Length: 184
		[Address(RVA = "0x2D7E480", Offset = "0x2D7D880", Length = "0xB8")]
		[CompilerGenerated]
		[Token(Token = "0x60002DA")]
		internal remove { } //Length: 184
	}

	[Token(Token = "0x170000C7")]
	internal DecalEntity decalEntity
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002E4")]
		internal get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002E5")]
		internal set { } //Length: 5
	}

	[Token(Token = "0x170000D6")]
	internal Vector3 decalOffset
	{
		[Address(RVA = "0x2D7DFA0", Offset = "0x2D7D3A0", Length = "0x20")]
		[Token(Token = "0x6000300")]
		internal get { } //Length: 32
	}

	[Token(Token = "0x170000D5")]
	internal Vector3 decalSize
	{
		[Address(RVA = "0x2D7DFC0", Offset = "0x2D7D3C0", Length = "0x15")]
		[Token(Token = "0x60002FF")]
		internal get { } //Length: 21
	}

	[Token(Token = "0x170000C5")]
	internal static Material defaultMaterial
	{
		[Address(RVA = "0x2D7DFE0", Offset = "0x2D7D3E0", Length = "0x37")]
		[CompilerGenerated]
		[Token(Token = "0x60002E1")]
		internal get { } //Length: 55
		[Address(RVA = "0x2D7E540", Offset = "0x2D7D940", Length = "0x56")]
		[CompilerGenerated]
		[Token(Token = "0x60002E2")]
		internal set { } //Length: 86
	}

	[Token(Token = "0x170000C9")]
	public float drawDistance
	{
		[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
		[Token(Token = "0x60002E8")]
		 get { } //Length: 6
		[Address(RVA = "0x2D7E5A0", Offset = "0x2D7D9A0", Length = "0x15")]
		[Token(Token = "0x60002E9")]
		 set { } //Length: 21
	}

	[Token(Token = "0x170000D4")]
	internal Vector3 effectiveScale
	{
		[Address(RVA = "0x2D7E020", Offset = "0x2D7D420", Length = "0x8F")]
		[Token(Token = "0x60002FE")]
		internal get { } //Length: 143
	}

	[Token(Token = "0x170000CC")]
	public float endAngleFade
	{
		[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
		[Token(Token = "0x60002EE")]
		 get { } //Length: 6
		[Address(RVA = "0x2D7E5C0", Offset = "0x2D7D9C0", Length = "0x26")]
		[Token(Token = "0x60002EF")]
		 set { } //Length: 38
	}

	[Token(Token = "0x170000D3")]
	public float fadeFactor
	{
		[Address(RVA = "0x2D7E0B0", Offset = "0x2D7D4B0", Length = "0x6")]
		[Token(Token = "0x60002FC")]
		 get { } //Length: 6
		[Address(RVA = "0x2D7E5F0", Offset = "0x2D7D9F0", Length = "0x33")]
		[Token(Token = "0x60002FD")]
		 set { } //Length: 51
	}

	[Token(Token = "0x170000CA")]
	public float fadeScale
	{
		[Address(RVA = "0x1BBC130", Offset = "0x1BBB530", Length = "0x6")]
		[Token(Token = "0x60002EA")]
		 get { } //Length: 6
		[Address(RVA = "0x2D7E630", Offset = "0x2D7DA30", Length = "0x33")]
		[Token(Token = "0x60002EB")]
		 set { } //Length: 51
	}

	[Token(Token = "0x170000C6")]
	internal static bool isSupported
	{
		[Address(RVA = "0x2D7E0C0", Offset = "0x2D7D4C0", Length = "0x3A")]
		[Token(Token = "0x60002E3")]
		internal get { } //Length: 58
	}

	[Token(Token = "0x170000C8")]
	public Material material
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60002E6")]
		 get { } //Length: 5
		[Address(RVA = "0x2D7E670", Offset = "0x2D7DA70", Length = "0x25")]
		[Token(Token = "0x60002E7")]
		 set { } //Length: 37
	}

	[Token(Token = "0x170000D1")]
	public Vector3 pivot
	{
		[Address(RVA = "0x21EA5E0", Offset = "0x21E99E0", Length = "0x13")]
		[Token(Token = "0x60002F8")]
		 get { } //Length: 19
		[Address(RVA = "0x2D7E6A0", Offset = "0x2D7DAA0", Length = "0x16")]
		[Token(Token = "0x60002F9")]
		 set { } //Length: 22
	}

	[Token(Token = "0x170000CF")]
	public RenderingLayerMask renderingLayerMask
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x60002F4")]
		 get { } //Length: 4
		[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
		[Token(Token = "0x60002F5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000D0")]
	public DecalScaleMode scaleMode
	{
		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[Token(Token = "0x60002F6")]
		 get { } //Length: 4
		[Address(RVA = "0x2D7E6C0", Offset = "0x2D7DAC0", Length = "0xA")]
		[Token(Token = "0x60002F7")]
		 set { } //Length: 10
	}

	[Token(Token = "0x170000D2")]
	public Vector3 size
	{
		[Address(RVA = "0x2D7E100", Offset = "0x2D7D500", Length = "0x13")]
		[Token(Token = "0x60002FA")]
		 get { } //Length: 19
		[Address(RVA = "0x2D7E6D0", Offset = "0x2D7DAD0", Length = "0x16")]
		[Token(Token = "0x60002FB")]
		 set { } //Length: 22
	}

	[Token(Token = "0x170000CB")]
	public float startAngleFade
	{
		[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
		[Token(Token = "0x60002EC")]
		 get { } //Length: 6
		[Address(RVA = "0x2D7E6F0", Offset = "0x2D7DAF0", Length = "0x33")]
		[Token(Token = "0x60002ED")]
		 set { } //Length: 51
	}

	[Token(Token = "0x170000CE")]
	public Vector2 uvBias
	{
		[Address(RVA = "0x2D7E120", Offset = "0x2D7D520", Length = "0x13")]
		[Token(Token = "0x60002F2")]
		 get { } //Length: 19
		[Address(RVA = "0x2D7E730", Offset = "0x2D7DB30", Length = "0xB")]
		[Token(Token = "0x60002F3")]
		 set { } //Length: 11
	}

	[Token(Token = "0x170000CD")]
	public Vector2 uvScale
	{
		[Address(RVA = "0x2D7E160", Offset = "0x2D7D560", Length = "0x13")]
		[Token(Token = "0x60002F0")]
		 get { } //Length: 19
		[Address(RVA = "0x2D7E740", Offset = "0x2D7DB40", Length = "0xB")]
		[Token(Token = "0x60002F1")]
		 set { } //Length: 11
	}

	[Token(Token = "0x170000D7")]
	internal Vector4 uvScaleBias
	{
		[Address(RVA = "0x2D7E140", Offset = "0x2D7D540", Length = "0x1B")]
		[Token(Token = "0x6000301")]
		internal get { } //Length: 27
	}

	[Address(RVA = "0x2D7DA50", Offset = "0x2D7CE50", Length = "0x18B")]
	[Token(Token = "0x600030B")]
	public DecalProjector() { }

	[Address(RVA = "0x2D7DBE0", Offset = "0x2D7CFE0", Length = "0xB8")]
	[CompilerGenerated]
	[Token(Token = "0x60002DD")]
	internal static void add_onAllDecalPropertyChange(Action value) { }

	[Address(RVA = "0x2D7DCA0", Offset = "0x2D7D0A0", Length = "0xB4")]
	[CompilerGenerated]
	[Token(Token = "0x60002D7")]
	internal static void add_onDecalAdd(DecalProjectorAction value) { }

	[Address(RVA = "0x2D7DD60", Offset = "0x2D7D160", Length = "0xB8")]
	[CompilerGenerated]
	[Token(Token = "0x60002DF")]
	internal static void add_onDecalMaterialChange(DecalProjectorAction value) { }

	[Address(RVA = "0x2D7DE20", Offset = "0x2D7D220", Length = "0xB8")]
	[CompilerGenerated]
	[Token(Token = "0x60002DB")]
	internal static void add_onDecalPropertyChange(DecalProjectorAction value) { }

	[Address(RVA = "0x2D7DEE0", Offset = "0x2D7D2E0", Length = "0xB8")]
	[CompilerGenerated]
	[Token(Token = "0x60002D9")]
	internal static void add_onDecalRemove(DecalProjectorAction value) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002E4")]
	internal DecalEntity get_decalEntity() { }

	[Address(RVA = "0x2D7DFA0", Offset = "0x2D7D3A0", Length = "0x20")]
	[Token(Token = "0x6000300")]
	internal Vector3 get_decalOffset() { }

	[Address(RVA = "0x2D7DFC0", Offset = "0x2D7D3C0", Length = "0x15")]
	[Token(Token = "0x60002FF")]
	internal Vector3 get_decalSize() { }

	[Address(RVA = "0x2D7DFE0", Offset = "0x2D7D3E0", Length = "0x37")]
	[CompilerGenerated]
	[Token(Token = "0x60002E1")]
	internal static Material get_defaultMaterial() { }

	[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
	[Token(Token = "0x60002E8")]
	public float get_drawDistance() { }

	[Address(RVA = "0x2D7E020", Offset = "0x2D7D420", Length = "0x8F")]
	[Token(Token = "0x60002FE")]
	internal Vector3 get_effectiveScale() { }

	[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
	[Token(Token = "0x60002EE")]
	public float get_endAngleFade() { }

	[Address(RVA = "0x2D7E0B0", Offset = "0x2D7D4B0", Length = "0x6")]
	[Token(Token = "0x60002FC")]
	public float get_fadeFactor() { }

	[Address(RVA = "0x1BBC130", Offset = "0x1BBB530", Length = "0x6")]
	[Token(Token = "0x60002EA")]
	public float get_fadeScale() { }

	[Address(RVA = "0x2D7E0C0", Offset = "0x2D7D4C0", Length = "0x3A")]
	[Token(Token = "0x60002E3")]
	internal static bool get_isSupported() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60002E6")]
	public Material get_material() { }

	[Address(RVA = "0x21EA5E0", Offset = "0x21E99E0", Length = "0x13")]
	[Token(Token = "0x60002F8")]
	public Vector3 get_pivot() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x60002F4")]
	public RenderingLayerMask get_renderingLayerMask() { }

	[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
	[Token(Token = "0x60002F6")]
	public DecalScaleMode get_scaleMode() { }

	[Address(RVA = "0x2D7E100", Offset = "0x2D7D500", Length = "0x13")]
	[Token(Token = "0x60002FA")]
	public Vector3 get_size() { }

	[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
	[Token(Token = "0x60002EC")]
	public float get_startAngleFade() { }

	[Address(RVA = "0x2D7E120", Offset = "0x2D7D520", Length = "0x13")]
	[Token(Token = "0x60002F2")]
	public Vector2 get_uvBias() { }

	[Address(RVA = "0x2D7E160", Offset = "0x2D7D560", Length = "0x13")]
	[Token(Token = "0x60002F0")]
	public Vector2 get_uvScale() { }

	[Address(RVA = "0x2D7E140", Offset = "0x2D7D540", Length = "0x1B")]
	[Token(Token = "0x6000301")]
	internal Vector4 get_uvScaleBias() { }

	[Address(RVA = "0x2D7D310", Offset = "0x2D7C710", Length = "0x50")]
	[Token(Token = "0x6000302")]
	private void InitMaterial() { }

	[Address(RVA = "0x2D7D360", Offset = "0x2D7C760", Length = "0x11E")]
	[Token(Token = "0x6000307")]
	public bool IsValid() { }

	[Address(RVA = "0x2D7D480", Offset = "0x2D7C880", Length = "0x246")]
	[Token(Token = "0x6000306")]
	private void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x2D7D6D0", Offset = "0x2D7CAD0", Length = "0x59")]
	[Token(Token = "0x6000304")]
	private void OnDisable() { }

	[Address(RVA = "0x2D7D730", Offset = "0x2D7CB30", Length = "0xAE")]
	[Token(Token = "0x6000303")]
	private void OnEnable() { }

	[Address(RVA = "0x2D7D7E0", Offset = "0x2D7CBE0", Length = "0x167")]
	[Token(Token = "0x6000305")]
	internal void OnValidate() { }

	[Address(RVA = "0x2D7E180", Offset = "0x2D7D580", Length = "0xB8")]
	[CompilerGenerated]
	[Token(Token = "0x60002DE")]
	internal static void remove_onAllDecalPropertyChange(Action value) { }

	[Address(RVA = "0x2D7E240", Offset = "0x2D7D640", Length = "0xB4")]
	[CompilerGenerated]
	[Token(Token = "0x60002D8")]
	internal static void remove_onDecalAdd(DecalProjectorAction value) { }

	[Address(RVA = "0x2D7E300", Offset = "0x2D7D700", Length = "0xB8")]
	[CompilerGenerated]
	[Token(Token = "0x60002E0")]
	internal static void remove_onDecalMaterialChange(DecalProjectorAction value) { }

	[Address(RVA = "0x2D7E3C0", Offset = "0x2D7D7C0", Length = "0xB8")]
	[CompilerGenerated]
	[Token(Token = "0x60002DC")]
	internal static void remove_onDecalPropertyChange(DecalProjectorAction value) { }

	[Address(RVA = "0x2D7E480", Offset = "0x2D7D880", Length = "0xB8")]
	[CompilerGenerated]
	[Token(Token = "0x60002DA")]
	internal static void remove_onDecalRemove(DecalProjectorAction value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002E5")]
	internal void set_decalEntity(DecalEntity value) { }

	[Address(RVA = "0x2D7E540", Offset = "0x2D7D940", Length = "0x56")]
	[CompilerGenerated]
	[Token(Token = "0x60002E2")]
	internal static void set_defaultMaterial(Material value) { }

	[Address(RVA = "0x2D7E5A0", Offset = "0x2D7D9A0", Length = "0x15")]
	[Token(Token = "0x60002E9")]
	public void set_drawDistance(float value) { }

	[Address(RVA = "0x2D7E5C0", Offset = "0x2D7D9C0", Length = "0x26")]
	[Token(Token = "0x60002EF")]
	public void set_endAngleFade(float value) { }

	[Address(RVA = "0x2D7E5F0", Offset = "0x2D7D9F0", Length = "0x33")]
	[Token(Token = "0x60002FD")]
	public void set_fadeFactor(float value) { }

	[Address(RVA = "0x2D7E630", Offset = "0x2D7DA30", Length = "0x33")]
	[Token(Token = "0x60002EB")]
	public void set_fadeScale(float value) { }

	[Address(RVA = "0x2D7E670", Offset = "0x2D7DA70", Length = "0x25")]
	[Token(Token = "0x60002E7")]
	public void set_material(Material value) { }

	[Address(RVA = "0x2D7E6A0", Offset = "0x2D7DAA0", Length = "0x16")]
	[Token(Token = "0x60002F9")]
	public void set_pivot(Vector3 value) { }

	[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
	[Token(Token = "0x60002F5")]
	public void set_renderingLayerMask(RenderingLayerMask value) { }

	[Address(RVA = "0x2D7E6C0", Offset = "0x2D7DAC0", Length = "0xA")]
	[Token(Token = "0x60002F7")]
	public void set_scaleMode(DecalScaleMode value) { }

	[Address(RVA = "0x2D7E6D0", Offset = "0x2D7DAD0", Length = "0x16")]
	[Token(Token = "0x60002FB")]
	public void set_size(Vector3 value) { }

	[Address(RVA = "0x2D7E6F0", Offset = "0x2D7DAF0", Length = "0x33")]
	[Token(Token = "0x60002ED")]
	public void set_startAngleFade(float value) { }

	[Address(RVA = "0x2D7E730", Offset = "0x2D7DB30", Length = "0xB")]
	[Token(Token = "0x60002F3")]
	public void set_uvBias(Vector2 value) { }

	[Address(RVA = "0x2D7E740", Offset = "0x2D7DB40", Length = "0xB")]
	[Token(Token = "0x60002F1")]
	public void set_uvScale(Vector2 value) { }

	[Address(RVA = "0x2D7D950", Offset = "0x2D7CD50", Length = "0x82")]
	[Token(Token = "0x600030A")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x2D7D9E0", Offset = "0x2D7CDE0", Length = "0x14")]
	[Token(Token = "0x6000309")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	[Address(RVA = "0x2D7DA00", Offset = "0x2D7CE00", Length = "0x4F")]
	[Token(Token = "0x6000308")]
	internal static void UpdateAllDecalProperties() { }

}

