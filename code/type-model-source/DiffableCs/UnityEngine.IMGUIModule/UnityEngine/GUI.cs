namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
[Token(Token = "0x2000008")]
public class GUI
{
	[Token(Token = "0x2000009")]
	internal sealed class WindowFunction : MulticastDelegate
	{

		[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
		[Token(Token = "0x6000084")]
		public WindowFunction(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000085")]
		public override void Invoke(int id) { }

	}

	[Token(Token = "0x400003D")]
	private static int s_ScrollControlId; //Field offset: 0x0
	[Token(Token = "0x400003E")]
	private static int s_HotTextField; //Field offset: 0x4
	[Token(Token = "0x400003F")]
	private static readonly int s_BoxHash; //Field offset: 0x8
	[Token(Token = "0x4000040")]
	private static readonly int s_ButonHash; //Field offset: 0xC
	[Token(Token = "0x4000041")]
	private static readonly int s_RepeatButtonHash; //Field offset: 0x10
	[Token(Token = "0x4000042")]
	private static readonly int s_ToggleHash; //Field offset: 0x14
	[Token(Token = "0x4000043")]
	private static readonly int s_ButtonGridHash; //Field offset: 0x18
	[Token(Token = "0x4000044")]
	private static readonly int s_SliderHash; //Field offset: 0x1C
	[Token(Token = "0x4000045")]
	private static readonly int s_BeginGroupHash; //Field offset: 0x20
	[Token(Token = "0x4000046")]
	private static readonly int s_ScrollviewHash; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000047")]
	private static int <scrollTroughSide>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000048")]
	private static DateTime <nextScrollStepTime>k__BackingField; //Field offset: 0x30
	[Token(Token = "0x4000049")]
	private static GUISkin s_Skin; //Field offset: 0x38
	[Token(Token = "0x400004A")]
	internal static Rect s_ToolTipRect; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400004B")]
	private static GenericStack <scrollViewStates>k__BackingField; //Field offset: 0x50

	[Token(Token = "0x17000022")]
	public static Color backgroundColor
	{
		[Address(RVA = "0x30F49D0", Offset = "0x30F3DD0", Length = "0x6D")]
		[Token(Token = "0x600005B")]
		 get { } //Length: 109
		[Address(RVA = "0x30F4E70", Offset = "0x30F4270", Length = "0x64")]
		[Token(Token = "0x600005C")]
		 set { } //Length: 100
	}

	[Token(Token = "0x17000024")]
	public static bool changed
	{
		[Address(RVA = "0x30F4A40", Offset = "0x30F3E40", Length = "0x2A")]
		[Token(Token = "0x600005F")]
		 get { } //Length: 42
		[Address(RVA = "0x30F4EE0", Offset = "0x30F42E0", Length = "0x33")]
		[Token(Token = "0x6000060")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000021")]
	public static Color color
	{
		[Address(RVA = "0x30F4AB0", Offset = "0x30F3EB0", Length = "0x6D")]
		[Token(Token = "0x6000059")]
		 get { } //Length: 109
		[Address(RVA = "0x30F4F60", Offset = "0x30F4360", Length = "0x64")]
		[Token(Token = "0x600005A")]
		 set { } //Length: 100
	}

	[Token(Token = "0x17000023")]
	public static Color contentColor
	{
		[Address(RVA = "0x30F4B60", Offset = "0x30F3F60", Length = "0x6D")]
		[Token(Token = "0x600005D")]
		 get { } //Length: 109
		[Address(RVA = "0x30F5010", Offset = "0x30F4410", Length = "0x64")]
		[Token(Token = "0x600005E")]
		 set { } //Length: 100
	}

	[Token(Token = "0x17000025")]
	public static bool enabled
	{
		[Address(RVA = "0x30F4BD0", Offset = "0x30F3FD0", Length = "0x2A")]
		[Token(Token = "0x6000061")]
		 get { } //Length: 42
		[Address(RVA = "0x30F5080", Offset = "0x30F4480", Length = "0x33")]
		[Token(Token = "0x6000062")]
		 set { } //Length: 51
	}

	[Token(Token = "0x1700002A")]
	public static Matrix4x4 matrix
	{
		[Address(RVA = "0x30F4C00", Offset = "0x30F4000", Length = "0x81")]
		[Token(Token = "0x600006D")]
		 get { } //Length: 129
		[Address(RVA = "0x30F50C0", Offset = "0x30F44C0", Length = "0x52")]
		[Token(Token = "0x600006E")]
		 set { } //Length: 82
	}

	[Token(Token = "0x17000028")]
	internal static DateTime nextScrollStepTime
	{
		[Address(RVA = "0x30F4C90", Offset = "0x30F4090", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6000068")]
		internal get { } //Length: 79
		[Address(RVA = "0x30F5120", Offset = "0x30F4520", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000069")]
		internal set { } //Length: 85
	}

	[Token(Token = "0x17000027")]
	internal static int scrollTroughSide
	{
		[Address(RVA = "0x30F4CE0", Offset = "0x30F40E0", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x6000066")]
		internal get { } //Length: 78
		[Address(RVA = "0x30F5180", Offset = "0x30F4580", Length = "0x53")]
		[CompilerGenerated]
		[Token(Token = "0x6000067")]
		internal set { } //Length: 83
	}

	[Token(Token = "0x1700002B")]
	internal static GenericStack scrollViewStates
	{
		[Address(RVA = "0x30F4D30", Offset = "0x30F4130", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x600007C")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000029")]
	public static GUISkin skin
	{
		[Address(RVA = "0x30F4D80", Offset = "0x30F4180", Length = "0x77")]
		[Token(Token = "0x600006B")]
		 get { } //Length: 119
		[Address(RVA = "0x30F51E0", Offset = "0x30F45E0", Length = "0x71")]
		[Token(Token = "0x600006A")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000026")]
	internal static bool usePageScrollbars
	{
		[Address(RVA = "0x30F4E00", Offset = "0x30F4200", Length = "0x2A")]
		[Token(Token = "0x6000063")]
		internal get { } //Length: 42
	}

	[Address(RVA = "0x30F4680", Offset = "0x30F3A80", Length = "0x30F")]
	[Token(Token = "0x6000065")]
	private static GUI() { }

	[Address(RVA = "0x30F19E0", Offset = "0x30F0DE0", Length = "0x359")]
	[Token(Token = "0x600007A")]
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	[Address(RVA = "0x30F1D40", Offset = "0x30F1140", Length = "0xC9")]
	[Token(Token = "0x6000079")]
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	[Address(RVA = "0x30F1E10", Offset = "0x30F1210", Length = "0x20A")]
	[Token(Token = "0x6000072")]
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	[Address(RVA = "0x30F2020", Offset = "0x30F1420", Length = "0xB2")]
	[Token(Token = "0x6000071")]
	public static void Box(Rect position, string text) { }

	[Address(RVA = "0x30F20E0", Offset = "0x30F14E0", Length = "0x3D2")]
	[RequiredByNativeCode]
	[Token(Token = "0x600007D")]
	internal static void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	[Address(RVA = "0x30F24C0", Offset = "0x30F18C0", Length = "0x3F7")]
	[Token(Token = "0x6000074")]
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	[Address(RVA = "0x30F28C0", Offset = "0x30F1CC0", Length = "0x56C")]
	[Token(Token = "0x6000073")]
	private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	[Address(RVA = "0x30F2E30", Offset = "0x30F2230", Length = "0x272")]
	[Token(Token = "0x600006C")]
	internal static void DoSetSkin(GUISkin newSkin) { }

	[Address(RVA = "0x30F30B0", Offset = "0x30F24B0", Length = "0x62")]
	[Token(Token = "0x600007B")]
	public static void EndGroup() { }

	[Address(RVA = "0x30F49D0", Offset = "0x30F3DD0", Length = "0x6D")]
	[Token(Token = "0x600005B")]
	public static Color get_backgroundColor() { }

	[Address(RVA = "0x30F4990", Offset = "0x30F3D90", Length = "0x33")]
	[Token(Token = "0x6000080")]
	private static void get_backgroundColor_Injected(out Color ret) { }

	[Address(RVA = "0x30F4A40", Offset = "0x30F3E40", Length = "0x2A")]
	[Token(Token = "0x600005F")]
	public static bool get_changed() { }

	[Address(RVA = "0x30F4AB0", Offset = "0x30F3EB0", Length = "0x6D")]
	[Token(Token = "0x6000059")]
	public static Color get_color() { }

	[Address(RVA = "0x30F4A70", Offset = "0x30F3E70", Length = "0x33")]
	[Token(Token = "0x600007E")]
	private static void get_color_Injected(out Color ret) { }

	[Address(RVA = "0x30F4B60", Offset = "0x30F3F60", Length = "0x6D")]
	[Token(Token = "0x600005D")]
	public static Color get_contentColor() { }

	[Address(RVA = "0x30F4B20", Offset = "0x30F3F20", Length = "0x33")]
	[Token(Token = "0x6000082")]
	private static void get_contentColor_Injected(out Color ret) { }

	[Address(RVA = "0x30F4BD0", Offset = "0x30F3FD0", Length = "0x2A")]
	[Token(Token = "0x6000061")]
	public static bool get_enabled() { }

	[Address(RVA = "0x30F4C00", Offset = "0x30F4000", Length = "0x81")]
	[Token(Token = "0x600006D")]
	public static Matrix4x4 get_matrix() { }

	[Address(RVA = "0x30F4C90", Offset = "0x30F4090", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6000068")]
	internal static DateTime get_nextScrollStepTime() { }

	[Address(RVA = "0x30F4CE0", Offset = "0x30F40E0", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x6000066")]
	internal static int get_scrollTroughSide() { }

	[Address(RVA = "0x30F4D30", Offset = "0x30F4130", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x600007C")]
	internal static GenericStack get_scrollViewStates() { }

	[Address(RVA = "0x30F4D80", Offset = "0x30F4180", Length = "0x77")]
	[Token(Token = "0x600006B")]
	public static GUISkin get_skin() { }

	[Address(RVA = "0x30F4E00", Offset = "0x30F4200", Length = "0x2A")]
	[Token(Token = "0x6000063")]
	internal static bool get_usePageScrollbars() { }

	[Address(RVA = "0x30F3120", Offset = "0x30F2520", Length = "0x244")]
	[Token(Token = "0x6000076")]
	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { }

	[Address(RVA = "0x30F3370", Offset = "0x30F2770", Length = "0x2A")]
	[Token(Token = "0x6000064")]
	internal static void InternalRepaintEditorWindow() { }

	[Address(RVA = "0x30F33A0", Offset = "0x30F27A0", Length = "0x11F")]
	[Token(Token = "0x600006F")]
	public static void Label(Rect position, string text) { }

	[Address(RVA = "0x30F34C0", Offset = "0x30F28C0", Length = "0x9C")]
	[Token(Token = "0x6000070")]
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	[Address(RVA = "0x30F38A0", Offset = "0x30F2CA0", Length = "0xB4D")]
	[Token(Token = "0x6000078")]
	internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) { }

	[Address(RVA = "0x30F3560", Offset = "0x30F2960", Length = "0x334")]
	[Token(Token = "0x6000077")]
	internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) { }

	[Address(RVA = "0x30F4E70", Offset = "0x30F4270", Length = "0x64")]
	[Token(Token = "0x600005C")]
	public static void set_backgroundColor(Color value) { }

	[Address(RVA = "0x30F4E30", Offset = "0x30F4230", Length = "0x33")]
	[Token(Token = "0x6000081")]
	private static void set_backgroundColor_Injected(in Color value) { }

	[Address(RVA = "0x30F4EE0", Offset = "0x30F42E0", Length = "0x33")]
	[Token(Token = "0x6000060")]
	public static void set_changed(bool value) { }

	[Address(RVA = "0x30F4F60", Offset = "0x30F4360", Length = "0x64")]
	[Token(Token = "0x600005A")]
	public static void set_color(Color value) { }

	[Address(RVA = "0x30F4F20", Offset = "0x30F4320", Length = "0x33")]
	[Token(Token = "0x600007F")]
	private static void set_color_Injected(in Color value) { }

	[Address(RVA = "0x30F5010", Offset = "0x30F4410", Length = "0x64")]
	[Token(Token = "0x600005E")]
	public static void set_contentColor(Color value) { }

	[Address(RVA = "0x30F4FD0", Offset = "0x30F43D0", Length = "0x33")]
	[Token(Token = "0x6000083")]
	private static void set_contentColor_Injected(in Color value) { }

	[Address(RVA = "0x30F5080", Offset = "0x30F4480", Length = "0x33")]
	[Token(Token = "0x6000062")]
	public static void set_enabled(bool value) { }

	[Address(RVA = "0x30F50C0", Offset = "0x30F44C0", Length = "0x52")]
	[Token(Token = "0x600006E")]
	public static void set_matrix(Matrix4x4 value) { }

	[Address(RVA = "0x30F5120", Offset = "0x30F4520", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000069")]
	internal static void set_nextScrollStepTime(DateTime value) { }

	[Address(RVA = "0x30F5180", Offset = "0x30F4580", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x6000067")]
	internal static void set_scrollTroughSide(int value) { }

	[Address(RVA = "0x30F51E0", Offset = "0x30F45E0", Length = "0x71")]
	[Token(Token = "0x600006A")]
	public static void set_skin(GUISkin value) { }

	[Address(RVA = "0x30F43F0", Offset = "0x30F37F0", Length = "0x28F")]
	[Token(Token = "0x6000075")]
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null) { }

}

