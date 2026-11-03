namespace System.Threading;

[Token(Token = "0x2000229")]
public static class Monitor
{

	[Address(RVA = "0x20A1B70", Offset = "0x20A0F70", Length = "0x5")]
	[Token(Token = "0x6001283")]
	public static void Enter(object obj) { }

	[Address(RVA = "0x20A1AF0", Offset = "0x20A0EF0", Length = "0x79")]
	[Token(Token = "0x6001284")]
	public static void Enter(object obj, ref bool lockTaken) { }

	[Address(RVA = "0x20A1B80", Offset = "0x20A0F80", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001286")]
	public static void Exit(object obj) { }

	[Address(RVA = "0x20A1BA0", Offset = "0x20A0FA0", Length = "0x5")]
	[Token(Token = "0x600128D")]
	private static void Monitor_pulse(object obj) { }

	[Address(RVA = "0x20A1B90", Offset = "0x20A0F90", Length = "0x5")]
	[Token(Token = "0x600128F")]
	private static void Monitor_pulse_all(object obj) { }

	[Address(RVA = "0x20A1BB0", Offset = "0x20A0FB0", Length = "0x5")]
	[Token(Token = "0x600128C")]
	private static bool Monitor_test_synchronised(object obj) { }

	[Address(RVA = "0x20A1BC0", Offset = "0x20A0FC0", Length = "0x5")]
	[Token(Token = "0x6001291")]
	private static bool Monitor_wait(object obj, int ms) { }

	[Address(RVA = "0x20A1C40", Offset = "0x20A1040", Length = "0x67")]
	[Token(Token = "0x600128E")]
	private static void ObjPulse(object obj) { }

	[Address(RVA = "0x20A1BD0", Offset = "0x20A0FD0", Length = "0x67")]
	[Token(Token = "0x6001290")]
	private static void ObjPulseAll(object obj) { }

	[Address(RVA = "0x20A1CB0", Offset = "0x20A10B0", Length = "0xC5")]
	[Token(Token = "0x6001292")]
	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	[Address(RVA = "0x20A1E40", Offset = "0x20A1240", Length = "0xB5")]
	[Token(Token = "0x600128A")]
	public static void Pulse(object obj) { }

	[Address(RVA = "0x20A1D80", Offset = "0x20A1180", Length = "0xB5")]
	[Token(Token = "0x600128B")]
	public static void PulseAll(object obj) { }

	[Address(RVA = "0x20A1FB0", Offset = "0x20A13B0", Length = "0x6C")]
	[Token(Token = "0x6001295")]
	private static void ReliableEnter(object obj, ref bool lockTaken) { }

	[Address(RVA = "0x20A1F00", Offset = "0x20A1300", Length = "0xAB")]
	[Token(Token = "0x6001294")]
	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	[Address(RVA = "0x20A2020", Offset = "0x20A1420", Length = "0x6E")]
	[Token(Token = "0x6001285")]
	private static void ThrowLockTakenException() { }

	[Address(RVA = "0x20A2230", Offset = "0x20A1630", Length = "0x5")]
	[Token(Token = "0x6001293")]
	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	[Address(RVA = "0x20A2090", Offset = "0x20A1490", Length = "0x76")]
	[Token(Token = "0x6001287")]
	public static void TryEnter(object obj, ref bool lockTaken) { }

	[Address(RVA = "0x20A2110", Offset = "0x20A1510", Length = "0x114")]
	[Token(Token = "0x6001289")]
	public static bool Wait(object obj, int millisecondsTimeout) { }

	[Address(RVA = "0x20A2110", Offset = "0x20A1510", Length = "0x114")]
	[Token(Token = "0x6001288")]
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

}

