namespace UnityEngine.InputSystem;

[DefaultMember("Item")]
[InputControlLayout(stateType = typeof(KeyboardState), isGenericTypeOfDevice = True)]
[Token(Token = "0x2000090")]
public class Keyboard : InputDevice, ITextInputReceiver, IEventPreProcessor
{
	[Token(Token = "0x40003D2")]
	public const int KeyCount = 110; //Field offset: 0x0
	[Token(Token = "0x40003D3")]
	internal const int ExtendedKeyCount = 126; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x40003D9")]
	private static Keyboard <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40003D4")]
	private AnyKeyControl <anyKey>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40003D5")]
	private ButtonControl <shiftKey>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40003D6")]
	private ButtonControl <ctrlKey>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40003D7")]
	private ButtonControl <altKey>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40003D8")]
	private ButtonControl <imeSelected>k__BackingField; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x40003DA")]
	private InlinedArray<Action`1<Char>> m_TextInputListeners; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x40003DB")]
	private string m_KeyboardLayoutName; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x40003DC")]
	private KeyControl[] m_Keys; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x40003DD")]
	private InlinedArray<Action`1<IMECompositionString>> m_ImeCompositionListeners; //Field offset: 0x1E0

	[Token(Token = "0x1400000F")]
	public event Action<IMECompositionString> onIMECompositionChange
	{
		[Address(RVA = "0x29AD4D0", Offset = "0x29AC8D0", Length = "0xD8")]
		[Token(Token = "0x60006BE")]
		 add { } //Length: 216
		[Address(RVA = "0x29AE010", Offset = "0x29AD410", Length = "0x4C")]
		[Token(Token = "0x60006BF")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x1400000E")]
	public event Action<Char> onTextInput
	{
		[Address(RVA = "0x29AD5B0", Offset = "0x29AC9B0", Length = "0xD8")]
		[Token(Token = "0x60006BC")]
		 add { } //Length: 216
		[Address(RVA = "0x29AE060", Offset = "0x29AD460", Length = "0x4C")]
		[Token(Token = "0x60006BD")]
		 remove { } //Length: 76
	}

	[Token(Token = "0x170001F3")]
	public KeyControl aKey
	{
		[Address(RVA = "0x29AD780", Offset = "0x29ACB80", Length = "0xD")]
		[Token(Token = "0x60006D4")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700026D")]
	public ReadOnlyArray<KeyControl> allKeys
	{
		[Address(RVA = "0x29AD790", Offset = "0x29ACB90", Length = "0x56")]
		[Token(Token = "0x6000752")]
		 get { } //Length: 86
	}

	[Token(Token = "0x1700026A")]
	public ButtonControl altKey
	{
		[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600074D")]
		 get { } //Length: 8
		[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600074E")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001E4")]
	public AnyKeyControl anyKey
	{
		[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60006C4")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60006C5")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001E8")]
	public KeyControl backquoteKey
	{
		[Address(RVA = "0x29AD800", Offset = "0x29ACC00", Length = "0xD")]
		[Token(Token = "0x60006C9")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001EE")]
	public KeyControl backslashKey
	{
		[Address(RVA = "0x29AD810", Offset = "0x29ACC10", Length = "0xD")]
		[Token(Token = "0x60006CF")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700022B")]
	public KeyControl backspaceKey
	{
		[Address(RVA = "0x29AD820", Offset = "0x29ACC20", Length = "0xD")]
		[Token(Token = "0x600070C")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001F4")]
	public KeyControl bKey
	{
		[Address(RVA = "0x29AD7F0", Offset = "0x29ACBF0", Length = "0xD")]
		[Token(Token = "0x60006D5")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000232")]
	public KeyControl capsLockKey
	{
		[Address(RVA = "0x29AD840", Offset = "0x29ACC40", Length = "0xD")]
		[Token(Token = "0x6000713")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001F5")]
	public KeyControl cKey
	{
		[Address(RVA = "0x29AD830", Offset = "0x29ACC30", Length = "0xD")]
		[Token(Token = "0x60006D6")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001EB")]
	public KeyControl commaKey
	{
		[Address(RVA = "0x29AD850", Offset = "0x29ACC50", Length = "0xD")]
		[Token(Token = "0x60006CC")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000225")]
	public KeyControl contextMenuKey
	{
		[Address(RVA = "0x29AD860", Offset = "0x29ACC60", Length = "0xD")]
		[Token(Token = "0x6000706")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000269")]
	public ButtonControl ctrlKey
	{
		[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600074B")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600074C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700026E")]
	public private static Keyboard current
	{
		[Address(RVA = "0x29AD870", Offset = "0x29ACC70", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x6000753")]
		 get { } //Length: 54
		[Address(RVA = "0x29AE0B0", Offset = "0x29AD4B0", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x6000754")]
		private set { } //Length: 81
	}

	[Token(Token = "0x17000231")]
	public KeyControl deleteKey
	{
		[Address(RVA = "0x29AD8C0", Offset = "0x29ACCC0", Length = "0xD")]
		[Token(Token = "0x6000712")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000216")]
	public KeyControl digit0Key
	{
		[Address(RVA = "0x29AD8D0", Offset = "0x29ACCD0", Length = "0xD")]
		[Token(Token = "0x60006F7")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700020D")]
	public KeyControl digit1Key
	{
		[Address(RVA = "0x29AD8E0", Offset = "0x29ACCE0", Length = "0xD")]
		[Token(Token = "0x60006EE")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700020E")]
	public KeyControl digit2Key
	{
		[Address(RVA = "0x29AD8F0", Offset = "0x29ACCF0", Length = "0xD")]
		[Token(Token = "0x60006EF")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700020F")]
	public KeyControl digit3Key
	{
		[Address(RVA = "0x29AD900", Offset = "0x29ACD00", Length = "0xD")]
		[Token(Token = "0x60006F0")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000210")]
	public KeyControl digit4Key
	{
		[Address(RVA = "0x29AD910", Offset = "0x29ACD10", Length = "0xD")]
		[Token(Token = "0x60006F1")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000211")]
	public KeyControl digit5Key
	{
		[Address(RVA = "0x29AD920", Offset = "0x29ACD20", Length = "0xD")]
		[Token(Token = "0x60006F2")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000212")]
	public KeyControl digit6Key
	{
		[Address(RVA = "0x29AD930", Offset = "0x29ACD30", Length = "0xD")]
		[Token(Token = "0x60006F3")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000213")]
	public KeyControl digit7Key
	{
		[Address(RVA = "0x29AD940", Offset = "0x29ACD40", Length = "0xD")]
		[Token(Token = "0x60006F4")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000214")]
	public KeyControl digit8Key
	{
		[Address(RVA = "0x29AD950", Offset = "0x29ACD50", Length = "0xD")]
		[Token(Token = "0x60006F5")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000215")]
	public KeyControl digit9Key
	{
		[Address(RVA = "0x29AD960", Offset = "0x29ACD60", Length = "0xD")]
		[Token(Token = "0x60006F6")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001F6")]
	public KeyControl dKey
	{
		[Address(RVA = "0x29AD8B0", Offset = "0x29ACCB0", Length = "0xD")]
		[Token(Token = "0x60006D7")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700022A")]
	public KeyControl downArrowKey
	{
		[Address(RVA = "0x29AD970", Offset = "0x29ACD70", Length = "0xD")]
		[Token(Token = "0x600070B")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001F7")]
	public KeyControl eKey
	{
		[Address(RVA = "0x29AD980", Offset = "0x29ACD80", Length = "0xD")]
		[Token(Token = "0x60006D8")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700022F")]
	public KeyControl endKey
	{
		[Address(RVA = "0x29AD990", Offset = "0x29ACD90", Length = "0xD")]
		[Token(Token = "0x6000710")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001E6")]
	public KeyControl enterKey
	{
		[Address(RVA = "0x29AD9A0", Offset = "0x29ACDA0", Length = "0xD")]
		[Token(Token = "0x60006C7")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001F2")]
	public KeyControl equalsKey
	{
		[Address(RVA = "0x29AD9B0", Offset = "0x29ACDB0", Length = "0xD")]
		[Token(Token = "0x60006D3")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000226")]
	public KeyControl escapeKey
	{
		[Address(RVA = "0x29AD9C0", Offset = "0x29ACDC0", Length = "0xD")]
		[Token(Token = "0x6000707")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000251")]
	public KeyControl f10Key
	{
		[Address(RVA = "0x29AD9D0", Offset = "0x29ACDD0", Length = "0xD")]
		[Token(Token = "0x6000732")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000252")]
	public KeyControl f11Key
	{
		[Address(RVA = "0x29AD9E0", Offset = "0x29ACDE0", Length = "0xD")]
		[Token(Token = "0x6000733")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000253")]
	public KeyControl f12Key
	{
		[Address(RVA = "0x29AD9F0", Offset = "0x29ACDF0", Length = "0xD")]
		[Token(Token = "0x6000734")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000259")]
	public KeyControl f13Key
	{
		[Address(RVA = "0x29ADA00", Offset = "0x29ACE00", Length = "0xD")]
		[Token(Token = "0x600073A")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700025A")]
	public KeyControl f14Key
	{
		[Address(RVA = "0x29ADA10", Offset = "0x29ACE10", Length = "0xD")]
		[Token(Token = "0x600073B")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700025B")]
	public KeyControl f15Key
	{
		[Address(RVA = "0x29ADA20", Offset = "0x29ACE20", Length = "0xD")]
		[Token(Token = "0x600073C")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700025C")]
	public KeyControl f16Key
	{
		[Address(RVA = "0x29ADA30", Offset = "0x29ACE30", Length = "0xD")]
		[Token(Token = "0x600073D")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700025D")]
	public KeyControl f17Key
	{
		[Address(RVA = "0x29ADA40", Offset = "0x29ACE40", Length = "0xD")]
		[Token(Token = "0x600073E")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700025E")]
	public KeyControl f18Key
	{
		[Address(RVA = "0x29ADA50", Offset = "0x29ACE50", Length = "0xD")]
		[Token(Token = "0x600073F")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700025F")]
	public KeyControl f19Key
	{
		[Address(RVA = "0x29ADA60", Offset = "0x29ACE60", Length = "0xD")]
		[Token(Token = "0x6000740")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000248")]
	public KeyControl f1Key
	{
		[Address(RVA = "0x29ADA70", Offset = "0x29ACE70", Length = "0xD")]
		[Token(Token = "0x6000729")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000260")]
	public KeyControl f20Key
	{
		[Address(RVA = "0x29ADA80", Offset = "0x29ACE80", Length = "0xD")]
		[Token(Token = "0x6000741")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000261")]
	public KeyControl f21Key
	{
		[Address(RVA = "0x29ADA90", Offset = "0x29ACE90", Length = "0xD")]
		[Token(Token = "0x6000742")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000262")]
	public KeyControl f22Key
	{
		[Address(RVA = "0x29ADAA0", Offset = "0x29ACEA0", Length = "0xD")]
		[Token(Token = "0x6000743")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000263")]
	public KeyControl f23Key
	{
		[Address(RVA = "0x29ADAB0", Offset = "0x29ACEB0", Length = "0xD")]
		[Token(Token = "0x6000744")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000264")]
	public KeyControl f24Key
	{
		[Address(RVA = "0x29ADAC0", Offset = "0x29ACEC0", Length = "0xD")]
		[Token(Token = "0x6000745")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000249")]
	public KeyControl f2Key
	{
		[Address(RVA = "0x29ADAD0", Offset = "0x29ACED0", Length = "0xD")]
		[Token(Token = "0x600072A")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700024A")]
	public KeyControl f3Key
	{
		[Address(RVA = "0x29ADAE0", Offset = "0x29ACEE0", Length = "0xD")]
		[Token(Token = "0x600072B")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700024B")]
	public KeyControl f4Key
	{
		[Address(RVA = "0x29ADAF0", Offset = "0x29ACEF0", Length = "0xD")]
		[Token(Token = "0x600072C")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700024C")]
	public KeyControl f5Key
	{
		[Address(RVA = "0x29ADB00", Offset = "0x29ACF00", Length = "0xD")]
		[Token(Token = "0x600072D")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700024D")]
	public KeyControl f6Key
	{
		[Address(RVA = "0x29ADB10", Offset = "0x29ACF10", Length = "0xD")]
		[Token(Token = "0x600072E")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700024E")]
	public KeyControl f7Key
	{
		[Address(RVA = "0x29ADB20", Offset = "0x29ACF20", Length = "0xD")]
		[Token(Token = "0x600072F")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700024F")]
	public KeyControl f8Key
	{
		[Address(RVA = "0x29ADB30", Offset = "0x29ACF30", Length = "0xD")]
		[Token(Token = "0x6000730")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000250")]
	public KeyControl f9Key
	{
		[Address(RVA = "0x29ADB40", Offset = "0x29ACF40", Length = "0xD")]
		[Token(Token = "0x6000731")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001F8")]
	public KeyControl fKey
	{
		[Address(RVA = "0x29ADB50", Offset = "0x29ACF50", Length = "0xD")]
		[Token(Token = "0x60006D9")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001F9")]
	public KeyControl gKey
	{
		[Address(RVA = "0x29ADB60", Offset = "0x29ACF60", Length = "0xD")]
		[Token(Token = "0x60006DA")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001FA")]
	public KeyControl hKey
	{
		[Address(RVA = "0x29ADB70", Offset = "0x29ACF70", Length = "0xD")]
		[Token(Token = "0x60006DB")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700022E")]
	public KeyControl homeKey
	{
		[Address(RVA = "0x29ADB80", Offset = "0x29ACF80", Length = "0xD")]
		[Token(Token = "0x600070F")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001FB")]
	public KeyControl iKey
	{
		[Address(RVA = "0x29ADB90", Offset = "0x29ACF90", Length = "0xD")]
		[Token(Token = "0x60006DC")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700026B")]
	public ButtonControl imeSelected
	{
		[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600074F")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000750")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000230")]
	public KeyControl insertKey
	{
		[Address(RVA = "0x29ADBA0", Offset = "0x29ACFA0", Length = "0xD")]
		[Token(Token = "0x6000711")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700026C")]
	public KeyControl Item
	{
		[Address(RVA = "0x29AD690", Offset = "0x29ACA90", Length = "0xE9")]
		[Token(Token = "0x6000751")]
		 get { } //Length: 233
	}

	[Token(Token = "0x170001FC")]
	public KeyControl jKey
	{
		[Address(RVA = "0x29ADBB0", Offset = "0x29ACFB0", Length = "0xD")]
		[Token(Token = "0x60006DD")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001E3")]
	public string keyboardLayout
	{
		[Address(RVA = "0x29ADBD0", Offset = "0x29ACFD0", Length = "0x1D")]
		[Token(Token = "0x60006C2")]
		 get { } //Length: 29
		[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
		[Token(Token = "0x60006C3")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700026F")]
	protected KeyControl[] keys
	{
		[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
		[Token(Token = "0x600075D")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
		[Token(Token = "0x600075E")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001FD")]
	public KeyControl kKey
	{
		[Address(RVA = "0x29ADBC0", Offset = "0x29ACFC0", Length = "0xD")]
		[Token(Token = "0x60006DE")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000219")]
	public KeyControl leftAltKey
	{
		[Address(RVA = "0x29ADC00", Offset = "0x29AD000", Length = "0xD")]
		[Token(Token = "0x60006FA")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000221")]
	public KeyControl leftAppleKey
	{
		[Address(RVA = "0x29ADC10", Offset = "0x29AD010", Length = "0xD")]
		[Token(Token = "0x6000702")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000227")]
	public KeyControl leftArrowKey
	{
		[Address(RVA = "0x29ADC20", Offset = "0x29AD020", Length = "0xD")]
		[Token(Token = "0x6000708")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001EF")]
	public KeyControl leftBracketKey
	{
		[Address(RVA = "0x29ADC30", Offset = "0x29AD030", Length = "0xD")]
		[Token(Token = "0x60006D0")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000223")]
	public KeyControl leftCommandKey
	{
		[Address(RVA = "0x29ADC10", Offset = "0x29AD010", Length = "0xD")]
		[Token(Token = "0x6000704")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700021B")]
	public KeyControl leftCtrlKey
	{
		[Address(RVA = "0x29ADC40", Offset = "0x29AD040", Length = "0xD")]
		[Token(Token = "0x60006FC")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700021D")]
	public KeyControl leftMetaKey
	{
		[Address(RVA = "0x29ADC10", Offset = "0x29AD010", Length = "0xD")]
		[Token(Token = "0x60006FE")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000217")]
	public KeyControl leftShiftKey
	{
		[Address(RVA = "0x29ADC50", Offset = "0x29AD050", Length = "0xD")]
		[Token(Token = "0x60006F8")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700021F")]
	public KeyControl leftWindowsKey
	{
		[Address(RVA = "0x29ADC10", Offset = "0x29AD010", Length = "0xD")]
		[Token(Token = "0x6000700")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001FE")]
	public KeyControl lKey
	{
		[Address(RVA = "0x29ADBF0", Offset = "0x29ACFF0", Length = "0xD")]
		[Token(Token = "0x60006DF")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000267")]
	public KeyControl mediaForward
	{
		[Address(RVA = "0x29ADC70", Offset = "0x29AD070", Length = "0xD")]
		[Token(Token = "0x6000748")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000265")]
	public KeyControl mediaPlayPause
	{
		[Address(RVA = "0x29ADC80", Offset = "0x29AD080", Length = "0xD")]
		[Token(Token = "0x6000746")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000266")]
	public KeyControl mediaRewind
	{
		[Address(RVA = "0x29ADC90", Offset = "0x29AD090", Length = "0xD")]
		[Token(Token = "0x6000747")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001F1")]
	public KeyControl minusKey
	{
		[Address(RVA = "0x29ADCA0", Offset = "0x29AD0A0", Length = "0xD")]
		[Token(Token = "0x60006D2")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001FF")]
	public KeyControl mKey
	{
		[Address(RVA = "0x29ADC60", Offset = "0x29AD060", Length = "0xD")]
		[Token(Token = "0x60006E0")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000200")]
	public KeyControl nKey
	{
		[Address(RVA = "0x29ADCB0", Offset = "0x29AD0B0", Length = "0xD")]
		[Token(Token = "0x60006E1")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000234")]
	public KeyControl numLockKey
	{
		[Address(RVA = "0x29ADCC0", Offset = "0x29AD0C0", Length = "0xD")]
		[Token(Token = "0x6000715")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700023E")]
	public KeyControl numpad0Key
	{
		[Address(RVA = "0x29ADCD0", Offset = "0x29AD0D0", Length = "0xD")]
		[Token(Token = "0x600071F")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700023F")]
	public KeyControl numpad1Key
	{
		[Address(RVA = "0x29ADCE0", Offset = "0x29AD0E0", Length = "0xD")]
		[Token(Token = "0x6000720")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000240")]
	public KeyControl numpad2Key
	{
		[Address(RVA = "0x29ADCF0", Offset = "0x29AD0F0", Length = "0xD")]
		[Token(Token = "0x6000721")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000241")]
	public KeyControl numpad3Key
	{
		[Address(RVA = "0x29ADD00", Offset = "0x29AD100", Length = "0xD")]
		[Token(Token = "0x6000722")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000242")]
	public KeyControl numpad4Key
	{
		[Address(RVA = "0x29ADD10", Offset = "0x29AD110", Length = "0xD")]
		[Token(Token = "0x6000723")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000243")]
	public KeyControl numpad5Key
	{
		[Address(RVA = "0x29ADD20", Offset = "0x29AD120", Length = "0xD")]
		[Token(Token = "0x6000724")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000244")]
	public KeyControl numpad6Key
	{
		[Address(RVA = "0x29ADD30", Offset = "0x29AD130", Length = "0xD")]
		[Token(Token = "0x6000725")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000245")]
	public KeyControl numpad7Key
	{
		[Address(RVA = "0x29ADD40", Offset = "0x29AD140", Length = "0xD")]
		[Token(Token = "0x6000726")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000246")]
	public KeyControl numpad8Key
	{
		[Address(RVA = "0x29ADD50", Offset = "0x29AD150", Length = "0xD")]
		[Token(Token = "0x6000727")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000247")]
	public KeyControl numpad9Key
	{
		[Address(RVA = "0x29ADD60", Offset = "0x29AD160", Length = "0xD")]
		[Token(Token = "0x6000728")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000238")]
	public KeyControl numpadDivideKey
	{
		[Address(RVA = "0x29ADD70", Offset = "0x29AD170", Length = "0xD")]
		[Token(Token = "0x6000719")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000237")]
	public KeyControl numpadEnterKey
	{
		[Address(RVA = "0x29ADD80", Offset = "0x29AD180", Length = "0xD")]
		[Token(Token = "0x6000718")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700023D")]
	public KeyControl numpadEqualsKey
	{
		[Address(RVA = "0x29ADD90", Offset = "0x29AD190", Length = "0xD")]
		[Token(Token = "0x600071E")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700023A")]
	public KeyControl numpadMinusKey
	{
		[Address(RVA = "0x29ADDA0", Offset = "0x29AD1A0", Length = "0xD")]
		[Token(Token = "0x600071B")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000239")]
	public KeyControl numpadMultiplyKey
	{
		[Address(RVA = "0x29ADDB0", Offset = "0x29AD1B0", Length = "0xD")]
		[Token(Token = "0x600071A")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700023C")]
	public KeyControl numpadPeriodKey
	{
		[Address(RVA = "0x29ADDC0", Offset = "0x29AD1C0", Length = "0xD")]
		[Token(Token = "0x600071D")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700023B")]
	public KeyControl numpadPlusKey
	{
		[Address(RVA = "0x29ADDD0", Offset = "0x29AD1D0", Length = "0xD")]
		[Token(Token = "0x600071C")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000254")]
	public KeyControl oem1Key
	{
		[Address(RVA = "0x29ADDF0", Offset = "0x29AD1F0", Length = "0xD")]
		[Token(Token = "0x6000735")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000255")]
	public KeyControl oem2Key
	{
		[Address(RVA = "0x29ADE00", Offset = "0x29AD200", Length = "0xD")]
		[Token(Token = "0x6000736")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000256")]
	public KeyControl oem3Key
	{
		[Address(RVA = "0x29ADE10", Offset = "0x29AD210", Length = "0xD")]
		[Token(Token = "0x6000737")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000257")]
	public KeyControl oem4Key
	{
		[Address(RVA = "0x29ADE20", Offset = "0x29AD220", Length = "0xD")]
		[Token(Token = "0x6000738")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000258")]
	public KeyControl oem5Key
	{
		[Address(RVA = "0x29ADE30", Offset = "0x29AD230", Length = "0xD")]
		[Token(Token = "0x6000739")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000201")]
	public KeyControl oKey
	{
		[Address(RVA = "0x29ADDE0", Offset = "0x29AD1E0", Length = "0xD")]
		[Token(Token = "0x60006E2")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700022C")]
	public KeyControl pageDownKey
	{
		[Address(RVA = "0x29ADE50", Offset = "0x29AD250", Length = "0xD")]
		[Token(Token = "0x600070D")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700022D")]
	public KeyControl pageUpKey
	{
		[Address(RVA = "0x29ADE60", Offset = "0x29AD260", Length = "0xD")]
		[Token(Token = "0x600070E")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000236")]
	public KeyControl pauseKey
	{
		[Address(RVA = "0x29ADE70", Offset = "0x29AD270", Length = "0xD")]
		[Token(Token = "0x6000717")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001EC")]
	public KeyControl periodKey
	{
		[Address(RVA = "0x29ADE80", Offset = "0x29AD280", Length = "0xD")]
		[Token(Token = "0x60006CD")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000202")]
	public KeyControl pKey
	{
		[Address(RVA = "0x29ADE40", Offset = "0x29AD240", Length = "0xD")]
		[Token(Token = "0x60006E3")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000235")]
	public KeyControl printScreenKey
	{
		[Address(RVA = "0x29ADE90", Offset = "0x29AD290", Length = "0xD")]
		[Token(Token = "0x6000716")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000203")]
	public KeyControl qKey
	{
		[Address(RVA = "0x29ADEA0", Offset = "0x29AD2A0", Length = "0xD")]
		[Token(Token = "0x60006E4")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001E9")]
	public KeyControl quoteKey
	{
		[Address(RVA = "0x29ADEB0", Offset = "0x29AD2B0", Length = "0xD")]
		[Token(Token = "0x60006CA")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700021A")]
	public KeyControl rightAltKey
	{
		[Address(RVA = "0x29ADED0", Offset = "0x29AD2D0", Length = "0xD")]
		[Token(Token = "0x60006FB")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000222")]
	public KeyControl rightAppleKey
	{
		[Address(RVA = "0x29ADEE0", Offset = "0x29AD2E0", Length = "0xD")]
		[Token(Token = "0x6000703")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000228")]
	public KeyControl rightArrowKey
	{
		[Address(RVA = "0x29ADEF0", Offset = "0x29AD2F0", Length = "0xD")]
		[Token(Token = "0x6000709")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001F0")]
	public KeyControl rightBracketKey
	{
		[Address(RVA = "0x29ADF00", Offset = "0x29AD300", Length = "0xD")]
		[Token(Token = "0x60006D1")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000224")]
	public KeyControl rightCommandKey
	{
		[Address(RVA = "0x29ADEE0", Offset = "0x29AD2E0", Length = "0xD")]
		[Token(Token = "0x6000705")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700021C")]
	public KeyControl rightCtrlKey
	{
		[Address(RVA = "0x29ADF10", Offset = "0x29AD310", Length = "0xD")]
		[Token(Token = "0x60006FD")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700021E")]
	public KeyControl rightMetaKey
	{
		[Address(RVA = "0x29ADEE0", Offset = "0x29AD2E0", Length = "0xD")]
		[Token(Token = "0x60006FF")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000218")]
	public KeyControl rightShiftKey
	{
		[Address(RVA = "0x29ADF20", Offset = "0x29AD320", Length = "0xD")]
		[Token(Token = "0x60006F9")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000220")]
	public KeyControl rightWindowsKey
	{
		[Address(RVA = "0x29ADEE0", Offset = "0x29AD2E0", Length = "0xD")]
		[Token(Token = "0x6000701")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000204")]
	public KeyControl rKey
	{
		[Address(RVA = "0x29ADEC0", Offset = "0x29AD2C0", Length = "0xD")]
		[Token(Token = "0x60006E5")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000233")]
	public KeyControl scrollLockKey
	{
		[Address(RVA = "0x29ADF40", Offset = "0x29AD340", Length = "0xD")]
		[Token(Token = "0x6000714")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001EA")]
	public KeyControl semicolonKey
	{
		[Address(RVA = "0x29ADF50", Offset = "0x29AD350", Length = "0xD")]
		[Token(Token = "0x60006CB")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000268")]
	public ButtonControl shiftKey
	{
		[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000749")]
		 get { } //Length: 8
		[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600074A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000205")]
	public KeyControl sKey
	{
		[Address(RVA = "0x29ADF30", Offset = "0x29AD330", Length = "0xD")]
		[Token(Token = "0x60006E6")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001ED")]
	public KeyControl slashKey
	{
		[Address(RVA = "0x29ADF60", Offset = "0x29AD360", Length = "0xD")]
		[Token(Token = "0x60006CE")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001E5")]
	public KeyControl spaceKey
	{
		[Address(RVA = "0x29ADF70", Offset = "0x29AD370", Length = "0xD")]
		[Token(Token = "0x60006C6")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170001E7")]
	public KeyControl tabKey
	{
		[Address(RVA = "0x29ADF90", Offset = "0x29AD390", Length = "0xD")]
		[Token(Token = "0x60006C8")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000206")]
	public KeyControl tKey
	{
		[Address(RVA = "0x29ADF80", Offset = "0x29AD380", Length = "0xD")]
		[Token(Token = "0x60006E7")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000207")]
	public KeyControl uKey
	{
		[Address(RVA = "0x29ADFA0", Offset = "0x29AD3A0", Length = "0xD")]
		[Token(Token = "0x60006E8")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000229")]
	public KeyControl upArrowKey
	{
		[Address(RVA = "0x29ADFB0", Offset = "0x29AD3B0", Length = "0xD")]
		[Token(Token = "0x600070A")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000208")]
	public KeyControl vKey
	{
		[Address(RVA = "0x29ADFC0", Offset = "0x29AD3C0", Length = "0xD")]
		[Token(Token = "0x60006E9")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000209")]
	public KeyControl wKey
	{
		[Address(RVA = "0x29ADFD0", Offset = "0x29AD3D0", Length = "0xD")]
		[Token(Token = "0x60006EA")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700020A")]
	public KeyControl xKey
	{
		[Address(RVA = "0x29ADFE0", Offset = "0x29AD3E0", Length = "0xD")]
		[Token(Token = "0x60006EB")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700020B")]
	public KeyControl yKey
	{
		[Address(RVA = "0x29ADFF0", Offset = "0x29AD3F0", Length = "0xD")]
		[Token(Token = "0x60006EC")]
		 get { } //Length: 13
	}

	[Token(Token = "0x1700020C")]
	public KeyControl zKey
	{
		[Address(RVA = "0x29AE000", Offset = "0x29AD400", Length = "0xD")]
		[Token(Token = "0x60006ED")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x600075F")]
	public Keyboard() { }

	[Address(RVA = "0x29AD4D0", Offset = "0x29AC8D0", Length = "0xD8")]
	[Token(Token = "0x60006BE")]
	public void add_onIMECompositionChange(Action<IMECompositionString> value) { }

	[Address(RVA = "0x29AD5B0", Offset = "0x29AC9B0", Length = "0xD8")]
	[Token(Token = "0x60006BC")]
	public void add_onTextInput(Action<Char> value) { }

	[Address(RVA = "0x29AB450", Offset = "0x29AA850", Length = "0x112")]
	[Token(Token = "0x600075A")]
	public KeyControl FindKeyOnCurrentKeyboardLayout(string displayName) { }

	[Address(RVA = "0x29AB570", Offset = "0x29AA970", Length = "0x1A27")]
	[Token(Token = "0x6000757")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29AD780", Offset = "0x29ACB80", Length = "0xD")]
	[Token(Token = "0x60006D4")]
	public KeyControl get_aKey() { }

	[Address(RVA = "0x29AD790", Offset = "0x29ACB90", Length = "0x56")]
	[Token(Token = "0x6000752")]
	public ReadOnlyArray<KeyControl> get_allKeys() { }

	[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600074D")]
	public ButtonControl get_altKey() { }

	[Address(RVA = "0x28EAAE0", Offset = "0x28E9EE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60006C4")]
	public AnyKeyControl get_anyKey() { }

	[Address(RVA = "0x29AD800", Offset = "0x29ACC00", Length = "0xD")]
	[Token(Token = "0x60006C9")]
	public KeyControl get_backquoteKey() { }

	[Address(RVA = "0x29AD810", Offset = "0x29ACC10", Length = "0xD")]
	[Token(Token = "0x60006CF")]
	public KeyControl get_backslashKey() { }

	[Address(RVA = "0x29AD820", Offset = "0x29ACC20", Length = "0xD")]
	[Token(Token = "0x600070C")]
	public KeyControl get_backspaceKey() { }

	[Address(RVA = "0x29AD7F0", Offset = "0x29ACBF0", Length = "0xD")]
	[Token(Token = "0x60006D5")]
	public KeyControl get_bKey() { }

	[Address(RVA = "0x29AD840", Offset = "0x29ACC40", Length = "0xD")]
	[Token(Token = "0x6000713")]
	public KeyControl get_capsLockKey() { }

	[Address(RVA = "0x29AD830", Offset = "0x29ACC30", Length = "0xD")]
	[Token(Token = "0x60006D6")]
	public KeyControl get_cKey() { }

	[Address(RVA = "0x29AD850", Offset = "0x29ACC50", Length = "0xD")]
	[Token(Token = "0x60006CC")]
	public KeyControl get_commaKey() { }

	[Address(RVA = "0x29AD860", Offset = "0x29ACC60", Length = "0xD")]
	[Token(Token = "0x6000706")]
	public KeyControl get_contextMenuKey() { }

	[Address(RVA = "0x28EAB00", Offset = "0x28E9F00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600074B")]
	public ButtonControl get_ctrlKey() { }

	[Address(RVA = "0x29AD870", Offset = "0x29ACC70", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6000753")]
	public static Keyboard get_current() { }

	[Address(RVA = "0x29AD8C0", Offset = "0x29ACCC0", Length = "0xD")]
	[Token(Token = "0x6000712")]
	public KeyControl get_deleteKey() { }

	[Address(RVA = "0x29AD8D0", Offset = "0x29ACCD0", Length = "0xD")]
	[Token(Token = "0x60006F7")]
	public KeyControl get_digit0Key() { }

	[Address(RVA = "0x29AD8E0", Offset = "0x29ACCE0", Length = "0xD")]
	[Token(Token = "0x60006EE")]
	public KeyControl get_digit1Key() { }

	[Address(RVA = "0x29AD8F0", Offset = "0x29ACCF0", Length = "0xD")]
	[Token(Token = "0x60006EF")]
	public KeyControl get_digit2Key() { }

	[Address(RVA = "0x29AD900", Offset = "0x29ACD00", Length = "0xD")]
	[Token(Token = "0x60006F0")]
	public KeyControl get_digit3Key() { }

	[Address(RVA = "0x29AD910", Offset = "0x29ACD10", Length = "0xD")]
	[Token(Token = "0x60006F1")]
	public KeyControl get_digit4Key() { }

	[Address(RVA = "0x29AD920", Offset = "0x29ACD20", Length = "0xD")]
	[Token(Token = "0x60006F2")]
	public KeyControl get_digit5Key() { }

	[Address(RVA = "0x29AD930", Offset = "0x29ACD30", Length = "0xD")]
	[Token(Token = "0x60006F3")]
	public KeyControl get_digit6Key() { }

	[Address(RVA = "0x29AD940", Offset = "0x29ACD40", Length = "0xD")]
	[Token(Token = "0x60006F4")]
	public KeyControl get_digit7Key() { }

	[Address(RVA = "0x29AD950", Offset = "0x29ACD50", Length = "0xD")]
	[Token(Token = "0x60006F5")]
	public KeyControl get_digit8Key() { }

	[Address(RVA = "0x29AD960", Offset = "0x29ACD60", Length = "0xD")]
	[Token(Token = "0x60006F6")]
	public KeyControl get_digit9Key() { }

	[Address(RVA = "0x29AD8B0", Offset = "0x29ACCB0", Length = "0xD")]
	[Token(Token = "0x60006D7")]
	public KeyControl get_dKey() { }

	[Address(RVA = "0x29AD970", Offset = "0x29ACD70", Length = "0xD")]
	[Token(Token = "0x600070B")]
	public KeyControl get_downArrowKey() { }

	[Address(RVA = "0x29AD980", Offset = "0x29ACD80", Length = "0xD")]
	[Token(Token = "0x60006D8")]
	public KeyControl get_eKey() { }

	[Address(RVA = "0x29AD990", Offset = "0x29ACD90", Length = "0xD")]
	[Token(Token = "0x6000710")]
	public KeyControl get_endKey() { }

	[Address(RVA = "0x29AD9A0", Offset = "0x29ACDA0", Length = "0xD")]
	[Token(Token = "0x60006C7")]
	public KeyControl get_enterKey() { }

	[Address(RVA = "0x29AD9B0", Offset = "0x29ACDB0", Length = "0xD")]
	[Token(Token = "0x60006D3")]
	public KeyControl get_equalsKey() { }

	[Address(RVA = "0x29AD9C0", Offset = "0x29ACDC0", Length = "0xD")]
	[Token(Token = "0x6000707")]
	public KeyControl get_escapeKey() { }

	[Address(RVA = "0x29AD9D0", Offset = "0x29ACDD0", Length = "0xD")]
	[Token(Token = "0x6000732")]
	public KeyControl get_f10Key() { }

	[Address(RVA = "0x29AD9E0", Offset = "0x29ACDE0", Length = "0xD")]
	[Token(Token = "0x6000733")]
	public KeyControl get_f11Key() { }

	[Address(RVA = "0x29AD9F0", Offset = "0x29ACDF0", Length = "0xD")]
	[Token(Token = "0x6000734")]
	public KeyControl get_f12Key() { }

	[Address(RVA = "0x29ADA00", Offset = "0x29ACE00", Length = "0xD")]
	[Token(Token = "0x600073A")]
	public KeyControl get_f13Key() { }

	[Address(RVA = "0x29ADA10", Offset = "0x29ACE10", Length = "0xD")]
	[Token(Token = "0x600073B")]
	public KeyControl get_f14Key() { }

	[Address(RVA = "0x29ADA20", Offset = "0x29ACE20", Length = "0xD")]
	[Token(Token = "0x600073C")]
	public KeyControl get_f15Key() { }

	[Address(RVA = "0x29ADA30", Offset = "0x29ACE30", Length = "0xD")]
	[Token(Token = "0x600073D")]
	public KeyControl get_f16Key() { }

	[Address(RVA = "0x29ADA40", Offset = "0x29ACE40", Length = "0xD")]
	[Token(Token = "0x600073E")]
	public KeyControl get_f17Key() { }

	[Address(RVA = "0x29ADA50", Offset = "0x29ACE50", Length = "0xD")]
	[Token(Token = "0x600073F")]
	public KeyControl get_f18Key() { }

	[Address(RVA = "0x29ADA60", Offset = "0x29ACE60", Length = "0xD")]
	[Token(Token = "0x6000740")]
	public KeyControl get_f19Key() { }

	[Address(RVA = "0x29ADA70", Offset = "0x29ACE70", Length = "0xD")]
	[Token(Token = "0x6000729")]
	public KeyControl get_f1Key() { }

	[Address(RVA = "0x29ADA80", Offset = "0x29ACE80", Length = "0xD")]
	[Token(Token = "0x6000741")]
	public KeyControl get_f20Key() { }

	[Address(RVA = "0x29ADA90", Offset = "0x29ACE90", Length = "0xD")]
	[Token(Token = "0x6000742")]
	public KeyControl get_f21Key() { }

	[Address(RVA = "0x29ADAA0", Offset = "0x29ACEA0", Length = "0xD")]
	[Token(Token = "0x6000743")]
	public KeyControl get_f22Key() { }

	[Address(RVA = "0x29ADAB0", Offset = "0x29ACEB0", Length = "0xD")]
	[Token(Token = "0x6000744")]
	public KeyControl get_f23Key() { }

	[Address(RVA = "0x29ADAC0", Offset = "0x29ACEC0", Length = "0xD")]
	[Token(Token = "0x6000745")]
	public KeyControl get_f24Key() { }

	[Address(RVA = "0x29ADAD0", Offset = "0x29ACED0", Length = "0xD")]
	[Token(Token = "0x600072A")]
	public KeyControl get_f2Key() { }

	[Address(RVA = "0x29ADAE0", Offset = "0x29ACEE0", Length = "0xD")]
	[Token(Token = "0x600072B")]
	public KeyControl get_f3Key() { }

	[Address(RVA = "0x29ADAF0", Offset = "0x29ACEF0", Length = "0xD")]
	[Token(Token = "0x600072C")]
	public KeyControl get_f4Key() { }

	[Address(RVA = "0x29ADB00", Offset = "0x29ACF00", Length = "0xD")]
	[Token(Token = "0x600072D")]
	public KeyControl get_f5Key() { }

	[Address(RVA = "0x29ADB10", Offset = "0x29ACF10", Length = "0xD")]
	[Token(Token = "0x600072E")]
	public KeyControl get_f6Key() { }

	[Address(RVA = "0x29ADB20", Offset = "0x29ACF20", Length = "0xD")]
	[Token(Token = "0x600072F")]
	public KeyControl get_f7Key() { }

	[Address(RVA = "0x29ADB30", Offset = "0x29ACF30", Length = "0xD")]
	[Token(Token = "0x6000730")]
	public KeyControl get_f8Key() { }

	[Address(RVA = "0x29ADB40", Offset = "0x29ACF40", Length = "0xD")]
	[Token(Token = "0x6000731")]
	public KeyControl get_f9Key() { }

	[Address(RVA = "0x29ADB50", Offset = "0x29ACF50", Length = "0xD")]
	[Token(Token = "0x60006D9")]
	public KeyControl get_fKey() { }

	[Address(RVA = "0x29ADB60", Offset = "0x29ACF60", Length = "0xD")]
	[Token(Token = "0x60006DA")]
	public KeyControl get_gKey() { }

	[Address(RVA = "0x29ADB70", Offset = "0x29ACF70", Length = "0xD")]
	[Token(Token = "0x60006DB")]
	public KeyControl get_hKey() { }

	[Address(RVA = "0x29ADB80", Offset = "0x29ACF80", Length = "0xD")]
	[Token(Token = "0x600070F")]
	public KeyControl get_homeKey() { }

	[Address(RVA = "0x29ADB90", Offset = "0x29ACF90", Length = "0xD")]
	[Token(Token = "0x60006DC")]
	public KeyControl get_iKey() { }

	[Address(RVA = "0x28D9950", Offset = "0x28D8D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600074F")]
	public ButtonControl get_imeSelected() { }

	[Address(RVA = "0x29ADBA0", Offset = "0x29ACFA0", Length = "0xD")]
	[Token(Token = "0x6000711")]
	public KeyControl get_insertKey() { }

	[Address(RVA = "0x29AD690", Offset = "0x29ACA90", Length = "0xE9")]
	[Token(Token = "0x6000751")]
	public KeyControl get_Item(Key key) { }

	[Address(RVA = "0x29ADBB0", Offset = "0x29ACFB0", Length = "0xD")]
	[Token(Token = "0x60006DD")]
	public KeyControl get_jKey() { }

	[Address(RVA = "0x29ADBD0", Offset = "0x29ACFD0", Length = "0x1D")]
	[Token(Token = "0x60006C2")]
	public string get_keyboardLayout() { }

	[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
	[Token(Token = "0x600075D")]
	protected KeyControl[] get_keys() { }

	[Address(RVA = "0x29ADBC0", Offset = "0x29ACFC0", Length = "0xD")]
	[Token(Token = "0x60006DE")]
	public KeyControl get_kKey() { }

	[Address(RVA = "0x29ADC00", Offset = "0x29AD000", Length = "0xD")]
	[Token(Token = "0x60006FA")]
	public KeyControl get_leftAltKey() { }

	[Address(RVA = "0x29ADC10", Offset = "0x29AD010", Length = "0xD")]
	[Token(Token = "0x6000702")]
	public KeyControl get_leftAppleKey() { }

	[Address(RVA = "0x29ADC20", Offset = "0x29AD020", Length = "0xD")]
	[Token(Token = "0x6000708")]
	public KeyControl get_leftArrowKey() { }

	[Address(RVA = "0x29ADC30", Offset = "0x29AD030", Length = "0xD")]
	[Token(Token = "0x60006D0")]
	public KeyControl get_leftBracketKey() { }

	[Address(RVA = "0x29ADC10", Offset = "0x29AD010", Length = "0xD")]
	[Token(Token = "0x6000704")]
	public KeyControl get_leftCommandKey() { }

	[Address(RVA = "0x29ADC40", Offset = "0x29AD040", Length = "0xD")]
	[Token(Token = "0x60006FC")]
	public KeyControl get_leftCtrlKey() { }

	[Address(RVA = "0x29ADC10", Offset = "0x29AD010", Length = "0xD")]
	[Token(Token = "0x60006FE")]
	public KeyControl get_leftMetaKey() { }

	[Address(RVA = "0x29ADC50", Offset = "0x29AD050", Length = "0xD")]
	[Token(Token = "0x60006F8")]
	public KeyControl get_leftShiftKey() { }

	[Address(RVA = "0x29ADC10", Offset = "0x29AD010", Length = "0xD")]
	[Token(Token = "0x6000700")]
	public KeyControl get_leftWindowsKey() { }

	[Address(RVA = "0x29ADBF0", Offset = "0x29ACFF0", Length = "0xD")]
	[Token(Token = "0x60006DF")]
	public KeyControl get_lKey() { }

	[Address(RVA = "0x29ADC70", Offset = "0x29AD070", Length = "0xD")]
	[Token(Token = "0x6000748")]
	public KeyControl get_mediaForward() { }

	[Address(RVA = "0x29ADC80", Offset = "0x29AD080", Length = "0xD")]
	[Token(Token = "0x6000746")]
	public KeyControl get_mediaPlayPause() { }

	[Address(RVA = "0x29ADC90", Offset = "0x29AD090", Length = "0xD")]
	[Token(Token = "0x6000747")]
	public KeyControl get_mediaRewind() { }

	[Address(RVA = "0x29ADCA0", Offset = "0x29AD0A0", Length = "0xD")]
	[Token(Token = "0x60006D2")]
	public KeyControl get_minusKey() { }

	[Address(RVA = "0x29ADC60", Offset = "0x29AD060", Length = "0xD")]
	[Token(Token = "0x60006E0")]
	public KeyControl get_mKey() { }

	[Address(RVA = "0x29ADCB0", Offset = "0x29AD0B0", Length = "0xD")]
	[Token(Token = "0x60006E1")]
	public KeyControl get_nKey() { }

	[Address(RVA = "0x29ADCC0", Offset = "0x29AD0C0", Length = "0xD")]
	[Token(Token = "0x6000715")]
	public KeyControl get_numLockKey() { }

	[Address(RVA = "0x29ADCD0", Offset = "0x29AD0D0", Length = "0xD")]
	[Token(Token = "0x600071F")]
	public KeyControl get_numpad0Key() { }

	[Address(RVA = "0x29ADCE0", Offset = "0x29AD0E0", Length = "0xD")]
	[Token(Token = "0x6000720")]
	public KeyControl get_numpad1Key() { }

	[Address(RVA = "0x29ADCF0", Offset = "0x29AD0F0", Length = "0xD")]
	[Token(Token = "0x6000721")]
	public KeyControl get_numpad2Key() { }

	[Address(RVA = "0x29ADD00", Offset = "0x29AD100", Length = "0xD")]
	[Token(Token = "0x6000722")]
	public KeyControl get_numpad3Key() { }

	[Address(RVA = "0x29ADD10", Offset = "0x29AD110", Length = "0xD")]
	[Token(Token = "0x6000723")]
	public KeyControl get_numpad4Key() { }

	[Address(RVA = "0x29ADD20", Offset = "0x29AD120", Length = "0xD")]
	[Token(Token = "0x6000724")]
	public KeyControl get_numpad5Key() { }

	[Address(RVA = "0x29ADD30", Offset = "0x29AD130", Length = "0xD")]
	[Token(Token = "0x6000725")]
	public KeyControl get_numpad6Key() { }

	[Address(RVA = "0x29ADD40", Offset = "0x29AD140", Length = "0xD")]
	[Token(Token = "0x6000726")]
	public KeyControl get_numpad7Key() { }

	[Address(RVA = "0x29ADD50", Offset = "0x29AD150", Length = "0xD")]
	[Token(Token = "0x6000727")]
	public KeyControl get_numpad8Key() { }

	[Address(RVA = "0x29ADD60", Offset = "0x29AD160", Length = "0xD")]
	[Token(Token = "0x6000728")]
	public KeyControl get_numpad9Key() { }

	[Address(RVA = "0x29ADD70", Offset = "0x29AD170", Length = "0xD")]
	[Token(Token = "0x6000719")]
	public KeyControl get_numpadDivideKey() { }

	[Address(RVA = "0x29ADD80", Offset = "0x29AD180", Length = "0xD")]
	[Token(Token = "0x6000718")]
	public KeyControl get_numpadEnterKey() { }

	[Address(RVA = "0x29ADD90", Offset = "0x29AD190", Length = "0xD")]
	[Token(Token = "0x600071E")]
	public KeyControl get_numpadEqualsKey() { }

	[Address(RVA = "0x29ADDA0", Offset = "0x29AD1A0", Length = "0xD")]
	[Token(Token = "0x600071B")]
	public KeyControl get_numpadMinusKey() { }

	[Address(RVA = "0x29ADDB0", Offset = "0x29AD1B0", Length = "0xD")]
	[Token(Token = "0x600071A")]
	public KeyControl get_numpadMultiplyKey() { }

	[Address(RVA = "0x29ADDC0", Offset = "0x29AD1C0", Length = "0xD")]
	[Token(Token = "0x600071D")]
	public KeyControl get_numpadPeriodKey() { }

	[Address(RVA = "0x29ADDD0", Offset = "0x29AD1D0", Length = "0xD")]
	[Token(Token = "0x600071C")]
	public KeyControl get_numpadPlusKey() { }

	[Address(RVA = "0x29ADDF0", Offset = "0x29AD1F0", Length = "0xD")]
	[Token(Token = "0x6000735")]
	public KeyControl get_oem1Key() { }

	[Address(RVA = "0x29ADE00", Offset = "0x29AD200", Length = "0xD")]
	[Token(Token = "0x6000736")]
	public KeyControl get_oem2Key() { }

	[Address(RVA = "0x29ADE10", Offset = "0x29AD210", Length = "0xD")]
	[Token(Token = "0x6000737")]
	public KeyControl get_oem3Key() { }

	[Address(RVA = "0x29ADE20", Offset = "0x29AD220", Length = "0xD")]
	[Token(Token = "0x6000738")]
	public KeyControl get_oem4Key() { }

	[Address(RVA = "0x29ADE30", Offset = "0x29AD230", Length = "0xD")]
	[Token(Token = "0x6000739")]
	public KeyControl get_oem5Key() { }

	[Address(RVA = "0x29ADDE0", Offset = "0x29AD1E0", Length = "0xD")]
	[Token(Token = "0x60006E2")]
	public KeyControl get_oKey() { }

	[Address(RVA = "0x29ADE50", Offset = "0x29AD250", Length = "0xD")]
	[Token(Token = "0x600070D")]
	public KeyControl get_pageDownKey() { }

	[Address(RVA = "0x29ADE60", Offset = "0x29AD260", Length = "0xD")]
	[Token(Token = "0x600070E")]
	public KeyControl get_pageUpKey() { }

	[Address(RVA = "0x29ADE70", Offset = "0x29AD270", Length = "0xD")]
	[Token(Token = "0x6000717")]
	public KeyControl get_pauseKey() { }

	[Address(RVA = "0x29ADE80", Offset = "0x29AD280", Length = "0xD")]
	[Token(Token = "0x60006CD")]
	public KeyControl get_periodKey() { }

	[Address(RVA = "0x29ADE40", Offset = "0x29AD240", Length = "0xD")]
	[Token(Token = "0x60006E3")]
	public KeyControl get_pKey() { }

	[Address(RVA = "0x29ADE90", Offset = "0x29AD290", Length = "0xD")]
	[Token(Token = "0x6000716")]
	public KeyControl get_printScreenKey() { }

	[Address(RVA = "0x29ADEA0", Offset = "0x29AD2A0", Length = "0xD")]
	[Token(Token = "0x60006E4")]
	public KeyControl get_qKey() { }

	[Address(RVA = "0x29ADEB0", Offset = "0x29AD2B0", Length = "0xD")]
	[Token(Token = "0x60006CA")]
	public KeyControl get_quoteKey() { }

	[Address(RVA = "0x29ADED0", Offset = "0x29AD2D0", Length = "0xD")]
	[Token(Token = "0x60006FB")]
	public KeyControl get_rightAltKey() { }

	[Address(RVA = "0x29ADEE0", Offset = "0x29AD2E0", Length = "0xD")]
	[Token(Token = "0x6000703")]
	public KeyControl get_rightAppleKey() { }

	[Address(RVA = "0x29ADEF0", Offset = "0x29AD2F0", Length = "0xD")]
	[Token(Token = "0x6000709")]
	public KeyControl get_rightArrowKey() { }

	[Address(RVA = "0x29ADF00", Offset = "0x29AD300", Length = "0xD")]
	[Token(Token = "0x60006D1")]
	public KeyControl get_rightBracketKey() { }

	[Address(RVA = "0x29ADEE0", Offset = "0x29AD2E0", Length = "0xD")]
	[Token(Token = "0x6000705")]
	public KeyControl get_rightCommandKey() { }

	[Address(RVA = "0x29ADF10", Offset = "0x29AD310", Length = "0xD")]
	[Token(Token = "0x60006FD")]
	public KeyControl get_rightCtrlKey() { }

	[Address(RVA = "0x29ADEE0", Offset = "0x29AD2E0", Length = "0xD")]
	[Token(Token = "0x60006FF")]
	public KeyControl get_rightMetaKey() { }

	[Address(RVA = "0x29ADF20", Offset = "0x29AD320", Length = "0xD")]
	[Token(Token = "0x60006F9")]
	public KeyControl get_rightShiftKey() { }

	[Address(RVA = "0x29ADEE0", Offset = "0x29AD2E0", Length = "0xD")]
	[Token(Token = "0x6000701")]
	public KeyControl get_rightWindowsKey() { }

	[Address(RVA = "0x29ADEC0", Offset = "0x29AD2C0", Length = "0xD")]
	[Token(Token = "0x60006E5")]
	public KeyControl get_rKey() { }

	[Address(RVA = "0x29ADF40", Offset = "0x29AD340", Length = "0xD")]
	[Token(Token = "0x6000714")]
	public KeyControl get_scrollLockKey() { }

	[Address(RVA = "0x29ADF50", Offset = "0x29AD350", Length = "0xD")]
	[Token(Token = "0x60006CB")]
	public KeyControl get_semicolonKey() { }

	[Address(RVA = "0x28EAAF0", Offset = "0x28E9EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000749")]
	public ButtonControl get_shiftKey() { }

	[Address(RVA = "0x29ADF30", Offset = "0x29AD330", Length = "0xD")]
	[Token(Token = "0x60006E6")]
	public KeyControl get_sKey() { }

	[Address(RVA = "0x29ADF60", Offset = "0x29AD360", Length = "0xD")]
	[Token(Token = "0x60006CE")]
	public KeyControl get_slashKey() { }

	[Address(RVA = "0x29ADF70", Offset = "0x29AD370", Length = "0xD")]
	[Token(Token = "0x60006C6")]
	public KeyControl get_spaceKey() { }

	[Address(RVA = "0x29ADF90", Offset = "0x29AD390", Length = "0xD")]
	[Token(Token = "0x60006C8")]
	public KeyControl get_tabKey() { }

	[Address(RVA = "0x29ADF80", Offset = "0x29AD380", Length = "0xD")]
	[Token(Token = "0x60006E7")]
	public KeyControl get_tKey() { }

	[Address(RVA = "0x29ADFA0", Offset = "0x29AD3A0", Length = "0xD")]
	[Token(Token = "0x60006E8")]
	public KeyControl get_uKey() { }

	[Address(RVA = "0x29ADFB0", Offset = "0x29AD3B0", Length = "0xD")]
	[Token(Token = "0x600070A")]
	public KeyControl get_upArrowKey() { }

	[Address(RVA = "0x29ADFC0", Offset = "0x29AD3C0", Length = "0xD")]
	[Token(Token = "0x60006E9")]
	public KeyControl get_vKey() { }

	[Address(RVA = "0x29ADFD0", Offset = "0x29AD3D0", Length = "0xD")]
	[Token(Token = "0x60006EA")]
	public KeyControl get_wKey() { }

	[Address(RVA = "0x29ADFE0", Offset = "0x29AD3E0", Length = "0xD")]
	[Token(Token = "0x60006EB")]
	public KeyControl get_xKey() { }

	[Address(RVA = "0x29ADFF0", Offset = "0x29AD3F0", Length = "0xD")]
	[Token(Token = "0x60006EC")]
	public KeyControl get_yKey() { }

	[Address(RVA = "0x29AE000", Offset = "0x29AD400", Length = "0xD")]
	[Token(Token = "0x60006ED")]
	public KeyControl get_zKey() { }

	[Address(RVA = "0x29ACFA0", Offset = "0x29AC3A0", Length = "0x58")]
	[Token(Token = "0x6000755")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x29AD000", Offset = "0x29AC400", Length = "0x10A")]
	[Token(Token = "0x600075B")]
	public override void OnIMECompositionChanged(IMECompositionString compositionString) { }

	[Address(RVA = "0x29AD110", Offset = "0x29AC510", Length = "0x90")]
	[Token(Token = "0x6000756")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x29AD1A0", Offset = "0x29AC5A0", Length = "0x8B")]
	[Token(Token = "0x6000759")]
	public override void OnTextInput(char character) { }

	[Address(RVA = "0x29AD230", Offset = "0x29AC630", Length = "0x10D")]
	[Token(Token = "0x6000758")]
	protected virtual void RefreshConfiguration() { }

	[Address(RVA = "0x29AE010", Offset = "0x29AD410", Length = "0x4C")]
	[Token(Token = "0x60006BF")]
	public void remove_onIMECompositionChange(Action<IMECompositionString> value) { }

	[Address(RVA = "0x29AE060", Offset = "0x29AD460", Length = "0x4C")]
	[Token(Token = "0x60006BD")]
	public void remove_onTextInput(Action<Char> value) { }

	[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600074E")]
	protected void set_altKey(ButtonControl value) { }

	[Address(RVA = "0x28EAB10", Offset = "0x28E9F10", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60006C5")]
	protected void set_anyKey(AnyKeyControl value) { }

	[Address(RVA = "0x1CEB140", Offset = "0x1CEA540", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600074C")]
	protected void set_ctrlKey(ButtonControl value) { }

	[Address(RVA = "0x29AE0B0", Offset = "0x29AD4B0", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x6000754")]
	private static void set_current(Keyboard value) { }

	[Address(RVA = "0x28D99C0", Offset = "0x28D8DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000750")]
	protected void set_imeSelected(ButtonControl value) { }

	[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
	[Token(Token = "0x60006C3")]
	protected void set_keyboardLayout(string value) { }

	[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
	[Token(Token = "0x600075E")]
	protected void set_keys(KeyControl[] value) { }

	[Address(RVA = "0x28EAB30", Offset = "0x28E9F30", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600074A")]
	protected void set_shiftKey(ButtonControl value) { }

	[Address(RVA = "0x29AD340", Offset = "0x29AC740", Length = "0x70")]
	[Token(Token = "0x60006C1")]
	public void SetIMECursorPosition(Vector2 position) { }

	[Address(RVA = "0x29AD3B0", Offset = "0x29AC7B0", Length = "0x78")]
	[Token(Token = "0x60006C0")]
	public void SetIMEEnabled(bool enabled) { }

	[Address(RVA = "0x29AD430", Offset = "0x29AC830", Length = "0x94")]
	[Token(Token = "0x600075C")]
	private override bool UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(InputEventPtr currentEventPtr) { }

}

