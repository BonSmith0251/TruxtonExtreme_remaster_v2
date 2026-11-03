namespace UnityEngine.UIElements.UIR;

[Flags]
[Token(Token = "0x20005BC")]
internal enum RenderDataDirtyTypes : int
{
	None = 0,
	Transform = 1,
	ClipRectSize = 2,
	Clipping = 4,
	ClippingHierarchy = 8,
	Visuals = 16,
	VisualsHierarchy = 32,
	VisualsOpacityId = 64,
	Opacity = 128,
	OpacityHierarchy = 256,
	Color = 512,
	AllVisuals = 112,
}

