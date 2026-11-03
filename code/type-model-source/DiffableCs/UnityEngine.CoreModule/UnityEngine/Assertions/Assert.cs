namespace UnityEngine.Assertions;

[DebuggerStepThrough]
[Token(Token = "0x200032E")]
public static class Assert
{
	[Obsolete("Future versions of Unity are expected to always throw exceptions and not have this field.")]
	[Token(Token = "0x400084F")]
	public static bool raiseExceptions; //Field offset: 0x0

	[Address(RVA = "0x30772E0", Offset = "0x30766E0", Length = "0x36")]
	[Token(Token = "0x60019D6")]
	private static Assert() { }

	[Address(RVA = "0x3076960", Offset = "0x3075D60", Length = "0x6D")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019D4")]
	public static void AreEqual(int expected, int actual) { }

	[Address(RVA = "0x3076B20", Offset = "0x3075F20", Length = "0x7A")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019D5")]
	public static void AreEqual(int expected, int actual, string message) { }

	[Address(RVA = "0x733620", Offset = "0x732A20", Length = "0x271")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019CC")]
	public static void AreEqual(T expected, T actual, string message, IEqualityComparer<T> comparer) { }

	[Address(RVA = "0x733AA0", Offset = "0x732EA0", Length = "0xA4")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019CB")]
	public static void AreEqual(T expected, T actual, string message) { }

	[Address(RVA = "0x30769D0", Offset = "0x3075DD0", Length = "0x14C")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019CD")]
	public static void AreEqual(object expected, object actual, string message) { }

	[Address(RVA = "0x7338A0", Offset = "0x732CA0", Length = "0x70")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019CA")]
	public static void AreEqual(T expected, T actual) { }

	[Address(RVA = "0x3076BA0", Offset = "0x3075FA0", Length = "0x116")]
	[Token(Token = "0x60019C5")]
	private static void Fail(string message, string userMessage) { }

	[Address(RVA = "0x3076DD0", Offset = "0x30761D0", Length = "0xE2")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019C9")]
	public static void IsFalse(bool condition, string message) { }

	[Address(RVA = "0x3076CC0", Offset = "0x30760C0", Length = "0x106")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019C8")]
	public static void IsFalse(bool condition) { }

	[Address(RVA = "0x7340C0", Offset = "0x7334C0", Length = "0x1A8")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019D1")]
	public static void IsNotNull(T value) { }

	[Address(RVA = "0x733F50", Offset = "0x733350", Length = "0x16B")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019D2")]
	public static void IsNotNull(T value, string message) { }

	[Address(RVA = "0x3076EC0", Offset = "0x30762C0", Length = "0x104")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019D3")]
	public static void IsNotNull(object value, string message) { }

	[Address(RVA = "0x734270", Offset = "0x733670", Length = "0x1AA")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019CE")]
	public static void IsNull(T value) { }

	[Address(RVA = "0x734420", Offset = "0x733820", Length = "0x16D")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019CF")]
	public static void IsNull(T value, string message) { }

	[Address(RVA = "0x3076FD0", Offset = "0x30763D0", Length = "0x104")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019D0")]
	public static void IsNull(object value, string message) { }

	[Address(RVA = "0x30770E0", Offset = "0x30764E0", Length = "0xE2")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019C7")]
	public static void IsTrue(bool condition, string message) { }

	[Address(RVA = "0x30771D0", Offset = "0x30765D0", Length = "0x107")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x60019C6")]
	public static void IsTrue(bool condition) { }

}

