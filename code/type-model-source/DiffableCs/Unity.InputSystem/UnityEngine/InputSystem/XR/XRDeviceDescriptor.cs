namespace UnityEngine.InputSystem.XR;

[Token(Token = "0x20000F1")]
public class XRDeviceDescriptor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005A8")]
	public string deviceName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005A9")]
	public string manufacturer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005AA")]
	public string serialNumber; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005AB")]
	public InputDeviceCharacteristics characteristics; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40005AC")]
	public int deviceId; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005AD")]
	public List<XRFeatureDescriptor> inputFeatures; //Field offset: 0x30

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000C70")]
	public XRDeviceDescriptor() { }

	[Address(RVA = "0x29D1BC0", Offset = "0x29D0FC0", Length = "0x39")]
	[Token(Token = "0x6000C6F")]
	public static XRDeviceDescriptor FromJson(string json) { }

	[Address(RVA = "0xAC9290", Offset = "0xAC8690", Length = "0x7")]
	[Token(Token = "0x6000C6E")]
	public string ToJson() { }

}

