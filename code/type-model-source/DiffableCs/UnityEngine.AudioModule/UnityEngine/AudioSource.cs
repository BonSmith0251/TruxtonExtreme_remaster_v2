namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioSourceBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000F")]
public sealed class AudioSource : AudioBehaviour
{

	[Token(Token = "0x17000014")]
	public AudioClip clip
	{
		[Address(RVA = "0x2FC9880", Offset = "0x2FC8C80", Length = "0xD1")]
		[Token(Token = "0x600005E")]
		 get { } //Length: 209
		[Address(RVA = "0x2FC9C80", Offset = "0x2FC9080", Length = "0xBA")]
		[Token(Token = "0x600005F")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000015")]
	internal object generatorObject
	{
		[Address(RVA = "0x2FC99A0", Offset = "0x2FC8DA0", Length = "0x90")]
		[Token(Token = "0x6000060")]
		internal get { } //Length: 144
		[Address(RVA = "0x2FC9C80", Offset = "0x2FC9080", Length = "0xBA")]
		[Token(Token = "0x6000061")]
		internal set { } //Length: 186
	}

	[Token(Token = "0x17000017")]
	public bool isPlaying
	{
		[Address(RVA = "0x2FC9A80", Offset = "0x2FC8E80", Length = "0x76")]
		[NativeName("IsPlayingScripting")]
		[Token(Token = "0x6000069")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000018")]
	public bool loop
	{
		[Address(RVA = "0x2FC9DE0", Offset = "0x2FC91E0", Length = "0x86")]
		[Token(Token = "0x600006A")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000016")]
	public AudioMixerGroup outputAudioMixerGroup
	{
		[Address(RVA = "0x2FC9EC0", Offset = "0x2FC92C0", Length = "0xBA")]
		[Token(Token = "0x6000062")]
		 set { } //Length: 186
	}

	[NativeProperty("StereoPan")]
	[Token(Token = "0x1700001A")]
	public float panStereo
	{
		[Address(RVA = "0x2FC9FD0", Offset = "0x2FC93D0", Length = "0x86")]
		[Token(Token = "0x600006C")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000012")]
	public float pitch
	{
		[Address(RVA = "0x2FC8BA0", Offset = "0x2FC7FA0", Length = "0x9B")]
		[Token(Token = "0x600005B")]
		 get { } //Length: 155
		[Address(RVA = "0x2FC95B0", Offset = "0x2FC89B0", Length = "0xAB")]
		[Token(Token = "0x600005C")]
		 set { } //Length: 171
	}

	[Token(Token = "0x17000019")]
	public bool playOnAwake
	{
		[Address(RVA = "0x2FCA0B0", Offset = "0x2FC94B0", Length = "0x86")]
		[Token(Token = "0x600006B")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700001B")]
	public int priority
	{
		[Address(RVA = "0x2FC9B40", Offset = "0x2FC8F40", Length = "0x76")]
		[Token(Token = "0x600006D")]
		 get { } //Length: 118
		[Address(RVA = "0x2FCA180", Offset = "0x2FC9580", Length = "0x83")]
		[Token(Token = "0x600006E")]
		 set { } //Length: 131
	}

	[NativeProperty("SecPosition")]
	[Token(Token = "0x17000013")]
	public float time
	{
		[Address(RVA = "0x2FCA260", Offset = "0x2FC9660", Length = "0x86")]
		[Token(Token = "0x600005D")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000011")]
	public float volume
	{
		[Address(RVA = "0x2FC9C00", Offset = "0x2FC9000", Length = "0x76")]
		[Token(Token = "0x6000059")]
		 get { } //Length: 118
		[Address(RVA = "0x2FCA340", Offset = "0x2FC9740", Length = "0x86")]
		[Token(Token = "0x600005A")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000070")]
	public AudioSource() { }

	[Address(RVA = "0x2FC9880", Offset = "0x2FC8C80", Length = "0xD1")]
	[Token(Token = "0x600005E")]
	public AudioClip get_clip() { }

	[Address(RVA = "0x2FC99A0", Offset = "0x2FC8DA0", Length = "0x90")]
	[Token(Token = "0x6000060")]
	internal object get_generatorObject() { }

	[Address(RVA = "0x2FC9960", Offset = "0x2FC8D60", Length = "0x33")]
	[Token(Token = "0x600007A")]
	private static IntPtr get_generatorObject_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC9A80", Offset = "0x2FC8E80", Length = "0x76")]
	[NativeName("IsPlayingScripting")]
	[Token(Token = "0x6000069")]
	public bool get_isPlaying() { }

	[Address(RVA = "0x2FC9A40", Offset = "0x2FC8E40", Length = "0x33")]
	[Token(Token = "0x600007F")]
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC8BA0", Offset = "0x2FC7FA0", Length = "0x9B")]
	[Token(Token = "0x600005B")]
	public float get_pitch() { }

	[Address(RVA = "0x2FC9B40", Offset = "0x2FC8F40", Length = "0x76")]
	[Token(Token = "0x600006D")]
	public int get_priority() { }

	[Address(RVA = "0x2FC9B00", Offset = "0x2FC8F00", Length = "0x33")]
	[Token(Token = "0x6000083")]
	private static int get_priority_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC9C00", Offset = "0x2FC9000", Length = "0x76")]
	[Token(Token = "0x6000059")]
	public float get_volume() { }

	[Address(RVA = "0x2FC9BC0", Offset = "0x2FC8FC0", Length = "0x33")]
	[Token(Token = "0x6000077")]
	private static float get_volume_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC8BA0", Offset = "0x2FC7FA0", Length = "0x9B")]
	[Token(Token = "0x6000053")]
	private static float GetPitch(AudioSource source) { }

	[Address(RVA = "0x2FC8B60", Offset = "0x2FC7F60", Length = "0x33")]
	[Token(Token = "0x6000071")]
	private static float GetPitch_Injected(IntPtr source) { }

	[Address(RVA = "0x2FC8E30", Offset = "0x2FC8230", Length = "0xE")]
	[Token(Token = "0x600006F")]
	public void GetSpectrumData(Single[] samples, int channel, FFTWindow window) { }

	[Address(RVA = "0x2FC8CB0", Offset = "0x2FC80B0", Length = "0x17D")]
	[NativeThrows]
	[Token(Token = "0x6000058")]
	private static void GetSpectrumDataHelper(AudioSource source, out Single[] samples, int channel, FFTWindow window) { }

	[Address(RVA = "0x2FC8C40", Offset = "0x2FC8040", Length = "0x62")]
	[Token(Token = "0x6000076")]
	private static void GetSpectrumDataHelper_Injected(IntPtr source, out BlittableArrayWrapper samples, int channel, FFTWindow window) { }

	[Address(RVA = "0x2FC8E80", Offset = "0x2FC8280", Length = "0x76")]
	[Token(Token = "0x6000067")]
	public void Pause() { }

	[Address(RVA = "0x2FC8E40", Offset = "0x2FC8240", Length = "0x33")]
	[Token(Token = "0x600007D")]
	private static void Pause_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC94C0", Offset = "0x2FC88C0", Length = "0x9D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000063")]
	public void Play() { }

	[Address(RVA = "0x2FC8F50", Offset = "0x2FC8350", Length = "0xAA")]
	[Token(Token = "0x6000055")]
	private static void PlayHelper(AudioSource source, ulong delay) { }

	[Address(RVA = "0x2FC8F00", Offset = "0x2FC8300", Length = "0x42")]
	[Token(Token = "0x6000073")]
	private static void PlayHelper_Injected(IntPtr source, ulong delay) { }

	[Address(RVA = "0x2FC9170", Offset = "0x2FC8570", Length = "0x197")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000064")]
	public void PlayOneShot(AudioClip clip) { }

	[Address(RVA = "0x2FC9310", Offset = "0x2FC8710", Length = "0x1A4")]
	[Token(Token = "0x6000065")]
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	[Address(RVA = "0x2FC9060", Offset = "0x2FC8460", Length = "0x10D")]
	[Token(Token = "0x6000056")]
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	[Address(RVA = "0x2FC9000", Offset = "0x2FC8400", Length = "0x52")]
	[Token(Token = "0x6000074")]
	private static void PlayOneShotHelper_Injected(IntPtr source, IntPtr clip, float volumeScale) { }

	[Address(RVA = "0x2FC9C80", Offset = "0x2FC9080", Length = "0xBA")]
	[Token(Token = "0x600005F")]
	public void set_clip(AudioClip value) { }

	[Address(RVA = "0x2FC9C80", Offset = "0x2FC9080", Length = "0xBA")]
	[Token(Token = "0x6000061")]
	internal void set_generatorObject(object value) { }

	[Address(RVA = "0x2FC9D40", Offset = "0x2FC9140", Length = "0x42")]
	[Token(Token = "0x600007B")]
	private static void set_generatorObject_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x2FC9DE0", Offset = "0x2FC91E0", Length = "0x86")]
	[Token(Token = "0x600006A")]
	public void set_loop(bool value) { }

	[Address(RVA = "0x2FC9D90", Offset = "0x2FC9190", Length = "0x42")]
	[Token(Token = "0x6000080")]
	private static void set_loop_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FC9EC0", Offset = "0x2FC92C0", Length = "0xBA")]
	[Token(Token = "0x6000062")]
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[Address(RVA = "0x2FC9E70", Offset = "0x2FC9270", Length = "0x42")]
	[Token(Token = "0x600007C")]
	private static void set_outputAudioMixerGroup_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x2FC9FD0", Offset = "0x2FC93D0", Length = "0x86")]
	[Token(Token = "0x600006C")]
	public void set_panStereo(float value) { }

	[Address(RVA = "0x2FC9F80", Offset = "0x2FC9380", Length = "0x43")]
	[Token(Token = "0x6000082")]
	private static void set_panStereo_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FC95B0", Offset = "0x2FC89B0", Length = "0xAB")]
	[Token(Token = "0x600005C")]
	public void set_pitch(float value) { }

	[Address(RVA = "0x2FCA0B0", Offset = "0x2FC94B0", Length = "0x86")]
	[Token(Token = "0x600006B")]
	public void set_playOnAwake(bool value) { }

	[Address(RVA = "0x2FCA060", Offset = "0x2FC9460", Length = "0x42")]
	[Token(Token = "0x6000081")]
	private static void set_playOnAwake_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FCA180", Offset = "0x2FC9580", Length = "0x83")]
	[Token(Token = "0x600006E")]
	public void set_priority(int value) { }

	[Address(RVA = "0x2FCA140", Offset = "0x2FC9540", Length = "0x40")]
	[Token(Token = "0x6000084")]
	private static void set_priority_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x2FCA260", Offset = "0x2FC9660", Length = "0x86")]
	[Token(Token = "0x600005D")]
	public void set_time(float value) { }

	[Address(RVA = "0x2FCA210", Offset = "0x2FC9610", Length = "0x43")]
	[Token(Token = "0x6000079")]
	private static void set_time_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FCA340", Offset = "0x2FC9740", Length = "0x86")]
	[Token(Token = "0x600005A")]
	public void set_volume(float value) { }

	[Address(RVA = "0x2FCA2F0", Offset = "0x2FC96F0", Length = "0x43")]
	[Token(Token = "0x6000078")]
	private static void set_volume_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FC95B0", Offset = "0x2FC89B0", Length = "0xAB")]
	[Token(Token = "0x6000054")]
	private static void SetPitch(AudioSource source, float pitch) { }

	[Address(RVA = "0x2FC9560", Offset = "0x2FC8960", Length = "0x43")]
	[Token(Token = "0x6000072")]
	private static void SetPitch_Injected(IntPtr source, float pitch) { }

	[Address(RVA = "0x2FC96B0", Offset = "0x2FC8AB0", Length = "0x78")]
	[Token(Token = "0x6000066")]
	public void Stop() { }

	[Address(RVA = "0x2FC9730", Offset = "0x2FC8B30", Length = "0x86")]
	[Token(Token = "0x6000057")]
	private void Stop(bool stopOneShots) { }

	[Address(RVA = "0x2FC9660", Offset = "0x2FC8A60", Length = "0x42")]
	[Token(Token = "0x6000075")]
	private static void Stop_Injected(IntPtr _unity_self, bool stopOneShots) { }

	[Address(RVA = "0x2FC9800", Offset = "0x2FC8C00", Length = "0x76")]
	[Token(Token = "0x6000068")]
	public void UnPause() { }

	[Address(RVA = "0x2FC97C0", Offset = "0x2FC8BC0", Length = "0x33")]
	[Token(Token = "0x600007E")]
	private static void UnPause_Injected(IntPtr _unity_self) { }

}

