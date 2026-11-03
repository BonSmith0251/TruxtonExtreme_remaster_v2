namespace UnityEngine.Rendering;

[Token(Token = "0x2000374")]
public enum SynchronisationStageFlags : int
{
	VertexProcessing = 1,
	PixelProcessing = 2,
	ComputeProcessing = 4,
	AllGPUOperations = 7,
}

