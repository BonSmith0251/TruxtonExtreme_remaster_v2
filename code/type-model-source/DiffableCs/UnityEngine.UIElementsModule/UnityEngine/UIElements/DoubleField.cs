namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000C1")]
public class DoubleField : TextValueField<Double>
{
	[Token(Token = "0x20000C4")]
	private class DoubleInput : TextValueInput<Double>
	{

		[Token(Token = "0x170000ED")]
		protected virtual string allowedCharacters
		{
			[Address(RVA = "0x333B7C0", Offset = "0x333ABC0", Length = "0xA6")]
			[Token(Token = "0x6000644")]
			 get { } //Length: 166
		}

		[Token(Token = "0x170000EC")]
		private DoubleField parentDoubleField
		{
			[Address(RVA = "0x333B870", Offset = "0x333AC70", Length = "0x71")]
			[Token(Token = "0x6000642")]
			private get { } //Length: 113
		}

		[Address(RVA = "0x333B730", Offset = "0x333AB30", Length = "0x8E")]
		[Token(Token = "0x6000643")]
		internal DoubleInput() { }

		[Address(RVA = "0x333B510", Offset = "0x333A910", Length = "0x186")]
		[Token(Token = "0x6000645")]
		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, double startValue) { }

		[Address(RVA = "0x333B7C0", Offset = "0x333ABC0", Length = "0xA6")]
		[Token(Token = "0x6000644")]
		protected virtual string get_allowedCharacters() { }

		[Address(RVA = "0x333B870", Offset = "0x333AC70", Length = "0x71")]
		[Token(Token = "0x6000642")]
		private DoubleField get_parentDoubleField() { }

		[Address(RVA = "0x333B6A0", Offset = "0x333AAA0", Length = "0x39")]
		[Token(Token = "0x6000647")]
		protected virtual double StringToValue(string str) { }

		[Address(RVA = "0x333B6E0", Offset = "0x333AAE0", Length = "0x44")]
		[Token(Token = "0x6000646")]
		protected virtual string ValueToString(double v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000C2")]
	internal class UxmlFactory : UxmlFactory<DoubleField, UxmlTraits>
	{

		[Address(RVA = "0x3346DE0", Offset = "0x33461E0", Length = "0x39")]
		[Token(Token = "0x6000640")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000C3")]
	internal class UxmlTraits : TextValueFieldTraits<Double, UxmlDoubleAttributeDescription>
	{

		[Address(RVA = "0x334ADB0", Offset = "0x334A1B0", Length = "0x39")]
		[Token(Token = "0x6000641")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x40003E4")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40003E5")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40003E6")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x170000EB")]
	private DoubleInput doubleInput
	{
		[Address(RVA = "0x333B490", Offset = "0x333A890", Length = "0x7A")]
		[Token(Token = "0x6000638")]
		private get { } //Length: 122
	}

	[Address(RVA = "0x333AF90", Offset = "0x333A390", Length = "0x112")]
	[Token(Token = "0x600063F")]
	private static DoubleField() { }

	[Address(RVA = "0x333B2B0", Offset = "0x333A6B0", Length = "0x1DD")]
	[Token(Token = "0x600063B")]
	public DoubleField() { }

	[Address(RVA = "0x333B0B0", Offset = "0x333A4B0", Length = "0x1F5")]
	[Token(Token = "0x600063C")]
	public DoubleField(string label, int maxLength = 1000) { }

	[Address(RVA = "0x333ACC0", Offset = "0x333A0C0", Length = "0xD7")]
	[Token(Token = "0x600063E")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, double startValue) { }

	[Address(RVA = "0x333ADA0", Offset = "0x333A1A0", Length = "0x22")]
	[Token(Token = "0x600063D")]
	internal virtual bool CanTryParse(string textString) { }

	[Address(RVA = "0x333B490", Offset = "0x333A890", Length = "0x7A")]
	[Token(Token = "0x6000638")]
	private DoubleInput get_doubleInput() { }

	[Address(RVA = "0x333ADD0", Offset = "0x333A1D0", Length = "0x116")]
	[Token(Token = "0x600063A")]
	protected virtual double StringToValue(string str) { }

	[Address(RVA = "0x333AEF0", Offset = "0x333A2F0", Length = "0x9E")]
	[Token(Token = "0x6000639")]
	protected virtual string ValueToString(double v) { }

}

