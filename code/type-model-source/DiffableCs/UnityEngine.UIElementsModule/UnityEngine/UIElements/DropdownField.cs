namespace UnityEngine.UIElements;

[Token(Token = "0x20000C5")]
public class DropdownField : PopupField<String>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000C6")]
	internal class UxmlFactory : UxmlFactory<DropdownField, UxmlTraits>
	{

		[Address(RVA = "0x3346AE0", Offset = "0x3345EE0", Length = "0x39")]
		[Token(Token = "0x600064A")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000C7")]
	internal class UxmlTraits : UxmlTraits<String>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40003E7")]
		private UxmlIntAttributeDescription m_Index; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40003E8")]
		private UxmlStringAttributeDescription m_Choices; //Field offset: 0xA0

		[Address(RVA = "0x334B050", Offset = "0x334A450", Length = "0x10B")]
		[Token(Token = "0x600064C")]
		public UxmlTraits() { }

		[Address(RVA = "0x3349440", Offset = "0x3348840", Length = "0x1D1")]
		[Token(Token = "0x600064B")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}


	[Address(RVA = "0x333B960", Offset = "0x333AD60", Length = "0x5C")]
	[Token(Token = "0x6000648")]
	public DropdownField() { }

	[Address(RVA = "0x333B8F0", Offset = "0x333ACF0", Length = "0x69")]
	[Token(Token = "0x6000649")]
	public DropdownField(string label) { }

}

