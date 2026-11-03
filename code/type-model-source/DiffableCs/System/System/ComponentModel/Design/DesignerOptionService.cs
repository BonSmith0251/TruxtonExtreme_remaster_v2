namespace System.ComponentModel.Design;

[Token(Token = "0x20001CE")]
public abstract class DesignerOptionService
{
	[DefaultMember("Item")]
	[Editor(null, "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[Token(Token = "0x20001CF")]
	[TypeConverter(typeof(DesignerOptionConverter))]
	internal sealed class DesignerOptionCollection : ICollection
	{
		[Token(Token = "0x20001D0")]
		private sealed class WrappedPropertyDescriptor : PropertyDescriptor
		{
			[FieldOffset(Offset = "0x88")]
			[Token(Token = "0x40006EA")]
			private object target; //Field offset: 0x88
			[FieldOffset(Offset = "0x90")]
			[Token(Token = "0x40006EB")]
			private PropertyDescriptor property; //Field offset: 0x90

			[Token(Token = "0x17000222")]
			public virtual AttributeCollection Attributes
			{
				[Address(RVA = "0x2697830", Offset = "0x2696C30", Length = "0x2D")]
				[Token(Token = "0x6000B8C")]
				 get { } //Length: 45
			}

			[Token(Token = "0x17000223")]
			public virtual Type ComponentType
			{
				[Address(RVA = "0x2697860", Offset = "0x2696C60", Length = "0x2D")]
				[Token(Token = "0x6000B8D")]
				 get { } //Length: 45
			}

			[Token(Token = "0x17000224")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x2697890", Offset = "0x2696C90", Length = "0x2D")]
				[Token(Token = "0x6000B8E")]
				 get { } //Length: 45
			}

			[Token(Token = "0x17000225")]
			public virtual Type PropertyType
			{
				[Address(RVA = "0x26978C0", Offset = "0x2696CC0", Length = "0x7D5")]
				[Token(Token = "0x6000B8F")]
				 get { } //Length: 2005
			}

			[Address(RVA = "0x26977A0", Offset = "0x2696BA0", Length = "0x84")]
			[Token(Token = "0x6000B8B")]
			internal WrappedPropertyDescriptor(PropertyDescriptor property, object target) { }

			[Address(RVA = "0x2697660", Offset = "0x2696A60", Length = "0x37")]
			[Token(Token = "0x6000B90")]
			public virtual bool CanResetValue(object component) { }

			[Address(RVA = "0x2697830", Offset = "0x2696C30", Length = "0x2D")]
			[Token(Token = "0x6000B8C")]
			public virtual AttributeCollection get_Attributes() { }

			[Address(RVA = "0x2697860", Offset = "0x2696C60", Length = "0x2D")]
			[Token(Token = "0x6000B8D")]
			public virtual Type get_ComponentType() { }

			[Address(RVA = "0x2697890", Offset = "0x2696C90", Length = "0x2D")]
			[Token(Token = "0x6000B8E")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x26978C0", Offset = "0x2696CC0", Length = "0x7D5")]
			[Token(Token = "0x6000B8F")]
			public virtual Type get_PropertyType() { }

			[Address(RVA = "0x26976A0", Offset = "0x2696AA0", Length = "0x37")]
			[Token(Token = "0x6000B91")]
			public virtual object GetValue(object component) { }

			[Address(RVA = "0x26976E0", Offset = "0x2696AE0", Length = "0x37")]
			[Token(Token = "0x6000B92")]
			public virtual void ResetValue(object component) { }

			[Address(RVA = "0x2697720", Offset = "0x2696B20", Length = "0x37")]
			[Token(Token = "0x6000B93")]
			public virtual void SetValue(object component, object value) { }

			[Address(RVA = "0x2697760", Offset = "0x2696B60", Length = "0x37")]
			[Token(Token = "0x6000B94")]
			public virtual bool ShouldSerializeValue(object component) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006E5")]
		private DesignerOptionService _service; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006E6")]
		private string _name; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006E7")]
		private object _value; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006E8")]
		private ArrayList _children; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006E9")]
		private PropertyDescriptorCollection _properties; //Field offset: 0x30

		[Token(Token = "0x1700021D")]
		public override int Count
		{
			[Address(RVA = "0x2681240", Offset = "0x2680640", Length = "0x37")]
			[Token(Token = "0x6000B83")]
			 get { } //Length: 55
		}

		[Token(Token = "0x1700021E")]
		public string Name
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000B84")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700021F")]
		public PropertyDescriptorCollection Properties
		{
			[Address(RVA = "0x2681280", Offset = "0x2680680", Length = "0x6FA")]
			[Token(Token = "0x6000B85")]
			 get { } //Length: 1786
		}

		[Token(Token = "0x17000220")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000B89")]
			private get { } //Length: 3
		}

		[Token(Token = "0x17000221")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
			[Token(Token = "0x6000B8A")]
			private get { } //Length: 4
		}

		[Address(RVA = "0x2681100", Offset = "0x2680500", Length = "0x56")]
		[Token(Token = "0x6000B86")]
		public override void CopyTo(Array array, int index) { }

		[Address(RVA = "0x2681160", Offset = "0x2680560", Length = "0x96")]
		[Token(Token = "0x6000B87")]
		private void EnsurePopulated() { }

		[Address(RVA = "0x2681240", Offset = "0x2680640", Length = "0x37")]
		[Token(Token = "0x6000B83")]
		public override int get_Count() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000B84")]
		public string get_Name() { }

		[Address(RVA = "0x2681280", Offset = "0x2680680", Length = "0x6FA")]
		[Token(Token = "0x6000B85")]
		public PropertyDescriptorCollection get_Properties() { }

		[Address(RVA = "0x2681200", Offset = "0x2680600", Length = "0x37")]
		[Token(Token = "0x6000B88")]
		public override IEnumerator GetEnumerator() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000B89")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6000B8A")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

	}

	[Token(Token = "0x20001D1")]
	public sealed class DesignerOptionConverter : TypeConverter
	{
		[Token(Token = "0x20001D2")]
		private class OptionPropertyDescriptor : PropertyDescriptor
		{
			[FieldOffset(Offset = "0x88")]
			[Token(Token = "0x40006EC")]
			private DesignerOptionCollection _option; //Field offset: 0x88

			[Token(Token = "0x17000226")]
			public virtual Type ComponentType
			{
				[Address(RVA = "0x268B880", Offset = "0x268AC80", Length = "0x20")]
				[Token(Token = "0x6000B9A")]
				 get { } //Length: 32
			}

			[Token(Token = "0x17000227")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
				[Token(Token = "0x6000B9B")]
				 get { } //Length: 3
			}

			[Token(Token = "0x17000228")]
			public virtual Type PropertyType
			{
				[Address(RVA = "0x268B880", Offset = "0x268AC80", Length = "0x20")]
				[Token(Token = "0x6000B9C")]
				 get { } //Length: 32
			}

			[Address(RVA = "0x268B830", Offset = "0x268AC30", Length = "0x49")]
			[Token(Token = "0x6000B99")]
			internal OptionPropertyDescriptor(DesignerOptionCollection option) { }

			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000B9D")]
			public virtual bool CanResetValue(object component) { }

			[Address(RVA = "0x268B880", Offset = "0x268AC80", Length = "0x20")]
			[Token(Token = "0x6000B9A")]
			public virtual Type get_ComponentType() { }

			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6000B9B")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x268B880", Offset = "0x268AC80", Length = "0x20")]
			[Token(Token = "0x6000B9C")]
			public virtual Type get_PropertyType() { }

			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[Token(Token = "0x6000B9E")]
			public virtual object GetValue(object component) { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x6000B9F")]
			public virtual void ResetValue(object component) { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x6000BA0")]
			public virtual void SetValue(object component, object value) { }

			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000BA1")]
			public virtual bool ShouldSerializeValue(object component) { }

		}


		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B98")]
		public DesignerOptionConverter() { }

		[Address(RVA = "0x2681980", Offset = "0x2680D80", Length = "0xCA")]
		[Token(Token = "0x6000B97")]
		public virtual object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, object value, Type destinationType) { }

		[Address(RVA = "0x2681A50", Offset = "0x2680E50", Length = "0x515")]
		[Token(Token = "0x6000B96")]
		public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, object value, Attribute[] attributes) { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000B95")]
		public virtual bool GetPropertiesSupported(ITypeDescriptorContext cxt) { }

	}


	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B82")]
	protected override void PopulateOptionCollection(DesignerOptionCollection options) { }

}

