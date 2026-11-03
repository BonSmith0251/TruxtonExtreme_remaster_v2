namespace System.ComponentModel;

[ComVisible(True)]
[Token(Token = "0x20001B3")]
public class TypeConverter
{
	[Token(Token = "0x20001B4")]
	internal abstract class SimplePropertyDescriptor : PropertyDescriptor
	{
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40006BB")]
		private Type componentType; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40006BC")]
		private Type propertyType; //Field offset: 0x90

		[Token(Token = "0x1700020F")]
		public virtual Type ComponentType
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[Token(Token = "0x6000AEE")]
			 get { } //Length: 8
		}

		[Token(Token = "0x17000210")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x268E010", Offset = "0x268D410", Length = "0x7E")]
			[Token(Token = "0x6000AEF")]
			 get { } //Length: 126
		}

		[Token(Token = "0x17000211")]
		public virtual Type PropertyType
		{
			[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
			[Token(Token = "0x6000AF0")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x268DF70", Offset = "0x268D370", Length = "0x9B")]
		[Token(Token = "0x6000AEC")]
		protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType) { }

		[Address(RVA = "0x268DF00", Offset = "0x268D300", Length = "0x66")]
		[Token(Token = "0x6000AED")]
		protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

		[Address(RVA = "0x268DC80", Offset = "0x268D080", Length = "0x14D")]
		[Token(Token = "0x6000AF1")]
		public virtual bool CanResetValue(object component) { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x6000AEE")]
		public virtual Type get_ComponentType() { }

		[Address(RVA = "0x268E010", Offset = "0x268D410", Length = "0x7E")]
		[Token(Token = "0x6000AEF")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6000AF0")]
		public virtual Type get_PropertyType() { }

		[Address(RVA = "0x268DDD0", Offset = "0x268D1D0", Length = "0x128")]
		[Token(Token = "0x6000AF2")]
		public virtual void ResetValue(object component) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000AF3")]
		public virtual bool ShouldSerializeValue(object component) { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x20001B5")]
	internal class StandardValuesCollection : ICollection, IEnumerable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006BD")]
		private ICollection values; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006BE")]
		private Array valueArray; //Field offset: 0x18

		[Token(Token = "0x17000212")]
		public int Count
		{
			[Address(RVA = "0x268E150", Offset = "0x268D550", Length = "0x65")]
			[Token(Token = "0x6000AF5")]
			 get { } //Length: 101
		}

		[Token(Token = "0x17000213")]
		public object Item
		{
			[Address(RVA = "0x268E270", Offset = "0x268D670", Length = "0xFA")]
			[Token(Token = "0x6000AF6")]
			 get { } //Length: 250
		}

		[Token(Token = "0x17000214")]
		private override int System.Collections.ICollection.Count
		{
			[Address(RVA = "0x268E150", Offset = "0x268D550", Length = "0x65")]
			[Token(Token = "0x6000AF9")]
			private get { } //Length: 101
		}

		[Token(Token = "0x17000215")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000AFA")]
			private get { } //Length: 3
		}

		[Token(Token = "0x17000216")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x6000AFB")]
			private get { } //Length: 3
		}

		[Address(RVA = "0x268E1C0", Offset = "0x268D5C0", Length = "0xAB")]
		[Token(Token = "0x6000AF4")]
		public StandardValuesCollection(ICollection values) { }

		[Address(RVA = "0x268E090", Offset = "0x268D490", Length = "0x67")]
		[Token(Token = "0x6000AF7")]
		public void CopyTo(Array array, int index) { }

		[Address(RVA = "0x268E150", Offset = "0x268D550", Length = "0x65")]
		[Token(Token = "0x6000AF5")]
		public int get_Count() { }

		[Address(RVA = "0x268E270", Offset = "0x268D670", Length = "0xFA")]
		[Token(Token = "0x6000AF6")]
		public object get_Item(int index) { }

		[Address(RVA = "0x268E100", Offset = "0x268D500", Length = "0x46")]
		[Token(Token = "0x6000AF8")]
		public IEnumerator GetEnumerator() { }

		[Address(RVA = "0x268E090", Offset = "0x268D490", Length = "0x67")]
		[Token(Token = "0x6000AFC")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x268E150", Offset = "0x268D550", Length = "0x65")]
		[Token(Token = "0x6000AF9")]
		private override int System.Collections.ICollection.get_Count() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000AFA")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000AFB")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0x268E100", Offset = "0x268D500", Length = "0x46")]
		[Token(Token = "0x6000AFD")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x40006B9")]
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior"; //Field offset: 0x0
	[Token(Token = "0x40006BA")]
	private static bool useCompatibleTypeConversion; //Field offset: 0x0

	[Token(Token = "0x1700020E")]
	private static bool UseCompatibleTypeConversion
	{
		[Address(RVA = "0x268F7E0", Offset = "0x268EBE0", Length = "0x41")]
		[Token(Token = "0x6000AC4")]
		private get { } //Length: 65
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000AEB")]
	public TypeConverter() { }

	[Address(RVA = "0x268E7D0", Offset = "0x268DBD0", Length = "0x19")]
	[Token(Token = "0x6000AC5")]
	public bool CanConvertFrom(Type sourceType) { }

	[Address(RVA = "0x268E760", Offset = "0x268DB60", Length = "0x6D")]
	[Token(Token = "0x6000AC6")]
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x268E7F0", Offset = "0x268DBF0", Length = "0x19")]
	[Token(Token = "0x6000AC7")]
	public bool CanConvertTo(Type destinationType) { }

	[Address(RVA = "0x268E810", Offset = "0x268DC10", Length = "0x4C")]
	[Token(Token = "0x6000AC8")]
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x268EA30", Offset = "0x268DE30", Length = "0x77")]
	[Token(Token = "0x6000AC9")]
	public object ConvertFrom(object value) { }

	[Address(RVA = "0x268EAB0", Offset = "0x268DEB0", Length = "0x65")]
	[Token(Token = "0x6000ACA")]
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x268E860", Offset = "0x268DC60", Length = "0x77")]
	[Token(Token = "0x6000ACB")]
	public object ConvertFromInvariantString(string text) { }

	[Address(RVA = "0x268E8E0", Offset = "0x268DCE0", Length = "0x85")]
	[Token(Token = "0x6000ACC")]
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	[Address(RVA = "0x2610B50", Offset = "0x260FF50", Length = "0x19")]
	[Token(Token = "0x6000ACF")]
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	[Address(RVA = "0x268EA00", Offset = "0x268DE00", Length = "0x2A")]
	[Token(Token = "0x6000ACD")]
	public object ConvertFromString(string text) { }

	[Address(RVA = "0x268E970", Offset = "0x268DD70", Length = "0x85")]
	[Token(Token = "0x6000ACE")]
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	[Address(RVA = "0x268EEA0", Offset = "0x268E2A0", Length = "0x2F")]
	[Token(Token = "0x6000AD0")]
	public object ConvertTo(object value, Type destinationType) { }

	[Address(RVA = "0x268EED0", Offset = "0x268E2D0", Length = "0x20E")]
	[Token(Token = "0x6000AD1")]
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Address(RVA = "0x268EB20", Offset = "0x268DF20", Length = "0x6C")]
	[Token(Token = "0x6000AD2")]
	public string ConvertToInvariantString(object value) { }

	[Address(RVA = "0x268EB90", Offset = "0x268DF90", Length = "0x7A")]
	[Token(Token = "0x6000AD3")]
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	[Address(RVA = "0x268ECF0", Offset = "0x268E0F0", Length = "0xB4")]
	[Token(Token = "0x6000AD6")]
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x268EC10", Offset = "0x268E010", Length = "0xDC")]
	[Token(Token = "0x6000AD4")]
	public string ConvertToString(object value) { }

	[Address(RVA = "0x268EDB0", Offset = "0x268E1B0", Length = "0xEC")]
	[Token(Token = "0x6000AD5")]
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000AD8")]
	public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	[Address(RVA = "0x268F0E0", Offset = "0x268E4E0", Length = "0x19")]
	[Token(Token = "0x6000AD7")]
	public object CreateInstance(IDictionary propertyValues) { }

	[Address(RVA = "0x268F7E0", Offset = "0x268EBE0", Length = "0x41")]
	[Token(Token = "0x6000AC4")]
	private static bool get_UseCompatibleTypeConversion() { }

	[Address(RVA = "0x268F100", Offset = "0x268E500", Length = "0x141")]
	[Token(Token = "0x6000AD9")]
	protected Exception GetConvertFromException(object value) { }

	[Address(RVA = "0x268F250", Offset = "0x268E650", Length = "0x185")]
	[Token(Token = "0x6000ADA")]
	protected Exception GetConvertToException(object value, Type destinationType) { }

	[Address(RVA = "0x268F3E0", Offset = "0x268E7E0", Length = "0x16")]
	[Token(Token = "0x6000ADB")]
	public bool GetCreateInstanceSupported() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000ADC")]
	public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	[Address(RVA = "0x268F420", Offset = "0x268E820", Length = "0x104")]
	[Token(Token = "0x6000ADD")]
	public PropertyDescriptorCollection GetProperties(object value) { }

	[Address(RVA = "0x268F530", Offset = "0x268E930", Length = "0x114")]
	[Token(Token = "0x6000ADE")]
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000ADF")]
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	[Address(RVA = "0x268F400", Offset = "0x268E800", Length = "0x16")]
	[Token(Token = "0x6000AE0")]
	public bool GetPropertiesSupported() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000AE1")]
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000AE3")]
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	[Address(RVA = "0x1E27040", Offset = "0x1E26440", Length = "0x16")]
	[Token(Token = "0x6000AE2")]
	public ICollection GetStandardValues() { }

	[Address(RVA = "0x217E220", Offset = "0x217D620", Length = "0x16")]
	[Token(Token = "0x6000AE4")]
	public bool GetStandardValuesExclusive() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000AE5")]
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	[Address(RVA = "0x268F650", Offset = "0x268EA50", Length = "0x16")]
	[Token(Token = "0x6000AE6")]
	public bool GetStandardValuesSupported() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000AE7")]
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	[Address(RVA = "0x268F670", Offset = "0x268EA70", Length = "0x19")]
	[Token(Token = "0x6000AE8")]
	public bool IsValid(object value) { }

	[Address(RVA = "0x268F690", Offset = "0x268EA90", Length = "0x10C")]
	[Token(Token = "0x6000AE9")]
	public override bool IsValid(ITypeDescriptorContext context, object value) { }

	[Address(RVA = "0x268F7A0", Offset = "0x268EBA0", Length = "0x38")]
	[Token(Token = "0x6000AEA")]
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, String[] names) { }

}

