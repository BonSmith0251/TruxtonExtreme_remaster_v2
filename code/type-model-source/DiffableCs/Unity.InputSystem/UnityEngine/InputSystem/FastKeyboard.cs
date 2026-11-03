namespace UnityEngine.InputSystem;

[Token(Token = "0x2000095")]
internal class FastKeyboard : Keyboard
{
	[Token(Token = "0x4000404")]
	public const string metadata = ";AnyKey;Button;Axis;Key;DiscreteButton;Keyboard"; //Field offset: 0x0

	[Address(RVA = "0x2958640", Offset = "0x2957A40", Length = "0x58B4")]
	[Token(Token = "0x60007AA")]
	public FastKeyboard() { }

	[Address(RVA = "0x2944620", Offset = "0x2943A20", Length = "0x25F")]
	[Token(Token = "0x60007E2")]
	private KeyControl Initialize_ctrlKeyboard0(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2944880", Offset = "0x2943C80", Length = "0x25F")]
	[Token(Token = "0x60007D9")]
	private KeyControl Initialize_ctrlKeyboard1(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2944AE0", Offset = "0x2943EE0", Length = "0x25F")]
	[Token(Token = "0x60007DA")]
	private KeyControl Initialize_ctrlKeyboard2(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2944D40", Offset = "0x2944140", Length = "0x25F")]
	[Token(Token = "0x60007DB")]
	private KeyControl Initialize_ctrlKeyboard3(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2944FA0", Offset = "0x29443A0", Length = "0x25F")]
	[Token(Token = "0x60007DC")]
	private KeyControl Initialize_ctrlKeyboard4(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2945200", Offset = "0x2944600", Length = "0x25F")]
	[Token(Token = "0x60007DD")]
	private KeyControl Initialize_ctrlKeyboard5(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2945460", Offset = "0x2944860", Length = "0x25F")]
	[Token(Token = "0x60007DE")]
	private KeyControl Initialize_ctrlKeyboard6(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29456C0", Offset = "0x2944AC0", Length = "0x25F")]
	[Token(Token = "0x60007DF")]
	private KeyControl Initialize_ctrlKeyboard7(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2945920", Offset = "0x2944D20", Length = "0x25F")]
	[Token(Token = "0x60007E0")]
	private KeyControl Initialize_ctrlKeyboard8(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2945B80", Offset = "0x2944F80", Length = "0x25F")]
	[Token(Token = "0x60007E1")]
	private KeyControl Initialize_ctrlKeyboard9(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2946EA0", Offset = "0x29462A0", Length = "0x26B")]
	[Token(Token = "0x60007BF")]
	private KeyControl Initialize_ctrlKeyboarda(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2947110", Offset = "0x2946510", Length = "0x2A4")]
	[Token(Token = "0x60007E8")]
	private DiscreteButtonControl Initialize_ctrlKeyboardalt(InternedString kDiscreteButtonLayout, InputControl parent) { }

	[Address(RVA = "0x29473C0", Offset = "0x29467C0", Length = "0x263")]
	[Token(Token = "0x60007AB")]
	private AnyKeyControl Initialize_ctrlKeyboardanyKey(InternedString kAnyKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2947630", Offset = "0x2946A30", Length = "0x26B")]
	[Token(Token = "0x60007C0")]
	private KeyControl Initialize_ctrlKeyboardb(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29478A0", Offset = "0x2946CA0", Length = "0x265")]
	[Token(Token = "0x60007B0")]
	private KeyControl Initialize_ctrlKeyboardbackquote(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2947B10", Offset = "0x2946F10", Length = "0x265")]
	[Token(Token = "0x60007B6")]
	private KeyControl Initialize_ctrlKeyboardbackslash(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2947D80", Offset = "0x2947180", Length = "0x26B")]
	[Token(Token = "0x60007EF")]
	private KeyControl Initialize_ctrlKeyboardbackspace(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2947FF0", Offset = "0x29473F0", Length = "0x26B")]
	[Token(Token = "0x60007C1")]
	private KeyControl Initialize_ctrlKeyboardc(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2948260", Offset = "0x2947660", Length = "0x26B")]
	[Token(Token = "0x60007F6")]
	private KeyControl Initialize_ctrlKeyboardcapsLock(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29484D0", Offset = "0x29478D0", Length = "0x265")]
	[Token(Token = "0x60007B3")]
	private KeyControl Initialize_ctrlKeyboardcomma(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2948740", Offset = "0x2947B40", Length = "0x27F")]
	[Token(Token = "0x60007EE")]
	private KeyControl Initialize_ctrlKeyboardcontextMenu(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29489C0", Offset = "0x2947DC0", Length = "0x2A4")]
	[Token(Token = "0x60007EB")]
	private DiscreteButtonControl Initialize_ctrlKeyboardctrl(InternedString kDiscreteButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2948C70", Offset = "0x2948070", Length = "0x26B")]
	[Token(Token = "0x60007C2")]
	private KeyControl Initialize_ctrlKeyboardd(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2948EE0", Offset = "0x29482E0", Length = "0x26B")]
	[Token(Token = "0x60007F5")]
	private KeyControl Initialize_ctrlKeyboarddelete(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2949150", Offset = "0x2948550", Length = "0x26B")]
	[Token(Token = "0x60007BC")]
	private KeyControl Initialize_ctrlKeyboarddownArrow(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29493C0", Offset = "0x29487C0", Length = "0x26B")]
	[Token(Token = "0x60007C3")]
	private KeyControl Initialize_ctrlKeyboarde(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2949630", Offset = "0x2948A30", Length = "0x26B")]
	[Token(Token = "0x60007F3")]
	private KeyControl Initialize_ctrlKeyboardend(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29498A0", Offset = "0x2948CA0", Length = "0x279")]
	[Token(Token = "0x60007AE")]
	private KeyControl Initialize_ctrlKeyboardenter(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2949B20", Offset = "0x2948F20", Length = "0x26B")]
	[Token(Token = "0x60007BA")]
	private KeyControl Initialize_ctrlKeyboardequals(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2949D90", Offset = "0x2949190", Length = "0x270")]
	[Token(Token = "0x60007AC")]
	private KeyControl Initialize_ctrlKeyboardescape(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294DA90", Offset = "0x294CE90", Length = "0x26B")]
	[Token(Token = "0x60007C4")]
	private KeyControl Initialize_ctrlKeyboardf(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294B870", Offset = "0x294AC70", Length = "0x26B")]
	[Token(Token = "0x600080C")]
	private KeyControl Initialize_ctrlKeyboardf1(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294A010", Offset = "0x2949410", Length = "0x26B")]
	[Token(Token = "0x6000815")]
	private KeyControl Initialize_ctrlKeyboardf10(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294A280", Offset = "0x2949680", Length = "0x26B")]
	[Token(Token = "0x6000816")]
	private KeyControl Initialize_ctrlKeyboardf11(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294A4F0", Offset = "0x29498F0", Length = "0x26B")]
	[Token(Token = "0x6000817")]
	private KeyControl Initialize_ctrlKeyboardf12(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294A760", Offset = "0x2949B60", Length = "0x26B")]
	[Token(Token = "0x600081D")]
	private KeyControl Initialize_ctrlKeyboardf13(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294A9D0", Offset = "0x2949DD0", Length = "0x26B")]
	[Token(Token = "0x600081E")]
	private KeyControl Initialize_ctrlKeyboardf14(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294AC40", Offset = "0x294A040", Length = "0x26B")]
	[Token(Token = "0x600081F")]
	private KeyControl Initialize_ctrlKeyboardf15(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294AEB0", Offset = "0x294A2B0", Length = "0x26B")]
	[Token(Token = "0x6000820")]
	private KeyControl Initialize_ctrlKeyboardf16(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294B120", Offset = "0x294A520", Length = "0x26B")]
	[Token(Token = "0x6000821")]
	private KeyControl Initialize_ctrlKeyboardf17(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294B390", Offset = "0x294A790", Length = "0x26B")]
	[Token(Token = "0x6000822")]
	private KeyControl Initialize_ctrlKeyboardf18(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294B600", Offset = "0x294AA00", Length = "0x26B")]
	[Token(Token = "0x6000823")]
	private KeyControl Initialize_ctrlKeyboardf19(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294C710", Offset = "0x294BB10", Length = "0x26B")]
	[Token(Token = "0x600080D")]
	private KeyControl Initialize_ctrlKeyboardf2(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294BAE0", Offset = "0x294AEE0", Length = "0x26B")]
	[Token(Token = "0x6000824")]
	private KeyControl Initialize_ctrlKeyboardf20(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294BD50", Offset = "0x294B150", Length = "0x26B")]
	[Token(Token = "0x6000825")]
	private KeyControl Initialize_ctrlKeyboardf21(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294BFC0", Offset = "0x294B3C0", Length = "0x26B")]
	[Token(Token = "0x6000826")]
	private KeyControl Initialize_ctrlKeyboardf22(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294C230", Offset = "0x294B630", Length = "0x26B")]
	[Token(Token = "0x6000827")]
	private KeyControl Initialize_ctrlKeyboardf23(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294C4A0", Offset = "0x294B8A0", Length = "0x26B")]
	[Token(Token = "0x6000828")]
	private KeyControl Initialize_ctrlKeyboardf24(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294C980", Offset = "0x294BD80", Length = "0x26B")]
	[Token(Token = "0x600080E")]
	private KeyControl Initialize_ctrlKeyboardf3(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294CBF0", Offset = "0x294BFF0", Length = "0x26B")]
	[Token(Token = "0x600080F")]
	private KeyControl Initialize_ctrlKeyboardf4(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294CE60", Offset = "0x294C260", Length = "0x26B")]
	[Token(Token = "0x6000810")]
	private KeyControl Initialize_ctrlKeyboardf5(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294D0D0", Offset = "0x294C4D0", Length = "0x26B")]
	[Token(Token = "0x6000811")]
	private KeyControl Initialize_ctrlKeyboardf6(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294D340", Offset = "0x294C740", Length = "0x26B")]
	[Token(Token = "0x6000812")]
	private KeyControl Initialize_ctrlKeyboardf7(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294D5B0", Offset = "0x294C9B0", Length = "0x26B")]
	[Token(Token = "0x6000813")]
	private KeyControl Initialize_ctrlKeyboardf8(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294D820", Offset = "0x294CC20", Length = "0x26B")]
	[Token(Token = "0x6000814")]
	private KeyControl Initialize_ctrlKeyboardf9(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294DD00", Offset = "0x294D100", Length = "0x26B")]
	[Token(Token = "0x60007C5")]
	private KeyControl Initialize_ctrlKeyboardg(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294DF70", Offset = "0x294D370", Length = "0x26B")]
	[Token(Token = "0x60007C6")]
	private KeyControl Initialize_ctrlKeyboardh(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294E1E0", Offset = "0x294D5E0", Length = "0x26B")]
	[Token(Token = "0x60007F2")]
	private KeyControl Initialize_ctrlKeyboardhome(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294E450", Offset = "0x294D850", Length = "0x26B")]
	[Token(Token = "0x60007C7")]
	private KeyControl Initialize_ctrlKeyboardi(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2946050", Offset = "0x2945450", Length = "0x260")]
	[Token(Token = "0x600082C")]
	private ButtonControl Initialize_ctrlKeyboardIMESelected(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2945DE0", Offset = "0x29451E0", Length = "0x26F")]
	[Token(Token = "0x600082D")]
	private KeyControl Initialize_ctrlKeyboardIMESelectedObsoleteKey(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294E6C0", Offset = "0x294DAC0", Length = "0x26B")]
	[Token(Token = "0x60007F4")]
	private KeyControl Initialize_ctrlKeyboardinsert(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294E930", Offset = "0x294DD30", Length = "0x26B")]
	[Token(Token = "0x60007C8")]
	private KeyControl Initialize_ctrlKeyboardj(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294EBA0", Offset = "0x294DFA0", Length = "0x26B")]
	[Token(Token = "0x60007C9")]
	private KeyControl Initialize_ctrlKeyboardk(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294EE10", Offset = "0x294E210", Length = "0x26B")]
	[Token(Token = "0x60007CA")]
	private KeyControl Initialize_ctrlKeyboardl(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294F080", Offset = "0x294E480", Length = "0x27F")]
	[Token(Token = "0x60007E6")]
	private KeyControl Initialize_ctrlKeyboardleftAlt(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294F300", Offset = "0x294E700", Length = "0x26B")]
	[Token(Token = "0x60007BD")]
	private KeyControl Initialize_ctrlKeyboardleftArrow(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294F570", Offset = "0x294E970", Length = "0x26B")]
	[Token(Token = "0x60007B7")]
	private KeyControl Initialize_ctrlKeyboardleftBracket(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294F7E0", Offset = "0x294EBE0", Length = "0x27F")]
	[Token(Token = "0x60007E9")]
	private KeyControl Initialize_ctrlKeyboardleftCtrl(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294FA60", Offset = "0x294EE60", Length = "0x293")]
	[Token(Token = "0x60007EC")]
	private KeyControl Initialize_ctrlKeyboardleftMeta(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294FD00", Offset = "0x294F100", Length = "0x27F")]
	[Token(Token = "0x60007E3")]
	private KeyControl Initialize_ctrlKeyboardleftShift(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x294FF80", Offset = "0x294F380", Length = "0x26B")]
	[Token(Token = "0x60007CB")]
	private KeyControl Initialize_ctrlKeyboardm(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29501F0", Offset = "0x294F5F0", Length = "0x26E")]
	[Token(Token = "0x600082B")]
	private KeyControl Initialize_ctrlKeyboardmediaForward(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2950460", Offset = "0x294F860", Length = "0x26B")]
	[Token(Token = "0x6000829")]
	private KeyControl Initialize_ctrlKeyboardmediaPlayPause(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29506D0", Offset = "0x294FAD0", Length = "0x26B")]
	[Token(Token = "0x600082A")]
	private KeyControl Initialize_ctrlKeyboardmediaRewind(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2950940", Offset = "0x294FD40", Length = "0x26B")]
	[Token(Token = "0x60007B9")]
	private KeyControl Initialize_ctrlKeyboardminus(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2950BB0", Offset = "0x294FFB0", Length = "0x26B")]
	[Token(Token = "0x60007CC")]
	private KeyControl Initialize_ctrlKeyboardn(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2950E20", Offset = "0x2950220", Length = "0x26B")]
	[Token(Token = "0x60007F7")]
	private KeyControl Initialize_ctrlKeyboardnumLock(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2951090", Offset = "0x2950490", Length = "0x26B")]
	[Token(Token = "0x600080B")]
	private KeyControl Initialize_ctrlKeyboardnumpad0(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2951300", Offset = "0x2950700", Length = "0x26B")]
	[Token(Token = "0x6000802")]
	private KeyControl Initialize_ctrlKeyboardnumpad1(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2951570", Offset = "0x2950970", Length = "0x26B")]
	[Token(Token = "0x6000803")]
	private KeyControl Initialize_ctrlKeyboardnumpad2(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29517E0", Offset = "0x2950BE0", Length = "0x26B")]
	[Token(Token = "0x6000804")]
	private KeyControl Initialize_ctrlKeyboardnumpad3(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2951A50", Offset = "0x2950E50", Length = "0x26B")]
	[Token(Token = "0x6000805")]
	private KeyControl Initialize_ctrlKeyboardnumpad4(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2951CC0", Offset = "0x29510C0", Length = "0x26B")]
	[Token(Token = "0x6000806")]
	private KeyControl Initialize_ctrlKeyboardnumpad5(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2951F30", Offset = "0x2951330", Length = "0x26B")]
	[Token(Token = "0x6000807")]
	private KeyControl Initialize_ctrlKeyboardnumpad6(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29521A0", Offset = "0x29515A0", Length = "0x26B")]
	[Token(Token = "0x6000808")]
	private KeyControl Initialize_ctrlKeyboardnumpad7(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2952410", Offset = "0x2951810", Length = "0x26B")]
	[Token(Token = "0x6000809")]
	private KeyControl Initialize_ctrlKeyboardnumpad8(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2952680", Offset = "0x2951A80", Length = "0x26B")]
	[Token(Token = "0x600080A")]
	private KeyControl Initialize_ctrlKeyboardnumpad9(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29528F0", Offset = "0x2951CF0", Length = "0x26B")]
	[Token(Token = "0x60007FC")]
	private KeyControl Initialize_ctrlKeyboardnumpadDivide(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2952B60", Offset = "0x2951F60", Length = "0x26B")]
	[Token(Token = "0x60007FB")]
	private KeyControl Initialize_ctrlKeyboardnumpadEnter(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2952DD0", Offset = "0x29521D0", Length = "0x26B")]
	[Token(Token = "0x6000801")]
	private KeyControl Initialize_ctrlKeyboardnumpadEquals(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2953040", Offset = "0x2952440", Length = "0x26B")]
	[Token(Token = "0x60007FF")]
	private KeyControl Initialize_ctrlKeyboardnumpadMinus(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29532B0", Offset = "0x29526B0", Length = "0x26B")]
	[Token(Token = "0x60007FD")]
	private KeyControl Initialize_ctrlKeyboardnumpadMultiply(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2953520", Offset = "0x2952920", Length = "0x26B")]
	[Token(Token = "0x6000800")]
	private KeyControl Initialize_ctrlKeyboardnumpadPeriod(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2953790", Offset = "0x2952B90", Length = "0x26B")]
	[Token(Token = "0x60007FE")]
	private KeyControl Initialize_ctrlKeyboardnumpadPlus(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2953A00", Offset = "0x2952E00", Length = "0x26B")]
	[Token(Token = "0x60007CD")]
	private KeyControl Initialize_ctrlKeyboardo(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29462C0", Offset = "0x29456C0", Length = "0x25F")]
	[Token(Token = "0x6000818")]
	private KeyControl Initialize_ctrlKeyboardOEM1(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2946520", Offset = "0x2945920", Length = "0x25F")]
	[Token(Token = "0x6000819")]
	private KeyControl Initialize_ctrlKeyboardOEM2(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2946780", Offset = "0x2945B80", Length = "0x25F")]
	[Token(Token = "0x600081A")]
	private KeyControl Initialize_ctrlKeyboardOEM3(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29469E0", Offset = "0x2945DE0", Length = "0x25F")]
	[Token(Token = "0x600081B")]
	private KeyControl Initialize_ctrlKeyboardOEM4(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2946C40", Offset = "0x2946040", Length = "0x25F")]
	[Token(Token = "0x600081C")]
	private KeyControl Initialize_ctrlKeyboardOEM5(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2953C70", Offset = "0x2953070", Length = "0x26B")]
	[Token(Token = "0x60007CE")]
	private KeyControl Initialize_ctrlKeyboardp(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2953EE0", Offset = "0x29532E0", Length = "0x26B")]
	[Token(Token = "0x60007F0")]
	private KeyControl Initialize_ctrlKeyboardpageDown(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2954150", Offset = "0x2953550", Length = "0x26B")]
	[Token(Token = "0x60007F1")]
	private KeyControl Initialize_ctrlKeyboardpageUp(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29543C0", Offset = "0x29537C0", Length = "0x26B")]
	[Token(Token = "0x60007FA")]
	private KeyControl Initialize_ctrlKeyboardpause(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2954630", Offset = "0x2953A30", Length = "0x265")]
	[Token(Token = "0x60007B4")]
	private KeyControl Initialize_ctrlKeyboardperiod(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29548A0", Offset = "0x2953CA0", Length = "0x26B")]
	[Token(Token = "0x60007F8")]
	private KeyControl Initialize_ctrlKeyboardprintScreen(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2954B10", Offset = "0x2953F10", Length = "0x26B")]
	[Token(Token = "0x60007CF")]
	private KeyControl Initialize_ctrlKeyboardq(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2954D80", Offset = "0x2954180", Length = "0x265")]
	[Token(Token = "0x60007B1")]
	private KeyControl Initialize_ctrlKeyboardquote(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2954FF0", Offset = "0x29543F0", Length = "0x26B")]
	[Token(Token = "0x60007D0")]
	private KeyControl Initialize_ctrlKeyboardr(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2955260", Offset = "0x2954660", Length = "0x28A")]
	[Token(Token = "0x60007E7")]
	private KeyControl Initialize_ctrlKeyboardrightAlt(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29554F0", Offset = "0x29548F0", Length = "0x26B")]
	[Token(Token = "0x60007BE")]
	private KeyControl Initialize_ctrlKeyboardrightArrow(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2955760", Offset = "0x2954B60", Length = "0x26B")]
	[Token(Token = "0x60007B8")]
	private KeyControl Initialize_ctrlKeyboardrightBracket(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29559D0", Offset = "0x2954DD0", Length = "0x27F")]
	[Token(Token = "0x60007EA")]
	private KeyControl Initialize_ctrlKeyboardrightCtrl(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2955C50", Offset = "0x2955050", Length = "0x293")]
	[Token(Token = "0x60007ED")]
	private KeyControl Initialize_ctrlKeyboardrightMeta(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2955EF0", Offset = "0x29552F0", Length = "0x27F")]
	[Token(Token = "0x60007E4")]
	private KeyControl Initialize_ctrlKeyboardrightShift(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2956170", Offset = "0x2955570", Length = "0x26B")]
	[Token(Token = "0x60007D1")]
	private KeyControl Initialize_ctrlKeyboards(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29563E0", Offset = "0x29557E0", Length = "0x26B")]
	[Token(Token = "0x60007F9")]
	private KeyControl Initialize_ctrlKeyboardscrollLock(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2956650", Offset = "0x2955A50", Length = "0x265")]
	[Token(Token = "0x60007B2")]
	private KeyControl Initialize_ctrlKeyboardsemicolon(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29568C0", Offset = "0x2955CC0", Length = "0x2A4")]
	[Token(Token = "0x60007E5")]
	private DiscreteButtonControl Initialize_ctrlKeyboardshift(InternedString kDiscreteButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2956B70", Offset = "0x2955F70", Length = "0x265")]
	[Token(Token = "0x60007B5")]
	private KeyControl Initialize_ctrlKeyboardslash(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2956DE0", Offset = "0x29561E0", Length = "0x265")]
	[Token(Token = "0x60007AD")]
	private KeyControl Initialize_ctrlKeyboardspace(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2957050", Offset = "0x2956450", Length = "0x26B")]
	[Token(Token = "0x60007D2")]
	private KeyControl Initialize_ctrlKeyboardt(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29572C0", Offset = "0x29566C0", Length = "0x265")]
	[Token(Token = "0x60007AF")]
	private KeyControl Initialize_ctrlKeyboardtab(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2957530", Offset = "0x2956930", Length = "0x26B")]
	[Token(Token = "0x60007D3")]
	private KeyControl Initialize_ctrlKeyboardu(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29577A0", Offset = "0x2956BA0", Length = "0x26B")]
	[Token(Token = "0x60007BB")]
	private KeyControl Initialize_ctrlKeyboardupArrow(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2957A10", Offset = "0x2956E10", Length = "0x26B")]
	[Token(Token = "0x60007D4")]
	private KeyControl Initialize_ctrlKeyboardv(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2957C80", Offset = "0x2957080", Length = "0x26B")]
	[Token(Token = "0x60007D5")]
	private KeyControl Initialize_ctrlKeyboardw(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2957EF0", Offset = "0x29572F0", Length = "0x26B")]
	[Token(Token = "0x60007D6")]
	private KeyControl Initialize_ctrlKeyboardx(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x2958160", Offset = "0x2957560", Length = "0x26B")]
	[Token(Token = "0x60007D7")]
	private KeyControl Initialize_ctrlKeyboardy(InternedString kKeyLayout, InputControl parent) { }

	[Address(RVA = "0x29583D0", Offset = "0x29577D0", Length = "0x26B")]
	[Token(Token = "0x60007D8")]
	private KeyControl Initialize_ctrlKeyboardz(InternedString kKeyLayout, InputControl parent) { }

}

