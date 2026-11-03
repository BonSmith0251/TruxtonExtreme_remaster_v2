namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x200012C")]
public class PopupField : BasePopupField<T, T>
{
	[CompilerGenerated]
	[Token(Token = "0x200012D")]
	private sealed class <>c__DisplayClass27_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005D8")]
		public T item; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005D9")]
		public PopupField<T> <>4__this; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000956")]
		public <>c__DisplayClass27_0() { }

		[Address(RVA = "0xA71F80", Offset = "0xA71380", Length = "0x31")]
		[Token(Token = "0x6000957")]
		internal void <AddMenuItems>b__0() { }

	}

	[Token(Token = "0x40005D3")]
	internal static readonly BindingId indexProperty; //Field offset: 0x0
	[Token(Token = "0x40005D5")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40005D6")]
	public static readonly string labelUssClassName; //Field offset: 0x0
	[Token(Token = "0x40005D7")]
	public static readonly string inputUssClassName; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005D4")]
	private int m_Index; //Field offset: 0x0

	[CreateProperty]
	[Token(Token = "0x17000194")]
	public int index
	{
		[Address(RVA = "0xE2B0A0", Offset = "0xE2A4A0", Length = "0x9")]
		[Token(Token = "0x6000950")]
		 get { } //Length: 9
		[Address(RVA = "0xE2B500", Offset = "0xE2A900", Length = "0x102")]
		[Token(Token = "0x6000951")]
		 set { } //Length: 258
	}

	[Token(Token = "0x17000193")]
	public virtual T value
	{
		[Address(RVA = "0xE2B1B0", Offset = "0xE2A5B0", Length = "0x26")]
		[Token(Token = "0x600094D")]
		 get { } //Length: 38
		[Address(RVA = "0xE2B8A0", Offset = "0xE2ACA0", Length = "0xEA")]
		[Token(Token = "0x600094E")]
		 set { } //Length: 234
	}

	[Address(RVA = "0xE2A8A0", Offset = "0xE29CA0", Length = "0x42F")]
	[Token(Token = "0x6000955")]
	private static PopupField`1() { }

	[Address(RVA = "0xE2ACD0", Offset = "0xE2A0D0", Length = "0x192")]
	[Token(Token = "0x6000952")]
	public PopupField`1(string label = null) { }

	[Address(RVA = "0xE28F60", Offset = "0xE28360", Length = "0x403")]
	[Token(Token = "0x6000953")]
	internal virtual void AddMenuItems(AbstractGenericMenu menu) { }

	[Address(RVA = "0xE29A60", Offset = "0xE28E60", Length = "0x26")]
	[Token(Token = "0x6000954")]
	private void ChangeValueFromMenu(T menuItem) { }

	[Address(RVA = "0xE2B0A0", Offset = "0xE2A4A0", Length = "0x9")]
	[Token(Token = "0x6000950")]
	public int get_index() { }

	[Address(RVA = "0xE2B1B0", Offset = "0xE2A5B0", Length = "0x26")]
	[Token(Token = "0x600094D")]
	public virtual T get_value() { }

	[Address(RVA = "0xE29A90", Offset = "0xE28E90", Length = "0x94")]
	[Token(Token = "0x600094C")]
	internal virtual string GetListItemToDisplay(T value) { }

	[Address(RVA = "0xE2A120", Offset = "0xE29520", Length = "0xFD")]
	[Token(Token = "0x600094B")]
	internal virtual string GetValueToDisplay() { }

	[Address(RVA = "0xE2B500", Offset = "0xE2A900", Length = "0x102")]
	[Token(Token = "0x6000951")]
	public void set_index(int value) { }

	[Address(RVA = "0xE2B8A0", Offset = "0xE2ACA0", Length = "0xEA")]
	[Token(Token = "0x600094E")]
	public virtual void set_value(T value) { }

	[Address(RVA = "0xE2A400", Offset = "0xE29800", Length = "0x6E")]
	[Token(Token = "0x600094F")]
	public virtual void SetValueWithoutNotify(T newValue) { }

}

