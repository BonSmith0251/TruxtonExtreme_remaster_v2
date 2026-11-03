namespace UnityEngine.UIElements;

[Token(Token = "0x20000A2")]
internal class ButtonStripField : BaseField<Int32>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000A3")]
	internal class UxmlFactory : UxmlFactory<ButtonStripField, UxmlTraits>
	{

		[Address(RVA = "0x3346B20", Offset = "0x3345F20", Length = "0x39")]
		[Token(Token = "0x60005CB")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000A4")]
	internal class UxmlTraits : UxmlTraits<Int32>
	{

		[Address(RVA = "0x334B4E0", Offset = "0x334A8E0", Length = "0x39")]
		[Token(Token = "0x60005CC")]
		public UxmlTraits() { }

	}

	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x4000385")]
	private readonly List<Button> m_Buttons; //Field offset: 0x358

	[Address(RVA = "0x3339860", Offset = "0x3338C60", Length = "0xB1")]
	[Token(Token = "0x60005C8")]
	public ButtonStripField() { }

	[Address(RVA = "0x3339670", Offset = "0x3338A70", Length = "0xC5")]
	[Token(Token = "0x60005CA")]
	private void RefreshButtonsState() { }

	[Address(RVA = "0x3339740", Offset = "0x3338B40", Length = "0x11C")]
	[Token(Token = "0x60005C9")]
	public virtual void SetValueWithoutNotify(int newValue) { }

}

