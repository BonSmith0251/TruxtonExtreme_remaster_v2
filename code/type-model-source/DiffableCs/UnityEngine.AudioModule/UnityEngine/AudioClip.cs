namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("AudioClipBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000A")]
public sealed class AudioClip : AudioResource, IAudioGenerator, ICapabilities
{
	[Token(Token = "0x200000B")]
	internal sealed class PCMReaderCallback : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x600003D")]
		public PCMReaderCallback(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x600003E")]
		public override void Invoke(Single[] data) { }

	}

	[Token(Token = "0x200000C")]
	internal sealed class PCMSetPositionCallback : MulticastDelegate
	{

		[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
		[Token(Token = "0x600003F")]
		public PCMSetPositionCallback(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000040")]
		public override void Invoke(int position) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000026")]
	private PCMReaderCallback m_PCMReaderCallback; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000027")]
	private PCMSetPositionCallback m_PCMSetPositionCallback; //Field offset: 0x20

	[Token(Token = "0x14000001")]
	private event PCMReaderCallback m_PCMReaderCallback
	{
		[Address(RVA = "0x2FC6300", Offset = "0x2FC5700", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000022")]
		private add { } //Length: 158
		[Address(RVA = "0x2FC6BC0", Offset = "0x2FC5FC0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000023")]
		private remove { } //Length: 158
	}

	[Token(Token = "0x14000002")]
	private event PCMSetPositionCallback m_PCMSetPositionCallback
	{
		[Address(RVA = "0x2FC63A0", Offset = "0x2FC57A0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000024")]
		private add { } //Length: 158
		[Address(RVA = "0x2FC6C60", Offset = "0x2FC6060", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000025")]
		private remove { } //Length: 158
	}

	[Token(Token = "0x17000008")]
	public bool ambisonic
	{
		[Address(RVA = "0x2FC6480", Offset = "0x2FC5880", Length = "0x76")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 118
	}

	[NativeProperty("ChannelCount")]
	[Token(Token = "0x17000003")]
	public int channels
	{
		[Address(RVA = "0x2FC6540", Offset = "0x2FC5940", Length = "0x76")]
		[Token(Token = "0x600000E")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000004")]
	public int frequency
	{
		[Address(RVA = "0x2FC6600", Offset = "0x2FC5A00", Length = "0x76")]
		[Token(Token = "0x600000F")]
		 get { } //Length: 118
	}

	[Obsolete("Use AudioClip.loadState instead to get more detailed information about the loading process.")]
	[Token(Token = "0x17000005")]
	public bool isReadyToPlay
	{
		[Address(RVA = "0x2FC66C0", Offset = "0x2FC5AC0", Length = "0x76")]
		[NativeName("ReadyToPlay")]
		[Token(Token = "0x6000010")]
		 get { } //Length: 118
	}

	[NativeProperty("LengthSec")]
	[Token(Token = "0x17000001")]
	public float length
	{
		[Address(RVA = "0x2FC6780", Offset = "0x2FC5B80", Length = "0x76")]
		[Token(Token = "0x600000C")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000009")]
	public bool loadInBackground
	{
		[Address(RVA = "0x2FC6840", Offset = "0x2FC5C40", Length = "0x76")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000A")]
	public AudioDataLoadState loadState
	{
		[Address(RVA = "0x2FC6900", Offset = "0x2FC5D00", Length = "0x76")]
		[NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = True)]
		[Token(Token = "0x6000017")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000006")]
	public AudioClipLoadType loadType
	{
		[Address(RVA = "0x2FC69C0", Offset = "0x2FC5DC0", Length = "0x76")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000007")]
	public bool preloadAudioData
	{
		[Address(RVA = "0x2FC6A80", Offset = "0x2FC5E80", Length = "0x76")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 118
	}

	[NativeProperty("SampleCount")]
	[Token(Token = "0x17000002")]
	public int samples
	{
		[Address(RVA = "0x2FC6B40", Offset = "0x2FC5F40", Length = "0x76")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000C")]
	private override bool UnityEngine.Audio.GeneratorInstance.ICapabilities.isFinite
	{
		[Address(RVA = "0x2FC60D0", Offset = "0x2FC54D0", Length = "0x3E")]
		[Token(Token = "0x6000029")]
		private get { } //Length: 62
	}

	[Token(Token = "0x1700000B")]
	private override bool UnityEngine.Audio.GeneratorInstance.ICapabilities.isRealtime
	{
		[Address(RVA = "0x2FC6110", Offset = "0x2FC5510", Length = "0x3E")]
		[Token(Token = "0x6000028")]
		private get { } //Length: 62
	}

	[Token(Token = "0x1700000D")]
	private override Nullable<DiscreteTime> UnityEngine.Audio.GeneratorInstance.ICapabilities.length
	{
		[Address(RVA = "0x2FC6150", Offset = "0x2FC5550", Length = "0x3E")]
		[Token(Token = "0x600002A")]
		private get { } //Length: 62
	}

	[Address(RVA = "0x2FC6290", Offset = "0x2FC5690", Length = "0x6F")]
	[Token(Token = "0x6000006")]
	private AudioClip() { }

	[Address(RVA = "0x2FC6300", Offset = "0x2FC5700", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000022")]
	private void add_m_PCMReaderCallback(PCMReaderCallback value) { }

	[Address(RVA = "0x2FC63A0", Offset = "0x2FC57A0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000024")]
	private void add_m_PCMSetPositionCallback(PCMSetPositionCallback value) { }

	[Address(RVA = "0x2FC4C10", Offset = "0x2FC4010", Length = "0x54")]
	[Token(Token = "0x6000009")]
	private static AudioClip Construct_Internal() { }

	[Address(RVA = "0x2FC4BE0", Offset = "0x2FC3FE0", Length = "0x2A")]
	[Token(Token = "0x600002E")]
	private static IntPtr Construct_Internal_Injected() { }

	[Address(RVA = "0x2FC4F10", Offset = "0x2FC4310", Length = "0x2D")]
	[Token(Token = "0x6000020")]
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback) { }

	[Address(RVA = "0x2FC52A0", Offset = "0x2FC46A0", Length = "0x28")]
	[Token(Token = "0x600001F")]
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	[Address(RVA = "0x2FC4F40", Offset = "0x2FC4340", Length = "0x3A")]
	[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
	[Token(Token = "0x600001E")]
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback) { }

	[Address(RVA = "0x2FC4EE0", Offset = "0x2FC42E0", Length = "0x30")]
	[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
	[Token(Token = "0x600001D")]
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, PCMReaderCallback pcmreadercallback) { }

	[Address(RVA = "0x2FC52D0", Offset = "0x2FC46D0", Length = "0x28")]
	[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
	[Token(Token = "0x600001C")]
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream) { }

	[Address(RVA = "0x2FC4F80", Offset = "0x2FC4380", Length = "0x31C")]
	[Token(Token = "0x6000021")]
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback) { }

	[Address(RVA = "0x2FC4CE0", Offset = "0x2FC40E0", Length = "0x1F8")]
	[Token(Token = "0x600000B")]
	private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	[Address(RVA = "0x2FC4C70", Offset = "0x2FC4070", Length = "0x6D")]
	[Token(Token = "0x6000030")]
	private static void CreateUserSound_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, int lengthSamples, int channels, int frequency, bool stream) { }

	[Address(RVA = "0x2FC6480", Offset = "0x2FC5880", Length = "0x76")]
	[Token(Token = "0x6000015")]
	public bool get_ambisonic() { }

	[Address(RVA = "0x2FC6440", Offset = "0x2FC5840", Length = "0x33")]
	[Token(Token = "0x600003A")]
	private static bool get_ambisonic_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC6540", Offset = "0x2FC5940", Length = "0x76")]
	[Token(Token = "0x600000E")]
	public int get_channels() { }

	[Address(RVA = "0x2FC6500", Offset = "0x2FC5900", Length = "0x33")]
	[Token(Token = "0x6000033")]
	private static int get_channels_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC6600", Offset = "0x2FC5A00", Length = "0x76")]
	[Token(Token = "0x600000F")]
	public int get_frequency() { }

	[Address(RVA = "0x2FC65C0", Offset = "0x2FC59C0", Length = "0x33")]
	[Token(Token = "0x6000034")]
	private static int get_frequency_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC66C0", Offset = "0x2FC5AC0", Length = "0x76")]
	[NativeName("ReadyToPlay")]
	[Token(Token = "0x6000010")]
	public bool get_isReadyToPlay() { }

	[Address(RVA = "0x2FC6680", Offset = "0x2FC5A80", Length = "0x33")]
	[Token(Token = "0x6000035")]
	private static bool get_isReadyToPlay_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC6780", Offset = "0x2FC5B80", Length = "0x76")]
	[Token(Token = "0x600000C")]
	public float get_length() { }

	[Address(RVA = "0x2FC6740", Offset = "0x2FC5B40", Length = "0x33")]
	[Token(Token = "0x6000031")]
	private static float get_length_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC6840", Offset = "0x2FC5C40", Length = "0x76")]
	[Token(Token = "0x6000016")]
	public bool get_loadInBackground() { }

	[Address(RVA = "0x2FC6800", Offset = "0x2FC5C00", Length = "0x33")]
	[Token(Token = "0x600003B")]
	private static bool get_loadInBackground_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC6900", Offset = "0x2FC5D00", Length = "0x76")]
	[NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = True)]
	[Token(Token = "0x6000017")]
	public AudioDataLoadState get_loadState() { }

	[Address(RVA = "0x2FC68C0", Offset = "0x2FC5CC0", Length = "0x33")]
	[Token(Token = "0x600003C")]
	private static AudioDataLoadState get_loadState_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC69C0", Offset = "0x2FC5DC0", Length = "0x76")]
	[Token(Token = "0x6000011")]
	public AudioClipLoadType get_loadType() { }

	[Address(RVA = "0x2FC6980", Offset = "0x2FC5D80", Length = "0x33")]
	[Token(Token = "0x6000036")]
	private static AudioClipLoadType get_loadType_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC6A80", Offset = "0x2FC5E80", Length = "0x76")]
	[Token(Token = "0x6000014")]
	public bool get_preloadAudioData() { }

	[Address(RVA = "0x2FC6A40", Offset = "0x2FC5E40", Length = "0x33")]
	[Token(Token = "0x6000039")]
	private static bool get_preloadAudioData_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC6B40", Offset = "0x2FC5F40", Length = "0x76")]
	[Token(Token = "0x600000D")]
	public int get_samples() { }

	[Address(RVA = "0x2FC6B00", Offset = "0x2FC5F00", Length = "0x33")]
	[Token(Token = "0x6000032")]
	private static int get_samples_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC5610", Offset = "0x2FC4A10", Length = "0x13B")]
	[Token(Token = "0x6000018")]
	public bool GetData(Span<Single> data, int offsetSamples) { }

	[Address(RVA = "0x2FC5360", Offset = "0x2FC4760", Length = "0x182")]
	[Token(Token = "0x6000019")]
	public bool GetData(Single[] data, int offsetSamples) { }

	[Address(RVA = "0x2FC54F0", Offset = "0x2FC48F0", Length = "0x117")]
	[Token(Token = "0x6000007")]
	private static bool GetData(AudioClip clip, Span<Single> data, int samplesOffset) { }

	[Address(RVA = "0x2FC5300", Offset = "0x2FC4700", Length = "0x52")]
	[Token(Token = "0x600002C")]
	private static bool GetData_Injected(IntPtr clip, ref ManagedSpanWrapper data, int samplesOffset) { }

	[Address(RVA = "0x2FC57A0", Offset = "0x2FC4BA0", Length = "0x106")]
	[Token(Token = "0x600000A")]
	private string GetName() { }

	[Address(RVA = "0x2FC5750", Offset = "0x2FC4B50", Length = "0x42")]
	[Token(Token = "0x600002F")]
	private static void GetName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FC58B0", Offset = "0x2FC4CB0", Length = "0x1B")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000026")]
	private void InvokePCMReaderCallback_Internal(Single[] data) { }

	[Address(RVA = "0x2FC58D0", Offset = "0x2FC4CD0", Length = "0x1B")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000027")]
	private void InvokePCMSetPositionCallback_Internal(int position) { }

	[Address(RVA = "0x2FC5930", Offset = "0x2FC4D30", Length = "0x76")]
	[Token(Token = "0x6000012")]
	public bool LoadAudioData() { }

	[Address(RVA = "0x2FC58F0", Offset = "0x2FC4CF0", Length = "0x33")]
	[Token(Token = "0x6000037")]
	private static bool LoadAudioData_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC6BC0", Offset = "0x2FC5FC0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000023")]
	private void remove_m_PCMReaderCallback(PCMReaderCallback value) { }

	[Address(RVA = "0x2FC6C60", Offset = "0x2FC6060", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000025")]
	private void remove_m_PCMSetPositionCallback(PCMSetPositionCallback value) { }

	[Address(RVA = "0x2FC5D00", Offset = "0x2FC5100", Length = "0x2A2")]
	[Token(Token = "0x600001A")]
	public bool SetData(Single[] data, int offsetSamples) { }

	[Address(RVA = "0x2FC5A10", Offset = "0x2FC4E10", Length = "0x2E9")]
	[Token(Token = "0x600001B")]
	public bool SetData(ReadOnlySpan<Single> data, int offsetSamples) { }

	[Address(RVA = "0x2FC5FB0", Offset = "0x2FC53B0", Length = "0x117")]
	[Token(Token = "0x6000008")]
	private static bool SetData(AudioClip clip, ReadOnlySpan<Single> data, int samplesOffset) { }

	[Address(RVA = "0x2FC59B0", Offset = "0x2FC4DB0", Length = "0x52")]
	[Token(Token = "0x600002D")]
	private static bool SetData_Injected(IntPtr clip, ref ManagedSpanWrapper data, int samplesOffset) { }

	[Address(RVA = "0x2FC60D0", Offset = "0x2FC54D0", Length = "0x3E")]
	[Token(Token = "0x6000029")]
	private override bool UnityEngine.Audio.GeneratorInstance.ICapabilities.get_isFinite() { }

	[Address(RVA = "0x2FC6110", Offset = "0x2FC5510", Length = "0x3E")]
	[Token(Token = "0x6000028")]
	private override bool UnityEngine.Audio.GeneratorInstance.ICapabilities.get_isRealtime() { }

	[Address(RVA = "0x2FC6150", Offset = "0x2FC5550", Length = "0x3E")]
	[Token(Token = "0x600002A")]
	private override Nullable<DiscreteTime> UnityEngine.Audio.GeneratorInstance.ICapabilities.get_length() { }

	[Address(RVA = "0x2FC6190", Offset = "0x2FC5590", Length = "0x3E")]
	[Token(Token = "0x600002B")]
	private override GeneratorInstance UnityEngine.Audio.IAudioGenerator.CreateInstance(ControlContext context, Nullable<AudioFormat> nestedFormat, CreationParameters parameters) { }

	[Address(RVA = "0x2FC6210", Offset = "0x2FC5610", Length = "0x76")]
	[Token(Token = "0x6000013")]
	public bool UnloadAudioData() { }

	[Address(RVA = "0x2FC61D0", Offset = "0x2FC55D0", Length = "0x33")]
	[Token(Token = "0x6000038")]
	private static bool UnloadAudioData_Injected(IntPtr _unity_self) { }

}

