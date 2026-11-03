namespace UnityEngine.UIElements;

[Token(Token = "0x200021A")]
internal static class PointerDeviceState
{
	[Flags]
	[Token(Token = "0x200021B")]
	public enum LocationFlag : int
	{
		None = 0,
		OutsidePanel = 1,
	}

	[Token(Token = "0x200021C")]
	private struct PointerLocation
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008A5")]
		private Vector3 <Position>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008A6")]
		private IPanel <Panel>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008A7")]
		private LocationFlag <Flags>k__BackingField; //Field offset: 0x18

		[Token(Token = "0x17000299")]
		internal LocationFlag Flags
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000EC1")]
			internal get { } //Length: 4
			[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000EC2")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000298")]
		internal IPanel Panel
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000EBF")]
			internal get { } //Length: 5
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000EC0")]
			private set { } //Length: 13
		}

		[Token(Token = "0x17000297")]
		internal Vector3 Position
		{
			[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000EBD")]
			internal get { } //Length: 18
			[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
			[CompilerGenerated]
			[Token(Token = "0x6000EBE")]
			private set { } //Length: 15
		}

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000EC1")]
		internal LocationFlag get_Flags() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000EBF")]
		internal IPanel get_Panel() { }

		[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000EBD")]
		internal Vector3 get_Position() { }

		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000EC2")]
		private void set_Flags(LocationFlag value) { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000EC0")]
		private void set_Panel(IPanel value) { }

		[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
		[CompilerGenerated]
		[Token(Token = "0x6000EBE")]
		private void set_Position(Vector3 value) { }

		[Address(RVA = "0x33D9C60", Offset = "0x33D9060", Length = "0x1D2")]
		[Token(Token = "0x6000EC3")]
		internal void SetLocation(Vector3 position, IPanel panel) { }

	}

	[Token(Token = "0x200021D")]
	internal class RuntimePointerState
	{
		[Token(Token = "0x200021E")]
		internal struct RaycastHit
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008AA")]
			public float distance; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40008AB")]
			public Collider collider; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40008AC")]
			public UIDocument document; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40008AD")]
			public VisualElement element; //Field offset: 0x18

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008A8")]
		public RaycastHit hit; //Field offset: 0x10
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40008A9")]
		public int updateFrameCount; //Field offset: 0x30

		[Address(RVA = "0x33DB5A0", Offset = "0x33DA9A0", Length = "0xE")]
		[Token(Token = "0x6000EC5")]
		public RuntimePointerState() { }

		[Address(RVA = "0x33DB580", Offset = "0x33DA980", Length = "0x13")]
		[Token(Token = "0x6000EC4")]
		public override void Reset() { }

	}

	[Token(Token = "0x200021F")]
	internal class ScreenPointerState : RuntimePointerState
	{
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40008AE")]
		public Vector2 mousePosition; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40008AF")]
		public Nullable<Int32> targetDisplay; //Field offset: 0x40

		[Address(RVA = "0x33DB5A0", Offset = "0x33DA9A0", Length = "0xE")]
		[Token(Token = "0x6000EC7")]
		public ScreenPointerState() { }

		[Address(RVA = "0x33DB5B0", Offset = "0x33DA9B0", Length = "0x64")]
		[Token(Token = "0x6000EC6")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x2000220")]
	internal class TrackedPointerState : RuntimePointerState
	{
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40008B0")]
		public Vector3 worldPosition; //Field offset: 0x38
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40008B1")]
		public Quaternion worldOrientation; //Field offset: 0x44
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40008B2")]
		public float maxDistance; //Field offset: 0x54

		[Token(Token = "0x1700029A")]
		public Ray worldRay
		{
			[Address(RVA = "0x33DBB80", Offset = "0x33DAF80", Length = "0x1A1")]
			[Token(Token = "0x6000EC8")]
			 get { } //Length: 417
		}

		[Address(RVA = "0x33DBAF0", Offset = "0x33DAEF0", Length = "0x90")]
		[Token(Token = "0x6000ECA")]
		public TrackedPointerState() { }

		[Address(RVA = "0x33DBB80", Offset = "0x33DAF80", Length = "0x1A1")]
		[Token(Token = "0x6000EC8")]
		public Ray get_worldRay() { }

		[Address(RVA = "0x33DBA50", Offset = "0x33DAE50", Length = "0x92")]
		[Token(Token = "0x6000EC9")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x400089C")]
	private static RuntimePointerState[] s_RuntimePointerStates; //Field offset: 0x0
	[Token(Token = "0x400089D")]
	private static PointerLocation[] s_PlayerPointerLocations; //Field offset: 0x8
	[Token(Token = "0x400089E")]
	private static Int32[] s_PressedButtons; //Field offset: 0x10
	[Token(Token = "0x400089F")]
	private static readonly RuntimePanel[] s_PlayerPanelWithSoftPointerCapture; //Field offset: 0x18
	[Token(Token = "0x40008A0")]
	private static readonly UIDocument[] s_WorldSpaceDocumentWithSoftPointerCapture; //Field offset: 0x20
	[Token(Token = "0x40008A1")]
	private static readonly Camera[] s_CameraWithSoftPointerCapture; //Field offset: 0x28

	[Address(RVA = "0x33D8B80", Offset = "0x33D7F80", Length = "0x23B")]
	[Token(Token = "0x6000EBC")]
	private static PointerDeviceState() { }

	[Address(RVA = "0x33D7670", Offset = "0x33D6A70", Length = "0x6F")]
	[Token(Token = "0x6000EB7")]
	internal static Camera GetCameraWithSoftPointerCapture(int pointerId) { }

	[Address(RVA = "0x33D76E0", Offset = "0x33D6AE0", Length = "0x76")]
	[Token(Token = "0x6000EB0")]
	public static IPanel GetPanel(int pointerId, ContextType contextType) { }

	[Address(RVA = "0x33D7760", Offset = "0x33D6B60", Length = "0x6F")]
	[Token(Token = "0x6000EB5")]
	internal static RuntimePanel GetPlayerPanelWithSoftPointerCapture(int pointerId) { }

	[Address(RVA = "0x33D77D0", Offset = "0x33D6BD0", Length = "0x15E")]
	[Token(Token = "0x6000EAF")]
	public static Vector3 GetPointerDeltaPosition(int pointerId, ContextType contextType, Vector3 newPosition) { }

	[Address(RVA = "0x33D7930", Offset = "0x33D6D30", Length = "0x99")]
	[Token(Token = "0x6000EAE")]
	public static Vector3 GetPointerPosition(int pointerId, ContextType contextType) { }

	[Address(RVA = "0x33D79D0", Offset = "0x33D6DD0", Length = "0x6E")]
	[Token(Token = "0x6000EB3")]
	public static int GetPressedButtons(int pointerId) { }

	[Address(RVA = "0x33D7A40", Offset = "0x33D6E40", Length = "0x1DF")]
	[Token(Token = "0x6000EBB")]
	internal static ScreenPointerState GetScreenPointerState(int pointerId, bool createIfNull = false) { }

	[Address(RVA = "0x33D7C20", Offset = "0x33D7020", Length = "0x259")]
	[Token(Token = "0x6000EB9")]
	internal static TrackedPointerState GetTrackedState(int pointerId, bool createIfNull = false) { }

	[Address(RVA = "0x33D7E80", Offset = "0x33D7280", Length = "0x6F")]
	[Token(Token = "0x6000EB6")]
	internal static UIDocument GetWorldSpaceDocumentWithSoftPointerCapture(int pointerId) { }

	[Address(RVA = "0x33D7EF0", Offset = "0x33D72F0", Length = "0x84")]
	[Token(Token = "0x6000EB4")]
	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	[Address(RVA = "0x33D7F80", Offset = "0x33D7380", Length = "0xA")]
	[Token(Token = "0x6000EB1")]
	private static bool HasFlagFast(LocationFlag flagSet, LocationFlag flag) { }

	[Address(RVA = "0x33D7F90", Offset = "0x33D7390", Length = "0x88")]
	[Token(Token = "0x6000EB2")]
	public static bool HasLocationFlag(int pointerId, ContextType contextType, LocationFlag flag) { }

	[Address(RVA = "0x33D8020", Offset = "0x33D7420", Length = "0xEB")]
	[Token(Token = "0x6000EAB")]
	public static void PressButton(int pointerId, int buttonId) { }

	[Address(RVA = "0x33D8110", Offset = "0x33D7510", Length = "0x72")]
	[Token(Token = "0x6000EAD")]
	public static void ReleaseAllButtons(int pointerId) { }

	[Address(RVA = "0x33D8190", Offset = "0x33D7590", Length = "0xEB")]
	[Token(Token = "0x6000EAC")]
	public static void ReleaseButton(int pointerId, int buttonId) { }

	[Address(RVA = "0x33D8280", Offset = "0x33D7680", Length = "0x1A8")]
	[Token(Token = "0x6000EA9")]
	internal static void RemoveDocumentData(UIDocument document) { }

	[Address(RVA = "0x33D8430", Offset = "0x33D7830", Length = "0x337")]
	[Token(Token = "0x6000EA8")]
	internal static void RemovePanelData(IPanel panel) { }

	[Address(RVA = "0x33D8770", Offset = "0x33D7B70", Length = "0xE1")]
	[Token(Token = "0x6000EBA")]
	internal static void RemoveTrackedState(int pointerId) { }

	[Address(RVA = "0x33D8860", Offset = "0x33D7C60", Length = "0xAF")]
	[Token(Token = "0x6000EAA")]
	public static void SavePointerPosition(int pointerId, Vector3 position, IPanel panel, ContextType contextType) { }

	[Address(RVA = "0x33D8910", Offset = "0x33D7D10", Length = "0x262")]
	[Token(Token = "0x6000EB8")]
	internal static void SetElementWithSoftPointerCapture(int pointerId, VisualElement element, Camera camera) { }

}

