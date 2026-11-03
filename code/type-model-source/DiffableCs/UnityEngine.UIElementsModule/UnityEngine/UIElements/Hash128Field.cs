namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000DC")]
public class Hash128Field : TextInputBaseField<Hash128>
{
	[Token(Token = "0x20000DF")]
	private class Hash128Input : TextInputBase<Hash128>
	{

		[Token(Token = "0x170000FE")]
		protected string allowedCharacters
		{
			[Address(RVA = "0x33800D0", Offset = "0x337F4D0", Length = "0x2C")]
			[Token(Token = "0x60006CF")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x337FF70", Offset = "0x337F370", Length = "0x158")]
		[Token(Token = "0x60006CE")]
		internal Hash128Input() { }

		[Address(RVA = "0x337FE20", Offset = "0x337F220", Length = "0xA3")]
		[Token(Token = "0x60006D0")]
		internal virtual bool AcceptCharacter(char c) { }

		[Address(RVA = "0x33800D0", Offset = "0x337F4D0", Length = "0x2C")]
		[Token(Token = "0x60006CF")]
		protected string get_allowedCharacters() { }

		[Address(RVA = "0x337FED0", Offset = "0x337F2D0", Length = "0x9A")]
		[Token(Token = "0x60006D2")]
		internal static Hash128 Parse(string str) { }

		[Address(RVA = "0x337F6D0", Offset = "0x337EAD0", Length = "0x9B")]
		[Token(Token = "0x60006D1")]
		protected virtual Hash128 StringToValue(string str) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000DD")]
	internal class UxmlFactory : UxmlFactory<Hash128Field, UxmlTraits>
	{

		[Address(RVA = "0x3391460", Offset = "0x3390860", Length = "0x39")]
		[Token(Token = "0x60006CC")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000DE")]
	internal class UxmlTraits : TextValueFieldTraits<Hash128, UxmlHash128AttributeDescription>
	{

		[Address(RVA = "0x33922E0", Offset = "0x33916E0", Length = "0x39")]
		[Token(Token = "0x60006CD")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x400043C")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400043D")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x400043E")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x170000FD")]
	public virtual Hash128 value
	{
		[Address(RVA = "0x337FD00", Offset = "0x337F100", Length = "0x5C")]
		[Token(Token = "0x60006C3")]
		 get { } //Length: 92
		[Address(RVA = "0x337FD60", Offset = "0x337F160", Length = "0xB9")]
		[Token(Token = "0x60006C4")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x337F8F0", Offset = "0x337ECF0", Length = "0x112")]
	[Token(Token = "0x60006CB")]
	private static Hash128Field() { }

	[Address(RVA = "0x337FCF0", Offset = "0x337F0F0", Length = "0x10")]
	[Token(Token = "0x60006C1")]
	public Hash128Field() { }

	[Address(RVA = "0x337FA10", Offset = "0x337EE10", Length = "0x2D2")]
	[Token(Token = "0x60006C2")]
	public Hash128Field(string label, int maxLength = -1) { }

	[Address(RVA = "0x337FD00", Offset = "0x337F100", Length = "0x5C")]
	[Token(Token = "0x60006C3")]
	public virtual Hash128 get_value() { }

	[Address(RVA = "0x337F490", Offset = "0x337E890", Length = "0x17D")]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FocusOutEvent)})]
	[Token(Token = "0x60006CA")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x337FD60", Offset = "0x337F160", Length = "0xB9")]
	[Token(Token = "0x60006C4")]
	public virtual void set_value(Hash128 value) { }

	[Address(RVA = "0x337F610", Offset = "0x337EA10", Length = "0xB9")]
	[Token(Token = "0x60006C7")]
	public virtual void SetValueWithoutNotify(Hash128 newValue) { }

	[Address(RVA = "0x337F6D0", Offset = "0x337EAD0", Length = "0x9B")]
	[Token(Token = "0x60006C9")]
	protected virtual Hash128 StringToValue(string str) { }

	[Address(RVA = "0x337F770", Offset = "0x337EB70", Length = "0x82")]
	[Token(Token = "0x60006C6")]
	internal virtual void UpdateTextFromValue() { }

	[Address(RVA = "0x337F800", Offset = "0x337EC00", Length = "0xCA")]
	[Token(Token = "0x60006C5")]
	internal virtual void UpdateValueFromText() { }

	[Address(RVA = "0x337F8D0", Offset = "0x337ECD0", Length = "0x13")]
	[Token(Token = "0x60006C8")]
	protected virtual string ValueToString(Hash128 value) { }

}

