namespace UnityEngine.Rendering;

[Token(Token = "0x2000038")]
public interface IGPUResidentRenderPipeline
{

	[Token(Token = "0x17000020")]
	public GPUResidentDrawerMode gpuResidentDrawerMode
	{
		[Token(Token = "0x6000122")]
		 get { } //Length: 0
		[Token(Token = "0x6000123")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700001F")]
	public GPUResidentDrawerSettings gpuResidentDrawerSettings
	{
		[Token(Token = "0x6000121")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000122")]
	public GPUResidentDrawerMode get_gpuResidentDrawerMode() { }

	[Token(Token = "0x6000121")]
	public GPUResidentDrawerSettings get_gpuResidentDrawerSettings() { }

	[Address(RVA = "0x2CCB1D0", Offset = "0x2CCA5D0", Length = "0x3A")]
	[Token(Token = "0x6000128")]
	public static bool IsGPUResidentDrawerEnabled() { }

	[Address(RVA = "0x2CCEBC0", Offset = "0x2CCDFC0", Length = "0x90")]
	[Token(Token = "0x6000127")]
	public static bool IsGPUResidentDrawerSupportedByProjectConfiguration(bool logReason = false) { }

	[Address(RVA = "0x2CCEC90", Offset = "0x2CCE090", Length = "0x171")]
	[Token(Token = "0x6000125")]
	public bool IsGPUResidentDrawerSupportedBySRP(bool logReason = false) { }

	[Address(RVA = "0x2CCEC50", Offset = "0x2CCE050", Length = "0x36")]
	[Token(Token = "0x6000126")]
	public bool IsGPUResidentDrawerSupportedBySRP(out string message, out LogType severity) { }

	[Address(RVA = "0x2CCD420", Offset = "0x2CCC820", Length = "0x211")]
	[Token(Token = "0x6000124")]
	public static void ReinitializeGPUResidentDrawer() { }

	[Token(Token = "0x6000123")]
	public void set_gpuResidentDrawerMode(GPUResidentDrawerMode value) { }

}

