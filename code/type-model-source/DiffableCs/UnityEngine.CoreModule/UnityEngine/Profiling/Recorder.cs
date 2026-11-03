namespace UnityEngine.Profiling;

[Token(Token = "0x2000202")]
[UsedByNativeCode]
public sealed class Recorder
{
	[Token(Token = "0x4000734")]
	private const ProfilerRecorderOptions s_RecorderDefaultOptions = 153; //Field offset: 0x0
	[Token(Token = "0x4000735")]
	internal static Recorder s_InvalidRecorder; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000736")]
	private ProfilerRecorder m_RecorderCPU; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000737")]
	private ProfilerRecorder m_RecorderGPU; //Field offset: 0x18

	[Token(Token = "0x17000370")]
	public long elapsedNanoseconds
	{
		[Address(RVA = "0x3081D10", Offset = "0x3081110", Length = "0x30")]
		[Token(Token = "0x6001711")]
		 get { } //Length: 48
	}

	[Token(Token = "0x1700036F")]
	public bool enabled
	{
		[Address(RVA = "0x3081D40", Offset = "0x3081140", Length = "0xD")]
		[Token(Token = "0x600170F")]
		 get { } //Length: 13
		[Address(RVA = "0x3081B70", Offset = "0x3080F70", Length = "0x6C")]
		[Token(Token = "0x6001710")]
		 set { } //Length: 108
	}

	[Token(Token = "0x17000371")]
	public long gpuElapsedNanoseconds
	{
		[Address(RVA = "0x3081D50", Offset = "0x3081150", Length = "0x30")]
		[Token(Token = "0x6001712")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000373")]
	public int gpuSampleBlockCount
	{
		[Address(RVA = "0x3081D80", Offset = "0x3081180", Length = "0x56")]
		[Token(Token = "0x6001714")]
		 get { } //Length: 86
	}

	[Token(Token = "0x17000372")]
	public int sampleBlockCount
	{
		[Address(RVA = "0x3081DE0", Offset = "0x30811E0", Length = "0x56")]
		[Token(Token = "0x6001713")]
		 get { } //Length: 86
	}

	[Address(RVA = "0x3081BE0", Offset = "0x3080FE0", Length = "0x67")]
	[Token(Token = "0x6001716")]
	private static Recorder() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600170C")]
	internal Recorder() { }

	[Address(RVA = "0x3081C50", Offset = "0x3081050", Length = "0xB9")]
	[Token(Token = "0x600170D")]
	internal Recorder(ProfilerRecorderHandle handle) { }

	[Address(RVA = "0x3081B00", Offset = "0x3080F00", Length = "0x6B")]
	[Token(Token = "0x600170E")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x3081D10", Offset = "0x3081110", Length = "0x30")]
	[Token(Token = "0x6001711")]
	public long get_elapsedNanoseconds() { }

	[Address(RVA = "0x3081D40", Offset = "0x3081140", Length = "0xD")]
	[Token(Token = "0x600170F")]
	public bool get_enabled() { }

	[Address(RVA = "0x3081D50", Offset = "0x3081150", Length = "0x30")]
	[Token(Token = "0x6001712")]
	public long get_gpuElapsedNanoseconds() { }

	[Address(RVA = "0x3081D80", Offset = "0x3081180", Length = "0x56")]
	[Token(Token = "0x6001714")]
	public int get_gpuSampleBlockCount() { }

	[Address(RVA = "0x3081DE0", Offset = "0x30811E0", Length = "0x56")]
	[Token(Token = "0x6001713")]
	public int get_sampleBlockCount() { }

	[Address(RVA = "0x3081B70", Offset = "0x3080F70", Length = "0x6C")]
	[Token(Token = "0x6001710")]
	public void set_enabled(bool value) { }

	[Address(RVA = "0x3081B70", Offset = "0x3080F70", Length = "0x6C")]
	[Token(Token = "0x6001715")]
	private void SetEnabled(bool state) { }

}

