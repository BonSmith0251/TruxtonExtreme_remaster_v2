namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[Token(Token = "0x200000C")]
[UsedByNativeCode]
public struct InputDevice : IEquatable<InputDevice>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004E")]
	private ulong m_DeviceId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400004F")]
	private bool m_Initialized; //Field offset: 0x8

	[Token(Token = "0x17000006")]
	private ulong deviceId
	{
		[Address(RVA = "0x3491AE0", Offset = "0x3490EE0", Length = "0x12")]
		[Token(Token = "0x600000B")]
		private get { } //Length: 18
	}

	[Address(RVA = "0x3491AD0", Offset = "0x3490ED0", Length = "0x8")]
	[Token(Token = "0x600000A")]
	internal InputDevice(ulong deviceId) { }

	[Address(RVA = "0x34919C0", Offset = "0x3490DC0", Length = "0xAA")]
	[Token(Token = "0x600000C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3491A70", Offset = "0x3490E70", Length = "0x25")]
	[Token(Token = "0x600000D")]
	public override bool Equals(InputDevice other) { }

	[Address(RVA = "0x3491AE0", Offset = "0x3490EE0", Length = "0x12")]
	[Token(Token = "0x600000B")]
	private ulong get_deviceId() { }

	[Address(RVA = "0x3491AA0", Offset = "0x3490EA0", Length = "0x2C")]
	[Token(Token = "0x600000E")]
	public virtual int GetHashCode() { }

}

