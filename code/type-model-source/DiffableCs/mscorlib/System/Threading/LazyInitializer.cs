namespace System.Threading;

[Token(Token = "0x20001F4")]
public static class LazyInitializer
{

	[Address(RVA = "0x852590", Offset = "0x851990", Length = "0x64")]
	[Token(Token = "0x600117A")]
	public static T EnsureInitialized(ref T target) { }

	[Address(RVA = "0x852680", Offset = "0x851A80", Length = "0xD4")]
	[Token(Token = "0x600117C")]
	public static T EnsureInitialized(ref T target, Func<T> valueFactory) { }

	[Address(RVA = "0x852400", Offset = "0x851800", Length = "0x81")]
	[Token(Token = "0x600117E")]
	public static T EnsureInitialized(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }

	[Address(RVA = "0x852600", Offset = "0x851A00", Length = "0x78")]
	[Token(Token = "0x6001180")]
	public static T EnsureInitialized(ref T target, ref object syncLock, Func<T> valueFactory) { }

	[Address(RVA = "0x8522B0", Offset = "0x8516B0", Length = "0x94")]
	[Token(Token = "0x600117B")]
	private static T EnsureInitializedCore(ref T target) { }

	[Address(RVA = "0x852350", Offset = "0x851750", Length = "0xA2")]
	[Token(Token = "0x600117D")]
	private static T EnsureInitializedCore(ref T target, Func<T> valueFactory) { }

	[Address(RVA = "0x851E60", Offset = "0x851260", Length = "0x114")]
	[Token(Token = "0x600117F")]
	private static T EnsureInitializedCore(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }

	[Address(RVA = "0x852160", Offset = "0x851560", Length = "0x14C")]
	[Token(Token = "0x6001181")]
	private static T EnsureInitializedCore(ref T target, ref object syncLock, Func<T> valueFactory) { }

	[Address(RVA = "0x209F4C0", Offset = "0x209E8C0", Length = "0x6F")]
	[Token(Token = "0x6001182")]
	private static object EnsureLockInitialized(ref object syncLock) { }

}

