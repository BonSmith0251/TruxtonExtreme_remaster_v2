namespace UnityEngine;

[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
[NativeHeader("Runtime/Utilities/CopyPaste.h")]
[NativeHeader("Modules/IMGUI/GUIManager.h")]
[NativeHeader("Modules/IMGUI/GUIUtility.h")]
[NativeHeader("Runtime/Input/InputBindings.h")]
[Token(Token = "0x200001F")]
public class GUIUtility
{
	[Token(Token = "0x40000B9")]
	internal static int s_ControlCount; //Field offset: 0x0
	[Token(Token = "0x40000BA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int s_SkinMode; //Field offset: 0x4
	[Token(Token = "0x40000BB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int s_OriginalID; //Field offset: 0x8
	[Token(Token = "0x40000BC")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Action takeCapture; //Field offset: 0x10
	[Token(Token = "0x40000BD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Action releaseCapture; //Field offset: 0x18
	[Token(Token = "0x40000BE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Func<Int32, IntPtr, Boolean> processEvent; //Field offset: 0x20
	[Token(Token = "0x40000BF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Action cleanupRoots; //Field offset: 0x28
	[Token(Token = "0x40000C0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Func<Exception, Boolean> endContainerGUIFromException; //Field offset: 0x30
	[Token(Token = "0x40000C1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Action guiChanged; //Field offset: 0x38
	[Token(Token = "0x40000C2")]
	internal static Action<EventType, KeyCode, EventModifiers> beforeEventProcessed; //Field offset: 0x40
	[Token(Token = "0x40000C3")]
	private static Event m_Event; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40000C4")]
	private static bool <guiIsExiting>k__BackingField; //Field offset: 0x50
	[Token(Token = "0x40000C5")]
	internal static Func<Boolean> s_HasCurrentWindowKeyFocusFunc; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40000C6")]
	private static bool <isUITK>k__BackingField; //Field offset: 0x60

	[StaticAccessor("InputBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x1700006B")]
	internal static Vector2 compositionCursorPos
	{
		[Address(RVA = "0x30F10E0", Offset = "0x30F04E0", Length = "0x65")]
		[Token(Token = "0x6000186")]
		internal set { } //Length: 101
	}

	[StaticAccessor("InputBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x17000069")]
	internal static string compositionString
	{
		[Address(RVA = "0x30F0D00", Offset = "0x30F0100", Length = "0xDE")]
		[Token(Token = "0x6000184")]
		internal get { } //Length: 222
	}

	[NativeProperty("GetGUIState().m_OnGUIDepth", True, TargetType::Field (1))]
	[Token(Token = "0x17000065")]
	internal static int guiDepth
	{
		[Address(RVA = "0x30F0DE0", Offset = "0x30F01E0", Length = "0x2A")]
		[Token(Token = "0x6000174")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 42
	}

	[Token(Token = "0x1700006C")]
	internal static bool guiIsExiting
	{
		[Address(RVA = "0x30F1150", Offset = "0x30F0550", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x6000190")]
		internal set { } //Length: 84
	}

	[Token(Token = "0x1700006D")]
	public static int hotControl
	{
		[Address(RVA = "0x30F0E10", Offset = "0x30F0210", Length = "0x5B")]
		[Token(Token = "0x6000191")]
		 get { } //Length: 91
		[Address(RVA = "0x30F11B0", Offset = "0x30F05B0", Length = "0x62")]
		[Token(Token = "0x6000192")]
		 set { } //Length: 98
	}

	[StaticAccessor("InputBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x1700006A")]
	internal static IMECompositionMode imeCompositionMode
	{
		[Address(RVA = "0x30F1220", Offset = "0x30F0620", Length = "0x31")]
		[Token(Token = "0x6000185")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 49
	}

	[Token(Token = "0x1700006F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool isUITK
	{
		[Address(RVA = "0x30F0E70", Offset = "0x30F0270", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x60001A4")]
		internal get { } //Length: 79
		[Address(RVA = "0x30F1260", Offset = "0x30F0660", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x60001A5")]
		internal set { } //Length: 84
	}

	[Token(Token = "0x1700006E")]
	public static int keyboardControl
	{
		[Address(RVA = "0x30F0EC0", Offset = "0x30F02C0", Length = "0x5B")]
		[Token(Token = "0x6000195")]
		 get { } //Length: 91
		[Address(RVA = "0x30F12C0", Offset = "0x30F06C0", Length = "0x62")]
		[Token(Token = "0x6000196")]
		 set { } //Length: 98
	}

	[NativeProperty("GetGUIState().m_CanvasGUIState.m_IsMouseUsed", True, TargetType::Field (1))]
	[Token(Token = "0x17000066")]
	internal static bool mouseUsed
	{
		[Address(RVA = "0x30F1330", Offset = "0x30F0730", Length = "0x33")]
		[Token(Token = "0x6000175")]
		internal set { } //Length: 51
	}

	[NativeProperty("GetGUIState().m_PixelsPerPoint", True, TargetType::Field (1))]
	[Token(Token = "0x17000064")]
	internal static float pixelsPerPoint
	{
		[Address(RVA = "0x30F0F20", Offset = "0x30F0320", Length = "0x2A")]
		[Token(Token = "0x6000172")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIToolkitAuthoringModule"})]
		internal get { } //Length: 42
		[Address(RVA = "0x30F1370", Offset = "0x30F0770", Length = "0x3A")]
		[Token(Token = "0x6000173")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 58
	}

	[Token(Token = "0x17000068")]
	public static string systemCopyBuffer
	{
		[Address(RVA = "0x30F0F90", Offset = "0x30F0390", Length = "0xDE")]
		[FreeFunction("GetCopyBuffer")]
		[Token(Token = "0x6000177")]
		 get { } //Length: 222
		[Address(RVA = "0x30F13F0", Offset = "0x30F07F0", Length = "0x199")]
		[FreeFunction("SetCopyBuffer")]
		[Token(Token = "0x6000178")]
		 set { } //Length: 409
	}

	[StaticAccessor("GetInputManager()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x17000067")]
	internal static bool textFieldInput
	{
		[Address(RVA = "0x30F1070", Offset = "0x30F0470", Length = "0x2A")]
		[Token(Token = "0x6000176")]
		internal get { } //Length: 42
	}

	[Address(RVA = "0x30F0BF0", Offset = "0x30EFFF0", Length = "0xC6")]
	[Token(Token = "0x60001AC")]
	private static GUIUtility() { }

	[Address(RVA = "0x30EEC60", Offset = "0x30EE060", Length = "0xDC")]
	[Token(Token = "0x60001A8")]
	public static Rect AlignRectToDevice(Rect rect) { }

	[Address(RVA = "0x30EEBC0", Offset = "0x30EDFC0", Length = "0x9C")]
	[Token(Token = "0x6000183")]
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[Address(RVA = "0x30EEB50", Offset = "0x30EDF50", Length = "0x62")]
	[Token(Token = "0x60001B3")]
	private static void AlignRectToDevice_Injected(in Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	[Address(RVA = "0x30EEE50", Offset = "0x30EE250", Length = "0x6F")]
	[Token(Token = "0x600017C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[Address(RVA = "0x30EEE10", Offset = "0x30EE210", Length = "0x33")]
	[Token(Token = "0x60001B1")]
	private static void BeginContainer_Injected(IntPtr objectGUIState) { }

	[Address(RVA = "0x30EED80", Offset = "0x30EE180", Length = "0x8C")]
	[Token(Token = "0x600017B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[Address(RVA = "0x30EED40", Offset = "0x30EE140", Length = "0x33")]
	[Token(Token = "0x60001B0")]
	private static void BeginContainerFromOwner_Injected(IntPtr owner) { }

	[Address(RVA = "0x30EEEC0", Offset = "0x30EE2C0", Length = "0x227")]
	[RequiredByNativeCode]
	[Token(Token = "0x600019C")]
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[Address(RVA = "0x30EF130", Offset = "0x30EE530", Length = "0x6F")]
	[Token(Token = "0x600017E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int CheckForTabEvent(Event evt) { }

	[Address(RVA = "0x30EF0F0", Offset = "0x30EE4F0", Length = "0x33")]
	[Token(Token = "0x60001B2")]
	private static int CheckForTabEvent_Injected(IntPtr evt) { }

	[Address(RVA = "0x30EF1A0", Offset = "0x30EE5A0", Length = "0xB1")]
	[Token(Token = "0x60001A6")]
	internal static void CheckOnGUI() { }

	[Address(RVA = "0x30EF260", Offset = "0x30EE660", Length = "0xD2")]
	[RequiredByNativeCode]
	[Token(Token = "0x600019D")]
	internal static void DestroyGUI(int instanceID) { }

	[Address(RVA = "0x30EF3E0", Offset = "0x30EE7E0", Length = "0x7C")]
	[Token(Token = "0x600019B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void EndContainer() { }

	[Address(RVA = "0x30EF340", Offset = "0x30EE740", Length = "0x98")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001A0")]
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[Address(RVA = "0x30EF560", Offset = "0x30EE960", Length = "0x1CA")]
	[RequiredByNativeCode]
	[Token(Token = "0x600019E")]
	internal static void EndGUI(int layoutType) { }

	[Address(RVA = "0x30EF460", Offset = "0x30EE860", Length = "0xFA")]
	[RequiredByNativeCode]
	[Token(Token = "0x600019F")]
	internal static bool EndGUIFromException(Exception exception) { }

	[Address(RVA = "0x30EF730", Offset = "0x30EEB30", Length = "0x52")]
	[Token(Token = "0x6000198")]
	public static void ExitGUI() { }

	[Address(RVA = "0x30F0D00", Offset = "0x30F0100", Length = "0xDE")]
	[Token(Token = "0x6000184")]
	internal static string get_compositionString() { }

	[Address(RVA = "0x30F0CC0", Offset = "0x30F00C0", Length = "0x33")]
	[Token(Token = "0x60001B4")]
	private static void get_compositionString_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x30F0DE0", Offset = "0x30F01E0", Length = "0x2A")]
	[Token(Token = "0x6000174")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int get_guiDepth() { }

	[Address(RVA = "0x30F0E10", Offset = "0x30F0210", Length = "0x5B")]
	[Token(Token = "0x6000191")]
	public static int get_hotControl() { }

	[Address(RVA = "0x30F0E70", Offset = "0x30F0270", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x60001A4")]
	internal static bool get_isUITK() { }

	[Address(RVA = "0x30F0EC0", Offset = "0x30F02C0", Length = "0x5B")]
	[Token(Token = "0x6000195")]
	public static int get_keyboardControl() { }

	[Address(RVA = "0x30F0F20", Offset = "0x30F0320", Length = "0x2A")]
	[Token(Token = "0x6000172")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIToolkitAuthoringModule"})]
	internal static float get_pixelsPerPoint() { }

	[Address(RVA = "0x30F0F90", Offset = "0x30F0390", Length = "0xDE")]
	[FreeFunction("GetCopyBuffer")]
	[Token(Token = "0x6000177")]
	public static string get_systemCopyBuffer() { }

	[Address(RVA = "0x30F0F50", Offset = "0x30F0350", Length = "0x33")]
	[Token(Token = "0x60001AD")]
	private static void get_systemCopyBuffer_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x30F1070", Offset = "0x30F0470", Length = "0x2A")]
	[Token(Token = "0x6000176")]
	internal static bool get_textFieldInput() { }

	[Address(RVA = "0x30EF790", Offset = "0x30EEB90", Length = "0x164")]
	[Token(Token = "0x600018E")]
	public static int GetControlID(int hint, FocusType focus) { }

	[Address(RVA = "0x30EF900", Offset = "0x30EED00", Length = "0xCE")]
	[Token(Token = "0x600017A")]
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[Address(RVA = "0x30EF9D0", Offset = "0x30EEDD0", Length = "0x9E")]
	[Token(Token = "0x6000199")]
	internal static GUISkin GetDefaultSkin() { }

	[Address(RVA = "0x30EFA70", Offset = "0x30EEE70", Length = "0x174")]
	[Token(Token = "0x600018F")]
	public static object GetStateObject(Type t, int controlID) { }

	[Address(RVA = "0x30EFBF0", Offset = "0x30EEFF0", Length = "0x2A")]
	[Token(Token = "0x6000181")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool HasFocusableControls() { }

	[Address(RVA = "0x30EFC20", Offset = "0x30EF020", Length = "0x11C")]
	[Token(Token = "0x6000197")]
	internal static bool HasKeyFocus(int controlID) { }

	[Address(RVA = "0x30EFFB0", Offset = "0x30EF3B0", Length = "0x119")]
	[Token(Token = "0x60001A9")]
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	[Address(RVA = "0x30EFD40", Offset = "0x30EF140", Length = "0x263")]
	[Token(Token = "0x60001AB")]
	internal static bool HitTest(Rect rect, Event evt) { }

	[Address(RVA = "0x30F00D0", Offset = "0x30EF4D0", Length = "0x14B")]
	[Token(Token = "0x60001AA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	[Address(RVA = "0x30F0220", Offset = "0x30EF620", Length = "0x2A")]
	[NativeMethod("EndContainer")]
	[Token(Token = "0x600017D")]
	internal static void Internal_EndContainer() { }

	[Address(RVA = "0x30F0250", Offset = "0x30EF650", Length = "0x2A")]
	[Token(Token = "0x600018C")]
	private static void Internal_ExitGUI() { }

	[Address(RVA = "0x30F02D0", Offset = "0x30EF6D0", Length = "0x7F")]
	[FreeFunction("GetGUIState().GetControlID")]
	[Token(Token = "0x6000179")]
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect) { }

	[Address(RVA = "0x30F0280", Offset = "0x30EF680", Length = "0x4E")]
	[Token(Token = "0x60001AF")]
	private static int Internal_GetControlID_Injected(int hint, FocusType focusType, in Rect rect) { }

	[Address(RVA = "0x30F0350", Offset = "0x30EF750", Length = "0x31")]
	[Token(Token = "0x600018B")]
	private static object Internal_GetDefaultSkin(int skinMode) { }

	[Address(RVA = "0x30F0390", Offset = "0x30EF790", Length = "0x2A")]
	[Token(Token = "0x6000187")]
	private static int Internal_GetHotControl() { }

	[Address(RVA = "0x30F03C0", Offset = "0x30EF7C0", Length = "0x2A")]
	[Token(Token = "0x6000188")]
	private static int Internal_GetKeyboardControl() { }

	[Address(RVA = "0x30F03F0", Offset = "0x30EF7F0", Length = "0x31")]
	[Token(Token = "0x6000189")]
	private static void Internal_SetHotControl(int value) { }

	[Address(RVA = "0x30F0430", Offset = "0x30EF830", Length = "0x31")]
	[Token(Token = "0x600018A")]
	private static void Internal_SetKeyboardControl(int value) { }

	[Address(RVA = "0x30F0470", Offset = "0x30EF870", Length = "0x7A")]
	[Token(Token = "0x60001A2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool IsExitGUIException(Exception exception) { }

	[Address(RVA = "0x30F04F0", Offset = "0x30EF8F0", Length = "0x67")]
	[RequiredByNativeCode]
	[Token(Token = "0x600018D")]
	private static void MarkGUIChanged() { }

	[Address(RVA = "0x30F0560", Offset = "0x30EF960", Length = "0x31")]
	[Token(Token = "0x6000182")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool OwnsId(int id) { }

	[Address(RVA = "0x30F05A0", Offset = "0x30EF9A0", Length = "0x2C1")]
	[RequiredByNativeCode]
	[Token(Token = "0x600019A")]
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result) { }

	[Address(RVA = "0x30F0870", Offset = "0x30EFC70", Length = "0x67")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000194")]
	internal static void RemoveCapture() { }

	[Address(RVA = "0x30F08E0", Offset = "0x30EFCE0", Length = "0x186")]
	[Token(Token = "0x60001A1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void ResetGlobalState() { }

	[Address(RVA = "0x30F10E0", Offset = "0x30F04E0", Length = "0x65")]
	[Token(Token = "0x6000186")]
	internal static void set_compositionCursorPos(Vector2 value) { }

	[Address(RVA = "0x30F10A0", Offset = "0x30F04A0", Length = "0x33")]
	[Token(Token = "0x60001B5")]
	private static void set_compositionCursorPos_Injected(in Vector2 value) { }

	[Address(RVA = "0x30F1150", Offset = "0x30F0550", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x6000190")]
	internal static void set_guiIsExiting(bool value) { }

	[Address(RVA = "0x30F11B0", Offset = "0x30F05B0", Length = "0x62")]
	[Token(Token = "0x6000192")]
	public static void set_hotControl(int value) { }

	[Address(RVA = "0x30F1220", Offset = "0x30F0620", Length = "0x31")]
	[Token(Token = "0x6000185")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_imeCompositionMode(IMECompositionMode value) { }

	[Address(RVA = "0x30F1260", Offset = "0x30F0660", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x60001A5")]
	internal static void set_isUITK(bool value) { }

	[Address(RVA = "0x30F12C0", Offset = "0x30F06C0", Length = "0x62")]
	[Token(Token = "0x6000196")]
	public static void set_keyboardControl(int value) { }

	[Address(RVA = "0x30F1330", Offset = "0x30F0730", Length = "0x33")]
	[Token(Token = "0x6000175")]
	internal static void set_mouseUsed(bool value) { }

	[Address(RVA = "0x30F1370", Offset = "0x30F0770", Length = "0x3A")]
	[Token(Token = "0x6000173")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_pixelsPerPoint(float value) { }

	[Address(RVA = "0x30F13F0", Offset = "0x30F07F0", Length = "0x199")]
	[FreeFunction("SetCopyBuffer")]
	[Token(Token = "0x6000178")]
	public static void set_systemCopyBuffer(string value) { }

	[Address(RVA = "0x30F13B0", Offset = "0x30F07B0", Length = "0x33")]
	[Token(Token = "0x60001AE")]
	private static void set_systemCopyBuffer_Injected(ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x30F0A70", Offset = "0x30EFE70", Length = "0x2A")]
	[Token(Token = "0x600017F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void SetKeyboardControlToFirstControlId() { }

	[Address(RVA = "0x30F0AA0", Offset = "0x30EFEA0", Length = "0x2A")]
	[Token(Token = "0x6000180")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void SetKeyboardControlToLastControlId() { }

	[Address(RVA = "0x30F0AD0", Offset = "0x30EFED0", Length = "0xAA")]
	[Token(Token = "0x60001A3")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool ShouldRethrowException(Exception exception) { }

	[Address(RVA = "0x30F0B80", Offset = "0x30EFF80", Length = "0x67")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000193")]
	internal static void TakeCapture() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001A7")]
	internal static void WarnOnGUI() { }

}

