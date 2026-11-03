namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000330")]
internal struct XblPermissionCheckResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400090C")]
	internal readonly NativeBool isAllowed; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400090D")]
	internal readonly ulong targetXuid; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400090E")]
	internal readonly XblAnonymousUserType targetUserType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400090F")]
	internal readonly XblPermission permissionRequested; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000910")]
	private readonly XblPermissionDenyReasonDetails* reasons; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000911")]
	internal readonly SizeT reasonsCount; //Field offset: 0x20

	[Address(RVA = "0x9E7560", Offset = "0x9E6960", Length = "0x58")]
	[Token(Token = "0x600119E")]
	internal T[] GetReasons(Func<XblPermissionDenyReasonDetails, T> ctor) { }

}

