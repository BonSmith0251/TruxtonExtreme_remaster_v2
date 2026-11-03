namespace UnityEngine.Rendering;

[MovedFrom("UnityEngine.Rendering.RendererUtils")]
[Token(Token = "0x20003E2")]
public enum RendererListStatus : int
{
	kRendererListInvalid = -2,
	kRendererListProcessing = -1,
	kRendererListEmpty = 0,
	kRendererListPopulated = 1,
}

