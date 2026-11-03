namespace UnityEngine.Video;

[NativeHeader("Modules/Video/Public/VideoPlayer.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode]
[Token(Token = "0x200000C")]
public sealed class VideoPlayer : Behaviour
{
	[Token(Token = "0x200000E")]
	internal sealed class ErrorEventHandler : MulticastDelegate
	{

		[Address(RVA = "0x639C90", Offset = "0x639090", Length = "0xB5")]
		[Token(Token = "0x60000CD")]
		public ErrorEventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x60000CE")]
		public override void Invoke(VideoPlayer source, string message) { }

	}

	[Token(Token = "0x200000D")]
	internal sealed class EventHandler : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x60000CB")]
		public EventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x60000CC")]
		public override void Invoke(VideoPlayer source) { }

	}

	[Token(Token = "0x200000F")]
	internal sealed class FrameReadyEventHandler : MulticastDelegate
	{

		[Address(RVA = "0x639C90", Offset = "0x639090", Length = "0xB5")]
		[Token(Token = "0x60000CF")]
		public FrameReadyEventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x60000D0")]
		public override void Invoke(VideoPlayer source, long frameIdx) { }

	}

	[Token(Token = "0x2000010")]
	internal sealed class TimeEventHandler : MulticastDelegate
	{

		[Address(RVA = "0x348B960", Offset = "0x348AD60", Length = "0xB5")]
		[Token(Token = "0x60000D1")]
		public TimeEventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x60000D2")]
		public override void Invoke(VideoPlayer source, double seconds) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000026")]
	private EventHandler prepareCompleted; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000027")]
	private EventHandler loopPointReached; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000028")]
	private EventHandler started; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000029")]
	private EventHandler frameDropped; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400002A")]
	private ErrorEventHandler errorReceived; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400002B")]
	private EventHandler seekCompleted; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400002C")]
	private TimeEventHandler clockResyncOccurred; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400002D")]
	private FrameReadyEventHandler frameReady; //Field offset: 0x50

	[Token(Token = "0x14000007")]
	public event TimeEventHandler clockResyncOccurred
	{
		[Address(RVA = "0x348CD10", Offset = "0x348C110", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000066")]
		 add { } //Length: 158
		[Address(RVA = "0x348F520", Offset = "0x348E920", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000067")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000005")]
	public event ErrorEventHandler errorReceived
	{
		[Address(RVA = "0x348CDB0", Offset = "0x348C1B0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000062")]
		 add { } //Length: 158
		[Address(RVA = "0x348F5C0", Offset = "0x348E9C0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000063")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000004")]
	public event EventHandler frameDropped
	{
		[Address(RVA = "0x348CE50", Offset = "0x348C250", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000060")]
		 add { } //Length: 158
		[Address(RVA = "0x348F660", Offset = "0x348EA60", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000061")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000008")]
	public event FrameReadyEventHandler frameReady
	{
		[Address(RVA = "0x348CEF0", Offset = "0x348C2F0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600006A")]
		 add { } //Length: 158
		[Address(RVA = "0x348F700", Offset = "0x348EB00", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600006B")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000002")]
	public event EventHandler loopPointReached
	{
		[Address(RVA = "0x348CF90", Offset = "0x348C390", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600005C")]
		 add { } //Length: 158
		[Address(RVA = "0x348F7A0", Offset = "0x348EBA0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600005D")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000001")]
	public event EventHandler prepareCompleted
	{
		[Address(RVA = "0x348D030", Offset = "0x348C430", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600005A")]
		 add { } //Length: 158
		[Address(RVA = "0x348F840", Offset = "0x348EC40", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600005B")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000006")]
	public event EventHandler seekCompleted
	{
		[Address(RVA = "0x348D0D0", Offset = "0x348C4D0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000064")]
		 add { } //Length: 158
		[Address(RVA = "0x348F8E0", Offset = "0x348ECE0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000065")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000003")]
	public event EventHandler started
	{
		[Address(RVA = "0x348D170", Offset = "0x348C570", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600005E")]
		 add { } //Length: 158
		[Address(RVA = "0x348F980", Offset = "0x348ED80", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600005F")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700000B")]
	public VideoAspectRatio aspectRatio
	{
		[Address(RVA = "0x348D250", Offset = "0x348C650", Length = "0x76")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 118
		[Address(RVA = "0x348FA60", Offset = "0x348EE60", Length = "0x83")]
		[Token(Token = "0x6000017")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700002C")]
	public VideoAudioOutputMode audioOutputMode
	{
		[Address(RVA = "0x348D310", Offset = "0x348C710", Length = "0x76")]
		[Token(Token = "0x6000051")]
		 get { } //Length: 118
		[Address(RVA = "0x348FB30", Offset = "0x348EF30", Length = "0x83")]
		[Token(Token = "0x6000052")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000029")]
	public ushort audioTrackCount
	{
		[Address(RVA = "0x348D3D0", Offset = "0x348C7D0", Length = "0x76")]
		[Token(Token = "0x6000046")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700002D")]
	public bool canSetDirectAudioVolume
	{
		[Address(RVA = "0x348D490", Offset = "0x348C890", Length = "0x76")]
		[NativeName("CanSetDirectAudioVolume")]
		[Token(Token = "0x6000053")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000019")]
	public bool canSetPlaybackSpeed
	{
		[Address(RVA = "0x348D550", Offset = "0x348C950", Length = "0x76")]
		[NativeName("CanSetPlaybackSpeed")]
		[Token(Token = "0x6000030")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000020")]
	public bool canSetSkipOnDrop
	{
		[Address(RVA = "0x348D610", Offset = "0x348CA10", Length = "0x76")]
		[NativeName("CanSetSkipOnDrop")]
		[Token(Token = "0x600003C")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000014")]
	public bool canSetTime
	{
		[Address(RVA = "0x348D850", Offset = "0x348CC50", Length = "0x76")]
		[NativeName("CanSetTime")]
		[Token(Token = "0x6000028")]
		 get { } //Length: 118
	}

	[Obsolete("VideoPlayer.canSetTimeSource is deprecated. Use canSetTimeUpdateMode instead. (UnityUpgradable) -> canSetTimeUpdateMode")]
	[Token(Token = "0x1700001C")]
	public bool canSetTimeSource
	{
		[Address(RVA = "0x348D6D0", Offset = "0x348CAD0", Length = "0x76")]
		[NativeName("CanSetTimeSource")]
		[Token(Token = "0x6000035")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000006")]
	public bool canSetTimeUpdateMode
	{
		[Address(RVA = "0x348D790", Offset = "0x348CB90", Length = "0x76")]
		[NativeName("CanSetTimeUpdateMode")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000018")]
	public bool canStep
	{
		[Address(RVA = "0x348D910", Offset = "0x348CD10", Length = "0x76")]
		[NativeName("CanStep")]
		[Token(Token = "0x600002E")]
		 get { } //Length: 118
	}

	[NativeName("VideoClip")]
	[Token(Token = "0x17000004")]
	public VideoClip clip
	{
		[Address(RVA = "0x348D9D0", Offset = "0x348CDD0", Length = "0x90")]
		[Token(Token = "0x6000009")]
		 get { } //Length: 144
		[Address(RVA = "0x348FC10", Offset = "0x348F010", Length = "0xBA")]
		[Token(Token = "0x600000A")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000017")]
	public double clockTime
	{
		[Address(RVA = "0x348DAB0", Offset = "0x348CEB0", Length = "0x76")]
		[Token(Token = "0x600002D")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700002B")]
	public ushort controlledAudioTrackCount
	{
		[Address(RVA = "0x348BF20", Offset = "0x348B320", Length = "0x76")]
		[Token(Token = "0x600004B")]
		 get { } //Length: 118
		[Address(RVA = "0x348FCD0", Offset = "0x348F0D0", Length = "0x132")]
		[Token(Token = "0x600004C")]
		 set { } //Length: 306
	}

	[Token(Token = "0x1700002A")]
	public static ushort controlledAudioTrackMaxCount
	{
		[Address(RVA = "0x348DB30", Offset = "0x348CF30", Length = "0x2A")]
		[Token(Token = "0x600004A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700001F")]
	public double externalReferenceTime
	{
		[Address(RVA = "0x348DBA0", Offset = "0x348CFA0", Length = "0x76")]
		[Token(Token = "0x600003A")]
		 get { } //Length: 118
		[Address(RVA = "0x348FE60", Offset = "0x348F260", Length = "0x86")]
		[Token(Token = "0x600003B")]
		 set { } //Length: 134
	}

	[NativeName("FramePosition")]
	[Token(Token = "0x17000016")]
	public long frame
	{
		[Address(RVA = "0x348DDE0", Offset = "0x348D1E0", Length = "0x76")]
		[Token(Token = "0x600002B")]
		 get { } //Length: 118
		[Address(RVA = "0x348FF40", Offset = "0x348F340", Length = "0x85")]
		[Token(Token = "0x600002C")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000022")]
	public ulong frameCount
	{
		[Address(RVA = "0x348DC60", Offset = "0x348D060", Length = "0x76")]
		[Token(Token = "0x600003F")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000023")]
	public float frameRate
	{
		[Address(RVA = "0x348DD20", Offset = "0x348D120", Length = "0x76")]
		[Token(Token = "0x6000040")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000026")]
	public uint height
	{
		[Address(RVA = "0x348DEA0", Offset = "0x348D2A0", Length = "0x76")]
		[Token(Token = "0x6000043")]
		 get { } //Length: 118
	}

	[NativeName("Loop")]
	[Token(Token = "0x1700001B")]
	public bool isLooping
	{
		[Address(RVA = "0x348DF60", Offset = "0x348D360", Length = "0x76")]
		[Token(Token = "0x6000033")]
		 get { } //Length: 118
		[Address(RVA = "0x3490020", Offset = "0x348F420", Length = "0x86")]
		[Token(Token = "0x6000034")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000013")]
	public bool isPaused
	{
		[Address(RVA = "0x348E020", Offset = "0x348D420", Length = "0x76")]
		[NativeName("IsPaused")]
		[Token(Token = "0x6000027")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000012")]
	public bool isPlaying
	{
		[Address(RVA = "0x348E0E0", Offset = "0x348D4E0", Length = "0x76")]
		[NativeName("IsPlaying")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000F")]
	public bool isPrepared
	{
		[Address(RVA = "0x348E1A0", Offset = "0x348D5A0", Length = "0x76")]
		[NativeName("IsPrepared")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 118
	}

	[NativeName("Duration")]
	[Token(Token = "0x17000024")]
	public double length
	{
		[Address(RVA = "0x348E260", Offset = "0x348D660", Length = "0x76")]
		[Token(Token = "0x6000041")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000028")]
	public uint pixelAspectRatioDenominator
	{
		[Address(RVA = "0x348E320", Offset = "0x348D720", Length = "0x76")]
		[Token(Token = "0x6000045")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000027")]
	public uint pixelAspectRatioNumerator
	{
		[Address(RVA = "0x348E3E0", Offset = "0x348D7E0", Length = "0x76")]
		[Token(Token = "0x6000044")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700001A")]
	public float playbackSpeed
	{
		[Address(RVA = "0x348E560", Offset = "0x348D960", Length = "0x76")]
		[Token(Token = "0x6000031")]
		 get { } //Length: 118
		[Address(RVA = "0x34901E0", Offset = "0x348F5E0", Length = "0x86")]
		[Token(Token = "0x6000032")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000011")]
	public bool playOnAwake
	{
		[Address(RVA = "0x348E4A0", Offset = "0x348D8A0", Length = "0x76")]
		[Token(Token = "0x6000021")]
		 get { } //Length: 118
		[Address(RVA = "0x3490100", Offset = "0x348F500", Length = "0x86")]
		[Token(Token = "0x6000022")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000005")]
	public VideoRenderMode renderMode
	{
		[Address(RVA = "0x348E620", Offset = "0x348DA20", Length = "0x76")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 118
		[Address(RVA = "0x34902B0", Offset = "0x348F6B0", Length = "0x83")]
		[Token(Token = "0x600000C")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700002E")]
	public bool sendFrameReadyEvents
	{
		[Address(RVA = "0x348E6E0", Offset = "0x348DAE0", Length = "0x76")]
		[NativeName("AreFrameReadyEventsEnabled")]
		[Token(Token = "0x6000068")]
		 get { } //Length: 118
		[Address(RVA = "0x3490390", Offset = "0x348F790", Length = "0x86")]
		[NativeName("EnableFrameReadyEvents")]
		[Token(Token = "0x6000069")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000021")]
	public bool skipOnDrop
	{
		[Address(RVA = "0x348E7A0", Offset = "0x348DBA0", Length = "0x76")]
		[Token(Token = "0x600003D")]
		 get { } //Length: 118
		[Address(RVA = "0x3490470", Offset = "0x348F870", Length = "0x86")]
		[Token(Token = "0x600003E")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000001")]
	public VideoSource source
	{
		[Address(RVA = "0x348E860", Offset = "0x348DC60", Length = "0x76")]
		[Token(Token = "0x6000003")]
		 get { } //Length: 118
		[Address(RVA = "0x3490540", Offset = "0x348F940", Length = "0x83")]
		[Token(Token = "0x6000004")]
		 set { } //Length: 131
	}

	[NativeHeader("Runtime/Camera/Camera.h")]
	[Token(Token = "0x17000007")]
	public Camera targetCamera
	{
		[Address(RVA = "0x348EAA0", Offset = "0x348DEA0", Length = "0x90")]
		[Token(Token = "0x600000E")]
		 get { } //Length: 144
		[Address(RVA = "0x34907D0", Offset = "0x348FBD0", Length = "0xBA")]
		[Token(Token = "0x600000F")]
		 set { } //Length: 186
	}

	[Token(Token = "0x1700000D")]
	public Video3DLayout targetCamera3DLayout
	{
		[Address(RVA = "0x348E920", Offset = "0x348DD20", Length = "0x76")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 118
		[Address(RVA = "0x3490610", Offset = "0x348FA10", Length = "0x83")]
		[Token(Token = "0x600001B")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700000C")]
	public float targetCameraAlpha
	{
		[Address(RVA = "0x348E9E0", Offset = "0x348DDE0", Length = "0x76")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 118
		[Address(RVA = "0x34906F0", Offset = "0x348FAF0", Length = "0x86")]
		[Token(Token = "0x6000019")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700000A")]
	public string targetMaterialProperty
	{
		[Address(RVA = "0x348EB90", Offset = "0x348DF90", Length = "0x106")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 262
		[Address(RVA = "0x34908E0", Offset = "0x348FCE0", Length = "0x1C7")]
		[Token(Token = "0x6000015")]
		 set { } //Length: 455
	}

	[NativeHeader("Runtime/Graphics/Renderer.h")]
	[Token(Token = "0x17000009")]
	public Renderer targetMaterialRenderer
	{
		[Address(RVA = "0x348ECE0", Offset = "0x348E0E0", Length = "0x90")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 144
		[Address(RVA = "0x3490B00", Offset = "0x348FF00", Length = "0xBA")]
		[Token(Token = "0x6000013")]
		 set { } //Length: 186
	}

	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[Token(Token = "0x17000008")]
	public RenderTexture targetTexture
	{
		[Address(RVA = "0x348EDC0", Offset = "0x348E1C0", Length = "0x90")]
		[Token(Token = "0x6000010")]
		 get { } //Length: 144
		[Address(RVA = "0x3490C10", Offset = "0x3490010", Length = "0xBA")]
		[Token(Token = "0x6000011")]
		 set { } //Length: 186
	}

	[NativeHeader("Runtime/Graphics/Texture.h")]
	[Token(Token = "0x1700000E")]
	public Texture texture
	{
		[Address(RVA = "0x348EEA0", Offset = "0x348E2A0", Length = "0x90")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 144
	}

	[NativeName("SecPosition")]
	[Token(Token = "0x17000015")]
	public double time
	{
		[Address(RVA = "0x348F1C0", Offset = "0x348E5C0", Length = "0x76")]
		[Token(Token = "0x6000029")]
		 get { } //Length: 118
		[Address(RVA = "0x3490F90", Offset = "0x3490390", Length = "0x86")]
		[Token(Token = "0x600002A")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700001E")]
	public VideoTimeReference timeReference
	{
		[Address(RVA = "0x348EF80", Offset = "0x348E380", Length = "0x76")]
		[Token(Token = "0x6000038")]
		 get { } //Length: 118
		[Address(RVA = "0x3490D10", Offset = "0x3490110", Length = "0x83")]
		[Token(Token = "0x6000039")]
		 set { } //Length: 131
	}

	[Obsolete("VideoPlayer.timeSource is deprecated. Use timeUpdateMode instead. (UnityUpgradable) -> timeUpdateMode")]
	[Token(Token = "0x1700001D")]
	public VideoTimeSource timeSource
	{
		[Address(RVA = "0x348F040", Offset = "0x348E440", Length = "0x76")]
		[Token(Token = "0x6000036")]
		 get { } //Length: 118
		[Address(RVA = "0x3490DE0", Offset = "0x34901E0", Length = "0x83")]
		[Token(Token = "0x6000037")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000002")]
	public VideoTimeUpdateMode timeUpdateMode
	{
		[Address(RVA = "0x348F100", Offset = "0x348E500", Length = "0x76")]
		[Token(Token = "0x6000005")]
		 get { } //Length: 118
		[Address(RVA = "0x3490EB0", Offset = "0x34902B0", Length = "0x83")]
		[Token(Token = "0x6000006")]
		 set { } //Length: 131
	}

	[NativeName("VideoUrl")]
	[Token(Token = "0x17000003")]
	public string url
	{
		[Address(RVA = "0x348F290", Offset = "0x348E690", Length = "0x106")]
		[Token(Token = "0x6000007")]
		 get { } //Length: 262
		[Address(RVA = "0x3491070", Offset = "0x3490470", Length = "0x1C7")]
		[Token(Token = "0x6000008")]
		 set { } //Length: 455
	}

	[Token(Token = "0x17000010")]
	public bool waitForFirstFrame
	{
		[Address(RVA = "0x348F3E0", Offset = "0x348E7E0", Length = "0x76")]
		[Token(Token = "0x600001F")]
		 get { } //Length: 118
		[Address(RVA = "0x3491290", Offset = "0x3490690", Length = "0x86")]
		[Token(Token = "0x6000020")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000025")]
	public uint width
	{
		[Address(RVA = "0x348F4A0", Offset = "0x348E8A0", Length = "0x76")]
		[Token(Token = "0x6000042")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000074")]
	public VideoPlayer() { }

	[Address(RVA = "0x348CD10", Offset = "0x348C110", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000066")]
	public void add_clockResyncOccurred(TimeEventHandler value) { }

	[Address(RVA = "0x348CDB0", Offset = "0x348C1B0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000062")]
	public void add_errorReceived(ErrorEventHandler value) { }

	[Address(RVA = "0x348CE50", Offset = "0x348C250", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000060")]
	public void add_frameDropped(EventHandler value) { }

	[Address(RVA = "0x348CEF0", Offset = "0x348C2F0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600006A")]
	public void add_frameReady(FrameReadyEventHandler value) { }

	[Address(RVA = "0x348CF90", Offset = "0x348C390", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600005C")]
	public void add_loopPointReached(EventHandler value) { }

	[Address(RVA = "0x348D030", Offset = "0x348C430", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600005A")]
	public void add_prepareCompleted(EventHandler value) { }

	[Address(RVA = "0x348D0D0", Offset = "0x348C4D0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000064")]
	public void add_seekCompleted(EventHandler value) { }

	[Address(RVA = "0x348D170", Offset = "0x348C570", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600005E")]
	public void add_started(EventHandler value) { }

	[Address(RVA = "0x348BB00", Offset = "0x348AF00", Length = "0x97")]
	[Token(Token = "0x600004F")]
	public void EnableAudioTrack(ushort trackIndex, bool enabled) { }

	[Address(RVA = "0x348BAA0", Offset = "0x348AEA0", Length = "0x54")]
	[Token(Token = "0x60000BE")]
	private static void EnableAudioTrack_Injected(IntPtr _unity_self, ushort trackIndex, bool enabled) { }

	[Address(RVA = "0x348D250", Offset = "0x348C650", Length = "0x76")]
	[Token(Token = "0x6000016")]
	public VideoAspectRatio get_aspectRatio() { }

	[Address(RVA = "0x348D210", Offset = "0x348C610", Length = "0x33")]
	[Token(Token = "0x6000088")]
	private static VideoAspectRatio get_aspectRatio_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348D310", Offset = "0x348C710", Length = "0x76")]
	[Token(Token = "0x6000051")]
	public VideoAudioOutputMode get_audioOutputMode() { }

	[Address(RVA = "0x348D2D0", Offset = "0x348C6D0", Length = "0x33")]
	[Token(Token = "0x60000C0")]
	private static VideoAudioOutputMode get_audioOutputMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348D3D0", Offset = "0x348C7D0", Length = "0x76")]
	[Token(Token = "0x6000046")]
	public ushort get_audioTrackCount() { }

	[Address(RVA = "0x348D390", Offset = "0x348C790", Length = "0x33")]
	[Token(Token = "0x60000B8")]
	private static ushort get_audioTrackCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348D490", Offset = "0x348C890", Length = "0x76")]
	[NativeName("CanSetDirectAudioVolume")]
	[Token(Token = "0x6000053")]
	public bool get_canSetDirectAudioVolume() { }

	[Address(RVA = "0x348D450", Offset = "0x348C850", Length = "0x33")]
	[Token(Token = "0x60000C2")]
	private static bool get_canSetDirectAudioVolume_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348D550", Offset = "0x348C950", Length = "0x76")]
	[NativeName("CanSetPlaybackSpeed")]
	[Token(Token = "0x6000030")]
	public bool get_canSetPlaybackSpeed() { }

	[Address(RVA = "0x348D510", Offset = "0x348C910", Length = "0x33")]
	[Token(Token = "0x60000A2")]
	private static bool get_canSetPlaybackSpeed_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348D610", Offset = "0x348CA10", Length = "0x76")]
	[NativeName("CanSetSkipOnDrop")]
	[Token(Token = "0x600003C")]
	public bool get_canSetSkipOnDrop() { }

	[Address(RVA = "0x348D5D0", Offset = "0x348C9D0", Length = "0x33")]
	[Token(Token = "0x60000AE")]
	private static bool get_canSetSkipOnDrop_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348D850", Offset = "0x348CC50", Length = "0x76")]
	[NativeName("CanSetTime")]
	[Token(Token = "0x6000028")]
	public bool get_canSetTime() { }

	[Address(RVA = "0x348D810", Offset = "0x348CC10", Length = "0x33")]
	[Token(Token = "0x600009A")]
	private static bool get_canSetTime_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348D6D0", Offset = "0x348CAD0", Length = "0x76")]
	[NativeName("CanSetTimeSource")]
	[Token(Token = "0x6000035")]
	public bool get_canSetTimeSource() { }

	[Address(RVA = "0x348D690", Offset = "0x348CA90", Length = "0x33")]
	[Token(Token = "0x60000A7")]
	private static bool get_canSetTimeSource_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348D790", Offset = "0x348CB90", Length = "0x76")]
	[NativeName("CanSetTimeUpdateMode")]
	[Token(Token = "0x600000D")]
	public bool get_canSetTimeUpdateMode() { }

	[Address(RVA = "0x348D750", Offset = "0x348CB50", Length = "0x33")]
	[Token(Token = "0x600007F")]
	private static bool get_canSetTimeUpdateMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348D910", Offset = "0x348CD10", Length = "0x76")]
	[NativeName("CanStep")]
	[Token(Token = "0x600002E")]
	public bool get_canStep() { }

	[Address(RVA = "0x348D8D0", Offset = "0x348CCD0", Length = "0x33")]
	[Token(Token = "0x60000A0")]
	private static bool get_canStep_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348D9D0", Offset = "0x348CDD0", Length = "0x90")]
	[Token(Token = "0x6000009")]
	public VideoClip get_clip() { }

	[Address(RVA = "0x348D990", Offset = "0x348CD90", Length = "0x33")]
	[Token(Token = "0x600007B")]
	private static IntPtr get_clip_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348DAB0", Offset = "0x348CEB0", Length = "0x76")]
	[Token(Token = "0x600002D")]
	public double get_clockTime() { }

	[Address(RVA = "0x348DA70", Offset = "0x348CE70", Length = "0x33")]
	[Token(Token = "0x600009F")]
	private static double get_clockTime_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348BF20", Offset = "0x348B320", Length = "0x76")]
	[Token(Token = "0x600004B")]
	public ushort get_controlledAudioTrackCount() { }

	[Address(RVA = "0x348DB30", Offset = "0x348CF30", Length = "0x2A")]
	[Token(Token = "0x600004A")]
	public static ushort get_controlledAudioTrackMaxCount() { }

	[Address(RVA = "0x348DBA0", Offset = "0x348CFA0", Length = "0x76")]
	[Token(Token = "0x600003A")]
	public double get_externalReferenceTime() { }

	[Address(RVA = "0x348DB60", Offset = "0x348CF60", Length = "0x33")]
	[Token(Token = "0x60000AC")]
	private static double get_externalReferenceTime_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348DDE0", Offset = "0x348D1E0", Length = "0x76")]
	[Token(Token = "0x600002B")]
	public long get_frame() { }

	[Address(RVA = "0x348DDA0", Offset = "0x348D1A0", Length = "0x33")]
	[Token(Token = "0x600009D")]
	private static long get_frame_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348DC60", Offset = "0x348D060", Length = "0x76")]
	[Token(Token = "0x600003F")]
	public ulong get_frameCount() { }

	[Address(RVA = "0x348DC20", Offset = "0x348D020", Length = "0x33")]
	[Token(Token = "0x60000B1")]
	private static ulong get_frameCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348DD20", Offset = "0x348D120", Length = "0x76")]
	[Token(Token = "0x6000040")]
	public float get_frameRate() { }

	[Address(RVA = "0x348DCE0", Offset = "0x348D0E0", Length = "0x33")]
	[Token(Token = "0x60000B2")]
	private static float get_frameRate_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348DEA0", Offset = "0x348D2A0", Length = "0x76")]
	[Token(Token = "0x6000043")]
	public uint get_height() { }

	[Address(RVA = "0x348DE60", Offset = "0x348D260", Length = "0x33")]
	[Token(Token = "0x60000B5")]
	private static uint get_height_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348DF60", Offset = "0x348D360", Length = "0x76")]
	[Token(Token = "0x6000033")]
	public bool get_isLooping() { }

	[Address(RVA = "0x348DF20", Offset = "0x348D320", Length = "0x33")]
	[Token(Token = "0x60000A5")]
	private static bool get_isLooping_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E020", Offset = "0x348D420", Length = "0x76")]
	[NativeName("IsPaused")]
	[Token(Token = "0x6000027")]
	public bool get_isPaused() { }

	[Address(RVA = "0x348DFE0", Offset = "0x348D3E0", Length = "0x33")]
	[Token(Token = "0x6000099")]
	private static bool get_isPaused_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E0E0", Offset = "0x348D4E0", Length = "0x76")]
	[NativeName("IsPlaying")]
	[Token(Token = "0x6000026")]
	public bool get_isPlaying() { }

	[Address(RVA = "0x348E0A0", Offset = "0x348D4A0", Length = "0x33")]
	[Token(Token = "0x6000098")]
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E1A0", Offset = "0x348D5A0", Length = "0x76")]
	[NativeName("IsPrepared")]
	[Token(Token = "0x600001E")]
	public bool get_isPrepared() { }

	[Address(RVA = "0x348E160", Offset = "0x348D560", Length = "0x33")]
	[Token(Token = "0x6000090")]
	private static bool get_isPrepared_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E260", Offset = "0x348D660", Length = "0x76")]
	[Token(Token = "0x6000041")]
	public double get_length() { }

	[Address(RVA = "0x348E220", Offset = "0x348D620", Length = "0x33")]
	[Token(Token = "0x60000B3")]
	private static double get_length_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E320", Offset = "0x348D720", Length = "0x76")]
	[Token(Token = "0x6000045")]
	public uint get_pixelAspectRatioDenominator() { }

	[Address(RVA = "0x348E2E0", Offset = "0x348D6E0", Length = "0x33")]
	[Token(Token = "0x60000B7")]
	private static uint get_pixelAspectRatioDenominator_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E3E0", Offset = "0x348D7E0", Length = "0x76")]
	[Token(Token = "0x6000044")]
	public uint get_pixelAspectRatioNumerator() { }

	[Address(RVA = "0x348E3A0", Offset = "0x348D7A0", Length = "0x33")]
	[Token(Token = "0x60000B6")]
	private static uint get_pixelAspectRatioNumerator_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E560", Offset = "0x348D960", Length = "0x76")]
	[Token(Token = "0x6000031")]
	public float get_playbackSpeed() { }

	[Address(RVA = "0x348E520", Offset = "0x348D920", Length = "0x33")]
	[Token(Token = "0x60000A3")]
	private static float get_playbackSpeed_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E4A0", Offset = "0x348D8A0", Length = "0x76")]
	[Token(Token = "0x6000021")]
	public bool get_playOnAwake() { }

	[Address(RVA = "0x348E460", Offset = "0x348D860", Length = "0x33")]
	[Token(Token = "0x6000093")]
	private static bool get_playOnAwake_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E620", Offset = "0x348DA20", Length = "0x76")]
	[Token(Token = "0x600000B")]
	public VideoRenderMode get_renderMode() { }

	[Address(RVA = "0x348E5E0", Offset = "0x348D9E0", Length = "0x33")]
	[Token(Token = "0x600007D")]
	private static VideoRenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E6E0", Offset = "0x348DAE0", Length = "0x76")]
	[NativeName("AreFrameReadyEventsEnabled")]
	[Token(Token = "0x6000068")]
	public bool get_sendFrameReadyEvents() { }

	[Address(RVA = "0x348E6A0", Offset = "0x348DAA0", Length = "0x33")]
	[Token(Token = "0x60000C9")]
	private static bool get_sendFrameReadyEvents_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E7A0", Offset = "0x348DBA0", Length = "0x76")]
	[Token(Token = "0x600003D")]
	public bool get_skipOnDrop() { }

	[Address(RVA = "0x348E760", Offset = "0x348DB60", Length = "0x33")]
	[Token(Token = "0x60000AF")]
	private static bool get_skipOnDrop_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E860", Offset = "0x348DC60", Length = "0x76")]
	[Token(Token = "0x6000003")]
	public VideoSource get_source() { }

	[Address(RVA = "0x348E820", Offset = "0x348DC20", Length = "0x33")]
	[Token(Token = "0x6000075")]
	private static VideoSource get_source_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348EAA0", Offset = "0x348DEA0", Length = "0x90")]
	[Token(Token = "0x600000E")]
	public Camera get_targetCamera() { }

	[Address(RVA = "0x348EA60", Offset = "0x348DE60", Length = "0x33")]
	[Token(Token = "0x6000080")]
	private static IntPtr get_targetCamera_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E920", Offset = "0x348DD20", Length = "0x76")]
	[Token(Token = "0x600001A")]
	public Video3DLayout get_targetCamera3DLayout() { }

	[Address(RVA = "0x348E8E0", Offset = "0x348DCE0", Length = "0x33")]
	[Token(Token = "0x600008C")]
	private static Video3DLayout get_targetCamera3DLayout_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348E9E0", Offset = "0x348DDE0", Length = "0x76")]
	[Token(Token = "0x6000018")]
	public float get_targetCameraAlpha() { }

	[Address(RVA = "0x348E9A0", Offset = "0x348DDA0", Length = "0x33")]
	[Token(Token = "0x600008A")]
	private static float get_targetCameraAlpha_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348EB90", Offset = "0x348DF90", Length = "0x106")]
	[Token(Token = "0x6000014")]
	public string get_targetMaterialProperty() { }

	[Address(RVA = "0x348EB40", Offset = "0x348DF40", Length = "0x42")]
	[Token(Token = "0x6000086")]
	private static void get_targetMaterialProperty_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x348ECE0", Offset = "0x348E0E0", Length = "0x90")]
	[Token(Token = "0x6000012")]
	public Renderer get_targetMaterialRenderer() { }

	[Address(RVA = "0x348ECA0", Offset = "0x348E0A0", Length = "0x33")]
	[Token(Token = "0x6000084")]
	private static IntPtr get_targetMaterialRenderer_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348EDC0", Offset = "0x348E1C0", Length = "0x90")]
	[Token(Token = "0x6000010")]
	public RenderTexture get_targetTexture() { }

	[Address(RVA = "0x348ED80", Offset = "0x348E180", Length = "0x33")]
	[Token(Token = "0x6000082")]
	private static IntPtr get_targetTexture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348EEA0", Offset = "0x348E2A0", Length = "0x90")]
	[Token(Token = "0x600001C")]
	public Texture get_texture() { }

	[Address(RVA = "0x348EE60", Offset = "0x348E260", Length = "0x33")]
	[Token(Token = "0x600008E")]
	private static IntPtr get_texture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348F1C0", Offset = "0x348E5C0", Length = "0x76")]
	[Token(Token = "0x6000029")]
	public double get_time() { }

	[Address(RVA = "0x348F180", Offset = "0x348E580", Length = "0x33")]
	[Token(Token = "0x600009B")]
	private static double get_time_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348EF80", Offset = "0x348E380", Length = "0x76")]
	[Token(Token = "0x6000038")]
	public VideoTimeReference get_timeReference() { }

	[Address(RVA = "0x348EF40", Offset = "0x348E340", Length = "0x33")]
	[Token(Token = "0x60000AA")]
	private static VideoTimeReference get_timeReference_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348F040", Offset = "0x348E440", Length = "0x76")]
	[Token(Token = "0x6000036")]
	public VideoTimeSource get_timeSource() { }

	[Address(RVA = "0x348F000", Offset = "0x348E400", Length = "0x33")]
	[Token(Token = "0x60000A8")]
	private static VideoTimeSource get_timeSource_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348F100", Offset = "0x348E500", Length = "0x76")]
	[Token(Token = "0x6000005")]
	public VideoTimeUpdateMode get_timeUpdateMode() { }

	[Address(RVA = "0x348F0C0", Offset = "0x348E4C0", Length = "0x33")]
	[Token(Token = "0x6000077")]
	private static VideoTimeUpdateMode get_timeUpdateMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348F290", Offset = "0x348E690", Length = "0x106")]
	[Token(Token = "0x6000007")]
	public string get_url() { }

	[Address(RVA = "0x348F240", Offset = "0x348E640", Length = "0x42")]
	[Token(Token = "0x6000079")]
	private static void get_url_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x348F3E0", Offset = "0x348E7E0", Length = "0x76")]
	[Token(Token = "0x600001F")]
	public bool get_waitForFirstFrame() { }

	[Address(RVA = "0x348F3A0", Offset = "0x348E7A0", Length = "0x33")]
	[Token(Token = "0x6000091")]
	private static bool get_waitForFirstFrame_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348F4A0", Offset = "0x348E8A0", Length = "0x76")]
	[Token(Token = "0x6000042")]
	public uint get_width() { }

	[Address(RVA = "0x348F460", Offset = "0x348E860", Length = "0x33")]
	[Token(Token = "0x60000B4")]
	private static uint get_width_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348BBF0", Offset = "0x348AFF0", Length = "0x85")]
	[Token(Token = "0x6000048")]
	public ushort GetAudioChannelCount(ushort trackIndex) { }

	[Address(RVA = "0x348BBA0", Offset = "0x348AFA0", Length = "0x42")]
	[Token(Token = "0x60000BA")]
	private static ushort GetAudioChannelCount_Injected(IntPtr _unity_self, ushort trackIndex) { }

	[Address(RVA = "0x348BCE0", Offset = "0x348B0E0", Length = "0x115")]
	[Token(Token = "0x6000047")]
	public string GetAudioLanguageCode(ushort trackIndex) { }

	[Address(RVA = "0x348BC80", Offset = "0x348B080", Length = "0x52")]
	[Token(Token = "0x60000B9")]
	private static void GetAudioLanguageCode_Injected(IntPtr _unity_self, ushort trackIndex, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x348BE50", Offset = "0x348B250", Length = "0x85")]
	[Token(Token = "0x6000049")]
	public uint GetAudioSampleRate(ushort trackIndex) { }

	[Address(RVA = "0x348BE00", Offset = "0x348B200", Length = "0x42")]
	[Token(Token = "0x60000BB")]
	private static uint GetAudioSampleRate_Injected(IntPtr _unity_self, ushort trackIndex) { }

	[Address(RVA = "0x348BF20", Offset = "0x348B320", Length = "0x76")]
	[Token(Token = "0x600004D")]
	private ushort GetControlledAudioTrackCount() { }

	[Address(RVA = "0x348BEE0", Offset = "0x348B2E0", Length = "0x33")]
	[Token(Token = "0x60000BC")]
	private static ushort GetControlledAudioTrackCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348BFF0", Offset = "0x348B3F0", Length = "0x85")]
	[Token(Token = "0x6000056")]
	public bool GetDirectAudioMute(ushort trackIndex) { }

	[Address(RVA = "0x348BFA0", Offset = "0x348B3A0", Length = "0x42")]
	[Token(Token = "0x60000C5")]
	private static bool GetDirectAudioMute_Injected(IntPtr _unity_self, ushort trackIndex) { }

	[Address(RVA = "0x348C0D0", Offset = "0x348B4D0", Length = "0x85")]
	[Token(Token = "0x6000054")]
	public float GetDirectAudioVolume(ushort trackIndex) { }

	[Address(RVA = "0x348C080", Offset = "0x348B480", Length = "0x42")]
	[Token(Token = "0x60000C3")]
	private static float GetDirectAudioVolume_Injected(IntPtr _unity_self, ushort trackIndex) { }

	[Address(RVA = "0x348C1B0", Offset = "0x348B5B0", Length = "0x9F")]
	[NativeHeader("Modules/Audio/Public/AudioSource.h")]
	[Token(Token = "0x6000058")]
	public AudioSource GetTargetAudioSource(ushort trackIndex) { }

	[Address(RVA = "0x348C160", Offset = "0x348B560", Length = "0x42")]
	[Token(Token = "0x60000C7")]
	private static IntPtr GetTargetAudioSource_Injected(IntPtr _unity_self, ushort trackIndex) { }

	[Address(RVA = "0x348C250", Offset = "0x348B650", Length = "0x37")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000073")]
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

	[Address(RVA = "0x348C290", Offset = "0x348B690", Length = "0x37")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000071")]
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[Address(RVA = "0x348C2D0", Offset = "0x348B6D0", Length = "0x34")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000070")]
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[Address(RVA = "0x348C310", Offset = "0x348B710", Length = "0x37")]
	[RequiredByNativeCode]
	[Token(Token = "0x600006D")]
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[Address(RVA = "0x348C350", Offset = "0x348B750", Length = "0x34")]
	[RequiredByNativeCode]
	[Token(Token = "0x600006E")]
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[Address(RVA = "0x348C390", Offset = "0x348B790", Length = "0x34")]
	[RequiredByNativeCode]
	[Token(Token = "0x600006C")]
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[Address(RVA = "0x348C3D0", Offset = "0x348B7D0", Length = "0x34")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000072")]
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[Address(RVA = "0x348C410", Offset = "0x348B810", Length = "0x34")]
	[RequiredByNativeCode]
	[Token(Token = "0x600006F")]
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[Address(RVA = "0x348C4A0", Offset = "0x348B8A0", Length = "0x85")]
	[Token(Token = "0x6000050")]
	public bool IsAudioTrackEnabled(ushort trackIndex) { }

	[Address(RVA = "0x348C450", Offset = "0x348B850", Length = "0x42")]
	[Token(Token = "0x60000BF")]
	private static bool IsAudioTrackEnabled_Injected(IntPtr _unity_self, ushort trackIndex) { }

	[Address(RVA = "0x348C570", Offset = "0x348B970", Length = "0x76")]
	[Token(Token = "0x6000024")]
	public void Pause() { }

	[Address(RVA = "0x348C530", Offset = "0x348B930", Length = "0x33")]
	[Token(Token = "0x6000096")]
	private static void Pause_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348C630", Offset = "0x348BA30", Length = "0x76")]
	[Token(Token = "0x6000023")]
	public void Play() { }

	[Address(RVA = "0x348C5F0", Offset = "0x348B9F0", Length = "0x33")]
	[Token(Token = "0x6000095")]
	private static void Play_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348C6F0", Offset = "0x348BAF0", Length = "0x76")]
	[Token(Token = "0x600001D")]
	public void Prepare() { }

	[Address(RVA = "0x348C6B0", Offset = "0x348BAB0", Length = "0x33")]
	[Token(Token = "0x600008F")]
	private static void Prepare_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348F520", Offset = "0x348E920", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000067")]
	public void remove_clockResyncOccurred(TimeEventHandler value) { }

	[Address(RVA = "0x348F5C0", Offset = "0x348E9C0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000063")]
	public void remove_errorReceived(ErrorEventHandler value) { }

	[Address(RVA = "0x348F660", Offset = "0x348EA60", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000061")]
	public void remove_frameDropped(EventHandler value) { }

	[Address(RVA = "0x348F700", Offset = "0x348EB00", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600006B")]
	public void remove_frameReady(FrameReadyEventHandler value) { }

	[Address(RVA = "0x348F7A0", Offset = "0x348EBA0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600005D")]
	public void remove_loopPointReached(EventHandler value) { }

	[Address(RVA = "0x348F840", Offset = "0x348EC40", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600005B")]
	public void remove_prepareCompleted(EventHandler value) { }

	[Address(RVA = "0x348F8E0", Offset = "0x348ECE0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000065")]
	public void remove_seekCompleted(EventHandler value) { }

	[Address(RVA = "0x348F980", Offset = "0x348ED80", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600005F")]
	public void remove_started(EventHandler value) { }

	[Address(RVA = "0x348FA60", Offset = "0x348EE60", Length = "0x83")]
	[Token(Token = "0x6000017")]
	public void set_aspectRatio(VideoAspectRatio value) { }

	[Address(RVA = "0x348FA20", Offset = "0x348EE20", Length = "0x40")]
	[Token(Token = "0x6000089")]
	private static void set_aspectRatio_Injected(IntPtr _unity_self, VideoAspectRatio value) { }

	[Address(RVA = "0x348FB30", Offset = "0x348EF30", Length = "0x83")]
	[Token(Token = "0x6000052")]
	public void set_audioOutputMode(VideoAudioOutputMode value) { }

	[Address(RVA = "0x348FAF0", Offset = "0x348EEF0", Length = "0x40")]
	[Token(Token = "0x60000C1")]
	private static void set_audioOutputMode_Injected(IntPtr _unity_self, VideoAudioOutputMode value) { }

	[Address(RVA = "0x348FC10", Offset = "0x348F010", Length = "0xBA")]
	[Token(Token = "0x600000A")]
	public void set_clip(VideoClip value) { }

	[Address(RVA = "0x348FBC0", Offset = "0x348EFC0", Length = "0x42")]
	[Token(Token = "0x600007C")]
	private static void set_clip_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x348FCD0", Offset = "0x348F0D0", Length = "0x132")]
	[Token(Token = "0x600004C")]
	public void set_controlledAudioTrackCount(ushort value) { }

	[Address(RVA = "0x348FE60", Offset = "0x348F260", Length = "0x86")]
	[Token(Token = "0x600003B")]
	public void set_externalReferenceTime(double value) { }

	[Address(RVA = "0x348FE10", Offset = "0x348F210", Length = "0x43")]
	[Token(Token = "0x60000AD")]
	private static void set_externalReferenceTime_Injected(IntPtr _unity_self, double value) { }

	[Address(RVA = "0x348FF40", Offset = "0x348F340", Length = "0x85")]
	[Token(Token = "0x600002C")]
	public void set_frame(long value) { }

	[Address(RVA = "0x348FEF0", Offset = "0x348F2F0", Length = "0x42")]
	[Token(Token = "0x600009E")]
	private static void set_frame_Injected(IntPtr _unity_self, long value) { }

	[Address(RVA = "0x3490020", Offset = "0x348F420", Length = "0x86")]
	[Token(Token = "0x6000034")]
	public void set_isLooping(bool value) { }

	[Address(RVA = "0x348FFD0", Offset = "0x348F3D0", Length = "0x42")]
	[Token(Token = "0x60000A6")]
	private static void set_isLooping_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x34901E0", Offset = "0x348F5E0", Length = "0x86")]
	[Token(Token = "0x6000032")]
	public void set_playbackSpeed(float value) { }

	[Address(RVA = "0x3490190", Offset = "0x348F590", Length = "0x43")]
	[Token(Token = "0x60000A4")]
	private static void set_playbackSpeed_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3490100", Offset = "0x348F500", Length = "0x86")]
	[Token(Token = "0x6000022")]
	public void set_playOnAwake(bool value) { }

	[Address(RVA = "0x34900B0", Offset = "0x348F4B0", Length = "0x42")]
	[Token(Token = "0x6000094")]
	private static void set_playOnAwake_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x34902B0", Offset = "0x348F6B0", Length = "0x83")]
	[Token(Token = "0x600000C")]
	public void set_renderMode(VideoRenderMode value) { }

	[Address(RVA = "0x3490270", Offset = "0x348F670", Length = "0x40")]
	[Token(Token = "0x600007E")]
	private static void set_renderMode_Injected(IntPtr _unity_self, VideoRenderMode value) { }

	[Address(RVA = "0x3490390", Offset = "0x348F790", Length = "0x86")]
	[NativeName("EnableFrameReadyEvents")]
	[Token(Token = "0x6000069")]
	public void set_sendFrameReadyEvents(bool value) { }

	[Address(RVA = "0x3490340", Offset = "0x348F740", Length = "0x42")]
	[Token(Token = "0x60000CA")]
	private static void set_sendFrameReadyEvents_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3490470", Offset = "0x348F870", Length = "0x86")]
	[Token(Token = "0x600003E")]
	public void set_skipOnDrop(bool value) { }

	[Address(RVA = "0x3490420", Offset = "0x348F820", Length = "0x42")]
	[Token(Token = "0x60000B0")]
	private static void set_skipOnDrop_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3490540", Offset = "0x348F940", Length = "0x83")]
	[Token(Token = "0x6000004")]
	public void set_source(VideoSource value) { }

	[Address(RVA = "0x3490500", Offset = "0x348F900", Length = "0x40")]
	[Token(Token = "0x6000076")]
	private static void set_source_Injected(IntPtr _unity_self, VideoSource value) { }

	[Address(RVA = "0x34907D0", Offset = "0x348FBD0", Length = "0xBA")]
	[Token(Token = "0x600000F")]
	public void set_targetCamera(Camera value) { }

	[Address(RVA = "0x3490780", Offset = "0x348FB80", Length = "0x42")]
	[Token(Token = "0x6000081")]
	private static void set_targetCamera_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x3490610", Offset = "0x348FA10", Length = "0x83")]
	[Token(Token = "0x600001B")]
	public void set_targetCamera3DLayout(Video3DLayout value) { }

	[Address(RVA = "0x34905D0", Offset = "0x348F9D0", Length = "0x40")]
	[Token(Token = "0x600008D")]
	private static void set_targetCamera3DLayout_Injected(IntPtr _unity_self, Video3DLayout value) { }

	[Address(RVA = "0x34906F0", Offset = "0x348FAF0", Length = "0x86")]
	[Token(Token = "0x6000019")]
	public void set_targetCameraAlpha(float value) { }

	[Address(RVA = "0x34906A0", Offset = "0x348FAA0", Length = "0x43")]
	[Token(Token = "0x600008B")]
	private static void set_targetCameraAlpha_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x34908E0", Offset = "0x348FCE0", Length = "0x1C7")]
	[Token(Token = "0x6000015")]
	public void set_targetMaterialProperty(string value) { }

	[Address(RVA = "0x3490890", Offset = "0x348FC90", Length = "0x42")]
	[Token(Token = "0x6000087")]
	private static void set_targetMaterialProperty_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x3490B00", Offset = "0x348FF00", Length = "0xBA")]
	[Token(Token = "0x6000013")]
	public void set_targetMaterialRenderer(Renderer value) { }

	[Address(RVA = "0x3490AB0", Offset = "0x348FEB0", Length = "0x42")]
	[Token(Token = "0x6000085")]
	private static void set_targetMaterialRenderer_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x3490C10", Offset = "0x3490010", Length = "0xBA")]
	[Token(Token = "0x6000011")]
	public void set_targetTexture(RenderTexture value) { }

	[Address(RVA = "0x3490BC0", Offset = "0x348FFC0", Length = "0x42")]
	[Token(Token = "0x6000083")]
	private static void set_targetTexture_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x3490F90", Offset = "0x3490390", Length = "0x86")]
	[Token(Token = "0x600002A")]
	public void set_time(double value) { }

	[Address(RVA = "0x3490F40", Offset = "0x3490340", Length = "0x43")]
	[Token(Token = "0x600009C")]
	private static void set_time_Injected(IntPtr _unity_self, double value) { }

	[Address(RVA = "0x3490D10", Offset = "0x3490110", Length = "0x83")]
	[Token(Token = "0x6000039")]
	public void set_timeReference(VideoTimeReference value) { }

	[Address(RVA = "0x3490CD0", Offset = "0x34900D0", Length = "0x40")]
	[Token(Token = "0x60000AB")]
	private static void set_timeReference_Injected(IntPtr _unity_self, VideoTimeReference value) { }

	[Address(RVA = "0x3490DE0", Offset = "0x34901E0", Length = "0x83")]
	[Token(Token = "0x6000037")]
	public void set_timeSource(VideoTimeSource value) { }

	[Address(RVA = "0x3490DA0", Offset = "0x34901A0", Length = "0x40")]
	[Token(Token = "0x60000A9")]
	private static void set_timeSource_Injected(IntPtr _unity_self, VideoTimeSource value) { }

	[Address(RVA = "0x3490EB0", Offset = "0x34902B0", Length = "0x83")]
	[Token(Token = "0x6000006")]
	public void set_timeUpdateMode(VideoTimeUpdateMode value) { }

	[Address(RVA = "0x3490E70", Offset = "0x3490270", Length = "0x40")]
	[Token(Token = "0x6000078")]
	private static void set_timeUpdateMode_Injected(IntPtr _unity_self, VideoTimeUpdateMode value) { }

	[Address(RVA = "0x3491070", Offset = "0x3490470", Length = "0x1C7")]
	[Token(Token = "0x6000008")]
	public void set_url(string value) { }

	[Address(RVA = "0x3491020", Offset = "0x3490420", Length = "0x42")]
	[Token(Token = "0x600007A")]
	private static void set_url_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x3491290", Offset = "0x3490690", Length = "0x86")]
	[Token(Token = "0x6000020")]
	public void set_waitForFirstFrame(bool value) { }

	[Address(RVA = "0x3491240", Offset = "0x3490640", Length = "0x42")]
	[Token(Token = "0x6000092")]
	private static void set_waitForFirstFrame_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x348C7C0", Offset = "0x348BBC0", Length = "0x85")]
	[Token(Token = "0x600004E")]
	private void SetControlledAudioTrackCount(ushort value) { }

	[Address(RVA = "0x348C770", Offset = "0x348BB70", Length = "0x42")]
	[Token(Token = "0x60000BD")]
	private static void SetControlledAudioTrackCount_Injected(IntPtr _unity_self, ushort value) { }

	[Address(RVA = "0x348C8B0", Offset = "0x348BCB0", Length = "0x97")]
	[Token(Token = "0x6000057")]
	public void SetDirectAudioMute(ushort trackIndex, bool mute) { }

	[Address(RVA = "0x348C850", Offset = "0x348BC50", Length = "0x54")]
	[Token(Token = "0x60000C6")]
	private static void SetDirectAudioMute_Injected(IntPtr _unity_self, ushort trackIndex, bool mute) { }

	[Address(RVA = "0x348C9B0", Offset = "0x348BDB0", Length = "0x95")]
	[Token(Token = "0x6000055")]
	public void SetDirectAudioVolume(ushort trackIndex, float volume) { }

	[Address(RVA = "0x348C950", Offset = "0x348BD50", Length = "0x52")]
	[Token(Token = "0x60000C4")]
	private static void SetDirectAudioVolume_Injected(IntPtr _unity_self, ushort trackIndex, float volume) { }

	[Address(RVA = "0x348CAB0", Offset = "0x348BEB0", Length = "0xD2")]
	[Token(Token = "0x6000059")]
	public void SetTargetAudioSource(ushort trackIndex, AudioSource source) { }

	[Address(RVA = "0x348CA50", Offset = "0x348BE50", Length = "0x52")]
	[Token(Token = "0x60000C8")]
	private static void SetTargetAudioSource_Injected(IntPtr _unity_self, ushort trackIndex, IntPtr source) { }

	[Address(RVA = "0x348CBD0", Offset = "0x348BFD0", Length = "0x76")]
	[Token(Token = "0x600002F")]
	public void StepForward() { }

	[Address(RVA = "0x348CB90", Offset = "0x348BF90", Length = "0x33")]
	[Token(Token = "0x60000A1")]
	private static void StepForward_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x348CC90", Offset = "0x348C090", Length = "0x76")]
	[Token(Token = "0x6000025")]
	public void Stop() { }

	[Address(RVA = "0x348CC50", Offset = "0x348C050", Length = "0x33")]
	[Token(Token = "0x6000097")]
	private static void Stop_Injected(IntPtr _unity_self) { }

}

