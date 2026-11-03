namespace System.Runtime.Serialization;

[Token(Token = "0x20003E1")]
internal static class SerializationEventsCache
{
	[CompilerGenerated]
	[Token(Token = "0x20003E2")]
	private sealed class <>c
	{
		[Token(Token = "0x4000F33")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000F34")]
		public static Func<Type, SerializationEvents> <>9__1_0; //Field offset: 0x8

		[Address(RVA = "0x1F15A70", Offset = "0x1F14E70", Length = "0x67")]
		[Token(Token = "0x6001DB7")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001DB8")]
		public <>c() { }

		[Address(RVA = "0x1F15850", Offset = "0x1F14C50", Length = "0x16E")]
		[Token(Token = "0x6001DB9")]
		internal SerializationEvents <GetSerializationEventsForType>b__1_0(Type type) { }

	}

	[Token(Token = "0x4000F32")]
	private static readonly ConcurrentDictionary<Type, SerializationEvents> s_cache; //Field offset: 0x0

	[Address(RVA = "0x1F13290", Offset = "0x1F12690", Length = "0x84")]
	[Token(Token = "0x6001DB6")]
	private static SerializationEventsCache() { }

	[Address(RVA = "0x1F13130", Offset = "0x1F12530", Length = "0x159")]
	[Token(Token = "0x6001DB5")]
	internal static SerializationEvents GetSerializationEventsForType(Type t) { }

}

