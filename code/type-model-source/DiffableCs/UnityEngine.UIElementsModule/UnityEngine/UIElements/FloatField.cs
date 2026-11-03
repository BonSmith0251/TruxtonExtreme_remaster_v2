namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000CD")]
public class FloatField : TextValueField<Single>
{
	[Token(Token = "0x20000D0")]
	private class FloatInput : TextValueInput<Single>
	{

		[Token(Token = "0x170000F2")]
		protected virtual string allowedCharacters
		{
			[Address(RVA = "0x333DDD0", Offset = "0x333D1D0", Length = "0xA6")]
			[Token(Token = "0x6000676")]
			 get { } //Length: 166
		}

		[Token(Token = "0x170000F1")]
		private FloatField parentFloatField
		{
			[Address(RVA = "0x333DE80", Offset = "0x333D280", Length = "0x71")]
			[Token(Token = "0x6000674")]
			private get { } //Length: 113
		}

		[Address(RVA = "0x333DD40", Offset = "0x333D140", Length = "0x8E")]
		[Token(Token = "0x6000675")]
		internal FloatInput() { }

		[Address(RVA = "0x333DB00", Offset = "0x333CF00", Length = "0x1A9")]
		[Token(Token = "0x6000677")]
		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

		[Address(RVA = "0x333DDD0", Offset = "0x333D1D0", Length = "0xA6")]
		[Token(Token = "0x6000676")]
		protected virtual string get_allowedCharacters() { }

		[Address(RVA = "0x333DE80", Offset = "0x333D280", Length = "0x71")]
		[Token(Token = "0x6000674")]
		private FloatField get_parentFloatField() { }

		[Address(RVA = "0x333DCB0", Offset = "0x333D0B0", Length = "0x39")]
		[Token(Token = "0x6000679")]
		protected virtual float StringToValue(string str) { }

		[Address(RVA = "0x333DCF0", Offset = "0x333D0F0", Length = "0x44")]
		[Token(Token = "0x6000678")]
		protected virtual string ValueToString(float v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000CE")]
	internal class UxmlFactory : UxmlFactory<FloatField, UxmlTraits>
	{

		[Address(RVA = "0x3346AA0", Offset = "0x3345EA0", Length = "0x39")]
		[Token(Token = "0x6000672")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000CF")]
	internal class UxmlTraits : TextValueFieldTraits<Single, UxmlFloatAttributeDescription>
	{

		[Address(RVA = "0x334B5E0", Offset = "0x334A9E0", Length = "0x39")]
		[Token(Token = "0x6000673")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x40003FD")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40003FE")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40003FF")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x170000F0")]
	private FloatInput floatInput
	{
		[Address(RVA = "0x333DA80", Offset = "0x333CE80", Length = "0x7A")]
		[Token(Token = "0x6000669")]
		private get { } //Length: 122
	}

	[Address(RVA = "0x333D580", Offset = "0x333C980", Length = "0x112")]
	[Token(Token = "0x6000671")]
	private static FloatField() { }

	[Address(RVA = "0x333D6A0", Offset = "0x333CAA0", Length = "0x1DD")]
	[Token(Token = "0x600066D")]
	public FloatField() { }

	[Address(RVA = "0x333D880", Offset = "0x333CC80", Length = "0x1F5")]
	[Token(Token = "0x600066E")]
	public FloatField(string label, int maxLength = 1000) { }

	[Address(RVA = "0x333D200", Offset = "0x333C600", Length = "0xD7")]
	[Token(Token = "0x6000670")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	[Address(RVA = "0x333D2E0", Offset = "0x333C6E0", Length = "0x21")]
	[Token(Token = "0x600066F")]
	internal virtual bool CanTryParse(string textString) { }

	[Address(RVA = "0x333DA80", Offset = "0x333CE80", Length = "0x7A")]
	[Token(Token = "0x6000669")]
	private FloatInput get_floatInput() { }

	[Address(RVA = "0x333D310", Offset = "0x333C710", Length = "0x115")]
	[Token(Token = "0x600066B")]
	protected virtual float StringToValue(string str) { }

	[Address(RVA = "0x333D430", Offset = "0x333C830", Length = "0xA7")]
	[Token(Token = "0x600066C")]
	internal virtual void UpdateValueFromText() { }

	[Address(RVA = "0x333D4E0", Offset = "0x333C8E0", Length = "0x9E")]
	[Token(Token = "0x600066A")]
	protected virtual string ValueToString(float v) { }

}

