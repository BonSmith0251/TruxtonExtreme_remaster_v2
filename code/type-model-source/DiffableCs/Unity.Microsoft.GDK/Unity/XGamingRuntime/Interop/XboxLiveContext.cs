namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003BD")]
public static class XboxLiveContext
{

	[Address(RVA = "0x2BB8E00", Offset = "0x2BB8200", Length = "0x87")]
	[Token(Token = "0x600127D")]
	public static int XblContextDuplicateHandle(IntPtr xboxLiveContextHandle, out IntPtr duplicatedHandle) { }

	[Address(RVA = "0x2BB8E90", Offset = "0x2BB8290", Length = "0x87")]
	[Token(Token = "0x600127E")]
	public static int XblContextGetUser(IntPtr context, out IntPtr user) { }

	[Address(RVA = "0x2BB8F20", Offset = "0x2BB8320", Length = "0x87")]
	[Token(Token = "0x600127F")]
	public static int XblContextGetXboxUserId(IntPtr context, out ulong xboxUserId) { }

}

