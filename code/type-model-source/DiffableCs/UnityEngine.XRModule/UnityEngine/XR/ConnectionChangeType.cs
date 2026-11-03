namespace UnityEngine.XR;

[Token(Token = "0x2000008")]
internal enum ConnectionChangeType : uint
{
	Connected = 0,
	Disconnected = 1,
	ConfigChange = 2,
}

