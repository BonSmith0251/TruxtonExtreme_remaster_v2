namespace UnityEngine.UnityConsent;

[NativeHeader("Modules/UnityConsent/EndUserConsent.h")]
[Token(Token = "0x2000004")]
public static class EndUserConsent
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000007")]
	private static Action<ConsentState> consentStateChanged; //Field offset: 0x0

	[Address(RVA = "0x3479D30", Offset = "0x3479130", Length = "0x3D")]
	[NativeMethod("GetConsentStateStatic")]
	[Token(Token = "0x6000003")]
	public static ConsentState GetConsentState() { }

	[Address(RVA = "0x3479CF0", Offset = "0x34790F0", Length = "0x33")]
	[Token(Token = "0x6000005")]
	private static void GetConsentState_Injected(out ConsentState ret) { }

	[Address(RVA = "0x3479D70", Offset = "0x3479170", Length = "0x92")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000004")]
	private static void OnConsentStateChanged() { }

}

