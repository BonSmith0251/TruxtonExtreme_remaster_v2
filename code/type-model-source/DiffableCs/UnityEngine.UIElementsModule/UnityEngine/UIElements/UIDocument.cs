namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/UI Document")]
[DefaultExecutionOrder(-100)]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("UIE-get-started-with-runtime-ui")]
[Token(Token = "0x2000288")]
public sealed class UIDocument : MonoBehaviour
{
	[Token(Token = "0x2000289")]
	internal enum WorldSpaceSizeMode : int
	{
		Dynamic = 0,
		Fixed = 1,
	}

	[Token(Token = "0x4000A05")]
	internal const string k_RootStyleClassName = "unity-ui-document__root"; //Field offset: 0x0
	[Token(Token = "0x4000A06")]
	internal const string k_VisualElementNameSuffix = "-container"; //Field offset: 0x0
	[Token(Token = "0x4000A07")]
	internal const string k_EditorElementsWarningMessage = "The VisualTreeAsset contains editor-only elements that are incompatible at runtime.
To fix this, remove the editor elements from the VisualTreeAsset."; //Field offset: 0x0
	[Token(Token = "0x4000A08")]
	private const int k_DefaultSortingOrder = 0; //Field offset: 0x0
	[Token(Token = "0x4000A09")]
	private static int s_CurrentUIDocumentCounter; //Field offset: 0x0
	[Token(Token = "0x4000A0B")]
	internal static int EnabledDocumentCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A0A")]
	internal readonly int m_UIDocumentCreationIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000A0C")]
	private PanelSettings m_PanelSettings; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A0D")]
	private PanelSettings m_PreviousPanelSettings; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000A0E")]
	private UIDocument m_ParentUI; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A0F")]
	private UIDocumentList m_ChildrenContent; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A10")]
	private List<UIDocument> m_ChildrenContentCopy; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000A11")]
	private VisualTreeAsset sourceAsset; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A12")]
	private UIDocumentRootElement m_RootVisualElement; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A13")]
	private VisualElementFocusRing <focusRing>k__BackingField; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A14")]
	internal int softPointerCaptures; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000A15")]
	private int m_FirstChildInsertIndex; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000A16")]
	private float m_SortingOrder; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x4000A17")]
	private Position m_Position; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000A18")]
	private WorldSpaceSizeMode m_WorldSpaceSizeMode; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x4000A19")]
	private float m_WorldSpaceWidth; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000A1A")]
	private float m_WorldSpaceHeight; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[Token(Token = "0x4000A1B")]
	private PivotReferenceSize m_PivotReferenceSize; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000A1C")]
	private Pivot m_Pivot; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000A1D")]
	private BoxCollider m_WorldSpaceCollider; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A1E")]
	private bool m_RootHasWorldTransform; //Field offset: 0x98

	[Token(Token = "0x17000372")]
	internal RuntimePanel containerPanel
	{
		[Address(RVA = "0x33F8CC0", Offset = "0x33F80C0", Length = "0x7B")]
		[Token(Token = "0x60011C1")]
		internal get { } //Length: 123
	}

	[Token(Token = "0x17000368")]
	internal int firstChildInserIndex
	{
		[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
		[Token(Token = "0x60011AB")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000367")]
	internal VisualElementFocusRing focusRing
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60011A9")]
		internal get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[CompilerGenerated]
		[Token(Token = "0x60011AA")]
		private set { } //Length: 995
	}

	[Token(Token = "0x1700036D")]
	internal bool isTransformControlledByGameObject
	{
		[Address(RVA = "0x33F8D40", Offset = "0x33F8140", Length = "0x87")]
		[Token(Token = "0x60011B3")]
		internal get { } //Length: 135
	}

	[Token(Token = "0x1700036C")]
	private bool isWorldSpace
	{
		[Address(RVA = "0x33F8DD0", Offset = "0x33F81D0", Length = "0x80")]
		[Token(Token = "0x60011B2")]
		private get { } //Length: 128
	}

	[Token(Token = "0x17000363")]
	public PanelSettings panelSettings
	{
		[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
		[Token(Token = "0x60011A1")]
		 get { } //Length: 7
		[Address(RVA = "0x33F8EF0", Offset = "0x33F82F0", Length = "0x2CC")]
		[Token(Token = "0x60011A2")]
		 set { } //Length: 716
	}

	[Token(Token = "0x17000364")]
	public private UIDocument parentUI
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60011A3")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x60011A4")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700036F")]
	public Pivot pivot
	{
		[Address(RVA = "0x33F8E70", Offset = "0x33F8270", Length = "0x9")]
		[Token(Token = "0x60011B6")]
		 get { } //Length: 9
		[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
		[Token(Token = "0x60011B7")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700036E")]
	public PivotReferenceSize pivotReferenceSize
	{
		[Address(RVA = "0x33F8E60", Offset = "0x33F8260", Length = "0x9")]
		[Token(Token = "0x60011B4")]
		 get { } //Length: 9
		[Address(RVA = "0xD11B10", Offset = "0xD10F10", Length = "0x7")]
		[Token(Token = "0x60011B5")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000373")]
	private float pixelsPerUnit
	{
		[Address(RVA = "0x33F8E80", Offset = "0x33F8280", Length = "0x2B")]
		[Token(Token = "0x60011CD")]
		private get { } //Length: 43
	}

	[Token(Token = "0x17000369")]
	public Position position
	{
		[Address(RVA = "0x33F8EB0", Offset = "0x33F82B0", Length = "0x6")]
		[Token(Token = "0x60011AC")]
		 get { } //Length: 6
		[Address(RVA = "0x33F91C0", Offset = "0x33F85C0", Length = "0x10")]
		[Token(Token = "0x60011AD")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000366")]
	public private VisualElement rootVisualElement
	{
		[Address(RVA = "0x2F944E0", Offset = "0x2F938E0", Length = "0x7")]
		[Token(Token = "0x60011A7")]
		 get { } //Length: 7
		[Address(RVA = "0x33F91D0", Offset = "0x33F85D0", Length = "0x112")]
		[Token(Token = "0x60011A8")]
		private set { } //Length: 274
	}

	[Token(Token = "0x17000371")]
	public IRuntimePanel runtimePanel
	{
		[Address(RVA = "0x33F8EC0", Offset = "0x33F82C0", Length = "0x7")]
		[Token(Token = "0x60011C0")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000370")]
	public float sortingOrder
	{
		[Address(RVA = "0x2D7E0B0", Offset = "0x2D7D4B0", Length = "0x6")]
		[Token(Token = "0x60011B8")]
		 get { } //Length: 6
		[Address(RVA = "0x33F92F0", Offset = "0x33F86F0", Length = "0x19")]
		[Token(Token = "0x60011B9")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000365")]
	public VisualTreeAsset visualTreeAsset
	{
		[Address(RVA = "0x2F944F0", Offset = "0x2F938F0", Length = "0x7")]
		[Token(Token = "0x60011A5")]
		 get { } //Length: 7
		[Address(RVA = "0x33F9310", Offset = "0x33F8710", Length = "0x25")]
		[Token(Token = "0x60011A6")]
		 set { } //Length: 37
	}

	[Token(Token = "0x1700036B")]
	public Vector2 worldSpaceSize
	{
		[Address(RVA = "0x33F8ED0", Offset = "0x33F82D0", Length = "0x16")]
		[Token(Token = "0x60011B0")]
		 get { } //Length: 22
		[Address(RVA = "0x33F9350", Offset = "0x33F8750", Length = "0xA05")]
		[Token(Token = "0x60011B1")]
		 set { } //Length: 2565
	}

	[Token(Token = "0x1700036A")]
	public WorldSpaceSizeMode worldSpaceSizeMode
	{
		[Address(RVA = "0x30D0FD0", Offset = "0x30D03D0", Length = "0x6")]
		[Token(Token = "0x60011AE")]
		 get { } //Length: 6
		[Address(RVA = "0x33F9340", Offset = "0x33F8740", Length = "0x10")]
		[Token(Token = "0x60011AF")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x33F8B00", Offset = "0x33F7F00", Length = "0xFF")]
	[Token(Token = "0x60011BF")]
	private void _Enable() { }

	[Address(RVA = "0x33F8C00", Offset = "0x33F8000", Length = "0xB6")]
	[Token(Token = "0x60011BC")]
	private UIDocument() { }

	[Address(RVA = "0x33F4C90", Offset = "0x33F4090", Length = "0xFB")]
	[Token(Token = "0x60011D7")]
	internal void AddChildAndInsertContentToVisualTree(UIDocument child) { }

	[Address(RVA = "0x33F4D90", Offset = "0x33F4190", Length = "0xFC")]
	[Token(Token = "0x60011C6")]
	private void AddOrRemoveRendererComponent() { }

	[Address(RVA = "0x33F4E90", Offset = "0x33F4290", Length = "0xCE")]
	[Token(Token = "0x60011DD")]
	private void AddRootVisualElementToTree() { }

	[Address(RVA = "0x33F4F60", Offset = "0x33F4360", Length = "0x7")]
	[Token(Token = "0x60011BA")]
	internal void ApplySortingOrder() { }

	[Address(RVA = "0x33F4F70", Offset = "0x33F4370", Length = "0x7")]
	[Token(Token = "0x60011BD")]
	private void Awake() { }

	[Address(RVA = "0x33F4F80", Offset = "0x33F4380", Length = "0x3D5")]
	[Token(Token = "0x60011CC")]
	private void ClearTransform() { }

	[Address(RVA = "0x33F5360", Offset = "0x33F4760", Length = "0x3EA")]
	[Token(Token = "0x60011D2")]
	private void ComputeTransform(Transform transform, out Matrix4x4 matrix) { }

	[Address(RVA = "0x33F5750", Offset = "0x33F4B50", Length = "0x220")]
	[Token(Token = "0x60011C3")]
	internal void DoUpdate() { }

	[Address(RVA = "0x33F5980", Offset = "0x33F4D80", Length = "0xB1")]
	[Token(Token = "0x60011BB")]
	internal static UIDocument FindRootUIDocument(VisualElement element) { }

	[Address(RVA = "0x33F5A40", Offset = "0x33F4E40", Length = "0xAB")]
	[Token(Token = "0x60011D5")]
	private UIDocument FindUIDocumentParent() { }

	[Address(RVA = "0x33F8CC0", Offset = "0x33F80C0", Length = "0x7B")]
	[Token(Token = "0x60011C1")]
	internal RuntimePanel get_containerPanel() { }

	[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
	[Token(Token = "0x60011AB")]
	internal int get_firstChildInserIndex() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60011A9")]
	internal VisualElementFocusRing get_focusRing() { }

	[Address(RVA = "0x33F8D40", Offset = "0x33F8140", Length = "0x87")]
	[Token(Token = "0x60011B3")]
	internal bool get_isTransformControlledByGameObject() { }

	[Address(RVA = "0x33F8DD0", Offset = "0x33F81D0", Length = "0x80")]
	[Token(Token = "0x60011B2")]
	private bool get_isWorldSpace() { }

	[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
	[Token(Token = "0x60011A1")]
	public PanelSettings get_panelSettings() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60011A3")]
	public UIDocument get_parentUI() { }

	[Address(RVA = "0x33F8E70", Offset = "0x33F8270", Length = "0x9")]
	[Token(Token = "0x60011B6")]
	public Pivot get_pivot() { }

	[Address(RVA = "0x33F8E60", Offset = "0x33F8260", Length = "0x9")]
	[Token(Token = "0x60011B4")]
	public PivotReferenceSize get_pivotReferenceSize() { }

	[Address(RVA = "0x33F8E80", Offset = "0x33F8280", Length = "0x2B")]
	[Token(Token = "0x60011CD")]
	private float get_pixelsPerUnit() { }

	[Address(RVA = "0x33F8EB0", Offset = "0x33F82B0", Length = "0x6")]
	[Token(Token = "0x60011AC")]
	public Position get_position() { }

	[Address(RVA = "0x2F944E0", Offset = "0x2F938E0", Length = "0x7")]
	[Token(Token = "0x60011A7")]
	public VisualElement get_rootVisualElement() { }

	[Address(RVA = "0x33F8EC0", Offset = "0x33F82C0", Length = "0x7")]
	[Token(Token = "0x60011C0")]
	public IRuntimePanel get_runtimePanel() { }

	[Address(RVA = "0x2D7E0B0", Offset = "0x2D7D4B0", Length = "0x6")]
	[Token(Token = "0x60011B8")]
	public float get_sortingOrder() { }

	[Address(RVA = "0x2F944F0", Offset = "0x2F938F0", Length = "0x7")]
	[Token(Token = "0x60011A5")]
	public VisualTreeAsset get_visualTreeAsset() { }

	[Address(RVA = "0x33F8ED0", Offset = "0x33F82D0", Length = "0x16")]
	[Token(Token = "0x60011B0")]
	public Vector2 get_worldSpaceSize() { }

	[Address(RVA = "0x30D0FD0", Offset = "0x30D03D0", Length = "0x6")]
	[Token(Token = "0x60011AE")]
	public WorldSpaceSizeMode get_worldSpaceSizeMode() { }

	[Address(RVA = "0x33F5AF0", Offset = "0x33F4EF0", Length = "0xD8")]
	[Token(Token = "0x60011D3")]
	private static Vector2 GetPivotAsPercent(Pivot origin) { }

	[Address(RVA = "0x33F5BF0", Offset = "0x33F4FF0", Length = "0x45")]
	[Token(Token = "0x60011C9")]
	private static bool IsValidBounds(in Bounds b) { }

	[Address(RVA = "0x33F5C40", Offset = "0x33F5040", Length = "0x7")]
	[Token(Token = "0x60011C2")]
	private void LateUpdate() { }

	[Address(RVA = "0x33F5C50", Offset = "0x33F5050", Length = "0x1C8")]
	[Token(Token = "0x60011CF")]
	private Bounds LocalBoundsFromPivotSource() { }

	[Address(RVA = "0x33F5E20", Offset = "0x33F5220", Length = "0x11B")]
	[Token(Token = "0x60011DF")]
	private void OnDisable() { }

	[Address(RVA = "0x33F5F40", Offset = "0x33F5340", Length = "0x131")]
	[Token(Token = "0x60011BE")]
	private void OnEnable() { }

	[Address(RVA = "0x33F6080", Offset = "0x33F5480", Length = "0x1F7")]
	[Token(Token = "0x60011E0")]
	private void OnTransformChildrenChanged() { }

	[Address(RVA = "0x33F6280", Offset = "0x33F5680", Length = "0x7")]
	[Token(Token = "0x60011E1")]
	private void OnTransformParentChanged() { }

	[Address(RVA = "0x33F6290", Offset = "0x33F5690", Length = "0x298")]
	[Token(Token = "0x60011D0")]
	private Vector2 PivotOffset() { }

	[Address(RVA = "0x33F6550", Offset = "0x33F5950", Length = "0xA8")]
	[Token(Token = "0x60011E2")]
	internal void ReactToHierarchyChanged() { }

	[Address(RVA = "0x33F6600", Offset = "0x33F5A00", Length = "0x585")]
	[Token(Token = "0x60011D9")]
	private void RecreateUI() { }

	[Address(RVA = "0x33F6B90", Offset = "0x33F5F90", Length = "0x6F")]
	[Token(Token = "0x60011D8")]
	private void RemoveChild(UIDocument child) { }

	[Address(RVA = "0x33F6C00", Offset = "0x33F6000", Length = "0x102")]
	[Token(Token = "0x60011DE")]
	private void RemoveFromHierarchy() { }

	[Address(RVA = "0x33F6D10", Offset = "0x33F6110", Length = "0x72")]
	[Token(Token = "0x60011C8")]
	internal void RemoveWorldSpaceCollider() { }

	[Address(RVA = "0x33F6D90", Offset = "0x33F6190", Length = "0x108")]
	[Token(Token = "0x60011D6")]
	internal void Reset() { }

	[Address(RVA = "0x33F6EA0", Offset = "0x33F62A0", Length = "0x1C2")]
	[Token(Token = "0x60011C5")]
	private Bounds SanitizeRendererBounds(Bounds b) { }

	[Address(RVA = "0x33F7070", Offset = "0x33F6470", Length = "0x262")]
	[Token(Token = "0x60011CE")]
	private Matrix4x4 ScaleAndFlipMatrix() { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[CompilerGenerated]
	[Token(Token = "0x60011AA")]
	private void set_focusRing(VisualElementFocusRing value) { }

	[Address(RVA = "0x33F8EF0", Offset = "0x33F82F0", Length = "0x2CC")]
	[Token(Token = "0x60011A2")]
	public void set_panelSettings(PanelSettings value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x60011A4")]
	private void set_parentUI(UIDocument value) { }

	[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
	[Token(Token = "0x60011B7")]
	public void set_pivot(Pivot value) { }

	[Address(RVA = "0xD11B10", Offset = "0xD10F10", Length = "0x7")]
	[Token(Token = "0x60011B5")]
	public void set_pivotReferenceSize(PivotReferenceSize value) { }

	[Address(RVA = "0x33F91C0", Offset = "0x33F85C0", Length = "0x10")]
	[Token(Token = "0x60011AD")]
	public void set_position(Position value) { }

	[Address(RVA = "0x33F91D0", Offset = "0x33F85D0", Length = "0x112")]
	[Token(Token = "0x60011A8")]
	private void set_rootVisualElement(VisualElement value) { }

	[Address(RVA = "0x33F92F0", Offset = "0x33F86F0", Length = "0x19")]
	[Token(Token = "0x60011B9")]
	public void set_sortingOrder(float value) { }

	[Address(RVA = "0x33F9310", Offset = "0x33F8710", Length = "0x25")]
	[Token(Token = "0x60011A6")]
	public void set_visualTreeAsset(VisualTreeAsset value) { }

	[Address(RVA = "0x33F9350", Offset = "0x33F8750", Length = "0xA05")]
	[Token(Token = "0x60011B1")]
	public void set_worldSpaceSize(Vector2 value) { }

	[Address(RVA = "0x33F9340", Offset = "0x33F8740", Length = "0x10")]
	[Token(Token = "0x60011AF")]
	public void set_worldSpaceSizeMode(WorldSpaceSizeMode value) { }

	[Address(RVA = "0x33F72E0", Offset = "0x33F66E0", Length = "0x55F")]
	[Token(Token = "0x60011CB")]
	private void SetTransform() { }

	[Address(RVA = "0x33F7840", Offset = "0x33F6C40", Length = "0x160")]
	[Token(Token = "0x60011D4")]
	private void SetupFromHierarchy() { }

	[Address(RVA = "0x33F79B0", Offset = "0x33F6DB0", Length = "0xF3")]
	[Token(Token = "0x60011DA")]
	internal void SetupPosition() { }

	[Address(RVA = "0x33F7AB0", Offset = "0x33F6EB0", Length = "0x2E4")]
	[Token(Token = "0x60011DB")]
	private void SetupRootClassList() { }

	[Address(RVA = "0x33F7DA0", Offset = "0x33F71A0", Length = "0x3C7")]
	[Token(Token = "0x60011DC")]
	private void SetupWorldSpaceSize() { }

	[Address(RVA = "0x33F8170", Offset = "0x33F7570", Length = "0x12F")]
	[Token(Token = "0x60011D1")]
	private Matrix4x4 TransformToGameObjectMatrix() { }

	[Address(RVA = "0x33F82A0", Offset = "0x33F76A0", Length = "0xE5")]
	[Token(Token = "0x60011CA")]
	private void UpdateIsWorldSpaceRootFlag() { }

	[Address(RVA = "0x33F8390", Offset = "0x33F7790", Length = "0x314")]
	[Token(Token = "0x60011C4")]
	private void UpdateRenderer() { }

	[Address(RVA = "0x33F86B0", Offset = "0x33F7AB0", Length = "0x446")]
	[Token(Token = "0x60011C7")]
	internal void UpdateWorldSpaceCollider(ColliderUpdateMode mode) { }

}

