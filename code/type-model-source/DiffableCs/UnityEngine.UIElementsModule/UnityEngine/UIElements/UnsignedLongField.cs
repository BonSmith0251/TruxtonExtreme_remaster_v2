namespace UnityEngine.UIElements;

[Token(Token = "0x200017A")]
public class UnsignedLongField : TextValueField<UInt64>
{
	[Token(Token = "0x200017D")]
	private class UnsignedLongInput : TextValueInput<UInt64>
	{

		[Token(Token = "0x17000201")]
		protected virtual string allowedCharacters
		{
			[Address(RVA = "0x33C3B30", Offset = "0x33C2F30", Length = "0xA7")]
			[Token(Token = "0x6000B6B")]
			 get { } //Length: 167
		}

		[Token(Token = "0x17000200")]
		private UnsignedLongField parentUnsignedLongField
		{
			[Address(RVA = "0x33C3BE0", Offset = "0x33C2FE0", Length = "0x71")]
			[Token(Token = "0x6000B69")]
			private get { } //Length: 113
		}

		[Address(RVA = "0x33C3AA0", Offset = "0x33C2EA0", Length = "0x8E")]
		[Token(Token = "0x6000B6A")]
		internal UnsignedLongInput() { }

		[Address(RVA = "0x33C3740", Offset = "0x33C2B40", Length = "0x228")]
		[Token(Token = "0x6000B6C")]
		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, ulong startValue) { }

		[Address(RVA = "0x33C3970", Offset = "0x33C2D70", Length = "0x94")]
		[Token(Token = "0x6000B6D")]
		private ulong ClampToMinMaxULongValue(long niceDelta, ulong value) { }

		[Address(RVA = "0x33C3B30", Offset = "0x33C2F30", Length = "0xA7")]
		[Token(Token = "0x6000B6B")]
		protected virtual string get_allowedCharacters() { }

		[Address(RVA = "0x33C3BE0", Offset = "0x33C2FE0", Length = "0x71")]
		[Token(Token = "0x6000B69")]
		private UnsignedLongField get_parentUnsignedLongField() { }

		[Address(RVA = "0x33C3A10", Offset = "0x33C2E10", Length = "0x39")]
		[Token(Token = "0x6000B6F")]
		protected virtual ulong StringToValue(string str) { }

		[Address(RVA = "0x33C3A50", Offset = "0x33C2E50", Length = "0x43")]
		[Token(Token = "0x6000B6E")]
		protected virtual string ValueToString(ulong v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200017B")]
	internal class UxmlFactory : UxmlFactory<UnsignedLongField, UxmlTraits>
	{

		[Address(RVA = "0x33C3D20", Offset = "0x33C3120", Length = "0x39")]
		[Token(Token = "0x6000B67")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200017C")]
	internal class UxmlTraits : TextValueFieldTraits<UInt64, UxmlUnsignedLongAttributeDescription>
	{

		[Address(RVA = "0x33C4C20", Offset = "0x33C4020", Length = "0x39")]
		[Token(Token = "0x6000B68")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x4000765")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4000766")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x4000767")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x170001FF")]
	private UnsignedLongInput unsignedLongInput
	{
		[Address(RVA = "0x33C36C0", Offset = "0x33C2AC0", Length = "0x7A")]
		[Token(Token = "0x6000B5F")]
		private get { } //Length: 122
	}

	[Address(RVA = "0x33C31C0", Offset = "0x33C25C0", Length = "0x112")]
	[Token(Token = "0x6000B66")]
	private static UnsignedLongField() { }

	[Address(RVA = "0x33C34E0", Offset = "0x33C28E0", Length = "0x1DD")]
	[Token(Token = "0x6000B62")]
	public UnsignedLongField() { }

	[Address(RVA = "0x33C32E0", Offset = "0x33C26E0", Length = "0x1F5")]
	[Token(Token = "0x6000B63")]
	public UnsignedLongField(string label, int maxLength = 1000) { }

	[Address(RVA = "0x33C2EF0", Offset = "0x33C22F0", Length = "0xD7")]
	[Token(Token = "0x6000B65")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, ulong startValue) { }

	[Address(RVA = "0x33C2FD0", Offset = "0x33C23D0", Length = "0x22")]
	[Token(Token = "0x6000B64")]
	internal virtual bool CanTryParse(string textString) { }

	[Address(RVA = "0x33C36C0", Offset = "0x33C2AC0", Length = "0x7A")]
	[Token(Token = "0x6000B5F")]
	private UnsignedLongInput get_unsignedLongInput() { }

	[Address(RVA = "0x33C3000", Offset = "0x33C2400", Length = "0x115")]
	[Token(Token = "0x6000B61")]
	protected virtual ulong StringToValue(string str) { }

	[Address(RVA = "0x33C3120", Offset = "0x33C2520", Length = "0x9D")]
	[Token(Token = "0x6000B60")]
	protected virtual string ValueToString(ulong v) { }

}

