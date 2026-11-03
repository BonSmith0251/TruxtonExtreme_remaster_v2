namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(TouchscreenState), isGenericTypeOfDevice = True)]
[Token(Token = "0x20000BE")]
public class Touchscreen : Pointer, IInputStateCallbackReceiver, IEventMerger, ICustomDeviceReset
{
	[Token(Token = "0x4000461")]
	private static readonly ProfilerMarker k_TouchscreenUpdateMarker; //Field offset: 0x0
	[Token(Token = "0x4000462")]
	private static readonly ProfilerMarker k_TouchAllocateMarker; //Field offset: 0x8
	[CompilerGenerated]
	[Token(Token = "0x4000463")]
	private static Touchscreen <current>k__BackingField; //Field offset: 0x10
	[Token(Token = "0x4000464")]
	internal static float s_TapTime; //Field offset: 0x18
	[Token(Token = "0x4000465")]
	internal static float s_TapDelayTime; //Field offset: 0x1C
	[Token(Token = "0x4000466")]
	internal static float s_TapRadiusSquared; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400045F")]
	private TouchControl <primaryTouch>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000460")]
	private ReadOnlyArray<TouchControl> <touches>k__BackingField; //Field offset: 0x1C8

	[Token(Token = "0x170002AA")]
	public internal static Touchscreen current
	{
		[Address(RVA = "0x29B3ED0", Offset = "0x29B32D0", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6000A38")]
		 get { } //Length: 79
		[Address(RVA = "0x29B3F30", Offset = "0x29B3330", Length = "0x6E")]
		[CompilerGenerated]
		[Token(Token = "0x6000A39")]
		internal set { } //Length: 110
	}

	[Token(Token = "0x170002A7")]
	public TouchControl primaryTouch
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A32")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A33")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170002A9")]
	protected TouchControl[] touchControlArray
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[Token(Token = "0x6000A36")]
		 get { } //Length: 8
		[Address(RVA = "0x29B3FA0", Offset = "0x29B33A0", Length = "0x6D")]
		[Token(Token = "0x6000A37")]
		 set { } //Length: 109
	}

	[Token(Token = "0x170002A8")]
	public ReadOnlyArray<TouchControl> touches
	{
		[Address(RVA = "0x29B3F20", Offset = "0x29B3320", Length = "0xE")]
		[CompilerGenerated]
		[Token(Token = "0x6000A34")]
		 get { } //Length: 14
		[Address(RVA = "0x29B4010", Offset = "0x29B3410", Length = "0x18")]
		[CompilerGenerated]
		[Token(Token = "0x6000A35")]
		 set { } //Length: 24
	}

	[Address(RVA = "0x29B3E30", Offset = "0x29B3230", Length = "0x98")]
	[Token(Token = "0x6000A47")]
	private static Touchscreen() { }

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000A46")]
	public Touchscreen() { }

	[Address(RVA = "0x29B22C0", Offset = "0x29B16C0", Length = "0x3BF")]
	[Token(Token = "0x6000A3C")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29B3ED0", Offset = "0x29B32D0", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6000A38")]
	public static Touchscreen get_current() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A32")]
	public TouchControl get_primaryTouch() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[Token(Token = "0x6000A36")]
	protected TouchControl[] get_touchControlArray() { }

	[Address(RVA = "0x29B3F20", Offset = "0x29B3320", Length = "0xE")]
	[CompilerGenerated]
	[Token(Token = "0x6000A34")]
	public ReadOnlyArray<TouchControl> get_touches() { }

	[Address(RVA = "0x29B2680", Offset = "0x29B1A80", Length = "0xE9")]
	[Token(Token = "0x6000A3A")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x29B2770", Offset = "0x29B1B70", Length = "0x11A")]
	[Token(Token = "0x6000A43")]
	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	[Address(RVA = "0x29B2890", Offset = "0x29B1C90", Length = "0x3DC")]
	[Token(Token = "0x6000A3D")]
	protected void OnNextUpdate() { }

	[Address(RVA = "0x29B2C70", Offset = "0x29B2070", Length = "0x102")]
	[Token(Token = "0x6000A3B")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x29B2D80", Offset = "0x29B2180", Length = "0x800")]
	[Token(Token = "0x6000A3E")]
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	[Address(RVA = "0x29B3F30", Offset = "0x29B3330", Length = "0x6E")]
	[CompilerGenerated]
	[Token(Token = "0x6000A39")]
	internal static void set_current(Touchscreen value) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A33")]
	protected void set_primaryTouch(TouchControl value) { }

	[Address(RVA = "0x29B3FA0", Offset = "0x29B33A0", Length = "0x6D")]
	[Token(Token = "0x6000A37")]
	protected void set_touchControlArray(TouchControl[] value) { }

	[Address(RVA = "0x29B4010", Offset = "0x29B3410", Length = "0x18")]
	[CompilerGenerated]
	[Token(Token = "0x6000A35")]
	protected void set_touches(ReadOnlyArray<TouchControl> value) { }

	[Address(RVA = "0x29B3590", Offset = "0x29B2990", Length = "0xBE")]
	[Token(Token = "0x6000A45")]
	private static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr) { }

	[Address(RVA = "0x29B3650", Offset = "0x29B2A50", Length = "0x3B3")]
	[Token(Token = "0x6000A42")]
	private override void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset() { }

	[Address(RVA = "0x29B3A10", Offset = "0x29B2E10", Length = "0x151")]
	[Token(Token = "0x6000A44")]
	private override bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	[Address(RVA = "0x29B3B70", Offset = "0x29B2F70", Length = "0x292")]
	[Token(Token = "0x6000A41")]
	private override bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	[Address(RVA = "0x29B3E10", Offset = "0x29B3210", Length = "0x7")]
	[Token(Token = "0x6000A3F")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	[Address(RVA = "0x29B3E20", Offset = "0x29B3220", Length = "0x8")]
	[Token(Token = "0x6000A40")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

}

