namespace UnityEngine.ResourceManagement.Util;

[Flags]
[Token(Token = "0x2000042")]
internal enum BundleSource : int
{
	None = 0,
	Local = 1,
	Cache = 2,
	Download = 4,
}

