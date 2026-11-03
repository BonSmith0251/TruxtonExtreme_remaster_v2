namespace Unity.RenderPipelines.Core.Runtime.Shared;

[Token(Token = "0x2000004")]
internal static class CameraCaptureBridge
{

	[Address(RVA = "0x2BD37B0", Offset = "0x2BD2BB0", Length = "0x49")]
	[Token(Token = "0x6000003")]
	public static IEnumerator<Action`2<RenderTargetIdentifier, CommandBuffer>> GetCachedCaptureActionsEnumerator(Camera camera) { }

}

