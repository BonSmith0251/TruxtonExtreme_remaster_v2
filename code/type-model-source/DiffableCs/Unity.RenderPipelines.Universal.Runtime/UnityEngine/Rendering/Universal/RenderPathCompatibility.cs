namespace UnityEngine.Rendering.Universal;

[Flags]
[Token(Token = "0x20001D6")]
public enum RenderPathCompatibility : int
{
	Forward = 1,
	Deferred = 2,
	ForwardPlus = 4,
	DeferredPlus = 8,
	All = 15,
}

