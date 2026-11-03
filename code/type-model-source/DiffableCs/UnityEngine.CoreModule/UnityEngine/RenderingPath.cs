namespace UnityEngine;

[Token(Token = "0x20000FC")]
public enum RenderingPath : int
{
	UsePlayerSettings = -1,
	VertexLit = 0,
	Forward = 1,
	DeferredLighting = 2,
	DeferredShading = 3,
}

