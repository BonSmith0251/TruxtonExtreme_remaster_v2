namespace UnityEngine.Playables;

[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[Token(Token = "0x2000327")]
[UsedByNativeCode]
public struct PlayableHandle : IEquatable<PlayableHandle>
{
	[Token(Token = "0x4000846")]
	private static readonly PlayableHandle m_Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000844")]
	internal IntPtr m_Handle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000845")]
	internal uint m_Version; //Field offset: 0x8

	[Token(Token = "0x170003B1")]
	public static PlayableHandle Null
	{
		[Address(RVA = "0x307E080", Offset = "0x307D480", Length = "0x60")]
		[Token(Token = "0x600195B")]
		 get { } //Length: 96
	}

	[Address(RVA = "0x307E040", Offset = "0x307D440", Length = "0x39")]
	[Token(Token = "0x6001982")]
	private static PlayableHandle() { }

	[Address(RVA = "0x307CEC0", Offset = "0x307C2C0", Length = "0x5A")]
	[Token(Token = "0x6001965")]
	internal bool CheckInputBounds(int inputIndex) { }

	[Address(RVA = "0x307CF20", Offset = "0x307C320", Length = "0x22F")]
	[Token(Token = "0x6001966")]
	internal bool CheckInputBounds(int inputIndex, bool acceptAny) { }

	[Address(RVA = "0xD15EB0", Offset = "0xD152B0", Length = "0x1C")]
	[Token(Token = "0x6001964")]
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[Address(RVA = "0x307D260", Offset = "0x307C660", Length = "0x82")]
	[Token(Token = "0x6001962")]
	public override bool Equals(PlayableHandle other) { }

	[Address(RVA = "0x307D150", Offset = "0x307C550", Length = "0x10F")]
	[Token(Token = "0x6001961")]
	public virtual bool Equals(object p) { }

	[Address(RVA = "0x307E080", Offset = "0x307D480", Length = "0x60")]
	[Token(Token = "0x600195B")]
	public static PlayableHandle get_Null() { }

	[Address(RVA = "0x307D2F0", Offset = "0x307C6F0", Length = "0x33")]
	[FreeFunction("PlayableHandleBindings::GetDuration", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001972")]
	[VisibleToOtherModules]
	internal double GetDuration() { }

	[Address(RVA = "0x307D380", Offset = "0x307C780", Length = "0x7C")]
	[FreeFunction("PlayableHandleBindings::GetGraph", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001975")]
	[VisibleToOtherModules]
	internal PlayableGraph GetGraph() { }

	[Address(RVA = "0x307D330", Offset = "0x307C730", Length = "0x42")]
	[Token(Token = "0x6001983")]
	private static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret) { }

	[Address(RVA = "0x307D400", Offset = "0x307C800", Length = "0x2E")]
	[Token(Token = "0x6001963")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x307D670", Offset = "0x307CA70", Length = "0xCE")]
	[Token(Token = "0x600195C")]
	internal Playable GetInput(int inputPort) { }

	[Address(RVA = "0x307D430", Offset = "0x307C830", Length = "0x33")]
	[FreeFunction("PlayableHandleBindings::GetInputCount", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001976")]
	[VisibleToOtherModules]
	internal int GetInputCount() { }

	[Address(RVA = "0x307D4C0", Offset = "0x307C8C0", Length = "0x8B")]
	[FreeFunction("PlayableHandleBindings::GetInputHandle", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600197E")]
	private PlayableHandle GetInputHandle(int index) { }

	[Address(RVA = "0x307D470", Offset = "0x307C870", Length = "0x50")]
	[Token(Token = "0x6001985")]
	private static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret) { }

	[Address(RVA = "0x307D590", Offset = "0x307C990", Length = "0xD9")]
	[Token(Token = "0x600195F")]
	internal float GetInputWeight(int inputIndex) { }

	[Address(RVA = "0x307D550", Offset = "0x307C950", Length = "0x40")]
	[FreeFunction("PlayableHandleBindings::GetInputWeightFromIndex", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001981")]
	private float GetInputWeightFromIndex(int index) { }

	[Address(RVA = "0x8AFC40", Offset = "0x8AF040", Length = "0xC1")]
	[Token(Token = "0x6001959")]
	internal T GetObject() { }

	[Address(RVA = "0x307D820", Offset = "0x307CC20", Length = "0xCE")]
	[Token(Token = "0x600195D")]
	internal Playable GetOutput(int outputPort) { }

	[Address(RVA = "0x307D790", Offset = "0x307CB90", Length = "0x8B")]
	[FreeFunction("PlayableHandleBindings::GetOutputHandle", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600197F")]
	private PlayableHandle GetOutputHandle(int index) { }

	[Address(RVA = "0x307D740", Offset = "0x307CB40", Length = "0x50")]
	[Token(Token = "0x6001986")]
	private static void GetOutputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret) { }

	[Address(RVA = "0x307D930", Offset = "0x307CD30", Length = "0x33")]
	[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001968")]
	[VisibleToOtherModules]
	internal Type GetPlayableType() { }

	[Address(RVA = "0x307D8F0", Offset = "0x307CCF0", Length = "0x33")]
	[FreeFunction("PlayableHandleBindings::GetPlayState", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600196A")]
	[VisibleToOtherModules]
	internal PlayState GetPlayState() { }

	[Address(RVA = "0x307D970", Offset = "0x307CD70", Length = "0x33")]
	[FreeFunction("PlayableHandleBindings::GetPreviousTime", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001979")]
	[VisibleToOtherModules]
	internal double GetPreviousTime() { }

	[Address(RVA = "0x307D9B0", Offset = "0x307CDB0", Length = "0x33")]
	[FreeFunction("PlayableHandleBindings::GetScriptInstance", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600197D")]
	private object GetScriptInstance() { }

	[Address(RVA = "0x307DA30", Offset = "0x307CE30", Length = "0x33")]
	[FreeFunction("PlayableHandleBindings::GetTime", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600196E")]
	[VisibleToOtherModules]
	internal double GetTime() { }

	[Address(RVA = "0x307D9F0", Offset = "0x307CDF0", Length = "0x33")]
	[FreeFunction("PlayableHandleBindings::GetTimeWrapMode", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600197B")]
	[VisibleToOtherModules]
	internal DirectorWrapMode GetTimeWrapMode() { }

	[Address(RVA = "0x307DA70", Offset = "0x307CE70", Length = "0x33")]
	[FreeFunction("PlayableHandleBindings::IsDone", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001970")]
	[VisibleToOtherModules]
	internal bool IsDone() { }

	[Address(RVA = "0x8AFD10", Offset = "0x8AF110", Length = "0x92")]
	[Token(Token = "0x600195A")]
	[VisibleToOtherModules]
	internal bool IsPlayableOfType() { }

	[Address(RVA = "0x307DAB0", Offset = "0x307CEB0", Length = "0x33")]
	[Token(Token = "0x6001967")]
	[VisibleToOtherModules]
	internal bool IsValid() { }

	[Address(RVA = "0x307E0E0", Offset = "0x307D4E0", Length = "0x6D")]
	[Token(Token = "0x6001960")]
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	[Address(RVA = "0x307DAF0", Offset = "0x307CEF0", Length = "0x33")]
	[FreeFunction("PlayableHandleBindings::Pause", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600196C")]
	[VisibleToOtherModules]
	internal void Pause() { }

	[Address(RVA = "0x307DB30", Offset = "0x307CF30", Length = "0x33")]
	[FreeFunction("PlayableHandleBindings::Play", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600196B")]
	[VisibleToOtherModules]
	internal void Play() { }

	[Address(RVA = "0x307DB70", Offset = "0x307CF70", Length = "0x42")]
	[FreeFunction("PlayableHandleBindings::SetDone", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001971")]
	[VisibleToOtherModules]
	internal void SetDone(bool value) { }

	[Address(RVA = "0x307DBC0", Offset = "0x307CFC0", Length = "0x43")]
	[FreeFunction("PlayableHandleBindings::SetDuration", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001973")]
	[VisibleToOtherModules]
	internal void SetDuration(double value) { }

	[Address(RVA = "0x307DC10", Offset = "0x307D010", Length = "0x40")]
	[FreeFunction("PlayableHandleBindings::SetInputCount", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001977")]
	[VisibleToOtherModules]
	internal void SetInputCount(int value) { }

	[Address(RVA = "0x307DD00", Offset = "0x307D100", Length = "0xED")]
	[Token(Token = "0x600195E")]
	internal bool SetInputWeight(int inputIndex, float weight) { }

	[Address(RVA = "0x307DDF0", Offset = "0x307D1F0", Length = "0x83")]
	[FreeFunction("PlayableHandleBindings::SetInputWeight", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001978")]
	[VisibleToOtherModules]
	internal void SetInputWeight(PlayableHandle input, float weight) { }

	[Address(RVA = "0x307DCA0", Offset = "0x307D0A0", Length = "0x52")]
	[Token(Token = "0x6001984")]
	private static void SetInputWeight_Injected(ref PlayableHandle _unity_self, in PlayableHandle input, float weight) { }

	[Address(RVA = "0x307DC50", Offset = "0x307D050", Length = "0x50")]
	[FreeFunction("PlayableHandleBindings::SetInputWeightFromIndex", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001980")]
	private void SetInputWeightFromIndex(int index, float weight) { }

	[Address(RVA = "0x307DE80", Offset = "0x307D280", Length = "0x42")]
	[FreeFunction("PlayableHandleBindings::SetPropagateSetTime", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001974")]
	[VisibleToOtherModules]
	internal void SetPropagateSetTime(bool value) { }

	[Address(RVA = "0x307DED0", Offset = "0x307D2D0", Length = "0x42")]
	[FreeFunction("PlayableHandleBindings::SetScriptInstance", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001969")]
	[VisibleToOtherModules]
	internal void SetScriptInstance(object scriptInstance) { }

	[Address(RVA = "0x307DF20", Offset = "0x307D320", Length = "0x43")]
	[FreeFunction("PlayableHandleBindings::SetSpeed", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600196D")]
	[VisibleToOtherModules]
	internal void SetSpeed(double value) { }

	[Address(RVA = "0x307DFB0", Offset = "0x307D3B0", Length = "0x43")]
	[FreeFunction("PlayableHandleBindings::SetTime", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600196F")]
	[VisibleToOtherModules]
	internal void SetTime(double value) { }

	[Address(RVA = "0x307DF70", Offset = "0x307D370", Length = "0x40")]
	[FreeFunction("PlayableHandleBindings::SetTimeWrapMode", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600197C")]
	[VisibleToOtherModules]
	internal void SetTimeWrapMode(DirectorWrapMode mode) { }

	[Address(RVA = "0x307E000", Offset = "0x307D400", Length = "0x40")]
	[FreeFunction("PlayableHandleBindings::SetTraversalMode", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600197A")]
	[VisibleToOtherModules]
	internal void SetTraversalMode(PlayableTraversalMode mode) { }

}

