namespace UnityEngine.ResourceManagement.Profiling;

[Flags]
[Token(Token = "0x2000073")]
internal enum BundleOptions : short
{
	None = 0,
	CachingEnabled = 1,
	CheckSumEnabled = 2,
}

