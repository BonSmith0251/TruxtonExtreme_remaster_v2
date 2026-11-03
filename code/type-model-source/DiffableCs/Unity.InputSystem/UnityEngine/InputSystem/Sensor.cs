namespace UnityEngine.InputSystem;

[InputControlLayout(isGenericTypeOfDevice = True)]
[Token(Token = "0x20000AF")]
public class Sensor : InputDevice
{

	[Token(Token = "0x1700028C")]
	public float samplingFrequency
	{
		[Address(RVA = "0x29B1E80", Offset = "0x29B1280", Length = "0xD5")]
		[Token(Token = "0x60009C7")]
		 get { } //Length: 213
		[Address(RVA = "0x29B1F60", Offset = "0x29B1360", Length = "0x78")]
		[Token(Token = "0x60009C8")]
		 set { } //Length: 120
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x60009C9")]
	public Sensor() { }

	[Address(RVA = "0x29B1E80", Offset = "0x29B1280", Length = "0xD5")]
	[Token(Token = "0x60009C7")]
	public float get_samplingFrequency() { }

	[Address(RVA = "0x29B1F60", Offset = "0x29B1360", Length = "0x78")]
	[Token(Token = "0x60009C8")]
	public void set_samplingFrequency(float value) { }

}

