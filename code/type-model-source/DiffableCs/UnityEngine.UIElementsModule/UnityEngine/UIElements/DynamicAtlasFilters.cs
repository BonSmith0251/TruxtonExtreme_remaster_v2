namespace UnityEngine.UIElements;

[Flags]
[Token(Token = "0x2000007")]
public enum DynamicAtlasFilters : int
{
	None = 0,
	Readability = 1,
	Size = 2,
	Format = 4,
	ColorSpace = 8,
	FilterMode = 16,
}

