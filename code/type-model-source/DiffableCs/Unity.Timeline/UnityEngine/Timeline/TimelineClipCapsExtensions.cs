namespace UnityEngine.Timeline;

[Extension]
[Token(Token = "0x2000033")]
internal static class TimelineClipCapsExtensions
{

	[Address(RVA = "0x1F1C710", Offset = "0x1F1BB10", Length = "0x8")]
	[Extension]
	[Token(Token = "0x60001EC")]
	public static bool HasAll(ClipCaps caps, ClipCaps flags) { }

	[Address(RVA = "0x24D9550", Offset = "0x24D8950", Length = "0x6")]
	[Extension]
	[Token(Token = "0x60001ED")]
	public static bool HasAny(ClipCaps caps, ClipCaps flags) { }

	[Address(RVA = "0x2F35210", Offset = "0x2F34610", Length = "0x21")]
	[Extension]
	[Token(Token = "0x60001EB")]
	public static bool SupportsBlending(TimelineClip clip) { }

	[Address(RVA = "0x2F35240", Offset = "0x2F34640", Length = "0x21")]
	[Extension]
	[Token(Token = "0x60001E9")]
	public static bool SupportsClipIn(TimelineClip clip) { }

	[Address(RVA = "0x2F35270", Offset = "0x2F34670", Length = "0x21")]
	[Extension]
	[Token(Token = "0x60001E8")]
	public static bool SupportsExtrapolation(TimelineClip clip) { }

	[Address(RVA = "0x2F352A0", Offset = "0x2F346A0", Length = "0x1E")]
	[Extension]
	[Token(Token = "0x60001E7")]
	public static bool SupportsLooping(TimelineClip clip) { }

	[Address(RVA = "0x2F352C0", Offset = "0x2F346C0", Length = "0x21")]
	[Extension]
	[Token(Token = "0x60001EA")]
	public static bool SupportsSpeedMultiplier(TimelineClip clip) { }

}

