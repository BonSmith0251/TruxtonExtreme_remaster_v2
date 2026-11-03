namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000030")]
public static class TaskTracker
{
	[Token(Token = "0x4000091")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"formattedType", "trackingId", "addTime", "stackTrace"})]
	private static List<KeyValuePair`2<IUniTaskSource, ValueTuple`4<String, Int32, DateTime, String>>> listPool; //Field offset: 0x0
	[Token(Token = "0x4000092")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"formattedType", "trackingId", "addTime", "stackTrace"})]
	private static readonly WeakDictionary<IUniTaskSource, ValueTuple`4<String, Int32, DateTime, String>> tracking; //Field offset: 0x8
	[Token(Token = "0x4000093")]
	private static bool dirty; //Field offset: 0x10

	[Address(RVA = "0x2739120", Offset = "0x2738520", Length = "0xFB")]
	[Token(Token = "0x600010F")]
	private static TaskTracker() { }

	[Address(RVA = "0x2738990", Offset = "0x2737D90", Length = "0x57")]
	[Token(Token = "0x600010C")]
	public static bool CheckAndResetDirty() { }

	[Address(RVA = "0x27389F0", Offset = "0x2737DF0", Length = "0x48F")]
	[Token(Token = "0x600010D")]
	public static void ForEachActiveTask(Action<Int32, String, UniTaskStatus, DateTime, String> action) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600010B")]
	public static void RemoveTracking(IUniTaskSource task) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600010A")]
	public static void TrackActiveTask(IUniTaskSource task, int skipFrame) { }

	[Address(RVA = "0x2738E80", Offset = "0x2738280", Length = "0x294")]
	[Token(Token = "0x600010E")]
	private static void TypeBeautify(Type type, StringBuilder sb) { }

}

