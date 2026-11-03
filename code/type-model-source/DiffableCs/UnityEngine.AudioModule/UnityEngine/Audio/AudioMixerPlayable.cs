namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AudioMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000029")]
public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005A")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x2FC7710", Offset = "0x2FC6B10", Length = "0xDC")]
	[Token(Token = "0x60000BB")]
	internal AudioMixerPlayable(PlayableHandle handle) { }

	[Address(RVA = "0x2FC74C0", Offset = "0x2FC68C0", Length = "0x1CF")]
	[Token(Token = "0x60000B9")]
	public static AudioMixerPlayable Create(PlayableGraph graph, int inputCount = 0, bool normalizeInputVolumes = false) { }

	[Address(RVA = "0x2FC7350", Offset = "0x2FC6750", Length = "0x53")]
	[NativeThrows]
	[Token(Token = "0x60000BF")]
	private static bool CreateAudioMixerPlayableInternal(ref PlayableGraph graph, bool normalizeInputVolumes, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FC73B0", Offset = "0x2FC67B0", Length = "0x108")]
	[Token(Token = "0x60000BA")]
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount, bool normalizeInputVolumes) { }

	[Address(RVA = "0x2FC7690", Offset = "0x2FC6A90", Length = "0x79")]
	[Token(Token = "0x60000BE")]
	public override bool Equals(AudioMixerPlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x60000BC")]
	public override PlayableHandle GetHandle() { }

	[Address(RVA = "0x2FAD840", Offset = "0x2FACC40", Length = "0x3F")]
	[Token(Token = "0x60000BD")]
	public static Playable op_Implicit(AudioMixerPlayable playable) { }

}

