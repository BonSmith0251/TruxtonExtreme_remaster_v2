namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x200028B")]
internal abstract class IRenderGraphResourcePool
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001235")]
	protected IRenderGraphResourcePool() { }

	[Token(Token = "0x6001233")]
	public abstract void CheckFrameAllocation(bool onException, int frameIndex) { }

	[Token(Token = "0x6001232")]
	public abstract void Cleanup() { }

	[Token(Token = "0x6001234")]
	public abstract void LogResources(RenderGraphLogger logger) { }

	[Token(Token = "0x6001231")]
	public abstract void PurgeUnusedResources(int currentFrameIndex) { }

}

