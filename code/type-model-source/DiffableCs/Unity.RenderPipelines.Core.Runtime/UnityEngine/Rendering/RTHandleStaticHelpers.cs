namespace UnityEngine.Rendering;

[Token(Token = "0x200019A")]
public struct RTHandleStaticHelpers
{
	[Token(Token = "0x40007DC")]
	public static RTHandle s_RTHandleWrapper; //Field offset: 0x0

	[Address(RVA = "0x2C47FF0", Offset = "0x2C473F0", Length = "0x17C")]
	[Token(Token = "0x6000BD9")]
	public static void SetRTHandleStaticWrapper(RenderTargetIdentifier rtId) { }

	[Address(RVA = "0x2C48170", Offset = "0x2C47570", Length = "0x61")]
	[Token(Token = "0x6000BDA")]
	public static void SetRTHandleUserManagedWrapper(ref RTHandle rtWrapper, RenderTargetIdentifier rtId) { }

}

