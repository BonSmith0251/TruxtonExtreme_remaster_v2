namespace UnityEngine.Timeline;

[Token(Token = "0x200007E")]
internal static class TimelineUndo
{

	[Token(Token = "0x170000D2")]
	internal static bool undoEnabled
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000373")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000373")]
	internal static bool get_undoEnabled() { }

	[Address(RVA = "0x2F4A0B0", Offset = "0x2F494B0", Length = "0x75")]
	[Token(Token = "0x6000374")]
	public static void PushDestroyUndo(TimelineAsset timeline, object thingToDirty, object objectToDestroy) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6000375")]
	public static void PushUndo(Object[] thingsToDirty, string operation) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6000376")]
	public static void PushUndo(object thingToDirty, string operation) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6000377")]
	public static void RegisterCreatedObjectUndo(object thingCreated, string operation) { }

	[Address(RVA = "0x2F4A130", Offset = "0x2F49530", Length = "0x3C")]
	[Token(Token = "0x6000378")]
	internal static string UndoName(string name) { }

}

