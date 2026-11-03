namespace System;

[ClassInterface(ClassInterfaceType::AutoDual (2))]
[ComVisible(True)]
[Token(Token = "0x20001C2")]
public class object
{

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6000FFC")]
	public Object() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000FFA")]
	public override bool Equals(object obj) { }

	[Address(RVA = "0x1F339B0", Offset = "0x1F32DB0", Length = "0x29")]
	[Token(Token = "0x6000FFB")]
	public static bool Equals(object objA, object objB) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001004")]
	private void FieldGetter(string typeName, string fieldName, ref object val) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001005")]
	private void FieldSetter(string typeName, string fieldName, object val) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000FFD")]
	protected override void Finalize() { }

	[Address(RVA = "0x20868D0", Offset = "0x2085CD0", Length = "0x5")]
	[Token(Token = "0x6000FFE")]
	public override int GetHashCode() { }

	[Address(RVA = "0x20868E0", Offset = "0x2085CE0", Length = "0x5")]
	[Token(Token = "0x6000FFF")]
	public Type GetType() { }

	[Address(RVA = "0x20868D0", Offset = "0x2085CD0", Length = "0x5")]
	[Token(Token = "0x6001003")]
	internal static int InternalGetHashCode(object o) { }

	[Address(RVA = "0x207D240", Offset = "0x207C640", Length = "0x5")]
	[Token(Token = "0x6001000")]
	protected object MemberwiseClone() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001002")]
	public static bool ReferenceEquals(object objA, object objB) { }

	[Address(RVA = "0x20868F0", Offset = "0x2085CF0", Length = "0x2E")]
	[Token(Token = "0x6001001")]
	public override string ToString() { }

}

