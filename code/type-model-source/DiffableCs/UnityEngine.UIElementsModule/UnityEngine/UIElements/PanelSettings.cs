namespace UnityEngine.UIElements;

[HelpURL("UIE-Runtime-Panel-Settings")]
[Token(Token = "0x2000278")]
public class PanelSettings : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x200027A")]
	private sealed class <>c__DisplayClass146_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009E1")]
		public Func<Vector2, Vector2> screenToPanelSpaceFunction; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001179")]
		public <>c__DisplayClass146_0() { }

		[Address(RVA = "0x33F4480", Offset = "0x33F3880", Length = "0x58")]
		[Token(Token = "0x600117A")]
		internal Vector3 <SetScreenToPanelSpaceFunction>b__0(Vector2 p) { }

	}

	[Token(Token = "0x2000279")]
	private class RuntimePanelAccess
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009DE")]
		private readonly PanelSettings m_Settings; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009DF")]
		private BaseRuntimePanel m_RuntimePanel; //Field offset: 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40009E0")]
		private bool <isTransient>k__BackingField; //Field offset: 0x20

		[Token(Token = "0x1700035C")]
		internal bool isInitialized
		{
			[Address(RVA = "0x20B1050", Offset = "0x20B0450", Length = "0x9")]
			[Token(Token = "0x600116D")]
			internal get { } //Length: 9
		}

		[Token(Token = "0x1700035D")]
		internal bool isTransient
		{
			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600116E")]
			internal get { } //Length: 5
			[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x600116F")]
			internal set { } //Length: 4
		}

		[Token(Token = "0x1700035E")]
		internal BaseRuntimePanel panel
		{
			[Address(RVA = "0x33F2520", Offset = "0x33F1920", Length = "0x349")]
			[Token(Token = "0x6001170")]
			internal get { } //Length: 841
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600116C")]
		internal RuntimePanelAccess(PanelSettings settings) { }

		[Address(RVA = "0x33F2230", Offset = "0x33F1630", Length = "0xDE")]
		[Token(Token = "0x6001176")]
		private BaseRuntimePanel CreateRelatedRuntimePanel() { }

		[Address(RVA = "0x33F2310", Offset = "0x33F1710", Length = "0x72")]
		[Token(Token = "0x6001171")]
		internal void DisposePanel() { }

		[Address(RVA = "0x33F2390", Offset = "0x33F1790", Length = "0x4D")]
		[Token(Token = "0x6001177")]
		private void DisposeRelatedPanel() { }

		[Address(RVA = "0x20B1050", Offset = "0x20B0450", Length = "0x9")]
		[Token(Token = "0x600116D")]
		internal bool get_isInitialized() { }

		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600116E")]
		internal bool get_isTransient() { }

		[Address(RVA = "0x33F2520", Offset = "0x33F1920", Length = "0x349")]
		[Token(Token = "0x6001170")]
		internal BaseRuntimePanel get_panel() { }

		[Address(RVA = "0x33F23E0", Offset = "0x33F17E0", Length = "0x4D")]
		[Token(Token = "0x6001178")]
		internal void MarkPotentiallyEmpty() { }

		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600116F")]
		internal void set_isTransient(bool value) { }

		[Address(RVA = "0x33F2430", Offset = "0x33F1830", Length = "0x35")]
		[Token(Token = "0x6001175")]
		internal void SetPanelChangeReceiver() { }

		[Address(RVA = "0x33F2470", Offset = "0x33F1870", Length = "0x33")]
		[Token(Token = "0x6001173")]
		internal void SetSortingPriority() { }

		[Address(RVA = "0x33F24B0", Offset = "0x33F18B0", Length = "0x2B")]
		[Token(Token = "0x6001174")]
		internal void SetTargetDisplay() { }

		[Address(RVA = "0x33F24E0", Offset = "0x33F18E0", Length = "0x3D")]
		[Token(Token = "0x6001172")]
		internal void SetTargetTexture() { }

	}

	[Token(Token = "0x40009B0")]
	private const int k_DefaultSortingOrder = 0; //Field offset: 0x0
	[Token(Token = "0x40009B1")]
	private const float k_DefaultScaleValue = 1; //Field offset: 0x0
	[Token(Token = "0x40009B2")]
	internal const string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset"; //Field offset: 0x0
	[Token(Token = "0x40009BD")]
	private const float DefaultDpi = 96; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40009B3")]
	private ThemeStyleSheet themeUss; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40009B4")]
	private bool m_DisableNoThemeWarning; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40009B5")]
	private RenderTexture m_TargetTexture; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40009B6")]
	private PanelRenderMode m_RenderMode; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("m_WorldInputMode")]
	[SerializeField]
	[Token(Token = "0x40009B7")]
	private ColliderUpdateMode m_ColliderUpdateMode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40009B8")]
	private bool m_ColliderIsTrigger; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40009B9")]
	private PanelScaleMode m_ScaleMode; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40009BA")]
	private float m_ReferenceSpritePixelsPerUnit; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x40009BB")]
	private float m_PixelsPerUnit; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40009BC")]
	private float m_Scale; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40009BE")]
	private float m_ReferenceDpi; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40009BF")]
	private float m_FallbackDpi; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x40009C0")]
	private Vector2Int m_ReferenceResolution; //Field offset: 0x54
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x40009C1")]
	private PanelScreenMatchMode m_ScreenMatchMode; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40009C2")]
	private float m_Match; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x40009C3")]
	private float m_SortingOrder; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40009C4")]
	private int m_TargetDisplay; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x40009C5")]
	private BindingLogLevel m_BindingLogLevel; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40009C6")]
	private bool m_ClearDepthStencil; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[SerializeField]
	[Token(Token = "0x40009C7")]
	private bool m_ClearColor; //Field offset: 0x71
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x40009C8")]
	private Color m_ColorClearValue; //Field offset: 0x74
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[Token(Token = "0x40009C9")]
	private uint m_VertexBudget; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x40009CA")]
	private TextureSlotCount m_TextureSlotCount; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40009CB")]
	private RuntimePanelAccess m_PanelAccess; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40009CC")]
	internal UIDocumentList m_AttachedUIDocumentsList; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40009CD")]
	private DynamicAtlasSettings m_DynamicAtlasSettings; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40009CE")]
	private Shader m_AtlasBlitShader; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40009CF")]
	private Shader m_DefaultShader; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40009D0")]
	private Shader m_RuntimeGaussianBlurShader; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40009D1")]
	private Shader m_RuntimeColorEffectShader; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40009D2")]
	private Shader m_SDFShader; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40009D3")]
	private Shader m_BitmapShader; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40009D4")]
	private Shader m_SpriteShader; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40009D5")]
	internal TextAsset m_ICUDataAsset; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x40009D6")]
	public bool forceGammaRendering; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x40009D7")]
	public PanelTextSettings textSettings; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40009D8")]
	private Rect m_TargetRect; //Field offset: 0xF8
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40009D9")]
	private float m_ResolvedScale; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40009DA")]
	private StyleSheet m_OldThemeUss; //Field offset: 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40009DB")]
	private float <ScreenDPI>k__BackingField; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40009DC")]
	private IDebugPanelChangeReceiver m_PanelChangeReceiver; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40009DD")]
	private Func<Vector2, Vector3> m_AssignedScreenToPanel; //Field offset: 0x128

	[Token(Token = "0x1700034F")]
	public BindingLogLevel bindingLogLevel
	{
		[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
		[Token(Token = "0x6001144")]
		 get { } //Length: 4
		[Address(RVA = "0x33F1AE0", Offset = "0x33F0EE0", Length = "0x40")]
		[Token(Token = "0x6001145")]
		 set { } //Length: 64
	}

	[Token(Token = "0x17000352")]
	public bool clearColor
	{
		[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
		[Token(Token = "0x6001149")]
		 get { } //Length: 5
		[Address(RVA = "0x20D3FE0", Offset = "0x20D33E0", Length = "0x4")]
		[Token(Token = "0x600114A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000350")]
	public bool clearDepthStencil
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[Token(Token = "0x6001146")]
		 get { } //Length: 5
		[Address(RVA = "0xD89260", Offset = "0xD88660", Length = "0x4")]
		[Token(Token = "0x6001147")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000343")]
	internal bool colliderIsTrigger
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x600112B")]
		internal get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[Token(Token = "0x600112C")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000342")]
	internal ColliderUpdateMode colliderUpdateMode
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6001129")]
		internal get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[Token(Token = "0x600112A")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000353")]
	public Color colorClearValue
	{
		[Address(RVA = "0x33F1A10", Offset = "0x33F0E10", Length = "0xB")]
		[Token(Token = "0x600114B")]
		 get { } //Length: 11
		[Address(RVA = "0x33F1B30", Offset = "0x33F0F30", Length = "0x8")]
		[Token(Token = "0x600114C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000351")]
	public float depthClearValue
	{
		[Address(RVA = "0x33F1A20", Offset = "0x33F0E20", Length = "0x9")]
		[Token(Token = "0x6001148")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700033F")]
	internal bool disableNoThemeWarning
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6001123")]
		internal get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x6001124")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700035A")]
	public DynamicAtlasSettings dynamicAtlasSettings
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x6001156")]
		 get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[Token(Token = "0x6001157")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000349")]
	public float fallbackDpi
	{
		[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
		[Token(Token = "0x6001137")]
		 get { } //Length: 6
		[Address(RVA = "0x33F1B40", Offset = "0x33F0F40", Length = "0x29")]
		[Token(Token = "0x6001138")]
		 set { } //Length: 41
	}

	[Token(Token = "0x17000357")]
	internal bool isInitialized
	{
		[Address(RVA = "0x33F1A30", Offset = "0x33F0E30", Length = "0x16")]
		[Token(Token = "0x6001152")]
		internal get { } //Length: 22
	}

	[Token(Token = "0x17000358")]
	internal bool isTransient
	{
		[Address(RVA = "0x33F1A50", Offset = "0x33F0E50", Length = "0x1E")]
		[Token(Token = "0x6001153")]
		internal get { } //Length: 30
		[Address(RVA = "0x33F1B70", Offset = "0x33F0F70", Length = "0x1D")]
		[Token(Token = "0x6001154")]
		internal set { } //Length: 29
	}

	[Token(Token = "0x1700034C")]
	public float match
	{
		[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
		[Token(Token = "0x600113D")]
		 get { } //Length: 6
		[Address(RVA = "0x1CC5D40", Offset = "0x1CC5140", Length = "0x6")]
		[Token(Token = "0x600113E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000356")]
	internal BaseRuntimePanel panel
	{
		[Address(RVA = "0x33F1A70", Offset = "0x33F0E70", Length = "0x20")]
		[Token(Token = "0x6001151")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.VectorGraphicsModule"})]
		internal get { } //Length: 32
	}

	[Token(Token = "0x17000346")]
	internal float pixelsPerUnit
	{
		[Address(RVA = "0x316C300", Offset = "0x316B700", Length = "0x8")]
		[Token(Token = "0x6001131")]
		internal get { } //Length: 8
		[Address(RVA = "0x1E08FF0", Offset = "0x1E083F0", Length = "0x6")]
		[Token(Token = "0x6001132")]
		internal set { } //Length: 6
	}

	[Token(Token = "0x17000348")]
	public float referenceDpi
	{
		[Address(RVA = "0x21F3FC0", Offset = "0x21F33C0", Length = "0x6")]
		[Token(Token = "0x6001135")]
		 get { } //Length: 6
		[Address(RVA = "0x33F1B90", Offset = "0x33F0F90", Length = "0x29")]
		[Token(Token = "0x6001136")]
		 set { } //Length: 41
	}

	[Token(Token = "0x1700034A")]
	public Vector2Int referenceResolution
	{
		[Address(RVA = "0x337B8A0", Offset = "0x337ACA0", Length = "0x5")]
		[Token(Token = "0x6001139")]
		 get { } //Length: 5
		[Address(RVA = "0x33F1BC0", Offset = "0x33F0FC0", Length = "0x5")]
		[Token(Token = "0x600113A")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000345")]
	public float referenceSpritePixelsPerUnit
	{
		[Address(RVA = "0x31132B0", Offset = "0x31126B0", Length = "0x8")]
		[Token(Token = "0x600112F")]
		 get { } //Length: 8
		[Address(RVA = "0x11169A0", Offset = "0x1115DA0", Length = "0x6")]
		[Token(Token = "0x6001130")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000341")]
	internal PanelRenderMode renderMode
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6001127")]
		internal get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x6001128")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000347")]
	public float scale
	{
		[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
		[Token(Token = "0x6001133")]
		 get { } //Length: 6
		[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
		[Token(Token = "0x6001134")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000344")]
	public PanelScaleMode scaleMode
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x600112D")]
		 get { } //Length: 4
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[Token(Token = "0x600112E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700035B")]
	private float ScreenDPI
	{
		[Address(RVA = "0x2D25F20", Offset = "0x2D25320", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x600115D")]
		private get { } //Length: 9
		[Address(RVA = "0x2D26190", Offset = "0x2D25590", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x600115E")]
		private set { } //Length: 9
	}

	[Token(Token = "0x1700034B")]
	public PanelScreenMatchMode screenMatchMode
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[Token(Token = "0x600113B")]
		 get { } //Length: 4
		[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
		[Token(Token = "0x600113C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700034D")]
	public float sortingOrder
	{
		[Address(RVA = "0x121E450", Offset = "0x121D850", Length = "0x6")]
		[Token(Token = "0x600113F")]
		 get { } //Length: 6
		[Address(RVA = "0x33F1BD0", Offset = "0x33F0FD0", Length = "0x44")]
		[Token(Token = "0x6001140")]
		 set { } //Length: 68
	}

	[Token(Token = "0x1700034E")]
	public int targetDisplay
	{
		[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
		[Token(Token = "0x6001142")]
		 get { } //Length: 4
		[Address(RVA = "0x33F1C20", Offset = "0x33F1020", Length = "0x3A")]
		[Token(Token = "0x6001143")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000340")]
	public RenderTexture targetTexture
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001125")]
		 get { } //Length: 5
		[Address(RVA = "0x33F1C60", Offset = "0x33F1060", Length = "0x5D")]
		[Token(Token = "0x6001126")]
		 set { } //Length: 93
	}

	[Token(Token = "0x17000355")]
	public TextureSlotCount textureSlotCount
	{
		[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
		[Token(Token = "0x600114F")]
		 get { } //Length: 7
		[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
		[Token(Token = "0x6001150")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700033E")]
	public ThemeStyleSheet themeStyleSheet
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x6001121")]
		 get { } //Length: 7
		[Address(RVA = "0x33F1CC0", Offset = "0x33F10C0", Length = "0x28")]
		[Token(Token = "0x6001122")]
		 set { } //Length: 40
	}

	[Token(Token = "0x17000354")]
	public uint vertexBudget
	{
		[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
		[Token(Token = "0x600114D")]
		 get { } //Length: 7
		[Address(RVA = "0xD11B10", Offset = "0xD10F10", Length = "0x7")]
		[Token(Token = "0x600114E")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000359")]
	internal VisualElement visualTree
	{
		[Address(RVA = "0x33F1AA0", Offset = "0x33F0EA0", Length = "0x3C")]
		[Token(Token = "0x6001155")]
		internal get { } //Length: 60
	}

	[Address(RVA = "0x33F1870", Offset = "0x33F0C70", Length = "0x196")]
	[Token(Token = "0x6001158")]
	private PanelSettings() { }

	[Address(RVA = "0x33EFED0", Offset = "0x33EF2D0", Length = "0xC04")]
	[Token(Token = "0x6001165")]
	internal void ApplyPanelSettings() { }

	[Address(RVA = "0x33F0AE0", Offset = "0x33EFEE0", Length = "0x3F")]
	[Token(Token = "0x6001141")]
	internal void ApplySortingOrder() { }

	[Address(RVA = "0x33F0B20", Offset = "0x33EFF20", Length = "0x21E")]
	[Token(Token = "0x6001162")]
	private void ApplyThemeStyleSheet(VisualElement root = null) { }

	[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
	[Token(Token = "0x6001163")]
	internal bool AssignICUData() { }

	[Address(RVA = "0x33F0D40", Offset = "0x33F0140", Length = "0x130")]
	[Token(Token = "0x600116A")]
	internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument) { }

	[Address(RVA = "0x33F0E80", Offset = "0x33F0280", Length = "0x112")]
	[Token(Token = "0x600116B")]
	internal void DetachUIDocument(UIDocument uiDocument) { }

	[Address(RVA = "0x33F0FA0", Offset = "0x33F03A0", Length = "0x20")]
	[Token(Token = "0x600115C")]
	internal void DisposePanel() { }

	[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
	[Token(Token = "0x6001144")]
	public BindingLogLevel get_bindingLogLevel() { }

	[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
	[Token(Token = "0x6001149")]
	public bool get_clearColor() { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x6001146")]
	public bool get_clearDepthStencil() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x600112B")]
	internal bool get_colliderIsTrigger() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6001129")]
	internal ColliderUpdateMode get_colliderUpdateMode() { }

	[Address(RVA = "0x33F1A10", Offset = "0x33F0E10", Length = "0xB")]
	[Token(Token = "0x600114B")]
	public Color get_colorClearValue() { }

	[Address(RVA = "0x33F1A20", Offset = "0x33F0E20", Length = "0x9")]
	[Token(Token = "0x6001148")]
	public float get_depthClearValue() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6001123")]
	internal bool get_disableNoThemeWarning() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x6001156")]
	public DynamicAtlasSettings get_dynamicAtlasSettings() { }

	[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
	[Token(Token = "0x6001137")]
	public float get_fallbackDpi() { }

	[Address(RVA = "0x33F1A30", Offset = "0x33F0E30", Length = "0x16")]
	[Token(Token = "0x6001152")]
	internal bool get_isInitialized() { }

	[Address(RVA = "0x33F1A50", Offset = "0x33F0E50", Length = "0x1E")]
	[Token(Token = "0x6001153")]
	internal bool get_isTransient() { }

	[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
	[Token(Token = "0x600113D")]
	public float get_match() { }

	[Address(RVA = "0x33F1A70", Offset = "0x33F0E70", Length = "0x20")]
	[Token(Token = "0x6001151")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.VectorGraphicsModule"})]
	internal BaseRuntimePanel get_panel() { }

	[Address(RVA = "0x316C300", Offset = "0x316B700", Length = "0x8")]
	[Token(Token = "0x6001131")]
	internal float get_pixelsPerUnit() { }

	[Address(RVA = "0x21F3FC0", Offset = "0x21F33C0", Length = "0x6")]
	[Token(Token = "0x6001135")]
	public float get_referenceDpi() { }

	[Address(RVA = "0x337B8A0", Offset = "0x337ACA0", Length = "0x5")]
	[Token(Token = "0x6001139")]
	public Vector2Int get_referenceResolution() { }

	[Address(RVA = "0x31132B0", Offset = "0x31126B0", Length = "0x8")]
	[Token(Token = "0x600112F")]
	public float get_referenceSpritePixelsPerUnit() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6001127")]
	internal PanelRenderMode get_renderMode() { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[Token(Token = "0x6001133")]
	public float get_scale() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x600112D")]
	public PanelScaleMode get_scaleMode() { }

	[Address(RVA = "0x2D25F20", Offset = "0x2D25320", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x600115D")]
	private float get_ScreenDPI() { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[Token(Token = "0x600113B")]
	public PanelScreenMatchMode get_screenMatchMode() { }

	[Address(RVA = "0x121E450", Offset = "0x121D850", Length = "0x6")]
	[Token(Token = "0x600113F")]
	public float get_sortingOrder() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[Token(Token = "0x6001142")]
	public int get_targetDisplay() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001125")]
	public RenderTexture get_targetTexture() { }

	[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
	[Token(Token = "0x600114F")]
	public TextureSlotCount get_textureSlotCount() { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x6001121")]
	public ThemeStyleSheet get_themeStyleSheet() { }

	[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
	[Token(Token = "0x600114D")]
	public uint get_vertexBudget() { }

	[Address(RVA = "0x33F1AA0", Offset = "0x33F0EA0", Length = "0x3C")]
	[Token(Token = "0x6001155")]
	internal VisualElement get_visualTree() { }

	[Address(RVA = "0x33F0FD0", Offset = "0x33F03D0", Length = "0x137")]
	[Token(Token = "0x6001169")]
	internal Rect GetDisplayRect() { }

	[Address(RVA = "0x33F1110", Offset = "0x33F0510", Length = "0xA")]
	[Token(Token = "0x6001160")]
	internal IDebugPanelChangeReceiver GetPanelChangeReceiver() { }

	[Address(RVA = "0x33F1120", Offset = "0x33F0520", Length = "0x3A7")]
	[Token(Token = "0x6001164")]
	private void InitializeShaders() { }

	[Address(RVA = "0x33F0FA0", Offset = "0x33F03A0", Length = "0x20")]
	[Token(Token = "0x600115B")]
	private void OnDisable() { }

	[Address(RVA = "0x33F14D0", Offset = "0x33F08D0", Length = "0x28")]
	[Token(Token = "0x600115A")]
	private void OnEnable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001159")]
	private void Reset() { }

	[Address(RVA = "0x33F1500", Offset = "0x33F0900", Length = "0x189")]
	[Token(Token = "0x6001168")]
	internal float ResolveScale(Rect targetRect, float screenDpi) { }

	[Address(RVA = "0x33F1AE0", Offset = "0x33F0EE0", Length = "0x40")]
	[Token(Token = "0x6001145")]
	public void set_bindingLogLevel(BindingLogLevel value) { }

	[Address(RVA = "0x20D3FE0", Offset = "0x20D33E0", Length = "0x4")]
	[Token(Token = "0x600114A")]
	public void set_clearColor(bool value) { }

	[Address(RVA = "0xD89260", Offset = "0xD88660", Length = "0x4")]
	[Token(Token = "0x6001147")]
	public void set_clearDepthStencil(bool value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[Token(Token = "0x600112C")]
	internal void set_colliderIsTrigger(bool value) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[Token(Token = "0x600112A")]
	internal void set_colliderUpdateMode(ColliderUpdateMode value) { }

	[Address(RVA = "0x33F1B30", Offset = "0x33F0F30", Length = "0x8")]
	[Token(Token = "0x600114C")]
	public void set_colorClearValue(Color value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x6001124")]
	internal void set_disableNoThemeWarning(bool value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[Token(Token = "0x6001157")]
	public void set_dynamicAtlasSettings(DynamicAtlasSettings value) { }

	[Address(RVA = "0x33F1B40", Offset = "0x33F0F40", Length = "0x29")]
	[Token(Token = "0x6001138")]
	public void set_fallbackDpi(float value) { }

	[Address(RVA = "0x33F1B70", Offset = "0x33F0F70", Length = "0x1D")]
	[Token(Token = "0x6001154")]
	internal void set_isTransient(bool value) { }

	[Address(RVA = "0x1CC5D40", Offset = "0x1CC5140", Length = "0x6")]
	[Token(Token = "0x600113E")]
	public void set_match(float value) { }

	[Address(RVA = "0x1E08FF0", Offset = "0x1E083F0", Length = "0x6")]
	[Token(Token = "0x6001132")]
	internal void set_pixelsPerUnit(float value) { }

	[Address(RVA = "0x33F1B90", Offset = "0x33F0F90", Length = "0x29")]
	[Token(Token = "0x6001136")]
	public void set_referenceDpi(float value) { }

	[Address(RVA = "0x33F1BC0", Offset = "0x33F0FC0", Length = "0x5")]
	[Token(Token = "0x600113A")]
	public void set_referenceResolution(Vector2Int value) { }

	[Address(RVA = "0x11169A0", Offset = "0x1115DA0", Length = "0x6")]
	[Token(Token = "0x6001130")]
	public void set_referenceSpritePixelsPerUnit(float value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x6001128")]
	internal void set_renderMode(PanelRenderMode value) { }

	[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
	[Token(Token = "0x6001134")]
	public void set_scale(float value) { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[Token(Token = "0x600112E")]
	public void set_scaleMode(PanelScaleMode value) { }

	[Address(RVA = "0x2D26190", Offset = "0x2D25590", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x600115E")]
	private void set_ScreenDPI(float value) { }

	[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
	[Token(Token = "0x600113C")]
	public void set_screenMatchMode(PanelScreenMatchMode value) { }

	[Address(RVA = "0x33F1BD0", Offset = "0x33F0FD0", Length = "0x44")]
	[Token(Token = "0x6001140")]
	public void set_sortingOrder(float value) { }

	[Address(RVA = "0x33F1C20", Offset = "0x33F1020", Length = "0x3A")]
	[Token(Token = "0x6001143")]
	public void set_targetDisplay(int value) { }

	[Address(RVA = "0x33F1C60", Offset = "0x33F1060", Length = "0x5D")]
	[Token(Token = "0x6001126")]
	public void set_targetTexture(RenderTexture value) { }

	[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
	[Token(Token = "0x6001150")]
	public void set_textureSlotCount(TextureSlotCount value) { }

	[Address(RVA = "0x33F1CC0", Offset = "0x33F10C0", Length = "0x28")]
	[Token(Token = "0x6001122")]
	public void set_themeStyleSheet(ThemeStyleSheet value) { }

	[Address(RVA = "0xD11B10", Offset = "0xD10F10", Length = "0x7")]
	[Token(Token = "0x600114E")]
	public void set_vertexBudget(uint value) { }

	[Address(RVA = "0x33F1690", Offset = "0x33F0A90", Length = "0x5B")]
	[Conditional("ENABLE_PROFILER")]
	[Token(Token = "0x600115F")]
	public void SetPanelChangeReceiver(IDebugPanelChangeReceiver value) { }

	[Address(RVA = "0x33F1750", Offset = "0x33F0B50", Length = "0xF3")]
	[Token(Token = "0x6001167")]
	public void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screenToPanelSpaceFunction) { }

	[Address(RVA = "0x33F16F0", Offset = "0x33F0AF0", Length = "0x50")]
	[Token(Token = "0x6001166")]
	public void SetScreenToPanelSpaceFunction3D(Func<Vector2, Vector3> screenToPanelSpaceFunction) { }

	[Address(RVA = "0x33F1850", Offset = "0x33F0C50", Length = "0x1E")]
	[Token(Token = "0x6001161")]
	internal void UpdateScreenDPI() { }

}

