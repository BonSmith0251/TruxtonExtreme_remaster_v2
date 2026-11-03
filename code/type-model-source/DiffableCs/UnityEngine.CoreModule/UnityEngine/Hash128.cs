namespace UnityEngine;

[NativeHeader("Runtime/Utilities/Hash128.h")]
[NativeHeader("Runtime/Export/Hashing/Hash128.bindings.h")]
[Token(Token = "0x200013F")]
[UsedByNativeCode]
public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128>
{
	[Token(Token = "0x4000412")]
	private const ulong kConst = 16045690984833335023; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000410")]
	internal ulong u64_0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000411")]
	internal ulong u64_1; //Field offset: 0x8

	[Token(Token = "0x1700026D")]
	public bool isValid
	{
		[Address(RVA = "0x3049A90", Offset = "0x3048E90", Length = "0x16")]
		[Token(Token = "0x6000F97")]
		 get { } //Length: 22
	}

	[Address(RVA = "0xE1C7E0", Offset = "0xE1BBE0", Length = "0x8")]
	[Token(Token = "0x6000F96")]
	public Hash128(ulong u64_0, ulong u64_1) { }

	[Address(RVA = "0x30491B0", Offset = "0x30485B0", Length = "0x8")]
	[Token(Token = "0x6000FA0")]
	public void Append(int val) { }

	[Address(RVA = "0x8152E0", Offset = "0x8146E0", Length = "0x55")]
	[Token(Token = "0x6000F9F")]
	public void Append(ref T val) { }

	[Address(RVA = "0x30491C0", Offset = "0x30485C0", Length = "0xDE")]
	[Token(Token = "0x6000FA4")]
	public override int CompareTo(object obj) { }

	[Address(RVA = "0x30492A0", Offset = "0x30486A0", Length = "0x4C")]
	[Token(Token = "0x6000F98")]
	public override int CompareTo(Hash128 rhs) { }

	[Address(RVA = "0x8154B0", Offset = "0x8148B0", Length = "0x73")]
	[Token(Token = "0x6000F9D")]
	public static Hash128 Compute(ref T val) { }

	[Address(RVA = "0x3049350", Offset = "0x3048750", Length = "0x32")]
	[Token(Token = "0x6000F9E")]
	public static Hash128 Compute(int val) { }

	[Address(RVA = "0x30492F0", Offset = "0x30486F0", Length = "0x60")]
	[FreeFunction("ComputeHash128FromScriptPointer", IsThreadSafe = True)]
	[Token(Token = "0x6000F9C")]
	private static void ComputeFromPtr(IntPtr data, int start, int count, int elemSize, ref Hash128 hash) { }

	[Address(RVA = "0x3049440", Offset = "0x3048840", Length = "0x28")]
	[Token(Token = "0x6000FA2")]
	public override bool Equals(Hash128 obj) { }

	[Address(RVA = "0x3049390", Offset = "0x3048790", Length = "0xA2")]
	[Token(Token = "0x6000FA1")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3049A90", Offset = "0x3048E90", Length = "0x16")]
	[Token(Token = "0x6000F97")]
	public bool get_isValid() { }

	[Address(RVA = "0x3049470", Offset = "0x3048870", Length = "0x2E")]
	[Token(Token = "0x6000FA3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30494F0", Offset = "0x30488F0", Length = "0xAC")]
	[FreeFunction("Hash128ToString", IsThreadSafe = True)]
	[Token(Token = "0x6000F9B")]
	private static string Hash128ToStringImpl(Hash128 hash) { }

	[Address(RVA = "0x30494A0", Offset = "0x30488A0", Length = "0x42")]
	[Token(Token = "0x6000FAD")]
	private static void Hash128ToStringImpl_Injected(in Hash128 hash, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3049AB0", Offset = "0x3048EB0", Length = "0x1D")]
	[Token(Token = "0x6000FA5")]
	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	[Address(RVA = "0x3049AD0", Offset = "0x3048ED0", Length = "0x2F")]
	[Token(Token = "0x6000FA8")]
	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	[Address(RVA = "0x3049B00", Offset = "0x3048F00", Length = "0x28")]
	[Token(Token = "0x6000FA6")]
	public static bool op_Inequality(Hash128 hash1, Hash128 hash2) { }

	[Address(RVA = "0x3049B30", Offset = "0x3048F30", Length = "0x14")]
	[Token(Token = "0x6000FA7")]
	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	[Address(RVA = "0x30495F0", Offset = "0x30489F0", Length = "0x1CF")]
	[FreeFunction("StringToHash128", IsThreadSafe = True)]
	[Token(Token = "0x6000F9A")]
	public static Hash128 Parse(string hashString) { }

	[Address(RVA = "0x30495A0", Offset = "0x30489A0", Length = "0x42")]
	[Token(Token = "0x6000FAC")]
	private static void Parse_Injected(ref ManagedSpanWrapper hashString, out Hash128 ret) { }

	[Address(RVA = "0x30497C0", Offset = "0x3048BC0", Length = "0x20")]
	[Token(Token = "0x6000FAB")]
	private static void Rot64(ref ulong x, int k) { }

	[Address(RVA = "0x30497E0", Offset = "0x3048BE0", Length = "0x142")]
	[Token(Token = "0x6000FAA")]
	private static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) { }

	[Address(RVA = "0x3049930", Offset = "0x3048D30", Length = "0x139")]
	[Token(Token = "0x6000FA9")]
	private void ShortHash4(uint data) { }

	[Address(RVA = "0x3049A70", Offset = "0x3048E70", Length = "0x1D")]
	[Token(Token = "0x6000F99")]
	public virtual string ToString() { }

}

