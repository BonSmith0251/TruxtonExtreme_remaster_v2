namespace Unity.XGamingRuntime;

[Token(Token = "0x200029B")]
public class XUserDeviceAssociationChange
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400071E")]
	internal APP_LOCAL_DEVICE_ID _deviceId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400071F")]
	internal XUserLocalId _oldUser; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000720")]
	internal XUserLocalId _newUser; //Field offset: 0x20

	[Token(Token = "0x170002ED")]
	public APP_LOCAL_DEVICE_ID DeviceId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D81")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000D82")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002EF")]
	public XUserLocalId NewUser
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000D85")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000D86")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002EE")]
	public XUserLocalId OldUser
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000D83")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000D84")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B84950", Offset = "0x2B83D50", Length = "0x128")]
	[Token(Token = "0x6000D7F")]
	internal XUserDeviceAssociationChange(XUserDeviceAssociationChange interop) { }

	[Address(RVA = "0x2B84A80", Offset = "0x2B83E80", Length = "0xD6")]
	[Token(Token = "0x6000D80")]
	public XUserDeviceAssociationChange() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000D81")]
	public APP_LOCAL_DEVICE_ID get_DeviceId() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000D85")]
	public XUserLocalId get_NewUser() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000D83")]
	public XUserLocalId get_OldUser() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000D82")]
	public void set_DeviceId(APP_LOCAL_DEVICE_ID value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000D86")]
	public void set_NewUser(XUserLocalId value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000D84")]
	public void set_OldUser(XUserLocalId value) { }

}

