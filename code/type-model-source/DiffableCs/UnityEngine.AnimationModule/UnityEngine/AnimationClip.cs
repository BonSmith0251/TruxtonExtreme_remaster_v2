namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
[NativeType("Modules/Animation/AnimationClip.h")]
[Token(Token = "0x200000B")]
public sealed class AnimationClip : Motion
{

	[Token(Token = "0x1700000A")]
	public bool empty
	{
		[Address(RVA = "0x2FAE690", Offset = "0x2FADA90", Length = "0x76")]
		[NativeMethod("IsEmpty")]
		[Token(Token = "0x600003C")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000010")]
	public AnimationEvent[] events
	{
		[Address(RVA = "0x2FAE710", Offset = "0x2FADB10", Length = "0x240")]
		[Token(Token = "0x6000044")]
		 get { } //Length: 576
		[Address(RVA = "0x2FAF350", Offset = "0x2FAE750", Length = "0x1A8")]
		[Token(Token = "0x6000045")]
		 set { } //Length: 424
	}

	[NativeProperty("SampleRate", False, TargetType::Function (0))]
	[Token(Token = "0x17000005")]
	public float frameRate
	{
		[Address(RVA = "0x2FAE9A0", Offset = "0x2FADDA0", Length = "0x76")]
		[Token(Token = "0x6000030")]
		 get { } //Length: 118
		[Address(RVA = "0x2FAF550", Offset = "0x2FAE950", Length = "0x86")]
		[Token(Token = "0x6000031")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700000B")]
	public bool hasGenericRootTransform
	{
		[Address(RVA = "0x2FAEA60", Offset = "0x2FADE60", Length = "0x76")]
		[NativeMethod("HasGenericRootTransform")]
		[Token(Token = "0x600003D")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000D")]
	public bool hasMotionCurves
	{
		[Address(RVA = "0x2FAEB20", Offset = "0x2FADF20", Length = "0x76")]
		[NativeMethod("HasMotionCurves")]
		[Token(Token = "0x600003F")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000C")]
	public bool hasMotionFloatCurves
	{
		[Address(RVA = "0x2FAEBE0", Offset = "0x2FADFE0", Length = "0x76")]
		[NativeMethod("HasMotionFloatCurves")]
		[Token(Token = "0x600003E")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000E")]
	public bool hasRootCurves
	{
		[Address(RVA = "0x2FAECA0", Offset = "0x2FAE0A0", Length = "0x76")]
		[NativeMethod("HasRootCurves")]
		[Token(Token = "0x6000040")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000F")]
	internal bool hasRootMotion
	{
		[Address(RVA = "0x2FAED60", Offset = "0x2FAE160", Length = "0x76")]
		[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = True)]
		[Token(Token = "0x6000041")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x17000009")]
	public bool humanMotion
	{
		[Address(RVA = "0x2FAEE20", Offset = "0x2FAE220", Length = "0x76")]
		[NativeMethod("IsHumanMotion")]
		[Token(Token = "0x600003B")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000008")]
	public bool legacy
	{
		[Address(RVA = "0x2FAEEE0", Offset = "0x2FAE2E0", Length = "0x76")]
		[NativeMethod("IsLegacy")]
		[Token(Token = "0x6000039")]
		 get { } //Length: 118
		[Address(RVA = "0x2FAF630", Offset = "0x2FAEA30", Length = "0x86")]
		[NativeMethod("SetLegacy")]
		[Token(Token = "0x600003A")]
		 set { } //Length: 134
	}

	[NativeProperty("Length", False, TargetType::Function (0))]
	[Token(Token = "0x17000002")]
	public float length
	{
		[Address(RVA = "0x2FAEFA0", Offset = "0x2FAE3A0", Length = "0x76")]
		[Token(Token = "0x600002D")]
		 get { } //Length: 118
	}

	[NativeProperty("Bounds", False, TargetType::Function (0))]
	[Token(Token = "0x17000007")]
	public Bounds localBounds
	{
		[Address(RVA = "0x2FAF070", Offset = "0x2FAE470", Length = "0x94")]
		[Token(Token = "0x6000037")]
		 get { } //Length: 148
		[Address(RVA = "0x2FAF710", Offset = "0x2FAEB10", Length = "0x85")]
		[Token(Token = "0x6000038")]
		 set { } //Length: 133
	}

	[NativeProperty("StartTime", False, TargetType::Function (0))]
	[Token(Token = "0x17000003")]
	internal float startTime
	{
		[Address(RVA = "0x2FAF150", Offset = "0x2FAE550", Length = "0x76")]
		[Token(Token = "0x600002E")]
		internal get { } //Length: 118
	}

	[NativeProperty("StopTime", False, TargetType::Function (0))]
	[Token(Token = "0x17000004")]
	internal float stopTime
	{
		[Address(RVA = "0x2FAF210", Offset = "0x2FAE610", Length = "0x76")]
		[Token(Token = "0x600002F")]
		internal get { } //Length: 118
	}

	[NativeProperty("WrapMode", False, TargetType::Function (0))]
	[Token(Token = "0x17000006")]
	public WrapMode wrapMode
	{
		[Address(RVA = "0x2FAF2D0", Offset = "0x2FAE6D0", Length = "0x76")]
		[Token(Token = "0x6000035")]
		 get { } //Length: 118
		[Address(RVA = "0x2FAF7E0", Offset = "0x2FAEBE0", Length = "0x83")]
		[Token(Token = "0x6000036")]
		 set { } //Length: 131
	}

	[Address(RVA = "0x2FAE5E0", Offset = "0x2FAD9E0", Length = "0x6E")]
	[Token(Token = "0x6000029")]
	public AnimationClip() { }

	[Address(RVA = "0x2FAD960", Offset = "0x2FACD60", Length = "0x1C8")]
	[Token(Token = "0x6000042")]
	public void AddEvent(AnimationEvent evt) { }

	[Address(RVA = "0x2FAD8D0", Offset = "0x2FACCD0", Length = "0x85")]
	[FreeFunction(Name = "AnimationClipBindings::AddEventInternal", HasExplicitThis = True)]
	[Token(Token = "0x6000043")]
	private void AddEventInternal(object evt) { }

	[Address(RVA = "0x2FAD880", Offset = "0x2FACC80", Length = "0x42")]
	[Token(Token = "0x600005E")]
	private static void AddEventInternal_Injected(IntPtr _unity_self, object evt) { }

	[Address(RVA = "0x2FADB70", Offset = "0x2FACF70", Length = "0x76")]
	[Token(Token = "0x6000034")]
	public void ClearCurves() { }

	[Address(RVA = "0x2FADB30", Offset = "0x2FACF30", Length = "0x33")]
	[Token(Token = "0x6000050")]
	private static void ClearCurves_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FADC30", Offset = "0x2FAD030", Length = "0x76")]
	[Token(Token = "0x6000033")]
	public void EnsureQuaternionContinuity() { }

	[Address(RVA = "0x2FADBF0", Offset = "0x2FACFF0", Length = "0x33")]
	[Token(Token = "0x600004F")]
	private static void EnsureQuaternionContinuity_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAE690", Offset = "0x2FADA90", Length = "0x76")]
	[NativeMethod("IsEmpty")]
	[Token(Token = "0x600003C")]
	public bool get_empty() { }

	[Address(RVA = "0x2FAE650", Offset = "0x2FADA50", Length = "0x33")]
	[Token(Token = "0x6000058")]
	private static bool get_empty_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAE710", Offset = "0x2FADB10", Length = "0x240")]
	[Token(Token = "0x6000044")]
	public AnimationEvent[] get_events() { }

	[Address(RVA = "0x2FAE9A0", Offset = "0x2FADDA0", Length = "0x76")]
	[Token(Token = "0x6000030")]
	public float get_frameRate() { }

	[Address(RVA = "0x2FAE960", Offset = "0x2FADD60", Length = "0x33")]
	[Token(Token = "0x600004C")]
	private static float get_frameRate_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAEA60", Offset = "0x2FADE60", Length = "0x76")]
	[NativeMethod("HasGenericRootTransform")]
	[Token(Token = "0x600003D")]
	public bool get_hasGenericRootTransform() { }

	[Address(RVA = "0x2FAEA20", Offset = "0x2FADE20", Length = "0x33")]
	[Token(Token = "0x6000059")]
	private static bool get_hasGenericRootTransform_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAEB20", Offset = "0x2FADF20", Length = "0x76")]
	[NativeMethod("HasMotionCurves")]
	[Token(Token = "0x600003F")]
	public bool get_hasMotionCurves() { }

	[Address(RVA = "0x2FAEAE0", Offset = "0x2FADEE0", Length = "0x33")]
	[Token(Token = "0x600005B")]
	private static bool get_hasMotionCurves_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAEBE0", Offset = "0x2FADFE0", Length = "0x76")]
	[NativeMethod("HasMotionFloatCurves")]
	[Token(Token = "0x600003E")]
	public bool get_hasMotionFloatCurves() { }

	[Address(RVA = "0x2FAEBA0", Offset = "0x2FADFA0", Length = "0x33")]
	[Token(Token = "0x600005A")]
	private static bool get_hasMotionFloatCurves_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAECA0", Offset = "0x2FAE0A0", Length = "0x76")]
	[NativeMethod("HasRootCurves")]
	[Token(Token = "0x6000040")]
	public bool get_hasRootCurves() { }

	[Address(RVA = "0x2FAEC60", Offset = "0x2FAE060", Length = "0x33")]
	[Token(Token = "0x600005C")]
	private static bool get_hasRootCurves_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAED60", Offset = "0x2FAE160", Length = "0x76")]
	[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = True)]
	[Token(Token = "0x6000041")]
	internal bool get_hasRootMotion() { }

	[Address(RVA = "0x2FAED20", Offset = "0x2FAE120", Length = "0x33")]
	[Token(Token = "0x600005D")]
	private static bool get_hasRootMotion_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAEE20", Offset = "0x2FAE220", Length = "0x76")]
	[NativeMethod("IsHumanMotion")]
	[Token(Token = "0x600003B")]
	public bool get_humanMotion() { }

	[Address(RVA = "0x2FAEDE0", Offset = "0x2FAE1E0", Length = "0x33")]
	[Token(Token = "0x6000057")]
	private static bool get_humanMotion_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAEEE0", Offset = "0x2FAE2E0", Length = "0x76")]
	[NativeMethod("IsLegacy")]
	[Token(Token = "0x6000039")]
	public bool get_legacy() { }

	[Address(RVA = "0x2FAEEA0", Offset = "0x2FAE2A0", Length = "0x33")]
	[Token(Token = "0x6000055")]
	private static bool get_legacy_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAEFA0", Offset = "0x2FAE3A0", Length = "0x76")]
	[Token(Token = "0x600002D")]
	public float get_length() { }

	[Address(RVA = "0x2FAEF60", Offset = "0x2FAE360", Length = "0x33")]
	[Token(Token = "0x6000049")]
	private static float get_length_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAF070", Offset = "0x2FAE470", Length = "0x94")]
	[Token(Token = "0x6000037")]
	public Bounds get_localBounds() { }

	[Address(RVA = "0x2FAF020", Offset = "0x2FAE420", Length = "0x42")]
	[Token(Token = "0x6000053")]
	private static void get_localBounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[Address(RVA = "0x2FAF150", Offset = "0x2FAE550", Length = "0x76")]
	[Token(Token = "0x600002E")]
	internal float get_startTime() { }

	[Address(RVA = "0x2FAF110", Offset = "0x2FAE510", Length = "0x33")]
	[Token(Token = "0x600004A")]
	private static float get_startTime_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAF210", Offset = "0x2FAE610", Length = "0x76")]
	[Token(Token = "0x600002F")]
	internal float get_stopTime() { }

	[Address(RVA = "0x2FAF1D0", Offset = "0x2FAE5D0", Length = "0x33")]
	[Token(Token = "0x600004B")]
	private static float get_stopTime_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAF2D0", Offset = "0x2FAE6D0", Length = "0x76")]
	[Token(Token = "0x6000035")]
	public WrapMode get_wrapMode() { }

	[Address(RVA = "0x2FAF290", Offset = "0x2FAE690", Length = "0x33")]
	[Token(Token = "0x6000051")]
	private static WrapMode get_wrapMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FADD10", Offset = "0x2FAD110", Length = "0x95")]
	[FreeFunction(Name = "AnimationClipBindings::GetEventsInternal", HasExplicitThis = True)]
	[Token(Token = "0x6000047")]
	private void GetEventsInternal(out IntPtr values, out int size) { }

	[Address(RVA = "0x2FADCB0", Offset = "0x2FAD0B0", Length = "0x52")]
	[Token(Token = "0x6000060")]
	private static void GetEventsInternal_Injected(IntPtr _unity_self, out IntPtr values, out int size) { }

	[Address(RVA = "0x2FADDB0", Offset = "0x2FAD1B0", Length = "0x33")]
	[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
	[Token(Token = "0x600002A")]
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	[Address(RVA = "0x2FADE60", Offset = "0x2FAD260", Length = "0x121")]
	[FreeFunction]
	[NativeHeader("Modules/Animation/AnimationUtility.h")]
	[Token(Token = "0x600002C")]
	internal static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, WrapMode wrapMode) { }

	[Address(RVA = "0x2FADF90", Offset = "0x2FAD390", Length = "0x167")]
	[Token(Token = "0x600002B")]
	public void SampleAnimation(GameObject go, float time) { }

	[Address(RVA = "0x2FADDF0", Offset = "0x2FAD1F0", Length = "0x62")]
	[Token(Token = "0x6000048")]
	private static void SampleAnimation_Injected(IntPtr go, IntPtr clip, float inTime, WrapMode wrapMode) { }

	[Address(RVA = "0x2FAF350", Offset = "0x2FAE750", Length = "0x1A8")]
	[Token(Token = "0x6000045")]
	public void set_events(AnimationEvent[] value) { }

	[Address(RVA = "0x2FAF550", Offset = "0x2FAE950", Length = "0x86")]
	[Token(Token = "0x6000031")]
	public void set_frameRate(float value) { }

	[Address(RVA = "0x2FAF500", Offset = "0x2FAE900", Length = "0x43")]
	[Token(Token = "0x600004D")]
	private static void set_frameRate_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FAF630", Offset = "0x2FAEA30", Length = "0x86")]
	[NativeMethod("SetLegacy")]
	[Token(Token = "0x600003A")]
	public void set_legacy(bool value) { }

	[Address(RVA = "0x2FAF5E0", Offset = "0x2FAE9E0", Length = "0x42")]
	[Token(Token = "0x6000056")]
	private static void set_legacy_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FAF710", Offset = "0x2FAEB10", Length = "0x85")]
	[Token(Token = "0x6000038")]
	public void set_localBounds(Bounds value) { }

	[Address(RVA = "0x2FAF6C0", Offset = "0x2FAEAC0", Length = "0x42")]
	[Token(Token = "0x6000054")]
	private static void set_localBounds_Injected(IntPtr _unity_self, in Bounds value) { }

	[Address(RVA = "0x2FAF7E0", Offset = "0x2FAEBE0", Length = "0x83")]
	[Token(Token = "0x6000036")]
	public void set_wrapMode(WrapMode value) { }

	[Address(RVA = "0x2FAF7A0", Offset = "0x2FAEBA0", Length = "0x40")]
	[Token(Token = "0x6000052")]
	private static void set_wrapMode_Injected(IntPtr _unity_self, WrapMode value) { }

	[Address(RVA = "0x2FAE170", Offset = "0x2FAD570", Length = "0x363")]
	[FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = True)]
	[Token(Token = "0x6000032")]
	public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve) { }

	[Address(RVA = "0x2FAE100", Offset = "0x2FAD500", Length = "0x62")]
	[Token(Token = "0x600004E")]
	private static void SetCurve_Injected(IntPtr _unity_self, ref ManagedSpanWrapper relativePath, Type type, ref ManagedSpanWrapper propertyName, IntPtr curve) { }

	[Address(RVA = "0x2FAE540", Offset = "0x2FAD940", Length = "0x95")]
	[FreeFunction(Name = "AnimationClipBindings::SetEventsInternal", HasExplicitThis = True)]
	[Token(Token = "0x6000046")]
	private void SetEventsInternal(Void* data, int length) { }

	[Address(RVA = "0x2FAE4E0", Offset = "0x2FAD8E0", Length = "0x52")]
	[Token(Token = "0x600005F")]
	private static void SetEventsInternal_Injected(IntPtr _unity_self, Void* data, int length) { }

}

