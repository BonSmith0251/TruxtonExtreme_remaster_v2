namespace TXEKernel;

[Token(Token = "0x2000009")]
public class TXERendererFeatureCopyColor : ScriptableRendererFeature
{
	[Token(Token = "0x200000B")]
	private class GrabPass : ScriptableRenderPass
	{
		[Token(Token = "0x4000022")]
		private const string ProfilerTag = "TXERendererFeatureCopyColor"; //Field offset: 0x0
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000023")]
		private readonly Settings _settings; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000024")]
		private readonly int _texturePropertyId; //Field offset: 0x68

		[Address(RVA = "0x5D3C30", Offset = "0x5D3030", Length = "0xB1")]
		[Token(Token = "0x6000019")]
		public GrabPass(Settings settings) { }

		[Address(RVA = "0x5D3050", Offset = "0x5D2450", Length = "0x15F")]
		[Token(Token = "0x600001C")]
		public void Dispose() { }

		[Address(RVA = "0x5D31B0", Offset = "0x5D25B0", Length = "0x20")]
		[Token(Token = "0x600001D")]
		private static int DivRoundDown(int v, int div) { }

		[Address(RVA = "0x5D31D0", Offset = "0x5D25D0", Length = "0x40E")]
		[Token(Token = "0x600001A")]
		private void EnsureRenderTexture(int width, int height, GraphicsFormat format) { }

		[Address(RVA = "0x5D35E0", Offset = "0x5D29E0", Length = "0x6C")]
		[Token(Token = "0x600001E")]
		private void GetDownsampledSize(int srcW, int srcH, out int w, out int h) { }

		[Address(RVA = "0x5D3650", Offset = "0x5D2A50", Length = "0x5D2")]
		[Token(Token = "0x600001B")]
		public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

	}

	[Token(Token = "0x200000A")]
	internal class Settings
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400001E")]
		public string textureName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400001F")]
		public RenderPassEvent passEvent; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Header("CopyColor Downsample (1=Full, 2=Half, 4=Quarter)")]
		[Min(1)]
		[Token(Token = "0x4000020")]
		public int downsample; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000021")]
		public bool forceEvenSize; //Field offset: 0x20

		[Address(RVA = "0x5D3CF0", Offset = "0x5D30F0", Length = "0x61")]
		[Token(Token = "0x6000018")]
		public Settings() { }

	}

	[Token(Token = "0x4000019")]
	internal static RenderTexture s_SharedTexture; //Field offset: 0x0
	[Token(Token = "0x400001A")]
	internal static RTHandle s_SharedTextureHandle; //Field offset: 0x8
	[Token(Token = "0x400001B")]
	internal static string s_SharedTextureName; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400001C")]
	private Settings settings; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400001D")]
	private GrabPass grabPass; //Field offset: 0x28

	[Token(Token = "0x17000001")]
	public static RenderTexture SharedTexture
	{
		[Address(RVA = "0x5D4890", Offset = "0x5D3C90", Length = "0x36")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 54
	}

	[Token(Token = "0x17000002")]
	public static string SharedTextureName
	{
		[Address(RVA = "0x5D4850", Offset = "0x5D3C50", Length = "0x37")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 55
	}

	[Address(RVA = "0x5D47A0", Offset = "0x5D3BA0", Length = "0xAF")]
	[Token(Token = "0x6000017")]
	public TXERendererFeatureCopyColor() { }

	[Address(RVA = "0x5D4450", Offset = "0x5D3850", Length = "0x4B")]
	[Token(Token = "0x6000015")]
	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	[Address(RVA = "0x5D44A0", Offset = "0x5D38A0", Length = "0x17C")]
	[Token(Token = "0x6000013")]
	public virtual void Create() { }

	[Address(RVA = "0x5D4620", Offset = "0x5D3A20", Length = "0x175")]
	[Token(Token = "0x6000016")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x5D4890", Offset = "0x5D3C90", Length = "0x36")]
	[Token(Token = "0x6000011")]
	public static RenderTexture get_SharedTexture() { }

	[Address(RVA = "0x5D4850", Offset = "0x5D3C50", Length = "0x37")]
	[Token(Token = "0x6000012")]
	public static string get_SharedTextureName() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("SetupRenderPasses is obsolete in RenderGraph, but kept for compatibility.")]
	[Token(Token = "0x6000014")]
	public virtual void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData) { }

}

