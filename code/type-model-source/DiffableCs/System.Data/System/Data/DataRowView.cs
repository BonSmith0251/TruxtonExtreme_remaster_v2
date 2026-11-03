namespace System.Data;

[DefaultMember("Item")]
[Token(Token = "0x2000046")]
public class DataRowView : ICustomTypeDescriptor, INotifyPropertyChanged
{
	[Token(Token = "0x4000162")]
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400015F")]
	private readonly DataView _dataView; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000160")]
	private readonly DataRow _row; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000161")]
	private bool _delayBeginEdit; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000163")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x28

	[Token(Token = "0x170000BF")]
	public DataView DataView
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600048C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C2")]
	public bool IsNew
	{
		[Address(RVA = "0x2320170", Offset = "0x231F570", Length = "0x22")]
		[Token(Token = "0x6000496")]
		 get { } //Length: 34
	}

	[Token(Token = "0x170000C1")]
	public DataRow Row
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000494")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C0")]
	private DataRowVersion RowVersionDefault
	{
		[Address(RVA = "0x23201A0", Offset = "0x231F5A0", Length = "0x58")]
		[Token(Token = "0x600048D")]
		private get { } //Length: 88
	}

	[Address(RVA = "0x23200F0", Offset = "0x231F4F0", Length = "0x76")]
	[Token(Token = "0x60004A4")]
	private static DataRowView() { }

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000489")]
	internal DataRowView(DataView dataView, DataRow row) { }

	[Address(RVA = "0x231F880", Offset = "0x231EC80", Length = "0x221")]
	[Token(Token = "0x6000492")]
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	[Address(RVA = "0x231FAB0", Offset = "0x231EEB0", Length = "0xB")]
	[Token(Token = "0x6000493")]
	public DataView CreateChildView(DataRelation relation) { }

	[Address(RVA = "0x231FAC0", Offset = "0x231EEC0", Length = "0x58")]
	[Token(Token = "0x6000495")]
	public override void EndEdit() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x600048A")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600048C")]
	public DataView get_DataView() { }

	[Address(RVA = "0x2320170", Offset = "0x231F570", Length = "0x22")]
	[Token(Token = "0x6000496")]
	public bool get_IsNew() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000494")]
	public DataRow get_Row() { }

	[Address(RVA = "0x23201A0", Offset = "0x231F5A0", Length = "0x58")]
	[Token(Token = "0x600048D")]
	private DataRowVersion get_RowVersionDefault() { }

	[Address(RVA = "0x231FB20", Offset = "0x231EF20", Length = "0x119")]
	[Token(Token = "0x6000490")]
	internal object GetColumnValue(DataColumn column) { }

	[Address(RVA = "0x231FC40", Offset = "0x231F040", Length = "0x2A")]
	[Token(Token = "0x600048B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x231FC70", Offset = "0x231F070", Length = "0x79")]
	[Token(Token = "0x600048E")]
	internal int GetRecord() { }

	[Address(RVA = "0x231FCF0", Offset = "0x231F0F0", Length = "0x79")]
	[Token(Token = "0x600048F")]
	internal bool HasRecord() { }

	[Address(RVA = "0x231FD70", Offset = "0x231F170", Length = "0x86")]
	[Token(Token = "0x6000497")]
	internal void RaisePropertyChangedEvent(string propName) { }

	[Address(RVA = "0x231FE00", Offset = "0x231F200", Length = "0xB6")]
	[Token(Token = "0x6000491")]
	internal void SetColumnValue(DataColumn column, object value) { }

	[Address(RVA = "0x231FEC0", Offset = "0x231F2C0", Length = "0x47")]
	[Token(Token = "0x6000498")]
	private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000499")]
	private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600049A")]
	private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600049B")]
	private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600049C")]
	private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600049D")]
	private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600049E")]
	private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	[Address(RVA = "0x231FF10", Offset = "0x231F310", Length = "0x47")]
	[Token(Token = "0x600049F")]
	private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	[Address(RVA = "0x231FF60", Offset = "0x231F360", Length = "0x47")]
	[Token(Token = "0x60004A0")]
	private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	[Address(RVA = "0x2320040", Offset = "0x231F440", Length = "0xA8")]
	[Token(Token = "0x60004A1")]
	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	[Address(RVA = "0x231FFB0", Offset = "0x231F3B0", Length = "0x8E")]
	[Token(Token = "0x60004A2")]
	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60004A3")]
	private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

