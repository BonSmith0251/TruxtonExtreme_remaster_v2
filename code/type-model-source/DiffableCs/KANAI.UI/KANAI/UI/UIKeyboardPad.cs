namespace KANAI.UI;

[Token(Token = "0x2000029")]
public class UIKeyboardPad
{
	[Token(Token = "0x200002A")]
	private struct KeyboardButton
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000140")]
		private UIKeyboard <_code>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000141")]
		private bool <_isOn>k__BackingField; //Field offset: 0x4
		[FieldOffset(Offset = "0x5")]
		[Token(Token = "0x4000142")]
		private bool _isPreOn; //Field offset: 0x5

		[Token(Token = "0x17000024")]
		public private UIKeyboard _code
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x600011C")]
			 get { } //Length: 3
			[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
			[CompilerGenerated]
			[Token(Token = "0x600011D")]
			private set { } //Length: 3
		}

		[Token(Token = "0x17000025")]
		public private bool _isOn
		{
			[Address(RVA = "0xAEF1A0", Offset = "0xAEE5A0", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x600011E")]
			 get { } //Length: 5
			[Address(RVA = "0x1E16980", Offset = "0x1E15D80", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x600011F")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000026")]
		public bool _isPresent
		{
			[Address(RVA = "0x1E16960", Offset = "0x1E15D60", Length = "0x11")]
			[Token(Token = "0x6000120")]
			 get { } //Length: 17
		}

		[Address(RVA = "0x1E168E0", Offset = "0x1E15CE0", Length = "0x7")]
		[Token(Token = "0x6000123")]
		public void ClearState() { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600011C")]
		public UIKeyboard get__code() { }

		[Address(RVA = "0xAEF1A0", Offset = "0xAEE5A0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600011E")]
		public bool get__isOn() { }

		[Address(RVA = "0x1E16960", Offset = "0x1E15D60", Length = "0x11")]
		[Token(Token = "0x6000120")]
		public bool get__isPresent() { }

		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x600011D")]
		private void set__code(UIKeyboard value) { }

		[Address(RVA = "0x1E16980", Offset = "0x1E15D80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600011F")]
		private void set__isOn(bool value) { }

		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6000121")]
		public void SetCode(UIKeyboard code) { }

		[Address(RVA = "0x1E168F0", Offset = "0x1E15CF0", Length = "0x69")]
		[Token(Token = "0x6000122")]
		public void UpdateState() { }

	}

	[Token(Token = "0x400013B")]
	private static Dictionary<UIKeyboard, String> KeyStringTable; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400013C")]
	private KeyboardButton[] _keyTables; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400013D")]
	private Dictionary<Buttons, UIKeyboard> _button2keyDic; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400013E")]
	private int _keyCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400013F")]
	private int _keyIndex; //Field offset: 0x24

	[Address(RVA = "0x1E21CE0", Offset = "0x1E210E0", Length = "0xDF")]
	[Token(Token = "0x6000115")]
	private Nullable<KeyboardButton> _hasKey(UIKeyboard k) { }

	[Address(RVA = "0x1E21190", Offset = "0x1E20590", Length = "0xB49")]
	[Token(Token = "0x600011B")]
	private static UIKeyboardPad() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600011A")]
	public UIKeyboardPad() { }

	[Address(RVA = "0x1E20030", Offset = "0x1E1F430", Length = "0x19C")]
	[Token(Token = "0x6000117")]
	public string Button2Key(Buttons btn) { }

	[Address(RVA = "0x1E201D0", Offset = "0x1E1F5D0", Length = "0x42")]
	[Token(Token = "0x600010A")]
	public void ClearButtons() { }

	[Address(RVA = "0x1E20220", Offset = "0x1E1F620", Length = "0x86")]
	[Token(Token = "0x6000114")]
	private void EntryButton(UIKeyboard aKey) { }

	[Address(RVA = "0x1E202B0", Offset = "0x1E1F6B0", Length = "0x2B5")]
	[Token(Token = "0x6000107")]
	public void Initialize(int n = 128) { }

	[Address(RVA = "0x1E20570", Offset = "0x1E1F970", Length = "0xD")]
	[Token(Token = "0x6000111")]
	public bool IsCancel() { }

	[Address(RVA = "0x1E20580", Offset = "0x1E1F980", Length = "0x12")]
	[Token(Token = "0x6000108")]
	public bool IsEmpty() { }

	[Address(RVA = "0x1E205A0", Offset = "0x1E1F9A0", Length = "0x37")]
	[Token(Token = "0x6000110")]
	public bool IsOk() { }

	[Address(RVA = "0x1E20680", Offset = "0x1E1FA80", Length = "0x83")]
	[Token(Token = "0x600010C")]
	public bool IsOn(UIKeyboard aKey) { }

	[Address(RVA = "0x1E205E0", Offset = "0x1E1F9E0", Length = "0x94")]
	[Token(Token = "0x600010D")]
	public bool IsOn(Buttons tbtn) { }

	[Address(RVA = "0x1E20710", Offset = "0x1E1FB10", Length = "0x93")]
	[Token(Token = "0x600010E")]
	public bool IsPresent(UIKeyboard aKey) { }

	[Address(RVA = "0x1E207B0", Offset = "0x1E1FBB0", Length = "0x94")]
	[Token(Token = "0x600010F")]
	public bool IsPresent(Buttons tbtn) { }

	[Address(RVA = "0x1E20850", Offset = "0x1E1FC50", Length = "0x1F4")]
	[Token(Token = "0x6000116")]
	public string Key2Button(string key) { }

	[Address(RVA = "0x1E20A50", Offset = "0x1E1FE50", Length = "0x8E")]
	[Token(Token = "0x600010B")]
	public static string KeyString(UIKeyboard key) { }

	[Address(RVA = "0x1E20AE0", Offset = "0x1E1FEE0", Length = "0x162")]
	[Token(Token = "0x6000112")]
	public Vector2 LStick(Vector2 tvec) { }

	[Address(RVA = "0x1E20C50", Offset = "0x1E20050", Length = "0x61")]
	[Token(Token = "0x6000118")]
	public void MapButton(Buttons btn, UIKeyboard key) { }

	[Address(RVA = "0x1E20CC0", Offset = "0x1E200C0", Length = "0x162")]
	[Token(Token = "0x6000113")]
	public Vector2 RStick(Vector2 tvec) { }

	[Address(RVA = "0x1E20E30", Offset = "0x1E20230", Length = "0x283")]
	[Token(Token = "0x6000119")]
	public void SetDefaultMapping() { }

	[Address(RVA = "0x1E210C0", Offset = "0x1E204C0", Length = "0xCC")]
	[Token(Token = "0x6000109")]
	public void UpdateButtons() { }

}

