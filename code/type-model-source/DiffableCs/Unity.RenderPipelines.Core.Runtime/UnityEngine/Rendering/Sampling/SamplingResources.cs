namespace UnityEngine.Rendering.Sampling;

[Token(Token = "0x2000236")]
internal sealed class SamplingResources : IDisposable
{
	[Token(Token = "0x2000237")]
	public enum ResourceType : int
	{
		BlueNoiseTextures = 1,
		SobolMatrices = 2,
		All = 3,
	}

	[Token(Token = "0x40009EA")]
	public static readonly UInt32[] sobolMatrices; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009E6")]
	private Texture2D m_SobolScramblingTile; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009E7")]
	private Texture2D m_SobolRankingTile; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009E8")]
	private Texture2D m_SobolOwenScrambled256Samples; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009E9")]
	private GraphicsBuffer m_SobolBuffer; //Field offset: 0x28

	[Address(RVA = "0x2C880B0", Offset = "0x2C874B0", Length = "0x7D")]
	[Token(Token = "0x6000FDD")]
	private static SamplingResources() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000FDC")]
	public SamplingResources() { }

	[Address(RVA = "0x2C87E80", Offset = "0x2C87280", Length = "0x208")]
	[Token(Token = "0x6000FDA")]
	public static void Bind(CommandBuffer cmd, SamplingResources resources) { }

	[Address(RVA = "0x2C88090", Offset = "0x2C87490", Length = "0x11")]
	[Token(Token = "0x6000FDB")]
	public override void Dispose() { }

}

