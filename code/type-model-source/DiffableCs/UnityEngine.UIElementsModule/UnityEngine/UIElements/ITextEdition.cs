namespace UnityEngine.UIElements;

[Token(Token = "0x20004BE")]
public interface ITextEdition
{

	[Token(Token = "0x17000991")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Func<Char, Boolean> AcceptCharacter
	{
		[Token(Token = "0x6002409")]
		internal get { } //Length: 0
		[Token(Token = "0x600240A")]
		internal set { } //Length: 0
	}

	[Token(Token = "0x1700099A")]
	public bool autoCorrection
	{
		[Address(RVA = "0x32A0B80", Offset = "0x329FF80", Length = "0xAB")]
		[Token(Token = "0x600241D")]
		 get { } //Length: 171
		[Address(RVA = "0x32A0E40", Offset = "0x32A0240", Length = "0xA8")]
		[Token(Token = "0x600241E")]
		 set { } //Length: 168
	}

	[Token(Token = "0x17000996")]
	internal Func<String> GetDefaultValueType
	{
		[Token(Token = "0x6002413")]
		internal get { } //Length: 0
		[Token(Token = "0x6002414")]
		internal set { } //Length: 0
	}

	[Token(Token = "0x1700099B")]
	public bool hideMobileInput
	{
		[Address(RVA = "0x32A0C30", Offset = "0x32A0030", Length = "0xAB")]
		[Token(Token = "0x600241F")]
		 get { } //Length: 171
		[Address(RVA = "0x32A0EF0", Offset = "0x32A02F0", Length = "0xA8")]
		[Token(Token = "0x6002420")]
		 set { } //Length: 168
	}

	[Token(Token = "0x17000999")]
	public bool hidePlaceholderOnFocus
	{
		[Token(Token = "0x600241B")]
		 get { } //Length: 0
		[Token(Token = "0x600241C")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000990")]
	public bool isDelayed
	{
		[Token(Token = "0x6002405")]
		 get { } //Length: 0
		[Token(Token = "0x6002406")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000998")]
	public bool isPassword
	{
		[Token(Token = "0x6002419")]
		 get { } //Length: 0
		[Token(Token = "0x600241A")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700098D")]
	public bool isReadOnly
	{
		[Token(Token = "0x60023FF")]
		 get { } //Length: 0
		[Token(Token = "0x6002400")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700099D")]
	public TouchScreenKeyboardType keyboardType
	{
		[Address(RVA = "0x32A0CE0", Offset = "0x32A00E0", Length = "0xAB")]
		[Token(Token = "0x6002422")]
		 get { } //Length: 171
		[Address(RVA = "0x32A0FA0", Offset = "0x32A03A0", Length = "0xA8")]
		[Token(Token = "0x6002423")]
		 set { } //Length: 168
	}

	[Token(Token = "0x17000997")]
	public char maskChar
	{
		[Token(Token = "0x6002417")]
		 get { } //Length: 0
		[Token(Token = "0x6002418")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700098E")]
	public int maxLength
	{
		[Token(Token = "0x6002401")]
		 get { } //Length: 0
		[Token(Token = "0x6002402")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000995")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Action MoveFocusToCompositeRoot
	{
		[Token(Token = "0x6002411")]
		internal get { } //Length: 0
		[Token(Token = "0x6002412")]
		internal set { } //Length: 0
	}

	[Token(Token = "0x1700098C")]
	internal bool multiline
	{
		[Token(Token = "0x60023FD")]
		internal get { } //Length: 0
		[Token(Token = "0x60023FE")]
		internal set { } //Length: 0
	}

	[Token(Token = "0x1700098F")]
	public string placeholder
	{
		[Token(Token = "0x6002403")]
		 get { } //Length: 0
		[Token(Token = "0x6002404")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700099C")]
	public TouchScreenKeyboard touchScreenKeyboard
	{
		[Address(RVA = "0x32A0D90", Offset = "0x32A0190", Length = "0xAB")]
		[Token(Token = "0x6002421")]
		 get { } //Length: 171
	}

	[Token(Token = "0x17000992")]
	internal Action<Boolean> UpdateScrollOffset
	{
		[Token(Token = "0x600240B")]
		internal get { } //Length: 0
		[Token(Token = "0x600240C")]
		internal set { } //Length: 0
	}

	[Token(Token = "0x17000994")]
	internal Action UpdateTextFromValue
	{
		[Token(Token = "0x600240F")]
		internal get { } //Length: 0
		[Token(Token = "0x6002410")]
		internal set { } //Length: 0
	}

	[Token(Token = "0x17000993")]
	internal Action UpdateValueFromText
	{
		[Token(Token = "0x600240D")]
		internal get { } //Length: 0
		[Token(Token = "0x600240E")]
		internal set { } //Length: 0
	}

	[Token(Token = "0x6002416")]
	internal string CullString(string s) { }

	[Token(Token = "0x6002409")]
	internal Func<Char, Boolean> get_AcceptCharacter() { }

	[Address(RVA = "0x32A0B80", Offset = "0x329FF80", Length = "0xAB")]
	[Token(Token = "0x600241D")]
	public bool get_autoCorrection() { }

	[Token(Token = "0x6002413")]
	internal Func<String> get_GetDefaultValueType() { }

	[Address(RVA = "0x32A0C30", Offset = "0x32A0030", Length = "0xAB")]
	[Token(Token = "0x600241F")]
	public bool get_hideMobileInput() { }

	[Token(Token = "0x600241B")]
	public bool get_hidePlaceholderOnFocus() { }

	[Token(Token = "0x6002405")]
	public bool get_isDelayed() { }

	[Token(Token = "0x6002419")]
	public bool get_isPassword() { }

	[Token(Token = "0x60023FF")]
	public bool get_isReadOnly() { }

	[Address(RVA = "0x32A0CE0", Offset = "0x32A00E0", Length = "0xAB")]
	[Token(Token = "0x6002422")]
	public TouchScreenKeyboardType get_keyboardType() { }

	[Token(Token = "0x6002417")]
	public char get_maskChar() { }

	[Token(Token = "0x6002401")]
	public int get_maxLength() { }

	[Token(Token = "0x6002411")]
	internal Action get_MoveFocusToCompositeRoot() { }

	[Token(Token = "0x60023FD")]
	internal bool get_multiline() { }

	[Token(Token = "0x6002403")]
	public string get_placeholder() { }

	[Address(RVA = "0x32A0D90", Offset = "0x32A0190", Length = "0xAB")]
	[Token(Token = "0x6002421")]
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	[Token(Token = "0x600240B")]
	internal Action<Boolean> get_UpdateScrollOffset() { }

	[Token(Token = "0x600240F")]
	internal Action get_UpdateTextFromValue() { }

	[Token(Token = "0x600240D")]
	internal Action get_UpdateValueFromText() { }

	[Token(Token = "0x6002408")]
	internal void RestoreValueAndText() { }

	[Token(Token = "0x6002407")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SaveValueAndText() { }

	[Token(Token = "0x600240A")]
	internal void set_AcceptCharacter(Func<Char, Boolean> value) { }

	[Address(RVA = "0x32A0E40", Offset = "0x32A0240", Length = "0xA8")]
	[Token(Token = "0x600241E")]
	public void set_autoCorrection(bool value) { }

	[Token(Token = "0x6002414")]
	internal void set_GetDefaultValueType(Func<String> value) { }

	[Address(RVA = "0x32A0EF0", Offset = "0x32A02F0", Length = "0xA8")]
	[Token(Token = "0x6002420")]
	public void set_hideMobileInput(bool value) { }

	[Token(Token = "0x600241C")]
	public void set_hidePlaceholderOnFocus(bool value) { }

	[Token(Token = "0x6002406")]
	public void set_isDelayed(bool value) { }

	[Token(Token = "0x600241A")]
	public void set_isPassword(bool value) { }

	[Token(Token = "0x6002400")]
	public void set_isReadOnly(bool value) { }

	[Address(RVA = "0x32A0FA0", Offset = "0x32A03A0", Length = "0xA8")]
	[Token(Token = "0x6002423")]
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	[Token(Token = "0x6002418")]
	public void set_maskChar(char value) { }

	[Token(Token = "0x6002402")]
	public void set_maxLength(int value) { }

	[Token(Token = "0x6002412")]
	internal void set_MoveFocusToCompositeRoot(Action value) { }

	[Token(Token = "0x60023FE")]
	internal void set_multiline(bool value) { }

	[Token(Token = "0x6002404")]
	public void set_placeholder(string value) { }

	[Token(Token = "0x600240C")]
	internal void set_UpdateScrollOffset(Action<Boolean> value) { }

	[Token(Token = "0x6002410")]
	internal void set_UpdateTextFromValue(Action value) { }

	[Token(Token = "0x600240E")]
	internal void set_UpdateValueFromText(Action value) { }

	[Token(Token = "0x6002415")]
	internal void UpdateText(string value) { }

}

