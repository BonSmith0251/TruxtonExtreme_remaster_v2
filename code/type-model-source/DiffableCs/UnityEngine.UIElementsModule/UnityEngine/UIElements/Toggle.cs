namespace UnityEngine.UIElements;

[Token(Token = "0x2000165")]
public class Toggle : BaseBoolField
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000166")]
	internal class UxmlFactory : UxmlFactory<Toggle, UxmlTraits>
	{

		[Address(RVA = "0x33C3CE0", Offset = "0x33C30E0", Length = "0x39")]
		[Token(Token = "0x6000AE3")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000167")]
	internal class UxmlTraits : BaseFieldTraits<Boolean, UxmlBoolAttributeDescription>
	{
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000715")]
		private UxmlStringAttributeDescription m_Text; //Field offset: 0xA0

		[Address(RVA = "0x33C4EC0", Offset = "0x33C42C0", Length = "0xA7")]
		[Token(Token = "0x6000AE5")]
		public UxmlTraits() { }

		[Address(RVA = "0x33C3E60", Offset = "0x33C3260", Length = "0x13D")]
		[Token(Token = "0x6000AE4")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400070E")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400070F")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x4000710")]
	public static readonly string inputUssClassName; //Field offset: 0x10
	[Obsolete]
	[Token(Token = "0x4000711")]
	public static readonly string noTextVariantUssClassName; //Field offset: 0x18
	[Token(Token = "0x4000712")]
	public static readonly string checkmarkUssClassName; //Field offset: 0x20
	[Token(Token = "0x4000713")]
	public static readonly string textUssClassName; //Field offset: 0x28
	[Token(Token = "0x4000714")]
	public static readonly string mixedValuesUssClassName; //Field offset: 0x30

	[Address(RVA = "0x33BBEA0", Offset = "0x33BB2A0", Length = "0x272")]
	[Token(Token = "0x6000AE2")]
	private static Toggle() { }

	[Address(RVA = "0x33BC260", Offset = "0x33BB660", Length = "0x126")]
	[Token(Token = "0x6000ADE")]
	public Toggle() { }

	[Address(RVA = "0x33BC120", Offset = "0x33BB520", Length = "0x133")]
	[Token(Token = "0x6000ADF")]
	public Toggle(string label) { }

	[Address(RVA = "0x33BBC90", Offset = "0x33BB090", Length = "0x7A")]
	[Token(Token = "0x6000AE0")]
	protected virtual void InitLabel() { }

	[Address(RVA = "0x33BBD10", Offset = "0x33BB110", Length = "0x181")]
	[Token(Token = "0x6000AE1")]
	protected virtual void UpdateMixedValueContent() { }

}

