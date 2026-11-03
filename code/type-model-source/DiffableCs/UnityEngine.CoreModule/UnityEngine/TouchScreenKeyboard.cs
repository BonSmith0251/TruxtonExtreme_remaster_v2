namespace UnityEngine;

[NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
[NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
[NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
[Token(Token = "0x20001EF")]
public class TouchScreenKeyboard
{
	[Token(Token = "0x20001F2")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6001602")]
		public static IntPtr ConvertToNative(TouchScreenKeyboard touchScreenKeyboard) { }

	}

	[Token(Token = "0x20001F1")]
	internal enum InputFieldAppearance : int
	{
		Customizable = 0,
		AlwaysVisible = 1,
		AlwaysHidden = 2,
	}

	[Token(Token = "0x20001F0")]
	internal enum Status : int
	{
		Visible = 0,
		Done = 1,
		Canceled = 2,
		LostFocus = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40006E6")]
	private static bool <disableInPlaceEditing>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006E5")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Token(Token = "0x17000345")]
	public bool active
	{
		[Address(RVA = "0x308BE20", Offset = "0x308B220", Length = "0x52")]
		[NativeName("IsActive")]
		[Token(Token = "0x60015EF")]
		 get { } //Length: 82
		[Address(RVA = "0x308C360", Offset = "0x308B760", Length = "0x5C")]
		[NativeName("SetActive")]
		[Token(Token = "0x60015F0")]
		 set { } //Length: 92
	}

	[Token(Token = "0x17000348")]
	public bool canGetSelection
	{
		[Address(RVA = "0x308BEC0", Offset = "0x308B2C0", Length = "0x52")]
		[NativeName("CanGetSelection")]
		[Token(Token = "0x60015F3")]
		 get { } //Length: 82
	}

	[Token(Token = "0x17000349")]
	public bool canSetSelection
	{
		[Address(RVA = "0x308BF60", Offset = "0x308B360", Length = "0x52")]
		[NativeName("CanSetSelection")]
		[Token(Token = "0x60015F4")]
		 get { } //Length: 82
	}

	[Token(Token = "0x17000347")]
	public int characterLimit
	{
		[Address(RVA = "0x308C400", Offset = "0x308B800", Length = "0x59")]
		[NativeName("SetCharacterLimit")]
		[Token(Token = "0x60015F2")]
		 set { } //Length: 89
	}

	[Token(Token = "0x17000340")]
	internal static bool disableInPlaceEditing
	{
		[Address(RVA = "0x308BFC0", Offset = "0x308B3C0", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x60015E6")]
		internal get { } //Length: 54
	}

	[Token(Token = "0x17000343")]
	public static bool hideInput
	{
		[Address(RVA = "0x308C460", Offset = "0x308B860", Length = "0x33")]
		[NativeName("SetInputHidden")]
		[Token(Token = "0x60015ED")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000344")]
	public static InputFieldAppearance inputFieldAppearance
	{
		[Address(RVA = "0x308C000", Offset = "0x308B400", Length = "0x2A")]
		[NativeName("GetInputFieldAppearance")]
		[Token(Token = "0x60015EE")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000341")]
	public static bool isInPlaceEditingAllowed
	{
		[Address(RVA = "0x308C030", Offset = "0x308B430", Length = "0x60")]
		[Token(Token = "0x60015E7")]
		 get { } //Length: 96
	}

	[Token(Token = "0x1700033F")]
	public static bool isSupported
	{
		[Address(RVA = "0x308C090", Offset = "0x308B490", Length = "0x83")]
		[Token(Token = "0x60015E5")]
		 get { } //Length: 131
	}

	[Token(Token = "0x1700034A")]
	public RangeInt selection
	{
		[Address(RVA = "0x308C120", Offset = "0x308B520", Length = "0x42")]
		[Token(Token = "0x60015F5")]
		 get { } //Length: 66
		[Address(RVA = "0x308C4A0", Offset = "0x308B8A0", Length = "0x11F")]
		[Token(Token = "0x60015F6")]
		 set { } //Length: 287
	}

	[Token(Token = "0x17000346")]
	public Status status
	{
		[Address(RVA = "0x308C1B0", Offset = "0x308B5B0", Length = "0x52")]
		[NativeName("GetKeyboardStatus")]
		[Token(Token = "0x60015F1")]
		 get { } //Length: 82
	}

	[Token(Token = "0x17000342")]
	public string text
	{
		[Address(RVA = "0x308C260", Offset = "0x308B660", Length = "0xA3")]
		[NativeName("GetText")]
		[Token(Token = "0x60015EB")]
		 get { } //Length: 163
		[Address(RVA = "0x308C610", Offset = "0x308BA10", Length = "0x190")]
		[NativeName("SetText")]
		[Token(Token = "0x60015EC")]
		 set { } //Length: 400
	}

	[Address(RVA = "0x308BCB0", Offset = "0x308B0B0", Length = "0x12A")]
	[Token(Token = "0x60015E3")]
	public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[Address(RVA = "0x308B4A0", Offset = "0x308A8A0", Length = "0x8A")]
	[Token(Token = "0x60015E1")]
	private void Destroy() { }

	[Address(RVA = "0x308B530", Offset = "0x308A930", Length = "0xCE")]
	[Token(Token = "0x60015E2")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x308BE20", Offset = "0x308B220", Length = "0x52")]
	[NativeName("IsActive")]
	[Token(Token = "0x60015EF")]
	public bool get_active() { }

	[Address(RVA = "0x308BDE0", Offset = "0x308B1E0", Length = "0x33")]
	[Token(Token = "0x60015FC")]
	private static bool get_active_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x308BEC0", Offset = "0x308B2C0", Length = "0x52")]
	[NativeName("CanGetSelection")]
	[Token(Token = "0x60015F3")]
	public bool get_canGetSelection() { }

	[Address(RVA = "0x308BE80", Offset = "0x308B280", Length = "0x33")]
	[Token(Token = "0x6001600")]
	private static bool get_canGetSelection_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x308BF60", Offset = "0x308B360", Length = "0x52")]
	[NativeName("CanSetSelection")]
	[Token(Token = "0x60015F4")]
	public bool get_canSetSelection() { }

	[Address(RVA = "0x308BF20", Offset = "0x308B320", Length = "0x33")]
	[Token(Token = "0x6001601")]
	private static bool get_canSetSelection_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x308BFC0", Offset = "0x308B3C0", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x60015E6")]
	internal static bool get_disableInPlaceEditing() { }

	[Address(RVA = "0x308C000", Offset = "0x308B400", Length = "0x2A")]
	[NativeName("GetInputFieldAppearance")]
	[Token(Token = "0x60015EE")]
	public static InputFieldAppearance get_inputFieldAppearance() { }

	[Address(RVA = "0x308C030", Offset = "0x308B430", Length = "0x60")]
	[Token(Token = "0x60015E7")]
	public static bool get_isInPlaceEditingAllowed() { }

	[Address(RVA = "0x308C090", Offset = "0x308B490", Length = "0x83")]
	[Token(Token = "0x60015E5")]
	public static bool get_isSupported() { }

	[Address(RVA = "0x308C120", Offset = "0x308B520", Length = "0x42")]
	[Token(Token = "0x60015F5")]
	public RangeInt get_selection() { }

	[Address(RVA = "0x308C1B0", Offset = "0x308B5B0", Length = "0x52")]
	[NativeName("GetKeyboardStatus")]
	[Token(Token = "0x60015F1")]
	public Status get_status() { }

	[Address(RVA = "0x308C170", Offset = "0x308B570", Length = "0x33")]
	[Token(Token = "0x60015FE")]
	private static Status get_status_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x308C260", Offset = "0x308B660", Length = "0xA3")]
	[NativeName("GetText")]
	[Token(Token = "0x60015EB")]
	public string get_text() { }

	[Address(RVA = "0x308C210", Offset = "0x308B610", Length = "0x42")]
	[Token(Token = "0x60015FA")]
	private static void get_text_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x308B600", Offset = "0x308AA00", Length = "0x42")]
	[Token(Token = "0x60015F7")]
	private static void GetSelection(out int start, out int length) { }

	[Address(RVA = "0x308B650", Offset = "0x308AA50", Length = "0x33")]
	[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = True)]
	[Token(Token = "0x60015E0")]
	private static void Internal_Destroy(IntPtr ptr) { }

	[Address(RVA = "0x308B690", Offset = "0x308AA90", Length = "0x2A")]
	[Token(Token = "0x60015E8")]
	private static bool IsInPlaceEditingAllowed() { }

	[Address(RVA = "0x308B820", Offset = "0x308AC20", Length = "0x177")]
	[ExcludeFromDocs]
	[Token(Token = "0x60015EA")]
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[Address(RVA = "0x308B6C0", Offset = "0x308AAC0", Length = "0x156")]
	[Token(Token = "0x60015E9")]
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[Address(RVA = "0x308C360", Offset = "0x308B760", Length = "0x5C")]
	[NativeName("SetActive")]
	[Token(Token = "0x60015F0")]
	public void set_active(bool value) { }

	[Address(RVA = "0x308C310", Offset = "0x308B710", Length = "0x42")]
	[Token(Token = "0x60015FD")]
	private static void set_active_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x308C400", Offset = "0x308B800", Length = "0x59")]
	[NativeName("SetCharacterLimit")]
	[Token(Token = "0x60015F2")]
	public void set_characterLimit(int value) { }

	[Address(RVA = "0x308C3C0", Offset = "0x308B7C0", Length = "0x40")]
	[Token(Token = "0x60015FF")]
	private static void set_characterLimit_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x308C460", Offset = "0x308B860", Length = "0x33")]
	[NativeName("SetInputHidden")]
	[Token(Token = "0x60015ED")]
	public static void set_hideInput(bool value) { }

	[Address(RVA = "0x308C4A0", Offset = "0x308B8A0", Length = "0x11F")]
	[Token(Token = "0x60015F6")]
	public void set_selection(RangeInt value) { }

	[Address(RVA = "0x308C610", Offset = "0x308BA10", Length = "0x190")]
	[NativeName("SetText")]
	[Token(Token = "0x60015EC")]
	public void set_text(string value) { }

	[Address(RVA = "0x308C5C0", Offset = "0x308B9C0", Length = "0x42")]
	[Token(Token = "0x60015FB")]
	private static void set_text_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x308B9A0", Offset = "0x308ADA0", Length = "0x3E")]
	[Token(Token = "0x60015F8")]
	private static void SetSelection(int start, int length) { }

	[Address(RVA = "0x308BA40", Offset = "0x308AE40", Length = "0x269")]
	[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
	[Token(Token = "0x60015E4")]
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	[Address(RVA = "0x308B9E0", Offset = "0x308ADE0", Length = "0x52")]
	[Token(Token = "0x60015F9")]
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper_Injected(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, ref ManagedSpanWrapper text, ref ManagedSpanWrapper textPlaceholder) { }

}

