namespace System;

[StackTraceHidden]
[Token(Token = "0x2000166")]
internal static class ThrowHelper
{

	[Address(RVA = "0x204C060", Offset = "0x204B460", Length = "0x58")]
	[Token(Token = "0x6000C64")]
	private static Exception CreateArgumentException_DestinationTooShort() { }

	[Address(RVA = "0x204C0C0", Offset = "0x204B4C0", Length = "0x87")]
	[Token(Token = "0x6000C60")]
	private static Exception CreateArgumentNullException(ExceptionArgument argument) { }

	[Address(RVA = "0x204C1A0", Offset = "0x204B5A0", Length = "0x87")]
	[Token(Token = "0x6000C6A")]
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

	[Address(RVA = "0x204C150", Offset = "0x204B550", Length = "0x44")]
	[Token(Token = "0x6000C68")]
	private static Exception CreateArgumentOutOfRangeException() { }

	[Address(RVA = "0x204C230", Offset = "0x204B630", Length = "0x44")]
	[Token(Token = "0x6000C62")]
	private static Exception CreateArrayTypeMismatchException() { }

	[Address(RVA = "0x204C280", Offset = "0x204B680", Length = "0x44")]
	[Token(Token = "0x6000C66")]
	private static Exception CreateIndexOutOfRangeException() { }

	[Address(RVA = "0x204C2D0", Offset = "0x204B6D0", Length = "0x44")]
	[Token(Token = "0x6000C6C")]
	private static Exception CreateThrowNotSupportedException() { }

	[Address(RVA = "0x204C320", Offset = "0x204B720", Length = "0x75")]
	[Token(Token = "0x6000C7E")]
	private static ArgumentException GetAddingDuplicateWithKeyArgumentException(object key) { }

	[Address(RVA = "0x204C3A0", Offset = "0x204B7A0", Length = "0x87")]
	[Token(Token = "0x6000C87")]
	private static ArgumentException GetArgumentException(ExceptionResource resource) { }

	[Address(RVA = "0x204C430", Offset = "0x204B830", Length = "0x150")]
	[Token(Token = "0x6000C8A")]
	internal static string GetArgumentName(ExceptionArgument argument) { }

	[Address(RVA = "0x204C740", Offset = "0x204BB40", Length = "0x5F")]
	[Token(Token = "0x6000C88")]
	private static ArgumentNullException GetArgumentNullException(ExceptionArgument argument) { }

	[Address(RVA = "0x204C7A0", Offset = "0x204BBA0", Length = "0x6F")]
	[Token(Token = "0x6000C7A")]
	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, string resource) { }

	[Address(RVA = "0x204C810", Offset = "0x204BC10", Length = "0xA2")]
	[Token(Token = "0x6000C8B")]
	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	[Address(RVA = "0x204C8C0", Offset = "0x204BCC0", Length = "0x12D")]
	[Token(Token = "0x6000C86")]
	private static Exception GetArraySegmentCtorValidationFailedException(Array array, int offset, int count) { }

	[Address(RVA = "0x204C9F0", Offset = "0x204BDF0", Length = "0x54")]
	[Token(Token = "0x6000C84")]
	internal static InvalidOperationException GetInvalidOperationException(string str) { }

	[Address(RVA = "0x204CA50", Offset = "0x204BE50", Length = "0x7B")]
	[Token(Token = "0x6000C80")]
	private static KeyNotFoundException GetKeyNotFoundException(object key) { }

	[Address(RVA = "0x204CAD0", Offset = "0x204BED0", Length = "0x258")]
	[Token(Token = "0x6000C8E")]
	internal static string GetResourceName(ExceptionResource resource) { }

	[Address(RVA = "0x945020", Offset = "0x944420", Length = "0x11")]
	[Token(Token = "0x6000C89")]
	internal static void IfNullAndNullsAreIllegalThenThrow(object value, ExceptionArgument argName) { }

	[Address(RVA = "0x204D060", Offset = "0x204C460", Length = "0x27")]
	[Token(Token = "0x6000C7F")]
	internal static void ThrowAddingDuplicateWithKeyArgumentException(object key) { }

	[Address(RVA = "0x204D190", Offset = "0x204C590", Length = "0x5A")]
	[Token(Token = "0x6000C6F")]
	internal static void ThrowArgumentException(ExceptionResource resource) { }

	[Address(RVA = "0x204D110", Offset = "0x204C510", Length = "0x70")]
	[Token(Token = "0x6000C70")]
	internal static void ThrowArgumentException(ExceptionResource resource, ExceptionArgument argument) { }

	[Address(RVA = "0x204D090", Offset = "0x204C490", Length = "0x4E")]
	[Token(Token = "0x6000C7D")]
	internal static void ThrowArgumentException_Argument_InvalidArrayType() { }

	[Address(RVA = "0x204D0E0", Offset = "0x204C4E0", Length = "0x27")]
	[Token(Token = "0x6000C63")]
	internal static void ThrowArgumentException_DestinationTooShort() { }

	[Address(RVA = "0x204D1F0", Offset = "0x204C5F0", Length = "0x27")]
	[Token(Token = "0x6000C5F")]
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	[Address(RVA = "0x204D370", Offset = "0x204C770", Length = "0x3C")]
	[Token(Token = "0x6000C7B")]
	internal static void ThrowArgumentOutOfRange_IndexException() { }

	[Address(RVA = "0x204D340", Offset = "0x204C740", Length = "0x27")]
	[Token(Token = "0x6000C67")]
	internal static void ThrowArgumentOutOfRangeException() { }

	[Address(RVA = "0x204D220", Offset = "0x204C620", Length = "0xE3")]
	[Token(Token = "0x6000C71")]
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	[Address(RVA = "0x204D310", Offset = "0x204C710", Length = "0x27")]
	[Token(Token = "0x6000C69")]
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	[Address(RVA = "0x204D3B0", Offset = "0x204C7B0", Length = "0x28")]
	[Token(Token = "0x6000C85")]
	internal static void ThrowArraySegmentCtorValidationFailedExceptions(Array array, int offset, int count) { }

	[Address(RVA = "0x204D3E0", Offset = "0x204C7E0", Length = "0x27")]
	[Token(Token = "0x6000C61")]
	internal static void ThrowArrayTypeMismatchException() { }

	[Address(RVA = "0x204D410", Offset = "0x204C810", Length = "0x32")]
	[Token(Token = "0x6000C8D")]
	internal static void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count() { }

	[Address(RVA = "0x204D450", Offset = "0x204C850", Length = "0x3C")]
	[Token(Token = "0x6000C7C")]
	internal static void ThrowIndexArgumentOutOfRange_NeedNonNegNumException() { }

	[Address(RVA = "0x204D490", Offset = "0x204C890", Length = "0x27")]
	[Token(Token = "0x6000C65")]
	internal static void ThrowIndexOutOfRangeException() { }

	[Address(RVA = "0x204D690", Offset = "0x204CA90", Length = "0x5A")]
	[Token(Token = "0x6000C72")]
	internal static void ThrowInvalidOperationException(ExceptionResource resource) { }

	[Address(RVA = "0x204D4C0", Offset = "0x204C8C0", Length = "0x36")]
	[Token(Token = "0x6000C83")]
	internal static void ThrowInvalidOperationException_ConcurrentOperationsNotSupported() { }

	[Address(RVA = "0x204D500", Offset = "0x204C900", Length = "0x4E")]
	[Token(Token = "0x6000C78")]
	internal static void ThrowInvalidOperationException_InvalidOperation_EnumEnded() { }

	[Address(RVA = "0x204D550", Offset = "0x204C950", Length = "0x4E")]
	[Token(Token = "0x6000C75")]
	internal static void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion() { }

	[Address(RVA = "0x204D5A0", Offset = "0x204C9A0", Length = "0x4E")]
	[Token(Token = "0x6000C77")]
	internal static void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted() { }

	[Address(RVA = "0x204D5F0", Offset = "0x204C9F0", Length = "0x4E")]
	[Token(Token = "0x6000C76")]
	internal static void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen() { }

	[Address(RVA = "0x204D640", Offset = "0x204CA40", Length = "0x4E")]
	[Token(Token = "0x6000C79")]
	internal static void ThrowInvalidOperationException_InvalidOperation_NoValue() { }

	[Address(RVA = "0x204D6F0", Offset = "0x204CAF0", Length = "0x66")]
	[Token(Token = "0x6000C82")]
	internal static void ThrowInvalidTypeWithPointersNotSupported(Type targetType) { }

	[Address(RVA = "0x204D760", Offset = "0x204CB60", Length = "0xB")]
	[Token(Token = "0x6000C81")]
	internal static void ThrowKeyNotFoundException(object key) { }

	[Address(RVA = "0x204D7D0", Offset = "0x204CBD0", Length = "0x27")]
	[Token(Token = "0x6000C6B")]
	internal static void ThrowNotSupportedException() { }

	[Address(RVA = "0x204D770", Offset = "0x204CB70", Length = "0x5A")]
	[Token(Token = "0x6000C74")]
	internal static void ThrowNotSupportedException(ExceptionResource resource) { }

	[Address(RVA = "0x204D800", Offset = "0x204CC00", Length = "0x5A")]
	[Token(Token = "0x6000C73")]
	internal static void ThrowSerializationException(ExceptionResource resource) { }

	[Address(RVA = "0x204D860", Offset = "0x204CC60", Length = "0x32")]
	[Token(Token = "0x6000C8C")]
	internal static void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index() { }

	[Address(RVA = "0x204D8A0", Offset = "0x204CCA0", Length = "0xDC")]
	[Token(Token = "0x6000C6D")]
	internal static void ThrowWrongKeyTypeArgumentException(object key, Type targetType) { }

	[Address(RVA = "0x204D980", Offset = "0x204CD80", Length = "0xDC")]
	[Token(Token = "0x6000C6E")]
	internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType) { }

}

