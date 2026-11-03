namespace UnityEngine.Playables;

[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[Token(Token = "0x2000325")]
[UsedByNativeCode]
public struct PlayableGraph
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400083E")]
	internal IntPtr m_Handle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400083F")]
	internal uint m_Version; //Field offset: 0x8

	[Address(RVA = "0x8AF870", Offset = "0x8AEC70", Length = "0x10F")]
	[Token(Token = "0x6001937")]
	public bool Connect(U source, int sourceOutputPort, V destination, int destinationInputPort) { }

	[Address(RVA = "0x307C2E0", Offset = "0x307B6E0", Length = "0x6C")]
	[FreeFunction("PlayableGraphBindings::ConnectInternal", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600194E")]
	private bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort) { }

	[Address(RVA = "0x307C270", Offset = "0x307B670", Length = "0x62")]
	[Token(Token = "0x6001957")]
	private static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, in PlayableHandle source, int sourceOutputPort, in PlayableHandle destination, int destinationInputPort) { }

	[Address(RVA = "0x307C620", Offset = "0x307BA20", Length = "0x2D")]
	[Token(Token = "0x600193B")]
	public static PlayableGraph Create() { }

	[Address(RVA = "0x307C650", Offset = "0x307BA50", Length = "0x1B0")]
	[Token(Token = "0x600193C")]
	public static PlayableGraph Create(string name) { }

	[Address(RVA = "0x307C5D0", Offset = "0x307B9D0", Length = "0x42")]
	[Token(Token = "0x6001950")]
	private static void Create_Injected(ref ManagedSpanWrapper name, out PlayableGraph ret) { }

	[Address(RVA = "0x307C3A0", Offset = "0x307B7A0", Length = "0x4B")]
	[FreeFunction("PlayableGraphBindings::CreatePlayableHandle", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001948")]
	internal PlayableHandle CreatePlayableHandle() { }

	[Address(RVA = "0x307C350", Offset = "0x307B750", Length = "0x42")]
	[Token(Token = "0x6001952")]
	private static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret) { }

	[Address(RVA = "0x307C450", Offset = "0x307B850", Length = "0x17C")]
	[FreeFunction("PlayableGraphBindings::CreateScriptOutputInternal", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001949")]
	internal bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle) { }

	[Address(RVA = "0x307C3F0", Offset = "0x307B7F0", Length = "0x52")]
	[Token(Token = "0x6001953")]
	private static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, ref ManagedSpanWrapper name, out PlayableOutputHandle handle) { }

	[Address(RVA = "0x307C950", Offset = "0x307BD50", Length = "0x33")]
	[FreeFunction("PlayableGraphBindings::Destroy", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600193D")]
	public void Destroy() { }

	[Address(RVA = "0x8AF980", Offset = "0x8AED80", Length = "0x64")]
	[Token(Token = "0x6001939")]
	public void DestroyOutput(U output) { }

	[Address(RVA = "0x307C860", Offset = "0x307BC60", Length = "0x42")]
	[FreeFunction("PlayableGraphBindings::DestroyOutputInternal", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600194B")]
	internal void DestroyOutputInternal(PlayableOutputHandle handle) { }

	[Address(RVA = "0x307C810", Offset = "0x307BC10", Length = "0x42")]
	[Token(Token = "0x6001955")]
	private static void DestroyOutputInternal_Injected(ref PlayableGraph _unity_self, in PlayableOutputHandle handle) { }

	[Address(RVA = "0x8AFAE0", Offset = "0x8AEEE0", Length = "0x64")]
	[Token(Token = "0x6001938")]
	public void DestroyPlayable(U playable) { }

	[Address(RVA = "0x307C900", Offset = "0x307BD00", Length = "0x42")]
	[FreeFunction("PlayableGraphBindings::DestroyPlayableInternal", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600194F")]
	private void DestroyPlayableInternal(PlayableHandle playable) { }

	[Address(RVA = "0x307C8B0", Offset = "0x307BCB0", Length = "0x42")]
	[Token(Token = "0x6001958")]
	private static void DestroyPlayableInternal_Injected(ref PlayableGraph _unity_self, in PlayableHandle playable) { }

	[Address(RVA = "0x307C990", Offset = "0x307BD90", Length = "0x43")]
	[FreeFunction("PlayableGraphBindings::Evaluate", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001942")]
	public void Evaluate(float deltaTime) { }

	[Address(RVA = "0x307C9E0", Offset = "0x307BDE0", Length = "0x36")]
	[Token(Token = "0x600193A")]
	public void Evaluate() { }

	[Address(RVA = "0x307CA70", Offset = "0x307BE70", Length = "0x44")]
	[FreeFunction("PlayableGraphBindings::GetFrameRate", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600194D")]
	internal FrameRate GetFrameRate() { }

	[Address(RVA = "0x307CA20", Offset = "0x307BE20", Length = "0x42")]
	[Token(Token = "0x6001956")]
	private static void GetFrameRate_Injected(ref PlayableGraph _unity_self, out FrameRate ret) { }

	[Address(RVA = "0x307CAC0", Offset = "0x307BEC0", Length = "0x33")]
	[FreeFunction("PlayableGraphBindings::GetPlayableCount", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001945")]
	public int GetPlayableCount() { }

	[Address(RVA = "0x307CB00", Offset = "0x307BF00", Length = "0x33")]
	[FreeFunction("PlayableGraphBindings::GetResolver", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001944")]
	public IExposedPropertyTable GetResolver() { }

	[Address(RVA = "0x307CC30", Offset = "0x307C030", Length = "0x69")]
	[Token(Token = "0x6001936")]
	public Playable GetRootPlayable(int index) { }

	[Address(RVA = "0x307CB40", Offset = "0x307BF40", Length = "0x33")]
	[FreeFunction("PlayableGraphBindings::GetRootPlayableCount", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001946")]
	public int GetRootPlayableCount() { }

	[Address(RVA = "0x307CBD0", Offset = "0x307BFD0", Length = "0x5A")]
	[FreeFunction("PlayableGraphBindings::GetRootPlayableInternal", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600194A")]
	internal PlayableHandle GetRootPlayableInternal(int index) { }

	[Address(RVA = "0x307CB80", Offset = "0x307BF80", Length = "0x50")]
	[Token(Token = "0x6001954")]
	private static void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret) { }

	[Address(RVA = "0x307CCA0", Offset = "0x307C0A0", Length = "0x33")]
	[FreeFunction("PlayableGraphBindings::IsMatchFrameRateEnabled", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600194C")]
	internal bool IsMatchFrameRateEnabled() { }

	[Address(RVA = "0x307CCE0", Offset = "0x307C0E0", Length = "0x33")]
	[FreeFunction("PlayableGraphBindings::IsPlaying", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600193F")]
	public bool IsPlaying() { }

	[Address(RVA = "0x307CD20", Offset = "0x307C120", Length = "0x33")]
	[Token(Token = "0x600193E")]
	public bool IsValid() { }

	[Address(RVA = "0x307CD60", Offset = "0x307C160", Length = "0x33")]
	[FreeFunction("PlayableGraphBindings::Play", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001940")]
	public void Play() { }

	[Address(RVA = "0x307CDA0", Offset = "0x307C1A0", Length = "0x40")]
	[FreeFunction("PlayableGraphBindings::SetTimeUpdateMode", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001943")]
	public void SetTimeUpdateMode(DirectorUpdateMode value) { }

	[Address(RVA = "0x307CDE0", Offset = "0x307C1E0", Length = "0x33")]
	[FreeFunction("PlayableGraphBindings::Stop", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001941")]
	public void Stop() { }

	[Address(RVA = "0x307CE70", Offset = "0x307C270", Length = "0x42")]
	[FreeFunction("PlayableGraphBindings::SynchronizeEvaluation", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001947")]
	internal void SynchronizeEvaluation(PlayableGraph playable) { }

	[Address(RVA = "0x307CE20", Offset = "0x307C220", Length = "0x42")]
	[Token(Token = "0x6001951")]
	private static void SynchronizeEvaluation_Injected(ref PlayableGraph _unity_self, in PlayableGraph playable) { }

}

