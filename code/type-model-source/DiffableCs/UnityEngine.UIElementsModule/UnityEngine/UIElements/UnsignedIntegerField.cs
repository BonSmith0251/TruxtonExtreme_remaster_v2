namespace UnityEngine.UIElements;

[Token(Token = "0x2000176")]
public class UnsignedIntegerField : TextValueField<UInt32>
{
	[Token(Token = "0x2000179")]
	private class UnsignedIntegerInput : TextValueInput<UInt32>
	{

		[Token(Token = "0x170001FE")]
		protected virtual string allowedCharacters
		{
			[Address(RVA = "0x33C2DC0", Offset = "0x33C21C0", Length = "0xA7")]
			[Token(Token = "0x6000B5B")]
			 get { } //Length: 167
		}

		[Token(Token = "0x170001FD")]
		private UnsignedIntegerField parentUnsignedIntegerField
		{
			[Address(RVA = "0x33C2E70", Offset = "0x33C2270", Length = "0x71")]
			[Token(Token = "0x6000B59")]
			private get { } //Length: 113
		}

		[Address(RVA = "0x33C2D30", Offset = "0x33C2130", Length = "0x8E")]
		[Token(Token = "0x6000B5A")]
		internal UnsignedIntegerInput() { }

		[Address(RVA = "0x33C2AE0", Offset = "0x33C1EE0", Length = "0x1BF")]
		[Token(Token = "0x6000B5C")]
		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue) { }

		[Address(RVA = "0x33C2DC0", Offset = "0x33C21C0", Length = "0xA7")]
		[Token(Token = "0x6000B5B")]
		protected virtual string get_allowedCharacters() { }

		[Address(RVA = "0x33C2E70", Offset = "0x33C2270", Length = "0x71")]
		[Token(Token = "0x6000B59")]
		private UnsignedIntegerField get_parentUnsignedIntegerField() { }

		[Address(RVA = "0x33C2CA0", Offset = "0x33C20A0", Length = "0x39")]
		[Token(Token = "0x6000B5E")]
		protected virtual uint StringToValue(string str) { }

		[Address(RVA = "0x33C2CE0", Offset = "0x33C20E0", Length = "0x42")]
		[Token(Token = "0x6000B5D")]
		protected virtual string ValueToString(uint v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000177")]
	internal class UxmlFactory : UxmlFactory<UnsignedIntegerField, UxmlTraits>
	{

		[Address(RVA = "0x33C3DA0", Offset = "0x33C31A0", Length = "0x39")]
		[Token(Token = "0x6000B57")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000178")]
	internal class UxmlTraits : TextValueFieldTraits<UInt32, UxmlUnsignedIntAttributeDescription>
	{

		[Address(RVA = "0x33C4BE0", Offset = "0x33C3FE0", Length = "0x39")]
		[Token(Token = "0x6000B58")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x4000762")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4000763")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x4000764")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x170001FC")]
	private UnsignedIntegerInput integerInput
	{
		[Address(RVA = "0x33C2A60", Offset = "0x33C1E60", Length = "0x7A")]
		[Token(Token = "0x6000B4F")]
		private get { } //Length: 122
	}

	[Address(RVA = "0x33C2560", Offset = "0x33C1960", Length = "0x112")]
	[Token(Token = "0x6000B56")]
	private static UnsignedIntegerField() { }

	[Address(RVA = "0x33C2880", Offset = "0x33C1C80", Length = "0x1DD")]
	[Token(Token = "0x6000B52")]
	public UnsignedIntegerField() { }

	[Address(RVA = "0x33C2680", Offset = "0x33C1A80", Length = "0x1F5")]
	[Token(Token = "0x6000B53")]
	public UnsignedIntegerField(string label, int maxLength = 1000) { }

	[Address(RVA = "0x33C2290", Offset = "0x33C1690", Length = "0xD7")]
	[Token(Token = "0x6000B55")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue) { }

	[Address(RVA = "0x33C2370", Offset = "0x33C1770", Length = "0x21")]
	[Token(Token = "0x6000B54")]
	internal virtual bool CanTryParse(string textString) { }

	[Address(RVA = "0x33C2A60", Offset = "0x33C1E60", Length = "0x7A")]
	[Token(Token = "0x6000B4F")]
	private UnsignedIntegerInput get_integerInput() { }

	[Address(RVA = "0x33C23A0", Offset = "0x33C17A0", Length = "0x113")]
	[Token(Token = "0x6000B51")]
	protected virtual uint StringToValue(string str) { }

	[Address(RVA = "0x33C24C0", Offset = "0x33C18C0", Length = "0x9C")]
	[Token(Token = "0x6000B50")]
	protected virtual string ValueToString(uint v) { }

}

