namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/Panel Input Configuration", 1)]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("UIE-get-started-with-runtime-ui")]
[Token(Token = "0x2000271")]
public sealed class PanelInputConfiguration : MonoBehaviour
{
	[Token(Token = "0x2000272")]
	internal enum PanelInputRedirection : int
	{
		AutoSwitch = 0,
		Never = 1,
		Always = 2,
	}

	[Token(Token = "0x2000273")]
	public struct Settings
	{
		[Token(Token = "0x4000999")]
		private static Settings s_Default; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x400099A")]
		[Tooltip("Determines whether world space panels process input events. Disable this if you need UGUI support but do not require world space input to improve performance.")]
		internal bool m_ProcessWorldSpaceInput; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[Token(Token = "0x400099B")]
		[Tooltip("Determines which layers can block input events on world space panels.")]
		internal LayerMask m_InteractionLayers; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x400099C")]
		[Tooltip("Sets how far away interactions with world-space UI are possible. Defaults to unlimited (infinity), but you can customize it for XR or performance needs. The distance uses GameObject units, consistent with transform positions and Camera clipping planes.")]
		internal float m_MaxInteractionDistance; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		[Token(Token = "0x400099D")]
		[Tooltip("Defines whether the Main Camera is used as the Event Camera for world space panels. Disable to specify alternative Event Camera(s) for raycasting input.")]
		internal bool m_DefaultEventCameraIsMainCamera; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x400099E")]
		[Tooltip("Defines the Event Camera(s) used for world space raycasting input.")]
		internal Camera[] m_EventCameras; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x400099F")]
		[Tooltip("Determines which input event system is used for UI interactions when combining UI Toolkit and UGUI.")]
		internal PanelInputRedirection m_PanelInputRedirection; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Token(Token = "0x40009A0")]
		[Tooltip("Automatically adds UI Toolkit components under the EventSystem to handle input redirection between UI Toolkit and UGUI panels. Disable to manually assign these components through code.")]
		internal bool m_AutoCreatePanelComponents; //Field offset: 0x1C

		[Token(Token = "0x1700033D")]
		public bool autoCreatePanelComponents
		{
			[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
			[Token(Token = "0x600111F")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000336")]
		public static Settings Default
		{
			[Address(RVA = "0x33F3340", Offset = "0x33F2740", Length = "0x62")]
			[Token(Token = "0x6001118")]
			 get { } //Length: 98
		}

		[Token(Token = "0x1700033A")]
		public bool defaultEventCameraIsMainCamera
		{
			[Address(RVA = "0x293B900", Offset = "0x293AD00", Length = "0x5")]
			[Token(Token = "0x600111C")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700033B")]
		public Camera[] eventCameras
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x600111D")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000338")]
		public LayerMask interactionLayers
		{
			[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
			[Token(Token = "0x600111A")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000339")]
		public float maxInteractionDistance
		{
			[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
			[Token(Token = "0x600111B")]
			 get { } //Length: 229
		}

		[Token(Token = "0x1700033C")]
		public PanelInputRedirection panelInputRedirection
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[Token(Token = "0x600111E")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000337")]
		public bool processWorldSpaceInput
		{
			[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
			[Token(Token = "0x6001119")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x33F3270", Offset = "0x33F2670", Length = "0xC3")]
		[Token(Token = "0x6001120")]
		private static Settings() { }

		[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
		[Token(Token = "0x600111F")]
		public bool get_autoCreatePanelComponents() { }

		[Address(RVA = "0x33F3340", Offset = "0x33F2740", Length = "0x62")]
		[Token(Token = "0x6001118")]
		public static Settings get_Default() { }

		[Address(RVA = "0x293B900", Offset = "0x293AD00", Length = "0x5")]
		[Token(Token = "0x600111C")]
		public bool get_defaultEventCameraIsMainCamera() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600111D")]
		public Camera[] get_eventCameras() { }

		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x600111A")]
		public LayerMask get_interactionLayers() { }

		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[Token(Token = "0x600111B")]
		public float get_maxInteractionDistance() { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600111E")]
		public PanelInputRedirection get_panelInputRedirection() { }

		[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
		[Token(Token = "0x6001119")]
		public bool get_processWorldSpaceInput() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000990")]
	private static PanelInputConfiguration <current>k__BackingField; //Field offset: 0x0
	[Token(Token = "0x4000994")]
	internal const string SettingsProperty = "m_Settings"; //Field offset: 0x0
	[Token(Token = "0x4000991")]
	internal static int s_ActiveInstances; //Field offset: 0x8
	[Token(Token = "0x4000992")]
	internal static Action<PanelInputConfiguration> onApply; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000993")]
	private Settings m_Settings; //Field offset: 0x20

	[Token(Token = "0x17000335")]
	public bool autoCreatePanelComponents
	{
		[Address(RVA = "0x101DB70", Offset = "0x101CF70", Length = "0x5")]
		[Token(Token = "0x6001112")]
		 get { } //Length: 5
		[Address(RVA = "0x33EFD80", Offset = "0x33EF180", Length = "0x10")]
		[Token(Token = "0x6001113")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700032D")]
	internal static PanelInputConfiguration current
	{
		[Address(RVA = "0x33EFD40", Offset = "0x33EF140", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x6001103")]
		internal get { } //Length: 54
		[Address(RVA = "0x33EFD90", Offset = "0x33EF190", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x6001104")]
		internal set { } //Length: 81
	}

	[Token(Token = "0x17000332")]
	public bool defaultEventCameraIsMainCamera
	{
		[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
		[Token(Token = "0x600110C")]
		 get { } //Length: 5
		[Address(RVA = "0x33EFDF0", Offset = "0x33EF1F0", Length = "0x10")]
		[Token(Token = "0x600110D")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000333")]
	public Camera[] eventCameras
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600110E")]
		 get { } //Length: 5
		[Address(RVA = "0x33EFE00", Offset = "0x33EF200", Length = "0x31")]
		[Token(Token = "0x600110F")]
		 set { } //Length: 49
	}

	[Token(Token = "0x17000330")]
	public LayerMask interactionLayers
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6001108")]
		 get { } //Length: 4
		[Address(RVA = "0x33EFE40", Offset = "0x33EF240", Length = "0x4A")]
		[Token(Token = "0x6001109")]
		 set { } //Length: 74
	}

	[Token(Token = "0x17000331")]
	public float maxInteractionDistance
	{
		[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
		[Token(Token = "0x600110A")]
		 get { } //Length: 6
		[Address(RVA = "0x33EFE90", Offset = "0x33EF290", Length = "0x19")]
		[Token(Token = "0x600110B")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000334")]
	public PanelInputRedirection panelInputRedirection
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6001110")]
		 get { } //Length: 4
		[Address(RVA = "0x33EFEB0", Offset = "0x33EF2B0", Length = "0x10")]
		[Token(Token = "0x6001111")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700032F")]
	public bool processWorldSpaceInput
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6001106")]
		 get { } //Length: 5
		[Address(RVA = "0x33EFEC0", Offset = "0x33EF2C0", Length = "0x10")]
		[Token(Token = "0x6001107")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700032E")]
	internal Settings settings
	{
		[Address(RVA = "0x337B800", Offset = "0x337AC00", Length = "0x13")]
		[Token(Token = "0x6001105")]
		internal get { } //Length: 19
	}

	[Address(RVA = "0x33EFC90", Offset = "0x33EF090", Length = "0xA2")]
	[Token(Token = "0x6001117")]
	public PanelInputConfiguration() { }

	[Address(RVA = "0x33EF480", Offset = "0x33EE880", Length = "0x434")]
	[Token(Token = "0x6001116")]
	private static void Apply(PanelInputConfiguration input) { }

	[Address(RVA = "0x101DB70", Offset = "0x101CF70", Length = "0x5")]
	[Token(Token = "0x6001112")]
	public bool get_autoCreatePanelComponents() { }

	[Address(RVA = "0x33EFD40", Offset = "0x33EF140", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6001103")]
	internal static PanelInputConfiguration get_current() { }

	[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
	[Token(Token = "0x600110C")]
	public bool get_defaultEventCameraIsMainCamera() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600110E")]
	public Camera[] get_eventCameras() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6001108")]
	public LayerMask get_interactionLayers() { }

	[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
	[Token(Token = "0x600110A")]
	public float get_maxInteractionDistance() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6001110")]
	public PanelInputRedirection get_panelInputRedirection() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6001106")]
	public bool get_processWorldSpaceInput() { }

	[Address(RVA = "0x337B800", Offset = "0x337AC00", Length = "0x13")]
	[Token(Token = "0x6001105")]
	internal Settings get_settings() { }

	[Address(RVA = "0x33EF8C0", Offset = "0x33EECC0", Length = "0xF8")]
	[Token(Token = "0x6001115")]
	private void OnDisable() { }

	[Address(RVA = "0x33EF9C0", Offset = "0x33EEDC0", Length = "0x2C6")]
	[Token(Token = "0x6001114")]
	private void OnEnable() { }

	[Address(RVA = "0x33EFD80", Offset = "0x33EF180", Length = "0x10")]
	[Token(Token = "0x6001113")]
	public void set_autoCreatePanelComponents(bool value) { }

	[Address(RVA = "0x33EFD90", Offset = "0x33EF190", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x6001104")]
	internal static void set_current(PanelInputConfiguration value) { }

	[Address(RVA = "0x33EFDF0", Offset = "0x33EF1F0", Length = "0x10")]
	[Token(Token = "0x600110D")]
	public void set_defaultEventCameraIsMainCamera(bool value) { }

	[Address(RVA = "0x33EFE00", Offset = "0x33EF200", Length = "0x31")]
	[Token(Token = "0x600110F")]
	public void set_eventCameras(Camera[] value) { }

	[Address(RVA = "0x33EFE40", Offset = "0x33EF240", Length = "0x4A")]
	[Token(Token = "0x6001109")]
	public void set_interactionLayers(LayerMask value) { }

	[Address(RVA = "0x33EFE90", Offset = "0x33EF290", Length = "0x19")]
	[Token(Token = "0x600110B")]
	public void set_maxInteractionDistance(float value) { }

	[Address(RVA = "0x33EFEB0", Offset = "0x33EF2B0", Length = "0x10")]
	[Token(Token = "0x6001111")]
	public void set_panelInputRedirection(PanelInputRedirection value) { }

	[Address(RVA = "0x33EFEC0", Offset = "0x33EF2C0", Length = "0x10")]
	[Token(Token = "0x6001107")]
	public void set_processWorldSpaceInput(bool value) { }

}

