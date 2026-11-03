namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x2000102")]
public class LongField : TextValueField<Int64>
{
	[Token(Token = "0x2000105")]
	private class LongInput : TextValueInput<Int64>
	{

		[Token(Token = "0x1700014A")]
		protected virtual string allowedCharacters
		{
			[Address(RVA = "0x3387840", Offset = "0x3386C40", Length = "0xA7")]
			[Token(Token = "0x60007F8")]
			 get { } //Length: 167
		}

		[Token(Token = "0x17000149")]
		private LongField parentLongField
		{
			[Address(RVA = "0x33878F0", Offset = "0x3386CF0", Length = "0x71")]
			[Token(Token = "0x60007F6")]
			private get { } //Length: 113
		}

		[Address(RVA = "0x33877B0", Offset = "0x3386BB0", Length = "0x8E")]
		[Token(Token = "0x60007F7")]
		internal LongInput() { }

		[Address(RVA = "0x3387430", Offset = "0x3386830", Length = "0x231")]
		[Token(Token = "0x60007F9")]
		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue) { }

		[Address(RVA = "0x3387670", Offset = "0x3386A70", Length = "0xA2")]
		[Token(Token = "0x60007FA")]
		private long ClampMinMaxLongValue(long niceDelta, long value) { }

		[Address(RVA = "0x3387840", Offset = "0x3386C40", Length = "0xA7")]
		[Token(Token = "0x60007F8")]
		protected virtual string get_allowedCharacters() { }

		[Address(RVA = "0x33878F0", Offset = "0x3386CF0", Length = "0x71")]
		[Token(Token = "0x60007F6")]
		private LongField get_parentLongField() { }

		[Address(RVA = "0x3387720", Offset = "0x3386B20", Length = "0x39")]
		[Token(Token = "0x60007FC")]
		protected virtual long StringToValue(string str) { }

		[Address(RVA = "0x3387760", Offset = "0x3386B60", Length = "0x43")]
		[Token(Token = "0x60007FB")]
		protected virtual string ValueToString(long v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000103")]
	internal class UxmlFactory : UxmlFactory<LongField, UxmlTraits>
	{

		[Address(RVA = "0x33912E0", Offset = "0x33906E0", Length = "0x39")]
		[Token(Token = "0x60007F4")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000104")]
	internal class UxmlTraits : TextValueFieldTraits<Int64, UxmlLongAttributeDescription>
	{

		[Address(RVA = "0x3392730", Offset = "0x3391B30", Length = "0xE4")]
		[Token(Token = "0x60007F5")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x40004EC")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40004ED")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40004EE")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x17000148")]
	private LongInput longInput
	{
		[Address(RVA = "0x33873B0", Offset = "0x33867B0", Length = "0x7A")]
		[Token(Token = "0x60007EC")]
		private get { } //Length: 122
	}

	[Address(RVA = "0x3386EB0", Offset = "0x33862B0", Length = "0x112")]
	[Token(Token = "0x60007F3")]
	private static LongField() { }

	[Address(RVA = "0x33871D0", Offset = "0x33865D0", Length = "0x1DD")]
	[Token(Token = "0x60007EF")]
	public LongField() { }

	[Address(RVA = "0x3386FD0", Offset = "0x33863D0", Length = "0x1F5")]
	[Token(Token = "0x60007F0")]
	public LongField(string label, int maxLength = 1000) { }

	[Address(RVA = "0x3386BE0", Offset = "0x3385FE0", Length = "0xD7")]
	[Token(Token = "0x60007F2")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue) { }

	[Address(RVA = "0x3386CC0", Offset = "0x33860C0", Length = "0x22")]
	[Token(Token = "0x60007F1")]
	internal virtual bool CanTryParse(string textString) { }

	[Address(RVA = "0x33873B0", Offset = "0x33867B0", Length = "0x7A")]
	[Token(Token = "0x60007EC")]
	private LongInput get_longInput() { }

	[Address(RVA = "0x3386CF0", Offset = "0x33860F0", Length = "0x115")]
	[Token(Token = "0x60007EE")]
	protected virtual long StringToValue(string str) { }

	[Address(RVA = "0x3386E10", Offset = "0x3386210", Length = "0x9D")]
	[Token(Token = "0x60007ED")]
	protected virtual string ValueToString(long v) { }

}

