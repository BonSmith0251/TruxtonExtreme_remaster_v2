namespace System.Data;

[Token(Token = "0x2000053")]
public class DataViewManager : MarshalByValueComponent
{
	[Token(Token = "0x400019A")]
	private static NotSupportedException s_notSupported; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000198")]
	private DataViewSettingCollection _dataViewSettingsCollection; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000199")]
	internal int _nViews; //Field offset: 0x28

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	[Token(Token = "0x170000E7")]
	public DataViewSettingCollection DataViewSettings
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600053A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2334D70", Offset = "0x2334170", Length = "0x73")]
	[Token(Token = "0x600053B")]
	private static DataViewManager() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600053A")]
	public DataViewSettingCollection get_DataViewSettings() { }

}

