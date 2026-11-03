namespace UnityEngine.UI;

[Token(Token = "0x200001D")]
public static class FontUpdateTracker
{
	[Token(Token = "0x400006C")]
	private static Dictionary<Font, HashSet`1<Text>> m_Tracked; //Field offset: 0x0

	[Address(RVA = "0x31DD530", Offset = "0x31DC930", Length = "0x84")]
	[Token(Token = "0x60000E2")]
	private static FontUpdateTracker() { }

	[Address(RVA = "0x31DCF50", Offset = "0x31DC350", Length = "0x17B")]
	[Token(Token = "0x60000E0")]
	private static void RebuildForFont(Font f) { }

	[Address(RVA = "0x31DD0D0", Offset = "0x31DC4D0", Length = "0x249")]
	[Token(Token = "0x60000DF")]
	public static void TrackText(Text t) { }

	[Address(RVA = "0x31DD320", Offset = "0x31DC720", Length = "0x208")]
	[Token(Token = "0x60000E1")]
	public static void UntrackText(Text t) { }

}

