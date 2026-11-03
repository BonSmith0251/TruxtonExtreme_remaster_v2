namespace UnityEngine;

[NativeHeader("Runtime/Input/InputBindings.h")]
[Token(Token = "0x200000A")]
public class Input
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400002E")]
	private static bool <simulateTouchEnabled>k__BackingField; //Field offset: 0x0

	[NativeThrows]
	[Token(Token = "0x1700000F")]
	public static bool anyKey
	{
		[Address(RVA = "0x31112A0", Offset = "0x31106A0", Length = "0x2A")]
		[Token(Token = "0x6000021")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000014")]
	public static Vector2 compositionCursorPos
	{
		[Address(RVA = "0x3111310", Offset = "0x3110710", Length = "0x3B")]
		[Token(Token = "0x6000027")]
		 get { } //Length: 59
		[Address(RVA = "0x3111850", Offset = "0x3110C50", Length = "0x34")]
		[Token(Token = "0x6000028")]
		 set { } //Length: 52
	}

	[Token(Token = "0x17000013")]
	public static string compositionString
	{
		[Address(RVA = "0x3111390", Offset = "0x3110790", Length = "0xA4")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 164
	}

	[Token(Token = "0x17000012")]
	public static IMECompositionMode imeCompositionMode
	{
		[Address(RVA = "0x3111440", Offset = "0x3110840", Length = "0x2A")]
		[Token(Token = "0x6000024")]
		 get { } //Length: 42
		[Address(RVA = "0x3111890", Offset = "0x3110C90", Length = "0x31")]
		[Token(Token = "0x6000025")]
		 set { } //Length: 49
	}

	[NativeThrows]
	[Token(Token = "0x17000010")]
	public static Vector3 mousePosition
	{
		[Address(RVA = "0x31114B0", Offset = "0x31108B0", Length = "0x3E")]
		[Token(Token = "0x6000022")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000016")]
	public static bool mousePresent
	{
		[Address(RVA = "0x31114F0", Offset = "0x31108F0", Length = "0x6D")]
		[Token(Token = "0x600002C")]
		 get { } //Length: 109
	}

	[NativeThrows]
	[Token(Token = "0x17000011")]
	public static Vector2 mouseScrollDelta
	{
		[Address(RVA = "0x31115A0", Offset = "0x31109A0", Length = "0x3B")]
		[Token(Token = "0x6000023")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000019")]
	public static bool multiTouchEnabled
	{
		[Address(RVA = "0x31118D0", Offset = "0x3110CD0", Length = "0x33")]
		[FreeFunction("SetMultiTouchEnabled")]
		[Token(Token = "0x600002F")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000015")]
	internal static bool simulateTouchEnabled
	{
		[Address(RVA = "0x31115E0", Offset = "0x31109E0", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x6000029")]
		internal get { } //Length: 54
	}

	[Token(Token = "0x17000018")]
	public static int touchCount
	{
		[Address(RVA = "0x3111620", Offset = "0x3110A20", Length = "0x2A")]
		[FreeFunction("GetTouchCount")]
		[Token(Token = "0x600002E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700001A")]
	public static Touch[] touches
	{
		[Address(RVA = "0x31116C0", Offset = "0x3110AC0", Length = "0x14B")]
		[Token(Token = "0x6000030")]
		 get { } //Length: 331
	}

	[Token(Token = "0x17000017")]
	public static bool touchSupported
	{
		[Address(RVA = "0x3111650", Offset = "0x3110A50", Length = "0x70")]
		[Token(Token = "0x600002D")]
		 get { } //Length: 112
	}

	[Address(RVA = "0x3110F80", Offset = "0x3110380", Length = "0x2A")]
	[Token(Token = "0x6000031")]
	internal static bool CheckDisabled() { }

	[Address(RVA = "0x3110FB0", Offset = "0x31103B0", Length = "0x2A")]
	[NativeThrows]
	[Token(Token = "0x600001F")]
	public static void ClearLastPenContactEvent() { }

	[Address(RVA = "0x31112A0", Offset = "0x31106A0", Length = "0x2A")]
	[Token(Token = "0x6000021")]
	public static bool get_anyKey() { }

	[Address(RVA = "0x3111310", Offset = "0x3110710", Length = "0x3B")]
	[Token(Token = "0x6000027")]
	public static Vector2 get_compositionCursorPos() { }

	[Address(RVA = "0x31112D0", Offset = "0x31106D0", Length = "0x33")]
	[Token(Token = "0x6000037")]
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	[Address(RVA = "0x3111390", Offset = "0x3110790", Length = "0xA4")]
	[Token(Token = "0x6000026")]
	public static string get_compositionString() { }

	[Address(RVA = "0x3111350", Offset = "0x3110750", Length = "0x33")]
	[Token(Token = "0x6000036")]
	private static void get_compositionString_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3111440", Offset = "0x3110840", Length = "0x2A")]
	[Token(Token = "0x6000024")]
	public static IMECompositionMode get_imeCompositionMode() { }

	[Address(RVA = "0x31114B0", Offset = "0x31108B0", Length = "0x3E")]
	[Token(Token = "0x6000022")]
	public static Vector3 get_mousePosition() { }

	[Address(RVA = "0x3111470", Offset = "0x3110870", Length = "0x33")]
	[Token(Token = "0x6000034")]
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	[Address(RVA = "0x31114F0", Offset = "0x31108F0", Length = "0x6D")]
	[Token(Token = "0x600002C")]
	public static bool get_mousePresent() { }

	[Address(RVA = "0x31115A0", Offset = "0x31109A0", Length = "0x3B")]
	[Token(Token = "0x6000023")]
	public static Vector2 get_mouseScrollDelta() { }

	[Address(RVA = "0x3111560", Offset = "0x3110960", Length = "0x33")]
	[Token(Token = "0x6000035")]
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	[Address(RVA = "0x31115E0", Offset = "0x31109E0", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6000029")]
	internal static bool get_simulateTouchEnabled() { }

	[Address(RVA = "0x3111620", Offset = "0x3110A20", Length = "0x2A")]
	[FreeFunction("GetTouchCount")]
	[Token(Token = "0x600002E")]
	public static int get_touchCount() { }

	[Address(RVA = "0x31116C0", Offset = "0x3110AC0", Length = "0x14B")]
	[Token(Token = "0x6000030")]
	public static Touch[] get_touches() { }

	[Address(RVA = "0x3111650", Offset = "0x3110A50", Length = "0x70")]
	[Token(Token = "0x600002D")]
	public static bool get_touchSupported() { }

	[Address(RVA = "0x3110FF0", Offset = "0x31103F0", Length = "0x7")]
	[Token(Token = "0x6000016")]
	public static float GetAxis(string axisName) { }

	[Address(RVA = "0x3110FE0", Offset = "0x31103E0", Length = "0x7")]
	[Token(Token = "0x6000017")]
	public static float GetAxisRaw(string axisName) { }

	[Address(RVA = "0x3111000", Offset = "0x3110400", Length = "0x7")]
	[Token(Token = "0x6000018")]
	public static bool GetButtonDown(string buttonName) { }

	[Address(RVA = "0x3111010", Offset = "0x3110410", Length = "0x31")]
	[Token(Token = "0x6000020")]
	public static bool GetKey(KeyCode key) { }

	[Address(RVA = "0x3111010", Offset = "0x3110410", Length = "0x31")]
	[NativeThrows]
	[Token(Token = "0x6000019")]
	private static bool GetKeyInt(KeyCode key) { }

	[Address(RVA = "0x3111090", Offset = "0x3110490", Length = "0x46")]
	[NativeThrows]
	[Token(Token = "0x600001E")]
	public static PenData GetLastPenContactEvent() { }

	[Address(RVA = "0x3111050", Offset = "0x3110450", Length = "0x33")]
	[Token(Token = "0x6000033")]
	private static void GetLastPenContactEvent_Injected(out PenData ret) { }

	[Address(RVA = "0x3111160", Offset = "0x3110560", Length = "0x31")]
	[NativeThrows]
	[Token(Token = "0x600001A")]
	public static bool GetMouseButton(int button) { }

	[Address(RVA = "0x31110E0", Offset = "0x31104E0", Length = "0x31")]
	[NativeThrows]
	[Token(Token = "0x600001B")]
	public static bool GetMouseButtonDown(int button) { }

	[Address(RVA = "0x3111120", Offset = "0x3110520", Length = "0x31")]
	[NativeThrows]
	[Token(Token = "0x600001C")]
	public static bool GetMouseButtonUp(int button) { }

	[Address(RVA = "0x31111A0", Offset = "0x31105A0", Length = "0x2A")]
	[FreeFunction("GetMousePresent")]
	[Token(Token = "0x600002A")]
	private static bool GetMousePresentInternal() { }

	[Address(RVA = "0x3111240", Offset = "0x3110640", Length = "0x5A")]
	[NativeThrows]
	[Token(Token = "0x600001D")]
	public static Touch GetTouch(int index) { }

	[Address(RVA = "0x3111200", Offset = "0x3110600", Length = "0x40")]
	[Token(Token = "0x6000032")]
	private static void GetTouch_Injected(int index, out Touch ret) { }

	[Address(RVA = "0x31111D0", Offset = "0x31105D0", Length = "0x2A")]
	[FreeFunction("IsTouchSupported")]
	[Token(Token = "0x600002B")]
	private static bool GetTouchSupportedInternal() { }

	[Address(RVA = "0x3111850", Offset = "0x3110C50", Length = "0x34")]
	[Token(Token = "0x6000028")]
	public static void set_compositionCursorPos(Vector2 value) { }

	[Address(RVA = "0x3111810", Offset = "0x3110C10", Length = "0x33")]
	[Token(Token = "0x6000038")]
	private static void set_compositionCursorPos_Injected(in Vector2 value) { }

	[Address(RVA = "0x3111890", Offset = "0x3110C90", Length = "0x31")]
	[Token(Token = "0x6000025")]
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	[Address(RVA = "0x31118D0", Offset = "0x3110CD0", Length = "0x33")]
	[FreeFunction("SetMultiTouchEnabled")]
	[Token(Token = "0x600002F")]
	public static void set_multiTouchEnabled(bool value) { }

}

