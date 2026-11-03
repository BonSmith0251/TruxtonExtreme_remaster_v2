namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x2000262")]
public interface IUnsafeRenderGraphBuilder : IRenderAttachmentRenderGraphBuilder, IBaseRenderGraphBuilder, IDisposable
{

	[Token(Token = "0x6001106")]
	public void SetRenderFunc(BaseRenderFunc<PassData, UnsafeGraphContext> renderFunc) { }

}

