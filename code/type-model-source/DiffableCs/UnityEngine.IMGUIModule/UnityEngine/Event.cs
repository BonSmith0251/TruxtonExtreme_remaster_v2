namespace UnityEngine;

[NativeHeader("Modules/IMGUI/Event.bindings.h")]
[StaticAccessor("GUIEvent", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000002")]
public sealed class Event
{
	[Token(Token = "0x2000003")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000051")]
		public static IntPtr ConvertToNative(Event e) { }

	}

	[Token(Token = "0x4000002")]
	internal const float scrollWheelDeltaPerTick = 3; //Field offset: 0x0
	[Token(Token = "0x4000003")]
	internal static bool s_AllowOutsideOnGUI; //Field offset: 0x0
	[Token(Token = "0x4000004")]
	private static Event s_Current; //Field offset: 0x8
	[Token(Token = "0x4000005")]
	private static Event s_MasterEvent; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000001")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Token(Token = "0x17000014")]
	public bool alt
	{
		[Address(RVA = "0x30DDD40", Offset = "0x30DD140", Length = "0x56")]
		[Token(Token = "0x6000028")]
		 get { } //Length: 86
	}

	[NativeProperty("button", False, TargetType::Field (1))]
	[Token(Token = "0x17000005")]
	public int button
	{
		[Address(RVA = "0x30DDDE0", Offset = "0x30DD1E0", Length = "0x51")]
		[Token(Token = "0x6000007")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000016")]
	public bool capsLock
	{
		[Address(RVA = "0x30DDE40", Offset = "0x30DD240", Length = "0x56")]
		[Token(Token = "0x600002A")]
		 get { } //Length: 86
	}

	[NativeProperty("character", False, TargetType::Field (1))]
	[Token(Token = "0x1700000C")]
	public char character
	{
		[Address(RVA = "0x30DDEE0", Offset = "0x30DD2E0", Length = "0x51")]
		[Token(Token = "0x600000E")]
		 get { } //Length: 81
	}

	[NativeProperty("clickCount", False, TargetType::Field (1))]
	[Token(Token = "0x1700000B")]
	public int clickCount
	{
		[Address(RVA = "0x30DDF80", Offset = "0x30DD380", Length = "0x51")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000015")]
	public bool command
	{
		[Address(RVA = "0x30DE100", Offset = "0x30DD500", Length = "0x56")]
		[Token(Token = "0x6000029")]
		 get { } //Length: 86
	}

	[Token(Token = "0x17000011")]
	public string commandName
	{
		[Address(RVA = "0x30DE030", Offset = "0x30DD430", Length = "0xCE")]
		[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = True)]
		[Token(Token = "0x6000015")]
		 get { } //Length: 206
		[Address(RVA = "0x30DEF40", Offset = "0x30DE340", Length = "0x1BB")]
		[FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = True)]
		[Token(Token = "0x6000016")]
		 set { } //Length: 443
	}

	[Token(Token = "0x17000013")]
	public bool control
	{
		[Address(RVA = "0x30DE160", Offset = "0x30DD560", Length = "0x56")]
		[Token(Token = "0x6000027")]
		 get { } //Length: 86
	}

	[Token(Token = "0x17000019")]
	public static Event current
	{
		[Address(RVA = "0x30DE1C0", Offset = "0x30DD5C0", Length = "0x37")]
		[Token(Token = "0x600002D")]
		 get { } //Length: 55
		[Address(RVA = "0x30DF100", Offset = "0x30DE500", Length = "0xAB")]
		[Token(Token = "0x600002E")]
		 set { } //Length: 171
	}

	[NativeProperty("delta", False, TargetType::Field (1))]
	[Token(Token = "0x17000003")]
	public Vector2 delta
	{
		[Address(RVA = "0x30DE250", Offset = "0x30DD650", Length = "0x62")]
		[Token(Token = "0x6000004")]
		 get { } //Length: 98
		[Address(RVA = "0x30DF200", Offset = "0x30DE600", Length = "0x5B")]
		[Token(Token = "0x6000005")]
		 set { } //Length: 91
	}

	[NativeProperty("displayIndex", False, TargetType::Field (1))]
	[Token(Token = "0x1700000F")]
	public int displayIndex
	{
		[Address(RVA = "0x30DE300", Offset = "0x30DD700", Length = "0x51")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 81
		[Address(RVA = "0x30DF2A0", Offset = "0x30DE6A0", Length = "0x58")]
		[Token(Token = "0x6000012")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000018")]
	public bool functionKey
	{
		[Address(RVA = "0x30DE360", Offset = "0x30DD760", Length = "0x56")]
		[Token(Token = "0x600002C")]
		 get { } //Length: 86
	}

	[NativeProperty("keycode", False, TargetType::Field (1))]
	[Token(Token = "0x1700000D")]
	private KeyCode Internal_keyCode
	{
		[Address(RVA = "0x30DDCE0", Offset = "0x30DD0E0", Length = "0x51")]
		[Token(Token = "0x600000F")]
		private get { } //Length: 81
	}

	[Token(Token = "0x1700001D")]
	internal bool isDirectManipulationDevice
	{
		[Address(RVA = "0x30DE3C0", Offset = "0x30DD7C0", Length = "0xCC")]
		[Token(Token = "0x6000032")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 204
	}

	[Token(Token = "0x1700001A")]
	public bool isKey
	{
		[Address(RVA = "0x30DE490", Offset = "0x30DD890", Length = "0x7F")]
		[Token(Token = "0x600002F")]
		 get { } //Length: 127
	}

	[Token(Token = "0x1700001B")]
	public bool isMouse
	{
		[Address(RVA = "0x30DE510", Offset = "0x30DD910", Length = "0x89")]
		[Token(Token = "0x6000030")]
		 get { } //Length: 137
	}

	[Token(Token = "0x1700001C")]
	public bool isScrollWheel
	{
		[Address(RVA = "0x30DE5A0", Offset = "0x30DD9A0", Length = "0x57")]
		[Token(Token = "0x6000031")]
		 get { } //Length: 87
	}

	[Token(Token = "0x1700000E")]
	public KeyCode keyCode
	{
		[Address(RVA = "0x30DE600", Offset = "0x30DDA00", Length = "0x249")]
		[Token(Token = "0x6000010")]
		 get { } //Length: 585
	}

	[NativeProperty("modifiers", False, TargetType::Field (1))]
	[Token(Token = "0x17000006")]
	public EventModifiers modifiers
	{
		[Address(RVA = "0x30DE890", Offset = "0x30DDC90", Length = "0x51")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 81
	}

	[NativeProperty("mousePosition", False, TargetType::Field (1))]
	[Token(Token = "0x17000002")]
	public Vector2 mousePosition
	{
		[Address(RVA = "0x30DE940", Offset = "0x30DDD40", Length = "0x62")]
		[Token(Token = "0x6000002")]
		 get { } //Length: 98
		[Address(RVA = "0x30DF350", Offset = "0x30DE750", Length = "0x5B")]
		[Token(Token = "0x6000003")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000017")]
	public bool numeric
	{
		[Address(RVA = "0x30DE9B0", Offset = "0x30DDDB0", Length = "0x56")]
		[Token(Token = "0x600002B")]
		 get { } //Length: 86
	}

	[NativeProperty("penStatus", False, TargetType::Field (1))]
	[Token(Token = "0x1700000A")]
	public PenStatus penStatus
	{
		[Address(RVA = "0x30DEA50", Offset = "0x30DDE50", Length = "0x51")]
		[Token(Token = "0x600000C")]
		 get { } //Length: 81
	}

	[NativeProperty("pointerType", False, TargetType::Field (1))]
	[Token(Token = "0x17000004")]
	public PointerType pointerType
	{
		[Address(RVA = "0x30DEAF0", Offset = "0x30DDEF0", Length = "0x51")]
		[Token(Token = "0x6000006")]
		 get { } //Length: 81
	}

	[NativeProperty("pressure", False, TargetType::Field (1))]
	[Token(Token = "0x17000007")]
	public float pressure
	{
		[Address(RVA = "0x30DEB90", Offset = "0x30DDF90", Length = "0x51")]
		[Token(Token = "0x6000009")]
		 get { } //Length: 81
	}

	[NativeProperty("type", False, TargetType::Field (1))]
	[Token(Token = "0x17000001")]
	public EventType rawType
	{
		[Address(RVA = "0x30DEC30", Offset = "0x30DE030", Length = "0x51")]
		[Token(Token = "0x6000001")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000012")]
	public bool shift
	{
		[Address(RVA = "0x30DEC90", Offset = "0x30DE090", Length = "0x56")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 86
	}

	[NativeProperty("tilt", False, TargetType::Field (1))]
	[Token(Token = "0x17000009")]
	public Vector2 tilt
	{
		[Address(RVA = "0x30DED40", Offset = "0x30DE140", Length = "0x62")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 98
	}

	[NativeProperty("twist", False, TargetType::Field (1))]
	[Token(Token = "0x17000008")]
	public float twist
	{
		[Address(RVA = "0x30DEDF0", Offset = "0x30DE1F0", Length = "0x51")]
		[Token(Token = "0x600000A")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000010")]
	public EventType type
	{
		[Address(RVA = "0x30DEE90", Offset = "0x30DE290", Length = "0x51")]
		[FreeFunction("GUIEvent::GetType", HasExplicitThis = True)]
		[Token(Token = "0x6000013")]
		 get { } //Length: 81
		[Address(RVA = "0x30DF3F0", Offset = "0x30DE7F0", Length = "0x58")]
		[FreeFunction("GUIEvent::SetType", HasExplicitThis = True)]
		[Token(Token = "0x6000014")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x30DDC10", Offset = "0x30DD010", Length = "0x3D")]
	[Token(Token = "0x6000022")]
	public Event() { }

	[Address(RVA = "0x30DDC50", Offset = "0x30DD050", Length = "0x48")]
	[Token(Token = "0x6000023")]
	public Event(int displayIndex) { }

	[Address(RVA = "0x30DC7F0", Offset = "0x30DBBF0", Length = "0x6B")]
	[Token(Token = "0x6000025")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void CopyFrom(Event e) { }

	[Address(RVA = "0x30DC790", Offset = "0x30DBB90", Length = "0x5A")]
	[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = True, HasExplicitThis = True)]
	[Token(Token = "0x600001B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void CopyFromPtr(IntPtr ptr) { }

	[Address(RVA = "0x30DC740", Offset = "0x30DBB40", Length = "0x42")]
	[Token(Token = "0x600004E")]
	private static void CopyFromPtr_Injected(IntPtr _unity_self, IntPtr ptr) { }

	[Address(RVA = "0x30DC860", Offset = "0x30DBC60", Length = "0x2E9")]
	[Token(Token = "0x6000034")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30DCB50", Offset = "0x30DBF50", Length = "0x8D")]
	[Token(Token = "0x6000024")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x30DDD40", Offset = "0x30DD140", Length = "0x56")]
	[Token(Token = "0x6000028")]
	public bool get_alt() { }

	[Address(RVA = "0x30DDDE0", Offset = "0x30DD1E0", Length = "0x51")]
	[Token(Token = "0x6000007")]
	public int get_button() { }

	[Address(RVA = "0x30DDDA0", Offset = "0x30DD1A0", Length = "0x33")]
	[Token(Token = "0x600003D")]
	private static int get_button_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DDE40", Offset = "0x30DD240", Length = "0x56")]
	[Token(Token = "0x600002A")]
	public bool get_capsLock() { }

	[Address(RVA = "0x30DDEE0", Offset = "0x30DD2E0", Length = "0x51")]
	[Token(Token = "0x600000E")]
	public char get_character() { }

	[Address(RVA = "0x30DDEA0", Offset = "0x30DD2A0", Length = "0x33")]
	[Token(Token = "0x6000044")]
	private static char get_character_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DDF80", Offset = "0x30DD380", Length = "0x51")]
	[Token(Token = "0x600000D")]
	public int get_clickCount() { }

	[Address(RVA = "0x30DDF40", Offset = "0x30DD340", Length = "0x33")]
	[Token(Token = "0x6000043")]
	private static int get_clickCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DE100", Offset = "0x30DD500", Length = "0x56")]
	[Token(Token = "0x6000029")]
	public bool get_command() { }

	[Address(RVA = "0x30DE030", Offset = "0x30DD430", Length = "0xCE")]
	[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = True)]
	[Token(Token = "0x6000015")]
	public string get_commandName() { }

	[Address(RVA = "0x30DDFE0", Offset = "0x30DD3E0", Length = "0x42")]
	[Token(Token = "0x600004A")]
	private static void get_commandName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x30DE160", Offset = "0x30DD560", Length = "0x56")]
	[Token(Token = "0x6000027")]
	public bool get_control() { }

	[Address(RVA = "0x30DE1C0", Offset = "0x30DD5C0", Length = "0x37")]
	[Token(Token = "0x600002D")]
	public static Event get_current() { }

	[Address(RVA = "0x30DE250", Offset = "0x30DD650", Length = "0x62")]
	[Token(Token = "0x6000004")]
	public Vector2 get_delta() { }

	[Address(RVA = "0x30DE200", Offset = "0x30DD600", Length = "0x42")]
	[Token(Token = "0x600003A")]
	private static void get_delta_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x30DE300", Offset = "0x30DD700", Length = "0x51")]
	[Token(Token = "0x6000011")]
	public int get_displayIndex() { }

	[Address(RVA = "0x30DE2C0", Offset = "0x30DD6C0", Length = "0x33")]
	[Token(Token = "0x6000046")]
	private static int get_displayIndex_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DE360", Offset = "0x30DD760", Length = "0x56")]
	[Token(Token = "0x600002C")]
	public bool get_functionKey() { }

	[Address(RVA = "0x30DDCE0", Offset = "0x30DD0E0", Length = "0x51")]
	[Token(Token = "0x600000F")]
	private KeyCode get_Internal_keyCode() { }

	[Address(RVA = "0x30DDCA0", Offset = "0x30DD0A0", Length = "0x33")]
	[Token(Token = "0x6000045")]
	private static KeyCode get_Internal_keyCode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DE3C0", Offset = "0x30DD7C0", Length = "0xCC")]
	[Token(Token = "0x6000032")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool get_isDirectManipulationDevice() { }

	[Address(RVA = "0x30DE490", Offset = "0x30DD890", Length = "0x7F")]
	[Token(Token = "0x600002F")]
	public bool get_isKey() { }

	[Address(RVA = "0x30DE510", Offset = "0x30DD910", Length = "0x89")]
	[Token(Token = "0x6000030")]
	public bool get_isMouse() { }

	[Address(RVA = "0x30DE5A0", Offset = "0x30DD9A0", Length = "0x57")]
	[Token(Token = "0x6000031")]
	public bool get_isScrollWheel() { }

	[Address(RVA = "0x30DE600", Offset = "0x30DDA00", Length = "0x249")]
	[Token(Token = "0x6000010")]
	public KeyCode get_keyCode() { }

	[Address(RVA = "0x30DE890", Offset = "0x30DDC90", Length = "0x51")]
	[Token(Token = "0x6000008")]
	public EventModifiers get_modifiers() { }

	[Address(RVA = "0x30DE850", Offset = "0x30DDC50", Length = "0x33")]
	[Token(Token = "0x600003E")]
	private static EventModifiers get_modifiers_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DE940", Offset = "0x30DDD40", Length = "0x62")]
	[Token(Token = "0x6000002")]
	public Vector2 get_mousePosition() { }

	[Address(RVA = "0x30DE8F0", Offset = "0x30DDCF0", Length = "0x42")]
	[Token(Token = "0x6000038")]
	private static void get_mousePosition_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x30DE9B0", Offset = "0x30DDDB0", Length = "0x56")]
	[Token(Token = "0x600002B")]
	public bool get_numeric() { }

	[Address(RVA = "0x30DEA50", Offset = "0x30DDE50", Length = "0x51")]
	[Token(Token = "0x600000C")]
	public PenStatus get_penStatus() { }

	[Address(RVA = "0x30DEA10", Offset = "0x30DDE10", Length = "0x33")]
	[Token(Token = "0x6000042")]
	private static PenStatus get_penStatus_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DEAF0", Offset = "0x30DDEF0", Length = "0x51")]
	[Token(Token = "0x6000006")]
	public PointerType get_pointerType() { }

	[Address(RVA = "0x30DEAB0", Offset = "0x30DDEB0", Length = "0x33")]
	[Token(Token = "0x600003C")]
	private static PointerType get_pointerType_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DEB90", Offset = "0x30DDF90", Length = "0x51")]
	[Token(Token = "0x6000009")]
	public float get_pressure() { }

	[Address(RVA = "0x30DEB50", Offset = "0x30DDF50", Length = "0x33")]
	[Token(Token = "0x600003F")]
	private static float get_pressure_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DEC30", Offset = "0x30DE030", Length = "0x51")]
	[Token(Token = "0x6000001")]
	public EventType get_rawType() { }

	[Address(RVA = "0x30DEBF0", Offset = "0x30DDFF0", Length = "0x33")]
	[Token(Token = "0x6000037")]
	private static EventType get_rawType_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DEC90", Offset = "0x30DE090", Length = "0x56")]
	[Token(Token = "0x6000026")]
	public bool get_shift() { }

	[Address(RVA = "0x30DED40", Offset = "0x30DE140", Length = "0x62")]
	[Token(Token = "0x600000B")]
	public Vector2 get_tilt() { }

	[Address(RVA = "0x30DECF0", Offset = "0x30DE0F0", Length = "0x42")]
	[Token(Token = "0x6000041")]
	private static void get_tilt_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x30DEDF0", Offset = "0x30DE1F0", Length = "0x51")]
	[Token(Token = "0x600000A")]
	public float get_twist() { }

	[Address(RVA = "0x30DEDB0", Offset = "0x30DE1B0", Length = "0x33")]
	[Token(Token = "0x6000040")]
	private static float get_twist_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DEE90", Offset = "0x30DE290", Length = "0x51")]
	[FreeFunction("GUIEvent::GetType", HasExplicitThis = True)]
	[Token(Token = "0x6000013")]
	public EventType get_type() { }

	[Address(RVA = "0x30DEE50", Offset = "0x30DE250", Length = "0x33")]
	[Token(Token = "0x6000048")]
	private static EventType get_type_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DCBE0", Offset = "0x30DBFE0", Length = "0x2A")]
	[Token(Token = "0x6000021")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEngine.InputForUIModule"})]
	internal static int GetDoubleClickTime() { }

	[Address(RVA = "0x30DCC50", Offset = "0x30DC050", Length = "0x9C")]
	[Token(Token = "0x600001D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.InputForUIModule"})]
	internal static void GetEventAtIndex(int index, Event outEvent) { }

	[Address(RVA = "0x30DCC10", Offset = "0x30DC010", Length = "0x40")]
	[Token(Token = "0x6000050")]
	private static void GetEventAtIndex_Injected(int index, IntPtr outEvent) { }

	[Address(RVA = "0x30DCCF0", Offset = "0x30DC0F0", Length = "0x2A")]
	[Token(Token = "0x600001E")]
	public static int GetEventCount() { }

	[Address(RVA = "0x30DCD20", Offset = "0x30DC120", Length = "0x180")]
	[Token(Token = "0x6000033")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30DCEF0", Offset = "0x30DC2F0", Length = "0x58")]
	[FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = True)]
	[Token(Token = "0x600001A")]
	public EventType GetTypeForControl(int controlID) { }

	[Address(RVA = "0x30DCEB0", Offset = "0x30DC2B0", Length = "0x40")]
	[Token(Token = "0x600004D")]
	private static EventType GetTypeForControl_Injected(IntPtr _unity_self, int controlID) { }

	[Address(RVA = "0x30DCF50", Offset = "0x30DC350", Length = "0x31")]
	[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = True)]
	[Token(Token = "0x6000018")]
	private static IntPtr Internal_Create(int displayIndex) { }

	[Address(RVA = "0x30DCF90", Offset = "0x30DC390", Length = "0x33")]
	[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = True)]
	[Token(Token = "0x6000019")]
	private static void Internal_Destroy(IntPtr ptr) { }

	[Address(RVA = "0x30DCFD0", Offset = "0x30DC3D0", Length = "0x170")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000020")]
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	[Address(RVA = "0x30DD150", Offset = "0x30DC550", Length = "0x33")]
	[Token(Token = "0x600001F")]
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[Address(RVA = "0x30DD1D0", Offset = "0x30DC5D0", Length = "0x51")]
	[NativeMethod("Use")]
	[Token(Token = "0x6000017")]
	private void Internal_Use() { }

	[Address(RVA = "0x30DD190", Offset = "0x30DC590", Length = "0x33")]
	[Token(Token = "0x600004C")]
	private static void Internal_Use_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30DD270", Offset = "0x30DC670", Length = "0x8F")]
	[Token(Token = "0x600001C")]
	public static bool PopEvent(Event outEvent) { }

	[Address(RVA = "0x30DD230", Offset = "0x30DC630", Length = "0x33")]
	[Token(Token = "0x600004F")]
	private static bool PopEvent_Injected(IntPtr outEvent) { }

	[Address(RVA = "0x30DEF40", Offset = "0x30DE340", Length = "0x1BB")]
	[FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = True)]
	[Token(Token = "0x6000016")]
	public void set_commandName(string value) { }

	[Address(RVA = "0x30DEEF0", Offset = "0x30DE2F0", Length = "0x42")]
	[Token(Token = "0x600004B")]
	private static void set_commandName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x30DF100", Offset = "0x30DE500", Length = "0xAB")]
	[Token(Token = "0x600002E")]
	public static void set_current(Event value) { }

	[Address(RVA = "0x30DF200", Offset = "0x30DE600", Length = "0x5B")]
	[Token(Token = "0x6000005")]
	public void set_delta(Vector2 value) { }

	[Address(RVA = "0x30DF1B0", Offset = "0x30DE5B0", Length = "0x42")]
	[Token(Token = "0x600003B")]
	private static void set_delta_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x30DF2A0", Offset = "0x30DE6A0", Length = "0x58")]
	[Token(Token = "0x6000012")]
	public void set_displayIndex(int value) { }

	[Address(RVA = "0x30DF260", Offset = "0x30DE660", Length = "0x40")]
	[Token(Token = "0x6000047")]
	private static void set_displayIndex_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x30DF350", Offset = "0x30DE750", Length = "0x5B")]
	[Token(Token = "0x6000003")]
	public void set_mousePosition(Vector2 value) { }

	[Address(RVA = "0x30DF300", Offset = "0x30DE700", Length = "0x42")]
	[Token(Token = "0x6000039")]
	private static void set_mousePosition_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x30DF3F0", Offset = "0x30DE7F0", Length = "0x58")]
	[FreeFunction("GUIEvent::SetType", HasExplicitThis = True)]
	[Token(Token = "0x6000014")]
	public void set_type(EventType value) { }

	[Address(RVA = "0x30DF3B0", Offset = "0x30DE7B0", Length = "0x40")]
	[Token(Token = "0x6000049")]
	private static void set_type_Injected(IntPtr _unity_self, EventType value) { }

	[Address(RVA = "0x30DD300", Offset = "0x30DC700", Length = "0x772")]
	[Token(Token = "0x6000035")]
	public virtual string ToString() { }

	[Address(RVA = "0x30DDA80", Offset = "0x30DCE80", Length = "0x18E")]
	[Token(Token = "0x6000036")]
	public void Use() { }

}

