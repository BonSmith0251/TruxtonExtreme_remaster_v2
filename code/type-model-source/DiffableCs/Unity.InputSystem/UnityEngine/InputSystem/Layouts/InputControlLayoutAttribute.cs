namespace UnityEngine.InputSystem.Layouts;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False)]
[Token(Token = "0x2000210")]
public sealed class InputControlLayoutAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BBA")]
	private Type <stateType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BBB")]
	private string <stateFormat>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BBC")]
	private String[] <commonUsages>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BBD")]
	private string <variants>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BBE")]
	private bool <isNoisy>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000BBF")]
	internal Nullable<Boolean> canRunInBackgroundInternal; //Field offset: 0x31
	[FieldOffset(Offset = "0x33")]
	[Token(Token = "0x4000BC0")]
	internal Nullable<Boolean> updateBeforeRenderInternal; //Field offset: 0x33
	[CompilerGenerated]
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x4000BC1")]
	private bool <isGenericTypeOfDevice>k__BackingField; //Field offset: 0x35
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BC2")]
	private string <displayName>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BC3")]
	private string <description>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BC4")]
	private bool <hideInUI>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x1700059B")]
	public bool canRunInBackground
	{
		[Address(RVA = "0x2911590", Offset = "0x2910990", Length = "0x3A")]
		[Token(Token = "0x600138B")]
		 get { } //Length: 58
		[Address(RVA = "0x2911620", Offset = "0x2910A20", Length = "0x5B")]
		[Token(Token = "0x600138C")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000598")]
	public String[] commonUsages
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001385")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001386")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700059F")]
	public string description
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001393")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001394")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700059E")]
	public string displayName
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001391")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001392")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005A0")]
	public bool hideInUI
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001395")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001396")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700059D")]
	public bool isGenericTypeOfDevice
	{
		[Address(RVA = "0x29115D0", Offset = "0x29109D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600138F")]
		 get { } //Length: 5
		[Address(RVA = "0x2911680", Offset = "0x2910A80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001390")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700059A")]
	public bool isNoisy
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001389")]
		 get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600138A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000597")]
	public string stateFormat
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001383")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001384")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000596")]
	public Type stateType
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001381")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001382")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700059C")]
	public bool updateBeforeRender
	{
		[Address(RVA = "0x29115E0", Offset = "0x29109E0", Length = "0x3A")]
		[Token(Token = "0x600138D")]
		 get { } //Length: 58
		[Address(RVA = "0x2911690", Offset = "0x2910A90", Length = "0x5B")]
		[Token(Token = "0x600138E")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000599")]
	public string variants
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001387")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001388")]
		 set { } //Length: 13
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6001397")]
	public InputControlLayoutAttribute() { }

	[Address(RVA = "0x2911590", Offset = "0x2910990", Length = "0x3A")]
	[Token(Token = "0x600138B")]
	public bool get_canRunInBackground() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001385")]
	public String[] get_commonUsages() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001393")]
	public string get_description() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001391")]
	public string get_displayName() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001395")]
	public bool get_hideInUI() { }

	[Address(RVA = "0x29115D0", Offset = "0x29109D0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600138F")]
	public bool get_isGenericTypeOfDevice() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001389")]
	public bool get_isNoisy() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001383")]
	public string get_stateFormat() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001381")]
	public Type get_stateType() { }

	[Address(RVA = "0x29115E0", Offset = "0x29109E0", Length = "0x3A")]
	[Token(Token = "0x600138D")]
	public bool get_updateBeforeRender() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001387")]
	public string get_variants() { }

	[Address(RVA = "0x2911620", Offset = "0x2910A20", Length = "0x5B")]
	[Token(Token = "0x600138C")]
	public void set_canRunInBackground(bool value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001386")]
	public void set_commonUsages(String[] value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001394")]
	public void set_description(string value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001392")]
	public void set_displayName(string value) { }

	[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001396")]
	public void set_hideInUI(bool value) { }

	[Address(RVA = "0x2911680", Offset = "0x2910A80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001390")]
	public void set_isGenericTypeOfDevice(bool value) { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600138A")]
	public void set_isNoisy(bool value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001384")]
	public void set_stateFormat(string value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001382")]
	public void set_stateType(Type value) { }

	[Address(RVA = "0x2911690", Offset = "0x2910A90", Length = "0x5B")]
	[Token(Token = "0x600138E")]
	public void set_updateBeforeRender(bool value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001388")]
	public void set_variants(string value) { }

}

