namespace UnityEngine.Rendering;

[Token(Token = "0x20001E7")]
public static class SweepLineRectUtils
{
	[Token(Token = "0x20001E9")]
	private struct ActiveComparer : IComparer<Vector2>
	{

		[Address(RVA = "0x2C53DF0", Offset = "0x2C531F0", Length = "0x26")]
		[Token(Token = "0x6000E92")]
		public override int Compare(Vector2 a, Vector2 b) { }

	}

	[Token(Token = "0x20001E8")]
	private struct EventComparer : IComparer<Vector4>
	{

		[Address(RVA = "0x2C5B9E0", Offset = "0x2C5ADE0", Length = "0x3F")]
		[Token(Token = "0x6000E91")]
		public override int Compare(Vector4 a, Vector4 b) { }

	}


	[Address(RVA = "0x2C65920", Offset = "0x2C64D20", Length = "0x2C9")]
	[Token(Token = "0x6000E8D")]
	public static float CalculateRectUnionArea(List<Rect> rects) { }

	[Address(RVA = "0x2C65550", Offset = "0x2C64950", Length = "0x3C7")]
	[Token(Token = "0x6000E8F")]
	private static float CalculateRectUnionArea(Vector4[] eventsBuffer, Vector2[] activeBuffer, int eventCount) { }

	[Address(RVA = "0x2C65BF0", Offset = "0x2C64FF0", Length = "0x19A")]
	[Token(Token = "0x6000E90")]
	private static void InsertEvents(in Rect rect, Vector4[] eventsBuffer, ref int eventCount) { }

	[Address(RVA = "0x2C65D90", Offset = "0x2C65190", Length = "0xB8")]
	[Token(Token = "0x6000E8E")]
	private static float MergeLengthY(Vector2[] activeBuffer, int count) { }

}

