namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200012E")]
internal class InvokeOnRenderObjectCallbackPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000130")]
	private sealed class <>c
	{
		[Token(Token = "0x4000679")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400067A")]
		public static BaseRenderFunc<PassData, UnsafeGraphContext> <>9__2_0; //Field offset: 0x8

		[Address(RVA = "0x2DC8EC0", Offset = "0x2DC82C0", Length = "0x67")]
		[Token(Token = "0x6000732")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000733")]
		public <>c() { }

		[Address(RVA = "0x2DC8980", Offset = "0x2DC7D80", Length = "0x153")]
		[Token(Token = "0x6000734")]
		internal void <Render>b__2_0(PassData data, UnsafeGraphContext context) { }

	}

	[Token(Token = "0x200012F")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000677")]
		internal TextureHandle colorTarget; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000678")]
		internal TextureHandle depthTarget; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000731")]
		public PassData() { }

	}


	[Address(RVA = "0x2DADF60", Offset = "0x2DAD360", Length = "0x88")]
	[Token(Token = "0x600072F")]
	public InvokeOnRenderObjectCallbackPass(RenderPassEvent evt) { }

	[Address(RVA = "0x2DADC00", Offset = "0x2DAD000", Length = "0x35F")]
	[Token(Token = "0x6000730")]
	internal void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget) { }

}

