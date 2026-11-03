namespace UnityEngine.UIElements.UIR;

[Flags]
[Token(Token = "0x20005BE")]
internal enum RenderDataFlags : int
{
	IsGroupTransform = 1,
	IsIgnoringDynamicColorHint = 2,
	HasExtraData = 4,
	HasExtraMeshes = 8,
	IsSubTreeQuad = 16,
	IsNestedRenderTreeRoot = 32,
	IsClippingRectDirty = 64,
}

