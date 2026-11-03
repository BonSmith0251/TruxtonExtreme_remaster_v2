namespace UnityEngine.Rendering;

[Token(Token = "0x2000121")]
internal class ProbeVolumeDebugColorPreferences
{
	[Token(Token = "0x400053C")]
	internal static Func<Color> GetDetailSubdivisionColor; //Field offset: 0x0
	[Token(Token = "0x400053D")]
	internal static Func<Color> GetMediumSubdivisionColor; //Field offset: 0x8
	[Token(Token = "0x400053E")]
	internal static Func<Color> GetLowSubdivisionColor; //Field offset: 0x10
	[Token(Token = "0x400053F")]
	internal static Func<Color> GetVeryLowSubdivisionColor; //Field offset: 0x18
	[Token(Token = "0x4000540")]
	internal static Func<Color> GetSparseSubdivisionColor; //Field offset: 0x20
	[Token(Token = "0x4000541")]
	internal static Func<Color> GetSparsestSubdivisionColor; //Field offset: 0x28
	[Token(Token = "0x4000542")]
	internal static Color s_DetailSubdivision; //Field offset: 0x30
	[Token(Token = "0x4000543")]
	internal static Color s_MediumSubdivision; //Field offset: 0x40
	[Token(Token = "0x4000544")]
	internal static Color s_LowSubdivision; //Field offset: 0x50
	[Token(Token = "0x4000545")]
	internal static Color s_VeryLowSubdivision; //Field offset: 0x60
	[Token(Token = "0x4000546")]
	internal static Color s_SparseSubdivision; //Field offset: 0x70
	[Token(Token = "0x4000547")]
	internal static Color s_SparsestSubdivision; //Field offset: 0x80

	[Address(RVA = "0x2C1B0C0", Offset = "0x2C1A4C0", Length = "0x314")]
	[Token(Token = "0x6000A44")]
	private static ProbeVolumeDebugColorPreferences() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000A45")]
	public ProbeVolumeDebugColorPreferences() { }

}

