namespace System.ComponentModel;

[Token(Token = "0x200015A")]
public class ArrayConverter : CollectionConverter
{
	[Token(Token = "0x200015B")]
	private class ArrayPropertyDescriptor : SimplePropertyDescriptor
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40005FB")]
		private readonly int _index; //Field offset: 0x98

		[Address(RVA = "0x2640C70", Offset = "0x2640070", Length = "0xA1")]
		[Token(Token = "0x6000867")]
		public ArrayPropertyDescriptor(Type arrayType, Type elementType, int index) { }

		[Address(RVA = "0x2640AD0", Offset = "0x263FED0", Length = "0x7E")]
		[Token(Token = "0x6000868")]
		public virtual object GetValue(object instance) { }

		[Address(RVA = "0x2640B50", Offset = "0x263FF50", Length = "0x11A")]
		[Token(Token = "0x6000869")]
		public virtual void SetValue(object instance, object value) { }

	}


	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x6000866")]
	public ArrayConverter() { }

	[Address(RVA = "0x26406A0", Offset = "0x263FAA0", Length = "0x1A4")]
	[Token(Token = "0x6000863")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Address(RVA = "0x2640850", Offset = "0x263FC50", Length = "0x27A")]
	[Token(Token = "0x6000864")]
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000865")]
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

