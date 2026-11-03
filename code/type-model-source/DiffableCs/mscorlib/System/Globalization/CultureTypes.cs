namespace System.Globalization;

[Flags]
[Token(Token = "0x2000541")]
public enum CultureTypes : int
{
	NeutralCultures = 1,
	SpecificCultures = 2,
	InstalledWin32Cultures = 4,
	AllCultures = 7,
	UserCustomCulture = 8,
	ReplacementCultures = 16,
	WindowsOnlyCultures = 32,
	FrameworkCultures = 64,
}

