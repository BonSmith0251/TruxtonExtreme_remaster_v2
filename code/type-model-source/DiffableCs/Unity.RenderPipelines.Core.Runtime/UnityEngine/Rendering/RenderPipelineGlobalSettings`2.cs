namespace UnityEngine.Rendering;

[Token(Token = "0x2000163")]
public abstract class RenderPipelineGlobalSettings : RenderPipelineGlobalSettings
{
	[CompilerGenerated]
	[Token(Token = "0x2000164")]
	private sealed class <>c
	{
		[Token(Token = "0x40006E4")]
		public static readonly <>c<TGlobalRenderPipelineSettings, TRenderPipeline> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000B58")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B59")]
		public <>c() { }

		[Address(RVA = "0xA36B50", Offset = "0xA35F50", Length = "0x8A")]
		[Token(Token = "0x6000B5A")]
		internal TGlobalRenderPipelineSettings <.cctor>b__5_0() { }

	}

	[Token(Token = "0x40006E3")]
	private static Lazy<TGlobalRenderPipelineSettings> s_Instance; //Field offset: 0x0

	[Token(Token = "0x17000152")]
	public static TGlobalRenderPipelineSettings instance
	{
		[Address(RVA = "0xF52820", Offset = "0xF51C20", Length = "0xC6")]
		[Token(Token = "0x6000B54")]
		 get { } //Length: 198
	}

	[Address(RVA = "0xF525F0", Offset = "0xF519F0", Length = "0x214")]
	[Token(Token = "0x6000B57")]
	private static RenderPipelineGlobalSettings`2() { }

	[Address(RVA = "0xF52810", Offset = "0xF51C10", Length = "0x7")]
	[Token(Token = "0x6000B56")]
	protected RenderPipelineGlobalSettings`2() { }

	[Address(RVA = "0xF52820", Offset = "0xF51C20", Length = "0xC6")]
	[Token(Token = "0x6000B54")]
	public static TGlobalRenderPipelineSettings get_instance() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B55")]
	public override void Reset() { }

}

