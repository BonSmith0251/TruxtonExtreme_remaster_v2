namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioListenerBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000E")]
public sealed class AudioListener : AudioBehaviour
{

	[NativeProperty("ListenerPause")]
	[Token(Token = "0x1700000F")]
	public static bool pause
	{
		[Address(RVA = "0x2FC7090", Offset = "0x2FC6490", Length = "0x2A")]
		[Token(Token = "0x6000046")]
		 get { } //Length: 42
		[Address(RVA = "0x2FC71B0", Offset = "0x2FC65B0", Length = "0x33")]
		[Token(Token = "0x6000047")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000010")]
	public AudioVelocityUpdateMode velocityUpdateMode
	{
		[Address(RVA = "0x2FC7100", Offset = "0x2FC6500", Length = "0x76")]
		[Token(Token = "0x6000048")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC7230", Offset = "0x2FC6630", Length = "0x83")]
		[Token(Token = "0x6000049")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700000E")]
	public static float volume
	{
		[Address(RVA = "0x2FC7180", Offset = "0x2FC6580", Length = "0x2A")]
		[Token(Token = "0x6000044")]
		 get { } //Length: 42
		[Address(RVA = "0x2FC72C0", Offset = "0x2FC66C0", Length = "0x3A")]
		[Token(Token = "0x6000045")]
		 set { } //Length: 58
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600004E")]
	public AudioListener() { }

	[Address(RVA = "0x2FC7090", Offset = "0x2FC6490", Length = "0x2A")]
	[Token(Token = "0x6000046")]
	public static bool get_pause() { }

	[Address(RVA = "0x2FC7100", Offset = "0x2FC6500", Length = "0x76")]
	[Token(Token = "0x6000048")]
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	[Address(RVA = "0x2FC70C0", Offset = "0x2FC64C0", Length = "0x33")]
	[Token(Token = "0x6000051")]
	private static AudioVelocityUpdateMode get_velocityUpdateMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC7180", Offset = "0x2FC6580", Length = "0x2A")]
	[Token(Token = "0x6000044")]
	public static float get_volume() { }

	[Address(RVA = "0x2FC6E50", Offset = "0x2FC6250", Length = "0x56")]
	[Obsolete("GetOutputData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
	[Token(Token = "0x600004A")]
	public static Single[] GetOutputData(int numSamples, int channel) { }

	[Address(RVA = "0x2FC6E40", Offset = "0x2FC6240", Length = "0x8")]
	[Token(Token = "0x600004B")]
	public static void GetOutputData(Single[] samples, int channel) { }

	[Address(RVA = "0x2FC6D40", Offset = "0x2FC6140", Length = "0xF2")]
	[NativeThrows]
	[Token(Token = "0x6000042")]
	private static void GetOutputDataHelper(out Single[] samples, int channel) { }

	[Address(RVA = "0x2FC6D00", Offset = "0x2FC6100", Length = "0x40")]
	[Token(Token = "0x600004F")]
	private static void GetOutputDataHelper_Injected(out BlittableArrayWrapper samples, int channel) { }

	[Address(RVA = "0x2FC7010", Offset = "0x2FC6410", Length = "0x66")]
	[Obsolete("GetSpectrumData returning a float[] is deprecated, use GetSpectrumData and pass a pre allocated array instead.")]
	[Token(Token = "0x600004C")]
	public static Single[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	[Address(RVA = "0x2FC7080", Offset = "0x2FC6480", Length = "0x8")]
	[Token(Token = "0x600004D")]
	public static void GetSpectrumData(Single[] samples, int channel, FFTWindow window) { }

	[Address(RVA = "0x2FC6F00", Offset = "0x2FC6300", Length = "0x106")]
	[NativeThrows]
	[Token(Token = "0x6000043")]
	private static void GetSpectrumDataHelper(out Single[] samples, int channel, FFTWindow window) { }

	[Address(RVA = "0x2FC6EB0", Offset = "0x2FC62B0", Length = "0x50")]
	[Token(Token = "0x6000050")]
	private static void GetSpectrumDataHelper_Injected(out BlittableArrayWrapper samples, int channel, FFTWindow window) { }

	[Address(RVA = "0x2FC71B0", Offset = "0x2FC65B0", Length = "0x33")]
	[Token(Token = "0x6000047")]
	public static void set_pause(bool value) { }

	[Address(RVA = "0x2FC7230", Offset = "0x2FC6630", Length = "0x83")]
	[Token(Token = "0x6000049")]
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	[Address(RVA = "0x2FC71F0", Offset = "0x2FC65F0", Length = "0x40")]
	[Token(Token = "0x6000052")]
	private static void set_velocityUpdateMode_Injected(IntPtr _unity_self, AudioVelocityUpdateMode value) { }

	[Address(RVA = "0x2FC72C0", Offset = "0x2FC66C0", Length = "0x3A")]
	[Token(Token = "0x6000045")]
	public static void set_volume(float value) { }

}

