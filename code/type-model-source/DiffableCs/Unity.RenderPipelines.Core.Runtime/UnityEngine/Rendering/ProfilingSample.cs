namespace UnityEngine.Rendering;

[IgnoredByDeepProfiler]
[Obsolete("Please use ProfilingScope. #from(2021.1)")]
[Token(Token = "0x20000DA")]
public struct ProfilingSample : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002AF")]
	private readonly CommandBuffer m_Cmd; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002B0")]
	private readonly string m_Name; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002B1")]
	private bool m_Disposed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002B2")]
	private CustomSampler m_Sampler; //Field offset: 0x18

	[Address(RVA = "0x2BE5EE0", Offset = "0x2BE52E0", Length = "0xAB")]
	[Token(Token = "0x60007C5")]
	public ProfilingSample(CommandBuffer cmd, string name, CustomSampler sampler = null) { }

	[Address(RVA = "0x2BE5F90", Offset = "0x2BE5390", Length = "0xB2")]
	[Token(Token = "0x60007C6")]
	public ProfilingSample(CommandBuffer cmd, string format, object arg) { }

	[Address(RVA = "0x2BE6050", Offset = "0x2BE5450", Length = "0xB2")]
	[Token(Token = "0x60007C7")]
	public ProfilingSample(CommandBuffer cmd, string format, Object[] args) { }

	[Address(RVA = "0x2BE5E70", Offset = "0x2BE5270", Length = "0x6B")]
	[Token(Token = "0x60007C8")]
	public override void Dispose() { }

	[Address(RVA = "0x2BE5DF0", Offset = "0x2BE51F0", Length = "0x7C")]
	[Token(Token = "0x60007C9")]
	private void Dispose(bool disposing) { }

}

