namespace UnityEngine.UIElements;

[Token(Token = "0x20002C1")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule", "UnityEngine.VectorGraphicsModule"})]
internal abstract class BaseRuntimePanel : Panel
{
	[CompilerGenerated]
	[Token(Token = "0x20002C2")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B3E")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x340CFB0", Offset = "0x340C3B0", Length = "0x67")]
		[Token(Token = "0x600134A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600134B")]
		public <>c() { }

		[Address(RVA = "0x340CD90", Offset = "0x340C190", Length = "0x24")]
		[Token(Token = "0x600134C")]
		internal Vector3 <.cctor>b__51_0(Vector2 p) { }

	}

	[Token(Token = "0x4000B32")]
	private static int s_CurrentRuntimePanelCounter; //Field offset: 0x0
	[Token(Token = "0x4000B3C")]
	internal static readonly Func<Vector2, Vector3> DefaultScreenToPanelSpace; //Field offset: 0x8
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000B31")]
	private GameObject m_SelectableGameObject; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000B33")]
	internal readonly int m_RuntimePanelCreationIndex; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x4000B34")]
	private float m_SortingPriority; //Field offset: 0x1E4
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000B35")]
	internal int resolvedSortingIndex; //Field offset: 0x1E8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000B36")]
	private Action destroyed; //Field offset: 0x1F0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000B37")]
	private Action drawsInCamerasChanged; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000B38")]
	private bool m_DrawsInCameras; //Field offset: 0x200
	[FieldOffset(Offset = "0x204")]
	[Token(Token = "0x4000B39")]
	private float m_PixelsPerUnit; //Field offset: 0x204
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000B3A")]
	internal RenderTexture targetTexture; //Field offset: 0x208
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000B3B")]
	private int <targetDisplay>k__BackingField; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B3D")]
	private Func<Vector2, Vector3> m_ScreenToPanelSpace; //Field offset: 0x218

	[Token(Token = "0x1400002B")]
	public event Action destroyed
	{
		[Address(RVA = "0x33FB080", Offset = "0x33FA480", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x600132F")]
		 add { } //Length: 162
		[Address(RVA = "0x33FB570", Offset = "0x33FA970", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6001330")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x1400002C")]
	internal event Action drawsInCamerasChanged
	{
		[Address(RVA = "0x33FB130", Offset = "0x33FA530", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6001333")]
		internal add { } //Length: 162
		[Address(RVA = "0x33FB620", Offset = "0x33FAA20", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6001334")]
		internal remove { } //Length: 162
	}

	[Token(Token = "0x170003C1")]
	internal bool drawsInCameras
	{
		[Address(RVA = "0x33FB360", Offset = "0x33FA760", Length = "0xA")]
		[Token(Token = "0x6001336")]
		internal get { } //Length: 10
		[Address(RVA = "0x33FB6D0", Offset = "0x33FAAD0", Length = "0x7D")]
		[Token(Token = "0x6001337")]
		internal set { } //Length: 125
	}

	[Token(Token = "0x170003C2")]
	internal float pixelsPerUnit
	{
		[Address(RVA = "0x33FB370", Offset = "0x33FA770", Length = "0xB")]
		[Token(Token = "0x6001338")]
		internal get { } //Length: 11
		[Address(RVA = "0x33FB750", Offset = "0x33FAB50", Length = "0x9")]
		[Token(Token = "0x6001339")]
		internal set { } //Length: 9
	}

	[Token(Token = "0x170003C5")]
	internal int screenRenderingHeight
	{
		[Address(RVA = "0x33FB380", Offset = "0x33FA780", Length = "0xE9")]
		[Token(Token = "0x600133D")]
		internal get { } //Length: 233
	}

	[Token(Token = "0x170003C4")]
	internal int screenRenderingWidth
	{
		[Address(RVA = "0x33FB470", Offset = "0x33FA870", Length = "0xE9")]
		[Token(Token = "0x600133C")]
		internal get { } //Length: 233
	}

	[Token(Token = "0x170003C6")]
	public Func<Vector2, Vector3> screenToPanelSpace
	{
		[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
		[Token(Token = "0x6001342")]
		 get { } //Length: 8
		[Address(RVA = "0x33FB760", Offset = "0x33FAB60", Length = "0x84")]
		[Token(Token = "0x6001343")]
		 set { } //Length: 132
	}

	[Token(Token = "0x170003BF")]
	public override GameObject selectableGameObject
	{
		[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
		[Token(Token = "0x600132B")]
		 get { } //Length: 8
		[Address(RVA = "0x33FB7F0", Offset = "0x33FABF0", Length = "0xA0")]
		[Token(Token = "0x600132C")]
		 set { } //Length: 160
	}

	[Token(Token = "0x170003C0")]
	public float sortingPriority
	{
		[Address(RVA = "0x33FB560", Offset = "0x33FA960", Length = "0x9")]
		[Token(Token = "0x600132D")]
		 get { } //Length: 9
		[Address(RVA = "0x33FB890", Offset = "0x33FAC90", Length = "0x8C")]
		[Token(Token = "0x600132E")]
		 set { } //Length: 140
	}

	[Token(Token = "0x170003C3")]
	internal int targetDisplay
	{
		[Address(RVA = "0x3264080", Offset = "0x3263480", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600133A")]
		internal get { } //Length: 7
		[Address(RVA = "0x33FB920", Offset = "0x33FAD20", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600133B")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x33FAE80", Offset = "0x33FA280", Length = "0xE1")]
	[Token(Token = "0x6001349")]
	private static BaseRuntimePanel() { }

	[Address(RVA = "0x33FAF70", Offset = "0x33FA370", Length = "0x106")]
	[Token(Token = "0x6001331")]
	protected BaseRuntimePanel(ScriptableObject ownerObject, EventDispatcher dispatcher = null) { }

	[Address(RVA = "0x33FB080", Offset = "0x33FA480", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x600132F")]
	public void add_destroyed(Action value) { }

	[Address(RVA = "0x33FB130", Offset = "0x33FA530", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6001333")]
	internal void add_drawsInCamerasChanged(Action value) { }

	[Address(RVA = "0x33FA100", Offset = "0x33F9500", Length = "0x2E5")]
	[Token(Token = "0x6001346")]
	private void AssignPanelToComponents(BaseRuntimePanel panel) { }

	[Address(RVA = "0x33FA3F0", Offset = "0x33F97F0", Length = "0x51")]
	[Token(Token = "0x6001332")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x33FB360", Offset = "0x33FA760", Length = "0xA")]
	[Token(Token = "0x6001336")]
	internal bool get_drawsInCameras() { }

	[Address(RVA = "0x33FB370", Offset = "0x33FA770", Length = "0xB")]
	[Token(Token = "0x6001338")]
	internal float get_pixelsPerUnit() { }

	[Address(RVA = "0x33FB380", Offset = "0x33FA780", Length = "0xE9")]
	[Token(Token = "0x600133D")]
	internal int get_screenRenderingHeight() { }

	[Address(RVA = "0x33FB470", Offset = "0x33FA870", Length = "0xE9")]
	[Token(Token = "0x600133C")]
	internal int get_screenRenderingWidth() { }

	[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
	[Token(Token = "0x6001342")]
	public Func<Vector2, Vector3> get_screenToPanelSpace() { }

	[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
	[Token(Token = "0x600132B")]
	public override GameObject get_selectableGameObject() { }

	[Address(RVA = "0x33FB560", Offset = "0x33FA960", Length = "0x9")]
	[Token(Token = "0x600132D")]
	public float get_sortingPriority() { }

	[Address(RVA = "0x3264080", Offset = "0x3263480", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600133A")]
	internal int get_targetDisplay() { }

	[Address(RVA = "0x33FB1E0", Offset = "0x33FA5E0", Length = "0xB1")]
	[Token(Token = "0x600133F")]
	internal static int getScreenRenderingHeight(int display) { }

	[Address(RVA = "0x33FB2A0", Offset = "0x33FA6A0", Length = "0xB1")]
	[Token(Token = "0x6001340")]
	internal static int getScreenRenderingWidth(int display) { }

	[Address(RVA = "0x33FA450", Offset = "0x33F9850", Length = "0x1C")]
	[Token(Token = "0x6001335")]
	private void InvokeDrawsInCamerasChanged() { }

	[Address(RVA = "0x33FA470", Offset = "0x33F9870", Length = "0xA6")]
	[Token(Token = "0x6001348")]
	internal void PointerEntersPanel(int pointerId, Vector3 position) { }

	[Address(RVA = "0x33FA520", Offset = "0x33F9920", Length = "0x125")]
	[Token(Token = "0x6001347")]
	internal void PointerLeavesPanel(int pointerId) { }

	[Address(RVA = "0x33FB570", Offset = "0x33FA970", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6001330")]
	public void remove_destroyed(Action value) { }

	[Address(RVA = "0x33FB620", Offset = "0x33FAA20", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6001334")]
	internal void remove_drawsInCamerasChanged(Action value) { }

	[Address(RVA = "0x33FA650", Offset = "0x33F9A50", Length = "0x466")]
	[Token(Token = "0x6001341")]
	public virtual void Render() { }

	[Address(RVA = "0x33FADC0", Offset = "0x33FA1C0", Length = "0x75")]
	[Token(Token = "0x6001344")]
	internal Vector3 ScreenToPanel(Vector2 screen) { }

	[Address(RVA = "0x33FAAC0", Offset = "0x33F9EC0", Length = "0x2F8")]
	[Token(Token = "0x6001345")]
	internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector3 panelPosition, bool allowOutside = false) { }

	[Address(RVA = "0x33FB6D0", Offset = "0x33FAAD0", Length = "0x7D")]
	[Token(Token = "0x6001337")]
	internal void set_drawsInCameras(bool value) { }

	[Address(RVA = "0x33FB750", Offset = "0x33FAB50", Length = "0x9")]
	[Token(Token = "0x6001339")]
	internal void set_pixelsPerUnit(float value) { }

	[Address(RVA = "0x33FB760", Offset = "0x33FAB60", Length = "0x84")]
	[Token(Token = "0x6001343")]
	public void set_screenToPanelSpace(Func<Vector2, Vector3> value) { }

	[Address(RVA = "0x33FB7F0", Offset = "0x33FABF0", Length = "0xA0")]
	[Token(Token = "0x600132C")]
	public override void set_selectableGameObject(GameObject value) { }

	[Address(RVA = "0x33FB890", Offset = "0x33FAC90", Length = "0x8C")]
	[Token(Token = "0x600132E")]
	public void set_sortingPriority(float value) { }

	[Address(RVA = "0x33FB920", Offset = "0x33FAD20", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600133B")]
	internal void set_targetDisplay(int value) { }

	[Address(RVA = "0x33FAE40", Offset = "0x33FA240", Length = "0x38")]
	[Token(Token = "0x600133E")]
	internal override void Update() { }

}

