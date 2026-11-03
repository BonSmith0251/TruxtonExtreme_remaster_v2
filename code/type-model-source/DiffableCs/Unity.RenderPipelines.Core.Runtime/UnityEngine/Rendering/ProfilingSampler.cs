namespace UnityEngine.Rendering;

[IgnoredByDeepProfiler]
[Token(Token = "0x20000D8")]
public class ProfilingSampler
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002AA")]
	private CustomSampler <sampler>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002AB")]
	private CustomSampler <inlineSampler>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002AC")]
	private string <name>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002AD")]
	private Recorder m_Recorder; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002AE")]
	private Recorder m_InlineRecorder; //Field offset: 0x30

	[Token(Token = "0x170000C3")]
	public float cpuElapsedTime
	{
		[Address(RVA = "0x2BE6320", Offset = "0x2BE5720", Length = "0x51")]
		[Token(Token = "0x60007BC")]
		 get { } //Length: 81
	}

	[Token(Token = "0x170000C4")]
	public int cpuSampleCount
	{
		[Address(RVA = "0x2BE6380", Offset = "0x2BE5780", Length = "0x3F")]
		[Token(Token = "0x60007BD")]
		 get { } //Length: 63
	}

	[Token(Token = "0x170000C0")]
	public bool enableRecording
	{
		[Address(RVA = "0x2BE6500", Offset = "0x2BE5900", Length = "0x44")]
		[Token(Token = "0x60007B9")]
		 set { } //Length: 68
	}

	[Token(Token = "0x170000C1")]
	public float gpuElapsedTime
	{
		[Address(RVA = "0x2BE63C0", Offset = "0x2BE57C0", Length = "0x51")]
		[Token(Token = "0x60007BA")]
		 get { } //Length: 81
	}

	[Token(Token = "0x170000C2")]
	public int gpuSampleCount
	{
		[Address(RVA = "0x2BE6420", Offset = "0x2BE5820", Length = "0x3F")]
		[Token(Token = "0x60007BB")]
		 get { } //Length: 63
	}

	[Token(Token = "0x170000C5")]
	public float inlineCpuElapsedTime
	{
		[Address(RVA = "0x2BE6460", Offset = "0x2BE5860", Length = "0x51")]
		[Token(Token = "0x60007BE")]
		 get { } //Length: 81
	}

	[Token(Token = "0x170000C6")]
	public int inlineCpuSampleCount
	{
		[Address(RVA = "0x2BE64C0", Offset = "0x2BE58C0", Length = "0x3F")]
		[Token(Token = "0x60007BF")]
		 get { } //Length: 63
	}

	[Token(Token = "0x170000BE")]
	internal CustomSampler inlineSampler
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007B5")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007B6")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000BF")]
	public private string name
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007B7")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007B8")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000BD")]
	internal CustomSampler sampler
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007B3")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007B4")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60007C0")]
	private ProfilingSampler() { }

	[Address(RVA = "0x2BE61F0", Offset = "0x2BE55F0", Length = "0x128")]
	[Token(Token = "0x60007AF")]
	public ProfilingSampler(string name) { }

	[Address(RVA = "0x2BE6110", Offset = "0x2BE5510", Length = "0x5E")]
	[Token(Token = "0x60007B0")]
	public void Begin(CommandBuffer cmd) { }

	[Address(RVA = "0x2BE6170", Offset = "0x2BE5570", Length = "0x5E")]
	[Token(Token = "0x60007B1")]
	public void End(CommandBuffer cmd) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60007AE")]
	public static ProfilingSampler Get(TEnum marker) { }

	[Address(RVA = "0x2BE6320", Offset = "0x2BE5720", Length = "0x51")]
	[Token(Token = "0x60007BC")]
	public float get_cpuElapsedTime() { }

	[Address(RVA = "0x2BE6380", Offset = "0x2BE5780", Length = "0x3F")]
	[Token(Token = "0x60007BD")]
	public int get_cpuSampleCount() { }

	[Address(RVA = "0x2BE63C0", Offset = "0x2BE57C0", Length = "0x51")]
	[Token(Token = "0x60007BA")]
	public float get_gpuElapsedTime() { }

	[Address(RVA = "0x2BE6420", Offset = "0x2BE5820", Length = "0x3F")]
	[Token(Token = "0x60007BB")]
	public int get_gpuSampleCount() { }

	[Address(RVA = "0x2BE6460", Offset = "0x2BE5860", Length = "0x51")]
	[Token(Token = "0x60007BE")]
	public float get_inlineCpuElapsedTime() { }

	[Address(RVA = "0x2BE64C0", Offset = "0x2BE58C0", Length = "0x3F")]
	[Token(Token = "0x60007BF")]
	public int get_inlineCpuSampleCount() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007B5")]
	internal CustomSampler get_inlineSampler() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007B7")]
	public string get_name() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007B3")]
	internal CustomSampler get_sampler() { }

	[Address(RVA = "0x2BE61D0", Offset = "0x2BE55D0", Length = "0x13")]
	[Token(Token = "0x60007B2")]
	internal bool IsValid() { }

	[Address(RVA = "0x2BE6500", Offset = "0x2BE5900", Length = "0x44")]
	[Token(Token = "0x60007B9")]
	public void set_enableRecording(bool value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007B6")]
	private void set_inlineSampler(CustomSampler value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007B8")]
	private void set_name(string value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007B4")]
	private void set_sampler(CustomSampler value) { }

}

