namespace System.Net;

[Token(Token = "0x200021D")]
internal sealed class NetEventSource : EventSource
{
	[Token(Token = "0x200021E")]
	internal class Keywords
	{
		[Token(Token = "0x40007C9")]
		public const EventKeywords Default = 1; //Field offset: 0x0
		[Token(Token = "0x40007CA")]
		public const EventKeywords Debug = 2; //Field offset: 0x0
		[Token(Token = "0x40007CB")]
		public const EventKeywords EnterExit = 4; //Field offset: 0x0

	}

	[Token(Token = "0x40007C8")]
	public static readonly NetEventSource Log; //Field offset: 0x0

	[Token(Token = "0x170002D9")]
	public static bool IsEnabled
	{
		[Address(RVA = "0x268A420", Offset = "0x2689820", Length = "0x5E")]
		[Token(Token = "0x6000E42")]
		 get { } //Length: 94
	}

	[Address(RVA = "0x268A3B0", Offset = "0x26897B0", Length = "0x67")]
	[Token(Token = "0x6000E49")]
	private static NetEventSource() { }

	[Address(RVA = "0x23188B0", Offset = "0x2317CB0", Length = "0x7")]
	[Token(Token = "0x6000E48")]
	public NetEventSource() { }

	[Address(RVA = "0x2688810", Offset = "0x2687C10", Length = "0x91")]
	[Event(3, Level = EventLevel::Informational (4), Keywords = 1, Message = "[{2}]<-->[{3}]")]
	[Token(Token = "0x6000E41")]
	private void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	[Address(RVA = "0x2688690", Offset = "0x2687A90", Length = "0x170")]
	[NonEvent]
	[Token(Token = "0x6000E40")]
	public static void Associate(object first, object second, string memberName = null) { }

	[Address(RVA = "0x26888B0", Offset = "0x2687CB0", Length = "0x87")]
	[Event(6, Level = EventLevel::Critical (1), Keywords = 2)]
	[Token(Token = "0x6000E3F")]
	private void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	[Address(RVA = "0x2688AC0", Offset = "0x2687EC0", Length = "0x181")]
	[NonEvent]
	[Token(Token = "0x6000E32")]
	public static void Enter(object thisOrContextObject, FormattableString formattableString = null, string memberName = null) { }

	[Address(RVA = "0x2688C50", Offset = "0x2688050", Length = "0x1A5")]
	[NonEvent]
	[Token(Token = "0x6000E34")]
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName = null) { }

	[Address(RVA = "0x2688940", Offset = "0x2687D40", Length = "0x170")]
	[NonEvent]
	[Token(Token = "0x6000E33")]
	public static void Enter(object thisOrContextObject, object arg0, string memberName = null) { }

	[Address(RVA = "0x2688E00", Offset = "0x2688200", Length = "0x87")]
	[Event(1, Level = EventLevel::Informational (4), Keywords = 4)]
	[Token(Token = "0x6000E35")]
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	[Address(RVA = "0x2688F20", Offset = "0x2688320", Length = "0x16E")]
	[NonEvent]
	[Token(Token = "0x6000E3C")]
	public static void Error(object thisOrContextObject, object message, string memberName = null) { }

	[Address(RVA = "0x2688E90", Offset = "0x2688290", Length = "0x87")]
	[Event(5, Level = EventLevel::Warning (3), Keywords = 1)]
	[Token(Token = "0x6000E3D")]
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	[Address(RVA = "0x2689120", Offset = "0x2688520", Length = "0x181")]
	[NonEvent]
	[Token(Token = "0x6000E36")]
	public static void Exit(object thisOrContextObject, FormattableString formattableString = null, string memberName = null) { }

	[Address(RVA = "0x26892B0", Offset = "0x26886B0", Length = "0x16E")]
	[NonEvent]
	[Token(Token = "0x6000E37")]
	public static void Exit(object thisOrContextObject, object arg0, string memberName = null) { }

	[Address(RVA = "0x2689090", Offset = "0x2688490", Length = "0x87")]
	[Event(2, Level = EventLevel::Informational (4), Keywords = 4)]
	[Token(Token = "0x6000E38")]
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	[Address(RVA = "0x2689420", Offset = "0x2688820", Length = "0x16E")]
	[NonEvent]
	[Token(Token = "0x6000E3E")]
	public static void Fail(object thisOrContextObject, object message, string memberName = null) { }

	[Address(RVA = "0x2689930", Offset = "0x2688D30", Length = "0x3C9")]
	[NonEvent]
	[Token(Token = "0x6000E45")]
	public static object Format(object value) { }

	[Address(RVA = "0x2689590", Offset = "0x2688990", Length = "0x393")]
	[NonEvent]
	[Token(Token = "0x6000E46")]
	private static string Format(FormattableString s) { }

	[Address(RVA = "0x268A420", Offset = "0x2689820", Length = "0x5E")]
	[Token(Token = "0x6000E42")]
	public static bool get_IsEnabled() { }

	[Address(RVA = "0x2689D00", Offset = "0x2689100", Length = "0x1C")]
	[NonEvent]
	[Token(Token = "0x6000E44")]
	public static int GetHashCode(object value) { }

	[Address(RVA = "0x2689D20", Offset = "0x2689120", Length = "0xEE")]
	[NonEvent]
	[Token(Token = "0x6000E43")]
	public static string IdOf(object value) { }

	[Address(RVA = "0x268A030", Offset = "0x2689430", Length = "0x16E")]
	[NonEvent]
	[Token(Token = "0x6000E3A")]
	public static void Info(object thisOrContextObject, object message, string memberName = null) { }

	[Address(RVA = "0x2689E10", Offset = "0x2689210", Length = "0x181")]
	[NonEvent]
	[Token(Token = "0x6000E39")]
	public static void Info(object thisOrContextObject, FormattableString formattableString = null, string memberName = null) { }

	[Address(RVA = "0x2689FA0", Offset = "0x26893A0", Length = "0x87")]
	[Event(4, Level = EventLevel::Informational (4), Keywords = 1)]
	[Token(Token = "0x6000E3B")]
	private void Info(string thisOrContextObject, string memberName, string message) { }

	[Address(RVA = "0x268A1A0", Offset = "0x26895A0", Length = "0x205")]
	[NonEvent]
	[Token(Token = "0x6000E47")]
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

}

