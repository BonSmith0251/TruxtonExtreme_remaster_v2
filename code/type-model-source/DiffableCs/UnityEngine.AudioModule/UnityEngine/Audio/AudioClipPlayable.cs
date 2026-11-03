namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AudioClipPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000026")]
public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000059")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x2FC49C0", Offset = "0x2FC3DC0", Length = "0xDC")]
	[Token(Token = "0x60000A1")]
	internal AudioClipPlayable(PlayableHandle handle) { }

	[Address(RVA = "0x2FC3F60", Offset = "0x2FC3360", Length = "0x2DD")]
	[Token(Token = "0x600009F")]
	public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping) { }

	[Address(RVA = "0x2FC3E30", Offset = "0x2FC3230", Length = "0x126")]
	[Token(Token = "0x60000A0")]
	private static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping) { }

	[Address(RVA = "0x2FC4240", Offset = "0x2FC3640", Length = "0x79")]
	[Token(Token = "0x60000A5")]
	public override bool Equals(AudioClipPlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x60000A2")]
	public override PlayableHandle GetHandle() { }

	[Address(RVA = "0x2FC4330", Offset = "0x2FC3730", Length = "0x9C")]
	[NativeThrows]
	[Token(Token = "0x60000AF")]
	private static bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FC42C0", Offset = "0x2FC36C0", Length = "0x64")]
	[Token(Token = "0x60000B0")]
	private static bool InternalCreateAudioClipPlayable_Injected(ref PlayableGraph graph, IntPtr clip, bool looping, ref PlayableHandle handle) { }

	[Address(RVA = "0x2FC4AA0", Offset = "0x2FC3EA0", Length = "0x134")]
	[Token(Token = "0x60000A4")]
	public static AudioClipPlayable op_Explicit(Playable playable) { }

	[Address(RVA = "0x2FAD840", Offset = "0x2FACC40", Length = "0x3F")]
	[Token(Token = "0x60000A3")]
	public static Playable op_Implicit(AudioClipPlayable playable) { }

	[Address(RVA = "0x2FC43D0", Offset = "0x2FC37D0", Length = "0x1BF")]
	[Token(Token = "0x60000A9")]
	public void Seek(double startTime, double startDelay, double duration) { }

	[Address(RVA = "0x2FC4590", Offset = "0x2FC3990", Length = "0x43")]
	[NativeThrows]
	[Token(Token = "0x60000AE")]
	private static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay) { }

	[Address(RVA = "0x2FC4630", Offset = "0x2FC3A30", Length = "0xD2")]
	[Token(Token = "0x60000A8")]
	internal void SetSpatialBlend(float value) { }

	[Address(RVA = "0x2FC45E0", Offset = "0x2FC39E0", Length = "0x43")]
	[NativeThrows]
	[Token(Token = "0x60000AC")]
	private static void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend) { }

	[Address(RVA = "0x2FC4710", Offset = "0x2FC3B10", Length = "0x43")]
	[NativeThrows]
	[Token(Token = "0x60000AD")]
	private static void SetStartDelayInternal(ref PlayableHandle hdl, double delay) { }

	[Address(RVA = "0x2FC47B0", Offset = "0x2FC3BB0", Length = "0xD7")]
	[Token(Token = "0x60000A7")]
	internal void SetStereoPan(float value) { }

	[Address(RVA = "0x2FC4760", Offset = "0x2FC3B60", Length = "0x43")]
	[NativeThrows]
	[Token(Token = "0x60000AB")]
	private static void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan) { }

	[Address(RVA = "0x2FC48E0", Offset = "0x2FC3CE0", Length = "0xD2")]
	[Token(Token = "0x60000A6")]
	internal void SetVolume(float value) { }

	[Address(RVA = "0x2FC4890", Offset = "0x2FC3C90", Length = "0x43")]
	[NativeThrows]
	[Token(Token = "0x60000AA")]
	private static void SetVolumeInternal(ref PlayableHandle hdl, float volume) { }

}

