namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000F8")]
public class IntegerField : TextValueField<Int32>
{
	[Token(Token = "0x20000FB")]
	private class IntegerInput : TextValueInput<Int32>
	{

		[Token(Token = "0x17000142")]
		protected virtual string allowedCharacters
		{
			[Address(RVA = "0x3384B00", Offset = "0x3383F00", Length = "0xA7")]
			[Token(Token = "0x60007D1")]
			 get { } //Length: 167
		}

		[Token(Token = "0x17000141")]
		private IntegerField parentIntegerField
		{
			[Address(RVA = "0x3384BB0", Offset = "0x3383FB0", Length = "0x71")]
			[Token(Token = "0x60007CF")]
			private get { } //Length: 113
		}

		[Address(RVA = "0x3384A70", Offset = "0x3383E70", Length = "0x8E")]
		[Token(Token = "0x60007D0")]
		internal IntegerInput() { }

		[Address(RVA = "0x3384810", Offset = "0x3383C10", Length = "0x1C0")]
		[Token(Token = "0x60007D2")]
		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

		[Address(RVA = "0x3384B00", Offset = "0x3383F00", Length = "0xA7")]
		[Token(Token = "0x60007D1")]
		protected virtual string get_allowedCharacters() { }

		[Address(RVA = "0x3384BB0", Offset = "0x3383FB0", Length = "0x71")]
		[Token(Token = "0x60007CF")]
		private IntegerField get_parentIntegerField() { }

		[Address(RVA = "0x33849E0", Offset = "0x3383DE0", Length = "0x39")]
		[Token(Token = "0x60007D4")]
		protected virtual int StringToValue(string str) { }

		[Address(RVA = "0x3384A20", Offset = "0x3383E20", Length = "0x42")]
		[Token(Token = "0x60007D3")]
		protected virtual string ValueToString(int v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000F9")]
	internal class UxmlFactory : UxmlFactory<IntegerField, UxmlTraits>
	{

		[Address(RVA = "0x3391320", Offset = "0x3390720", Length = "0x39")]
		[Token(Token = "0x60007CD")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000FA")]
	internal class UxmlTraits : TextValueFieldTraits<Int32, UxmlIntAttributeDescription>
	{

		[Address(RVA = "0x33925C0", Offset = "0x33919C0", Length = "0x39")]
		[Token(Token = "0x60007CE")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x40004DC")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40004DD")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40004DE")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x17000140")]
	private IntegerInput integerInput
	{
		[Address(RVA = "0x3384790", Offset = "0x3383B90", Length = "0x7A")]
		[Token(Token = "0x60007C5")]
		private get { } //Length: 122
	}

	[Address(RVA = "0x3384290", Offset = "0x3383690", Length = "0x112")]
	[Token(Token = "0x60007CC")]
	private static IntegerField() { }

	[Address(RVA = "0x33845B0", Offset = "0x33839B0", Length = "0x1DD")]
	[Token(Token = "0x60007C8")]
	public IntegerField() { }

	[Address(RVA = "0x33843B0", Offset = "0x33837B0", Length = "0x1F5")]
	[Token(Token = "0x60007C9")]
	public IntegerField(string label, int maxLength = 1000) { }

	[Address(RVA = "0x3383FC0", Offset = "0x33833C0", Length = "0xD7")]
	[Token(Token = "0x60007CB")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	[Address(RVA = "0x33840A0", Offset = "0x33834A0", Length = "0x21")]
	[Token(Token = "0x60007CA")]
	internal virtual bool CanTryParse(string textString) { }

	[Address(RVA = "0x3384790", Offset = "0x3383B90", Length = "0x7A")]
	[Token(Token = "0x60007C5")]
	private IntegerInput get_integerInput() { }

	[Address(RVA = "0x33840D0", Offset = "0x33834D0", Length = "0x113")]
	[Token(Token = "0x60007C7")]
	protected virtual int StringToValue(string str) { }

	[Address(RVA = "0x33841F0", Offset = "0x33835F0", Length = "0x9C")]
	[Token(Token = "0x60007C6")]
	protected virtual string ValueToString(int v) { }

}

