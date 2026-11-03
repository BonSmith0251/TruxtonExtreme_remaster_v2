namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x2000261")]
public interface IComputeRenderGraphBuilder : IBaseRenderGraphBuilder, IDisposable
{

	[Token(Token = "0x6001105")]
	public void SetRenderFunc(BaseRenderFunc<PassData, ComputeGraphContext> renderFunc) { }

}

